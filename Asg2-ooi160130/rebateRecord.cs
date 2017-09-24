using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6326Asg2
{
    class rebateRecord : IEquatable<rebateRecord>
    {
        public string firstName;
        public string lastName;
        public string midInit;
        public string addrLine1;
        public string addrLine2;
        public string city;
        public string state;
        public string zipCode;
        public string phoneNumber;
        public string email;
        public bool purchaseProofYes;
        public bool purchaseProofNo;
        public string dateReceived;
        public TimeSpan startTime, endTime;


        public rebateRecord(string fN, string lN, string mI,string addrL1, string addrL2, string cityIn, string st, string zip, string pNumber,string emailAddress, bool purchaseYes, bool purchaseNo, string date, TimeSpan sT, TimeSpan eT)
        {
            firstName = fN;
            lastName = lN;
            midInit = mI;
            addrLine1 = addrL1;
            addrLine2 = addrL2;
            city = cityIn;
            state = st;
            zipCode = zip;
            phoneNumber = pNumber;
            email = emailAddress;
            purchaseProofYes = purchaseYes;
            purchaseProofNo = purchaseNo;
            dateReceived = date;
            startTime = sT;
            endTime = eT;
        }

        public rebateRecord() { }

        public bool Equals(rebateRecord other)
        {
            if (other == null)
                return false;
            return (this.firstName == other.firstName &&
                this.lastName == other.lastName &&
                this.midInit == other.midInit &&
                this.addrLine1 == other.addrLine1 &&
                this.addrLine2 == other.addrLine2 &&
                this.city == other.city &&
                this.state == other.state &&
                this.zipCode == other.zipCode &&
                this.phoneNumber == other.phoneNumber &&
                this.email == other.email &&
                this.purchaseProofYes == other.purchaseProofYes &&
                this.purchaseProofNo == other.purchaseProofNo &&
                this.dateReceived == other.dateReceived);
        }
    }
}
