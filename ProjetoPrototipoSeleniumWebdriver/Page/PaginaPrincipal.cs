using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace ProjetoPrototipoSeleniumWebdriver.Page
{
    [TestClass]
    public class PaginaPrincipal
    {
        public void busca(IWebDriver navegador, String texto)
        {
            //localizar o campo de busca/pesquisa
            navegador.FindElement(By.Name("q")).SendKeys(texto + Keys.Enter);

        }
    }
}
