using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Demo
{
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => {
                ChromeDriver chromeDriver = new ChromeDriver();
                {
                    chromeDriver.Url = "https://www.instagram.com/"; /*đến địa chỉ cần đến*/
                    chromeDriver.Navigate();
                    chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); /* đợi load trang 10s*/
                    chromeDriver.FindElement(By.Name("username")).SendKeys("henrymain23@gmail.com"); /*tìm element user mà nhập*/
                    chromeDriver.FindElement(By.Name("password")).SendKeys("main99");/*tìm element pass mà nhập*/
                    chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); /* đợi load trang 10s*/
                    var button = chromeDriver.FindElementByXPath("/html/body/div[1]/section/main/article/div[2]/div[1]/div/form/div[4]/button/div");/* đăng nhập*/
                    button.Click();
                    chromeDriver.FindElementByXPath("/html/body/div[1]/section/main/div/div/div/section/div/button").Click();/* lưu đăng nhập*/
                    chromeDriver.FindElementByXPath("/html/body/div[4]/div/div/div/div[3]/button[2]").Click(); /* tắt thông báo*/
                }
            });
            t.Start();

            Thread t2 = new Thread(() => {
                ChromeDriver chromeDriver = new ChromeDriver();
                {
                    chromeDriver.Url = "https://www.instagram.com/"; /*đến địa chỉ cần đến*/
                    chromeDriver.Navigate();
                    chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); /* đợi load trang 10s*/
                    chromeDriver.FindElement(By.Name("username")).SendKeys("mainlqc0203"); /*tìm element user mà nhập*/
                    chromeDriver.FindElement(By.Name("password")).SendKeys("chinh123");/*tìm element pass mà nhập*/
                    chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); /* đợi load trang 10s*/
                    var button = chromeDriver.FindElementByXPath("/html/body/div[1]/section/main/article/div[2]/div[1]/div/form/div[4]/button/div");/* đăng nhập*/
                    button.Click();
                    chromeDriver.FindElementByXPath("/html/body/div[1]/section/main/div/div/div/section/div/button").Click();/* lưu đăng nhập*/
                    chromeDriver.FindElementByXPath("/html/body/div[4]/div/div/div/div[3]/button[2]").Click(); /* tắt thông báo*/
                }
            });
            t2.Start();
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => {
                ChromeDriver chromeDriver = new ChromeDriver();
                {
                    chromeDriver.Url = "https://www.instagram.com/"; /*đến địa chỉ cần đến*/
                    chromeDriver.Navigate();
                    chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); /* đợi load trang 10s*/
                    chromeDriver.FindElement(By.Name("username")).SendKeys("henrymain23@gmail.com"); /*tìm element user mà nhập*/
                    chromeDriver.FindElement(By.Name("password")).SendKeys("main99");/*tìm element pass mà nhập*/
                    chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); /* đợi load trang 10s*/
                    var button = chromeDriver.FindElementByXPath("/html/body/div[1]/section/main/article/div[2]/div[1]/div/form/div[4]/button/div");/* đăng nhập*/
                    button.Click();
                    chromeDriver.FindElementByXPath("/html/body/div[1]/section/main/div/div/div/section/div/button").Click();/* lưu đăng nhập*/
                    chromeDriver.FindElementByXPath("/html/body/div[4]/div/div/div/div[3]/button[2]").Click(); /* tắt thông báo*/
                }
                var seach = chromeDriver.FindElementByXPath("/html/body/div[1]/section/nav/div[2]/div/div/div[2]/input");/* tìm đến ô tìm kiếm*/
                seach.SendKeys("main.lqc");
                seach.Click();
                chromeDriver.FindElementByXPath("/html/body/div[1]/section/nav/div[2]/div/div/div[2]/div[3]/div[2]/div/a[1]/div").Click();
                chromeDriver.Navigate().Forward(); /* chuyển trang sau */
                chromeDriver.FindElementByXPath("/html/body/div[1]/section/main/div/header/section/div[1]/div[1]/span/span[1]/button").Click();
            });
            t.Start();

            Thread t2 = new Thread(() => {
                ChromeDriver chromeDriver = new ChromeDriver();
                {
                    chromeDriver.Url = "https://www.instagram.com/"; /*đến địa chỉ cần đến*/
                    chromeDriver.Navigate();
                    chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); /* đợi load trang 10s*/
                    chromeDriver.FindElement(By.Name("username")).SendKeys("mainlqc0203"); /*tìm element user mà nhập*/
                    chromeDriver.FindElement(By.Name("password")).SendKeys("chinh123");/*tìm element pass mà nhập*/
                    chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); /* đợi load trang 10s*/
                    var button = chromeDriver.FindElementByXPath("/html/body/div[1]/section/main/article/div[2]/div[1]/div/form/div[4]/button/div");/* đăng nhập*/
                    button.Click();
                    chromeDriver.FindElementByXPath("/html/body/div[1]/section/main/div/div/div/section/div/button").Click();/* lưu đăng nhập*/
                    chromeDriver.FindElementByXPath("/html/body/div[4]/div/div/div/div[3]/button[2]").Click(); /* tắt thông báo*/
                }
                var seach = chromeDriver.FindElementByXPath("/html/body/div[1]/section/nav/div[2]/div/div/div[2]/input");/* tìm đến ô tìm kiếm*/
                seach.SendKeys("main.lqc");
                seach.Click();
                chromeDriver.FindElementByXPath("/html/body/div[1]/section/nav/div[2]/div/div/div[2]/div[3]/div[2]/div/a[1]/div").Click();
                chromeDriver.Navigate().Forward(); /* chuyển trang sau */
                chromeDriver.FindElementByXPath("/html/body/div[1]/section/main/div/header/section/div[1]/div[1]/span/span[1]/button").Click();
            });
            t2.Start();
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => {
                ChromeDriver chromeDriver = new ChromeDriver();
                {
                    chromeDriver.Url = "https://www.instagram.com/"; /*đến địa chỉ cần đến*/
                    chromeDriver.Navigate();
                    chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); /* đợi load trang 10s*/
                    chromeDriver.FindElement(By.Name("username")).SendKeys("henrymain23@gmail.com"); /*tìm element user mà nhập*/
                    chromeDriver.FindElement(By.Name("password")).SendKeys("main99");/*tìm element pass mà nhập*/
                    chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); /* đợi load trang 10s*/
                    var button = chromeDriver.FindElementByXPath("/html/body/div[1]/section/main/article/div[2]/div[1]/div/form/div[4]/button/div");/* đăng nhập*/
                    button.Click();
                    chromeDriver.FindElementByXPath("/html/body/div[1]/section/main/div/div/div/section/div/button").Click();/* lưu đăng nhập*/
                    chromeDriver.FindElementByXPath("/html/body/div[4]/div/div/div/div[3]/button[2]").Click(); /* tắt thông báo*/
                }
                chromeDriver.Url = "https://www.instagram.com/direct/inbox/";
                chromeDriver.FindElementByXPath("/html/body/div[1]/section/div/div[2]/div/div/div[2]/div/button").Click();
                chromeDriver.FindElementByXPath("/html/body/div[4]/div/div/div[2]/div[2]/div/div").Click();
                chromeDriver.FindElementByXPath("/html/body/div[4]/div/div/div[2]/div[1]/div/div[2]/input").SendKeys("main.lqc");
                chromeDriver.FindElementByXPath("/html/body/div[4]/div/div/div[2]/div[2]/div/div/div[2]/div[1]/div/div").Click();
                chromeDriver.FindElementByXPath("/html/body/div[4]/div/div/div[1]/div/div[2]/div/button").Click();
                var sent = chromeDriver.FindElementByXPath("/html/body/div[1]/section/div/div[2]/div/div/div[2]/div[2]/div/div[2]/div/div/div[2]/textarea"); /* nhắn tin*/
                sent.Click();
                sent.SendKeys("Hello my friend, I am Main, nice to chat with you");
                chromeDriver.FindElementByXPath("/html/body/div[1]/section/div/div[2]/div/div/div[2]/div[2]/div/div[2]/div/div/div[3]/button").Click();
            });
            t.Start();

            Thread t2 = new Thread(() => {
                ChromeDriver chromeDriver = new ChromeDriver();
                {
                    chromeDriver.Url = "https://www.instagram.com/"; /*đến địa chỉ cần đến*/
                    chromeDriver.Navigate();
                    chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); /* đợi load trang 10s*/
                    chromeDriver.FindElement(By.Name("username")).SendKeys("mainlqc0203"); /*tìm element user mà nhập*/
                    chromeDriver.FindElement(By.Name("password")).SendKeys("chinh123");/*tìm element pass mà nhập*/
                    chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); /* đợi load trang 10s*/
                    var button = chromeDriver.FindElementByXPath("/html/body/div[1]/section/main/article/div[2]/div[1]/div/form/div[4]/button/div");/* đăng nhập*/
                    button.Click();
                    chromeDriver.FindElementByXPath("/html/body/div[1]/section/main/div/div/div/section/div/button").Click();/* lưu đăng nhập*/
                    chromeDriver.FindElementByXPath("/html/body/div[4]/div/div/div/div[3]/button[2]").Click(); /* tắt thông báo*/
                }
                chromeDriver.Url = "https://www.instagram.com/direct/inbox/";
                chromeDriver.FindElementByXPath("/html/body/div[1]/section/div/div[2]/div/div/div[2]/div/button").Click();
                chromeDriver.FindElementByXPath("/html/body/div[4]/div/div/div[2]/div[2]/div/div").Click();
                chromeDriver.FindElementByXPath("/html/body/div[4]/div/div/div[2]/div[1]/div/div[2]/input").SendKeys("main.lqc");
                chromeDriver.FindElementByXPath("/html/body/div[4]/div/div/div[2]/div[2]/div/div/div[2]/div[1]/div/div").Click();
                chromeDriver.FindElementByXPath("/html/body/div[4]/div/div/div[1]/div/div[2]/div/button").Click();
                var sent = chromeDriver.FindElementByXPath("/html/body/div[1]/section/div/div[2]/div/div/div[2]/div[2]/div/div[2]/div/div/div[2]/textarea"); /* nhắn tin*/
                sent.Click();
                sent.SendKeys("Hello my friend, I am Main, nice to chat with you");
                chromeDriver.FindElementByXPath("/html/body/div[1]/section/div/div[2]/div/div/div[2]/div[2]/div/div[2]/div/div/div[3]/button").Click();
            });
            t2.Start();
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => {
                ChromeDriver chromeDriver = new ChromeDriver();
                {
                    chromeDriver.Url = "https://www.instagram.com/"; /*đến địa chỉ cần đến*/
                    chromeDriver.Navigate();
                    chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); /* đợi load trang 10s*/
                    chromeDriver.FindElement(By.Name("username")).SendKeys("henrymain23@gmail.com"); /*tìm element user mà nhập*/
                    chromeDriver.FindElement(By.Name("password")).SendKeys("main99");/*tìm element pass mà nhập*/
                    chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); /* đợi load trang 10s*/
                    var button = chromeDriver.FindElementByXPath("/html/body/div[1]/section/main/article/div[2]/div[1]/div/form/div[4]/button/div");/* đăng nhập*/
                    button.Click();
                    chromeDriver.FindElementByXPath("/html/body/div[1]/section/main/div/div/div/section/div/button").Click();/* lưu đăng nhập*/
                    chromeDriver.FindElementByXPath("/html/body/div[4]/div/div/div/div[3]/button[2]").Click(); /* tắt thông báo*/
                }
                chromeDriver.Navigate().Forward();
                chromeDriver.Url = "https://www.instagram.com/main.lqc/";
                chromeDriver.FindElementByXPath("/html/body/div[1]/section/main/div/div[2]/article/div/div/div[1]/div[1]/a/div/div[2]").Click();
                chromeDriver.FindElementByCssSelector("body > div._2dDPU.CkGkG > div.zZYga > div > article > div.eo2As > section.ltpMr.Slqrh > span.fr66n > button > svg").Click();
                chromeDriver.FindElementByXPath("/html/body/div[4]/div[2]/div/article/div[2]/section[3]/div/form/textarea").Click();
                chromeDriver.FindElementByXPath("/html/body/div[4]/div[2]/div/article/div[2]/section[3]/div/form/textarea").SendKeys("You very Handsome");
                chromeDriver.FindElementByXPath("/html/body/div[4]/div[2]/div/article/div[2]/section[3]/div/form/button").Click();
            });
            t.Start();

            Thread t2 = new Thread(() => {
                ChromeDriver chromeDriver = new ChromeDriver();
                {
                    chromeDriver.Url = "https://www.instagram.com/"; /*đến địa chỉ cần đến*/
                    chromeDriver.Navigate();
                    chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); /* đợi load trang 10s*/
                    chromeDriver.FindElement(By.Name("username")).SendKeys("mainlqc0203"); /*tìm element user mà nhập*/
                    chromeDriver.FindElement(By.Name("password")).SendKeys("chinh123");/*tìm element pass mà nhập*/
                    chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); /* đợi load trang 10s*/
                    var button = chromeDriver.FindElementByXPath("/html/body/div[1]/section/main/article/div[2]/div[1]/div/form/div[4]/button/div");/* đăng nhập*/
                    button.Click();
                    chromeDriver.FindElementByXPath("/html/body/div[1]/section/main/div/div/div/section/div/button").Click();/* lưu đăng nhập*/
                    chromeDriver.FindElementByXPath("/html/body/div[4]/div/div/div/div[3]/button[2]").Click(); /* tắt thông báo*/
                }
                chromeDriver.Navigate().Forward();
                chromeDriver.Url = "https://www.instagram.com/main.lqc/";
                chromeDriver.FindElementByXPath("/html/body/div[1]/section/main/div/div[2]/article/div/div/div[1]/div[1]/a/div/div[2]").Click();
                chromeDriver.FindElementByCssSelector("body > div._2dDPU.CkGkG > div.zZYga > div > article > div.eo2As > section.ltpMr.Slqrh > span.fr66n > button > svg").Click();
                chromeDriver.FindElementByXPath("/html/body/div[4]/div[2]/div/article/div[2]/section[3]/div/form/textarea").Click();
                chromeDriver.FindElementByXPath("/html/body/div[4]/div[2]/div/article/div[2]/section[3]/div/form/textarea").SendKeys("You very Handsome");
                chromeDriver.FindElementByXPath("/html/body/div[4]/div[2]/div/article/div[2]/section[3]/div/form/button").Click();

            });
            t2.Start();
            
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => {
                ChromeDriver chromeDriver = new ChromeDriver();
                {
                    chromeDriver.Url = "https://www.instagram.com/";
                    chromeDriver.Navigate();
                    chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); /* đợi load trang 10s*/
                    chromeDriver.FindElement(By.Name("username")).SendKeys("henrymain23@gmail.com"); /*tìm element user mà nhập*/
                    chromeDriver.FindElement(By.Name("password")).SendKeys("main99");/*tìm element pass mà nhập*/
                    chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); /* đợi load trang 10s*/
                    var button = chromeDriver.FindElementByXPath("/html/body/div[1]/section/main/article/div[2]/div[1]/div/form/div[4]/button/div");/* đăng nhập*/
                    button.Click();
                    chromeDriver.FindElementByXPath("/html/body/div[1]/section/main/div/div/div/section/div/button").Click();/* lưu đăng nhập*/
                    chromeDriver.FindElementByXPath("/html/body/div[4]/div/div/div/div[3]/button[2]").Click(); /* tắt thông báo*/
                }
                chromeDriver.FindElementByCssSelector("#react-root > section > main > section > div > div:nth-child(2) > div > article:nth-child(1) > div.eo2As > section.ltpMr.Slqrh > span.fr66n > button > svg").Click();
                chromeDriver.FindElementByCssSelector("#react-root > section > main > section > div > div:nth-child(2) > div > article:nth-child(2) > div.eo2As > section.ltpMr.Slqrh > span.fr66n > button > svg").Click();
                chromeDriver.FindElementByCssSelector("#react-root > section > main > section > div > div:nth-child(2) > div > article:nth-child(3) > div.eo2As > section.ltpMr.Slqrh > span.fr66n > button > svg").Click();
                chromeDriver.FindElementByCssSelector("#react-root > section > main > section > div > div:nth-child(2) > div > article:nth-child(4) > div.eo2As > section.ltpMr.Slqrh > span.fr66n > button > svg").Click();
                chromeDriver.FindElementByCssSelector("#react-root > section > main > section > div > div:nth-child(2) > div > article:nth-child(5) > div.eo2As > section.ltpMr.Slqrh > span.fr66n > button > svg").Click();
                chromeDriver.FindElementByCssSelector("#react-root > section > main > section > div > div:nth-child(2) > div > article:nth-child(6) > div.eo2As > section.ltpMr.Slqrh > span.fr66n > button > svg").Click();
                chromeDriver.FindElementByCssSelector("#react-root > section > main > section > div > div:nth-child(2) > div > article:nth-child(7) > div.eo2As > section.ltpMr.Slqrh > span.fr66n > button > svg").Click();
            }); 
            t.Start();

            Thread t2 = new Thread(() => {
                ChromeDriver chromeDriver = new ChromeDriver();
                {
                    chromeDriver.Url = "https://www.instagram.com/";
                    chromeDriver.Navigate();
                    chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); /* đợi load trang 10s*/
                    chromeDriver.FindElement(By.Name("username")).SendKeys("mainlqc0203"); /*tìm element user mà nhập*/
                    chromeDriver.FindElement(By.Name("password")).SendKeys("chinh123"); /*tìm element pass mà nhập*/
                    chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); /* đợi load trang 10s*/
                    var button = chromeDriver.FindElementByXPath("/html/body/div[1]/section/main/article/div[2]/div[1]/div/form/div[4]/button/div");/* đăng nhập*/
                    button.Click();
                    chromeDriver.FindElementByXPath("/html/body/div[1]/section/main/div/div/div/section/div/button").Click();/* lưu đăng nhập*/
                    chromeDriver.FindElementByXPath("/html/body/div[4]/div/div/div/div[3]/button[2]").Click(); /* tắt thông báo*/
                }
                chromeDriver.FindElementByCssSelector("#react-root > section > main > section > div > div:nth-child(3) > div > article:nth-child(1) > div.eo2As > section.ltpMr.Slqrh > span.fr66n > button > svg").Click();
                chromeDriver.FindElementByCssSelector("#react-root > section > main > section > div > div:nth-child(3) > div > article:nth-child(3) > div.eo2As > section.ltpMr.Slqrh > span.fr66n > button > svg").Click();
                chromeDriver.FindElementByCssSelector("#react-root > section > main > section > div > div:nth-child(3) > div > article:nth-child(4) > div.eo2As > section.ltpMr.Slqrh > span.fr66n > button > svg").Click();
                chromeDriver.FindElementByCssSelector("#react-root > section > main > section > div > div:nth-child(3) > div > article:nth-child(4) > div.eo2As > section.ltpMr.Slqrh > span.fr66n > button > svg").Click();
                chromeDriver.FindElementByCssSelector("#react-root > section > main > section > div > div:nth-child(3) > div > article:nth-child(5) > div.eo2As > section.ltpMr.Slqrh > span.fr66n > button > svg").Click();
                chromeDriver.FindElementByCssSelector("#react-root > section > main > section > div > div:nth-child(3) > div > article:nth-child(7) > div.eo2As > section.ltpMr.Slqrh > span.fr66n > button > svg").Click();
            });
            t2.Start();
            
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => {
                ChromeDriver chromeDriver = new ChromeDriver();
                {
                    chromeDriver.Url = "https://www.instagram.com/";
                    chromeDriver.Navigate();
                    chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); /* đợi load trang 10s*/
                    chromeDriver.FindElement(By.Name("username")).SendKeys("henrymain23@gmail.com"); /*tìm element user mà nhập*/
                    chromeDriver.FindElement(By.Name("password")).SendKeys("main99");/*tìm element pass mà nhập*/
                    chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); /* đợi load trang 10s*/
                    var button = chromeDriver.FindElementByXPath("/html/body/div[1]/section/main/article/div[2]/div[1]/div/form/div[4]/button/div");/* đăng nhập*/
                    button.Click();
                    chromeDriver.FindElementByXPath("/html/body/div[1]/section/main/div/div/div/section/div/button").Click();/* lưu đăng nhập*/
                    chromeDriver.FindElementByXPath("/html/body/div[4]/div/div/div/div[3]/button[2]").Click(); /* tắt thông báo*/
                }
                chromeDriver.Url = "https://www.instagram.com/lqc2399/";
                chromeDriver.FindElementByXPath("/html/body/div[1]/section/main/div/header/section/ul/li[3]/a").Click();/* Chuyển đến trang following và unfollow 5 người*/
                chromeDriver.FindElementByXPath("/html/body/div[4]/div/div/div[2]/ul/div/li[2]/div/div[3]/button").Click();
                chromeDriver.FindElementByXPath("/html/body/div[5]/div/div/div/div[3]/button[1] ").Click();
                chromeDriver.FindElementByXPath("/html/body/div[4]/div/div/div[2]/ul/div/li[3]/div/div[3]/button").Click();
                chromeDriver.FindElementByXPath("/html/body/div[5]/div/div/div/div[3]/button[1] ").Click();
                chromeDriver.FindElementByXPath("/html/body/div[4]/div/div/div[2]/ul/div/li[4]/div/div[3]/button").Click();
                chromeDriver.FindElementByXPath("/html/body/div[5]/div/div/div/div[3]/button[1] ").Click();
                chromeDriver.FindElementByXPath("/html/body/div[4]/div/div/div[2]/ul/div/li[5]/div/div[3]/button").Click();
                chromeDriver.FindElementByXPath("/html/body/div[5]/div/div/div/div[3]/button[1] ").Click();
                chromeDriver.FindElementByXPath("/html/body/div[4]/div/div/div[2]/ul/div/li[6]/div/div[3]/button").Click();
                chromeDriver.FindElementByXPath("/html/body/div[5]/div/div/div/div[3]/button[1] ").Click();
                chromeDriver.FindElementByXPath("/html/body/div[4]/div/div/div[2]/ul/div/li[7]/div/div[3]/button").Click();
                chromeDriver.FindElementByXPath("/html/body/div[5]/div/div/div/div[3]/button[1] ").Click();
            });
            t.Start();

            Thread t2 = new Thread(() => {
                ChromeDriver chromeDriver = new ChromeDriver();
                {
                    chromeDriver.Url = "https://www.instagram.com/";
                    chromeDriver.Navigate();
                    chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); /* đợi load trang 10s*/
                    chromeDriver.FindElement(By.Name("username")).SendKeys("mainlqc0203"); /*tìm element user mà nhập*/
                    chromeDriver.FindElement(By.Name("password")).SendKeys("chinh123");/*tìm element pass mà nhập*/
                    chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); /* đợi load trang 10s*/
                    var button = chromeDriver.FindElementByXPath("/html/body/div[1]/section/main/article/div[2]/div[1]/div/form/div[4]/button/div");/* đăng nhập*/
                    button.Click();
                    chromeDriver.FindElementByXPath("/html/body/div[1]/section/main/div/div/div/section/div/button").Click();/* lưu đăng nhập*/
                    chromeDriver.FindElementByXPath("/html/body/div[4]/div/div/div/div[3]/button[2]").Click(); /* tắt thông báo*/
                }
                chromeDriver.Url = "https://www.instagram.com/lqc2399/";
                chromeDriver.FindElementByXPath("/html/body/div[1]/section/main/div/header/section/ul/li[3]/a").Click();/* Chuyển đến trang following và unfollow 5 người*/
                chromeDriver.FindElementByXPath("/html/body/div[4]/div/div/div[2]/ul/div/li[2]/div/div[3]/button").Click();
                chromeDriver.FindElementByXPath("/html/body/div[5]/div/div/div/div[3]/button[1] ").Click();
                chromeDriver.FindElementByXPath("/html/body/div[4]/div/div/div[2]/ul/div/li[3]/div/div[3]/button").Click();
                chromeDriver.FindElementByXPath("/html/body/div[5]/div/div/div/div[3]/button[1] ").Click();
                chromeDriver.FindElementByXPath("/html/body/div[4]/div/div/div[2]/ul/div/li[4]/div/div[3]/button").Click();
                chromeDriver.FindElementByXPath("/html/body/div[5]/div/div/div/div[3]/button[1] ").Click();
                chromeDriver.FindElementByXPath("/html/body/div[4]/div/div/div[2]/ul/div/li[5]/div/div[3]/button").Click();
                chromeDriver.FindElementByXPath("/html/body/div[5]/div/div/div/div[3]/button[1] ").Click();
                chromeDriver.FindElementByXPath("/html/body/div[4]/div/div/div[2]/ul/div/li[6]/div/div[3]/button").Click();
                chromeDriver.FindElementByXPath("/html/body/div[5]/div/div/div/div[3]/button[1] ").Click();
                chromeDriver.FindElementByXPath("/html/body/div[4]/div/div/div[2]/ul/div/li[7]/div/div[3]/button").Click();
                chromeDriver.FindElementByXPath("/html/body/div[5]/div/div/div/div[3]/button[1] ").Click();
            });
            t2.Start();
            

        }
    }
}
