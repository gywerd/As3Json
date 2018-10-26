using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityRepository
{


    public class DollarRates
    {
        private List<Rates> rateList;
        private string _disclaimer;
        private string _licence;
        private string _timestamp;
        private string _base;
        private Dictionary<string, decimal> _rates;

        public DollarRates()
        {
        }

        public void FillListWithDollarRates()
        {
            List<Rates> ld = new List<Rates>();
            foreach (var item in _rates)
            {
                Rates cd = new Rates();
                cd.country = item.Key;
                cd.value = item.Value.ToString();
                ld.Add(cd);
            }

            rateList = ld;
        }

        public List<Rates> RateList
        {
            get { return this.rateList; }
            set { this.rateList = value; }
        }

        public string disclaimer
        {
            get { return this._disclaimer; }
            set { this._disclaimer = value; }
        }

        public string licence
        {
            get { return this._licence; }
            set { this._licence = value; }
        }


        public string timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        public string @base
        {
            get { return this._base; }
            set { this._base = value; }
        }

        public Dictionary<string, decimal> rates
        {
            get { return this._rates; }
            set
            {
                if (value != _rates)
                {
                    this._rates = value;
                    FillListWithDollarRates();
                }
            }
        }
    }
}
