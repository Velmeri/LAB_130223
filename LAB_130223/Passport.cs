using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_130223
{
    internal class Passport
    {
        public string CitizenName { get; set; }
        public string PassportNumber { get; set; }
        public string IssuingCountry { get; set; }
        public DateTime IssuanceDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        public virtual string GetPassportInformation()
        {
            return $"Name: {CitizenName}\nPassport Number: {PassportNumber}\nIssuing Country: {IssuingCountry}\nIssuance Date: {IssuanceDate:dd/MM/yyyy}\nExpiration Date: {ExpirationDate:dd/MM/yyyy}";
        }
    }

    internal class ForeignPassport : Passport
    {
        public string VisaNumber { get; set; }
        public string ForeignPassportNumber { get; set; }

        public override string GetPassportInformation()
        {
            return $"{base.GetPassportInformation()}\nVisa Number: {VisaNumber}\nForeign Passport Number: {ForeignPassportNumber}";
        }
    }
}
