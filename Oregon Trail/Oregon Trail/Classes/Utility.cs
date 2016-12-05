using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLog.Log;


namespace Oregon_Trail.Classes
{
    public static class Utility
    {
        public static bool toBool(int number)
        {
            bool result = false;
            switch (number)
            {
                case 1:
                    result = true;
                    break;
                case 0:
                    result = false;
                    break;
            }
            return result;
        }

        public static int toInt(string strings)
        {
            int result = 1;
            try
            {
                int.TryParse(strings, out result);
            }
            catch (Exception e)
            {

            }

            return result;
        }

        private static bool result;

        public static bool BoolParse(int num)
        {
            switch(num)
            {
                case 1:
                    result = true;
                    break;
                case 0:
                    result = false;
                    break;
            }
            return result;
        }

        public static double intToDouble(int num)
        {
            double result = (double)num;
            return result;
        }
    }
}
