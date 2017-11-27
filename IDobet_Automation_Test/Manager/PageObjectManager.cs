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
        private static PageObjectManager _instance { get; set; }

        public PageObjectModel.North.TopBar topBar { get; set; }

        public PageObjectModel.Center.CenterFireScrollBar centerFireScrollBar { get; set; }

        public PageObjectModel.East.EastFireScrollBar eastFireScrollBar { get; set; }

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
                    _instance.topBar = new PageObjectModel.North.TopBar(TestConfigManager.Instance.driver);
                    _instance.centerFireScrollBar = new PageObjectModel.Center.CenterFireScrollBar(TestConfigManager.Instance.driver);
                    _instance.eastFireScrollBar = new PageObjectModel.East.EastFireScrollBar(TestConfigManager.Instance.driver);
                }
                return _instance;
            }
        }
    }    
}
