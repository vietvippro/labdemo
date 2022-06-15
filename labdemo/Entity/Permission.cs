using System.ComponentModel.DataAnnotations;
namespace labdemo.Models
{
    public class Permission
    {
        [Key]
        public Guid ID { get; set; }
        public string Permission_Name { get; set; }
    }
}
