using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EmployeeDataAccessService.DataContracts {
    [DataContract]
    public class EmployeeContract {
        [DataMember]
        public int Id { get; set; }
        
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Department { get; set; }

        [DataMember]
        public DateTime HireDate { get; set; }

    }
}