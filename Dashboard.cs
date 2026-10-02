using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Mini_Mart_Pos
{
    public partial class Dashboard : Form
    {
        private string loggedInUser = "Admin";
        private DataGridView dgvRecentSales;
        private Panel bottomNavPanel;

        // Default Constructor
        public Dashboard()
        {
            InitializeComponent();
            this.loggedInUser = "Admin";

            this.Load += Dashboard_Load;
            this.FormClosed += Dashboard_FormClosed;
        }

        // Overloaded Constructor to receive Cashier Username
        public Dashboard(string username)
        {
            InitializeComponent();
            this.loggedInUser = string.IsNullOrWhiteSpace(username) ? "Admin" : username;

            this.Load += Dashboard_Load;
            this.FormClosed += Dashboard_FormClosed;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;

            // 1. Display cashier username
            UpdateCashierLabel();

            // 2. Populate values into summary cards (Daily Sales, Transactions, Low Stock, Top Seller)
            SetCardValues();

            // 3. Configure Sales Overview chart data
            SetupChartData();

            // 4. Initialize Recent Sales DataGridView inside panel4
            SetupRecentSalesGrid();

            // 5. Create bottom navigation buttons (DASHBOARD & POS)
            CreateBottomNavigation();
        }

        private void UpdateCashierLabel()
        {
            if (lblCashier != null)
            {
                lblCashier.Text = "Active cashier: " + loggedInUser;
            }
        }

        private void SetCardValues()
        {
            AddOrUpdateValue(pnlDailySales, "$ 150.50");
            AddOrUpdateValue(pnlTransaction, "24");
            AddOrUpdateValue(pnlStockItems, "5 Items");
            AddOrUpdateValue(pnlTopSeller, "Coca Cola");
        }

        private void AddOrUpdateValue(Panel pnl, string valueText)
        {
            if (pnl == null) return;

            Label lblVal = null;
            foreach (Control c in pnl.Controls)
            {
                if (c is Label lbl && c.Name == "lblVal")
                {
                    lblVal = lbl;
                    break;
                }
            }

            if (lblVal == null)
            {
                lblVal = new Label
                {
                    Name = "lblVal",
                    Font = new Font("Segoe UI", 16, FontStyle.Bold),
                    ForeColor = Color.FromArgb(128, 0, 128), // Purple theme color
                    AutoSize = true,
                    Location = new Point(20, 45)
                };
                pnl.Controls.Add(lblVal);
            }

            lblVal.Text = valueText;
            lblVal.BringToFront();
        }

        private void SetupChartData()
        {
            if (chart1 != null)
            {
                chart1.Series.Clear();

                Series series = new Series("Sales")
                {
                    ChartType = SeriesChartType.Column,
                    Color = Color.Purple,
                    IsValueShownAsLabel = true
                };

                // Sample sales data points for weekly overview
                series.Points.AddXY("Mon", 45);
                series.Points.AddXY("Tue", 72);
                series.Points.AddXY("Wed", 82);
                series.Points.AddXY("Thu", 68);
                series.Points.AddXY("Fri", 95);
                series.Points.AddXY("Sat", 110);
                series.Points.AddXY("Sun", 85);

                chart1.Series.Add(series);
            }
        }

        private void SetupRecentSalesGrid()
        {
            if (panel4 == null) return;

            // Configure panel4 styling
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Clear();

            // Recent Sales header title
            Label lblTitle = new Label
            {
                Text = "RECENT SALES",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 41, 59),
                Location = new Point(10, 8),
                AutoSize = true
            };
            panel4.Controls.Add(lblTitle);

            // Initialize DataGridView inside panel4
            dgvRecentSales = new DataGridView
            {
                Location = new Point(10, 32),
                Size = new Size(panel4.Width - 20, panel4.Height - 40),
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };

            // Populate sample data table
            DataTable dt = new DataTable();
            dt.Columns.Add("Time");
            dt.Columns.Add("Total");
            dt.Columns.Add("Payment Type");

            dt.Rows.Add("10:30 AM", "$ 12.50", "Cash");
            dt.Rows.Add("11:15 AM", "$ 4.50", "ABA KHQR");
            dt.Rows.Add("11:40 AM", "$ 8.00", "Cash");

            dgvRecentSales.DataSource = dt;
            panel4.Controls.Add(dgvRecentSales);
        }

        private void CreateBottomNavigation()
        {
            if (panel4 == null) return;

            // Place navigation buttons directly below panel4
            int topPos = panel4.Bottom + 15;

            bottomNavPanel = new Panel
            {
                Location = new Point(panel4.Left, topPos),
                Size = new Size(400, 50),
                BackColor = Color.Transparent
            };

            Button btnDash = new Button
            {
                Text = "DASHBOARD",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Size = new Size(130, 40),
                Location = new Point(0, 5),
                BackColor = Color.Purple,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnDash.FlatAppearance.BorderSize = 0;

            Button btnPos = new Button
            {
                Text = "POS",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Size = new Size(130, 40),
                Location = new Point(140, 5),
                BackColor = Color.FromArgb(230, 230, 230),
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat
            };

            btnPos.Click += btnPOS_Click;

            bottomNavPanel.Controls.Add(btnDash);
            bottomNavPanel.Controls.Add(btnPos);

            this.Controls.Add(bottomNavPanel);
            bottomNavPanel.BringToFront();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            POS posForm = new POS();
            posForm.Show();
            this.Hide();
        }

        // Kept to prevent CS1061 compile error with panel4 Paint event handler in Designer file
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Load_1(object sender, EventArgs e)
        {

        }
    }
}