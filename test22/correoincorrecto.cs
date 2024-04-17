using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace test22
{
    internal class correoincorrecto
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://localhost/login-register/jecto/index.php");
            driver.Manage().Window.Maximize(); //



            //prueba 2
           //correo incorecto
            IWebElement input = driver.FindElement(By.Id("correo"));
            input.SendKeys("santoayudameDios");

            //ingresar contrasena
            IWebElement cnt = driver.FindElement(By.Id("password"));
            cnt.SendKeys("1234");

            //pulsar el btn inicio de seccion

            IWebElement btn = driver.FindElement(By.Id("btn_entrar"));
            btn.Click();

            System.Threading.Thread.Sleep(2000);

        }
    }
}
