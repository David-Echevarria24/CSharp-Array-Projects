namespace DataFormatting6;

class Program
{
    static void Main(string[] args)
    {
        const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";
        string quantity = "";
        string output = "";
        
       
        int spanStart = input.IndexOf("<span>") + "<span>".Length;
        int spanEnd = input.IndexOf("</span>");
        quantity = input.Substring(spanStart, spanEnd - spanStart);

       
        output = input.Replace("<div>", "").Replace("</div>", "").Replace("trade", "reg");

        Console.WriteLine($"Quantity: {quantity}");
        Console.WriteLine($"Output: {output}");

 
    }
}
