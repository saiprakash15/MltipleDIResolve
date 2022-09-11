using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MltipleDIResolve
{
    public class AhaServices : IStreamService
    {
        public string[] ShowMovies()
        {
            return new string[]
            {
                "AHA1",
                "AHA2",
                "AHA3",
                Guid.NewGuid().ToString()
            };
        }
    }
}
