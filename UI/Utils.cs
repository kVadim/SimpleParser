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

            if (cny_checkbox)
            {
                if (houbistring.Contains(ch))
                {
                    string partOfstring = houbistring.Substring(pos, houbistring.Length - pos);
                    double result = double.Parse(partOfstring, CultureInfo.InvariantCulture) / cny;
                    result = Math.Round(result, 2);
                    houbistring = result.ToString();
                }
                else
                {
                    double result = double.Parse(houbistring, CultureInfo.InvariantCulture) / cny;
                    result = Math.Round(result, 2);
                    houbistring = result.ToString();
                }
            }
            else
            {
                if (houbistring.Contains(ch))
                {
                    houbistring = houbistring.Substring(0, pos-1);
                }
                else
                {
                    houbistring = "99999";
                    
                }

            }

            return houbistring;
        }
    }
}
