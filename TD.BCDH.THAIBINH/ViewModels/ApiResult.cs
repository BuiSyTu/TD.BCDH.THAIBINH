using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD.BCDH.THAIBINH.ViewModels
{
    public class ApiResult<T>
    {
        public T data;
        public double total;
        public Error err;
    }

    public class Error
    {
        public string code;
        public string internalMessage;
        public string userMessage;
    }
}
