using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace repdemo.Models
{
    public interface IPersonRespository
    {
        List<Person> HentData();
    }
}
