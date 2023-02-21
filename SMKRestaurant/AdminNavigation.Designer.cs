namespace SMKRestaurant
{
    partial class AdminNavigation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.btnToOrderForm = new System.Windows.Forms.Button();
            this.btnToManageMenu = new System.Windows.Forms.Button();
            this.btnToManageMember = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnManageReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin Navigation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome, ";
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.Location = new System.Drawing.Point(94, 62);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(100, 16);
            this.labelAdmin.TabIndex = 3;
            this.labelAdmin.Text = "[ Admin Name ]";
            // 
            // btnToOrderForm
            // 
            this.btnToOrderForm.Location = new System.Drawing.Point(97, 98);
            this.btnToOrderForm.Name = "btnToOrderForm";
            this.btnToOrderForm.Size = new System.Drawing.Size(148, 34);
            this.btnToOrderForm.TabIndex = 4;
            this.btnToOrderForm.Text = "Order";
            this.btnToOrderForm.UseVisualStyleBackColor = true;
            this.btnToOrderForm.Click += new System.EventHandler(this.btnToOrderForm_Click);
            // 
            // btnToManageMenu
            // 
            this.btnToManageMenu.Location = new System.Drawing.Point(97, 138);
            this.btnToManageMenu.Name = "btnToManageMenu";
            this.btnToManageMenu.Size = new System.Drawing.Size(148, 34);
            this.btnToManageMenu.TabIndex = 5;
            this.btnToManageMenu.Text = "Manage Menu";
            this.btnToManageMenu.UseVisualStyleBackColor = true;
            this.btnToManageMenu.Click += new System.EventHandler(this.btnToManageMenu_Click);
            // 
            // btnToManageMember
            // 
            this.btnToManageMember.Location = new System.Drawing.Point(97, 178);
            this.btnToManageMember.Name = "btnToManageMember";
            this.btnToManageMember.Size = new System.Drawing.Size(148, 34);
            this.btnToManageMember.TabIndex = 6;
            this.btnToManageMember.Text = "Manage Member";
            this.btnToManageMember.UseVisualStyleBackColor = true;
            this.btnToManageMember.Click += new System.EventHandler(this.btnToManageMember_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(97, 258);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(148, 34);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnManageReport
            // 
            this.btnManageReport.Location = new System.Drawing.Point(97, 218);
            this.btnManageReport.Name = "btnManageReport";
            this.btnManageReport.Size = new System.Drawing.Size(148, 34);
            this.btnManageReport.TabIndex = 8;
            this.btnManageReport.Text = "Manage Report";
            this.btnManageReport.UseVisualStyleBackColor = true;
            this.btnManageReport.Click += new System.EventHandler(this.btnManageReport_Click);
            // 
            // AdminNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 348);
            this.Controls.Add(this.btnManageReport);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnToManageMember);
            this.Controls.Add(this.btnToManageMenu);
            this.Controls.Add(this.btnToOrderForm);
            this.Controls.Add(this.labelAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminNavigation";
            this.Text = "Admin Navigation Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Button btnToOrderForm;
        private System.Windows.Forms.Button btnToManageMenu;
        private System.Windows.Forms.Button btnToManageMember;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnManageReport;
    }
}