using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    public class Web
    {
        public string WebColor { get; private set; } = "grey";
        public void ChangeWebColor(string colour)
        {
            WebColor = colour;  
        }

    }
}
