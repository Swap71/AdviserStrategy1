using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdviserStrategy1
{
    class SearchAR
    {


        IWebDriver driver;


        public object IJavascriptExecutor { get; private set; }


        [SetUp]
        public void startBrowser()
       
        {


            var browser = System.Configuration.ConfigurationManager.AppSettings["Browser"];
            var Path = System.Configuration.ConfigurationManager.AppSettings["Path"];

            switch (browser)
            {
                case "IE":


                    driver = new InternetExplorerDriver(Path);
                    break;

                case "FF":

                    driver = new FirefoxDriver(Path);
                    break;


                case "CR":


                    driver = new ChromeDriver(Path);
                    break;
            }

            //  driver = new ChromeDriver("D:\\chromedriver_win32");
            //     driver.Navigate().GoToUrl("http://10.168.190.20/User/dashboard.aspx");
            //    driver.Navigate().GoToUrl("http:stellar11/User/dashboard.aspx");
            var url = System.Configuration.ConfigurationManager.AppSettings["url"];
            Console.WriteLine(string.Format("URL is : ", url));
            driver.Navigate().GoToUrl(url);

            IWebElement element = driver.FindElement(By.XPath(".//*[@id='ctl00_memberslogin_Login1_UserName']"));


            var SA_Username = System.Configuration.ConfigurationManager.AppSettings["SA_Username"];


            Console.WriteLine(string.Format("Given Name is : ", SA_Username));
            element.SendKeys(SA_Username);


            String Name = driver.FindElement(By.XPath(".//*[@id='ctl00_memberslogin_Login1_UserName']")).GetAttribute("value");

            Console.WriteLine("UserName Successfully Created :" + Name);


            Console.WriteLine("UserName1");
            driver.Manage().Window.Maximize();

            IWebElement element1 = driver.FindElement(By.XPath(".//*[@id='ctl00_memberslogin_Login1_Password']"));

            var SA_Passwrd = System.Configuration.ConfigurationManager.AppSettings["SA_Passwrd"];
            Console.WriteLine(string.Format("Password is : ", SA_Passwrd));
            element1.SendKeys(SA_Passwrd);



            IWebElement element2 = driver.FindElement(By.XPath(".//*[@id='ctl00_memberslogin_Login1_LoginButton']"));
            element2.Click();

        }

        [Test]
        public void SearchAR1()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));


            Thread.Sleep(1000);


            //  driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_AdminLink']")).Click();
            driver.FindElement(By.XPath(".//*[@id='aspnetForm']/section[2]/section[1]/nav")).Click();
            Console.WriteLine("Black Ribbon");
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//a[contains(@title, 'Management')]")).Click();

            //  wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(@title, 'Management')]")));
            Console.WriteLine("Management Clicked");

            Thread.Sleep(2000);

            //    

            //    
            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_HyperLinkAdminPlanners']")).Click();
            Console.WriteLine("Management Clicked");


            /*****  
              driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ClientName']")).SendKeys("FP130218AR");

              Console.WriteLine("Enter AR");*****/




            Thread.Sleep(2000);

            IWebElement element = driver.FindElement(By.Id("ctl00_ctl00_cph1_cph1_ClientName"));


            var SUserName = System.Configuration.ConfigurationManager.AppSettings["SUserName"];


            Console.WriteLine(string.Format("Given Name is : ", SUserName));
            element.SendKeys(SUserName);

            //  driver.FindElement(By.Id("ctl00_ctl00_cph1_cph1_ClientName")).SendKeys("tes");

            Console.WriteLine("Enter Search");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_btnSearch']")).Click();

            Console.WriteLine("Click on Search button");


            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_rgManageAR_ctl00_ctl04_hlJumpTo']")).Click();
/*
            for (int i = 0; i <= 25; i++)
            {


                //    String ss = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_rgManageAR_ctl00__" + i + "']/td[2]")).Text;
                String gn = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_rgManageAR_ctl00__"+i+"']/td[1]")).GetAttribute("Value");
                //*[@id="ctl00_ctl00_cph1_cph1_rgManageAR_ctl00__0"]/td[1]
                string s = ConfigurationManager.AppSettings["SUserName"];
                if (s.Equals(gn))
                {
                    Console.WriteLine("In Loop ,,Given Name is:" + gn);
                    //*[@id="ctl00_ctl00_cph1_cph1_rgManageOrphanAR_ctl00__1"]/td[1]
                 //   String sn = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_rgManageAR_ctl00__" + i + "']/td[2]")).Text;
                    //*[@id="ctl00_ctl00_cph1_cph1_rgManageAR_ctl00__0"]/td[4]

                    string s1 = ConfigurationManager.AppSettings["SGivenName"];
                    // if (!String.IsNullOrEmpty(s1))
                    if (s1.Equals(s))
                    //    if (sn == "sl")
                    {

                        Console.WriteLine("Given Name is:" + s);


                        Console.WriteLine("Into Loop i is +" + i);


                        var im1 = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_rgManageAR_ctl00__" + i + "']/td[4]"));


                        Console.WriteLine("i value chk is +" + i);

                        im1.Click();

                        break;
                    }
                }
                else
                    
                    driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_rgManageAR_ctl00']/tfoot/tr/td/table/tbody/tr/td/div[2]/a[2]/span")).Click();

                */
          //  }









        }

        //  return true;
        [TearDown]
        public void CloseBrowser()
        {
            // driver.Close();
            //  Base.driver.Close();

            // End test ans flush report
            /*  report.EndTest(test);
              report.Flush();*/
            /*      r1.EndTest(t1);
                  r1.Flush();*/
        }

    }
}
