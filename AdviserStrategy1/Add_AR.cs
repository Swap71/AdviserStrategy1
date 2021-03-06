﻿using NUnit.Framework;
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
using OpenQA.Selenium.Interactions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AdviserStrategy1
{
    class Add_AR
    {

        IWebDriver driver;


        public object IJavascriptExecutor { get; private set; }
        public object EmailA { get; private set; }

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
            var url = ConfigurationManager.AppSettings["url"];
            Console.WriteLine(string.Format("URL is : ", url));
            driver.Navigate().GoToUrl(url);

            IWebElement element = driver.FindElement(By.XPath(".//*[@id='ctl00_memberslogin_Login1_UserName']"));
            //*[@id="ctl00_memberslogin_Login1_UserName"]


            var SA_Username = ConfigurationManager.AppSettings["SA_Username"];


            Console.WriteLine(string.Format("Given Name is : ", SA_Username));
            element.SendKeys(SA_Username);


            String Name = driver.FindElement(By.XPath(".//*[@id='ctl00_memberslogin_Login1_UserName']")).GetAttribute("value");

            Console.WriteLine("SA_Username  :" + Name);


            Console.WriteLine("UserName1");
            driver.Manage().Window.Maximize();

            IWebElement element1 = driver.FindElement(By.XPath(".//*[@id='ctl00_memberslogin_Login1_Password']"));

            var SA_Passwrd = ConfigurationManager.AppSettings["SA_Passwrd"];
            Console.WriteLine(string.Format("Password is : ", SA_Passwrd));
            element1.SendKeys(SA_Passwrd);



            IWebElement element2 = driver.FindElement(By.XPath(".//*[@id='ctl00_memberslogin_Login1_LoginButton']"));
            element2.Click();
            //Added here....

        }

        [Test]
        public void AddAR()
        {

            //  try
            //   {

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

            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_HyperLinkAdminPlanners']/span")).Click();
            Console.WriteLine("Add a New AR");

            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_hlJumpTo']")).Click();
            Console.WriteLine("AR Details");



            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_hlARDetails']")).Click();
            Console.WriteLine("Clicked on AR Details");


            // Thread.Sleep(2000);




            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_txtNumber']")).Clear();

            //   driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_txtNumber']")).SendKeys("5465");
            IWebElement element3 = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_txtNumber']"));
            var txtNumber = ConfigurationManager.AppSettings["txtNumber"];
            Console.WriteLine(string.Format("TxtNumber is : ", txtNumber));
            element3.SendKeys(txtNumber);



            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_txtUserName']")).Clear();

            //      driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_txtUserName']")).SendKeys("FP130218ARSDL1");

            IWebElement element4 = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_txtUserName']"));
            var Adv_UserName = ConfigurationManager.AppSettings["Adv_UserName"];
            Console.WriteLine(string.Format("Adv_UserName is : ", Adv_UserName));
            element4.SendKeys(Adv_UserName);
            Console.WriteLine("Enter AR");

            //  Thread.Sleep(1000);

            //      Console.WriteLine("Add New AR Clicked");
            //*[@id="ctl00_ctl00_cph1_cph1_ARDetailsControl_twofactorauthentication"]/td/div/label/span
            driver.FindElement(By.ClassName("switch-knob")).Click();
            Console.WriteLine("Disable FF");

          
            Console.WriteLine("CLICK  ");

         
            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_GivenName']")).Clear();
            // driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_GivenName']")).SendKeys("Zak");
            //   driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_GivenName']")).SendKeys("tes1");
            IWebElement element5 = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_GivenName']"));
            var givenName = ConfigurationManager.AppSettings["givenName"];
            Console.WriteLine(string.Format("TxtUserName is : ", givenName));
            element5.SendKeys(givenName);
            //   Console.WriteLine("Enter AR");

            Console.WriteLine("Enter GN");

            //   Thread.Sleep(1000);
            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_Surname']")).Clear();
            //          driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_Surname']")).SendKeys("H");
            IWebElement element6 = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_Surname']"));
            var surname = ConfigurationManager.AppSettings["surname"];
            Console.WriteLine(string.Format("TxtUserName is : ", surname));
            element6.SendKeys(surname);
            Console.WriteLine("Enter SN");

            //   Thread.Sleep(1000);
            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_Email']")).Clear();
            //driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_Email']")).SendKeys("swapnil.landge@stellarconsultants.co.in");
        /***/    IWebElement element7 = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_Email']"));

            //*[@id="ctl00_ctl00_cph1_cph1_ARDetailsControl_Email"]

            // ConfigurationManager.AppSettings[“Category”];
          





  System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            var emai = ConfigurationManager.AppSettings["EmailA"];
            Console.WriteLine(string.Format("TxtUserName is : ", EmailA));
           
            config.AppSettings.Settings.Remove("EmailA");

            //   config.AppSettings.Settings.Add("EmailA", DateTime.Now.ToShortDateString());
            config.AppSettings.Settings.Add("EmailA", "r1@a1.com");

         //   var emai = ConfigurationManager.AppSettings["EmailA"];

            // Save the configuration file.

            config.Save(ConfigurationSaveMode.Modified);

   

    ConfigurationManager.RefreshSection("AppSettings");

            Thread.Sleep(5000);


            element7.SendKeys(emai);
            Console.WriteLine("Enter Email 123");



            //    However modifying config file will take extra lines of code. Below lines will update the key attribute by deleting previous entry and adding new entry in the config file:
            /***
                        System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                        config.AppSettings.Settings.Remove("EmailA");
                 //       driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_Email']")).Clear();

                        config.AppSettings.Settings.Add("EmailA", "J@Bond.com");
                        config.Save(ConfigurationSaveMode.Modified);


                        *****************/

            //      Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            //     System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            //   ConfigurationManager config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            //  config.AppSettings.Settings.Add("EmailA", "swapnil.landge@stellarconsultants.co.in");
            /***    config.AppSettings.Settings.Add("EmailA", "swap_lan8@yahoo.co.in");
                config.Save(ConfigurationSaveMode.Minimal);
                *****/
            /****>>>       ConfigurationManager.RefreshSection("appSettings");

                //   var EmailAp = ConfigurationManager.AppSettings["EmailA"];
                   Console.WriteLine(string.Format("TxtUserName is : ", EmailA));
                   element7.SendKeys(emai);
                   Console.WriteLine("Enter Email 123");*****>>>>>>>>>>>/

                   /**       var email = ConfigurationManager.AppSettings["email"];
                          Console.WriteLine(string.Format("TxtUserName is : ", email));
                          element7.SendKeys(email);
                          Console.WriteLine("Enter Email");
                          **/
            //   Thread.Sleep(2000);

            //    IWebElement element2 = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_rcbCAR_Input']"));
            //       element2.Click();
            Console.WriteLine("Jump");
            /***       driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_rcbCAR_Input']")).Clear();
                   driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_rcbCAR_Input']")).SendKeys("Swap-CAR-07");
                   ****/
            //  Thread.Sleep(2000);

            Console.WriteLine("Jump123");

            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_rcbAFSL_Input']")).Click();
            Console.WriteLine("CLICK 123 ");


            /*   driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_rcbAFSL_Input']")).Clear();
               driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_rcbAFSL_Input']")).SendKeys("Swap - AFSL - 07");*/
            Console.WriteLine("Send ");

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //     IWebElement element = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_rcbAFSL_DropDown']/div/ul/li[10]"));
            IWebElement element = driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_rcbAFSL_DropDown']/div/ul/li[4]"));
            
            //     ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView();"
            //                                                        , element);

            js.ExecuteScript("arguments[0].click();", element);

            Console.WriteLine("JS CHK ");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_rcbCAR_Input']")).Click();
            Console.WriteLine("CLICK 12345 ");

            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;

            //*[@id="ctl00_ctl00_cph1_cph1_ARDetailsControl_rcbCAR_DropDown"]/div/ul/li[2]
             IWebElement element1 = driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_rcbCAR_DropDown']/div/ul/li[2]"));
          //  IWebElement element1 = driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_rcbCAR_Input']"));
            //*[@id="ctl00_ctl00_cph1_cph1_ARDetailsControl_rcbCAR_DropDown"]/div/ul/li[2]
            //     ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView();"
            //                                                        , element);


            js1.ExecuteScript("arguments[0].click();", element1);

            Console.WriteLine("JS11111 CHK ");




            //     driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_rcbCAR_Input']")).SendKeys("Swap-CAR-07");

            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_ARDetailsControl_btnUpdate']")).Click();
            Console.WriteLine("Click on ADD");

            // Thread.Sleep(7000);



    /*****        wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_FaderMessage_General']")));
            Console.WriteLine("W8 for Text");

            String message1 = driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_FaderMessage_General']")).Text; 

            // String message1 = driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_FaderMessage_GeneralMsg']")).Text;


            // String message1 = driver.FindElement(By.XPath("//*[@id='lbl_Alert']")).Text;

            //   String message007 = driver.FindElement(By.CssSelector("body")).Text;
            // Assert.AreEqual("Unable To Add AR", message1);
            //   Assert.AreEqual("Unable To Add AR", message1);
            Assert.IsTrue(message1.Contains("New"), message1 + " doesn't contains 'message.'");//Finalising SOA... 
       ***/     Console.WriteLine("Successfully Added AR");

            Array[] ar = new Array[300];

            //      String message2 = driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_FaderMessage_General']")).Text;

  /****          String ar = driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_FaderMessage_General']")).Text;


            Console.WriteLine("AR"+ message2);

            String size = message2;
            Console.WriteLine("AR Size" + size.Length);


            Array[] ar = new Array[300];

            for(int i = size.Length;i>0;i--)
            {
                Console.WriteLine("String is" + ar[i]);
                
            }
            ****/




        }
    }
}


