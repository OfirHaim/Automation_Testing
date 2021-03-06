﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Configuration;


namespace IDobet_Automation_Test.PageObjectModel.MainView.West
{
    public class MainWest_InitClasses
    {
        public Left_Banners leftBanners { get; set; }

        public MainWest_InitClasses(IWebDriver driver)
        {
            leftBanners = new Left_Banners();
            
            PageFactory.InitElements(driver, this);
            PageFactory.InitElements(driver, leftBanners);
        }
    }
}
