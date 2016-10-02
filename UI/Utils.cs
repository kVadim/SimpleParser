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

        public static string ParseHuobi(this string houbistring, char ch, double cny, bool cny_checkbox)
        {
            int pos = houbistring.LastIndexOf(ch) + 1;
           
                if (houbistring.Contains(ch))
                {
                    if (cny_checkbox)
                        {
                            string partOfstring = houbistring.Substring(pos, houbistring.Length - pos);
                            double result = double.Parse(partOfstring, CultureInfo.InvariantCulture) / cny;
                            result = Math.Round(result, 2);
                            houbistring = result.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
                        }
                        else
                        {
                            houbistring = houbistring.Substring(0, pos - 1);
                        }
                }
                else
                {
                    double result = double.Parse(houbistring, CultureInfo.InvariantCulture) / cny;
                    result = Math.Round(result, 2);
                    houbistring = result.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
                }
            return houbistring;
        }
    }
}
