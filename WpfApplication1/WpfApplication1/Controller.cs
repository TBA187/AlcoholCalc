using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Controller
    {
        


        public List<Person> CreatePersons()
        {
            List<Person> personlist = new List<Person>();
            Person person1 = new Person();
            Person person2 = new Person();

            personlist.Add(person1);
            personlist.Add(person2);
            
            person1.Username = "Ivan123";
            person1.Password = "123ivan";
            person1.Gender = "Male";
            person1.Weight = 110;

            person2.Username = "Ida123";
            person2.Password = "123ida";
            person2.Gender = "Female";
            person2.Weight = 50;

            return personlist;
        }
               
    }
}
