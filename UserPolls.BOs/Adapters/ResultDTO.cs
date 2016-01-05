using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserPolls.BOs
{
    /// <summary>
    /// Abstracted results set with status and object.
    /// </summary>
    public class ResultsDTO<T>
    {
        public const string ok = "ok";
        public const string error = "error";

        private string _status = ok;

        /// <summary>
        /// Status : ok/error
        /// </summary>
        public string status
        {
            get
            { return _status; }
            set
            {
                _status = value;
            }
        }
        /// <summary>
        /// Message data.
        /// </summary>
        public string message { get; set; }

        /// <summary>
        /// Response result.
        /// </summary>
        public T result { get; set; }
    }
}
