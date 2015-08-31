using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class Login
    {
        private List<Person> persons;

        public Login()
        {
        }
        public bool Verify(string username, string password)
        {
            if (username == null || password == null)
            {
                throw new ArgumentNullException();
            }

            foreach (Person p in persons)
            {
                if (p.Username == username && p.Password == password)
                {
                    return true;
                }
            }

            return false;
        }
        public void SetUserSource(List<Person> source)
        {
            persons = source;
        }
    }
}
