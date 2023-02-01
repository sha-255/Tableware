using System.Windows.Forms;
using System.Drawing;

namespace Tableware01
{
    partial class Registration
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
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new Size(300, 500);
            MinimumSize = new Size(300, 500);
            Text = "Авторизация";
            StartPosition = FormStartPosition.CenterScreen;
            Icon = Properties.Resources.icon;
        }

        private void InitializeControls()
        {
            Table = new TableLayoutPanel();
            Logo = new PictureBox
            {
                Dock = DockStyle.Top,
                Image = Properties.Resources.logo,
                SizeMode = PictureBoxSizeMode.Zoom
            };
            LoginTitle = new Label
            {
                Dock = DockStyle.Bottom,
                Text = "Введите логин"
            };
            LoginInput = new TextBox
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(118, 227, 131),
                MaxLength = 50
            };
            PasswordTitle = new Label
            {
                Dock = DockStyle.Bottom,
                Text = "Введите пароль"
            };
            PasswordInput = new TextBox
            {
                Dock = DockStyle.Fill,
                MaxLength = 50,
                BackColor = Color.FromArgb(118, 227, 131),
                UseSystemPasswordChar = true
            };
            Autorization = new Button
            {
                Dock = DockStyle.Top,
                BackColor = Color.FromArgb(73, 140, 81),
                Text = "Войти"
            };
            InitializeAutorizationPanel();
        }

        private void InitializeAutorizationPanel()
        {
            var column = 1;
            Table.RowStyles.Clear();
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            for (var i = 0; i < 5; i++)
                Table.RowStyles.Add(new RowStyle(SizeType.Percent, 80));
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            Table.Controls.Add(new Panel(), column, 0);
            Table.Controls.Add(Logo, column, 1);
            Table.Controls.Add(LoginTitle, column, 2);
            Table.Controls.Add(LoginInput, column, 3);
            Table.Controls.Add(PasswordTitle, column, 4);
            Table.Controls.Add(PasswordInput, column, 5);
            Table.Controls.Add(Autorization, column, 6);
            Table.Controls.Add(new Panel(), column, 7);
            Table.Controls.Add(new Panel(), 2, 7);
            Table.Dock = DockStyle.Fill;
            Controls.Add(Table);
        }
    }
}