using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handlers
{
    public class Validator
    {
        public static Boolean CheckTextBoxNull(String text)
        {
            return text == null || text == String.Empty;
        }
    }
}
