using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meta
{
    public class Algorithm
    {
        public void Execute(Display[] displays)
        {
            for (int i = 0; i < 10; i++)
            {
                displays.ToList().ForEach(d => d.Write(i.ToString(CultureInfo.InvariantCulture)));
            }
        }
    }
}
