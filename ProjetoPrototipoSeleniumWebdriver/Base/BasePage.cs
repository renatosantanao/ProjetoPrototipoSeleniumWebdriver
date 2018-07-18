using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ProjetoPrototipoSeleniumWebdriver.Base
{
    [TestClass]
    public class BasePage
    {
        public static IWebDriver criarChrome()
        {
            // iniciando variavel para receber capacidades do google chrome
            IWebDriver navegador = new ChromeDriver();
            
            //definindo o tempo para carrega a página que o webdriver deve aguardar
            navegador.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

            //definindo ulr a ser utilizada para o teste
            navegador.Navigate().GoToUrl("www.pontofrio.com.br");

            return navegador;
        }
    }
}
