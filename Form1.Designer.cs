using System.Windows.Forms;

namespace calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nazad = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.plusminus = new System.Windows.Forms.Button();
            this.coren = new System.Windows.Forms.Button();
            this.a7 = new System.Windows.Forms.Button();
            this.a8 = new System.Windows.Forms.Button();
            this.a9 = new System.Windows.Forms.Button();
            this.delit = new System.Windows.Forms.Button();
            this.procent = new System.Windows.Forms.Button();
            this.a4 = new System.Windows.Forms.Button();
            this.a5 = new System.Windows.Forms.Button();
            this.a6 = new System.Windows.Forms.Button();
            this.umnoshit = new System.Windows.Forms.Button();
            this.kvadrat = new System.Windows.Forms.Button();
            this.a1 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.a0 = new System.Windows.Forms.Button();
            this.zapyataya = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.ravno = new System.Windows.Forms.Button();
            this.textXYI = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nazad
            // 
            this.nazad.Location = new System.Drawing.Point(12, 110);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(50, 42);
            this.nazad.TabIndex = 0;
            this.nazad.Text = "<------";
            this.nazad.UseVisualStyleBackColor = true;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(68, 110);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(50, 42);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // log
            // 
            this.log.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.log.Location = new System.Drawing.Point(124, 110);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(50, 42);
            this.log.TabIndex = 2;
            this.log.Text = "CE";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // plusminus
            // 
            this.plusminus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.plusminus.Location = new System.Drawing.Point(180, 110);
            this.plusminus.Name = "plusminus";
            this.plusminus.Size = new System.Drawing.Size(50, 42);
            this.plusminus.TabIndex = 3;
            this.plusminus.Text = "+/-";
            this.plusminus.UseVisualStyleBackColor = true;
            this.plusminus.Click += new System.EventHandler(this.plusminus_Click);
            // 
            // coren
            // 
            this.coren.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coren.Location = new System.Drawing.Point(236, 110);
            this.coren.Name = "coren";
            this.coren.Size = new System.Drawing.Size(50, 42);
            this.coren.TabIndex = 4;
            this.coren.Text = "√";
            this.coren.UseVisualStyleBackColor = true;
            this.coren.Click += new System.EventHandler(this.coren_Click);
            // 
            // a7
            // 
            this.a7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.a7.Location = new System.Drawing.Point(12, 158);
            this.a7.Name = "a7";
            this.a7.Size = new System.Drawing.Size(50, 42);
            this.a7.TabIndex = 5;
            this.a7.Text = "7";
            this.a7.UseVisualStyleBackColor = true;
            this.a7.Click += new System.EventHandler(this.a7_Click);
            // 
            // a8
            // 
            this.a8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.a8.Location = new System.Drawing.Point(68, 158);
            this.a8.Name = "a8";
            this.a8.Size = new System.Drawing.Size(50, 42);
            this.a8.TabIndex = 6;
            this.a8.Text = "8";
            this.a8.UseVisualStyleBackColor = true;
            this.a8.Click += new System.EventHandler(this.a8_Click);
            // 
            // a9
            // 
            this.a9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.a9.Location = new System.Drawing.Point(124, 157);
            this.a9.Name = "a9";
            this.a9.Size = new System.Drawing.Size(50, 42);
            this.a9.TabIndex = 7;
            this.a9.Text = "9";
            this.a9.UseVisualStyleBackColor = true;
            this.a9.Click += new System.EventHandler(this.a9_Click);
            // 
            // delit
            // 
            this.delit.Location = new System.Drawing.Point(180, 158);
            this.delit.Name = "delit";
            this.delit.Size = new System.Drawing.Size(50, 42);
            this.delit.TabIndex = 8;
            this.delit.Text = "/";
            this.delit.UseVisualStyleBackColor = true;
            this.delit.Click += new System.EventHandler(this.delit_Click);
            // 
            // procent
            // 
            this.procent.Location = new System.Drawing.Point(235, 158);
            this.procent.Name = "procent";
            this.procent.Size = new System.Drawing.Size(50, 42);
            this.procent.TabIndex = 9;
            this.procent.Text = "%";
            this.procent.UseVisualStyleBackColor = true;
            this.procent.Click += new System.EventHandler(this.procent_Click);
            // 
            // a4
            // 
            this.a4.Location = new System.Drawing.Point(12, 206);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(50, 42);
            this.a4.TabIndex = 10;
            this.a4.Text = "4";
            this.a4.UseVisualStyleBackColor = true;
            this.a4.Click += new System.EventHandler(this.a4_Click);
            // 
            // a5
            // 
            this.a5.Location = new System.Drawing.Point(68, 206);
            this.a5.Name = "a5";
            this.a5.Size = new System.Drawing.Size(50, 42);
            this.a5.TabIndex = 11;
            this.a5.Text = "5";
            this.a5.UseVisualStyleBackColor = true;
            this.a5.Click += new System.EventHandler(this.a5_Click);
            // 
            // a6
            // 
            this.a6.Location = new System.Drawing.Point(124, 206);
            this.a6.Name = "a6";
            this.a6.Size = new System.Drawing.Size(50, 42);
            this.a6.TabIndex = 12;
            this.a6.Text = "6";
            this.a6.UseVisualStyleBackColor = true;
            this.a6.Click += new System.EventHandler(this.a6_Click);
            // 
            // umnoshit
            // 
            this.umnoshit.Location = new System.Drawing.Point(180, 206);
            this.umnoshit.Name = "umnoshit";
            this.umnoshit.Size = new System.Drawing.Size(50, 42);
            this.umnoshit.TabIndex = 13;
            this.umnoshit.Text = "*";
            this.umnoshit.UseVisualStyleBackColor = true;
            this.umnoshit.Click += new System.EventHandler(this.umnoshit_Click);
            // 
            // kvadrat
            // 
            this.kvadrat.Location = new System.Drawing.Point(235, 206);
            this.kvadrat.Name = "kvadrat";
            this.kvadrat.Size = new System.Drawing.Size(50, 42);
            this.kvadrat.TabIndex = 14;
            this.kvadrat.Text = "x²";
            this.kvadrat.UseVisualStyleBackColor = true;
            this.kvadrat.Click += new System.EventHandler(this.kvadrat_Click);
            // 
            // a1
            // 
            this.a1.Location = new System.Drawing.Point(12, 254);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(50, 42);
            this.a1.TabIndex = 15;
            this.a1.Text = "1";
            this.a1.UseVisualStyleBackColor = true;
            this.a1.Click += new System.EventHandler(this.a1_Click);
            // 
            // a2
            // 
            this.a2.Location = new System.Drawing.Point(68, 254);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(50, 42);
            this.a2.TabIndex = 16;
            this.a2.Text = "2";
            this.a2.UseVisualStyleBackColor = true;
            this.a2.Click += new System.EventHandler(this.a2_Click);
            // 
            // a3
            // 
            this.a3.Location = new System.Drawing.Point(124, 254);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(50, 42);
            this.a3.TabIndex = 17;
            this.a3.Text = "3";
            this.a3.UseVisualStyleBackColor = true;
            this.a3.Click += new System.EventHandler(this.a3_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(180, 254);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(50, 42);
            this.minus.TabIndex = 18;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // a0
            // 
            this.a0.Location = new System.Drawing.Point(12, 302);
            this.a0.Name = "a0";
            this.a0.Size = new System.Drawing.Size(106, 42);
            this.a0.TabIndex = 20;
            this.a0.Text = "0";
            this.a0.UseVisualStyleBackColor = true;
            this.a0.Click += new System.EventHandler(this.a0_Click);
            // 
            // zapyataya
            // 
            this.zapyataya.Location = new System.Drawing.Point(124, 302);
            this.zapyataya.Name = "zapyataya";
            this.zapyataya.Size = new System.Drawing.Size(50, 42);
            this.zapyataya.TabIndex = 22;
            this.zapyataya.Text = ",";
            this.zapyataya.UseVisualStyleBackColor = true;
            this.zapyataya.Click += new System.EventHandler(this.zapyataya_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(179, 302);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(50, 42);
            this.plus.TabIndex = 23;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // ravno
            // 
            this.ravno.Location = new System.Drawing.Point(235, 254);
            this.ravno.Name = "ravno";
            this.ravno.Size = new System.Drawing.Size(50, 90);
            this.ravno.TabIndex = 24;
            this.ravno.Text = "=";
            this.ravno.UseVisualStyleBackColor = true;
            this.ravno.Click += new System.EventHandler(this.ravno_Click);
            // 
            // textXYI
            // 
            this.textXYI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textXYI.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textXYI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textXYI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textXYI.Location = new System.Drawing.Point(12, 15);
            this.textXYI.Multiline = true;
            this.textXYI.Name = "textXYI";
            this.textXYI.ReadOnly = true;
            this.textXYI.Size = new System.Drawing.Size(273, 89);
            this.textXYI.TabIndex = 25;
            this.textXYI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(251, 17);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(33, 20);
            this.textBox2.TabIndex = 26;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(13, 17);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(232, 20);
            this.textBox4.TabIndex = 28;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(168, 64);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 37);
            this.textBox1.TabIndex = 29;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AcceptButton = this.ravno;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(296, 353);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textXYI);
            this.Controls.Add(this.ravno);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.zapyataya);
            this.Controls.Add(this.a0);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.kvadrat);
            this.Controls.Add(this.umnoshit);
            this.Controls.Add(this.a6);
            this.Controls.Add(this.a5);
            this.Controls.Add(this.a4);
            this.Controls.Add(this.procent);
            this.Controls.Add(this.delit);
            this.Controls.Add(this.a9);
            this.Controls.Add(this.a8);
            this.Controls.Add(this.a7);
            this.Controls.Add(this.coren);
            this.Controls.Add(this.plusminus);
            this.Controls.Add(this.log);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.nazad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button plusminus;
        private System.Windows.Forms.Button coren;
        private System.Windows.Forms.Button a7;
        private System.Windows.Forms.Button a8;
        private System.Windows.Forms.Button a9;
        private System.Windows.Forms.Button delit;
        private System.Windows.Forms.Button procent;
        private System.Windows.Forms.Button a4;
        private System.Windows.Forms.Button a5;
        private System.Windows.Forms.Button a6;
        private System.Windows.Forms.Button umnoshit;
        private System.Windows.Forms.Button kvadrat;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button a0;
        private System.Windows.Forms.Button zapyataya;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button ravno;
        private System.Windows.Forms.TextBox textXYI;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox4;
        private TextBox textBox1;
    }
}

