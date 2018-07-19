using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdviserStrategy1
{
    class AddPP
    {
        IWebDriver driver;


        public object IJavascriptExecutor { get; private set; }
        /// public static ExtentReports extent;

        // public static ExtentTest test;

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
        public void AddParaPlanner()
        {


            //   Thread.Sleep(2000);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));


            Thread.Sleep(2000);


            //  driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_AdminLink']")).Click();
            driver.FindElement(By.XPath(".//*[@id='aspnetForm']/section[2]/section[1]/nav")).Click();
            Console.WriteLine("Black Ribbon");
            Thread.Sleep(2000);


            driver.FindElement(By.XPath("//a[contains(@title, 'Management')]")).Click();

            //  wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(@title, 'Management')]")));
            Console.WriteLine("Management Clicked");





            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_HyperLink9']")).Click();

            //  wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(@title, 'Management')]")));
            Console.WriteLine("Manage Staff");



            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_btnMemberAdd']")).Click();



            driver.FindElement(By.XPath(".//*[@id='txtUserName']")).Clear();

            IWebElement element3 = driver.FindElement(By.XPath(".//*[@id='txtUserName']"));

            var pptxtUserName = System.Configuration.ConfigurationManager.AppSettings["pptxtUserName"];
            Console.WriteLine(string.Format("Password is : ", pptxtUserName));
            element3.SendKeys(pptxtUserName);

            //    driver.FindElement(By.XPath(".//*[@id='txtUserName']")).SendKeys("FP140218PPSL");
            Console.WriteLine("Enter AR");

            driver.FindElement(By.ClassName("switch-knob")).Click();
            Console.WriteLine("Disable FF");

            Thread.Sleep(2000);


            driver.FindElement(By.XPath(".//*[@id='roleslist']/div[1]/div/label/span")).Click();
            Console.WriteLine("Advice Tech Super");




            driver.FindElement(By.XPath(".//*[@id='roleslist']/div[2]/div/label/span")).Click();
            Console.WriteLine("Management");



            driver.FindElement(By.XPath(".//*[@id='roleslist']/div[3]/div/label/span")).Click();
            Console.WriteLine("Team Lead");


            driver.FindElement(By.XPath(".//*[@id='GivenName']")).Clear();
            //  driver.FindElement(By.XPath(".//*[@id='GivenName']")).SendKeys("Test");

            IWebElement element4 = driver.FindElement(By.XPath(".//*[@id='GivenName']"));

            var ppgn = System.Configuration.ConfigurationManager.AppSettings["ppgn"];
            Console.WriteLine(string.Format("Password is : ", ppgn));
            element4.SendKeys(ppgn);




            driver.FindElement(By.XPath(".//*[@id='Surname']")).Clear();
            //    driver.FindElement(By.XPath(".//*[@id='Surname']")).SendKeys("Para");

            IWebElement element5 = driver.FindElement(By.XPath(".//*[@id='Surname']"));

            var ppsn = System.Configuration.ConfigurationManager.AppSettings["ppsn"];
            Console.WriteLine(string.Format("Password is : ", ppsn));
            element5.SendKeys(ppsn);





            driver.FindElement(By.XPath(".//*[@id='Email']")).Clear();
            //    driver.FindElement(By.XPath(".//*[@id='Email']")).SendKeys("swapnil.landge@stellarconsultants.co.in");

            IWebElement element6 = driver.FindElement(By.XPath(".//*[@id='Email']"));

            var ppe = System.Configuration.ConfigurationManager.AppSettings["ppe"];
            Console.WriteLine(string.Format("Password is : ", ppe));
            element6.SendKeys(ppe);

            driver.FindElement(By.XPath("//*[@id='Hero360WorkPhone']")).Clear();
            //  driver.FindElement(By.XPath(".//*[@id='Phone']")).SendKeys("0487961254");
            //*[@id="Hero360WorkPhone"]
            IWebElement element7 = driver.FindElement(By.XPath("//*[@id='Hero360WorkPhone']"));
            var phone = System.Configuration.ConfigurationManager.AppSettings["phone"];
            Console.WriteLine(string.Format("Password is : ", phone));
            element7.SendKeys(phone);



            driver.FindElement(By.XPath(".//*[@id='AddStaffDetails']")).Click();
            Console.WriteLine("Add");

            Thread.Sleep(5000);

            // String msg = driver.FindElement(By.CssSelector("body")).Text;
            String msg = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ctl00_pnlStaff']/div[4]/div[2]/span")).Text;
            Console.WriteLine("Message is :" + msg);

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement element = driver.FindElement(By.XPath(".//*[@id='aspnetForm']/section[2]/section[2]/section[1]/section/footer/div"));
            //     ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView();"
            //                                                        , element);

            js.ExecuteScript("arguments[0].scrollIntoView();", element);
            //     Assert.IsTrue(msg.Contains("Successfully created new Staff Member"), msg + " doesn't contains 'msg.'");
            //  Assert.IsTrue(msg.Contains("Successfully"), msg + " doesn't contains 'msg.'");
            Assert.IsTrue(msg.Contains("Saving"), msg + " doesn't contains 'msg.'");
            /*
                        driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_HyperLinkAdminPlanners']/span")).Click();
                        Console.WriteLine("Add a New AR");

                        driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_hlJumpTo']")).Click();
                        Console.WriteLine("AR Details");



                        driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_hlARDetails']")).Click();
                        Console.WriteLine("Clicked on AR Details");


                        Thread.Sleep(2000);




                        driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_txtNumber']")).Clear();

                        driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_txtNumber']")).SendKeys("5465");


                        driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_txtUserName']")).Clear();

                        driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_txtUserName']")).SendKeys("FP130218ARSDL1");
                        Console.WriteLine("Enter AR");

                        //      Console.WriteLine("Add New AR Clicked");

                        driver.FindElement(By.ClassName("switch-knob")).Click();
                        Console.WriteLine("Disable FF");

                        Thread.Sleep(2000);

                        driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_GivenName']")).Clear();
                        // driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_GivenName']")).SendKeys("Zak");
                        driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_GivenName']")).SendKeys("tes1");
                        Console.WriteLine("Enter GN");


                        driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_Surname']")).Clear();
                        driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_Surname']")).SendKeys("H");
                        Console.WriteLine("Enter SN");


                        driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_Email']")).Clear();
                        driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_Email']")).SendKeys("swapnil.landge@stellarconsultants.co.in");
                        Console.WriteLine("Enter Email");

                        driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_btnUpdate']")).Click();
                        Console.WriteLine("Click on ADD");

                        driver.FindElement(By.XPath("//a[contains(@title, 'Search client')]")).Click();
                        Console.WriteLine("Click on Search Client");

                        /*  wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_pnlContactInfo']/div[3]/table/tbody/tr[2]/td")));
                          Console.WriteLine("GN");
                          var gn = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_GivenName']"));
                          gn.Click();
                          Console.WriteLine("GN");*/





            /*****     driver.FindElement(By.XPath(".//*[@id='ctl00_repProducts_ctl11_hlJumpTo']/span")).Click();****/
            /**    wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='ctl00_ctl00_MainMenu']")));**/
            /*       wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='ctl00_ctl00_PanelLoggedIn']/aside")));
                   Console.WriteLine("Panel");
                   Thread.Sleep(3000);
                   wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='ctl00_ctl00_repProducts_ctl11_hlJumpTo']")));
                   Console.WriteLine("Wait for SmartSOA ");
                   var mng2 = driver.FindElement(By.XPath("//a[span/text()='SmartSOA']"));
                   mng2.Click();
                   //   driver.FindElement(By.XPath("//a[span/text()='text_from_link_I_want_to_click']")).Click();

                */
            /*  wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_SOAControl_StrategyReviewRequest']/div/div/div")));
              //  wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='aspnetForm']/section[2]/section[2]/section[1]/section/sectionv")));

              Console.WriteLine("Find Save ");
              var image2 = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_SOAControl_StrategyReviewRequest']/div/div/div/a"));
              // var image2 = driver.FindElement(By.ClassName("content - holder js - content - holder slideout - panel"));

              // var image2 = driver.FindElement(By.XPath(".//*[@id='aspnetForm']/section[2]/section[2]/section[1]/section/footer/div"));

              image2.Click();
              Console.WriteLine("Save ok");



              //    var elem = driver.FindElement(By.ClassName("portal-content"));
              wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='aspnetForm']/section[2]/section[2]/section[1]/section/footer/div")));
              //  var elem = driver.FindElement(By.ClassName("footer - nav"));
              var elem = driver.FindElement(By.XPath(".//*[@id='aspnetForm']/section[2]/section[2]/section[1]"));

              ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", elem);


              Console.WriteLine("Final Position Data Entered");


              Thread.Sleep(5000);*/

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
