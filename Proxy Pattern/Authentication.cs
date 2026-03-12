namespace SecureDocs //Do NOT change the Namespace Name
{
    public class AuthenticationRepo //Do NOT change the Class Name
    {
       // Implement your code here
       public List<Employee>GetAuthorizedEmployees(){
          
            return new List<Employee>{
               new Employee("D100","Alice"),
               new Employee("D101","Bob"),
               new Employee("D102","Charlie")
           };
            
       }
    }
}
