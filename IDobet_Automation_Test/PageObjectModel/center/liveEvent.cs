using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDobet_Automation_Test.PageObjectModel.center
{
    class LiveEvent
    {
        public LiveEvent()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
    }
}
