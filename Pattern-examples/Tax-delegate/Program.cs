SalesOrder order123 = new() { Price = 10.75m, ItemNumber = 4 };
Country currCountry = Country.Can; // get from UI or file

TaxAmount tax;
switch (currCountry)
{
    case Country.Can:
        tax = Taxes.CanTax;
        break;
    case Country.NL:
        tax = Taxes.NLTax;
        break;
    case Country.USA:
        // USA tax
    default: throw new NotImplementedException("no tax info for this country yet");
}

order123.TaxCalculator = tax;
order123.Process();

public enum Country { Can, USA, NL, Germany, Austria }

class SalesOrder
{
    public decimal Price { get; set; }
    public long ItemNumber { get; set; }
    public TaxAmount TaxCalculator { get; set; }
    
    public void Process()
    {
        var tax = Price + TaxCalculator(ItemNumber, Price);
        Console.WriteLine(tax);
    }
}

public delegate decimal TaxAmount(long itemSold, decimal price);

public static class Taxes
{
    public static decimal CanTax(long itemSold, decimal price)
    {
        //..
        return 12.5m;
    }
    public static decimal NLTax(long itemSold, decimal price)
    {
        //..
        return 21m;
    }
}
