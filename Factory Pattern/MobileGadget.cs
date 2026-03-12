namespace GadgetHub //Do NOT change the Namespace Name
{
    public class MobileGadget : Gadget //Do NOT change the Class Name
    {
       // Implement your code here
       public MobileGadget(string name){
           this.gadgetName=name;
           Console.WriteLine($"You have chosen Mobile Gadget and its name is {this.gadgetName}");
       }
    }
}
