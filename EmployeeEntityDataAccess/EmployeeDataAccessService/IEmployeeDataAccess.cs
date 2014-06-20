using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using EmployeeDataAccessService.DataContracts;

namespace EmployeeDataAccessService {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployeeDataAccess" in both code and config file together.
    [ServiceContract]
    public interface IEmployeeDataAccess{
        [OperationContract]
        IEnumerable<EmployeeContract> Fetch();

        [OperationContract]
        EmployeeContract FetchById(int id);

        [OperationContract]
        IEnumerable<EmployeeContract> FetchByName(string name);

        [OperationContract]
        IEnumerable<EmployeeContract> FetchByTitle(string title);

        [OperationContract]
        void Add(DataContracts.EmployeeContract employee);

        [OperationContract]
        void Update(EmployeeContract employee);

        [OperationContract]
        void Delete(EmployeeContract employee);

        [OperationContract]
        void DeleteById(int id);
    }
}
