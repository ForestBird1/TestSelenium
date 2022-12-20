using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

using System.Threading;

//Selenium 
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Support.UI;

namespace TestSelenium
{
    public partial class TestSelenium : Form
    {
        //Selenum_Chrome
        private ChromeDriverService _driverService = ChromeDriverService.CreateDefaultService();
        private ChromeOptions _options = new ChromeOptions();
        private ChromeDriver _driver = null;
        private IWebElement _web_elem = null;

        public TestSelenium()
        {
            InitializeComponent();
        }

        private void btn_selenium_start_Click(object sender, EventArgs e)
        {
            _options = new ChromeOptions();

            //명령프롬프트 숨기기
            //_driverService.HideCommandPromptWindow = true;

            //안전하지않은 페이지경고 무시하기
            //_options.AddArgument("ignore-certificate-errors");

            //gpu가속 비활성화
            //_options.AddArgument("--disable-gpu");

            //브라우저 숨기기
            //_options.AddArgument("--headless");

            //브라우저 사이즈조절. headless모드에서 사용하면 유용합니다
            //_options.AddArgument("--window-size=1920,1080");


            //브라우저 생성
            _driver = new ChromeDriver(_driverService, _options);
            _driver.Navigate().GoToUrl("https://www.naver.com/");
        }

        private void btn_click_loginpage_Click(object sender, EventArgs e)
        {
            try
            {
                //요소를 찾습니다
                _web_elem = _driver.FindElement(By.XPath("//*[@id='account']/a"));
                //클릭합니다
                _web_elem.Click();
            }
            catch(NoSuchElementException ex)
            {
                //요소가 없습니다
                Console.Write(ex);
            }
        }

        private void btn_write_account_and_login_Click(object sender, EventArgs e)
        {
            _web_elem = _driver.FindElement(By.XPath("//*[@id='id']"));
            _web_elem.SendKeys("id");

            _web_elem = _driver.FindElement(By.XPath("//*[@id='pw']"));
            _web_elem.SendKeys("pw");

            _web_elem = _driver.FindElement(By.XPath("//*[@id='log.login']"));
            _web_elem.Click();
        }

        private void btn_id_textbox_Click(object sender, EventArgs e)
        {
            //쓰기
            _web_elem = _driver.FindElement(By.XPath("//*[@id='id']"));
            _web_elem.SendKeys("id");

            //읽기
            _web_elem = _driver.FindElement(By.XPath("//*[@id='id']"));
            Console.WriteLine(_web_elem.Text);

            //지우기
            _web_elem = _driver.FindElement(By.XPath("//*[@id='id']"));
            //둘중에 하나만 사용해도 됩니다
            _web_elem.SendKeys("");
            _web_elem.Clear();
        }

        private void btn_screenshot_Click(object sender, EventArgs e)
        {
            //*전체스크린샷 찍기
            ITakesScreenshot _takesScreenshot = (ITakesScreenshot)_driver;
            Screenshot screenshot = _takesScreenshot.GetScreenshot();
            screenshot.SaveAsFile(Environment.CurrentDirectory + "//screenshot.png", ScreenshotImageFormat.Png);

            //네이버 로고요소 가져오기
            _web_elem = _driver.FindElement(By.XPath("//*[@id='header']/div[1]/div/div[1]/h1/a"));

            //스크린샷을 비트맵으로 변경
            Bitmap bitmap_screenshot = new Bitmap(new System.IO.MemoryStream(screenshot.AsByteArray));

            //*전체스크린샷에서 로고크기에 맞춰자릅니다
            Rectangle rect_crop_size = new Rectangle(_web_elem.Location.X, _web_elem.Location.Y, _web_elem.Size.Width, _web_elem.Size.Height);
            bitmap_screenshot = bitmap_screenshot.Clone(rect_crop_size, bitmap_screenshot.PixelFormat);
            bitmap_screenshot.Save(String.Format(Environment.CurrentDirectory + "//screenshot_2.png", ImageFormat.Png));

            //*비트맵은 사용후 꼭 Dispose해야 메모리누수가 발생하지 않습니다
            //*Dispose를 사용하지 않으려면 using문으로 사용해도 됩니다
            bitmap_screenshot.Dispose();

        }

        private void btn_bottom_screenshot_Click(object sender, EventArgs e)
        {
            //특정요소를 찾고 스크롤하기
            _web_elem = _driver.FindElement(By.XPath("//*[@id='footer']/div/div[3]/div[2]/div[1]/a/img"));
            _driver.ExecuteScript("arguments[0].scrollIntoView(true);", _web_elem);

            //웹 페이지의 Y기준점 찾기
            var y_offset_object =_driver.ExecuteScript("return window.pageYOffset;");
            int y_offset = (int)float.Parse(y_offset_object.ToString());

            //*전체스크린샷 찍기. 파일로 저장하지 않습니다
            ITakesScreenshot _takesScreenshot = (ITakesScreenshot)_driver;
            Screenshot screenshot = _takesScreenshot.GetScreenshot();

            //스크린샷을 비트맵으로 변경
            Bitmap bitmap_screenshot = new Bitmap(new System.IO.MemoryStream(screenshot.AsByteArray));

            //*전체스크린샷에서 요소크기에 맞춰자릅니다
            Rectangle rect_crop_size = new Rectangle(
                _web_elem.Location.X,
                _web_elem.Location.Y - y_offset, 
                _web_elem.Size.Width, 
                _web_elem.Size.Height);
            bitmap_screenshot = bitmap_screenshot.Clone(rect_crop_size, bitmap_screenshot.PixelFormat);
            bitmap_screenshot.Save(String.Format(Environment.CurrentDirectory + "//screenshot_scroll_crop.png", ImageFormat.Png));

            //*비트맵은 사용후 꼭 Dispose해야 메모리누수가 발생하지 않습니다
            //*Dispose를 사용하지 않으려면 using문으로 사용해도 됩니다
            bitmap_screenshot.Dispose();
        }

        private void btn_tab_Click(object sender, EventArgs e)
        {
            //새탭 생성
            _driver.ExecuteScript("window.open();");

            //*탭 포커싱
            //마지막 탭(우측) 포커싱하기
            _driver.SwitchTo().Window(_driver.WindowHandles.Last());

            //첫번째 탭(좌측) 포커싱하기
            _driver.SwitchTo().Window(_driver.WindowHandles.First());

            //*특정 탭정보 저장, 특정 탭 포커싱

            //현재 탭정보 저장
            //string window = _driver.CurrentWindowHandle;

            //모든 탭정보중 0번째 인덱스탭 저장
            string window = _driver.WindowHandles.ToList()[0];
            _driver.SwitchTo().Window(window);

            //현재 탭 닫기
            //탭을 닫은경우 포커싱을 잃어버리기 때문에 다른 탭으로 포커싱을 잡아줘야 합니다!!!
            _driver.Close();
        }
    }
}
