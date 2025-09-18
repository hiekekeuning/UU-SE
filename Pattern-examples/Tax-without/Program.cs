SalesOrder order123 = new() { Price = 10.75m, ItemNumber = 4 };
const Country currCountry = Country.Can; // get from config file
order123.Country = currCountry;
order123.Process();

public enum Country { Can, USA, NL, Germany, Austria }

public class SalesOrder
{
    public decimal Price { get; set; }
    public long ItemNumber { get; set; }

    public Country Country { get; set; }
    
    public void Process()
    {
        decimal tax;
        switch (Country)
        {
            case Country.Can: 
                // calculate tax based on ItemNumber, Price
                tax = 12.5m;
                break;
            case Country.NL:
                // calculate tax based on ItemNumber, Price
                tax = 21m; 
                break;
            default: throw new NotImplementedException("no tax info for this country yet");
        }
        
        Console.WriteLine(tax);
    }

    public void SpecialCase()
    {
        // logic...
        decimal tax;
        switch (Country)
        {
            case Country.Can: 
                // calculate tax based on ItemNumber, Price
                tax = 12.5m;
                break;
            case Country.NL:
                // calculate tax based on ItemNumber, Price
                tax = 21; 
                break;
            default: throw new NotImplementedException("no tax info for this country yet");
        }
        //...
    }
}
