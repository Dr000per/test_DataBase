using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_DataBase
{
    public class NumCheck
    {
        public Boolean checknum(char e)
        {

            if (char.IsNumber(e))
            {
                return true;
            }

            return false;

        }
    }
}
