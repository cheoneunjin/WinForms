﻿
namespace Project_2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.예약ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원예약ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.비회원예약ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.내역확인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원별조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기간별조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원조회및등급확인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblBirth = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Bisque;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.예약ToolStripMenuItem,
            this.내역확인ToolStripMenuItem,
            this.회원관리ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(802, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 예약ToolStripMenuItem
            // 
            this.예약ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.회원예약ToolStripMenuItem,
            this.비회원예약ToolStripMenuItem});
            this.예약ToolStripMenuItem.Name = "예약ToolStripMenuItem";
            this.예약ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.예약ToolStripMenuItem.Text = "예약";
            // 
            // 회원예약ToolStripMenuItem
            // 
            this.회원예약ToolStripMenuItem.Name = "회원예약ToolStripMenuItem";
            this.회원예약ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.회원예약ToolStripMenuItem.Text = "회원예약";
            this.회원예약ToolStripMenuItem.Click += new System.EventHandler(this.회원예약ToolStripMenuItem_Click);
            // 
            // 비회원예약ToolStripMenuItem
            // 
            this.비회원예약ToolStripMenuItem.Name = "비회원예약ToolStripMenuItem";
            this.비회원예약ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.비회원예약ToolStripMenuItem.Text = "비회원예약";
            this.비회원예약ToolStripMenuItem.Click += new System.EventHandler(this.비회원예약ToolStripMenuItem_Click);
            // 
            // 내역확인ToolStripMenuItem
            // 
            this.내역확인ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.회원별조회ToolStripMenuItem,
            this.기간별조회ToolStripMenuItem});
            this.내역확인ToolStripMenuItem.Name = "내역확인ToolStripMenuItem";
            this.내역확인ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.내역확인ToolStripMenuItem.Text = "내역확인";
            // 
            // 회원별조회ToolStripMenuItem
            // 
            this.회원별조회ToolStripMenuItem.Name = "회원별조회ToolStripMenuItem";
            this.회원별조회ToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.회원별조회ToolStripMenuItem.Text = "회원별 이용 내역 조회";
            this.회원별조회ToolStripMenuItem.Click += new System.EventHandler(this.회원별조회ToolStripMenuItem_Click);
            // 
            // 기간별조회ToolStripMenuItem
            // 
            this.기간별조회ToolStripMenuItem.Name = "기간별조회ToolStripMenuItem";
            this.기간별조회ToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.기간별조회ToolStripMenuItem.Text = "기간별 조회";
            this.기간별조회ToolStripMenuItem.Click += new System.EventHandler(this.기간별조회ToolStripMenuItem_Click);
            // 
            // 회원관리ToolStripMenuItem
            // 
            this.회원관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.회원조회및등급확인ToolStripMenuItem});
            this.회원관리ToolStripMenuItem.Name = "회원관리ToolStripMenuItem";
            this.회원관리ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.회원관리ToolStripMenuItem.Text = "회원관리";
            // 
            // 회원조회및등급확인ToolStripMenuItem
            // 
            this.회원조회및등급확인ToolStripMenuItem.Name = "회원조회및등급확인ToolStripMenuItem";
            this.회원조회및등급확인ToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.회원조회및등급확인ToolStripMenuItem.Text = "회원 조회 및 등급 확인";
            this.회원조회및등급확인ToolStripMenuItem.Click += new System.EventHandler(this.회원조회및등급확인ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(53, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "회원번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(53, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "회원이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(53, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "연락처";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MistyRose;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(401, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "생년월일";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(161, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 30);
            this.textBox1.TabIndex = 6;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(161, 177);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 30);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox3.Location = new System.Drawing.Point(161, 236);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(177, 30);
            this.textBox3.TabIndex = 8;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(504, 123);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // lblBirth
            // 
            this.lblBirth.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBirth.Location = new System.Drawing.Point(504, 342);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(177, 30);
            this.lblBirth.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(57, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "조  회";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(59, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 12;
            this.button2.Text = "등  록";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCoral;
            this.button3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(172, 424);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 13;
            this.button3.Text = "수  정";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCoral;
            this.button4.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(291, 424);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 32);
            this.button4.TabIndex = 14;
            this.button4.Text = "삭  제";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightCoral;
            this.button5.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(678, 424);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 32);
            this.button5.TabIndex = 15;
            this.button5.Text = "종  료";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LemonChiffon;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(223, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(345, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = "호텔 예약 프로그램 - 회원등록";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.MistyRose;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(43, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(722, 309);
            this.label6.TabIndex = 17;
            this.label6.Text = "Membership Information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 482);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label6);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "회원등록";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 예약ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회원예약ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 비회원예약ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 내역확인ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회원별조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 기간별조회ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox lblBirth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem 회원관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회원조회및등급확인ToolStripMenuItem;
    }
}
