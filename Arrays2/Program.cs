namespace Arrays2;

class Program
{
    static void Main()
    {
        string[] orderIDs = new string[8];
        orderIDs[0] = "B123";
        orderIDs[1] = "C234";
        orderIDs[2] = "A345";
        orderIDs[3] = "C15";
        orderIDs[4] = "B177";
        orderIDs[5] = "G3003";
        orderIDs[6] = "C235";
        orderIDs[7] = "B179";


        foreach (string orderID in orderIDs)
        {
            if (orderID.StartsWith('B'))
            {
                Console.WriteLine(orderID);
            }
        }
    }
}
