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
        private static PageObjectManager _instance                                                  { get; set; }

        public PageObjectModel.MainView.North.MainNorth_InitClasses mainNorth_InitClasses           { get; set; }

        public PageObjectModel.MainView.Center.MainCenter_InitClasses mainCenter_InitClasses        { get; set; }

        public PageObjectModel.MainView.East.MainEast_Initclasses mainEast_Initclasses              { get; set; }

        public PageObjectModel.MainView.West.MainWest_InitClasses mainWest_InitClasses              { get; set; }

        public PageObjectModel.ExternalPages.External_InitClasses external_InitClasses              { get; set; }   

        public PageObjectModel.UserView.West.UserWest_InitClasses userWest_InitClasses              { get; set; }

        public PageObjectModel.UserView.Center.UserCenter_InitClasses userCenter_InitClasses        { get; set; }



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
                    _instance.mainNorth_InitClasses     = new PageObjectModel.MainView.North.MainNorth_InitClasses(TestConfigManager.Instance.driver);
                    _instance.mainCenter_InitClasses    = new PageObjectModel.MainView.Center.MainCenter_InitClasses(TestConfigManager.Instance.driver);
                    _instance.mainEast_Initclasses      = new PageObjectModel.MainView.East.MainEast_Initclasses(TestConfigManager.Instance.driver);
                    _instance.mainWest_InitClasses      = new PageObjectModel.MainView.West.MainWest_InitClasses(TestConfigManager.Instance.driver);
                    _instance.external_InitClasses      = new PageObjectModel.ExternalPages.External_InitClasses(TestConfigManager.Instance.driver);
                    _instance.userWest_InitClasses      = new PageObjectModel.UserView.West.UserWest_InitClasses(TestConfigManager.Instance.driver);
                    _instance.userCenter_InitClasses    = new PageObjectModel.UserView.Center.UserCenter_InitClasses(TestConfigManager.Instance.driver);
                }
                return _instance;
            }
        }
    }    
}
