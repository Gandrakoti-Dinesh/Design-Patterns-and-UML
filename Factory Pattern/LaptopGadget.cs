namespace GadgetHub //Do NOT change the Namespace Name
{
    public class LaptopGadget : Gadget //Do NOT change the Class Name
    {
       // Implement your code here
       public LaptopGadget(string name){
           this.gadgetName=name;
           Console.WriteLine($"You have chosen Laptop Gadget and its name is {this.gadgetName}");
           
       }
    }
}
