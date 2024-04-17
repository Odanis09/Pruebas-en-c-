using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace test3
{
    internal class contrasenaincorrecta
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://localhost/login-register/jecto/index.php");
            driver.Manage().Window.Maximize(); //


            //prueba 3
            //contrasena incorecto
            IWebElement input = driver.FindElement(By.Id("correo"));
            input.SendKeys("odanisoto.19@gmail.com");

            IWebElement cnt = driver.FindElement(By.Id("password"));
            cnt.SendKeys("8765");

        

            IWebElement btn = driver.FindElement(By.Id("btn_entrar"));
            btn.Click();

            System.Threading.Thread.Sleep(2000);

        }
    }
}
