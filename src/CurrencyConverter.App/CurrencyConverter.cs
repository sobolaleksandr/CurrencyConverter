namespace CurrencyConverter.App;

/// <summary>
/// Implementation of <see cref="ICurrencyConverter"/>.
/// </summary>
public class CurrencyConverter : ICurrencyConverter
{
    private readonly CurrencyExchangeService _currencyExchangeService;

    /// <summary>
    /// Creates an instance of <see cref="CurrencyConverter"/>.
    /// </summary>
    /// <param name="currencyExchangeService"> Currency exchange service. </param>
    public CurrencyConverter(CurrencyExchangeService currencyExchangeService)
    {
        _currencyExchangeService = currencyExchangeService;
    }

    /// <inheritdoc/>
    public Currency Convert(Currency currency, CurrencyCode convertTo)
    {
        return new Currency(ConvertValue(currency, convertTo), convertTo, this);
    }

    /// <inheritdoc/>
    public decimal ConvertValue(Currency currency, CurrencyCode convertTo)
    {
        return currency.Value * _currencyExchangeService.GetRate(currency.Code) /
               _currencyExchangeService.GetRate(convertTo);
    }
}