namespace SecureDocs //Do NOT change the Namespace Name
{
    public class DocumentService : IDocumentAccess //Do NOT change the Class Name
    {
       // Implement your code here
       public string GetDocumentAccess(string documentedId,string name){
           return name +"allowed to access the document.";
           
       }
    }
}
