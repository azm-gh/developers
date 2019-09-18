namespace ExchangeRateUpdater
{
    public class ExchangeRate
    {
        public ExchangeRate(string sourceCurrency, string targetCurrency, decimal value)
        {
            SourceCurrency = sourceCurrency;
            TargetCurrency = targetCurrency;
            Value = value;
        }

        public string SourceCurrency { get; }

        public string TargetCurrency { get; }

        public decimal Value { get; }

        public override string ToString() => $"{SourceCurrency}/{TargetCurrency}={Value}";
    }
}
