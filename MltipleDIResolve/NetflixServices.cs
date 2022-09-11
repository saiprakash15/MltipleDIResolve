using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MltipleDIResolve
{
    public class NetflixServices : IStreamService
    {
        public string[] ShowMovies()
        {
            return new string[]
            {
                "Netflix1",
                "Netflix2",
                "Netflix3",
                Guid.NewGuid().ToString()

            };
        }
    }
}
