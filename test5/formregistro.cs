using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test5
{
    internal class formregistro
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://localhost/login-register/jecto/index.php");
            driver.Manage().Window.Maximize(); //



            //5to caso


            //pulsa btn registrarse

            IWebElement btn = driver.FindElement(By.Id("btn__registrarse"));
            btn.Click();

            System.Threading.Thread.Sleep(2000);
        }
    }
}
