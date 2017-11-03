using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    struct Params
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Type
        {
            get
            {
                return Type;
            }
            set
            {
                if (Type != "sedan" || Type != "universal" || Type != "under")
                {
                    throw new Exception("You can't buy car with this type");
                }
                else
                {
                    this.Type = Type;
                }
            }
        }
        public double Prise { get; set; }
        }
    }
}
