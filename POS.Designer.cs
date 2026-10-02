namespace Mini_Mart_Pos
{
    partial class POS
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.flpProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSoda = new System.Windows.Forms.Button();
            this.btnCoca = new System.Windows.Forms.Button();
            this.btnMilk = new System.Windows.Forms.Button();
            this.btnEggs = new System.Windows.Forms.Button();
            this.btnCookie = new System.Windows.Forms.Button();
            this.btnMeat = new System.Windows.Forms.Button();
            this.btnFastFood = new System.Windows.Forms.Button();
            this.btnBento = new System.Windows.Forms.Button();
            this.btnSkincare = new System.Windows.Forms.Button();
            this.btnVegetables = new System.Windows.Forms.Button();
            this.btnSnacks = new System.Windows.Forms.Button();
            this.pnlCart = new System.Windows.Forms.Panel();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnVoidSale = new System.Windows.Forms.Button();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCompleteSale = new System.Windows.Forms.Button();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.btnPos = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblCashierHeader = new System.Windows.Forms.Label();
            this.cmbCashier = new System.Windows.Forms.ComboBox();
            this.btnEndShift = new System.Windows.Forms.Button();
            this.flpProducts.SuspendLayout();
            this.pnlCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.pnlSummary.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(20, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 30);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Main product search...";
         
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(221)))));
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(250, 19);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(130, 32);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "Product Add/ List";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // flpProducts
            // 
            this.flpProducts.Controls.Add(this.btnSoda);
            this.flpProducts.Controls.Add(this.btnCoca);
            this.flpProducts.Controls.Add(this.btnMilk);
            this.flpProducts.Controls.Add(this.btnEggs);
            this.flpProducts.Controls.Add(this.btnCookie);
            this.flpProducts.Controls.Add(this.btnMeat);
            this.flpProducts.Controls.Add(this.btnFastFood);
            this.flpProducts.Controls.Add(this.btnBento);
            this.flpProducts.Controls.Add(this.btnSkincare);
            this.flpProducts.Controls.Add(this.btnVegetables);
            this.flpProducts.Controls.Add(this.btnSnacks);
            this.flpProducts.Location = new System.Drawing.Point(12, 100);
            this.flpProducts.Name = "flpProducts";
            this.flpProducts.Size = new System.Drawing.Size(420, 420);
            this.flpProducts.TabIndex = 2;
            // 
            // btnSoda
            // 
            this.btnSoda.BackColor = System.Drawing.Color.White;
            this.btnSoda.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnSoda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSoda.Location = new System.Drawing.Point(3, 3);
            this.btnSoda.Name = "btnSoda";
            this.btnSoda.Size = new System.Drawing.Size(98, 98);
            this.btnSoda.TabIndex = 0;
            this.btnSoda.Text = "Soda";
            this.btnSoda.UseVisualStyleBackColor = false;
            // 
            // btnCoca
            // 
            this.btnCoca.BackColor = System.Drawing.Color.White;
            this.btnCoca.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnCoca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCoca.Location = new System.Drawing.Point(107, 3);
            this.btnCoca.Name = "btnCoca";
            this.btnCoca.Size = new System.Drawing.Size(98, 98);
            this.btnCoca.TabIndex = 1;
            this.btnCoca.Text = "Coca Cola";
            this.btnCoca.UseVisualStyleBackColor = false;
            // 
            // btnMilk
            // 
            this.btnMilk.BackColor = System.Drawing.Color.White;
            this.btnMilk.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnMilk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMilk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMilk.Location = new System.Drawing.Point(211, 3);
            this.btnMilk.Name = "btnMilk";
            this.btnMilk.Size = new System.Drawing.Size(98, 98);
            this.btnMilk.TabIndex = 2;
            this.btnMilk.Text = "Milk";
            this.btnMilk.UseVisualStyleBackColor = false;
            // 
            // btnEggs
            // 
            this.btnEggs.BackColor = System.Drawing.Color.White;
            this.btnEggs.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnEggs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEggs.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEggs.Location = new System.Drawing.Point(315, 3);
            this.btnEggs.Name = "btnEggs";
            this.btnEggs.Size = new System.Drawing.Size(98, 98);
            this.btnEggs.TabIndex = 3;
            this.btnEggs.Text = "Eggs";
            this.btnEggs.UseVisualStyleBackColor = false;
            // 
            // btnCookie
            // 
            this.btnCookie.BackColor = System.Drawing.Color.White;
            this.btnCookie.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnCookie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCookie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCookie.Location = new System.Drawing.Point(3, 107);
            this.btnCookie.Name = "btnCookie";
            this.btnCookie.Size = new System.Drawing.Size(98, 98);
            this.btnCookie.TabIndex = 4;
            this.btnCookie.Text = "Cookie";
            this.btnCookie.UseVisualStyleBackColor = false;
            // 
            // btnMeat
            // 
            this.btnMeat.BackColor = System.Drawing.Color.White;
            this.btnMeat.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnMeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMeat.Location = new System.Drawing.Point(107, 107);
            this.btnMeat.Name = "btnMeat";
            this.btnMeat.Size = new System.Drawing.Size(98, 98);
            this.btnMeat.TabIndex = 5;
            this.btnMeat.Text = "Meat";
            this.btnMeat.UseVisualStyleBackColor = false;
            // 
            // btnFastFood
            // 
            this.btnFastFood.BackColor = System.Drawing.Color.White;
            this.btnFastFood.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnFastFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFastFood.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFastFood.Location = new System.Drawing.Point(211, 107);
            this.btnFastFood.Name = "btnFastFood";
            this.btnFastFood.Size = new System.Drawing.Size(98, 98);
            this.btnFastFood.TabIndex = 6;
            this.btnFastFood.Text = "Fast Food";
            this.btnFastFood.UseVisualStyleBackColor = false;
            // 
            // btnBento
            // 
            this.btnBento.BackColor = System.Drawing.Color.White;
            this.btnBento.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnBento.FlatAppearance.BorderSize = 2;
            this.btnBento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBento.Location = new System.Drawing.Point(315, 107);
            this.btnBento.Name = "btnBento";
            this.btnBento.Size = new System.Drawing.Size(98, 98);
            this.btnBento.TabIndex = 7;
            this.btnBento.Text = "Bento Box";
            this.btnBento.UseVisualStyleBackColor = false;
            // 
            // btnSkincare
            // 
            this.btnSkincare.BackColor = System.Drawing.Color.White;
            this.btnSkincare.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnSkincare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkincare.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSkincare.Location = new System.Drawing.Point(3, 211);
            this.btnSkincare.Name = "btnSkincare";
            this.btnSkincare.Size = new System.Drawing.Size(98, 98);
            this.btnSkincare.TabIndex = 8;
            this.btnSkincare.Text = "Skincare";
            this.btnSkincare.UseVisualStyleBackColor = false;
            // 
            // btnVegetables
            // 
            this.btnVegetables.BackColor = System.Drawing.Color.White;
            this.btnVegetables.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnVegetables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVegetables.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVegetables.Location = new System.Drawing.Point(107, 211);
            this.btnVegetables.Name = "btnVegetables";
            this.btnVegetables.Size = new System.Drawing.Size(98, 98);
            this.btnVegetables.TabIndex = 9;
            this.btnVegetables.Text = "Vegetables";
            this.btnVegetables.UseVisualStyleBackColor = false;
            // 
            // btnSnacks
            // 
            this.btnSnacks.BackColor = System.Drawing.Color.White;
            this.btnSnacks.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSnacks.FlatAppearance.BorderSize = 2;
            this.btnSnacks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnacks.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSnacks.Location = new System.Drawing.Point(211, 211);
            this.btnSnacks.Name = "btnSnacks";
            this.btnSnacks.Size = new System.Drawing.Size(98, 98);
            this.btnSnacks.TabIndex = 10;
            this.btnSnacks.Text = "Snacks";
            this.btnSnacks.UseVisualStyleBackColor = false;
            // 
            // pnlCart
            // 
            this.pnlCart.BackColor = System.Drawing.Color.White;
            this.pnlCart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCart.Controls.Add(this.dgvCart);
            this.pnlCart.Controls.Add(this.btnVoidSale);
            this.pnlCart.Controls.Add(this.btnClearAll);
            this.pnlCart.Location = new System.Drawing.Point(460, 171);
            this.pnlCart.Name = "pnlCart";
            this.pnlCart.Size = new System.Drawing.Size(350, 210);
            this.pnlCart.TabIndex = 3;
            // 
            // dgvCart
            // 
            this.dgvCart.BackgroundColor = System.Drawing.Color.White;
            this.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(10, 14);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 25;
            this.dgvCart.Size = new System.Drawing.Size(328, 140);
            this.dgvCart.TabIndex = 0;
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(221)))));
            this.btnClearAll.FlatAppearance.BorderSize = 0;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClearAll.ForeColor = System.Drawing.Color.White;
            this.btnClearAll.Location = new System.Drawing.Point(19, 170);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(117, 35);
            this.btnClearAll.TabIndex = 1;
            this.btnClearAll.Text = "CLEAR ALL";
            this.btnClearAll.UseVisualStyleBackColor = false;
            // 
            // btnVoidSale
            // 
            this.btnVoidSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(221)))));
            this.btnVoidSale.FlatAppearance.BorderSize = 0;
            this.btnVoidSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoidSale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnVoidSale.ForeColor = System.Drawing.Color.White;
            this.btnVoidSale.Location = new System.Drawing.Point(196, 170);
            this.btnVoidSale.Name = "btnVoidSale";
            this.btnVoidSale.Size = new System.Drawing.Size(132, 35);
            this.btnVoidSale.TabIndex = 2;
            this.btnVoidSale.Text = "VOID SALE";
            this.btnVoidSale.UseVisualStyleBackColor = false;
            // 
            // pnlSummary
            // 
            this.pnlSummary.BackColor = System.Drawing.Color.White;
            this.pnlSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummary.Controls.Add(this.lblTitle);
            this.pnlSummary.Controls.Add(this.lblSubtotal);
            this.pnlSummary.Controls.Add(this.lblTax);
            this.pnlSummary.Controls.Add(this.lblTotal);
            this.pnlSummary.Controls.Add(this.btnCompleteSale);
            this.pnlSummary.Location = new System.Drawing.Point(460, 396);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(350, 200);
            this.pnlSummary.TabIndex = 4;
            this.pnlSummary.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSummary_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(15, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(141, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Cart Summary";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtotal.Location = new System.Drawing.Point(15, 45);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(118, 21);
            this.lblSubtotal.TabIndex = 1;
            this.lblSubtotal.Text = "Subtotal: $ 0.00";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTax.Location = new System.Drawing.Point(15, 70);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(81, 21);
            this.lblTax.TabIndex = 2;
            this.lblTax.Text = "Tax: $ 0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(15, 100);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(121, 23);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "TOTAL: $ 0.00";
            // 
            // btnCompleteSale
            // 
            this.btnCompleteSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(221)))));
            this.btnCompleteSale.FlatAppearance.BorderSize = 0;
            this.btnCompleteSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleteSale.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCompleteSale.ForeColor = System.Drawing.Color.White;
            this.btnCompleteSale.Location = new System.Drawing.Point(10, 150);
            this.btnCompleteSale.Name = "btnCompleteSale";
            this.btnCompleteSale.Size = new System.Drawing.Size(318, 45);
            this.btnCompleteSale.TabIndex = 4;
            this.btnCompleteSale.Text = "COMPLETE SALE";
            this.btnCompleteSale.UseVisualStyleBackColor = false;
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.Controls.Add(this.btnPos);
            this.pnlNavigation.Controls.Add(this.btnDashboard);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 661);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(830, 40);
            this.pnlNavigation.TabIndex = 5;
            // 
            // btnPos
            // 
            this.btnPos.Location = new System.Drawing.Point(280, 5);
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(75, 30);
            this.btnPos.TabIndex = 0;
            this.btnPos.Text = "POS";
            this.btnPos.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(370, 5);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(90, 30);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // lblCashierHeader
            // 
            this.lblCashierHeader.AutoSize = true;
            this.lblCashierHeader.Location = new System.Drawing.Point(584, 28);
            this.lblCashierHeader.Name = "lblCashierHeader";
            this.lblCashierHeader.Size = new System.Drawing.Size(97, 16);
            this.lblCashierHeader.TabIndex = 6;
            this.lblCashierHeader.Text = "Cashier  Switch";
            this.lblCashierHeader.Click += new System.EventHandler(this.lblCashierHeader_Click);
            // 
            // cmbCashier
            // 
            this.cmbCashier.FormattingEnabled = true;
            this.cmbCashier.Location = new System.Drawing.Point(587, 57);
            this.cmbCashier.Name = "cmbCashier";
            this.cmbCashier.Size = new System.Drawing.Size(151, 24);
            this.cmbCashier.TabIndex = 7;
            this.cmbCashier.SelectedIndexChanged += new System.EventHandler(this.cmbCashier_SelectedIndexChanged);
            // 
            // btnEndShift
            // 
            this.btnEndShift.Location = new System.Drawing.Point(663, 87);
            this.btnEndShift.Name = "btnEndShift";
            this.btnEndShift.Size = new System.Drawing.Size(155, 37);
            this.btnEndShift.TabIndex = 8;
            this.btnEndShift.Text = "End Shift & Signout";
            this.btnEndShift.UseVisualStyleBackColor = true;
            this.btnEndShift.Click += new System.EventHandler(this.button1_Click);
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(830, 701);
            this.Controls.Add(this.btnEndShift);
            this.Controls.Add(this.cmbCashier);
            this.Controls.Add(this.lblCashierHeader);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.flpProducts);
            this.Controls.Add(this.pnlCart);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.pnlNavigation);
            this.Name = "POS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS";
            this.Load += new System.EventHandler(this.POS_Load_1);
            this.flpProducts.ResumeLayout(false);
            this.pnlCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummary.PerformLayout();
            this.pnlNavigation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.FlowLayoutPanel flpProducts;
        private System.Windows.Forms.Button btnSoda;
        private System.Windows.Forms.Button btnCoca;
        private System.Windows.Forms.Button btnMilk;
        private System.Windows.Forms.Button btnEggs;
        private System.Windows.Forms.Button btnCookie;
        private System.Windows.Forms.Button btnMeat;
        private System.Windows.Forms.Button btnFastFood;
        private System.Windows.Forms.Button btnBento;
        private System.Windows.Forms.Button btnSkincare;
        private System.Windows.Forms.Button btnVegetables;
        private System.Windows.Forms.Button btnSnacks;
        private System.Windows.Forms.Panel pnlCart;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnVoidSale;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCompleteSale;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Button btnPos;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label lblCashierHeader;
        private System.Windows.Forms.ComboBox cmbCashier;
        private System.Windows.Forms.Button btnEndShift;
    }
}