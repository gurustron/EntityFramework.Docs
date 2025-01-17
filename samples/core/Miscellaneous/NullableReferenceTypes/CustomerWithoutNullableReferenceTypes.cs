﻿using System.ComponentModel.DataAnnotations;

#nullable disable

namespace NullableReferenceTypes
{
    #region Customer
    public class CustomerWithoutNullableReferenceTypes
    {
        public int Id { get; set; }
        [Required]                               // Data annotations needed to configure as required
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }     // Data annotations needed to configure as required
        public string MiddleName { get; set; }   // Optional by convention
    }
    #endregion
}
