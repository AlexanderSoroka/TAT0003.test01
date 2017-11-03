using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Automobile
    {
       public AutomobileInfo information;
        public Automobile(AutomobileInfo info)
        {
            information = info;
        }

        public override string ToString()
        {
            StringBuilder line = new StringBuilder();
            line.Append("Mark: " + information.Mark);
            line.AppendLine();
            line.Append("Model: " + information.Model);
            line.AppendLine();
            line.Append("Type: " + information.Type);
            line.AppendLine();
            line.Append("Price: " + information.Price);
            line.AppendLine();
            return line.ToString();
        }
    }
}
