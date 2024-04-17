using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace test6
{
    internal class desplegarfdeinicio
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://localhost/login-register/jecto/index.php");
            driver.Manage().Window.Maximize(); //



            //5to caso


            //pulsa btn registrarse
            IWebElement btn1 = driver.FindElement(By.Id("btn__registrarse"));
            btn1.Click();

            IWebElement btn = driver.FindElement(By.Id("btn__iniciar-sesion"));
            btn.Click();

            System.Threading.Thread.Sleep(2000);
        }
    }
}
