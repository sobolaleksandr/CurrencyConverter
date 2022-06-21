using CurrencyConverter.App;

var currencyExchangeService = new CurrencyExchangeService();
ICurrencyConverter currencyConverter = new CurrencyConverter.App.CurrencyConverter(currencyExchangeService);
var euro = new Currency(100, CurrencyCode.Eur, currencyConverter);
var ruble = new Currency(100, CurrencyCode.Rub, currencyConverter);

euro.Add(ruble);
if (decimal.Round(euro.Value, 2) != 101.71m)
    throw new Exception("Add function failure");

euro.Subtract(ruble);
if (decimal.Round(euro.Value, 2) != 100m)
    throw new Exception("Subtract function failure");

var convertedCurrency = currencyConverter.Convert(ruble, CurrencyCode.Eur);
if (decimal.Round(convertedCurrency.Value, 2) != 1.71m || convertedCurrency.Code != CurrencyCode.Eur)
    throw new Exception("Convert function failure");

// To add a new currency, you need to add it to CurrencyCode,
// and also create a new case in switch section of CurrencyExchangeService
var dollar = new Currency(100, CurrencyCode.Dollar, currencyConverter);
euro.Add(dollar);
if (decimal.Round(euro.Value, 2) != 195.24m)
    throw new Exception("Add function failure");

Console.WriteLine("Application is working");