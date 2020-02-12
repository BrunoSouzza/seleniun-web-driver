using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new FirefoxDriver();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl("http://google.com.br");
            driver.FindElement(By.Name("q")).SendKeys("cheese" + Keys.Enter);
            IWebElement firstResult = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("h3>div")));
            Console.WriteLine(firstResult.GetAttribute("textContent"));

            string url = driver.Url;
            Console.WriteLine(url);
            Console.ReadKey();
        }
    }
}
