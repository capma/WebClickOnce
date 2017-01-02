using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// ADD START
using System.Runtime.Serialization;
// ADD END

namespace WCF_Northwind.Contract
{
    [DataContract]
    public class CategoryModel
    {
        [DataMember]
        public int CategoryID { get; set; }
        [DataMember]
        public string CategoryName { get; set; }
        [DataMember]
        public string Description { get; set; }
        //[DataMember]
        //public byte[] Picture { get; set; }
    }
}