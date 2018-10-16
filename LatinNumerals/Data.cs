using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinNumerals
{
    class Data
    {
        public string GetData()
        {
            Console.WriteLine("Proszę podac rzymską liczbę do przeliczenia");
            string text = Console.ReadLine();
            text = text.ToUpper();
            return text;
        }

        public void PrintData(string value)
        {
            if (value.Contains("-1"))
            {
                Console.WriteLine("Wprowadzono niewłaściwą wartość!");
            }
            else
            {
                Console.WriteLine($"Wartość dziesiętna wynosi :{value} ");
            }

        }

        public string Validator(string tocheck)
        {
            List<char> tovalidate = new List<char>();
            foreach( char letter in tocheck)
            {
                tovalidate.Add(letter);
            }
            int counter1 = 1;
            for (int i = 0; i<tovalidate.Count-1; i++)
            {
                    if (tovalidate[i] == tovalidate[i + 1])
                    {
                    counter1++;
                    }
                    else
                    {
                    counter1 = 0;
                    }
            }
            if(counter1 < 5)
            {
                return tocheck;
            }
            else return "0";
        }

        public bool Validator2(string tocheck)
        {
            List<char> tovalidate = new List<char>();
            foreach (char letter in tocheck)
            {
                tovalidate.Add(letter);
            }
            bool valid = false;
            for (int i = 0; i < tovalidate.Count - 1; i++)
            {
                if (tovalidate[i] == tovalidate[i + 1] && tovalidate[i] < tovalidate[i + 2])
                {
                    valid = false;
                }
                else
                {
                    valid = true;
                }
                return valid;
            }

            if (valid == true)
            {
                return true;
            }
            else return false;
        }



        // Returns decimal value of roman numeral 
        public int RomanToDecimal(string number)
        {
            // Initialize valueult 
            int value = 0;

            // Traverse given input 
            for (int i = 0; i < number.Length; i++)
            {
                // Getting value of symbol s[i] 
                int s1 = CharProcessor(number[i]);

                if (i + 1 < number.Length)
                {
                    // Getting value of symbol s[i+1] 
                    int s2 = CharProcessor(number[i + 1]);
                    

                    // Comparing both values 
                    if (s1 >= s2)
                    {
                        // Value of current symbol is greater 
                        // or equal to the next symbol 
                        value = value + s1;
                    }
                    else
                    {
                        value = value + s2 - s1;
                        i++; // Value of current symbol is 
                             // less than the next symbol 
                    }
                }
                else
                {
                    value = value + s1;
                    i++;
                }
            }
            return value;
        }

        public int CharProcessor(char sign)
        {
            switch (sign)
            {
                case 'I':
                    {
                        return 1;
                    }
                case 'V':
                    {
                        return 5;
                    }
                case 'X':
                    {
                        return 10;
                    }
                case 'D':
                    {
                        return 50;
                    }
                case 'C':
                    {
                        return 100;
                    }
                case 'L':
                    {
                        return 500;
                    }
                case 'M':
                    {
                        return 1000;
                    }
                default:
                    {
                        return -1;
                    }
            }
        }
    }
}

