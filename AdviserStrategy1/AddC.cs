using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Configuration;
using Configuration;
using Microsoft.Office.Interop.Excel;
using excel = Microsoft.Office.Interop.Excel;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System.Configuration.ConfigurationManager;
namespace AdviserStrategy1
{
    class AddC
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



           
            //     driver.Navigate().GoToUrl("http://10.168.190.20/User/dashboard.aspx");
            //     driver.Navigate().GoToUrl("http:stellar11/User/dashboard.aspx");
            var url = System.Configuration.ConfigurationManager.AppSettings["url"];
            Console.WriteLine(string.Format("URL is : ", url));
            driver.Navigate().GoToUrl(url);

            IWebElement element = driver.FindElement(By.XPath(".//*[@id='ctl00_memberslogin_Login1_UserName']"));

            var arc = System.Configuration.ConfigurationManager.AppSettings["arc"];
            Console.WriteLine(string.Format("arc is : ", arc));
            element.SendKeys(arc);


            String Name = driver.FindElement(By.XPath(".//*[@id='ctl00_memberslogin_Login1_UserName']")).GetAttribute("value");

            Console.WriteLine("UserName Successfully Created :" + Name);


            Console.WriteLine("UserName1");
            driver.Manage().Window.Maximize();

            IWebElement element1 = driver.FindElement(By.XPath(".//*[@id='ctl00_memberslogin_Login1_Password']"));
            var pswd = System.Configuration.ConfigurationManager.AppSettings["pswd"];
            Console.WriteLine(string.Format("Password of AR is : ", pswd));
            element1.SendKeys(pswd);
            Thread.Sleep(1000);
            //       element1.SendKeys("Zc9+?2CzG+w");
            //   element1.SendKeys("H+i78tB?F?c");
            IWebElement element2 = driver.FindElement(By.XPath(".//*[@id='ctl00_memberslogin_Login1_LoginButton']"));
            element2.Click();

            Thread.Sleep(1000);
            String A = driver.FindElement(By.XPath(" //*[@id='ctl00_rwAgreement_C_btnAgree']")).Text;
            Console.WriteLine(A);

            if (!String.IsNullOrEmpty(A))
            {
                driver.FindElement(By.XPath(" //*[@id='ctl00_rwAgreement_C_btnAgree']")).Click();
            }

        }
        [Test]
        public void AddClient()
        {


            //   Thread.Sleep(2000);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
       //     driver.FindElement(By.XPath("//*[@id='ctl00_rwAgreement_C']/div")).Click();
            Thread.Sleep(2000);
            //*[@id="ctl00_HyperLink3"]
            //     driver.FindElement(By.XPath("//*[@id='ctl00_rwAgreement_C_btnAgree']")).Click();


            //    Thread.Sleep(2000);
            driver.FindElement(By.XPath(".//*[@id='ctl00_HyperLink3']")).Click();

            Console.WriteLine("Clicked New Client");



            IWebElement element3 = driver.FindElement(By.XPath(".//*[@id='GivenName']"));
            var gnc = System.Configuration.ConfigurationManager.AppSettings["gnc"];
            element3.SendKeys(gnc);



            IWebElement element4 = driver.FindElement(By.XPath(".//*[@id='Surname']"));
            var sn = System.Configuration.ConfigurationManager.AppSettings["sn"];
            element4.SendKeys(sn);

            IWebElement element5 = driver.FindElement(By.XPath(".//*[@id='UserName']"));
            var un = System.Configuration.ConfigurationManager.AppSettings["un"];
            element5.SendKeys(un);

            IWebElement element6 = driver.FindElement(By.XPath(".//*[@id='Email']"));
            var email1 = System.Configuration.ConfigurationManager.AppSettings["email1"];
            element6.SendKeys(email1);

            Thread.Sleep(1000);
            //*[@id="divv"]/label[2]/span

            driver.FindElement(By.XPath("//*[@id='divv']/label[2]/span")).Click();

            driver.FindElement(By.XPath(".//*[@id='AdvisersList']")).Click();

            Thread.Sleep(1000);

        //    SelectElement oSelection = new SelectElement(driver.FindElement(By.XPath(".//*[@id='AdvisersList']")));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement element = driver.FindElement(By.XPath("//*[@id='AdvisersList']"));
            //     ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView();"
            //                                                        , element);

            js.ExecuteScript("arguments[0].click();", element);

            //*[@id="AdvisersList"]

            Console.WriteLine("JS CHK ");
            //     oSelection.SelectByText("Swapy La");
            var ar = System.Configuration.ConfigurationManager.AppSettings["SUserName"];
          //  oSelection.SelectByText("SUserName");
            // SGivenName

            driver.FindElement(By.XPath(".//*[@id='divv2']/label[2]/span")).Click();



            driver.FindElement(By.XPath(".//*[@id='Save_Client']")).Click();

            Thread.Sleep(4000);

            // String msg = driver.FindElement(By.CssSelector("body")).Text;
                  String msg = driver.FindElement(By.XPath(".//*[@id='MessageBox']/h3")).Text;
          //  String msg = driver.FindElement(By.XPath(" //*[@id='InputBox']/div[3]/span")).Text;
           
            Console.WriteLine("Message is :" + msg);
            Assert.IsTrue(msg.Contains("Success."), msg + " doesn't contains 'Sucees...msg.'");
            Console.WriteLine("Suces Message is :" + msg);
        }
    }
}

