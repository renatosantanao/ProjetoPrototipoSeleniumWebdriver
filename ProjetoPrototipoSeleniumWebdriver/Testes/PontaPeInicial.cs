using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ProjetoPrototipoSeleniumWebdriver
{
    [TestClass]
    public class UnitTest1
    {

        public IWebDriver driver;

        [TestInitialize]
        public void iniciarTestes()
        {
            driver = new ChromeDriver();
        }
        
        [TestMethod]
        public void TestMethod1()
        {

            //Navegando na url informada
            driver.Navigate().GoToUrl("http:www.google.com");

            //definindo uma variavel para receber o elemento a ser utilizado
            IWebElement element = driver.FindElement(By.Name("q"));

            //digitar um texto no campo busca
            element.SendKeys("Testes automatizados");

            //utilizando tecla Enter para realizar a pesquisa
            element.SendKeys(Keys.Enter);

        }

        [TestCleanup]
        public void finalizarTeste()
        {
            driver.Close();
        }
    }
}
