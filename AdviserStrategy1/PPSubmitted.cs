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
    class PPSubmitted
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



            var url = System.Configuration.ConfigurationManager.AppSettings["url"];
            Console.WriteLine(string.Format("URL is : ", url));
            driver.Navigate().GoToUrl(url);

            IWebElement element = driver.FindElement(By.XPath(".//*[@id='ctl00_memberslogin_Login1_UserName']"));


            var ParaPlanner = System.Configuration.ConfigurationManager.AppSettings["ParaPlanner"];


            Console.WriteLine(string.Format("Given Name is : ", ParaPlanner));
            element.SendKeys(ParaPlanner);


            String Name = driver.FindElement(By.XPath(".//*[@id='ctl00_memberslogin_Login1_UserName']")).GetAttribute("value");

            Console.WriteLine("UserName Successfully Created :" + Name);


            Console.WriteLine("UserName1");
            driver.Manage().Window.Maximize();

            IWebElement element1 = driver.FindElement(By.XPath(".//*[@id='ctl00_memberslogin_Login1_Password']"));

            var PPpswd = System.Configuration.ConfigurationManager.AppSettings["PPpswd"];
            Console.WriteLine(string.Format("Password is : ", PPpswd));
            element1.SendKeys(PPpswd);



            IWebElement element2 = driver.FindElement(By.XPath(".//*[@id='ctl00_memberslogin_Login1_LoginButton']"));
            element2.Click();

            String A = driver.FindElement(By.XPath(" //*[@id='ctl00_rwAgreement_C_btnAgree']")).Text;
            Console.WriteLine(A);

            if (!String.IsNullOrEmpty(A))
            {//*[@id="ctl00_rwAgreement_C_btnAgree"]
                driver.FindElement(By.XPath(" //*[@id='ctl00_rwAgreement_C_btnAgree']")).Click();
            }


        }
        [Test]
        public void ParaPlannerInProgressSOA2()
        {


            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            //*[@id="ctl00_cph1_hlAdviserSmartSOA"]

            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='ctl00_cph1_hlAdviserSmartSOA']")));
          
            var image1 = driver.FindElement(By.XPath(".//*[@id='ctl00_cph1_hlAdviserSmartSOA']/span[2]"));
            image1.Click();
            Console.WriteLine("Click on SOA Request ");

            Thread.Sleep(2000);
            //*[@id="ctl00_cph1_BpoSmartSOAControl_rptAdviserSOA_ctl05_lblAdviser"]
            //*[@id="ctl00_cph1_BpoSmartSOAControl_rptAdviserSOA_ctl06_lblAdviser"]
            //*[@id="ctl00_cph1_BpoSmartSOAControl_rptAdviserSOA_ctl07_ancoraccordpanel"]
            //*[@id="ctl00_cph1_BpoSmartSOAControl_rptAdviserSOA_ctl04_lblAdviser"]
            //*[@id="ctl00_cph1_BpoSmartSOAControl_rptAdviserSOA_ctl08_ancoraccordpanel"]
           
            //       IList<IWebElement> allLinks = driver.FindElements(By.XPath(".//*[@id='ui-accordion-f-accordion-panel-2']/div/ul/li/a"));
     /*       IList<IWebElement> allLinks = driver.FindElements(By.XPath(" //*[@id='aspnetForm']/section[2]/section[2]/section[1]/section/section/section/section[1]"));
            //  System.out.println(allLinks.size());
            Iterator<IWebElement> itr = allLinks.iterator();
            while(itr.hasNext()){
                //
                //    System.out.println(itr.next().getText());
                Console.WriteLine((itr.next().getText()));
            }

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //*[@id="ctl00_cph1_BpoSmartSOAControl_rptAdviserSOA_ctl08_lblAdviser"]
            IWebElement element = driver.FindElement(By.XPath("//*[@id='ctl00_cph1_BpoSmartSOAControl_rptAdviserSOA_ctl08_ancoraccordpanel']"));
            //     ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView();"
            //                                                        , element);

            js.ExecuteScript("arguments[0].click();", element);

            Console.WriteLine("JS CHK ");

            for (int i = 101; i <= 150; i++)
            {*/
                //*[@id="ctl00_cph1_BpoSmartSOAControl_rptAdviserSOA_ctl01_lblAdviser"]
                //  String ss = driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_rgManageAFSL_ctl00__" + i + "']/td[4]")).Text;
                /*         String ss = driver.FindElement(By.XPath(".//*[@id='aspnetForm']/section[2]/section[2]/section[1]/section/section/section/section[1]/ul/li/div/table/tbody/tr[" + i + "]/td[2]")).Text;*/
                //*[@id="ctl00_cph1_BpoSmartSOAControl_rptAdviserSOA_ctl08_ancoraccordpanel"]
                //*[@id="ctl00_cph1_BpoSmartSOAControl_rptAdviserSOA_ctl08_ancoraccordpanel"]
                //  wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("*[@id='ctl00_cph1_BpoSmartSOAControl_rptAdviserSOA_ctl08_ancoraccordpanel']")));
               // String s9 = driver.FindElement(By.XPath("//*[@id='ctl00_cph1_BpoSmartSOAControl_rptAdviserSOA_ct"+i+"_lblAdviser']")).Text;
              
          //       String s9 = driver.FindElement(By.XPath("//*[@id='ctl00_cph1_BpoSmartSOAControl_rptAdviserSOA_ct"+i+"_ancoraccordpanel']")).Text;
           //     Console.WriteLine("Check for S9 IS" + s9);
                Console.WriteLine("Accordian");//*[@id="ctl00_cph1_BpoSmartSOAControl_rptAdviserSOA_ctl08_lblAdviser"]
                var im80 = driver.FindElement(By.XPath("//*[@id='ctl00_cph1_BpoSmartSOAControl_rptAdviserSOA_ctl08_lblAdviser']"));
                Console.WriteLine("Clicked Accordian");
                im80.Click();
                //*[@id="ctl00_cph1_BpoSmartSOAControl_rptAdviserSOA_ctl01_ancoraccordpanel"]
                //   String ss7 = driver.FindElement(By.XPath("//*[@id='ctl00_cph1_BpoSmartSOAControl_rptAdviserSOA_ctl08_dvaccordpanel']/table/tbody/tr[" + i + "]/td[2]")).Text;
   /*             var GivenName = System.Configuration.ConfigurationManager.AppSettings["GivenName"];
                if (s9.Contains(GivenName))
                {
                    String ss7 = driver.FindElement(By.XPath("//*[@id='ctl00_cph1_BpoSmartSOAControl_rptAdviserSOA_ctl08_dvaccordpanel']/table/tbody/tr[" + i + "]/td[2]")).Text;
                    if (ss7.Contains("Request Submitted"))
                    {
                        //*[@id="ctl00_cph1_BpoSmartSOAControl_rptAdviserSOA_ctl08_dvaccordpanel"]/table/tbody/tr[1]/td[7]
                        //*[@id="ctl00_cph1_BpoSmartSOAControl_rptAdviserSOA_ctl08_dvaccordpanel"]/table/tbody/tr[2]/td[7]
                        var im8 = driver.FindElement(By.XPath(" //*[@id='ctl00_cph1_BpoSmartSOAControl_rptAdviserSOA_ctl08_dvaccordpanel']/table/tbody/tr[" + i + "]/td[7]"));
                        im8.Click();
                        Console.WriteLine("Request Submitted Clicked");

                        break;
                    }
                    */
              //  }

          //  }
                    //*[@id="lblSOAStatus"]
                    //*[@id="ctl00_cph1_BpoSmartSOAControl_rptAdviserSOA_ctl08_dvaccordpanel"]/table/tbody/tr[1]/td[2]
                    //*[@id="ctl00_cph1_BpoSmartSOAControl_rptAdviserSOA_ctl08_dvaccordpanel"]/table/tbody/tr[2]/td[2]
                    //  Request Submitted
                    //                                            .//*[@id='aspnetForm']/section[2]/section[2]/section[1]/section/section/section/section[1]/ul/li/div/table/tbody/tr[1]/td[2]
               //     Console.WriteLine("SOA Status is+" + ss7);

           /*     if (ss.Contains("In Progress"))



                {
                    Console.WriteLine("i value is+" + i);

                    var im1 = driver.FindElement(By.XPath(".//*[@id='aspnetForm']/section[2]/section[2]/section[1]/section/section/section/section[1]/ul/li/div/table/tbody/tr[" + i + "]/td[7]"));
                    //                                         .//*[@id='aspnetForm']/section[2]/section[2]/section[1]/section/section/section/section[1]/ul/li/div/table/tbody/tr[1]/td[7]



                    im1.Click();

                    break;
                }
            }*/



            Thread.Sleep(2000);
            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_repProducts_ctl01_hlJumpTo']/span")).Click();
            Console.WriteLine("Click on Cash Flow");
            Thread.Sleep(1000);
            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(6));


            wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='aspnetForm']/section[2]/section[2]/section[1]/section/section/section/section[1]/div[4]/div/div[1]/p[1]")));

            Console.WriteLine("SOA INCLUDE GRID123");
            //      var image14 = driver.FindElement(By.XPath(".//*[@id='LinkButton16']"));
            driver.FindElement(By.XPath(".//*[@id='LinkButton16']")).Click();
            //  image14.Click();
            Thread.Sleep(1000);
            //   .//*[@id='soa_control']/div/div/div[1]/div/ul
            driver.FindElement(By.XPath(".//*[@id='soa_control']/div/div/div[1]/div/ul/li[3]/span/a")).Click();

            Console.WriteLine("CLICK HERE");


            Thread.Sleep(1000);


            //   wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='soa_control']/div/div/div[2]/div[3]/div/ul/li[2]/div/label/span")));

            Console.WriteLine("SOA INCLUDE GRID123");
            driver.FindElement(By.XPath("//*[@id='soa_control']/div/div/div[2]/div[3]/div/ul/li[2]/div/label/span")).Click();

            String SOA1 = driver.FindElement(By.XPath("//*[@id='soa_control']/div/div/div[2]/div[4]/div")).Text;
            Console.WriteLine("SOA1 :" + SOA1);
            if (!(SOA1.Contains("Included in SOA.")))
            {
                driver.FindElement(By.XPath("//*[@id='soa_control']/div/div/div[2]/div[3]/div/ul/li[2]/div/label/span")).Click();
                Console.WriteLine("SOA1 Clicked in Loop");
            }
            //*[@id="soa_control"]/div/div/div[2]/div[4]/div

            //       IWebElement soa1 = driver.FindElement(By.XPath("//*[@id='soa_control']/div/div/div[2]/div[3]/div/ul/li[2]/div/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='soa_control']/div/div/div[2]/div[3]/div/ul/li[2]/div/label/span")).Click();

            String GRAPH1 = driver.FindElement(By.XPath("//*[@id='soa_control']/div/div/div[2]/div[4]/div")).Text;
            Console.WriteLine("Graph1 :" + GRAPH1);
            if (!(GRAPH1.Contains("Included graph in SOA.")))
            {
                driver.FindElement(By.XPath("//*[@id='soa_control']/div/div/div[2]/div[3]/div/ul/li[2]/div/label/span")).Click();
                Console.WriteLine("GRAPH1 Clicked in Loop");
            }



            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='soa_control']/div/div/div[2]/div[3]/div/ul/li[3]/div/label/span")).Click();

            Thread.Sleep(1000);

            IList<IWebElement> iframes = driver.FindElements(By.TagName("iframe"));
            //  driver.FindElements(By.TagName("iframe")).Text;
            int size = iframes.Count;
            Console.WriteLine("Frame SIZE IS :" + size);


            //   Thread.Sleep(1000);
            driver.SwitchTo().Frame(4);

            driver.FindElement(By.CssSelector("body")).Clear();
            IWebElement body4 = driver.FindElement(By.CssSelector("body"));
            Thread.Sleep(1000);
            Console.WriteLine("Frame 4");
            // body3.SendKeys("TESTING...Frames");
            body4.SendKeys("Advise Statement in Financial Position under Cash Flow  ");


            //   Console.WriteLine("Frame 4");

            driver.SwitchTo().DefaultContent();

            Thread.Sleep(2000);


            //      wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='soa_control']/div/div/div[2]")));

            Console.WriteLine("CHK");
            driver.FindElement(By.XPath("//*[@id='soa_control']/div/div/div[2]/div[6]/a[1]")).Click();

            Console.WriteLine("OK");



            //  Thread.Sleep(1000);


            /****************************************************************
                        Thread.Sleep(1000);

                        driver.FindElement(By.XPath("//*[@id='soa_control']/div/div/div[1]/div/ul/li[3]/span/a")).Click();
                        Console.WriteLine("Click Here Inside");
                        Thread.Sleep(2000);

                        //*[@id="MBOXOverallPositionDetailsDiv"]/table/tbody/tr[1]/td[2]
                        wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='MBOXOverallPositionDetailsDiv']/table/tbody/tr[1]/td[2]")));
                        var image26 = driver.FindElement(By.XPath("//*[@id='Image6']"));
                        Console.WriteLine("CHK1111");
                        image26.Click();
                        *************************************************************/
            Thread.Sleep(2000);

            /**********************

            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_Expenses_rgClientExpenseCategory_ctl00_ctl02_ctl00_InitInsertButton']")).Click();
            Console.WriteLine("Click on ADD NEW EXPENSE CATEGORY ");
            Thread.Sleep(2000);



            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_Expenses_rgClientExpenseCategory_ctl00_ctl02_ctl02_txtCategoryNameC']")).Click();
            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_Expenses_rgClientExpenseCategory_ctl00_ctl02_ctl02_txtCategoryNameC']")).SendKeys("JB");
            Console.WriteLine("Enter Name");
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_Expenses_rgClientExpenseCategory_ctl00_ctl02_ctl02_btnUpdateC']")).Click();
            Console.WriteLine("Click on Add");
            Thread.Sleep(2000);



            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_lbBackSummary2']")).Click();
            Console.WriteLine("Click on Back To App");
            Thread.Sleep(2000);


            Thread.Sleep(1000);
            ************************/

            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_repProducts_ctl02_hlJumpTo']/span")).Click();

            Console.WriteLine("Insurance Cover");

            Thread.Sleep(1000);




            // driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_ctl02_soa_control']/div/div/div[1]/div/ul/li[3]/span/a")).Click();
            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_ctl00_soa_control']/div/div/div[1]/div/ul/li[3]/span/a")).Click();

            Console.WriteLine("Click here....Insurance Cover");
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_ctl02_soa_control']/div/div/div[1]/div/ul/li[3]/span/a")).Click();

            Console.WriteLine("Click here....Personal Insurance Cover");
            Thread.Sleep(2000);
            //*[@id="soa_control"]/div/div/div[2]/div[3]/div/ul/li[2]/div/label/span
            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_ctl00_soa_control']/div/div/div[2]/div[3]/div/ul/li[2]/div/label/span")).Click();
            String SOA2 = driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_ctl00_soa_control']/div/div/div[2]/div[4]/div")).Text;
            Console.WriteLine("SOA2 :" + SOA2);
            //*[@id="ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_ctl00_soa_control"]/div/div/div[2]/div[4]/div
            if (!(SOA2.Contains("Included in SOA.")))
            {
                driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_ctl00_soa_control']/div/div/div[2]/div[3]/div/ul/li[2]/div/label/span")).Click();
                Console.WriteLine("SOA Clicked in Loop");
            }
            //*[@id="soa_control"]/div/div/div[2]/div[4]/div

            //       IWebElement soa1 = driver.FindElement(By.XPath("//*[@id='soa_control']/div/div/div[2]/div[3]/div/ul/li[2]/div/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_ctl00_soa_control']/div/div/div[2]/div[3]/div/ul/li[3]/div/label/span")).Click();
            //*[@id="ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_ctl00_soa_control"]/div/div/div[2]/div[4]/div
            String GRAPH2 = driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_ctl00_soa_control']/div/div/div[2]/div[4]/div")).Text;
            Console.WriteLine("GRAPH2 :" + GRAPH2);
            if (!(GRAPH2.Contains("Included graph in SOA.")))
            {
                driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_ctl00_soa_control']/div/div/div[2]/div[3]/div/ul/li[3]/div/label/span")).Click();
                Console.WriteLine("GRAPH2 Clicked in Loop");
            }

            Thread.Sleep(1000);


            //    wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_ctl00_soa_control']/div/div/div[2]/div[5]")));
            Console.WriteLine("Wait for Save 12345 ");
            //var image6 = driver.FindElement(By.XPath(".//*[@id='soa_control']/div/div/div[2]/div[5]/a[1]"));
            //     var image7 = driver.FindElement(By.ClassName("Save"));
            IList<IWebElement> iframes580 = driver.FindElements(By.TagName("iframe"));
            //  driver.FindElements(By.TagName("iframe")).Text;
            int size580 = iframes580.Count;
            Console.WriteLine("Frame SIZE IS :" + size580);


            //   Thread.Sleep(1000);
            driver.SwitchTo().Frame(10);

            driver.FindElement(By.CssSelector("body")).Clear();
            IWebElement body580 = driver.FindElement(By.CssSelector("body"));
            Thread.Sleep(1000);
            Console.WriteLine("Frame 10");
            // body3.SendKeys("TESTING...Frames");
            body580.SendKeys("Advise Statement for Life Cover ");

            //Included in SOA.

            driver.SwitchTo().DefaultContent();

            Thread.Sleep(2000);


            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_ctl00_soa_control']/div/div/div[2]/div[6]/a[1]")).Click();

            Console.WriteLine("LIFE COVER SAVE");
            Thread.Sleep(2000);

            Console.WriteLine("Personal Risk Cover111");


            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_ctl00_soa_control']/div/div/div[1]")));


            Console.WriteLine("Enter into Personal Risk Cover");
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_ctl02_soa_control']/div/div/div[2]/div[3]/div/ul/li[2]/div/label/span")).Click();
            String SOA3 = driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_ctl02_soa_control']/div/div/div[2]/div[4]/div")).Text;
            Console.WriteLine("SOA3 :" + SOA3);
            //*[@id="ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_ctl00_soa_control"]/div/div/div[2]/div[4]/div
            if (!(SOA3.Contains("Included in SOA.")))
            {
                driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_ctl02_soa_control']/div/div/div[2]/div[3]/div/ul/li[2]/div/label/span")).Click();
                Console.WriteLine("SOA Clicked in Loop");
            }
            //*[@id="soa_control"]/div/div/div[2]/div[4]/div

            //       IWebElement soa1 = driver.FindElement(By.XPath("//*[@id='soa_control']/div/div/div[2]/div[3]/div/ul/li[2]/div/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_ctl02_soa_control']/div/div/div[2]/div[3]/div/ul/li[3]/div/label/span")).Click();
            //*[@id="ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_ctl00_soa_control"]/div/div/div[2]/div[4]/div
            String GRAPH3 = driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_ctl02_soa_control']/div/div/div[2]/div[4]/div")).Text;
            Console.WriteLine("GRAPH3 :" + GRAPH3);
            if (!(GRAPH3.Contains("Included graph in SOA.")))
            {
                driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_ctl02_soa_control']/div/div/div[2]/div[3]/div/ul/li[3]/div/label/span")).Click();
                Console.WriteLine("GRAPH3 Clicked in Loop");
            }







            IList<IWebElement> iframes56 = driver.FindElements(By.TagName("iframe"));
            //  driver.FindElements(By.TagName("iframe")).Text;
            int size56 = iframes56.Count;
            Console.WriteLine("Frame SIZE IS :" + size56);


            //   Thread.Sleep(1000);
            driver.SwitchTo().Frame(5);

            driver.FindElement(By.CssSelector("body")).Clear();
            IWebElement body65 = driver.FindElement(By.CssSelector("body"));
            Thread.Sleep(1000);
            Console.WriteLine("Frame 5");
            // body3.SendKeys("TESTING...Frames");
            body65.SendKeys("Advise Statement for Personal Risk Cover 28 Feb 2018 ");


            driver.SwitchTo().DefaultContent();
            //*[@id="ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_ctl00_soa_control"]/div/div/div[2]/div[5]/a[1]

            Thread.Sleep(2000);




            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_ctl02_soa_control']/div/div/div[2]/div[6]/a[1]")).Click();

            Console.WriteLine("Save 4 Insurance Cover");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl02_ctl00_soa_control']/div/div/div[1]/div/ul/li[3]/span/a")).Click();

            Console.WriteLine("Trauma / Critical Illness Cover *");



            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl02_ctl00_soa_control']/div/div/div[2]/div[3]/div/ul/li[2]/div/label/span")).Click();
            String SOA4 = driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl02_ctl00_soa_control']/div/div/div[2]/div[4]/div")).Text;
            Console.WriteLine("SOA4 :" + SOA4);

            //*[@id="ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_ctl00_soa_control"]/div/div/div[2]/div[4]/div
            if (!(SOA4.Contains("Included in SOA.")))
            {
                driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl02_ctl00_soa_control']/div/div/div[2]/div[3]/div/ul/li[2]/div/label/span")).Click();
                Console.WriteLine("SOA4 Clicked in Loop");
            }
            //*[@id="soa_control"]/div/div/div[2]/div[4]/div

            //       IWebElement soa1 = driver.FindElement(By.XPath("//*[@id='soa_control']/div/div/div[2]/div[3]/div/ul/li[2]/div/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl02_ctl00_soa_control']/div/div/div[2]/div[3]/div/ul/li[3]/div/label/span")).Click();
            //*[@id="ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_ctl00_soa_control"]/div/div/div[2]/div[4]/div
            String GRAPH4 = driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl02_ctl00_soa_control']/div/div/div[2]/div[4]/div")).Text;
            Console.WriteLine("G4 :" + GRAPH4);
            if (!(GRAPH4.Contains("Included graph in SOA.")))
            {
                driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl02_ctl00_soa_control']/div/div/div[2]/div[3]/div/ul/li[3]/div/label/span")).Click();
                Console.WriteLine("GRAPH4 Clicked in Loop");
            }


            Thread.Sleep(2000);



            IList<IWebElement> iframes100 = driver.FindElements(By.TagName("iframe"));
            //  driver.FindElements(By.TagName("iframe")).Text;
            int size100 = iframes100.Count;
            Console.WriteLine("Frame SIZE IS :" + size100);


            //   Thread.Sleep(1000);
            driver.SwitchTo().Frame(15);

            driver.FindElement(By.CssSelector("body")).Clear();
            IWebElement body100 = driver.FindElement(By.CssSelector("body"));
            Thread.Sleep(1000);
            Console.WriteLine("Frame 15");
            // body3.SendKeys("TESTING...Frames");
            body100.SendKeys("Advise Statement for Trauma / Critical Illness Cover 28*Feb 2018 ");

            driver.SwitchTo().DefaultContent();


            Thread.Sleep(2000);


            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl02_ctl00_soa_control']/div/div/div[2]/div[6]/a[1]")).Click();


            Thread.Sleep(3000);
            //*[@id="ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl01_ctl00_soa_control"]/div/div/div[1]/div/ul/li[3]/span/a
            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl01_ctl00_soa_control']/div/div/div[1]/div/ul/li[3]/span/a")).Click();
            Thread.Sleep(3000);



            //*[@id="soa_control"]/div/div/div[2]/div[3]/div/ul/li[3]/div/label/span
            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl01_ctl00_soa_control']/div/div/div[2]/div[3]/div/ul/li[2]/div/label/span")).Click();
            String SOA5 = driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl01_ctl00_soa_control']/div/div/div[2]/div[4]/div")).Text;
            Console.WriteLine("SOA5 :" + SOA5);
            //*[@id="ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_ctl00_soa_control"]/div/div/div[2]/div[4]/div
            if (!(SOA5.Contains("Included in SOA.")))
            {
                driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl01_ctl00_soa_control']/div/div/div[2]/div[3]/div/ul/li[2]/div/label/span")).Click();
                Console.WriteLine("SOA5 Clicked in Loop");
            }
            //*[@id="soa_control"]/div/div/div[2]/div[4]/div

            //       IWebElement soa1 = driver.FindElement(By.XPath("//*[@id='soa_control']/div/div/div[2]/div[3]/div/ul/li[2]/div/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl01_ctl00_soa_control']/div/div/div[2]/div[3]/div/ul/li[3]/div/label/span")).Click();
            //*[@id="ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_ctl00_soa_control"]/div/div/div[2]/div[4]/div
            String GRAPH5 = driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl01_ctl00_soa_control']/div/div/div[2]/div[4]/div")).Text;
            Console.WriteLine("G5 :" + GRAPH5);
            if (!(GRAPH5.Contains("Included graph in SOA.")))
            {
                driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl01_ctl00_soa_control']/div/div/div[2]/div[3]/div/ul/li[3]/div/label/span")).Click();
                Console.WriteLine("GRAPH5 Clicked in Loop");
            }
            //   driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl01_ctl00_soa_control']/div/div/div[2]/div[3]/div/ul/li[3]/div/label/span")).Click();
            Console.WriteLine("T.P.D. Cover *");
            Thread.Sleep(2000);


            IList<IWebElement> iframes123 = driver.FindElements(By.TagName("iframe"));
            //  driver.FindElements(By.TagName("iframe")).Text;
            int size123 = iframes123.Count;
            Console.WriteLine("Frame SIZE IS :" + size123);


            //   Thread.Sleep(1000);
            driver.SwitchTo().Frame(15);

            driver.FindElement(By.CssSelector("body")).Clear();
            IWebElement body123 = driver.FindElement(By.CssSelector("body"));
            Thread.Sleep(1000);
            Console.WriteLine("Frame 15");
            // body3.SendKeys("TESTING...Frames");
            body123.SendKeys("Advise Statement for TPD  ");

            driver.SwitchTo().DefaultContent();
            //*[@id="ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_ctl00_soa_control"]/div/div/div[2]/div[5]/a[1]

            Thread.Sleep(3000);
            //*[@id="ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl01_ctl00_soa_control"]/div/div/div[2]/div[5]/a[1]
            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl01_ctl00_soa_control']/div/div/div[2]/div[6]/a[1]")).Click();

            Console.WriteLine("SAVE TPD ");

            Thread.Sleep(3000);



            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl03_ctl00_soa_control']/div/div/div[1]/div/ul/li[3]/span/a")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl03_ctl00_soa_control']/div/div/div[2]/div[3]/div/ul/li[2]/div/label/span")).Click();
            String SOA6 = driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl03_ctl00_soa_control']/div/div/div[2]/div[4]/div")).Text;
            Console.WriteLine("SOA6 :" + SOA6);
            //*[@id="ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_ctl00_soa_control"]/div/div/div[2]/div[4]/div
            if (!(SOA6.Contains("Included in SOA.")))
            {
                driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl03_ctl00_soa_control']/div/div/div[2]/div[3]/div/ul/li[2]/div/label/span")).Click();
                Console.WriteLine("SOA5 Clicked in Loop");
            }

            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl03_ctl00_soa_control']/div/div/div[2]/div[3]/div/ul/li[3]/div/label/span")).Click();
            //*[@id="ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_ctl00_soa_control"]/div/div/div[2]/div[4]/div
            String GRAPH6 = driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl03_ctl00_soa_control']/div/div/div[2]/div[4]/div")).Text;
            Console.WriteLine("G6 :" + GRAPH6);
            if (!(GRAPH6.Contains("Included graph in SOA.")))
            {
                driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl03_ctl00_soa_control']/div/div/div[2]/div[3]/div/ul/li[3]/div/label/span")).Click();
                Console.WriteLine("GRAPH6 Clicked in Loop");
            }



            IList<IWebElement> iframes196 = driver.FindElements(By.TagName("iframe"));
            //  driver.FindElements(By.TagName("iframe")).Text;
            int size196 = iframes196.Count;
            Console.WriteLine("Frame SIZE IS :" + size196);


            //   Thread.Sleep(1000);
            driver.SwitchTo().Frame(25);

            driver.FindElement(By.CssSelector("body")).Clear();
            IWebElement body196 = driver.FindElement(By.CssSelector("body"));
            Thread.Sleep(1000);
            Console.WriteLine("Frame 25");
            // body3.SendKeys("TESTING...Frames");
            body196.SendKeys("Advise Statement for Income Protection Cover ");


            driver.SwitchTo().DefaultContent();
            //*[@id="ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_ctl00_soa_control"]/div/div/div[2]/div[5]/a[1]

            Thread.Sleep(3000);


            //*[@id="ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl03_ctl00_soa_control"]/div/div/div[2]/div[5]/a[1]

            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl03_ctl00_soa_control']/div/div/div[2]/div[6]/a[1]")).Click();
            Console.WriteLine("SAVE----INSURANCE");

            Thread.Sleep(3000);

            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_repProducts_ctl03_hlJumpTo']/span")).Click();

            Console.WriteLine("Click on Super");

            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//*[@id='soa_control']/div/div/div[1]/div/ul/li[3]/span/a")).Click();

            Console.WriteLine("ClickHere");

            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//*[@id='soa_control']/div/div/div[2]/div[3]/div/ul/li[2]/div/label/span")).Click();
            String SOA7 = driver.FindElement(By.XPath("//*[@id='soa_control']/div/div/div[2]/div[3]/div/ul/li[2]/div/label/span")).Text;
            Console.WriteLine("SOA7 :" + SOA7);
            //*[@id="ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_ctl00_soa_control"]/div/div/div[2]/div[4]/div
            if (!(SOA7.Contains("Included in SOA.")))
            {
                driver.FindElement(By.XPath("//*[@id='soa_control']/div/div/div[2]/div[3]/div/ul/li[2]/div/label/span")).Click();
                Console.WriteLine("SOA7 Clicked in Loop");
            }

            driver.FindElement(By.XPath("//*[@id='soa_control']/div/div/div[2]/div[3]/div/ul/li[3]/div/label/span")).Click();
            //*[@id="ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_ctl00_soa_control"]/div/div/div[2]/div[4]/div
            String GRAPH7 = driver.FindElement(By.XPath("//*[@id='soa_control']/div/div/div[2]/div[4]/div")).Text;
            Console.WriteLine("G7 :" + GRAPH7);
            if (!(GRAPH7.Contains("Included graph in SOA.")))
            {
                driver.FindElement(By.XPath("//*[@id='soa_control']/div/div/div[2]/div[3]/div/ul/li[3]/div/label/span")).Click();
                Console.WriteLine("GRAPH7 Clicked in Loop");
            }






            Thread.Sleep(1000);
            driver.SwitchTo().Frame(7);
            driver.FindElement(By.CssSelector("body")).Clear();
            IWebElement body704 = driver.FindElement(By.CssSelector("body"));
            Thread.Sleep(1000);
            Console.WriteLine("Frame 7");
            // body3.SendKeys("TESTING...Frames");
            body704.SendKeys("Test for Super 28 Feb 2018");
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(3000);

            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='soa_control']/div/div/div[2]/div[6]/a[1]")));
            driver.FindElement(By.XPath("//*[@id='soa_control']/div/div/div[2]/div[6]/a[1]")).Click();
            //*[@id="soa_control"]/div/div/div[2]/div[5]/a[1]

            Console.WriteLine("SAVE SUPER");

            Thread.Sleep(3000);




            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_hlESTATE']")).Click();
            Console.WriteLine("Estate Planning ");
            Thread.Sleep(3000);

            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_EstatePlanningControl_ctl00_soa_control']/div/div/div[1]/div/ul/li[3]/span/a")).Click();
            Console.WriteLine("Click Here ");
            Thread.Sleep(2000);



            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_EstatePlanningControl_ctl00_soa_control']/div/div/div[2]/div[3]/div/ul/li[2]/div/label/span")).Click();
            String SOA8 = driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_EstatePlanningControl_ctl00_soa_control']/div/div/div[2]/div[4]/div")).Text;
            Console.WriteLine("SOA8 :" + SOA8);
            //*[@id="ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_ctl00_soa_control"]/div/div/div[2]/div[4]/div
            if (!(SOA8.Contains("Included in SOA.")))
            {
                //*[@id='ctl00_ctl00_cph1_cph1_EstatePlanningControl_ctl00_soa_control']/div/div/div[2]/div[3]/div/ul/li[2]/div/label/span
                driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_EstatePlanningControl_ctl00_soa_control']/div/div/div[2]/div[3]/div/ul/li[2]/div/label/span")).Click();
                Console.WriteLine("SOA8 Clicked in Loop");
            }

            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_EstatePlanningControl_ctl00_soa_control']/div/div/div[2]/div[3]/div/ul/li[3]/div/label/span")).Click();
            //*[@id="ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_ctl00_soa_control"]/div/div/div[2]/div[4]/div
            String GRAPH8 = driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_EstatePlanningControl_ctl00_soa_control']/div/div/div[2]/div[4]/div")).Text;
            Console.WriteLine("G8 :" + GRAPH8);
            if (!(GRAPH8.Contains("Included graph in SOA.")))
            {
                driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_EstatePlanningControl_ctl00_soa_control']/div/div/div[2]/div[3]/div/ul/li[3]/div/label/span")).Click();
                Console.WriteLine("GRAPH8 Clicked in Loop");
            }


            IList<IWebElement> iframes8 = driver.FindElements(By.TagName("iframe"));
            //  driver.FindElements(By.TagName("iframe")).Text;
            int size8 = iframes8.Count;
            Console.WriteLine("Frame SIZE IS :" + size8);


            //   Thread.Sleep(1000);
            driver.SwitchTo().Frame(4);

            driver.FindElement(By.CssSelector("body")).Clear();
            IWebElement body48 = driver.FindElement(By.CssSelector("body"));
            Thread.Sleep(1000);
            Console.WriteLine("Frame 4");
            // body3.SendKeys("TESTING...Frames");
            body48.SendKeys("Advise Statement in EP MARCH ");


            //   Console.WriteLine("Frame 4");

            driver.SwitchTo().DefaultContent();

            Thread.Sleep(2000);


            //      wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='soa_control']/div/div/div[2]")));

            Console.WriteLine("CHK");
            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_EstatePlanningControl_ctl00_soa_control']/div/div/div[2]/div[6]/a[1]")).Click();

            //*[@id="ctl00_ctl00_cph1_cph1_EstatePlanningControl_ctl00_soa_control"]/div/div/div[2]/div[5]/a[1]

            Console.WriteLine("OK");






            /**********************
            Thread.Sleep(3000);

            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_hlDEBT']")).Click();
            Console.WriteLine("Debt Manager");
            Thread.Sleep(3000);

            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_SmartDebt_balancedate']")).Clear();
            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_SmartDebt_balancedate']")).SendKeys("01/01/2017");
            Console.WriteLine("bALANCE dATE ");
            Thread.Sleep(3000);


            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_SmartDebt_monthlypayment']")).Clear();

            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_SmartDebt_monthlypayment']")).SendKeys("$84");

            Console.WriteLine("Monthly Payment");

            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_SmartDebt_btnCalc']")).Click();

            Console.WriteLine("Calculate Result");

            Thread.Sleep(2000);
            *****************/
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_hlSOA']")).Click();
            Console.WriteLine("Click on Smart SOA  ");

            Thread.Sleep(3000);

            //*[@id="ctl00_ctl00_cph1_cph1_SOAControl_StrategyReview"]/div/div/div/div/ul/li[1]/a/span
            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_SOAControl_BpoStatementReview']/div/div/div/div/ul/li[1]/a")).Click();

            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_SOAControl_BpoStatementReview']/div/div/div/div/ul/li[1]/div/ul/li[1]/a")).Click();

            Thread.Sleep(2000);



            IJavaScriptExecutor js55 = (IJavaScriptExecutor)driver;
            IWebElement element55 = driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_SOAControl_BpoStatementReview']/div/div/div/div/ul/li[1]/div/ul/li[1]/div/div/div[2]/div[4]"));
            //     ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView();"
            //                                                        , element);

            js55.ExecuteScript("arguments[0].scrollIntoView();", element55);
            //*[@id="ctl00_ctl00_cph1_cph1_SOAControl_StrategyReview"]/div/div/div/div/ul/li[1]/a/span



            Thread.Sleep(2000);


            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_SOAControl_BpoStatementReview']/div/div/div/div/ul/li[1]/div/ul/li[1]/div/div/div[2]/div[3]/div/ul/li[2]/div/label/span")).Click();
            String SOA9 = driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_SOAControl_BpoStatementReview']/div/div/div/div/ul/li[1]/div/ul/li[1]/div/div/div[2]/div[4]/div")).Text;
            Console.WriteLine("SOA9 :" + SOA9);
            //*[@id="ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_ctl00_soa_control"]/div/div/div[2]/div[4]/div
            if (!(SOA9.Contains("Included in SOA.")))
            {
                //*[@id='ctl00_ctl00_cph1_cph1_EstatePlanningControl_ctl00_soa_control']/div/div/div[2]/div[3]/div/ul/li[2]/div/label/span
                driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_SOAControl_BpoStatementReview']/div/div/div/div/ul/li[1]/div/ul/li[1]/div/div/div[2]/div[3]/div/ul/li[2]/div/label/span")).Click();
                Console.WriteLine("SOA9 Clicked in Loop");
            }

            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_SOAControl_BpoStatementReview']/div/div/div/div/ul/li[1]/div/ul/li[1]/div/div/div[2]/div[3]/div/ul/li[3]/div/label/span")).Click();
            //*[@id="ctl00_ctl00_cph1_cph1_InsuranceCover_dlInsuranceType_ctl00_ctl00_soa_control"]/div/div/div[2]/div[4]/div
            String GRAPH9 = driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_SOAControl_BpoStatementReview']/div/div/div/div/ul/li[1]/div/ul/li[1]/div/div/div[2]/div[4]/div")).Text;
            Console.WriteLine("G9 :" + GRAPH9);
            if (!(GRAPH9.Contains("Included graph in SOA.")))
            {
                driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_SOAControl_BpoStatementReview']/div/div/div/div/ul/li[1]/div/ul/li[1]/div/div/div[2]/div[3]/div/ul/li[3]/div/label/span")).Click();
                Console.WriteLine("GRAPH9 Clicked in Loop");
            }

            Thread.Sleep(3000);
            IList<IWebElement> iframes4 = driver.FindElements(By.TagName("iframe"));

            int size4 = iframes4.Count;
            Console.WriteLine("Frame 4 is :" + size4);


            driver.SwitchTo().Frame(4);


            driver.FindElement(By.CssSelector("body")).Clear();


            Console.WriteLine("Frame 4");



            IWebElement body42 = driver.FindElement(By.CssSelector("body"));
            Thread.Sleep(1000);
            body42.SendKeys("Final Strategy Test 28 February");

            Console.WriteLine(body42.Text);
            //  Console.WriteLine("Frame 1");
            driver.SwitchTo().DefaultContent();



            Thread.Sleep(3000);

            Console.WriteLine("Doc to Upload ");
            var image22 = driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_SOAControl_BpoStatementReview']/div/div/div/div/ul/li[1]/div/ul/li[1]/div/div/div[2]/div[6]/a[1]"));
            image22.Click();

            //  driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_SOAControl_BpoStatementReview']/div/div/div/div/ul/li[1]/div/ul/li[2]/a/span")).Click();

            Console.WriteLine("Click on FP  ");

            Thread.Sleep(3000);

            //*[@id="ctl00_ctl00_cph1_cph1_SOAControl_BpoStatementReview"]/div/div/div/div/ul/li[1]/a

            SelectElement oSelection = new SelectElement(driver.FindElement(By.XPath(".//*[@id='ddlSOATemplates']")));

            oSelection.SelectByText("AspectFP SOA Template");

            Console.WriteLine("Template Selection ");

            IWebElement Filename = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_SOAControl_txtFilename']"));


            var txtFilename = System.Configuration.ConfigurationManager.AppSettings["txtFilename"];


            Console.WriteLine(string.Format("Given Name is : ", txtFilename));
            Filename.SendKeys(txtFilename);

            Console.WriteLine("Enter Filename");

            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_SOAControl_btnRefresh_SOA']")).Click();
            Console.WriteLine("Click on New SOA Doc button ");

            //  driver.FindElement(By.XPath("//div[contains(@class,'callout callout-success')]")).Click();
            Console.WriteLine("Wait for Success message Element");




            Thread.Sleep(3000);
            String message = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_SOAControl_pnlCreateSOA']/div/div/div/div[3]/div[2]/span/span")).Text;
            Console.WriteLine("Success message is :" + message);
            Thread.Sleep(2000);
            //    Assert.IsTrue(message.Contains("SOA document created successfully."), message + " doesn't contains 'message.'");
            Assert.IsTrue(message.Contains("SOA"), message + " doesn't contains 'message.'");
            //  string title = driver.Title;
            Console.WriteLine("Successfully Created ");

            Thread.Sleep(4000);
            //    wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_SOAControl_rgSOA_ctl00__0']/td[4]")));

            var image7 = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_SOAControl_rgSOA_ctl00__0']/td[4]/div/label/span"));
            image7.Click();
            Console.WriteLine("Finalise");

            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_SOAControl_pnlFinalizeSOA']/div/div/div/div")));

            var image6 = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_SOAControl_btnFinalize_SOA']"));
            // var image6 = driver.FindElement(By.ClassName("panel -switch js - SOA - finalise"));
            image6.Click();
            Console.WriteLine("Clicked on Finalised SOA Doc ");
            //  "SOA Finalised."
            Thread.Sleep(2000);
            String message2 = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_SOAControl_pnlFinalizeSOA']/div/div/div/div/div[2]/span/span")).Text;

            Assert.IsTrue(message2.Contains("SOA"), message2 + " doesn't contains 'message.'");//Finalising SOA... 

            //  string title = driver.Title;
            Console.WriteLine("Success7....");


            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            IWebElement element1 = driver.FindElement(By.XPath(".//*[@id='aspnetForm']/section[2]/section[2]/section[1]/section/footer/div"));
            //     ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView();"
            //                                                        , element);

            js1.ExecuteScript("arguments[0].scrollIntoView();", element1);

            Thread.Sleep(2000);

            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_HyperLink121']")).Click();
            Console.WriteLine("Click on MyDashboard");

            Thread.Sleep(2000);

            driver.FindElement(By.XPath(" .//*[@id='ctl00_cph1_hlAdviserSmartSOA']")).Click();
            Console.WriteLine("Click on SOA Request");

        }
      }
   }
