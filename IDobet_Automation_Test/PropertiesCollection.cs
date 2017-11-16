using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDobet_Automation_Test
{
    enum PropertyType
    {
        Id,
        Name,
        LinqText,
        CssName,
        ClassName
    }

    class PropertiesCollection
    {
        //Auto implemant Property
            public static IWebDriver driver { get; set; }
    }
}
