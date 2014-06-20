using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using EmployeeDataAccessService.DataContracts;
using EmployeeEntityDataAccess;

namespace EmployeeDataAccessService {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeDataAccess" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeDataAccess.svc or EmployeeDataAccess.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeDataAccess : IEmployeeDataAccess {
        public EmployeeDataAccess(){
            Repository = new EmployeeEntityDataAccess.EmployeeDataAccess();
        }
        private EmployeeEntityDataAccess.EmployeeDataAccess Repository { get; set; }

        public IEnumerable<EmployeeContract> Fetch(){
            return Repository.Fetch().ToContracts();
        }

        public EmployeeContract FetchById(int id){
            return Repository.Fetch(id).ToContract();
        }

        IEnumerable<EmployeeContract> IEmployeeDataAccess.FetchByName(string name){
            return Repository.Fetch(name).ToContracts();
        }

        public IEnumerable<EmployeeContract> FetchByTitle(string title){
            return Repository.FetchByTitle(title).ToContracts();
        }

        public void Add(EmployeeContract employee){
            Repository.Add(employee.ToEntity());
        }

        public void Update(EmployeeContract employee){
            Repository.Update(employee.ToEntity());
        }

        public void Delete(EmployeeContract employee){
            Repository.Delete(employee.ToEntity());
        }

        public void DeleteById(int id){
            Repository.Delete(id);
        }
    }
}
