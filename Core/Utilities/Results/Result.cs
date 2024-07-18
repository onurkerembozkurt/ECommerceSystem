using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public bool Success {  get; }

        public string Message {get; }
        public Result(bool success,string message):this(success)
        {
                
                Message = message;
            //if it a variable is readonly, it can set in constructor
        }
        public Result(bool success)
        {
                Success=success;
        }
    }
}
