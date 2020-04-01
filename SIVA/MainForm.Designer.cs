namespace SIVA
{
	partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GoTray = new System.Windows.Forms.Button();
            this.AimApply = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AimSpdX = new System.Windows.Forms.TextBox();
            this.AimSpdY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AimPosX = new System.Windows.Forms.TextBox();
            this.AimPosY = new System.Windows.Forms.TextBox();
            this.Yaxis = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.HorizontalValue = new System.Windows.Forms.Label();
            this.Horizontal = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Left = new System.Windows.Forms.TextBox();
            this.Right = new System.Windows.Forms.TextBox();
            this.Force = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchApply = new System.Windows.Forms.Button();
            this.areashow = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.VerticalValue = new System.Windows.Forms.Label();
            this.Vertical = new System.Windows.Forms.TrackBar();
            this.label13 = new System.Windows.Forms.Label();
            this.Bottom = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Top = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.ResText = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.HumanEnable = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HumanStrength = new System.Windows.Forms.TextBox();
            this.LoadSetting = new System.Windows.Forms.Button();
            this.SaveSetting = new System.Windows.Forms.Button();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Horizontal)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Vertical)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(347, 283);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SaveSetting);
            this.tabPage1.Controls.Add(this.LoadSetting);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.GoTray);
            this.tabPage1.Controls.Add(this.AimApply);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(339, 257);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Aiming";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // GoTray
            // 
            this.GoTray.Location = new System.Drawing.Point(6, 228);
            this.GoTray.Name = "GoTray";
            this.GoTray.Size = new System.Drawing.Size(175, 23);
            this.GoTray.TabIndex = 47;
            this.GoTray.Text = "Hide with Tray Icon";
            this.GoTray.UseVisualStyleBackColor = true;
            this.GoTray.Click += new System.EventHandler(this.GoTray_Click);
            // 
            // AimApply
            // 
            this.AimApply.Location = new System.Drawing.Point(187, 199);
            this.AimApply.Name = "AimApply";
            this.AimApply.Size = new System.Drawing.Size(146, 52);
            this.AimApply.TabIndex = 46;
            this.AimApply.Text = "Apply";
            this.AimApply.UseVisualStyleBackColor = true;
            this.AimApply.Click += new System.EventHandler(this.AimApply_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.AimSpdX);
            this.groupBox4.Controls.Add(this.AimSpdY);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.AimPosX);
            this.groupBox4.Controls.Add(this.AimPosY);
            this.groupBox4.Controls.Add(this.Yaxis);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(327, 100);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aim Customizer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 12);
            this.label5.TabIndex = 28;
            this.label5.Text = "Aim Speed X";
            // 
            // AimSpdX
            // 
            this.AimSpdX.Location = new System.Drawing.Point(100, 15);
            this.AimSpdX.Name = "AimSpdX";
            this.AimSpdX.Size = new System.Drawing.Size(70, 21);
            this.AimSpdX.TabIndex = 30;
            this.AimSpdX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AimSpdY
            // 
            this.AimSpdY.Location = new System.Drawing.Point(100, 42);
            this.AimSpdY.Name = "AimSpdY";
            this.AimSpdY.Size = new System.Drawing.Size(70, 21);
            this.AimSpdY.TabIndex = 31;
            this.AimSpdY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 12);
            this.label6.TabIndex = 29;
            this.label6.Text = "Aim Speed Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 12);
            this.label1.TabIndex = 38;
            this.label1.Text = "Position X / Y";
            // 
            // AimPosX
            // 
            this.AimPosX.Location = new System.Drawing.Point(100, 69);
            this.AimPosX.Name = "AimPosX";
            this.AimPosX.Size = new System.Drawing.Size(32, 21);
            this.AimPosX.TabIndex = 39;
            this.AimPosX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AimPosY
            // 
            this.AimPosY.Location = new System.Drawing.Point(138, 69);
            this.AimPosY.Name = "AimPosY";
            this.AimPosY.Size = new System.Drawing.Size(32, 21);
            this.AimPosY.TabIndex = 40;
            this.AimPosY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Yaxis
            // 
            this.Yaxis.AutoSize = true;
            this.Yaxis.Location = new System.Drawing.Point(181, 71);
            this.Yaxis.Name = "Yaxis";
            this.Yaxis.Size = new System.Drawing.Size(92, 16);
            this.Yaxis.TabIndex = 36;
            this.Yaxis.Text = "Y-Axis Free";
            this.Yaxis.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.Force);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.SearchApply);
            this.tabPage2.Controls.Add(this.areashow);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(339, 257);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Searching";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.HorizontalValue);
            this.groupBox1.Controls.Add(this.Horizontal);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.Left);
            this.groupBox1.Controls.Add(this.Right);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 83);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Horizontal Range";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(107, 52);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 12);
            this.label17.TabIndex = 38;
            this.label17.Text = "Right";
            // 
            // HorizontalValue
            // 
            this.HorizontalValue.AutoSize = true;
            this.HorizontalValue.Location = new System.Drawing.Point(288, 26);
            this.HorizontalValue.Name = "HorizontalValue";
            this.HorizontalValue.Size = new System.Drawing.Size(35, 12);
            this.HorizontalValue.TabIndex = 37;
            this.HorizontalValue.Text = "value";
            // 
            // Horizontal
            // 
            this.Horizontal.AutoSize = false;
            this.Horizontal.BackColor = System.Drawing.SystemColors.Window;
            this.Horizontal.Location = new System.Drawing.Point(88, 22);
            this.Horizontal.Name = "Horizontal";
            this.Horizontal.Size = new System.Drawing.Size(203, 26);
            this.Horizontal.TabIndex = 36;
            this.Horizontal.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Horizontal.ValueChanged += new System.EventHandler(this.Horizontal_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 12);
            this.label12.TabIndex = 35;
            this.label12.Text = "Quick Change";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 12);
            this.label11.TabIndex = 34;
            this.label11.Text = "Left";
            // 
            // Left
            // 
            this.Left.Location = new System.Drawing.Point(37, 48);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(45, 21);
            this.Left.TabIndex = 33;
            this.Left.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Right
            // 
            this.Right.Location = new System.Drawing.Point(146, 49);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(45, 21);
            this.Right.TabIndex = 32;
            this.Right.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Force
            // 
            this.Force.Location = new System.Drawing.Point(136, 220);
            this.Force.Name = "Force";
            this.Force.Size = new System.Drawing.Size(30, 21);
            this.Force.TabIndex = 34;
            this.Force.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 12);
            this.label7.TabIndex = 35;
            this.label7.Text = "Force Search Range";
            // 
            // SearchApply
            // 
            this.SearchApply.Location = new System.Drawing.Point(212, 220);
            this.SearchApply.Name = "SearchApply";
            this.SearchApply.Size = new System.Drawing.Size(121, 23);
            this.SearchApply.TabIndex = 36;
            this.SearchApply.Text = "Apply";
            this.SearchApply.UseVisualStyleBackColor = true;
            this.SearchApply.Click += new System.EventHandler(this.SearchApply_Click);
            // 
            // areashow
            // 
            this.areashow.Location = new System.Drawing.Point(6, 189);
            this.areashow.Name = "areashow";
            this.areashow.Size = new System.Drawing.Size(327, 23);
            this.areashow.TabIndex = 37;
            this.areashow.Text = "Show serach area";
            this.areashow.UseVisualStyleBackColor = true;
            this.areashow.Click += new System.EventHandler(this.areashow_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.VerticalValue);
            this.groupBox2.Controls.Add(this.Vertical);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.Bottom);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.Top);
            this.groupBox2.Location = new System.Drawing.Point(6, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 83);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vertical Range";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(107, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 12);
            this.label18.TabIndex = 41;
            this.label18.Text = "Bottom";
            // 
            // VerticalValue
            // 
            this.VerticalValue.AutoSize = true;
            this.VerticalValue.Location = new System.Drawing.Point(288, 26);
            this.VerticalValue.Name = "VerticalValue";
            this.VerticalValue.Size = new System.Drawing.Size(35, 12);
            this.VerticalValue.TabIndex = 40;
            this.VerticalValue.Text = "value";
            // 
            // Vertical
            // 
            this.Vertical.AutoSize = false;
            this.Vertical.BackColor = System.Drawing.SystemColors.Window;
            this.Vertical.Location = new System.Drawing.Point(88, 22);
            this.Vertical.Name = "Vertical";
            this.Vertical.Size = new System.Drawing.Size(203, 26);
            this.Vertical.TabIndex = 39;
            this.Vertical.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Vertical.ValueChanged += new System.EventHandler(this.Vertical_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 12);
            this.label13.TabIndex = 38;
            this.label13.Text = "Quick Change";
            // 
            // Bottom
            // 
            this.Bottom.Location = new System.Drawing.Point(157, 48);
            this.Bottom.Name = "Bottom";
            this.Bottom.Size = new System.Drawing.Size(45, 21);
            this.Bottom.TabIndex = 26;
            this.Bottom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 12);
            this.label10.TabIndex = 25;
            this.label10.Text = "Top";
            // 
            // Top
            // 
            this.Top.Location = new System.Drawing.Point(37, 48);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(45, 21);
            this.Top.TabIndex = 24;
            this.Top.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(339, 257);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Advanced";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(191, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 12);
            this.label9.TabIndex = 45;
            this.label9.Text = "Current Resolution :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ResText
            // 
            this.ResText.AutoSize = true;
            this.ResText.Location = new System.Drawing.Point(309, 289);
            this.ResText.Name = "ResText";
            this.ResText.Size = new System.Drawing.Size(22, 12);
            this.ResText.TabIndex = 44;
            this.ResText.Text = "~P";
            this.ResText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.HumanStrength);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.HumanEnable);
            this.groupBox3.Location = new System.Drawing.Point(6, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 74);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aim Humanizer";
            // 
            // HumanEnable
            // 
            this.HumanEnable.AutoSize = true;
            this.HumanEnable.Location = new System.Drawing.Point(8, 20);
            this.HumanEnable.Name = "HumanEnable";
            this.HumanEnable.Size = new System.Drawing.Size(128, 16);
            this.HumanEnable.TabIndex = 0;
            this.HumanEnable.Text = "Enable Humanizer";
            this.HumanEnable.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Humanizer Strength";
            // 
            // HumanStrength
            // 
            this.HumanStrength.Location = new System.Drawing.Point(128, 42);
            this.HumanStrength.Name = "HumanStrength";
            this.HumanStrength.Size = new System.Drawing.Size(70, 21);
            this.HumanStrength.TabIndex = 2;
            this.HumanStrength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoadSetting
            // 
            this.LoadSetting.Location = new System.Drawing.Point(6, 199);
            this.LoadSetting.Name = "LoadSetting";
            this.LoadSetting.Size = new System.Drawing.Size(85, 23);
            this.LoadSetting.TabIndex = 49;
            this.LoadSetting.Text = "Load";
            this.LoadSetting.UseVisualStyleBackColor = true;
            this.LoadSetting.Click += new System.EventHandler(this.LoadSetting_Click);
            // 
            // SaveSetting
            // 
            this.SaveSetting.Location = new System.Drawing.Point(96, 199);
            this.SaveSetting.Name = "SaveSetting";
            this.SaveSetting.Size = new System.Drawing.Size(85, 23);
            this.SaveSetting.TabIndex = 50;
            this.SaveSetting.Text = "Save";
            this.SaveSetting.UseVisualStyleBackColor = true;
            this.SaveSetting.Click += new System.EventHandler(this.SaveSetting_Click);
            // 
            // TrayIcon
            // 
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "Click to restore";
            this.TrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 306);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ResText);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Horizontal)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Vertical)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label HorizontalValue;
        private System.Windows.Forms.TrackBar Horizontal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Left;
        private System.Windows.Forms.TextBox Right;
        private System.Windows.Forms.TextBox Force;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SearchApply;
        private System.Windows.Forms.Button areashow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label VerticalValue;
        private System.Windows.Forms.TrackBar Vertical;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Bottom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Top;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AimSpdX;
        private System.Windows.Forms.TextBox AimSpdY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AimPosX;
        private System.Windows.Forms.TextBox AimPosY;
        private System.Windows.Forms.CheckBox Yaxis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label ResText;
        private System.Windows.Forms.Button GoTray;
        private System.Windows.Forms.Button AimApply;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox HumanStrength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox HumanEnable;
        private System.Windows.Forms.Button SaveSetting;
        private System.Windows.Forms.Button LoadSetting;
        private System.Windows.Forms.NotifyIcon TrayIcon;
    }
}

