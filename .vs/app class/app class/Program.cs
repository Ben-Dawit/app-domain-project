using System;

namespace app_class
{
    class Program
    {
        static void Main(string[] args)
        {
           

        }
    }

    public abstract class user{
        public bool active=true;
        public string user_name;
       public  string password;

}
    public class administrator : user {

        public administrator(string user_name,string password) {
            this.user_name = user_name;
            this.password = password;
        }

        public accountant make_accountant() {

            Console.WriteLine("please enter the user name");
            string ID = Console.ReadLine();
            Console.WriteLine("please enter the password");
            string pass = Console.ReadLine();

            return new accountant(ID,pass);
        }

        public manager make_manger() {

            Console.WriteLine("please enter the user name");
            string ID = Console.ReadLine();
            Console.WriteLine("please enter the password");
            string pass = Console.ReadLine();

            return new manager(ID, pass);

        }
        
    }

    public class manager : user {
        public manager() { }
        public manager(string user_name, string password)
        {
            this.user_name = user_name;
            this.password = password;
            
        }
    }

    public class accountant : user {

        public accountant() { }
        public accountant(string user_name,string password ) {
            this.user_name = user_name;
            this.password = password;
            
        }
    }
}


