using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Mini_Mart_Pos
{
    public partial class POS : Form
    {
        private DataTable cartTable;
        private double taxRate = 0.10; // ពន្ធ 10%

        // បញ្ជីឈ្មោះ Cashier សមាជិកទាំង ៤ នាក់
        private string[] cashierList = new string[]
        {
            "Maly",
            "Vathana",
            "Dalis",
            "Chhenghorng"
        };

        public POS()
        {
            InitializeComponent();
            this.Load += POS_Load;
            this.FormClosed += POS_FormClosed;
        }

        private void POS_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            // 1. Setup Cashier Dropdown / Switch
            SetupCashierSection();

            // 2. Setup DataGridView Cart
            SetupCartGrid();

            // 3. ភ្ជាប់ Event ស្វែងរក (Search)
            AttachSearchEvents(this);

            // 4. ផ្ទុករូបភាពដាក់លើ ប៊ូតុង/Control ទំនិញ
            LoadItemImages();

            // 5. ភ្ជាប់ Event ចុចលើ ទំនិញ ដើម្បីបញ្ចូលទៅ Cart
            AttachItemClickEvents(this);

            // 6. ភ្ជាប់ Event លើ ប៊ូតុង CLEAR, VOID, COMPLETE SALE, DASHBOARD, END SHIFT
            AttachButtonEvents();

            // 7. គណនាតម្លៃសរុបដំបូង
            CalculateTotal();
        }

        // ==========================================
        // 0. CASHIER SWITCH SECTION (ការកំណត់ CASHIER)
        // ==========================================
        private void SetupCashierSection()
        {
            ComboBox cmb = FindControlRecursive<ComboBox>(this);
            if (cmb != null)
            {
                cmb.Items.Clear();
                cmb.Items.AddRange(cashierList);
                cmb.SelectedIndex = 0; // Default ជ្រើសរើស Maly
                cmb.DropDownStyle = ComboBoxStyle.DropDownList;

                cmb.SelectedIndexChanged -= cmbCashier_SelectedIndexChanged;
                cmb.SelectedIndexChanged += cmbCashier_SelectedIndexChanged;
            }
        }

        private void cmbCashier_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            if (cmb != null && cmb.SelectedItem != null)
            {
                string selectedCashier = cmb.SelectedItem.ToString();
                MessageBox.Show($"Switched Cashier to: {selectedCashier}", "Cashier Switch", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SetupCartGrid()
        {
            DataGridView dgv = FindControlRecursive<DataGridView>(this);
            if (dgv != null)
            {
                dgv.DataSource = null;
                dgv.Columns.Clear();

                cartTable = new DataTable();
                cartTable.Columns.Add("Items", typeof(string));
                cartTable.Columns.Add("Qty", typeof(int));
                cartTable.Columns.Add("Price", typeof(double));
                cartTable.Columns.Add("Total", typeof(double));

                dgv.DataSource = cartTable;
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.AllowUserToAddRows = false;
                dgv.ReadOnly = true;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        // ==========================================
        // 1. SEARCH FUNCTIONALITY (ការស្វែងរកទំនិញ)
        // ==========================================
        private void AttachSearchEvents(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox txt)
                {
                    txt.TextChanged -= TxtSearch_TextChanged;
                    txt.TextChanged += TxtSearch_TextChanged;

                    txt.Click -= TxtSearch_Click;
                    txt.Click += TxtSearch_Click;
                }

                if (c.HasChildren)
                {
                    AttachSearchEvents(c);
                }
            }
        }

        private void TxtSearch_Click(object sender, EventArgs e)
        {
            if (sender is TextBox txt && txt.Text == "Main product search...")
            {
                txt.Text = "";
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt == null) return;

            string searchText = txt.Text.Trim().ToLower();

            if (searchText == "main product search...")
                searchText = "";

            FilterCards(this, searchText);
        }

        private void FilterCards(Control parent, string keyword)
        {
            foreach (Control c in parent.Controls)
            {
                string itemName = GetItemName(c);

                if (!string.IsNullOrEmpty(itemName) && IsProductItem(itemName))
                {
                    Control topCard = GetTopCardContainer(c);

                    if (string.IsNullOrEmpty(keyword) || itemName.ToLower().Contains(keyword))
                    {
                        topCard.Visible = true;
                    }
                    else
                    {
                        topCard.Visible = false;
                    }
                }

                if (c.HasChildren && !(c is Button))
                {
                    FilterCards(c, keyword);
                }
            }
        }

        private Control GetTopCardContainer(Control c)
        {
            if (c.Parent != null && c.Parent != this && !(c.Parent is Form) && !(c.Parent is TableLayoutPanel) && !(c.Parent is FlowLayoutPanel))
            {
                if (c.Parent is Panel || c.Parent is GroupBox)
                    return c.Parent;
            }
            return c;
        }

        // ==========================================
        // 2. LOAD IMAGES (ការទាញយករូបភាពមកបង្ហាញ)
        // ==========================================
        private void LoadItemImages()
        {
            string debugImgFolder = Path.Combine(Application.StartupPath, "Image");
            string projectImgFolder = Path.Combine(Directory.GetParent(Application.StartupPath).Parent.FullName, "Image");

            if (!Directory.Exists(debugImgFolder))
                debugImgFolder = Path.Combine(Application.StartupPath, "Images");
            if (!Directory.Exists(projectImgFolder))
                projectImgFolder = Path.Combine(Directory.GetParent(Application.StartupPath).Parent.FullName, "Images");

            string targetFolder = Directory.Exists(debugImgFolder) ? debugImgFolder : (Directory.Exists(projectImgFolder) ? projectImgFolder : debugImgFolder);

            var items = new (string Keyword, string FileName)[]
            {
                ("Soda", "sosa.jpg"),
                ("Coca", "coca.jpg"),
                ("Milk", "milk.jpg"),
                ("Egg", "egg.jpg"),
                ("Cookie", "cookie.jpg"),
                ("Meat", "meat.jpg"),
                ("Fast Food", "Fast Food .jpg"),
                ("Bento Box", "Bento Box.jpg"),
                ("Skincare", "skincare.jpg"),
                ("Vegetables", "vegetables.jpg"),
                ("Snacks", "snacks.jpg")
            };

            foreach (var item in items)
            {
                string path = Path.Combine(targetFolder, item.FileName);

                if (!File.Exists(path))
                {
                    string nameOnly = Path.GetFileNameWithoutExtension(item.FileName).Trim();
                    string[] files = Directory.GetFiles(targetFolder, nameOnly + ".*");
                    if (files.Length > 0) path = files[0];
                }

                if (File.Exists(path))
                {
                    SetImageToMatchedControl(this, item.Keyword, path);
                }
            }
        }

        private void SetImageToMatchedControl(Control parent, string keyword, string imagePath)
        {
            foreach (Control c in parent.Controls)
            {
                string text = (c.Text + " " + c.Name).ToUpper();

                if (text.Contains(keyword.ToUpper()))
                {
                    Image img = LoadBitmapNoLock(imagePath);
                    if (img != null)
                    {
                        if (c is Button btn)
                        {
                            btn.Image = new Bitmap(img, new Size(40, 40));
                            btn.TextImageRelation = TextImageRelation.ImageAboveText;
                            btn.ImageAlign = ContentAlignment.TopCenter;
                            btn.TextAlign = ContentAlignment.BottomCenter;
                        }
                        else if (c is PictureBox pb)
                        {
                            pb.Image = img;
                            pb.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                        else if (c is Panel || c is GroupBox)
                        {
                            bool setInside = false;
                            foreach (Control sub in c.Controls)
                            {
                                if (sub is PictureBox subPb)
                                {
                                    subPb.Image = img;
                                    subPb.SizeMode = PictureBoxSizeMode.Zoom;
                                    setInside = true;
                                    break;
                                }
                            }
                            if (!setInside)
                            {
                                c.BackgroundImage = img;
                                c.BackgroundImageLayout = ImageLayout.Zoom;
                            }
                        }
                    }
                }

                if (c.HasChildren)
                {
                    SetImageToMatchedControl(c, keyword, imagePath);
                }
            }
        }

        private Image LoadBitmapNoLock(string path)
        {
            try
            {
                using (Bitmap bmp = new Bitmap(path))
                {
                    return new Bitmap(bmp);
                }
            }
            catch
            {
                return null;
            }
        }

        // ==========================================
        // 3. EVENT CLICK & CART LOGIC (បញ្ជាទិញទំនិញ)
        // ==========================================
        private void AttachItemClickEvents(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                string itemName = GetItemName(c);
                if (!string.IsNullOrEmpty(itemName) && IsProductItem(itemName))
                {
                    c.Cursor = Cursors.Hand;
                    c.Click -= Item_Click;
                    c.Click += Item_Click;

                    foreach (Control child in c.Controls)
                    {
                        child.Cursor = Cursors.Hand;
                        child.Click -= Item_Click;
                        child.Click += Item_Click;
                    }
                }

                if (c.HasChildren)
                {
                    AttachItemClickEvents(c);
                }
            }
        }

        private bool IsProductItem(string name)
        {
            string n = name.ToUpper();
            return n.Contains("SODA") || n.Contains("COCA") || n.Contains("MILK") ||
                   n.Contains("EGG") || n.Contains("COOKIE") || n.Contains("MEAT") ||
                   n.Contains("FAST") || n.Contains("BENTO") || n.Contains("SKIN") ||
                   n.Contains("VEGE") || n.Contains("SNACK");
        }

        private string GetItemName(Control c)
        {
            if (c is Button btn) return btn.Text;
            if (c is Label lbl) return lbl.Text;
            if (c is Panel || c is GroupBox)
            {
                foreach (Control sub in c.Controls)
                {
                    if (sub is Label l && IsProductItem(l.Text)) return l.Text;
                }
            }
            return c.Text;
        }

        private void Item_Click(object sender, EventArgs e)
        {
            Control clicked = sender as Control;
            string itemName = GetItemName(clicked);

            if (clicked is Label && clicked.Parent != null)
            {
                string parentName = GetItemName(clicked.Parent);
                if (!string.IsNullOrEmpty(parentName)) itemName = parentName;
            }

            if (string.IsNullOrEmpty(itemName) || !IsProductItem(itemName)) return;

            double price = GetProductPrice(itemName);
            bool found = false;

            if (cartTable != null)
            {
                foreach (DataRow row in cartTable.Rows)
                {
                    if (row["Items"].ToString().Equals(itemName, StringComparison.OrdinalIgnoreCase))
                    {
                        int newQty = Convert.ToInt32(row["Qty"]) + 1;
                        row["Qty"] = newQty;
                        row["Total"] = newQty * price;
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    cartTable.Rows.Add(itemName, 1, price, price);
                }
            }

            CalculateTotal();
        }

        private double GetProductPrice(string name)
        {
            string n = name.ToUpper();
            if (n.Contains("SODA")) return 1.00;
            if (n.Contains("COCA")) return 1.25;
            if (n.Contains("MILK")) return 2.50;
            if (n.Contains("EGG")) return 1.80;
            if (n.Contains("COOKIE")) return 1.50;
            if (n.Contains("MEAT")) return 5.00;
            if (n.Contains("FAST")) return 3.50;
            if (n.Contains("BENTO")) return 4.00;
            if (n.Contains("SKIN")) return 8.50;
            if (n.Contains("VEGE")) return 2.00;
            if (n.Contains("SNACK")) return 1.20;
            return 2.00;
        }

        private void CalculateTotal()
        {
            double subtotal = 0;

            if (cartTable != null)
            {
                foreach (DataRow row in cartTable.Rows)
                {
                    subtotal += Convert.ToDouble(row["Total"]);
                }
            }

            double tax = subtotal * taxRate;
            double total = subtotal + tax;

            UpdateSummaryLabel("Subtotal", $"$ {subtotal:F2}");
            UpdateSummaryLabel("Tax", $"$ {tax:F2}");
            UpdateSummaryLabel("TOTAL", $"$ {total:F2}");
        }

        private void UpdateSummaryLabel(string keyword, string value)
        {
            FindAndUpdateLabel(this, keyword, value);
        }

        private void FindAndUpdateLabel(Control parent, string keyword, string value)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Label lbl && lbl.Text.ToUpper().StartsWith(keyword.ToUpper()))
                {
                    lbl.Text = $"{keyword}: {value}";
                    return;
                }
                if (c.HasChildren)
                {
                    FindAndUpdateLabel(c, keyword, value);
                }
            }
        }

        // ==========================================
        // 4. PRINT RECEIPT INVOICE (ការបង្កើត និងបោះពុម្ពវិក្កយបត្រ)
        // ==========================================
        private void PrintReceipt()
        {
            if (cartTable == null || cartTable.Rows.Count == 0) return;

            // ទាញយកឈ្មោះ Cashier ចេញពី Dropdown/ComboBox
            ComboBox cmb = FindControlRecursive<ComboBox>(this);
            string cashierName = cmb != null && cmb.SelectedItem != null ? cmb.SelectedItem.ToString() : "Nita";

            // គណនាតម្លៃសរុប
            double subtotal = 0;
            foreach (DataRow row in cartTable.Rows)
            {
                subtotal += Convert.ToDouble(row["Total"]);
            }
            double grandTotal = subtotal + (subtotal * taxRate);

            // រៀបចំទម្រង់ Receipts Formatting
            StringBuilder receipt = new StringBuilder();
            receipt.AppendLine("==================================");
            receipt.AppendLine("         MINI MART POS            ");
            receipt.AppendLine("==================================");
            receipt.AppendLine($"Date: {DateTime.Now:dd/MM/yyyy hh:mm tt}");
            receipt.AppendLine($"Cashier: {cashierName}");
            receipt.AppendLine("----------------------------------");
            receipt.AppendLine(string.Format("{0,-12} {1,5} {2,8} {3,8}", "Item", "Qty", "Price", "Total"));
            receipt.AppendLine("----------------------------------");

            foreach (DataRow row in cartTable.Rows)
            {
                string item = row["Items"].ToString();
                if (item.Length > 12) item = item.Substring(0, 11) + ".";
                int qty = Convert.ToInt32(row["Qty"]);
                double price = Convert.ToDouble(row["Price"]);
                double total = Convert.ToDouble(row["Total"]);

                receipt.AppendLine(string.Format("{0,-12} {1,5} ${2,7:F2} ${3,7:F2}", item, qty, price, total));
            }

            receipt.AppendLine("----------------------------------");
            receipt.AppendLine($"Grand Total: ${grandTotal:F2}");
            receipt.AppendLine("==================================");
            receipt.AppendLine("   Thank you for shopping with us! ");

            // បង្ហាញវិក្កយបត្រ
            MessageBox.Show(receipt.ToString(), "Receipt Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ==========================================
        // 5. BUTTON EVENTS (CLEAR, VOID, COMPLETE, END SHIFT)
        // ==========================================
        private void AttachButtonEvents()
        {
            Button btnClear = FindButtonByText(this, "CLEAR");
            if (btnClear != null)
            {
                btnClear.Click -= ClearCart_Click;
                btnClear.Click += ClearCart_Click;
            }

            Button btnVoid = FindButtonByText(this, "VOID");
            if (btnVoid != null)
            {
                btnVoid.Click -= ClearCart_Click;
                btnVoid.Click += ClearCart_Click;
            }

            Button btnComplete = FindButtonByText(this, "COMPLETE");
            if (btnComplete != null)
            {
                btnComplete.Click -= CompleteSale_Click;
                btnComplete.Click += CompleteSale_Click;
            }

            Button btnDash = FindButtonByText(this, "DASHBOA");
            if (btnDash != null)
            {
                btnDash.Click -= btnDashboard_Click;
                btnDash.Click += btnDashboard_Click;
            }

            Button btnEndShift = FindButtonByText(this, "END SHIFT");
            if (btnEndShift != null)
            {
                btnEndShift.Click -= BtnEndShift_Click;
                btnEndShift.Click += BtnEndShift_Click;
            }
        }

        private void BtnEndShift_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to End Shift & Sign out?", "End Shift", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Shift Ended Successfully. Signing out...", "Sign Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form1 loginForm = new Form1();
                loginForm.Show();
            }
        }

        private void ClearCart_Click(object sender, EventArgs e)
        {
            if (cartTable != null)
            {
                cartTable.Rows.Clear();
                CalculateTotal();
            }
        }

        private void CompleteSale_Click(object sender, EventArgs e)
        {
            if (cartTable == null || cartTable.Rows.Count == 0)
            {
                MessageBox.Show("Please select items first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ១. បង្ហាញវិក្កយបត្រ (Receipt)
            PrintReceipt();

            // ២. ជោគជ័យ និងសម្អាតកន្ត្រកទំនិញ
            ClearCart_Click(sender, e);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private Button FindButtonByText(Control parent, string text)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Button btn && btn.Text.ToUpper().Contains(text.ToUpper()))
                    return btn;

                if (c.HasChildren)
                {
                    Button res = FindButtonByText(c, text);
                    if (res != null) return res;
                }
            }
            return null;
        }

        private T FindControlRecursive<T>(Control parent) where T : Control
        {
            foreach (Control c in parent.Controls)
            {
                if (c is T match) return match;
                if (c.HasChildren)
                {
                    T res = FindControlRecursive<T>(c);
                    if (res != null) return res;
                }
            }
            return null;
        }

        private void POS_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void POS_Load_1(object sender, EventArgs e) { }
        private void pnlSummary_Paint(object sender, PaintEventArgs e) { }
        private void lblCashierHeader_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
    }
}