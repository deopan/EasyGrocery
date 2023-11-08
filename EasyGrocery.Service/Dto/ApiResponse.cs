using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESasyGrocery.Service.Dto
{
    public class ApiResponse<T>
    {
        public T Data { get; set; }
        public int StatusCode { get; set; }
        public bool HasError { get; set; }
        public string Error { get; set; }
    }
}
