namespace CurrencyConverter.App
{
    /// <summary>
    /// Currency class.
    /// </summary>
    public class Currency
    {
        private readonly ICurrencyConverter _currencyConverter;
        private decimal _value;

        /// <summary>
        /// Creates an instance of <see cref="Currency"/>.
        /// </summary>
        /// <param name="value"> Initial currency value. </param>
        /// <param name="code"> Currency code. </param>
        /// <param name="currencyConverter"> Currency converter. </param>
        public Currency(decimal value, CurrencyCode code, ICurrencyConverter currencyConverter)
        {
            _currencyConverter = currencyConverter;
            Value = value;
            Code = code;
        }

        /// <summary>
        /// Currency code.
        /// </summary>
        public CurrencyCode Code { get; }

        /// <summary>
        /// Currency value.
        /// </summary>
        /// <exception cref="ArgumentException"> Thrown when the value to be set is less than zero. </exception>
        public decimal Value
        {
            get => _value;
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Currency value is negative");

                _value = value;
            }
        }

        /// <summary>
        /// Add currency.
        /// </summary>
        /// <param name="currency"> Currency to add. </param>
        public void Add(Currency currency)
        {
            Value += _currencyConverter.ConvertValue(currency, Code);
        }

        /// <summary>
        /// Subtract currency.
        /// </summary>
        /// <param name="currency"> Currency to subtract. </param>
        public void Subtract(Currency currency)
        {
            Value -= _currencyConverter.ConvertValue(currency, Code);
        }
    }
}