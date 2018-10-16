using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinNumerals
{
    class Program
    {
        static void Main(string[] args)
        {

            Data data = new Data();

            string number = data.GetData();
            string  valid = data.Validator(number);

           string value = data.RomanToDecimal(valid).ToString();

           data.PrintData(value);

        }
    }
}
