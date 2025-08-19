namespace Inheritance1;

// you have access to it, one moment:
// "INHERITANCE – CHEF AND ITALIAN CHEF
// Step 1: Define the Super Class and the SubClass.

class Chef //Super Class
{
 public void MakeChicken()
 {
   System.Console.WriteLine("The Chef makes chicken");
 }
 public void MakeSalad()
 {
   System.Console.WriteLine("The Chef makes salad");
 }
 public virtual void MakeSpecialDish()
 {
   System.Console.WriteLine("The Chef makes bbq ribs");
 }
}
 
class ItalianChef : Chef // ItalianChef is a Sub Class from the Chef Super Class
{
 public void makePasta()
 {
   System.Console.WriteLine("The Chef makes pasta");
 }
 public override void MakeSpecialDish()
 {
   System.Console.WriteLine("The Chef makes chicken parm");
 }
}
 
    // Step 2: Call Class to reflect Inheritance and to view Override.
    // Chef chef = new Chef();
    // chef.MakeSpecialDish();
    
    // ItalianChef aChef = new ItalianChef();
    // aChef.MakeSpecialDish();
    
    // Console.ReadLine();"