using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ExampleWinForm {
    public partial class ViewEmployees : Form {
        public ViewEmployees(){
            InitializeComponent();
            
            BindEmployees();
        }

        public List<Employee> Employees { get; set; }

        private void BindEmployees(){
            var repo = new EmployeeRepository();
            Employees = repo.FetchEmployees();
            employeeBindingSource.DataSource = Employees;
        }

        private void btnReset_Click(object sender, System.EventArgs e) {
            BindEmployees();
        }

        private void btnFilter_Click(object sender, System.EventArgs e){
            employeeBindingSource.DataSource = Employees.Where(n => n.Name.ToLower().Contains(txtFilter.Text.ToLower())).ToList();
        }

        private void txtFilter_TextChanged(object sender, System.EventArgs e) {
            btnFilter_Click(sender, null);
        }

        private void employeeBindingSource_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e) {
            if (e.ListChangedType == ListChangedType.ItemDeleted){
            }
        }

        private void dgvEmployees_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) {

        }

        
    }
}
