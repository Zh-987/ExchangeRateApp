//using TrackingCzechExchangeRates.Application.DTOs;
using TrackingCzechExchangeRates.Core.DTOs;
using TrackingCzechExchangeRates.Infrastructure.Repositories;

namespace TrackingCzechExchangeRates.Application.Services
{
    public class CurrencyConverterService
    {
        private readonly HttpClient _httpClient;

        public CurrencyConverterService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
           
        }

        public async Task<List<CurrencyData>> GetCurrencyDataAsync(int year)
        {
            string url = $"https://www.cnb.cz/en/financial_markets/foreign_exchange_market/exchange_rate_fixing/year.txt?year={year}";

            try
            {
                var response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                var currencyDataList = ParseCurrencyData(content);

                return currencyDataList;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching currency data: {ex.Message}");
                throw;
            }
        }

        private List<CurrencyData> ParseCurrencyData(string content)
        {
            var lines = content.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            var currencyDataList = new List<CurrencyData>();

            // Get the header line to extract currency codes
            var headerLine = lines.FirstOrDefault();
            var currencyCodes = headerLine?.Split('|', StringSplitOptions.RemoveEmptyEntries).Skip(1).ToList() ?? new List<string>();

            foreach (var line in lines.Skip(1)) // Skip the header line
            {
                var values = line.Split('|', StringSplitOptions.RemoveEmptyEntries);

                if (values.Length >= 1) // Check if there is at least one element
                {
                    try
                    {
                        var currencyData = new CurrencyData
                        {
                            Date = DateTime.ParseExact(values[0], "dd.MM.yyyy", null),
                            CurrencyValues = new Dictionary<string, decimal>()
                        };

                        for (int i = 1; i < Math.Min(currencyCodes.Count + 1, values.Length); i++)
                        {
                            if (decimal.TryParse(values[i], out var currencyValue))
                            {
                                currencyData.CurrencyValues[currencyCodes[i - 1]] = currencyValue;
                            }
                            else
                            {
                                // Log a warning or handle the case where the currency value cannot be parsed
                                Console.WriteLine($"Invalid currency value: {values[i]} for currency code: {currencyCodes[i - 1]}");
                            }
                        }

                        currencyDataList.Add(currencyData);
                    }
                    catch (Exception ex)
                    {
                        // Log the content of the problematic line
                        Console.WriteLine($"Error parsing line: {line}, Error: {ex.Message}");
                    }
                }
                else
                {
                    // Log a warning or handle the case where the line is malformed
                    Console.WriteLine($"Malformed line: {line}");
                }
            }

            return currencyDataList;
        }
    }
}