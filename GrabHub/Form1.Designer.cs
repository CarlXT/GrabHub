namespace GrabHub
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
            mainPanel = new Panel();
            mainbtn = new Button();
            welcomeMessage = new Label();
            welcomeGreat = new Label();
            actionPanel = new Panel();
            returnBtn = new Button();
            label3 = new Label();
            viewLbl = new Label();
            removeLbl = new Label();
            checkOutBtn = new Button();
            viewBtn = new Button();
            removeBtn = new Button();
            addCartLbl = new Label();
            addBtn = new Button();
            panel1 = new Panel();
            returnBtnAddPnl = new Button();
            mainPanel.SuspendLayout();
            actionPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(mainbtn);
            mainPanel.Controls.Add(welcomeMessage);
            mainPanel.Controls.Add(welcomeGreat);
            mainPanel.Location = new Point(182, 50);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(478, 280);
            mainPanel.TabIndex = 0;
            mainPanel.Paint += mainPanel_Paint;
            // 
            // mainbtn
            // 
            mainbtn.ForeColor = Color.RosyBrown;
            mainbtn.Location = new Point(86, 215);
            mainbtn.Name = "mainbtn";
            mainbtn.Size = new Size(325, 34);
            mainbtn.TabIndex = 2;
            mainbtn.Text = "Grab Now!\r\n";
            mainbtn.UseVisualStyleBackColor = true;
            mainbtn.Click += mainbtn_Click;
            // 
            // welcomeMessage
            // 
            welcomeMessage.AutoSize = true;
            welcomeMessage.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcomeMessage.ForeColor = SystemColors.Control;
            welcomeMessage.Location = new Point(47, 104);
            welcomeMessage.Name = "welcomeMessage";
            welcomeMessage.Size = new Size(390, 51);
            welcomeMessage.TabIndex = 1;
            welcomeMessage.Text = " Welcome to Grab Hub! We're so excited to serve you with quick, \r\n                       convenient, and delightful experiences. \r\n               Your satisfaction is our passion—enjoy the ride! ";
            welcomeMessage.Click += welcomeMessage_Click;
            // 
            // welcomeGreat
            // 
            welcomeGreat.AutoSize = true;
            welcomeGreat.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeGreat.ForeColor = SystemColors.Control;
            welcomeGreat.Location = new Point(30, 34);
            welcomeGreat.Name = "welcomeGreat";
            welcomeGreat.Size = new Size(430, 50);
            welcomeGreat.TabIndex = 0;
            welcomeGreat.Text = "Welcome  to Grab Hub!";
            // 
            // actionPanel
            // 
            actionPanel.Controls.Add(returnBtn);
            actionPanel.Controls.Add(label3);
            actionPanel.Controls.Add(viewLbl);
            actionPanel.Controls.Add(removeLbl);
            actionPanel.Controls.Add(checkOutBtn);
            actionPanel.Controls.Add(viewBtn);
            actionPanel.Controls.Add(removeBtn);
            actionPanel.Controls.Add(addCartLbl);
            actionPanel.Controls.Add(addBtn);
            actionPanel.Location = new Point(146, 12);
            actionPanel.Name = "actionPanel";
            actionPanel.Size = new Size(514, 341);
            actionPanel.TabIndex = 1;
            actionPanel.Visible = false;
            // 
            // returnBtn
            // 
            returnBtn.Image = (Image)resources.GetObject("returnBtn.Image");
            returnBtn.Location = new Point(441, 294);
            returnBtn.Name = "returnBtn";
            returnBtn.Size = new Size(42, 35);
            returnBtn.TabIndex = 8;
            returnBtn.UseVisualStyleBackColor = true;
            returnBtn.Click += returnBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(402, 196);
            label3.Name = "label3";
            label3.Size = new Size(71, 17);
            label3.TabIndex = 7;
            label3.Text = "Check Out";
            // 
            // viewLbl
            // 
            viewLbl.AutoSize = true;
            viewLbl.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewLbl.ForeColor = SystemColors.Control;
            viewLbl.Location = new Point(299, 196);
            viewLbl.Name = "viewLbl";
            viewLbl.Size = new Size(36, 17);
            viewLbl.TabIndex = 6;
            viewLbl.Text = "View";
            // 
            // removeLbl
            // 
            removeLbl.AutoSize = true;
            removeLbl.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeLbl.ForeColor = SystemColors.Control;
            removeLbl.Location = new Point(174, 196);
            removeLbl.Name = "removeLbl";
            removeLbl.Size = new Size(57, 17);
            removeLbl.TabIndex = 5;
            removeLbl.Text = "Remove";
            // 
            // checkOutBtn
            // 
            checkOutBtn.Image = (Image)resources.GetObject("checkOutBtn.Image");
            checkOutBtn.Location = new Point(383, 87);
            checkOutBtn.Name = "checkOutBtn";
            checkOutBtn.Size = new Size(100, 106);
            checkOutBtn.TabIndex = 4;
            checkOutBtn.UseVisualStyleBackColor = true;
            // 
            // viewBtn
            // 
            viewBtn.Image = (Image)resources.GetObject("viewBtn.Image");
            viewBtn.Location = new Point(267, 87);
            viewBtn.Name = "viewBtn";
            viewBtn.Size = new Size(100, 106);
            viewBtn.TabIndex = 3;
            viewBtn.UseVisualStyleBackColor = true;
            // 
            // removeBtn
            // 
            removeBtn.Image = (Image)resources.GetObject("removeBtn.Image");
            removeBtn.Location = new Point(151, 87);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(100, 106);
            removeBtn.TabIndex = 2;
            removeBtn.UseVisualStyleBackColor = true;
            // 
            // addCartLbl
            // 
            addCartLbl.AutoSize = true;
            addCartLbl.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addCartLbl.ForeColor = SystemColors.Control;
            addCartLbl.Location = new Point(70, 196);
            addCartLbl.Name = "addCartLbl";
            addCartLbl.Size = new Size(37, 17);
            addCartLbl.TabIndex = 1;
            addCartLbl.Text = "Add ";
            // 
            // addBtn
            // 
            addBtn.Image = (Image)resources.GetObject("addBtn.Image");
            addBtn.Location = new Point(36, 87);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(100, 106);
            addBtn.TabIndex = 0;
            addBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(returnBtnAddPnl);
            panel1.Location = new Point(73, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(647, 343);
            panel1.TabIndex = 2;
            // 
            // returnBtnAddPnl
            // 
            returnBtnAddPnl.Image = (Image)resources.GetObject("returnBtnAddPnl.Image");
            returnBtnAddPnl.Location = new Point(574, 296);
            returnBtnAddPnl.Name = "returnBtnAddPnl";
            returnBtnAddPnl.Size = new Size(42, 35);
            returnBtnAddPnl.TabIndex = 9;
            returnBtnAddPnl.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(799, 374);
            Controls.Add(panel1);
            Controls.Add(actionPanel);
            Controls.Add(mainPanel);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Form1";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            actionPanel.ResumeLayout(false);
            actionPanel.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Label welcomeGreat;
        private Label welcomeMessage;
        private Button mainbtn;
        private Panel actionPanel;
        private Label label3;
        private Label viewLbl;
        private Label removeLbl;
        private Button checkOutBtn;
        private Button viewBtn;
        private Button removeBtn;
        private Label addCartLbl;
        private Button addBtn;
        private Button returnBtn;
        private Panel panel1;
        private Button returnBtnAddPnl;
    }
}
