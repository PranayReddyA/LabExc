using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;
using OpenQA.Selenium.Edge;

namespace LabExc
{
    [TestClass]
    public class SeleniumTest
    {
        [DataTestMethod]
        [DataRow("CH","pranay@google.com","pranay","message","click")]
        [DataRow("FF","ashok@google.com","ashok","meg1","click")] 
        [DataRow("EDGE","kalyani@google.com","kalyani","text","click")] 
        // [Ignore]
        public void TestMethod1(string op1, string op2, string op3, string op4, string op5)
        {
            IWebDriver driver;
            if (op1 == "CH")
            {
                driver = new ChromeDriver(@"C:\Root\WebDriver");
            }
            else if (op1 == "FF")
            {
                driver = new FirefoxDriver(@"C:\Root\WebDriver");
            }

            //new addeds 
            else
            {
                driver = new EdgeDriver(@"C:\Root\WebDriver");
            }
             
            driver.Navigate().GoToUrl("https://www.demoblaze.com");
            IWebElement Contact = driver.FindElement(By.LinkText("Contact"));
            Contact.Click();
            Thread.Sleep(5000);

            IWebElement ContactEmail = driver.FindElement(By.Id("recipient-email"));
            ContactEmail.SendKeys(op2);
            Thread.Sleep(2000);

            IWebElement ContactName = driver.FindElement(By.Id("recipient-name"));
            ContactName.SendKeys(op3);
            Thread.Sleep(2000);
            
            IWebElement Message = driver.FindElement(By.Id("message-text"));
            Message.SendKeys(op4);
            Thread.Sleep(2000);

            IWebElement Close = driver.FindElement(By.ClassName("btn btn-secondary"));
            Close.Click();
            Thread.Sleep(2000);

            driver.Quit();
        }

        // [TestMethod]
        // [Ignore]
        // public void TestMethod2()
        // {
        //     IWebDriver driver =new ChromeDriver(@"C:\Root\WebDriver");
        //     driver.Navigate().GoToUrl("https://www.google.com");
        //     IWebElement SearchText=driver.FindElement(By.Name("q"));
        //     SearchText.SendKeys("cigniti"+Keys.Return);
        //     Thread.Sleep(5000);
        //     driver.Quit();
        // }

        // [DataTestMethod]
        // [Ignore]
        // [DataRow ("dell")]
        // [DataRow ("tata")]
        // [DataRow ("insta")]
        // public void TestMethod3(string op1)
        // {
        //     IWebDriver driver =new ChromeDriver(@"C:\Root\WebDriver");
        //     driver.Navigate().GoToUrl("https://www.google.com");
        //     IWebElement SearchText=driver.FindElement(By.Name("q"));
        //     SearchText.SendKeys(op1+Keys.Return);
        //     Thread.Sleep(5000);
        //     driver.Quit();
        // }

        // [DataTestMethod]
        // [DataRow ("FF","https://www.flipkart.com")]
        // [DataRow ("CH","https://www.linkedin.com")]
        // public void LaunchBrowser (string browser, string url)
        // {
        //     IWebDriver driver;
        //     if (browser=="FF")
        //     {
        //         driver=new FirefoxDriver(@"C:\Root\WebDriver");
        //     }
        //     else
        //     {
        //         driver=new ChromeDriver(@"C:\Root\WebDriver");
        //     }
        //     driver.Navigate().GoToUrl(url);
        //     Thread.Sleep(5000);
        //     driver.Quit();
        // }
    }
}
