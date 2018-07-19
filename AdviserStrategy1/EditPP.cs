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
    class EditPP
    {



        IWebDriver driver;


        public object IJavascriptExecutor { get; private set; }
        /// public static ExtentReports extent;

        // public static ExtentTest test;

        [SetUp]
        public void startBrowser()
        // static void Main(string[] args)
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
        public void EditParaPlanner()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));


            //  Thread.Sleep(2000);


            //  driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_AdminLink']")).Click();
            driver.FindElement(By.XPath(".//*[@id='aspnetForm']/section[2]/section[1]/nav")).Click();
            Console.WriteLine("Black Ribbon");
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//a[contains(@title, 'Management')]")).Click();

            //  wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(@title, 'Management')]")));
            Console.WriteLine("Management");

            Thread.Sleep(1000);


            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_HyperLink9']")).Click();
            Console.WriteLine("Manage Staff");

            /*  driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_btnSearch']")).Click();
              Console.WriteLine("Click on Search");*/

            //  driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ClientName']")).SendKeys("Test1");

            IWebElement element1 = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ClientName']"));

            var EPPGname = System.Configuration.ConfigurationManager.AppSettings["PPgn"];
            Console.WriteLine(string.Format("PP is : ", EPPGname));
            element1.SendKeys(EPPGname);

            Console.WriteLine("Enter PP");
            Thread.Sleep(1000);
            var EPPSname = System.Configuration.ConfigurationManager.AppSettings["PPsn"];

            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_btnSearch']")).Click();
            Console.WriteLine("Click on Search");


            for (int i = 0; i <= 20; i++)
            {


                //    String ss = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_rgManageAR_ctl00__" + i + "']/td[2]")).Text;
                String gn = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_rgUsers_ctl00__" + i + "']/td[5]")).Text;

                //*[@id="ctl00_ctl00_cph1_cph1_rgUsers_ctl00__1"]/td[5]


                string s = ConfigurationManager.AppSettings["PPgn"];
                //  Assert.AreEqual(EPPGname, gn);
                if (s.Equals(gn))
                   
              //  if (!String.IsNullOrEmpty(s))
                {

                    Console.WriteLine("PPgn is:" + s);
                    String sn = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_rgUsers_ctl00__" + i + "']/td[6]")).Text;


                    string s1 = ConfigurationManager.AppSettings["PPsn"];
                    // if (!String.IsNullOrEmpty(s1))
                    if (s1.Equals(sn))

                    {

                        Console.WriteLine("Sur Name is:" + sn);


                        Console.WriteLine("Into Loop i is +" + i);


                        //    var im1 = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_rgUsers_ctl00__" + i + "']/td[6]"));



                        {

                            //  Console.WriteLine("Given Name is:" + sn);


                            //         Console.WriteLine("Into Loop i is +" + i);


                            var im1 = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_rgUsers_ctl00__" + i + "']/td[7]"));


                            Console.WriteLine("i value chk is +" + i);

                            im1.Click();

                            break;
                        }
                    }
                }

            }

                driver.FindElement(By.XPath(".//*[@id='roleslist']/div[5]/div/label/span")).Click();
                Console.WriteLine("Clicked Role as a Medico Research");
                driver.FindElement(By.XPath(" .//*[@id='AddStaffDetails']")).Click();
                Console.WriteLine("Click on Update");



           // }
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
