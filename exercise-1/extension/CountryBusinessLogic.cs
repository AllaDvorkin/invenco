using core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace extension
{
    internal class CountryBusinessLogic : IBusinessLogic
    {
       
        public string GetWelcomeMessage()
        {
            string countryName = RegionInfo.CurrentRegion.EnglishName;
            return $"Hello Passport-X {countryName}";
        }

        public decimal CalculateMagicNumber(int input)
        {
            return input * 10 + 23 - 6 + 1;
        }
        
    }
}
