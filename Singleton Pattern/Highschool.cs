using System;
namespace UAHighschool //Do NOT change the Namespace Name
{
    public class Highschool //Do NOT change the Class Name
    { 
        private static Highschool _instance;
        public string schoolName;
        private Highschool(){
            
        }
       
        // Implement your code here'
        public static Highschool GetSchoolInstance(){
            if(_instance == null){
                _instance=new Highschool();
            }
            return _instance;
        }
    }
}
