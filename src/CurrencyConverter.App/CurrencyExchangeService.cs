namespace CurrencyConverter.App;

/// <summary>
/// Currency exchange service.
/// </summary>
public class CurrencyExchangeService
{
    /// <summary>
    /// Get currency rate.
    /// </summary>
    /// <param name="code"> Currency code. </param>
    /// <returns> Currency rate. </returns>
    /// <exception cref="NotSupportedException"> Thrown when currency code is not supported.</exception>
    public decimal GetRate(CurrencyCode code)
    {
        return code switch
        {
            CurrencyCode.Eur => 1.05m,
            CurrencyCode.Rub => 0.018m,
            CurrencyCode.Dollar => 1m,
            _ => throw new NotSupportedException($"Not supported currency type {code}"),
        };
    }
}