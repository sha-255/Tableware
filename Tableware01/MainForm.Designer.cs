using System.Drawing;
using System.Windows.Forms;

namespace Tableware01
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private readonly Color mainColor = Color.FromArgb(255, 255, 255);
        private readonly Color additionalColor = Color.FromArgb(118, 227, 131);
        private readonly Color accentColor = Color.FromArgb(73, 140, 81);
        private TabControl tabControl;
        private TabPage products;
        private TableLayoutPanel layoutPanel;
        private DataGridView usersDataGridView;
        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem dataGridVievWorck;
        private ToolStripMenuItem update;
        private ToolStripMenuItem insert;
        private ToolStripMenuItem delete;
        private ToolStripMenuItem reference;
        private ToolStripMenuItem howToUse;
        private string howToUseStr;
        private ToolStripMenuItem about;
        private string aboutStr;
        private TabPage orders;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            MinimumSize = new System.Drawing.Size(800, 450);
            Text = "ООО \"Посуда\"";
            StartPosition = FormStartPosition.CenterScreen;
            Icon = Properties.Resources.icon;
        }

        private void InitializeUserControls()
        {
            layoutPanel = new TableLayoutPanel() { Dock = DockStyle.Fill };
            tabControl = new TabControl() { Dock = DockStyle.Fill, };
            products = new TabPage()
            {
                Dock = DockStyle.Fill,
                Text = "Товары"
            };
            orders = new TabPage()
            {
                Dock = DockStyle.Fill,
                Text = "Корзина"
            };
            InitializeDataGridView();
            InitializeUserPanel();
        }

        private void InitializeDataGridView()
        {
            usersDataGridView = new DataGridView();
            LoadDataGrid();
            usersDataGridView.Dock = DockStyle.Fill;
            usersDataGridView.BackgroundColor = mainColor;
            usersDataGridView.GridColor = accentColor;
            usersDataGridView.RowHeadersVisible = false;
            usersDataGridView.ColumnHeadersVisible = true;
            usersDataGridView.ReadOnly = true;
            usersDataGridView.AllowUserToAddRows = false;
            usersDataGridView.AllowUserToDeleteRows = false;
            usersDataGridView.DefaultCellStyle.BackColor = additionalColor;
            usersDataGridView.DefaultCellStyle.ForeColor = accentColor;
            usersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            usersDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
        }

        private void InitializeUserPanel()
        {
            InitializeMenuStrip();
            InitializeProductsTab();
            InitializeOrdersTab();
            tabControl.Controls.Add(products);
            tabControl.Controls.Add(orders);
            Controls.Add(layoutPanel);
        }

        private void InitializeProductsTab()
        {
            layoutPanel.RowStyles.Clear();
            layoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 23));
            layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 1));
            layoutPanel.Dock = DockStyle.Fill;
            products.Controls.Add(usersDataGridView);
            layoutPanel.Controls.Add(mainMenuStrip, 0, 0);
            layoutPanel.Controls.Add(tabControl, 0, 1);
        }

        private void InitializeMenuStrip()
        {
            mainMenuStrip = new MenuStrip() 
            {
                BackColor = Color.White,
                Dock = DockStyle.Fill,
            };
            dataGridVievWorck = new ToolStripMenuItem() { Text = "Таблица" };
            update = new ToolStripMenuItem() { Text = "Обновить", };
            insert = new ToolStripMenuItem() { Text = "Вставить", };
            delete = new ToolStripMenuItem() { Text = "Удолить", };
            reference = new ToolStripMenuItem() { Text = "Справка", };
            howToUse = new ToolStripMenuItem() { Text = "Как пользоваться", };
            howToUseStr = "Не пользуйтесь этой программой";
            about = new ToolStripMenuItem() { Text = "О программе", };
            aboutStr = "ООО \"Посуда\" 2023 0.0.1\nСпасибо что используете нашу программу!";
            dataGridVievWorck.DropDownItems.Add(update);
            dataGridVievWorck.DropDownItems.Add(insert);
            dataGridVievWorck.DropDownItems.Add(delete);
            reference.DropDownItems.Add(howToUse);
            reference.DropDownItems.Add(about);
            mainMenuStrip.Items.Add(dataGridVievWorck);
            mainMenuStrip.Items.Add(reference);
        }

        private void InitializeOrdersTab()
        {
            var label = new Label()
            {
                Text = "Корзина пуста",
                Dock = DockStyle.Fill,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 20, FontStyle.Bold),
                ForeColor = accentColor
            };
            orders.Controls.Add(label);
        }
    }
}