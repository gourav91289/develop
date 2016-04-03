using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.boutique.Entity.Model
{
    public class Result
    {
        public string ErrorMessage { get; set; }
        public bool IsSuccess { get; set; }
        [NonSerialized]
        public Exception Exception;
    }
}
