using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityRepository
{
    public class Rates
    {
        private string _country;
        private string _value;

        public string country
        {
            get { return this._country; }
            set { this._country = value; }
        }

        public string value
        {
            get { return this._value; }
            set { this._value = value; }
        }

    }
}
