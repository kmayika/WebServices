using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyServiceLibrary
{
    [ServiceContract]
    public interface IMyLibraryService
    {
        [OperationContract]
        string GetData();
        [OperationContract]
        int Multiply(int a, int b);
    }
}
