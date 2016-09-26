using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleParser01
{
    public class Driver
    {
        public static IWebDriver Initialize()
        {
             IWebDriver driver = new ChromeDriver();
             return driver;
        
        }

    }
}
