using System.Data;
using System.Windows.Forms;

namespace Tableware01
{
    public partial class MainForm : Form
    {
        /*
        авторизованный клиент и менеджер может ПРОСМАТРИВАТЬ товары, ФОРМИРОВАТЬ и РЕДАКТИРОВАТЬ ЗАКАЗЫ;
        администратор может ДОБАВЛЯТЬ/РЕДАКТИРОВАТЬ/УДАЛЯТЬ ТОВАРЫ.
        */

        private DataTable dataTable = DataBase.GetDataTable("select * from Users", "№", "Имя", "Пароль");
        private Registration registrationForm = new Registration();

        public MainForm()
        {
            InitializeComponent();
            InitializeRegistrathionForm();
            registrationForm.OnStaffChange += (sender, args) => 
            {
                InitializeUserControls();
                howToUse.Click += (s, a) => MessageBox.Show(howToUseStr, "Как использовать программу", MessageBoxButtons.OK, MessageBoxIcon.Information);
                about.Click += (s, a) => MessageBox.Show(aboutStr, "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
                update.Click += (s, a) => UpdateDataTable(dataTable);
                insert.Click += (s, a) => DataBase.VoidQuery("insert into Users (Name, Password) values ('q', 'q')");
                delete.Click += (s, a) => DataBase.VoidQuery("delete from Users where Name = 'q'");
            };
        }

        private void InitializeRegistrathionForm()
        {
            Load += (sender, args) => registrationForm.ShowDialog();
            registrationForm.FormClosed += (sender, args) =>
            {
                if (registrationForm.ReturnStaff == Staff.None)
                     Close();
            };
        }

        private void LoadDataGrid() => usersDataGridView.DataSource = dataTable;

        private void UpdateDataTable(DataTable table)
        {
            var query = "select * from Users";
            table.Clear();
            foreach (var row in DataBase.GetTable(query, "№", "Имя", "Пароль").data)
                table.Rows.Add(row);
        }
    }
}