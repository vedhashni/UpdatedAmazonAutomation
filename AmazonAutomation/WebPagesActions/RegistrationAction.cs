using OpenQA.Selenium;
using AmazonAutomation.WebPagesData;
using System;

namespace AmazonAutomation.WebPagesActions
{
    public class RegistrationAction
    {
        public static ExcelOperation excel;
        public static Signup register;

        //Here we are reading the data from excel
        public static void ReadDataFromExcel(IWebDriver driver)
        {
            excel = new ExcelOperation();
            excel.PopulateFromExcel(@"C:\Users\vedhashni.v\source\repos\AmazonAutomation\AmazonAutomation\WebPagesData\SignupData.xlsx");
        }

        //Used for implementing signup operations
        public static void SignupIntoAmazon(IWebDriver driver)
        {
            excel = new ExcelOperation();
            register = new Signup(driver);
            TakeScreenShot(driver);
            register.signup.Click();
            TakeScreenShot(driver);
            System.Threading.Thread.Sleep(1000);
            //By invoking the readdate method values in table is retrived
            register.name.SendKeys(excel.ReadData(1, "Name"));
            TakeScreenShot(driver);
            //is used to wait in a particular page before taking another action
            System.Threading.Thread.Sleep(3000);
            //By invoking the readdate method values in table is retrived
            register.mobilenumber.SendKeys(excel.ReadData(1, "MobileNumber"));
            TakeScreenShot(driver);
            //is used to wait in a particular page before taking another action
            System.Threading.Thread.Sleep(3000);
            //By invoking the readdate method values in table is retrived
            register.email.SendKeys(excel.ReadData(1, "Email"));
            TakeScreenShot(driver);
            //is used to wait in a particular page before taking another action
            System.Threading.Thread.Sleep(3000);
            //By invoking the readdate method values in table is retrived
            register.password.SendKeys(excel.ReadData(1, "Password"));
            TakeScreenShot(driver);
            //is used to wait in a particular page before taking another action
            System.Threading.Thread.Sleep(3000);
            register.continuebtn.Click();
            TakeScreenShot(driver);
            TakeScreenShot(driver);
            System.Threading.Thread.Sleep(70000);
            TakeScreenShot(driver);
            //register.newaccountbtn.Click();
            //System.Threading.Thread.Sleep(10000);
        }

        public static void TakeScreenShot(IWebDriver driver)
        {
            ITakesScreenshot screenshot = driver as ITakesScreenshot;
            Screenshot screenshot1 = screenshot.GetScreenshot();
            screenshot1.SaveAsFile(@"C:\Users\vedhashni.v\source\repos\AmazonAutomation\AmazonAutomation\TestScreenShots\AmazonTest" + DateTime.Now.ToString("HHmmss") + ".png");
        }
    }
}
