using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace repdemo.Models
{
    public class PersonRepositoryData : IPersonRespository
    {

        public List<Person> HentData() {

            List<Person> l = new List<Person>();
            l.Add(new Person { Navn = "a" });
            l.Add(new Person { Navn = "b" });
            l.Add(new Person { Navn = "c" });
            return l;

        }

    }
}
