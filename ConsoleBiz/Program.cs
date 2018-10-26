using EntityRepository;
using ServiceIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Exchange CEX = new Exchange();
            DollarRates CDR = CEX.GetCurrencyFromOpenExchangeRate();
            
            Console.WriteLine(CDR.rates["DKK"].ToString());

            foreach (var item in CDR.rates)
            {
                Console.WriteLine("{0} {1}", item.Key, item.Value);
            }

            foreach (var item in CDR.RateList)
            {
                Console.WriteLine("{0} {1}", item.country, item.value);
            }

            Console.ReadLine();

        }

    }
}
