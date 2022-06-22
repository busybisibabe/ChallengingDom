using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace ChallengingDom.Hooks
{
    [Binding]
    public class WebHooks
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();

        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
            driver.Dispose();
            Kill("chromedriver");
        }

        public static void Kill(string processName)
        {
            Process[] runingProcesses = Process.GetProcesses();
            foreach (var process in runingProcesses)
            {
                if (process.ProcessName.Contains(processName))
                {
                    process.Kill();
                }
            }
        }
    }
}
