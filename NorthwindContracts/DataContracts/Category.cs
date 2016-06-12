using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;  
using System.ServiceModel; 

namespace NorthwindContracts.DataContracts
{
    [DataContract] 
    public class Category
    {
        [DataMember] 
        public int CategoryID { get; set; }

        [DataMember] 
        public string CategoryName { get; set; }

        [DataMember] 
        public string CategoryDescription { get; set; }

        [DataMember]
        public string CategoryURL { get; set; }
    }
}
