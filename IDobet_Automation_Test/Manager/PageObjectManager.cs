using IDobet_Automation_Test.Configiruation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDobet_Automation_Test.TestCases
{
    public class PageObjectManager
    {
        private static PageObjectManager _instance                                      { get; set; }

        public PageObjectModel.North.North_InitClasses north_InitClasses                { get; set; }

        public PageObjectModel.Center.Center_InitClasses center_InitClasses             { get; set; }

        public PageObjectModel.East.East_Initclasses east_Initclasses                   { get; set; }

        public PageObjectModel.West.West_InitClasses west_InitClasses                   { get; set; }

        public PageObjectModel.ExternalPages.External_InitClasses external_InitClasses  { get; set; }


        private PageObjectManager()
        {
        }

        public static PageObjectManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PageObjectManager();
                    _instance.north_InitClasses     = new PageObjectModel.North.North_InitClasses(TestConfigManager.Instance.driver);
                    _instance.center_InitClasses    = new PageObjectModel.Center.Center_InitClasses(TestConfigManager.Instance.driver);
                    _instance.east_Initclasses      = new PageObjectModel.East.East_Initclasses(TestConfigManager.Instance.driver);
                    _instance.west_InitClasses      = new PageObjectModel.West.West_InitClasses(TestConfigManager.Instance.driver);
                    _instance.external_InitClasses  = new PageObjectModel.ExternalPages.External_InitClasses(TestConfigManager.Instance.driver);
                }
                return _instance;
            }
        }
    }    
}
