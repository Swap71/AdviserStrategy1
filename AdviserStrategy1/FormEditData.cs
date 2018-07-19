using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdviserStrategy1
{
    class FormEditData
    {

        [FindsBy(How = How.XPath, Using = ".//*[@id='GivenName']")] // Imp

        public IWebElement Givenname2 { get; set; }
        

         [FindsBy(How = How.XPath, Using = ".//*[@id='Surname']")] // Imp
        public IWebElement Surname2 { get; set; }

       // public IWebElement Givenname2 { get; set; }
        
            
         [FindsBy(How = How.XPath, Using = ".//*[@id='Email']")] // Imp
        public IWebElement Email2 { get; set; }

        public void EnterGivenName2(string givenName)

        {

            Givenname2.Clear();

            Givenname2.SendKeys(givenName);


        }
        public void EnterSurName2(string surName)

        {

            Surname2.Clear();

            Surname2.SendKeys(surName);


        }
        public void EnterEmail2(string emailName)

        {

            Email2.Clear();

            Email2.SendKeys(emailName);


        }



    }
}
