using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;


namespace hw2

{

    class Program

    {

        static void Main(string[] args)

        {

            var users = new List<Models.User>();



            StringBuilder passwordMessage = new StringBuilder();

            StringBuilder userMessage = new StringBuilder();

            StringBuilder nameMessage = new StringBuilder();





            users.Add(new Models.User { Name = "Dave", Password = "hello" });

            users.Add(new Models.User { Name = "Steve", Password = "steve" });

            users.Add(new Models.User { Name = "Lisa", Password = "hello" });



            IEnumerable<Models.User> passwordQuery =

                from person in users

                where person.Password == "hello"

                select person;



            //How would I accomplish this:"Display to the console, all the passwords that are "hello". Hint: Where"

            //without using the foreach loop below? I understand the linq part, but how would I use linq to

            //loop over the results to display each entry? Or am I OK using the foreach since I'm just doing it for display purspose?



            foreach (Models.User u in passwordQuery)
            {

                passwordMessage.Append(u.Name + " has password \"hello\"\n");

            }



            //Display each person who has the password "hello"

            Console.WriteLine(passwordMessage);



            //Remove people whose passwords are just lower case versions of their names

            users.RemoveAll((x) => x.Password == x.Name.ToLower());



            //Remove the first person with the password "hello"

            users.Remove(users.First((x) => x.Password == "hello"));



            //Build string to show remaining users in list

            foreach (Models.User u in users)

            {

                nameMessage.Append("Name: " + u.Name + ", Password: " + u.Password + "\n");

            }



            Console.WriteLine("Remaining user(s): " + nameMessage);

        }

    }

}