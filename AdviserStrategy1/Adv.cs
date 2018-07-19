using Microsoft.Office.Interop.Excel;
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
using System.Windows.Forms;

namespace AdviserStrategy1
{

    class Adv
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
                  //  Thread.Sleep(15000);
                    //       driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
                    //  driver = new FirefoxDriver(new FirefoxBinary(), new FirefoxProfile(), TimeSpan.FromSeconds(180));
                    break;


                case "CR":

               
                    driver = new ChromeDriver(Path);
                    break;
            }



            var URL = System.Configuration.ConfigurationManager.AppSettings["URL"];
           
            driver.Navigate().GoToUrl(URL);




            IWebElement element = driver.FindElement(By.XPath(".//*[@id='ctl00_memberslogin_Login1_UserName']"));


            var Adviser = System.Configuration.ConfigurationManager.AppSettings["Adviser"];
            Console.WriteLine(string.Format("Adviser is : ", Adviser));
            element.SendKeys(Adviser);
            // element.SendKeys("FP140218ARSL");


            String Name = driver.FindElement(By.XPath(".//*[@id='ctl00_memberslogin_Login1_UserName']")).GetAttribute("value");

            Console.WriteLine("UserName Successfully Created :" + Name);


            Console.WriteLine("UserName1");
            driver.Manage().Window.Maximize();

            IWebElement element1 = driver.FindElement(By.XPath(".//*[@id='ctl00_memberslogin_Login1_Password']"));
            var Advpswd = System.Configuration.ConfigurationManager.AppSettings["Advpswd"];
            Console.WriteLine(string.Format("Adv Password is : ", Advpswd));
            element1.SendKeys(Advpswd);

            Thread.Sleep(1000);

            Console.WriteLine("Click on Logged Button  ");


            IWebElement element2 = driver.FindElement(By.XPath(".//*[@id='ctl00_memberslogin_Login1_LoginButton']"));
            element2.Click();

            Console.WriteLine("Enter into App ");
            Thread.Sleep(3000);

            String A = driver.FindElement(By.XPath(" //*[@id='ctl00_rwAgreement_C_btnAgree']")).Text;
            Console.WriteLine(A);

            if (!String.IsNullOrEmpty(A))
            {
                driver.FindElement(By.XPath(" //*[@id='ctl00_rwAgreement_C_btnAgree']")).Click();
            }
         
            

        }

        [Test]
        public void AdviserSOAReq1()
        {
            Thread.Sleep(2000);

            //*[@id="ctl00_rwAgreement_C"]/div
            //This step produce an alert on screen
            // driver.FindElement(By.XPath("//*[@id='content']/p[4]/button")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

           // Thread.Sleep(1000);


            //  driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_AdminLink']")).Click();
            driver.FindElement(By.XPath(".//*[@id='aspnetForm']/section[2]/section[1]/nav")).Click();
            Console.WriteLine("Black Ribbon");
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//a[contains(@title, 'Search client')]")).Click();

            //  wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(@title, 'Management')]")));
            Console.WriteLine("Search client");

            Thread.Sleep(1000);

            Console.WriteLine("Clicked Search");



            //  driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_HyperLinkAdminPlanners']")).Click();
            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_btnSearch']")).Click();
            Console.WriteLine("sEARCH");

            Thread.Sleep(1000);

            IWebElement element = driver.FindElement(By.Id("ctl00_ctl00_cph1_cph1_ClientName"));


            var C_USERNAME = System.Configuration.ConfigurationManager.AppSettings["C_USERNAME"];


            Console.WriteLine(string.Format("Given Name is : ", C_USERNAME));
            element.SendKeys(C_USERNAME);

            //  driver.FindElement(By.Id("ctl00_ctl00_cph1_cph1_ClientName")).SendKeys("Jeff1");

            Console.WriteLine("Enter Search");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_btnSearch']")).Click();

            Console.WriteLine("Click on Search button");


            for (int i = 0; i <= 20; i++)
            {


                //    String ss = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_rgManageAR_ctl00__" + i + "']/td[2]")).Text;
                String gn = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_rgUsers_ctl00__" + i + "']/td[4]")).Text;




                string s = ConfigurationManager.AppSettings["C_USERNAME"];
                if (!String.IsNullOrEmpty(s))
                {
                   
                    Console.WriteLine("C_Given Name is:" + gn);
                    String sn = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_rgUsers_ctl00__" + i + "']/td[5]")).Text;
                   

                    string s1 = ConfigurationManager.AppSettings["C_GIVEN NAME"];
                    if (!String.IsNullOrEmpty(s1))

                    {

                        Console.WriteLine("Given Name is:" + sn);


                        Console.WriteLine("Into Loop i is +" + i);


                        var im1 = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_rgUsers_ctl00__" + i + "']/td[7]"));


                        Console.WriteLine("i value chk is +" + i);

                        im1.Click();

                        break;
                    }
                }
            }

            Thread.Sleep(4000);

            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='ctl00_ctl00_PanelLoggedIn']/aside")));
            Console.WriteLine("Wait for CLIENT ");


            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_repProducts_ctl01_hlJumpTo']/span")).Click();

            Console.WriteLine("Click on Cash Flow ");



            Thread.Sleep(1000);
            driver.FindElement(By.XPath(".//*[@id='bpoFinancialPosition']/div/div/div[1]/div/ul/li[3]/span/a")).Click();
            Console.WriteLine("Clicked Here");

            Thread.Sleep(1000);

            IList<IWebElement> iframes = driver.FindElements(By.TagName("iframe"));
            //  driver.FindElements(By.TagName("iframe")).Text;
            int size = iframes.Count;
            Console.WriteLine("Frame SIZE IS :" + size);

            driver.SwitchTo().Frame(1);

            driver.FindElement(By.CssSelector("body")).Clear();
            IWebElement body1 = driver.FindElement(By.CssSelector("body"));
            Thread.Sleep(1000);
            body1.SendKeys("Stategy Test for Financial Position on 5 March 2018");

            Console.WriteLine(body1.Text);
            Console.WriteLine("Frame 1");
            driver.SwitchTo().DefaultContent();

            Thread.Sleep(1000);
            driver.SwitchTo().Frame(2);

            driver.FindElement(By.CssSelector("body")).Clear();
            IWebElement body2 = driver.FindElement(By.CssSelector("body"));
            Thread.Sleep(1000);
            Console.WriteLine("Frame 2");
            //   body.SendKeys("TESTING");
            body2.SendKeys("Outcome Test for Financial Position on 5 March 2018");

            Console.WriteLine(body2.Text);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(1000);
            driver.SwitchTo().Frame(3);

            driver.FindElement(By.CssSelector("body")).Clear();
            IWebElement body3 = driver.FindElement(By.CssSelector("body"));
            Thread.Sleep(1000);
            Console.WriteLine("Frame 3");
            // body3.SendKeys("TESTING...Frames");
            body3.SendKeys("Test for Financial Position on 5 March 2018");


            Console.WriteLine("Frame 3");

            driver.SwitchTo().DefaultContent();
            Thread.Sleep(1000);
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='bpoFinancialPosition']/div/div/div[3]/div[3]")));
            Console.WriteLine("Click on SAVE");
            var image7 = driver.FindElement(By.XPath(".//*[@id='bpoFinancialPosition']/div/div/div[3]/div[3]/a[1]"));
            image7.Click();

            Console.WriteLine("Save ");


            Thread.Sleep(1000);


            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_repProducts_ctl02_hlJumpTo']/span")).Click();

            Console.WriteLine("Click on Insurance Cover");
            Thread.Sleep(1000);



            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_bpoPersonalRiskCover']/div/div/div[1]/div/ul/li[3]/span/a")).Click();


            Console.WriteLine("Click here");
            Thread.Sleep(2000);


            IList<IWebElement> iframes270 = driver.FindElements(By.TagName("iframe"));
            //  driver.FindElements(By.TagName("iframe")).Text;
            int size270 = iframes.Count;
            Console.WriteLine("Frame SIZE IS :" + size270);

            driver.SwitchTo().Frame(1);

            driver.FindElement(By.CssSelector("body")).Clear();
            IWebElement body270 = driver.FindElement(By.CssSelector("body"));
            Thread.Sleep(1000);
            body270.SendKeys("Stategy Test for Personal Risk Cover on 5 March 2018");

            Console.WriteLine(body270.Text);
            Console.WriteLine("Frame 1");
            driver.SwitchTo().DefaultContent();

            Thread.Sleep(1000);
            driver.SwitchTo().Frame(2);

            driver.FindElement(By.CssSelector("body")).Clear();
            IWebElement body280 = driver.FindElement(By.CssSelector("body"));
            Thread.Sleep(1000);
            Console.WriteLine("Frame 2");
            //   body.SendKeys("TESTING");
            body280.SendKeys("Outcome Test for Personal Risk Cover on 5 March 2018");

            Console.WriteLine(body280.Text);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(1000);
            driver.SwitchTo().Frame(3);

            driver.FindElement(By.CssSelector("body")).Clear();
            IWebElement body29 = driver.FindElement(By.CssSelector("body"));
            Thread.Sleep(1000);
            Console.WriteLine("Frame 3");
            // body3.SendKeys("TESTING...Frames");
            body29.SendKeys("Test for Personal Risk Cover on 5 March 2018");
            Console.WriteLine(body29.Text);

            Console.WriteLine("Frame 3");

            driver.SwitchTo().DefaultContent();
            Thread.Sleep(1000);



            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_bpoPersonalRiskCover']/div/div/div[3]/div[2]/div[2]/div/table/tbody/tr[1]/td[2]/div/label[1]/span")).Click();
            Console.WriteLine("Need Analysis - YES");
            Thread.Sleep(1000);


            /*    driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_bpoPersonalRiskCover']/div/div/div[3]/div[2]/div[2]/div/table/tbody/tr[3]/td[2]/div/label[1]/span")).Click();
                Console.WriteLine("Quote - YES");*/
            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_bpoPersonalRiskCover']/div/div/div[3]/div[2]/div[2]/div/table/tbody/tr[3]/td[2]/div/label[2]/span")).Click();
            Console.WriteLine("Quote - NO");
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_bpoPersonalRiskCover']/div/div/div[3]/div[2]/div[2]/div/table/tbody/tr[5]/td[2]/div/label[2]/span")).Click();
            Console.WriteLine("Existing Policies Retained - NO");
            Thread.Sleep(1000);

            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_bpoPersonalRiskCover']/div/div/div[3]/div[3]")));
            Console.WriteLine("Click on SAVE");
            var image72 = driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_bpoPersonalRiskCover']/div/div/div[3]/div[3]/a[1]"));
            image72.Click();

            Console.WriteLine("Save ");

            /*************
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_aSummary']")).Click();
            Console.WriteLine("Click On Summary");
            Thread.Sleep(1000);


            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_LinkButton2']")).Click();
            Console.WriteLine("Click On View/Hide");
            Thread.Sleep(1000);

            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_txtIncomeMultiplier']")).Clear();
            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_txtIncomeMultiplier']")).SendKeys("35.21");
            Console.WriteLine("Income Multiplier for Recommended Cover");
            Thread.Sleep(1000);


            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_rbCustom']")).Click();
            Console.WriteLine("The Advised Cover Position");
            Thread.Sleep(1000);

            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_txtCustomCover']")).Clear();
            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_txtCustomCover']")).SendKeys("8");
            Console.WriteLine("The Advised Cover Position");
            Thread.Sleep(1000);

            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_btnRecalculateFinal']")).Click();
            Console.WriteLine("Save Adviser Cover");
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_TextBox1']")).Clear();
            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_TextBox1']")).SendKeys("Bill");
            Console.WriteLine("Enter Provider");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_txtPremium']")).Clear();
            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_txtPremium']")).SendKeys("50");
            Thread.Sleep(1000);



            SelectElement oSelection2 = new SelectElement(driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_DropDownList1']")));

            //  oSelection.SelectByText("- Select -");
            oSelection2.SelectByText("Monthly");

            Console.WriteLine("Selected Payment Frequency ");

            Thread.Sleep(1000);


            driver.FindElement(By.XPath("//*[@id='save_proposed_modal']/div[4]/a[1]")).Click();
            Console.WriteLine("Proceed with Save As Proceed");
            Thread.Sleep(1000);



            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_btnRecalculate']")).Click();
            Console.WriteLine("Re-Calculate");
           
            Thread.Sleep(1000);


            IJavaScriptExecutor js2 = (IJavaScriptExecutor)driver;
            IWebElement element2 = driver.FindElement(By.XPath(".//*[@id='aspnetForm']/section[2]/section[2]/section[1]/section/footer/div"));
            //     ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView();"
            //                                                        , element);

            js2.ExecuteScript("arguments[0].scrollIntoView();", element2);

            **************/

            Thread.Sleep(1000);

            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_repProducts_ctl03_hlJumpTo']/span")).Click();

            Console.WriteLine("Click on SUPER");
            Thread.Sleep(1000);


            driver.FindElement(By.XPath(" .//*[@id='bpoInvestmentStrategy']/div/div/div[1]/div/ul/li[3]/span/a")).Click();

            Console.WriteLine("Click Here");
            Thread.Sleep(1000);



            driver.FindElement(By.XPath(" //*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[1]/table/tbody/tr/td[2]/div/label[3]/span")).Click();

            Console.WriteLine("Not Specified..Superfund");
            Thread.Sleep(1000);

            IList<IWebElement> iframes2 = driver.FindElements(By.TagName("iframe"));

            int size2 = iframes2.Count;
            Console.WriteLine("Frame SIZE PRC is :" + size2);


            driver.SwitchTo().Frame(1);


            driver.FindElement(By.CssSelector("body")).Clear();


            Console.WriteLine("Frame 1");



            IWebElement body7 = driver.FindElement(By.CssSelector("body"));
            Thread.Sleep(1000);
            body7.SendKeys("Strategy for Super 1 March");

            Console.WriteLine(body7.Text);
            Console.WriteLine("Frame 1");
            driver.SwitchTo().DefaultContent();


            driver.SwitchTo().Frame(2);

            driver.FindElement(By.CssSelector("body")).Clear();
            IWebElement body8 = driver.FindElement(By.CssSelector("body"));
            Thread.Sleep(1000);
            Console.WriteLine("Frame 2");
            //   body.SendKeys("TESTING");
            body8.SendKeys("Outcome Test for Super on 5 March 2018 ");

            Console.WriteLine(body8.Text);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(1000);

            driver.SwitchTo().Frame(3);

            driver.FindElement(By.CssSelector("body")).Clear();
            IWebElement body9 = driver.FindElement(By.CssSelector("body"));
            Thread.Sleep(1000);
            Console.WriteLine("Frame 3");
            // body3.SendKeys("TESTING...Frames");
            body9.SendKeys("Test for Super on 1 March 2018");

            driver.SwitchTo().DefaultContent();
            Thread.Sleep(1000);
            driver.SwitchTo().Frame(4);
            driver.FindElement(By.CssSelector("body")).Clear();
            IWebElement body10 = driver.FindElement(By.CssSelector("body"));
            Thread.Sleep(1000);
            Console.WriteLine("Frame 4");
            // body3.SendKeys("TESTING...Frames");
            body10.SendKeys(" Test on 5 March 2018");
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(1000);





            //   Thread.Sleep(2000);

            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[3]/table/tbody/tr[2]/td[2]")));
            Console.WriteLine("Clicking on YES");

            driver.FindElement(By.XPath(" .//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[3]/table/tbody/tr[2]/td[2]/div/label[1]/span")).Click();
            Console.WriteLine("YES");

            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[3]/table/tbody/tr[3]/td[2]")));
            Console.WriteLine("Enter Naming");

            driver.FindElement(By.XPath(".//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[3]/table/tbody/tr[3]/td[2]/input")).Clear();
            driver.FindElement(By.XPath(".//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[3]/table/tbody/tr[3]/td[2]/input")).SendKeys("Ronaldo");

            Console.WriteLine("Enter Specify Name ");


            Thread.Sleep(2000);


            //    Console.WriteLine("Enter Specify Name ");

            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[3]/table/tbody/tr[4]/td[2]")));
            Console.WriteLine("Clicking on YES1");



            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[3]/table/tbody/tr[3]/td[2]")));
            Console.WriteLine("EnterPlatform");

            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[3]/table/tbody/tr[4]/td[2]")));
            Console.WriteLine("Clicking on NO");

            driver.FindElement(By.XPath(" .//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[3]/table/tbody/tr[4]/td[2]/div/label[2]/span")).Click();
            Console.WriteLine("NO");



            driver.FindElement(By.XPath(" .//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[3]/table/tbody/tr[5]/td[2]/input")).Clear();
            driver.FindElement(By.XPath(" .//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[3]/table/tbody/tr[5]/td[2]/input")).SendKeys("STR007");
            Console.WriteLine("YES1");


            Thread.Sleep(1000);

            driver.SwitchTo().Frame(5);

            driver.FindElement(By.CssSelector("body")).Clear();
            IWebElement body12 = driver.FindElement(By.CssSelector("body"));
            Thread.Sleep(1000);
            Console.WriteLine("Frame 5");
            //   body.SendKeys("TESTING");
            body12.SendKeys("Underlying investments on 5 March 2018 ");
            driver.SwitchTo().DefaultContent();


            driver.FindElement(By.XPath(" .//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[3]/table/tbody/tr[7]/td[2]/div/label[2]/span")).Click();
            Thread.Sleep(1000);


            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[3]/table/tbody/tr[9]/td[2]")));

            //   wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[3]/table/tbody/tr[9]/td[2]")));
            Console.WriteLine("Not Specified");
            //var image15 = driver.FindElement(By.XPath(".//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[3]/table/tbody/tr[9]/td[2]/div/label[3]/span"));
            driver.FindElement(By.XPath(".//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[3]/table/tbody/tr[9]/td[2]/div/label[3]/span")).Click(); ;
            //   image15.Click();
            Thread.Sleep(1000);


            driver.FindElement(By.XPath(" .//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[3]/a[1]")).Click();
            Console.WriteLine("S-A-V-E");

            Thread.Sleep(1000);

            driver.FindElement(By.XPath(" .//*[@id='ctl00_ctl00_repProducts_ctl05_hlJumpTo']/span")).Click();
            Console.WriteLine("Investments");


            Thread.Sleep(2000);
            driver.FindElement(By.XPath(".//*[@id='bpoInvestmentStrategy']/div/div/div[1]/div/ul/li[3]/span/a")).Click();

            Console.WriteLine("Click here");

            Thread.Sleep(1000);
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[1]/table/tbody/tr/td[2]")));
            Console.WriteLine("Clicking on CheckList Attached");

            driver.FindElement(By.XPath(" .//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[1]/table/tbody/tr/td[2]/div/label[1]/span")).Click();
            Console.WriteLine("CheckList");

            Thread.Sleep(2000);

            IList<IWebElement> iframes21 = driver.FindElements(By.TagName("iframe"));

            int size21 = iframes21.Count;
            Console.WriteLine("Frame SIZE PRC is :" + size21);


            driver.SwitchTo().Frame(1);


            driver.FindElement(By.CssSelector("body")).Clear();


            Console.WriteLine("Frame 1");



            IWebElement body71 = driver.FindElement(By.CssSelector("body"));
            Thread.Sleep(1000);
            body71.SendKeys("Stategy Test....Investment 28 Feb 2018 ");

            Console.WriteLine(body71.Text);
            Console.WriteLine("Frame 1");
            driver.SwitchTo().DefaultContent();


            driver.SwitchTo().Frame(2);

            driver.FindElement(By.CssSelector("body")).Clear();
            IWebElement body81 = driver.FindElement(By.CssSelector("body"));
            Thread.Sleep(1000);
            Console.WriteLine("Frame 2");
            //   body.SendKeys("TESTING");
            body81.SendKeys("Outcome Test for Investment 28 Feb 2018 ");

            Console.WriteLine(body81.Text);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(1000);

            driver.SwitchTo().Frame(3);

            driver.FindElement(By.CssSelector("body")).Clear();
            IWebElement body91 = driver.FindElement(By.CssSelector("body"));
            Thread.Sleep(1000);
            Console.WriteLine("Frame 3");
            // body3.SendKeys("TESTING...Frames");
            body91.SendKeys("Test for Investment 28 Feb 2018 ");

            driver.SwitchTo().DefaultContent();
            Thread.Sleep(1000);
            driver.SwitchTo().Frame(4);
            driver.FindElement(By.CssSelector("body")).Clear();
            IWebElement body101 = driver.FindElement(By.CssSelector("body"));
            Thread.Sleep(1000);
            Console.WriteLine("Frame 4");
            // body3.SendKeys("TESTING...Frames");
            body101.SendKeys("INVESTMENT 28 Feb 2018 ");
            driver.SwitchTo().DefaultContent();




            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[3]/table/tbody/tr[2]/td[2]")));
            Console.WriteLine("type of investment ");

            driver.FindElement(By.XPath(".//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[3]/table/tbody/tr[2]/td[2]/input")).Clear();
            driver.FindElement(By.XPath(".//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[3]/table/tbody/tr[2]/td[2]/input")).SendKeys("Property on 5 March 2018");


            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[3]/table/tbody/tr[3]/td[2]")));

            Console.WriteLine("Enter Platform  ");

            driver.FindElement(By.XPath(".//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[3]/table/tbody/tr[3]/td[2]/input")).Clear();
            driver.FindElement(By.XPath(".//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[3]/table/tbody/tr[3]/td[2]/input")).SendKeys("Platform on 5 March 2018");


            Thread.Sleep(1000);

            driver.SwitchTo().Frame(5);
            driver.FindElement(By.CssSelector("body")).Clear();
            IWebElement body102 = driver.FindElement(By.CssSelector("body"));
            Thread.Sleep(1000);
            Console.WriteLine("Frame 5");
            // body3.SendKeys("TESTING...Frames");
            body102.SendKeys("Test INV - 5 March 2018");
            driver.SwitchTo().DefaultContent();
            //    Thread.Sleep(1000);

            Thread.Sleep(1000);
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[3]/table/tbody/tr[3]/td[2]")));

            Console.WriteLine("investment money ");

            driver.FindElement(By.XPath(".//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[3]/table/tbody/tr[5]/td[2]/input")).Clear();
            driver.FindElement(By.XPath(".//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[3]/table/tbody/tr[5]/td[2]/input")).SendKeys("Cheque on 5 March 2018 ");




            Thread.Sleep(1000);
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[3]/table/tbody/tr[6]/td[2]")));

            Console.WriteLine(" investment time ");

            driver.FindElement(By.XPath(".//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[3]/table/tbody/tr[6]/td[2]/input")).Clear();
            driver.FindElement(By.XPath(".//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[3]/table/tbody/tr[6]/td[2]/input")).SendKeys("28");


            Thread.Sleep(1000);
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[3]/table/tbody/tr[7]/td[2]")));
            driver.FindElement(By.XPath("//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[3]/table/tbody/tr[7]/td[2]/div/label[1]/span")).Click();

            Console.WriteLine(" P or C ");
            Thread.Sleep(1000);
            //*[@id="bpoInvestmentStrategy"]/div/div/div[3]/div[2]/div[3]/table/tbody/tr[8]/td[2]/div/label[2]/span
            driver.FindElement(By.XPath("//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[3]/table/tbody/tr[8]/td[2]/div/label[1]/span")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[3]/table/tbody/tr[8]/td[2]/div/label[2]/span")).Click();
            //   driver.FindElement(By.XPath(".//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[2]/div[3]/table/tbody/tr[7]/td[2]/div/label[1]/span")).SendKeys("2 ");

            driver.FindElement(By.XPath(" .//*[@id='bpoInvestmentStrategy']/div/div/div[3]/div[3]/a[1]")).Click();
            Console.WriteLine("S-A-V-E Investmentt");



            Thread.Sleep(2000);



            driver.FindElement(By.XPath(" .//*[@id='ctl00_ctl00_repProducts_ctl08_hlJumpTo']/span")).Click();
            Console.WriteLine("Estate Planning");


            Thread.Sleep(2000);

            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_EstatePlanningControl_bpoEstatePlanning']/div/div/div[1]/div/ul")));
            Console.WriteLine("Click Here");
            var image61 = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_EstatePlanningControl_bpoEstatePlanning']/div/div/div[1]/div/ul/li[3]/span/a/i"));
            image61.Click();


            Thread.Sleep(2000);
            IList<IWebElement> iframes6 = driver.FindElements(By.TagName("iframe"));

            int size6 = iframes6.Count;
            Console.WriteLine("Frame SIZE is :" + size6);


            driver.SwitchTo().Frame(1);


            driver.FindElement(By.CssSelector("body")).Clear();


            Console.WriteLine("Frame 1");



            IWebElement body61 = driver.FindElement(By.CssSelector("body"));
            Thread.Sleep(1000);
            body61.SendKeys("Stategy Test for EP 5 March 2018 ");

            Console.WriteLine(body61.Text);
            Console.WriteLine("Frame 1");
            driver.SwitchTo().DefaultContent();


            driver.SwitchTo().Frame(2);

            driver.FindElement(By.CssSelector("body")).Clear();
            IWebElement body62 = driver.FindElement(By.CssSelector("body"));
            Thread.Sleep(1000);
            Console.WriteLine("Frame 2");
            //   body.SendKeys("TESTING");
            body62.SendKeys("Outcome Test for EP 5 March 2018");

            Console.WriteLine(body62.Text);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(1000);

            driver.SwitchTo().Frame(3);

            driver.FindElement(By.CssSelector("body")).Clear();
            IWebElement body63 = driver.FindElement(By.CssSelector("body"));
            Thread.Sleep(1000);
            Console.WriteLine("Frame 3");
            // body3.SendKeys("TESTING...Frames");
            body63.SendKeys("Test is going on for EP 5 March 2018 ");

            driver.SwitchTo().DefaultContent();
            Thread.Sleep(1000);

            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_EstatePlanningControl_bpoEstatePlanning']/div/div/div[3]/div[3]")));
            Console.WriteLine("SAVE EP");
            var image64 = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_EstatePlanningControl_bpoEstatePlanning']/div/div/div[3]/div[3]/a[1]"));
            image64.Click();

            Thread.Sleep(2000);
            /***************************
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='ctl00_ctl00_PanelLoggedIn']/aside")));
            Console.WriteLine("Wait DB ");

            Thread.Sleep(2000);

            //   wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='ctl00_repProducts_ctl10_hlJumpTo']")));
            Console.WriteLine("DB");

            //*[@id="ctl00_ctl00_repProducts_ctl10_hlJumpTo"]/span
            driver.FindElement(By.XPath(" //*[@id='ctl00_ctl00_cph1_cph1_hlDEBT']")).Click();
            Console.WriteLine("Debt Manager");


            Thread.Sleep(1000);

            driver.FindElement(By.XPath(" //*[@id='ctl00_ctl00_cph1_cph1_SmartDebt_balancedate']")).Clear();
            driver.FindElement(By.XPath(" //*[@id='ctl00_ctl00_cph1_cph1_SmartDebt_balancedate']")).SendKeys("01/01/2016");
            Console.WriteLine("BALANCE dATE ");

            Thread.Sleep(1000);
            driver.FindElement(By.XPath(" //*[@id='ctl00_ctl00_cph1_cph1_SmartDebt_monthlypayment']")).Clear();
            driver.FindElement(By.XPath(" //*[@id='ctl00_ctl00_cph1_cph1_SmartDebt_monthlypayment']")).SendKeys("$350");
            Console.WriteLine("Monthly Payment ");

            //*[@id="ctl00_ctl00_cph1_cph1_SmartDebt_monthlypayment"]
            driver.FindElement(By.XPath(" //*[@id='ctl00_ctl00_cph1_cph1_SmartDebt_btnCalc']")).Click();
            //*[@id="ctl00_ctl00_cph1_cph1_SmartDebt_btnCalc"]
            Console.WriteLine("Calculate Result");

            Thread.Sleep(2000);
            ***********************/




            driver.FindElement(By.XPath(" .//*[@id='ctl00_ctl00_pnlClientMenu']/ul/li[2]/span")).Click();
            Console.WriteLine("CLIENT");





            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_hlSOA']")).Click();
            Console.WriteLine("Click on Smart SOA  ");

            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_SOAControl_StrategyReview']/div/div/div/div/ul/li[1]/a")).Click();


            Thread.Sleep(2000);
            IList<IWebElement> iframes52 = driver.FindElements(By.TagName("iframe"));

            int size52 = iframes52.Count;
            Console.WriteLine("Frame SIZE is :" + size52);


            driver.SwitchTo().Frame(1);


            driver.FindElement(By.CssSelector("body")).Clear();


            Console.WriteLine("Frame 1");



            IWebElement body53 = driver.FindElement(By.CssSelector("body"));
            Thread.Sleep(1000);
            body53.SendKeys("Stategy Test on 5 March 2018 ");

            Console.WriteLine(body53.Text);
            Console.WriteLine("Frame 1");
            driver.SwitchTo().DefaultContent();


            driver.SwitchTo().Frame(2);

            driver.FindElement(By.CssSelector("body")).Clear();
            IWebElement body54 = driver.FindElement(By.CssSelector("body"));
            Thread.Sleep(1000);
            Console.WriteLine("Frame 2");
            //   body.SendKeys("TESTING");
            body54.SendKeys("Outcome Test on 5 March");

            Console.WriteLine(body54.Text);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(1000);

            driver.SwitchTo().Frame(3);

            driver.FindElement(By.CssSelector("body")).Clear();
            IWebElement body55 = driver.FindElement(By.CssSelector("body"));
            Thread.Sleep(1000);
            Console.WriteLine("Frame 3");
            // body3.SendKeys("TESTING...Frames");
            body55.SendKeys("Test on 5'18");

            driver.SwitchTo().DefaultContent();
            Thread.Sleep(1000);

            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_SOAControl_StrategyReview']/div/div/div/div/ul/li[1]/div/div/div[3]/div[3]/a[1]")).Click();
            Console.WriteLine("Save Ediited ");
            Thread.Sleep(1000);

            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_SOAControl_StrategyReviewRequest']/div/div/div/a")).Click();
            Console.WriteLine("Save ok");//An error has occured. Administrator has been notified.


            Thread.Sleep(2000);
            String message1 = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_SOAControl_StrategyReviewRequest']/div/div/div/div/div")).Text;
            Console.WriteLine("Success message of Submit SOA Request is :" + message1);




            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            IWebElement element3 = driver.FindElement(By.XPath(".//*[@id='aspnetForm']/section[2]/section[2]/section[1]/section/footer/div"));

            js1.ExecuteScript("arguments[0].scrollIntoView();", element3);

            //   Assert.IsTrue(message1.Contains("SOA request submitted successfully."), message1 + " doesn't contains 'message.'");
            Assert.IsTrue(message1.Contains("SOA request"), message1 + " doesn't contains 'message.'");


            Thread.Sleep(2000);

            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_HyperLink121']")).Click();
            Console.WriteLine("Click on MyDashboard");

            Thread.Sleep(2000);

            driver.FindElement(By.XPath(" .//*[@id='ctl00_cph1_hlAdviserSmartSOA']")).Click();
            Console.WriteLine("Click on SOA Request");


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

