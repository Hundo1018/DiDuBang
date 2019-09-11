namespace DiDuBang_ProtoType
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Underline_BTN = new System.Windows.Forms.Button();
            this.Strikeout_BTN = new System.Windows.Forms.Button();
            this.Italic_BTN = new System.Windows.Forms.Button();
            this.Bold_BTN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(993, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(808, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(185, 526);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(0, 24);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(191, 526);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(191, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 526);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.richTextBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBox1.Location = new System.Drawing.Point(34, 80);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(542, 720);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "dsfasdasdsadas";
            this.richTextBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RichTextBox1_MouseUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Underline_BTN);
            this.groupBox2.Controls.Add(this.Strikeout_BTN);
            this.groupBox2.Controls.Add(this.Italic_BTN);
            this.groupBox2.Controls.Add(this.Bold_BTN);
            this.groupBox2.Location = new System.Drawing.Point(319, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 53);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Underline_BTN
            // 
            this.Underline_BTN.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Underline_BTN.Location = new System.Drawing.Point(163, 21);
            this.Underline_BTN.Name = "Underline_BTN";
            this.Underline_BTN.Size = new System.Drawing.Size(22, 23);
            this.Underline_BTN.TabIndex = 3;
            this.Underline_BTN.Text = "U";
            this.Underline_BTN.UseVisualStyleBackColor = true;
            this.Underline_BTN.Click += new System.EventHandler(this.Underline_BTN_Click);
            // 
            // Strikeout_BTN
            // 
            this.Strikeout_BTN.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Strikeout_BTN.Location = new System.Drawing.Point(135, 21);
            this.Strikeout_BTN.Name = "Strikeout_BTN";
            this.Strikeout_BTN.Size = new System.Drawing.Size(22, 23);
            this.Strikeout_BTN.TabIndex = 2;
            this.Strikeout_BTN.Text = "S";
            this.Strikeout_BTN.UseVisualStyleBackColor = true;
            this.Strikeout_BTN.Click += new System.EventHandler(this.Strikeout_BTN_Click);
            // 
            // Italic_BTN
            // 
            this.Italic_BTN.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Italic_BTN.Location = new System.Drawing.Point(107, 21);
            this.Italic_BTN.Name = "Italic_BTN";
            this.Italic_BTN.Size = new System.Drawing.Size(22, 23);
            this.Italic_BTN.TabIndex = 1;
            this.Italic_BTN.Text = "I";
            this.Italic_BTN.UseVisualStyleBackColor = true;
            this.Italic_BTN.Click += new System.EventHandler(this.Italic_BTN_Click);
            // 
            // Bold_BTN
            // 
            this.Bold_BTN.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Bold_BTN.Location = new System.Drawing.Point(79, 21);
            this.Bold_BTN.Name = "Bold_BTN";
            this.Bold_BTN.Size = new System.Drawing.Size(22, 23);
            this.Bold_BTN.TabIndex = 0;
            this.Bold_BTN.Text = "B";
            this.Bold_BTN.UseVisualStyleBackColor = true;
            this.Bold_BTN.Click += new System.EventHandler(this.Bold_BTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 550);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Underline_BTN;
        private System.Windows.Forms.Button Strikeout_BTN;
        private System.Windows.Forms.Button Italic_BTN;
        private System.Windows.Forms.Button Bold_BTN;
    }
}

