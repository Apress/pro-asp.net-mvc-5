using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace HelperMethods.Models {

    [DisplayName("New Person")]
    public partial class PersonMetaData {
        [HiddenInput(DisplayValue = false)]
        public int PersonId { get; set; }

        [Display(Name = "First")]
        public string FirstName { get; set; }

        [Display(Name = "Last")]
        public string LastName { get; set; }

        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Approved")]
        public bool IsApproved { get; set; }
    }
}
