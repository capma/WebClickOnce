using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// ADD START
using WCF_Northwind.Contract;
// ADD END

namespace WCF_Northwind
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "INorthwindService" in both code and config file together.
    [ServiceContract]
    public interface INorthwindService
    {
        [OperationContract]
        List<CategoryModel> GetAllCategories();

        [OperationContract]
        List<ProductModel> GetAllProducts();      

        [OperationContract]
        List<ProductModel> GetProductByCategoryID(int CategoryID);



    }
}
