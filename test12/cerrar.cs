using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace test12
{
    internal class cerrar
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://localhost/login-register/jecto/index.php");
            driver.Manage().Window.Maximize(); //



            //prueba 1
            //correo incorecto
            IWebElement input = driver.FindElement(By.Id("correo"));
            input.SendKeys("odanisoto.19@gmail.com");

            //ingresar contrasena
            IWebElement cnt = driver.FindElement(By.Id("password"));
            cnt.SendKeys("1234");

            //pulsar el btn inicio de seccion

            IWebElement btn = driver.FindElement(By.Id("btn_entrar"));
            btn.Click();

            IWebElement btn1 = driver.FindElement(By.Id("btnCrear"));
            btn1.Click();

            IWebElement btn2 = driver.FindElement(By.Id("close"));
            btn2.Click();

            System.Threading.Thread.Sleep(2000);
        }
    }
}
