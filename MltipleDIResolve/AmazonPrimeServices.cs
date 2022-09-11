using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MltipleDIResolve
{
    public class AmazonPrimeServices : IStreamService
    {
        public string[] ShowMovies()
        {
            return new string[]
            {
                "AmazonPrime1",
                "AmazonPrime2",
                "AmazonPrime3",
                Guid.NewGuid().ToString()
            };
        }
    }
}
