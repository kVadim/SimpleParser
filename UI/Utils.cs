using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleParser01
{
    public static class Utils
    {

        public static string ParseHuobi(this string houbisting, char ch, double cny)
        {
            if (houbisting.Contains(ch))
            {
                houbisting = houbisting.Substring(0, 6);
            }
            else
            {

                double result = double.Parse(houbisting, CultureInfo.InvariantCulture)/cny;
                houbisting = "** " + result.ToString().Substring(0, 6) + " **";
            }
            return houbisting;
        }
    }
}
