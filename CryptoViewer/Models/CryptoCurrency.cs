namespace CryptoViewer.Models;

public class CryptoCurrency
{
    public string Name { get; set; } = string.Empty;
    public decimal PriceUsd { get; set; }
    public decimal PriceMxn { get; set; }
    public decimal Change24h { get; set; }
}