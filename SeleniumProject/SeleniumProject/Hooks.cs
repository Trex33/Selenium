using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject
{
    public class Hooks : Base
    {
        public Hooks()
        {
            Driver = new FirefoxDriver();
        }
    }
}
