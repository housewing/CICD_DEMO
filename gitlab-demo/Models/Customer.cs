using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace gitlab_demo.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string CusId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string CusName { get; set; }
    }
}
