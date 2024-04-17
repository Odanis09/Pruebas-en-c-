using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace test7
{
    internal class correoregistrado
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://localhost/login-register/jecto/index.php");
            driver.Manage().Window.Maximize(); //


            //prueba 3
            //contrasena incorecto
            IWebElement btn1 = driver.FindElement(By.Id("btn__registrarse"));
            btn1.Click();

            IWebElement input = driver.FindElement(By.Name("nombre_completo"));
            input.SendKeys("Odanis Soto");

            IWebElement input2 = driver.FindElement(By.Name("correo"));
            input.SendKeys("odanisoto.19@gmail.com");

            IWebElement input3 = driver.FindElement(By.Name("usuario"));
            input.SendKeys("SotoA");


            IWebElement cnt = driver.FindElement(By.Name("contrasena"));
            cnt.SendKeys("2345");



            IWebElement btn = driver.FindElement(By.Id("btn_registrar"));
            btn.Click();

            System.Threading.Thread.Sleep(2000);

        }
    }
}
