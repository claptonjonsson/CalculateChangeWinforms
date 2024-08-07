namespace CalculateChangeWinforms
{
    partial class CalculateChange
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDescription = new Label();
            Title = new Label();
            cbCurrency = new ComboBox();
            tbPrice = new TextBox();
            tbMoneyGiven = new TextBox();
            btnClear = new Button();
            btnQuit = new Button();
            lblCurrency = new Label();
            lblPrice = new Label();
            lblMoneyGiven = new Label();
            pnlDisplayBackground = new Panel();
            btnCopy = new Button();
            lblDisplayInfo = new Label();
            btnCalculate = new Button();
            lblDisplayInput = new Label();
            pnlDisplayBackground.SuspendLayout();
            SuspendLayout();
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Lucida Fax", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(219, 26);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(177, 30);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "Calculate your change. \r\nFill in the fields to the left.";
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Bahnschrift Condensed", 24F);
            Title.Location = new Point(12, 17);
            Title.Name = "Title";
            Title.Size = new Size(194, 39);
            Title.TabIndex = 1;
            Title.Text = "CalculateChange";
            // 
            // cbCurrency
            // 
            cbCurrency.AllowDrop = true;
            cbCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCurrency.FormattingEnabled = true;
            cbCurrency.Location = new Point(12, 103);
            cbCurrency.Name = "cbCurrency";
            cbCurrency.Size = new Size(84, 23);
            cbCurrency.Sorted = true;
            cbCurrency.TabIndex = 2;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(12, 153);
            tbPrice.MaxLength = 9;
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(84, 23);
            tbPrice.TabIndex = 3;
            // 
            // tbMoneyGiven
            // 
            tbMoneyGiven.Location = new Point(12, 207);
            tbMoneyGiven.MaxLength = 9;
            tbMoneyGiven.Name = "tbMoneyGiven";
            tbMoneyGiven.Size = new Size(84, 23);
            tbMoneyGiven.TabIndex = 4;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(12, 281);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(84, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear fields";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(12, 332);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(84, 23);
            btnQuit.TabIndex = 6;
            btnQuit.Text = "QUIT";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // lblCurrency
            // 
            lblCurrency.AutoSize = true;
            lblCurrency.Location = new Point(12, 85);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new Size(51, 15);
            lblCurrency.TabIndex = 7;
            lblCurrency.Text = "Curency";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(12, 135);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(61, 15);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Total price";
            // 
            // lblMoneyGiven
            // 
            lblMoneyGiven.AutoSize = true;
            lblMoneyGiven.Location = new Point(12, 189);
            lblMoneyGiven.Name = "lblMoneyGiven";
            lblMoneyGiven.Size = new Size(76, 15);
            lblMoneyGiven.TabIndex = 9;
            lblMoneyGiven.Text = "Money given";
            // 
            // pnlDisplayBackground
            // 
            pnlDisplayBackground.BackColor = Color.WhiteSmoke;
            pnlDisplayBackground.BorderStyle = BorderStyle.FixedSingle;
            pnlDisplayBackground.Controls.Add(btnCopy);
            pnlDisplayBackground.Controls.Add(lblDisplayInfo);
            pnlDisplayBackground.Location = new Point(117, 103);
            pnlDisplayBackground.Name = "pnlDisplayBackground";
            pnlDisplayBackground.Size = new Size(370, 252);
            pnlDisplayBackground.TabIndex = 10;
            // 
            // btnCopy
            // 
            btnCopy.Enabled = false;
            btnCopy.Location = new Point(308, 221);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(55, 23);
            btnCopy.TabIndex = 1;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // lblDisplayInfo
            // 
            lblDisplayInfo.AutoSize = true;
            lblDisplayInfo.Font = new Font("Lucida Console", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDisplayInfo.Location = new Point(21, 20);
            lblDisplayInfo.Name = "lblDisplayInfo";
            lblDisplayInfo.Size = new Size(0, 11);
            lblDisplayInfo.TabIndex = 0;
            lblDisplayInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(12, 252);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(84, 23);
            btnCalculate.TabIndex = 11;
            btnCalculate.Text = "Caculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblDisplayInput
            // 
            lblDisplayInput.AutoSize = true;
            lblDisplayInput.Location = new Point(193, 85);
            lblDisplayInput.Name = "lblDisplayInput";
            lblDisplayInput.Size = new Size(231, 15);
            lblDisplayInput.TabIndex = 12;
            lblDisplayInput.Text = "Fill in the input fields and press 'Calculate'.";
            lblDisplayInput.TextAlign = ContentAlignment.TopCenter;
            // 
            // CalculateChange
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 379);
            Controls.Add(lblDisplayInput);
            Controls.Add(btnCalculate);
            Controls.Add(tbMoneyGiven);
            Controls.Add(pnlDisplayBackground);
            Controls.Add(lblMoneyGiven);
            Controls.Add(lblPrice);
            Controls.Add(lblCurrency);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(tbPrice);
            Controls.Add(cbCurrency);
            Controls.Add(Title);
            Controls.Add(lblDescription);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CalculateChange";
            Text = "CalculateChange";
            pnlDisplayBackground.ResumeLayout(false);
            pnlDisplayBackground.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDescription;
        private Label Title;
        private ComboBox cbCurrency;
        private TextBox tbPrice;
        private TextBox tbMoneyGiven;
        private Button btnClear;
        private Button btnQuit;
        private Label lblCurrency;
        private Label lblPrice;
        private Label lblMoneyGiven;
        private Panel pnlDisplayBackground;
        private Button btnCalculate;
        private Label lblDisplayInfo;
        private Label lblDisplayInput;
        private Button btnCopy;
    }
}
