namespace SMKRestaurant
{
    partial class OrderForm
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
            this.dgMenuList = new System.Windows.Forms.DataGridView();
            this.dgOrderList = new System.Windows.Forms.DataGridView();
            this.pictureMenu = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMenuName = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCarbo = new System.Windows.Forms.Label();
            this.labelProtein = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgMenuList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Form Manage Menu";
            // 
            // dgMenuList
            // 
            this.dgMenuList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMenuList.Location = new System.Drawing.Point(12, 61);
            this.dgMenuList.Name = "dgMenuList";
            this.dgMenuList.Size = new System.Drawing.Size(429, 116);
            this.dgMenuList.TabIndex = 2;
            this.dgMenuList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMenuList_CellClick);
            // 
            // dgOrderList
            // 
            this.dgOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgOrderList.Location = new System.Drawing.Point(12, 320);
            this.dgOrderList.Name = "dgOrderList";
            this.dgOrderList.Size = new System.Drawing.Size(429, 116);
            this.dgOrderList.TabIndex = 3;
            // 
            // pictureMenu
            // 
            this.pictureMenu.Location = new System.Drawing.Point(67, 196);
            this.pictureMenu.Name = "pictureMenu";
            this.pictureMenu.Size = new System.Drawing.Size(144, 106);
            this.pictureMenu.TabIndex = 4;
            this.pictureMenu.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Menu Name";
            // 
            // txtMenuName
            // 
            this.txtMenuName.Enabled = false;
            this.txtMenuName.Location = new System.Drawing.Point(313, 207);
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.Size = new System.Drawing.Size(100, 20);
            this.txtMenuName.TabIndex = 6;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(313, 244);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 20);
            this.txtQty.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Qty";
            // 
            // labelCarbo
            // 
            this.labelCarbo.AutoSize = true;
            this.labelCarbo.Location = new System.Drawing.Point(12, 472);
            this.labelCarbo.Name = "labelCarbo";
            this.labelCarbo.Size = new System.Drawing.Size(50, 13);
            this.labelCarbo.TabIndex = 9;
            this.labelCarbo.Text = "Carbo : 0";
            // 
            // labelProtein
            // 
            this.labelProtein.AutoSize = true;
            this.labelProtein.Location = new System.Drawing.Point(115, 472);
            this.labelProtein.Name = "labelProtein";
            this.labelProtein.Size = new System.Drawing.Size(55, 13);
            this.labelProtein.TabIndex = 10;
            this.labelProtein.Text = "Protein : 0";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(233, 467);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 11;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(359, 471);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(46, 13);
            this.labelTotal.TabIndex = 12;
            this.labelTotal.Text = "Total : 0";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(249, 279);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(330, 279);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "MenuID";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Menu";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Qty";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Carbo";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Protein";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Price";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Total";
            this.Column7.Name = "Column7";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 494);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.labelProtein);
            this.Controls.Add(this.labelCarbo);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMenuName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureMenu);
            this.Controls.Add(this.dgOrderList);
            this.Controls.Add(this.dgMenuList);
            this.Controls.Add(this.label1);
            this.Name = "OrderForm";
            this.Text = "Manage Order";
            ((System.ComponentModel.ISupportInitialize)(this.dgMenuList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgMenuList;
        private System.Windows.Forms.DataGridView dgOrderList;
        private System.Windows.Forms.PictureBox pictureMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMenuName;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCarbo;
        private System.Windows.Forms.Label labelProtein;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}