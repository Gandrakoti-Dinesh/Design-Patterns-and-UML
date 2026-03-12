namespace SecureDocs //Do NOT change the Namespace Name
{
    public class ProxyService : IDocumentAccess//Do NOT change the Class Name
    {   private AuthenticationRepo authenticationRepo;
        private DocumentService documentService;
        
        public ProxyService(){
            authenticationRepo=new AuthenticationRepo();
            documentService=new DocumentService();
        }
       // Implement your code here
       public string GetDocumentAccess(string documentId,string name){
            List<Employee> employees=authenticationRepo.GetAuthorizedEmployees();
            foreach (Employee emp in employees){
                if(emp.documentId==documentId && emp.employeeName==name){
                    return documentService.GetDocumentAccess(documentId,name);
                }
            }
        return "Unauthorized";
    }
}

}
