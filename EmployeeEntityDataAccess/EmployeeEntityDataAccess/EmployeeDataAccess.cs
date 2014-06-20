using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeEntityDataAccess {
    public class EmployeeDataAccess : IDisposable {

        public EmployeeDataAccess() : this(new EmployeeDBEntities()){
            
        }

        public EmployeeDataAccess(EmployeeDBEntities entities){
            Context = entities;
        }

        protected EmployeeDBEntities Context { get; set; }

        public IEnumerable<EmployeeDataTransfer> Fetch(){
            return Context.Employees.ToDataTransfers();
        }
        
        public EmployeeDataTransfer Fetch(int id) {
            return Context.Employees.Find(id).ToDataTransfer();
        }

        public IEnumerable<EmployeeDataTransfer> Fetch(string name) {
            return Context.Employees.Where(e => e.Name.Contains(name)).ToDataTransfers();
        }

        public IEnumerable<EmployeeDataTransfer> FetchByTitle(string title) {
            return Context.Employees.Where(e => e.Name.Contains(title)).ToDataTransfers();
        }

        public void Add(EmployeeDataTransfer employee){
            Context.Employees.Add(employee.ToEntity());
            Context.SaveChanges();
        }

        public void Update(EmployeeDataTransfer employee){
            var entity = Context.Employees.Find(employee.Id);
            if (entity != null){
                entity.DeepCopy(employee);
                Context.SaveChanges();
            }
        }

        public void Delete(EmployeeDataTransfer employee) {
            var entity = Context.Employees.Find(employee.Id);
            if (entity != null) {
                Context.Employees.Remove(entity);
                Context.SaveChanges();
            }
        }

        public void Delete(int id) {
            var entity = Context.Employees.Find(id);
            if (entity != null) {
                Context.Employees.Remove(entity);
                Context.SaveChanges();
            }
        }

        public void Dispose(){
            Context.Dispose();
        }
    }
}
