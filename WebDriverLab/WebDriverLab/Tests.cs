using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;


namespace WebDriver
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://htc-online.ru");
        }

        [Test]
        public void Test1()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IWebElement accessoriesForSmartphonesButton = wait.Until(ExpectedConditions.ElementExists(By.XPath("//a[text() = 'Аксессуары для смартфонов']")));
            accessoriesForSmartphonesButton.Click();

            IWebElement audioButton = wait.Until(ExpectedConditions.ElementExists(By.XPath("//a[text() = 'аудио']")));
            audioButton.Click();

            IWebElement originalAdapterButton = wait.Until(ExpectedConditions.ElementExists(By.XPath("//span[text() = 'Оригинальный адаптер с Type C на 3,5 мм (DC M321)']")));
            originalAdapterButton.Click();

            IWebElement buyButton = wait.Until(ExpectedConditions.ElementExists(By.XPath("//a[text() = 'Купить']")));
            buyButton.Click();

            IWebElement goToBusketButton = wait.Until(ExpectedConditions.ElementExists(By.XPath("//span[text() = 'Перейти в корзину']")));
            goToBusketButton.Click();

            IWebElement originalAdapterButtonInBusket = wait.Until(ExpectedConditions.ElementExists(By.XPath("//span[text() = 'Оригинальный адаптер с Type C на 3,5 мм (DC M321)']")));

            Assert.IsNotNull(originalAdapterButtonInBusket);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}