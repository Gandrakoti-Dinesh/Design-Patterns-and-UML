namespace SecureDocs //Do NOT change the Namespace Name
{
    public class Program //Do NOT change the Class Name
    {
       public static void Main(string[] args) //Do NOT change the Method Signature
        {
           // Implement your code here
           Console.WriteLine("Enter the Employee name:");
           string name=Console.ReadLine();
           Console.WriteLine("Enter the Document Id:");
           string documentId=Console.ReadLine();
           IDocumentAccess access=new ProxyService();
           string result=access.GetDocumentAccess(documentId,name);
           Console.WriteLine(result);
        }
    }
}
