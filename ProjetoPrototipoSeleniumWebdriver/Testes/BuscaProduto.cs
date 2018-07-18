using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using ProjetoPrototipoSeleniumWebdriver.Base;
using ProjetoPrototipoSeleniumWebdriver.Page;

namespace ProjetoPrototipoSeleniumWebdriver.Testes
{
    [TestClass]
    public class BuscaProduto
    {
        private IWebDriver navegador;
        private PaginaPrincipal pesquiasrProduto = new PaginaPrincipal();

        [TestInitialize]
        public void iniciarTeste()
        {
            navegador = BasePage.criarChrome();
        }

        [TestMethod]
        public void realizarBusca()
        {
            //localizar o produto
            pesquiasrProduto.busca(navegador,"Notebook");
        }

        [TestCleanup]
        public void finalizarTeste()
        {
            //finalizar o navegador
            navegador.Close();
        }
    }
}
