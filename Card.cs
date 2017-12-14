using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarClasses
{
    public class Card
    {
        
        public string Suit { get; set; }
        public int Value { get; set; }

        public string Face
        {
            get

            {
                if (Value == 1)
                {
                    return "Ace";
                }
                else if (Value == 11)
                {
                    return "Jack";

                }

                else if (Value == 12)
                {
                    return "Queen";

                }
                else if (Value == 13)
                {
                    return "King";
                }
                else return Convert.ToString(Value);
            }
        }

        public string FullName()
        {
          
                return $"{Face} of {Suit}";

        }



    }
}

