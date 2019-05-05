using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class SecurityPrecautions
    {
        private string securityMeasureDescription;

        public string SecurityMeasureDescription
        {
            get { return securityMeasureDescription; }
            set { securityMeasureDescription = value; }
        }

        private string alertType;

        public string AlertType
        {
            get { return alertType; }
            set { alertType = value; }
        }

        private string alertMessage;

        public string AlertMessage
        {
            get { return alertMessage; }
            set { alertMessage = value; }
        }

        public SecurityPrecautions(string securityMeasureDescription, string alertType, string alertMessage)
        {
            this.securityMeasureDescription = securityMeasureDescription;
            this.alertMessage = alertMessage;
            this.alertType = alertType;
        }


        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
