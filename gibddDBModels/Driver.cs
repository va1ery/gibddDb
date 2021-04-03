using System;
using System.ComponentModel.DataAnnotations;

namespace gibddDBModels
{
    public class Driver : FullAuditModel
    {
        //       public int Id { get; set; }
        [StringLength(gibddDBModelsConstants.MAX_NAME_LENGTH)]
        public string firstName { get; set; }
        [StringLength(gibddDBModelsConstants.MAX_NAME_LENGTH)]
        public string lastName { get; set; }
        [StringLength(gibddDBModelsConstants.MAX_NAME_LENGTH)]
        public string middleName { get; set; }
        public string passportNumber { get; set; }
        public string postcode { get; set; }
        public string address { get; set; }
        public string company { get; set; }
        public string jobname { get; set; }
        [StringLength(gibddDBModelsConstants.MAX_PHONE_LENGTH)]
        public string phone { get; set; }
        public string email { get; set; }
        public string photo { get; set; }
        [StringLength(gibddDBModelsConstants.MAX_DESCRIPTION_LENGTH)]
        public string description { get; set; }
    }
}
