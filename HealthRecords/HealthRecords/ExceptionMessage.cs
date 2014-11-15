using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthRecords
{

    class ExceptionMessage
    {

        private int status;
        public int Status {
            get
            {
                return this.status;
            }
            set
            {
                // anzahl der werte
                if (value <= 5 && value >= 0)
                {
                    this.status = value;
                }
            }
        }
        public Exception Exception { get; set; }

        public ExceptionMessage()
        {
            this.status = 0;
            this.Exception = null;
        }

        public ExceptionMessage(int status, Exception exception)
        {
            this.Status = status;
            this.Exception = exception;
        }

    }

}
