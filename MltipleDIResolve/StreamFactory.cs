using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MltipleDIResolve
{
    public class StreamFactory
    {
        private readonly IServiceProvider serviceProvider;
        public StreamFactory(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }
        public IStreamService GetStreamingService(string userselection)
        {
            if(userselection == "Netflix")
            {
              return (IStreamService)serviceProvider.GetService(typeof(NetflixServices));
                    //new NetflixServices();
            }

            if(userselection  == "AHA")
            {
                return (IStreamService)serviceProvider.GetService(typeof(AhaServices));
            }
                return  (IStreamService)serviceProvider.GetService(typeof(AmazonPrimeServices));
            //new AmazonPrimeServices();
        }
    }
}
