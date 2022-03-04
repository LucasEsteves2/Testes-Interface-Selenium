using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;
using Xunit;

namespace TestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void TesteTela()
        {
            //Arrange
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            //Act
            driver.Navigate().GoToUrl("https://www.facebook.com/");
           var email = driver.FindElement(By.Id("email"));
           var senha = driver.FindElement(By.Id("pass"));

            email.SendKeys("luqui25 ");
            senha.SendKeys("40028922");
            senha.SendKeys("" +
                "") ;

            //Assert
            Assert.Contains("O Facebook ajuda você a se conectar e compartilhar com as pessoas que fazem parte da sua vida.", driver.PageSource);
        }
    }
}
