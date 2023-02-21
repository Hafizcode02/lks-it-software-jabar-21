namespace SMKRestaurant
{
    partial class CashierNavigation
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnToPayment = new System.Windows.Forms.Button();
            this.labelCashier = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(90, 132);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(148, 34);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnToPayment
            // 
            this.btnToPayment.Location = new System.Drawing.Point(90, 92);
            this.btnToPayment.Name = "btnToPayment";
            this.btnToPayment.Size = new System.Drawing.Size(148, 34);
            this.btnToPayment.TabIndex = 11;
            this.btnToPayment.Text = "Payment";
            this.btnToPayment.UseVisualStyleBackColor = true;
            this.btnToPayment.Click += new System.EventHandler(this.btnToPayment_Click);
            // 
            // labelCashier
            // 
            this.labelCashier.AutoSize = true;
            this.labelCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCashier.Location = new System.Drawing.Point(87, 56);
            this.labelCashier.Name = "labelCashier";
            this.labelCashier.Size = new System.Drawing.Size(108, 16);
            this.labelCashier.TabIndex = 10;
            this.labelCashier.Text = "[ Cashier Name ]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Welcome, ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cashier Navigation";
            // 
            // CashierNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 202);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnToPayment);
            this.Controls.Add(this.labelCashier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CashierNavigation";
            this.Text = "Cashier Navigation Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnToPayment;
        private System.Windows.Forms.Label labelCashier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}