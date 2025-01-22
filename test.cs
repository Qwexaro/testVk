using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitTestProject2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";


            driver.Navigate().GoToUrl("https://vk.com");
            IWebElement log = driver.FindElement(By.Id("index_email"));
            log.SendKeys("sjka@kja.da");
            IWebElement btn = driver.FindElement(By.CssSelector("#index_login > div > form > button > span"));
            btn.Submit();
            //IWebDriver butn = driver.FindElement(By.CssSelector()); 
            driver.Close();
        //    Assert.Pass();
        }
    }
}
