using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapp.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName ="varchar(250)")]
        [Required(ErrorMessage ="this field is required")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }
        [Column(TypeName ="varchar(10)")]
        [DisplayName("Emp. Code")]
        public string EmpCode { get; set; }
        [Column(TypeName ="varchar(100)")]
        public string Position { get; set; }
        [Column(TypeName ="varchar(100)")]
        [DisplayName("Office Location")]
        public string OfficeLocation { get; set; }

    
    }
}