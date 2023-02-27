using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_DataBase
{
    public class StringCheck
    {
        public Boolean StringIsValid(char str)
        {
            if (Regex.IsMatch(str.ToString(), @"\p{IsCyrillic}"))
            {
                return false;
            }
            return true;
        }
    }
}
