using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    internal class camposdeloginvacios
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://localhost/login-register/jecto/index.php");
            driver.Manage().Window.Maximize(); //


            //prueba 3
            //contrasena incorecto
            IWebElement input = driver.FindElement(By.Id("correo"));
            input.SendKeys(" ");

            IWebElement cnt = driver.FindElement(By.Id("password"));
            cnt.SendKeys("");



            IWebElement btn = driver.FindElement(By.Id("btn_entrar"));
            btn.Click();

            System.Threading.Thread.Sleep(2000);

        }
    }
}

