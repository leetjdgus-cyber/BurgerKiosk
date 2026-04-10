namespace BurgerKiosk
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblAppName = new Label();
            rdoHamBurger = new RadioButton();
            rdoChickenBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            chkFries = new CheckBox();
            chkCoke = new CheckBox();
            chkCheese = new CheckBox();
            chkSauce = new CheckBox();
            grpMenu = new GroupBox();
            grpOption = new GroupBox();
            grpOrder = new GroupBox();
            lblTotalCost = new Label();
            lstOrder = new ListBox();
            btnOrder = new Button();
            btnReset = new Button();
            lblError = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            grpMenu.SuspendLayout();
            grpOption.SuspendLayout();
            grpOrder.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = Color.IndianRed;
            lblAppName.Location = new Point(390, 9);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(344, 50);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "버거 주문 키오스크";
            lblAppName.Click += label1_Click;
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            rdoHamBurger.ForeColor = Color.Black;
            rdoHamBurger.Location = new Point(19, 71);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(116, 41);
            rdoHamBurger.TabIndex = 1;
            rdoHamBurger.TabStop = true;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = true;
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            rdoChickenBurger.ForeColor = Color.Black;
            rdoChickenBurger.Location = new Point(19, 357);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(143, 41);
            rdoChickenBurger.TabIndex = 2;
            rdoChickenBurger.TabStop = true;
            rdoChickenBurger.Text = "치킨버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            rdoBulgogiBurger.ForeColor = Color.Black;
            rdoBulgogiBurger.Location = new Point(9, 219);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(170, 41);
            rdoBulgogiBurger.TabIndex = 3;
            rdoBulgogiBurger.TabStop = true;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            rdoBulgogiBurger.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(211, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(211, 179);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(161, 122);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(211, 316);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(161, 121);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // chkFries
            // 
            chkFries.AutoSize = true;
            chkFries.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkFries.ForeColor = Color.Black;
            chkFries.Location = new Point(18, 39);
            chkFries.Name = "chkFries";
            chkFries.Size = new Size(129, 36);
            chkFries.TabIndex = 7;
            chkFries.Text = "감자튀김";
            chkFries.UseVisualStyleBackColor = true;
            // 
            // chkCoke
            // 
            chkCoke.AutoSize = true;
            chkCoke.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkCoke.ForeColor = Color.Black;
            chkCoke.Location = new Point(18, 101);
            chkCoke.Name = "chkCoke";
            chkCoke.Size = new Size(81, 36);
            chkCoke.TabIndex = 9;
            chkCoke.Text = "콜라";
            chkCoke.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkCheese.ForeColor = Color.Black;
            chkCheese.Location = new Point(18, 163);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(137, 36);
            chkCheese.TabIndex = 10;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkSauce.ForeColor = Color.Black;
            chkSauce.Location = new Point(18, 224);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(137, 36);
            chkSauce.TabIndex = 11;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(pictureBox2);
            grpMenu.Controls.Add(rdoHamBurger);
            grpMenu.Controls.Add(rdoChickenBurger);
            grpMenu.Controls.Add(rdoBulgogiBurger);
            grpMenu.Controls.Add(pictureBox1);
            grpMenu.Controls.Add(pictureBox3);
            grpMenu.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpMenu.ForeColor = Color.IndianRed;
            grpMenu.Location = new Point(92, 90);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(400, 455);
            grpMenu.TabIndex = 12;
            grpMenu.TabStop = false;
            grpMenu.Text = "메뉴 선택";
            // 
            // grpOption
            // 
            grpOption.Controls.Add(chkFries);
            grpOption.Controls.Add(chkCoke);
            grpOption.Controls.Add(chkSauce);
            grpOption.Controls.Add(chkCheese);
            grpOption.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpOption.ForeColor = Color.Blue;
            grpOption.Location = new Point(498, 90);
            grpOption.Name = "grpOption";
            grpOption.Size = new Size(278, 455);
            grpOption.TabIndex = 13;
            grpOption.TabStop = false;
            grpOption.Text = "추가 옵션";
            // 
            // grpOrder
            // 
            grpOrder.Controls.Add(lblTotalCost);
            grpOrder.Controls.Add(lstOrder);
            grpOrder.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpOrder.ForeColor = Color.IndianRed;
            grpOrder.Location = new Point(782, 90);
            grpOrder.Name = "grpOrder";
            grpOrder.Size = new Size(278, 311);
            grpOrder.TabIndex = 14;
            grpOrder.TabStop = false;
            grpOrder.Text = "주문 내역";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.ForeColor = Color.Blue;
            lblTotalCost.Location = new Point(21, 271);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(135, 30);
            lblTotalCost.TabIndex = 1;
            lblTotalCost.Text = "총 금액 : 0원";
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(21, 46);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(233, 214);
            lstOrder.TabIndex = 0;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = SystemColors.ActiveCaption;
            btnOrder.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnOrder.ForeColor = Color.Black;
            btnOrder.Location = new Point(803, 447);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(106, 46);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.IndianRed;
            btnReset.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnReset.ForeColor = Color.Black;
            btnReset.Location = new Point(930, 447);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(106, 46);
            btnReset.TabIndex = 3;
            btnReset.Text = "초기화";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(803, 423);
            lblError.Name = "lblError";
            lblError.Size = new Size(144, 21);
            lblError.TabIndex = 15;
            lblError.Text = "메뉴를 선택하세요";
            lblError.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 583);
            Controls.Add(lblError);
            Controls.Add(btnReset);
            Controls.Add(grpOrder);
            Controls.Add(btnOrder);
            Controls.Add(grpOption);
            Controls.Add(grpMenu);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Burger Kiosk v1.0";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            grpOption.ResumeLayout(false);
            grpOption.PerformLayout();
            grpOrder.ResumeLayout(false);
            grpOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private RadioButton rdoHamBurger;
        private RadioButton rdoChickenBurger;
        private RadioButton rdoBulgogiBurger;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private CheckBox chkFries;
        private CheckBox chkCoke;
        private CheckBox chkCheese;
        private CheckBox chkSauce;
        private GroupBox grpMenu;
        private GroupBox grpOption;
        private GroupBox grpOrder;
        private Label lblTotalCost;
        private ListBox lstOrder;
        private Button btnOrder;
        private Button btnReset;
        private Label lblError;
    }
}
