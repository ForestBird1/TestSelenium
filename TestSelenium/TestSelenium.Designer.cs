
namespace TestSelenium
{
    partial class TestSelenium
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_selenium_start = new System.Windows.Forms.Button();
            this.btn_click_loginpage = new System.Windows.Forms.Button();
            this.btn_id_textbox = new System.Windows.Forms.Button();
            this.btn_write_account_and_login = new System.Windows.Forms.Button();
            this.btn_screenshot = new System.Windows.Forms.Button();
            this.btn_bottom_screenshot = new System.Windows.Forms.Button();
            this.btn_tab = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_selenium_start
            // 
            this.btn_selenium_start.Location = new System.Drawing.Point(13, 13);
            this.btn_selenium_start.Name = "btn_selenium_start";
            this.btn_selenium_start.Size = new System.Drawing.Size(194, 82);
            this.btn_selenium_start.TabIndex = 0;
            this.btn_selenium_start.Text = "1. 셀레니움 시작";
            this.btn_selenium_start.UseVisualStyleBackColor = true;
            this.btn_selenium_start.Click += new System.EventHandler(this.btn_selenium_start_Click);
            // 
            // btn_click_loginpage
            // 
            this.btn_click_loginpage.Location = new System.Drawing.Point(13, 102);
            this.btn_click_loginpage.Name = "btn_click_loginpage";
            this.btn_click_loginpage.Size = new System.Drawing.Size(194, 66);
            this.btn_click_loginpage.TabIndex = 1;
            this.btn_click_loginpage.Text = "2. 로그인페이지 버튼 클릭";
            this.btn_click_loginpage.UseVisualStyleBackColor = true;
            this.btn_click_loginpage.Click += new System.EventHandler(this.btn_click_loginpage_Click);
            // 
            // btn_id_textbox
            // 
            this.btn_id_textbox.Location = new System.Drawing.Point(212, 174);
            this.btn_id_textbox.Name = "btn_id_textbox";
            this.btn_id_textbox.Size = new System.Drawing.Size(194, 66);
            this.btn_id_textbox.TabIndex = 2;
            this.btn_id_textbox.Text = "아이디텍스트 박스 \r\n쓰기, 읽기, 지우기";
            this.btn_id_textbox.UseVisualStyleBackColor = true;
            this.btn_id_textbox.Click += new System.EventHandler(this.btn_id_textbox_Click);
            // 
            // btn_write_account_and_login
            // 
            this.btn_write_account_and_login.Location = new System.Drawing.Point(12, 174);
            this.btn_write_account_and_login.Name = "btn_write_account_and_login";
            this.btn_write_account_and_login.Size = new System.Drawing.Size(194, 66);
            this.btn_write_account_and_login.TabIndex = 3;
            this.btn_write_account_and_login.Text = "3. 계정정보 입력후 로그인";
            this.btn_write_account_and_login.UseVisualStyleBackColor = true;
            this.btn_write_account_and_login.Click += new System.EventHandler(this.btn_write_account_and_login_Click);
            // 
            // btn_screenshot
            // 
            this.btn_screenshot.Location = new System.Drawing.Point(13, 246);
            this.btn_screenshot.Name = "btn_screenshot";
            this.btn_screenshot.Size = new System.Drawing.Size(194, 66);
            this.btn_screenshot.TabIndex = 4;
            this.btn_screenshot.Text = "4. 스크린샷";
            this.btn_screenshot.UseVisualStyleBackColor = true;
            this.btn_screenshot.Click += new System.EventHandler(this.btn_screenshot_Click);
            // 
            // btn_bottom_screenshot
            // 
            this.btn_bottom_screenshot.Location = new System.Drawing.Point(13, 318);
            this.btn_bottom_screenshot.Name = "btn_bottom_screenshot";
            this.btn_bottom_screenshot.Size = new System.Drawing.Size(194, 66);
            this.btn_bottom_screenshot.TabIndex = 5;
            this.btn_bottom_screenshot.Text = "5. 하단부 스크린샷";
            this.btn_bottom_screenshot.UseVisualStyleBackColor = true;
            this.btn_bottom_screenshot.Click += new System.EventHandler(this.btn_bottom_screenshot_Click);
            // 
            // btn_tab
            // 
            this.btn_tab.Location = new System.Drawing.Point(13, 390);
            this.btn_tab.Name = "btn_tab";
            this.btn_tab.Size = new System.Drawing.Size(194, 66);
            this.btn_tab.TabIndex = 6;
            this.btn_tab.Text = "6. 탭";
            this.btn_tab.UseVisualStyleBackColor = true;
            this.btn_tab.Click += new System.EventHandler(this.btn_tab_Click);
            // 
            // TestSelenium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 460);
            this.Controls.Add(this.btn_tab);
            this.Controls.Add(this.btn_bottom_screenshot);
            this.Controls.Add(this.btn_screenshot);
            this.Controls.Add(this.btn_write_account_and_login);
            this.Controls.Add(this.btn_id_textbox);
            this.Controls.Add(this.btn_click_loginpage);
            this.Controls.Add(this.btn_selenium_start);
            this.Name = "TestSelenium";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_selenium_start;
        private System.Windows.Forms.Button btn_click_loginpage;
        private System.Windows.Forms.Button btn_id_textbox;
        private System.Windows.Forms.Button btn_write_account_and_login;
        private System.Windows.Forms.Button btn_screenshot;
        private System.Windows.Forms.Button btn_bottom_screenshot;
        private System.Windows.Forms.Button btn_tab;
    }
}

