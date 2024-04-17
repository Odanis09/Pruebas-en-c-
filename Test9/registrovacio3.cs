using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Test9
{
    internal class registrovacio3
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://localhost/login-register/jecto/index.php");
            driver.Manage().Window.Maximize(); //

            IWebElement btn1 = driver.FindElement(By.Id("btn__registrarse"));
            btn1.Click();

            //7mo caso
            IWebElement input = driver.FindElement(By.Id("usuariox"));
            input.SendKeys("alejandro.23@gmail.com ");

            //pulsa btn registrarse

            IWebElement btn = driver.FindElement(By.Id("btn_registrar"));
            btn.Click();

            System.Threading.Thread.Sleep(2000);
        }
    }
}
