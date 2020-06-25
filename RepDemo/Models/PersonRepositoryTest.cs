using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace repdemo.Models
{
    public class PersonRepositoryTest : IPersonRespository
    {
        public List<Person> HentData()
        {

            List<Person> l = new List<Person>();
            for (int i = 0; i < 10; i++)
            {
                l.Add(new Person { Navn = i.ToString() }); 
            }
            return l;

        }
    }
}
