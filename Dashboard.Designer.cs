namespace Mini_Mart_Pos
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCashier = new System.Windows.Forms.Label();
            this.lblDashoardTitles = new System.Windows.Forms.Label();
            this.pnlDailySales = new System.Windows.Forms.Panel();
            this.lblDailySales = new System.Windows.Forms.Label();
            this.lblTransaction = new System.Windows.Forms.Label();
            this.pnlTransaction = new System.Windows.Forms.Panel();
            this.pnlTopSeller = new System.Windows.Forms.Panel();
            this.LblTop = new System.Windows.Forms.Label();
            this.pnlStockItems = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSaleOverview = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlDailySales.SuspendLayout();
            this.pnlTransaction.SuspendLayout();
            this.pnlTopSeller.SuspendLayout();
            this.pnlStockItems.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblCashier);
            this.panel1.Controls.Add(this.lblDashoardTitles);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 70);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(20, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 100);
            this.panel2.TabIndex = 2;
            // 
            // lblCashier
            // 
            this.lblCashier.AutoSize = true;
            this.lblCashier.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashier.Location = new System.Drawing.Point(900, 25);
            this.lblCashier.Name = "lblCashier";
            this.lblCashier.Size = new System.Drawing.Size(123, 23);
            this.lblCashier.TabIndex = 1;
            this.lblCashier.Text = "Active cashier: ";
            // 
            // lblDashoardTitles
            // 
            this.lblDashoardTitles.AutoSize = true;
            this.lblDashoardTitles.BackColor = System.Drawing.Color.Transparent;
            this.lblDashoardTitles.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashoardTitles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblDashoardTitles.Location = new System.Drawing.Point(25, 20);
            this.lblDashoardTitles.Name = "lblDashoardTitles";
            this.lblDashoardTitles.Size = new System.Drawing.Size(369, 41);
            this.lblDashoardTitles.TabIndex = 0;
            this.lblDashoardTitles.Text = "DASHBOARD (Overview)";
            // 
            // pnlDailySales
            // 
            this.pnlDailySales.BackColor = System.Drawing.Color.White;
            this.pnlDailySales.Controls.Add(this.lblDailySales);
            this.pnlDailySales.Location = new System.Drawing.Point(20, 100);
            this.pnlDailySales.Name = "pnlDailySales";
            this.pnlDailySales.Size = new System.Drawing.Size(275, 100);
            this.pnlDailySales.TabIndex = 3;
            // 
            // lblDailySales
            // 
            this.lblDailySales.AutoSize = true;
            this.lblDailySales.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDailySales.Location = new System.Drawing.Point(81, 12);
            this.lblDailySales.Name = "lblDailySales";
            this.lblDailySales.Size = new System.Drawing.Size(99, 20);
            this.lblDailySales.TabIndex = 0;
            this.lblDailySales.Text = "DAILY SALES";
            // 
            // lblTransaction
            // 
            this.lblTransaction.AutoSize = true;
            this.lblTransaction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransaction.Location = new System.Drawing.Point(79, 12);
            this.lblTransaction.Name = "lblTransaction";
            this.lblTransaction.Size = new System.Drawing.Size(116, 20);
            this.lblTransaction.TabIndex = 1;
            this.lblTransaction.Text = "TRANSACTION";
            // 
            // pnlTransaction
            // 
            this.pnlTransaction.BackColor = System.Drawing.Color.White;
            this.pnlTransaction.Controls.Add(this.lblTransaction);
            this.pnlTransaction.Location = new System.Drawing.Point(310, 100);
            this.pnlTransaction.Name = "pnlTransaction";
            this.pnlTransaction.Size = new System.Drawing.Size(275, 100);
            this.pnlTransaction.TabIndex = 2;
            // 
            // pnlTopSeller
            // 
            this.pnlTopSeller.BackColor = System.Drawing.Color.White;
            this.pnlTopSeller.Controls.Add(this.LblTop);
            this.pnlTopSeller.Location = new System.Drawing.Point(890, 100);
            this.pnlTopSeller.Name = "pnlTopSeller";
            this.pnlTopSeller.Size = new System.Drawing.Size(275, 100);
            this.pnlTopSeller.TabIndex = 0;
            // 
            // LblTop
            // 
            this.LblTop.AutoSize = true;
            this.LblTop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTop.Location = new System.Drawing.Point(84, 12);
            this.LblTop.Name = "LblTop";
            this.LblTop.Size = new System.Drawing.Size(91, 20);
            this.LblTop.TabIndex = 1;
            this.LblTop.Text = "TOP SELLER";
            // 
            // pnlStockItems
            // 
            this.pnlStockItems.BackColor = System.Drawing.Color.White;
            this.pnlStockItems.Controls.Add(this.label1);
            this.pnlStockItems.Location = new System.Drawing.Point(600, 100);
            this.pnlStockItems.Name = "pnlStockItems";
            this.pnlStockItems.Size = new System.Drawing.Size(275, 100);
            this.pnlStockItems.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOW STOCK ITEMS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblSaleOverview);
            this.panel3.Controls.Add(this.chart1);
            this.panel3.Location = new System.Drawing.Point(20, 237);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1145, 283);
            this.panel3.TabIndex = 2;
            // 
            // lblSaleOverview
            // 
            this.lblSaleOverview.AutoSize = true;
            this.lblSaleOverview.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleOverview.Location = new System.Drawing.Point(15, 10);
            this.lblSaleOverview.Name = "lblSaleOverview";
            this.lblSaleOverview.Size = new System.Drawing.Size(177, 28);
            this.lblSaleOverview.TabIndex = 5;
            this.lblSaleOverview.Text = "SALES OVERVIEW";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(227, 45);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(917, 250);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(20, 538);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(530, 155);
            this.panel4.TabIndex = 6;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 826);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlStockItems);
            this.Controls.Add(this.pnlTopSeller);
            this.Controls.Add(this.pnlTransaction);
            this.Controls.Add(this.pnlDailySales);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Mart POS Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDailySales.ResumeLayout(false);
            this.pnlDailySales.PerformLayout();
            this.pnlTransaction.ResumeLayout(false);
            this.pnlTransaction.PerformLayout();
            this.pnlTopSeller.ResumeLayout(false);
            this.pnlTopSeller.PerformLayout();
            this.pnlStockItems.ResumeLayout(false);
            this.pnlStockItems.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCashier;
        private System.Windows.Forms.Label lblDashoardTitles;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlDailySales;
        private System.Windows.Forms.Label lblTransaction;
        private System.Windows.Forms.Label lblDailySales;
        private System.Windows.Forms.Panel pnlTransaction;
        private System.Windows.Forms.Panel pnlTopSeller;
        private System.Windows.Forms.Panel pnlStockItems;
        private System.Windows.Forms.Label LblTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblSaleOverview;
        private System.Windows.Forms.Panel panel4;
    }
}