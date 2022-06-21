namespace CurrencyConverter.App;

/// <summary>
/// Currency converter interface.
/// </summary>
public interface ICurrencyConverter
{
    /// <summary>
    /// Convert currency.
    /// </summary>
    /// <param name="currency"> Currency to convert. </param>
    /// <param name="convertTo"> Currency code to convert. </param>
    /// <returns> Converter currency. </returns>
    Currency Convert(Currency currency, CurrencyCode convertTo);

    /// <summary>
    /// Convert currency value.
    /// </summary>
    /// <param name="currency"> Currency to convert. </param>
    /// <param name="convertTo"> Currency code to convert. </param>
    /// <returns> Converted currency value. </returns>
    decimal ConvertValue(Currency currency, CurrencyCode convertTo);
}