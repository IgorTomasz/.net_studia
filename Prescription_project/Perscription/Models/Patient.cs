﻿using System.ComponentModel.DataAnnotations;

namespace Perscription.Models
{
    public class Patient
    {
        [Key]
        public int IdPatient { get; set; }
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; } = null!;
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; } = null!;
        [Required]
        public DateTime BirthDate { get; set; }
        public virtual ICollection<Prescription> PatientsPresciption { get; set; }
    }
}
