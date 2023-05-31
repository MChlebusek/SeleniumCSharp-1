using System;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.Drawing.Printing;


namespace SeleniumCS;

public class firstTestclass
{


    [Fact]
    public void Navigation()
    {


        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.selenium.dev/projects/");
        driver.Manage().Window.Maximize();

        driver.FindElement(By.LinkText("Support")).Click();
        //Back

        driver.Navigate().Back();
        Thread.Sleep(2000);

        //Forward
        driver.Navigate().Forward();
        Thread.Sleep(2000);
        driver.FindElement(By.ClassName("DocSearch-Button-Placeholder")).Click();
        Thread.Sleep(2000);
        //Refresh
        driver.Navigate().Refresh();
        Thread.Sleep(2000);
    
        driver.Quit();




    }




    [Fact]
    public void Wikipedia()
    {

        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.wikipedia.org/");
        driver.Manage().Window.Maximize();
        List<string> CentralLanguages = new List<string>();
        ReadOnlyCollection<IWebElement> languages = driver.FindElements(By.ClassName("cental.featured.lang"));
        foreach (IWebElement language in languages)
        {
            string lang = language.Text;
            CentralLanguages.Add(lang)
        }

        //List<String> textofanchors = new List<String>();
        // ReadOnlyCollection<IWebElement> anchorLists = driver.FindElements(By.TagName("a"));
        // foreach (IWebElement anchor in anchorLists)
        //  {
        //   if (anchor.Text.Length > 0)
        // {
        //   if (anchor.Text.Contains("English"))
        //  {


        //  textofanchors.Add(anchor.Text);
        //  anchor.Click();
        // }
        // }

        //   }
        //string stop = "";

        // driver.FindElement(By.Name("searrh")).SendKeys("Selenium"); // aller a la barre de recherche et entrer selenium
        // driver.FindElement(By.XPath("//*[@Id='search-form']/fieldset/button")).Click();  ici on utilise ca pour utiliser le bouton click
       driver.Quit();


    }


    [Fact]
    public void Test1()
    {
        string ActualResult;
        string ExpecteResult = "bing";
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.google.co.in/");
        driver.Manage().Window.Maximize();
        ActualResult = driver.Title; //L actuel result est le titre retrouver sur google
        if (ActualResult.Contains(ExpecteResult))
        {
            Console.WriteLine("Test Case Passed");
            Assert.True(true, "Test Case Passed");

        }

        else
        {
            Console.WriteLine("Test Case Failed");
        }
        driver.Close();

        driver.Quit();


    }

   

        [Fact]
    public void firefoxMethod()
    {
        IWebDriver driver = new FirefoxDriver();
        driver.Navigate().GoToUrl("https://www.google.co.in/");
        driver.Manage().Window.Maximize();
        driver.Close();
        driver.Quit();


    }
    [Fact]
    public void IEMethod()
    {
        IWebDriver driver = new InternetExplorerDriver();
        driver.Navigate().GoToUrl("https://www.google.co.in/");
        driver.Manage().Window.Maximize();
        driver.Close();

        driver.Quit();


    }

    
}



