using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Handlers
{
    public class Validator
    {
        public static Boolean CheckTextBoxNull(String text)
        {
            return text == null || text == String.Empty;
        }

        public static Boolean noPropertiesChoose(List<String> list)
        {
            return list.Count <= 0;
        }

        public static Boolean noFileChoose(List<String> items)
        {
            return items.Count <= 0;
        }
    }
}
