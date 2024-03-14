namespace MyCalculator
{
    partial class Form1
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
            this.backspaceBtn = new System.Windows.Forms.Button();
            this.resultTxt = new System.Windows.Forms.TextBox();
            this.clearGlobalBtn = new System.Windows.Forms.Button();
            this.clearEntryBtn = new System.Windows.Forms.Button();
            this.devideBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.sixBtn = new System.Windows.Forms.Button();
            this.fiveBtn = new System.Windows.Forms.Button();
            this.fourBtn = new System.Windows.Forms.Button();
            this.multiplyBtn = new System.Windows.Forms.Button();
            this.nineBtn = new System.Windows.Forms.Button();
            this.eightBtn = new System.Windows.Forms.Button();
            this.sevenBtn = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.oneBtn = new System.Windows.Forms.Button();
            this.twoBtn = new System.Windows.Forms.Button();
            this.threeBtn = new System.Windows.Forms.Button();
            this.equalBtn = new System.Windows.Forms.Button();
            this.decimalBtn = new System.Windows.Forms.Button();
            this.zeroBtn = new System.Windows.Forms.Button();
            this.absoluteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backspaceBtn
            // 
            this.backspaceBtn.Font = new System.Drawing.Font("Wingdings", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.backspaceBtn.Location = new System.Drawing.Point(12, 100);
            this.backspaceBtn.Margin = new System.Windows.Forms.Padding(0);
            this.backspaceBtn.Name = "backspaceBtn";
            this.backspaceBtn.Size = new System.Drawing.Size(104, 77);
            this.backspaceBtn.TabIndex = 0;
            this.backspaceBtn.Text = "";
            this.backspaceBtn.UseVisualStyleBackColor = true;
            this.backspaceBtn.Click += new System.EventHandler(this.backspaceBtn_Click);
            // 
            // resultTxt
            // 
            this.resultTxt.Font = new System.Drawing.Font("Gadugi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTxt.Location = new System.Drawing.Point(12, 24);
            this.resultTxt.Margin = new System.Windows.Forms.Padding(0);
            this.resultTxt.Multiline = true;
            this.resultTxt.Name = "resultTxt";
            this.resultTxt.Size = new System.Drawing.Size(435, 58);
            this.resultTxt.TabIndex = 1;
            this.resultTxt.Text = "0";
            this.resultTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // clearGlobalBtn
            // 
            this.clearGlobalBtn.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearGlobalBtn.Location = new System.Drawing.Point(123, 100);
            this.clearGlobalBtn.Margin = new System.Windows.Forms.Padding(0);
            this.clearGlobalBtn.Name = "clearGlobalBtn";
            this.clearGlobalBtn.Size = new System.Drawing.Size(104, 77);
            this.clearGlobalBtn.TabIndex = 2;
            this.clearGlobalBtn.Text = "C";
            this.clearGlobalBtn.UseVisualStyleBackColor = true;
            this.clearGlobalBtn.Click += new System.EventHandler(this.clearGlobalBtn_Click);
            // 
            // clearEntryBtn
            // 
            this.clearEntryBtn.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearEntryBtn.Location = new System.Drawing.Point(233, 100);
            this.clearEntryBtn.Margin = new System.Windows.Forms.Padding(0);
            this.clearEntryBtn.Name = "clearEntryBtn";
            this.clearEntryBtn.Size = new System.Drawing.Size(104, 77);
            this.clearEntryBtn.TabIndex = 3;
            this.clearEntryBtn.Text = "CE";
            this.clearEntryBtn.UseVisualStyleBackColor = true;
            this.clearEntryBtn.Click += new System.EventHandler(this.clearEntryBtn_Click);
            // 
            // devideBtn
            // 
            this.devideBtn.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devideBtn.Location = new System.Drawing.Point(343, 100);
            this.devideBtn.Margin = new System.Windows.Forms.Padding(0);
            this.devideBtn.Name = "devideBtn";
            this.devideBtn.Size = new System.Drawing.Size(104, 77);
            this.devideBtn.TabIndex = 4;
            this.devideBtn.Text = "/";
            this.devideBtn.UseVisualStyleBackColor = true;
            this.devideBtn.Click += new System.EventHandler(this.numberOperator);
            // 
            // minusBtn
            // 
            this.minusBtn.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusBtn.Location = new System.Drawing.Point(343, 276);
            this.minusBtn.Margin = new System.Windows.Forms.Padding(0);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(104, 77);
            this.minusBtn.TabIndex = 8;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.numberOperator);
            // 
            // sixBtn
            // 
            this.sixBtn.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixBtn.Location = new System.Drawing.Point(233, 276);
            this.sixBtn.Margin = new System.Windows.Forms.Padding(0);
            this.sixBtn.Name = "sixBtn";
            this.sixBtn.Size = new System.Drawing.Size(104, 77);
            this.sixBtn.TabIndex = 7;
            this.sixBtn.Text = "6";
            this.sixBtn.UseVisualStyleBackColor = true;
            this.sixBtn.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // fiveBtn
            // 
            this.fiveBtn.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveBtn.Location = new System.Drawing.Point(123, 276);
            this.fiveBtn.Margin = new System.Windows.Forms.Padding(0);
            this.fiveBtn.Name = "fiveBtn";
            this.fiveBtn.Size = new System.Drawing.Size(104, 77);
            this.fiveBtn.TabIndex = 6;
            this.fiveBtn.Text = "5";
            this.fiveBtn.UseVisualStyleBackColor = true;
            this.fiveBtn.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // fourBtn
            // 
            this.fourBtn.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourBtn.Location = new System.Drawing.Point(12, 276);
            this.fourBtn.Margin = new System.Windows.Forms.Padding(0);
            this.fourBtn.Name = "fourBtn";
            this.fourBtn.Size = new System.Drawing.Size(104, 77);
            this.fourBtn.TabIndex = 5;
            this.fourBtn.Text = "4";
            this.fourBtn.UseVisualStyleBackColor = true;
            this.fourBtn.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // multiplyBtn
            // 
            this.multiplyBtn.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyBtn.Location = new System.Drawing.Point(343, 186);
            this.multiplyBtn.Margin = new System.Windows.Forms.Padding(0);
            this.multiplyBtn.Name = "multiplyBtn";
            this.multiplyBtn.Size = new System.Drawing.Size(104, 77);
            this.multiplyBtn.TabIndex = 12;
            this.multiplyBtn.Text = "X";
            this.multiplyBtn.UseVisualStyleBackColor = true;
            this.multiplyBtn.Click += new System.EventHandler(this.numberOperator);
            // 
            // nineBtn
            // 
            this.nineBtn.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineBtn.Location = new System.Drawing.Point(233, 186);
            this.nineBtn.Margin = new System.Windows.Forms.Padding(0);
            this.nineBtn.Name = "nineBtn";
            this.nineBtn.Size = new System.Drawing.Size(104, 77);
            this.nineBtn.TabIndex = 11;
            this.nineBtn.Text = "9";
            this.nineBtn.UseVisualStyleBackColor = true;
            this.nineBtn.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // eightBtn
            // 
            this.eightBtn.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightBtn.Location = new System.Drawing.Point(123, 186);
            this.eightBtn.Margin = new System.Windows.Forms.Padding(0);
            this.eightBtn.Name = "eightBtn";
            this.eightBtn.Size = new System.Drawing.Size(104, 77);
            this.eightBtn.TabIndex = 10;
            this.eightBtn.Text = "8";
            this.eightBtn.UseVisualStyleBackColor = true;
            this.eightBtn.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // sevenBtn
            // 
            this.sevenBtn.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenBtn.Location = new System.Drawing.Point(12, 186);
            this.sevenBtn.Margin = new System.Windows.Forms.Padding(0);
            this.sevenBtn.Name = "sevenBtn";
            this.sevenBtn.Size = new System.Drawing.Size(104, 77);
            this.sevenBtn.TabIndex = 9;
            this.sevenBtn.Text = "7";
            this.sevenBtn.UseVisualStyleBackColor = true;
            this.sevenBtn.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // plusBtn
            // 
            this.plusBtn.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusBtn.Location = new System.Drawing.Point(343, 365);
            this.plusBtn.Margin = new System.Windows.Forms.Padding(0);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(104, 77);
            this.plusBtn.TabIndex = 16;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.numberOperator);
            // 
            // oneBtn
            // 
            this.oneBtn.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneBtn.Location = new System.Drawing.Point(233, 365);
            this.oneBtn.Margin = new System.Windows.Forms.Padding(0);
            this.oneBtn.Name = "oneBtn";
            this.oneBtn.Size = new System.Drawing.Size(104, 77);
            this.oneBtn.TabIndex = 15;
            this.oneBtn.Text = "1";
            this.oneBtn.UseVisualStyleBackColor = true;
            this.oneBtn.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // twoBtn
            // 
            this.twoBtn.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoBtn.Location = new System.Drawing.Point(123, 365);
            this.twoBtn.Margin = new System.Windows.Forms.Padding(0);
            this.twoBtn.Name = "twoBtn";
            this.twoBtn.Size = new System.Drawing.Size(104, 77);
            this.twoBtn.TabIndex = 14;
            this.twoBtn.Text = "2";
            this.twoBtn.UseVisualStyleBackColor = true;
            this.twoBtn.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // threeBtn
            // 
            this.threeBtn.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeBtn.Location = new System.Drawing.Point(12, 365);
            this.threeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.threeBtn.Name = "threeBtn";
            this.threeBtn.Size = new System.Drawing.Size(104, 77);
            this.threeBtn.TabIndex = 13;
            this.threeBtn.Text = "3";
            this.threeBtn.UseVisualStyleBackColor = true;
            this.threeBtn.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // equalBtn
            // 
            this.equalBtn.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalBtn.Location = new System.Drawing.Point(343, 454);
            this.equalBtn.Margin = new System.Windows.Forms.Padding(0);
            this.equalBtn.Name = "equalBtn";
            this.equalBtn.Size = new System.Drawing.Size(104, 77);
            this.equalBtn.TabIndex = 20;
            this.equalBtn.Text = "=";
            this.equalBtn.UseVisualStyleBackColor = true;
            this.equalBtn.Click += new System.EventHandler(this.equalPressed);
            // 
            // decimalBtn
            // 
            this.decimalBtn.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalBtn.Location = new System.Drawing.Point(233, 454);
            this.decimalBtn.Margin = new System.Windows.Forms.Padding(0);
            this.decimalBtn.Name = "decimalBtn";
            this.decimalBtn.Size = new System.Drawing.Size(104, 77);
            this.decimalBtn.TabIndex = 19;
            this.decimalBtn.Text = ",";
            this.decimalBtn.UseVisualStyleBackColor = true;
            this.decimalBtn.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // zeroBtn
            // 
            this.zeroBtn.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroBtn.Location = new System.Drawing.Point(123, 454);
            this.zeroBtn.Margin = new System.Windows.Forms.Padding(0);
            this.zeroBtn.Name = "zeroBtn";
            this.zeroBtn.Size = new System.Drawing.Size(104, 77);
            this.zeroBtn.TabIndex = 18;
            this.zeroBtn.Text = "0";
            this.zeroBtn.UseVisualStyleBackColor = true;
            this.zeroBtn.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // absoluteBtn
            // 
            this.absoluteBtn.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.absoluteBtn.Location = new System.Drawing.Point(12, 454);
            this.absoluteBtn.Margin = new System.Windows.Forms.Padding(0);
            this.absoluteBtn.Name = "absoluteBtn";
            this.absoluteBtn.Size = new System.Drawing.Size(104, 77);
            this.absoluteBtn.TabIndex = 17;
            this.absoluteBtn.Text = "+/-";
            this.absoluteBtn.UseVisualStyleBackColor = true;
            this.absoluteBtn.Click += new System.EventHandler(this.absoluteBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(459, 547);
            this.Controls.Add(this.equalBtn);
            this.Controls.Add(this.decimalBtn);
            this.Controls.Add(this.zeroBtn);
            this.Controls.Add(this.absoluteBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.oneBtn);
            this.Controls.Add(this.twoBtn);
            this.Controls.Add(this.threeBtn);
            this.Controls.Add(this.multiplyBtn);
            this.Controls.Add(this.nineBtn);
            this.Controls.Add(this.eightBtn);
            this.Controls.Add(this.sevenBtn);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.sixBtn);
            this.Controls.Add(this.fiveBtn);
            this.Controls.Add(this.fourBtn);
            this.Controls.Add(this.devideBtn);
            this.Controls.Add(this.clearEntryBtn);
            this.Controls.Add(this.clearGlobalBtn);
            this.Controls.Add(this.resultTxt);
            this.Controls.Add(this.backspaceBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backspaceBtn;
        private System.Windows.Forms.TextBox resultTxt;
        private System.Windows.Forms.Button clearGlobalBtn;
        private System.Windows.Forms.Button clearEntryBtn;
        private System.Windows.Forms.Button devideBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button sixBtn;
        private System.Windows.Forms.Button fiveBtn;
        private System.Windows.Forms.Button fourBtn;
        private System.Windows.Forms.Button multiplyBtn;
        private System.Windows.Forms.Button nineBtn;
        private System.Windows.Forms.Button eightBtn;
        private System.Windows.Forms.Button sevenBtn;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button oneBtn;
        private System.Windows.Forms.Button twoBtn;
        private System.Windows.Forms.Button threeBtn;
        private System.Windows.Forms.Button equalBtn;
        private System.Windows.Forms.Button decimalBtn;
        private System.Windows.Forms.Button zeroBtn;
        private System.Windows.Forms.Button absoluteBtn;
    }
}

