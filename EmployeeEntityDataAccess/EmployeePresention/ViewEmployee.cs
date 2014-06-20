using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using EmployeeEntityDataAccess;

namespace EmployeePresention {
    public partial class ViewEmployee : Form {
        public ViewEmployee() {
            InitializeComponent();
            Dao = new EmployeeDataAccess();
        }

        private EmployeeDataAccess Dao { get; set; }
        private ObservableCollection<EmployeeDataTransfer> Employees { get; set; }

        private void ViewEmployee_Load(object sender, EventArgs e){
            Employees = new ObservableCollection<EmployeeDataTransfer>(Dao.Fetch());
            employeeDataTransferBindingSource.DataSource = Employees;
            Employees.CollectionChanged += Employees_CollectionChanged;
            Added = new List<EmployeeDataTransfer>();
        }

        private void Employees_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e){
            switch (e.Action){
                case NotifyCollectionChangedAction.Add:
                    var dto = (EmployeeDataTransfer) e.NewItems[0];
                    if (!Added.Contains(dto)){
                        Added.Add((EmployeeDataTransfer) e.NewItems[0]);
                    }
                    break;
            }
        }

        private List<EmployeeDataTransfer> Added { get; set; }

        private void Save_Click(object sender, EventArgs e) {
            Added.Where(a=> !string.IsNullOrEmpty(a.Name)).ToList().ForEach(Dao.Add);
        }
    }
}
