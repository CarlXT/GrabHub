namespace GrabHub
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            banana1 = new GrabHub.Products.Banana();
            apple1 = new GrabHub.Products.Picproducts.Apple();
            eggplant1 = new GrabHub.Products.Eggplant();
            horseradish1 = new GrabHub.Products.Horseradish();
            orange1 = new GrabHub.Products.Orange();
            label1 = new Label();
            chkBoxApple = new CheckBox();
            chkBoxBanana = new CheckBox();
            chkBoxEggplant = new CheckBox();
            chkBoxHorseradish = new CheckBox();
            chkBoxOrange = new CheckBox();
            txtBoxQuantity = new TextBox();
            returnBtn = new Button();
            mainbtn = new Button();
            SuspendLayout();
            // 
            // banana1
            // 
            banana1.BackColor = Color.RosyBrown;
            banana1.Location = new Point(-2, 177);
            banana1.Name = "banana1";
            banana1.Size = new Size(230, 256);
            banana1.TabIndex = 0;
            // 
            // apple1
            // 
            apple1.BackColor = Color.RosyBrown;
            apple1.Location = new Point(234, 170);
            apple1.Name = "apple1";
            apple1.Size = new Size(238, 263);
            apple1.TabIndex = 1;
            // 
            // eggplant1
            // 
            eggplant1.BackColor = Color.RosyBrown;
            eggplant1.Location = new Point(478, 170);
            eggplant1.Name = "eggplant1";
            eggplant1.Size = new Size(238, 263);
            eggplant1.TabIndex = 2;
            // 
            // horseradish1
            // 
            horseradish1.BackColor = Color.RosyBrown;
            horseradish1.Location = new Point(722, 170);
            horseradish1.Name = "horseradish1";
            horseradish1.Size = new Size(238, 263);
            horseradish1.TabIndex = 3;
            // 
            // orange1
            // 
            orange1.BackColor = Color.RosyBrown;
            orange1.Location = new Point(999, 170);
            orange1.Name = "orange1";
            orange1.Size = new Size(238, 263);
            orange1.TabIndex = 4;
            orange1.Load += orange1_Load;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 46F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(434, 9);
            label1.Name = "label1";
            label1.Size = new Size(395, 84);
            label1.TabIndex = 5;
            label1.Text = "Supermarket";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // chkBoxApple
            // 
            chkBoxApple.AutoSize = true;
            chkBoxApple.Location = new Point(313, 439);
            chkBoxApple.Name = "chkBoxApple";
            chkBoxApple.Size = new Size(89, 21);
            chkBoxApple.TabIndex = 6;
            chkBoxApple.Text = "Add Apple";
            chkBoxApple.UseVisualStyleBackColor = true;
            // 
            // chkBoxBanana
            // 
            chkBoxBanana.AutoSize = true;
            chkBoxBanana.Location = new Point(74, 439);
            chkBoxBanana.Name = "chkBoxBanana";
            chkBoxBanana.Size = new Size(97, 21);
            chkBoxBanana.TabIndex = 7;
            chkBoxBanana.Text = "Add Banana";
            chkBoxBanana.UseVisualStyleBackColor = true;
            // 
            // chkBoxEggplant
            // 
            chkBoxEggplant.AutoSize = true;
            chkBoxEggplant.Location = new Point(562, 439);
            chkBoxEggplant.Name = "chkBoxEggplant";
            chkBoxEggplant.Size = new Size(107, 21);
            chkBoxEggplant.TabIndex = 8;
            chkBoxEggplant.Text = "Add Eggplant";
            chkBoxEggplant.UseVisualStyleBackColor = true;
            // 
            // chkBoxHorseradish
            // 
            chkBoxHorseradish.AutoSize = true;
            chkBoxHorseradish.Location = new Point(802, 439);
            chkBoxHorseradish.Name = "chkBoxHorseradish";
            chkBoxHorseradish.Size = new Size(126, 21);
            chkBoxHorseradish.TabIndex = 9;
            chkBoxHorseradish.Text = "Add Horseradish";
            chkBoxHorseradish.UseVisualStyleBackColor = true;
            // 
            // chkBoxOrange
            // 
            chkBoxOrange.AutoSize = true;
            chkBoxOrange.Location = new Point(1079, 439);
            chkBoxOrange.Name = "chkBoxOrange";
            chkBoxOrange.Size = new Size(99, 21);
            chkBoxOrange.TabIndex = 10;
            chkBoxOrange.Text = "Add Orange";
            chkBoxOrange.UseVisualStyleBackColor = true;
            // 
            // txtBoxQuantity
            // 
            txtBoxQuantity.ForeColor = Color.Black;
            txtBoxQuantity.Location = new Point(478, 553);
            txtBoxQuantity.Name = "txtBoxQuantity";
            txtBoxQuantity.Size = new Size(271, 25);
            txtBoxQuantity.TabIndex = 11;
            txtBoxQuantity.Text = "Quantity";
            txtBoxQuantity.TextAlign = HorizontalAlignment.Center;
            txtBoxQuantity.Click += txtBoxQuantity_Click;
            txtBoxQuantity.TextChanged += txtBoxQuantity_TextChanged;
            txtBoxQuantity.KeyPress += txtBoxQuantity_KeyPress;
            txtBoxQuantity.Leave += txtBoxQuantity_Leave;
            // 
            // returnBtn
            // 
            returnBtn.Image = (Image)resources.GetObject("returnBtn.Image");
            returnBtn.Location = new Point(449, 609);
            returnBtn.Name = "returnBtn";
            returnBtn.Size = new Size(42, 35);
            returnBtn.TabIndex = 12;
            returnBtn.UseVisualStyleBackColor = true;
            returnBtn.Click += returnBtn_Click;
            // 
            // mainbtn
            // 
            mainbtn.ForeColor = Color.RosyBrown;
            mainbtn.Location = new Point(524, 609);
            mainbtn.Name = "mainbtn";
            mainbtn.Size = new Size(192, 34);
            mainbtn.TabIndex = 14;
            mainbtn.Text = "Add Product";
            mainbtn.UseVisualStyleBackColor = true;
            mainbtn.Click += mainbtn_Click;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1249, 776);
            Controls.Add(mainbtn);
            Controls.Add(returnBtn);
            Controls.Add(txtBoxQuantity);
            Controls.Add(chkBoxOrange);
            Controls.Add(chkBoxHorseradish);
            Controls.Add(chkBoxEggplant);
            Controls.Add(chkBoxBanana);
            Controls.Add(chkBoxApple);
            Controls.Add(label1);
            Controls.Add(orange1);
            Controls.Add(horseradish1);
            Controls.Add(eggplant1);
            Controls.Add(apple1);
            Controls.Add(banana1);
            Name = "AddProduct";
            Text = "AddProduct";
            Load += AddProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Products.Banana banana1;
        private Products.Picproducts.Apple apple1;
        private Products.Eggplant eggplant1;
        private Products.Horseradish horseradish1;
        private Products.Orange orange1;
        private Label label1;
        private CheckBox chkBoxApple;
        private CheckBox chkBoxBanana;
        private CheckBox chkBoxEggplant;
        private CheckBox chkBoxHorseradish;
        private CheckBox chkBoxOrange;
        private TextBox txtBoxQuantity;
        private Button returnBtn;
        private Button mainbtn;
    }
}