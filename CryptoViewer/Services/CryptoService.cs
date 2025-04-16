using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CryptoViewer.Models;

namespace CryptoViewer.Services;

public class CryptoService
{
    private readonly HttpClient _httpClient = new();

    public async Task<List<CryptoCurrency>> GetPricesAsync()
    {
        var url = "https://api.coingecko.com/api/v3/simple/price?ids=bitcoin,ethereum,stellar&vs_currencies=usd,mxn&include_24hr_change=true";
        var response = await _httpClient.GetFromJsonAsync<Dictionary<string, CoinGeckoData>>(url);

        var result = new List<CryptoCurrency>();

        foreach (var item in response)
        {
            result.Add(new CryptoCurrency
            {
                Name = item.Key.ToUpper(),
                PriceUsd = item.Value.usd,
                PriceMxn = item.Value.mxn,
                Change24h = item.Value.usd_24h_change
            });
        }

        return result;
    }
}