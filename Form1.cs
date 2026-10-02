using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Mini_Mart_Pos
{
    public partial class Form1 : Form
    {
        // Use Windows API to set Placeholder Text for TextBoxes
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        private const int EM_SETCUEBANNER = 0x1501;

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. Find all TextBoxes on the Form (including inside Panels/GroupBoxes)
            TextBox txtUser = GetUserTextBox();
            TextBox txtPass = GetPasswordTextBox();

            // 2. Set Placeholder for Username/Email
            if (txtUser != null)
            {
                txtUser.Text = "";
                SendMessage(txtUser.Handle, EM_SETCUEBANNER, 0, "Employee ID / Email");
            }

            // 3. Set Placeholder and obscure characters for Password
            if (txtPass != null)
            {
                txtPass.UseSystemPasswordChar = true;
                SendMessage(txtPass.Handle, EM_SETCUEBANNER, 0, "Enter Password");
            }

            // 4. Automatically attach Click Event to the Login Button
            Button btnLogin = FindControl<Button>("btnLogin")
                              ?? FindControl<Button>("button1")
                              ?? FindControl<Button>("btnSubmit");

            if (btnLogin != null)
            {
                btnLogin.Click -= btnLogin_Click; // Prevent duplicate event attachment
                btnLogin.Click += btnLogin_Click;
                this.ActiveControl = btnLogin;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string correctUsername = "admin";
            string correctPassword = "123";

            // Find Username and Password TextBoxes
            TextBox txtUser = GetUserTextBox();
            TextBox txtPass = GetPasswordTextBox();

            string inputUser = txtUser != null ? txtUser.Text.Trim() : "";
            string inputPass = txtPass != null ? txtPass.Text.Trim() : "";

            if (string.IsNullOrEmpty(inputUser) || string.IsNullOrEmpty(inputPass))
            {
                MessageBox.Show("Please enter Employee ID/Email and Password first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (inputUser == correctUsername && inputPass == correctPassword)
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open POS Form and hide Form1 (Login Form)
                POS pos = new POS();
                pos.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Employee ID/Email or Password! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (txtPass != null)
                {
                    txtPass.Clear();
                    txtPass.Focus();
                }
            }
        }

        // --- Helper Methods to automatically locate controls ---

        private TextBox GetUserTextBox()
        {
            return FindControl<TextBox>("txtUsername")
                ?? FindControl<TextBox>("textBox1")
                ?? GetTextBoxByIndex(0);
        }

        private TextBox GetPasswordTextBox()
        {
            return FindControl<TextBox>("txtPassword")
                ?? FindControl<TextBox>("textBox2")
                ?? GetTextBoxByIndex(1);
        }

        // Search for Control by Name (checks all layers/panels recursively)
        private T FindControl<T>(string name) where T : Control
        {
            Control[] found = this.Controls.Find(name, true);
            if (found.Length > 0 && found[0] is T control)
            {
                return control;
            }
            return null;
        }

        // If not found by name, retrieve TextBox by index order
        private TextBox GetTextBoxByIndex(int index)
        {
            List<TextBox> textBoxes = new List<TextBox>();
            GetAllTextBoxes(this, textBoxes);
            if (index < textBoxes.Count)
            {
                return textBoxes[index];
            }
            return null;
        }

        private void GetAllTextBoxes(Control container, List<TextBox> list)
        {
            foreach (Control c in container.Controls)
            {
                if (c is TextBox tb)
                {
                    list.Add(tb);
                }
                else if (c.HasChildren)
                {
                    GetAllTextBoxes(c, list);
                }
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
        }
    }
}