using System.Security.Cryptography.X509Certificates;

namespace SwitchCase1;

class Program //created a class and did switch/break
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.ShowMenuItem(0);
        menu.ShowMenuItem(1);
        menu.ShowMenuItem(2);
        menu.ShowMenuItem(3);
        menu.ShowMenuItem(5);

    }
}



class Menu
{

    public void ShowMenuItem(int itemCode)
    {
        switch (itemCode)
        {
            case 0:
            case 2:
                Console.WriteLine("Pizza");
                break;

            case 1:
                Console.WriteLine("Burger");
                break;

            case 3:
                Console.WriteLine("Salad");
                break;
            default:
                Console.WriteLine("Item not found");
                break;

        }
    }

}