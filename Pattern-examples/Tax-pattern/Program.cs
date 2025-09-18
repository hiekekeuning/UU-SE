
SalesOrder order123 = new() { Price = 10.75m, ItemNumber = 4 };
Country currCountry = Country.Can; // get from UI or file

CalcTax tax;
switch (currCountry)
{
    case Country.Can: 
        tax = new CanadianTax(); 
        break;
    case Country.NL: 
        tax = new NLTax(); 
        break;
    case Country.USA:
        //tax = new USATax(); 
    default: throw new NotImplementedException("no tax info for this country yet");
}

order123.TaxCalculator = tax;
order123.Process();


public enum Country { Can, USA, NL, Germany, Austria }

class SalesOrder
{
    public decimal Price { get; set; }
    public long ItemNumber { get; set; }

    public CalcTax TaxCalculator { get; set; }
    
    public void Process()
    {
        var p = Price + TaxCalculator.TaxAmount(ItemNumber, Price);
        Console.WriteLine(p);
    }
}

public abstract class CalcTax
{
    public abstract decimal TaxAmount(long itemSold, decimal price);
}

public class CanadianTax : CalcTax
{
    public override decimal TaxAmount(long itemSold, decimal price)
    {
        //..
        return 12.5m;
    }
}
public class NLTax : CalcTax
{
    public override decimal TaxAmount(long itemSold, decimal price)
    {
        //..
        return 21m;
    }
}

