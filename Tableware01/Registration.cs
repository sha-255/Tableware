using System;
using System.Windows.Forms;

namespace Tableware01
{
    public partial class Registration : Form
    {
        private TableLayoutPanel Table;
        private PictureBox Logo;
        private Label LoginTitle;
        private TextBox LoginInput;
        private Label PasswordTitle;
        private TextBox PasswordInput;
        private Button Autorization;
        public delegate void StaffHandler(object sender, EventArgs e);
        public event StaffHandler OnStaffChange;

        private Staff returnStaff;
        public Staff ReturnStaff
        { 
            get
            {
                return returnStaff;
            }
            private set
            {
                returnStaff = value;
                OnStaffChange?.Invoke(this, EventArgs.Empty);
            }
        }

        public Registration()
        {
            InitializeComponent();
            InitializeControls();
            Autorization.Click += (sender, args) =>
            {
                if (DataBase.TrySelect(
$"SELECT Name, Password from Users where Name = '{LoginInput.Text}' and Password = '{PasswordInput.Text}'"))
                {
                    ReturnStaff = Staff.User;
                    Close();
                }
                else
                    MessageBox.Show(
                        "Неверно заполненны данные",
                        "Предупреждение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            };
        }
    }
}