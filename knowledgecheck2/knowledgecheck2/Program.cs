// See https://aka.ms/new-console-template for more information


public class Guitars
{
    public string brand = "Fender";
}

public class Electric : Guitars
{
    public string guitarModel = "Stratocaster";
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<Electric>();
        for (int i = 0; i < numberOfRecords; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()
            var Electric = new Electric();

            Console.WriteLine("Enter the value for brand ");
            Electric.brand = Console.ReadLine();
            Console.WriteLine("Enter the value for model ");
            Electric.guitarModel = Console.ReadLine();



            recordList.Add(Electric);
            Console.WriteLine(Electric.guitarModel);
            Console.WriteLine(Electric.brand);
        }

        // Print out the list of records using Console.WriteLine()



    }

}
