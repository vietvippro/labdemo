using System.ComponentModel.DataAnnotations;
namespace labdemo.Models
{
    public class HinhThuc
    {      
            [Key]
            public Guid ID { get; set; }
            public string TenHinhThuc { get; set; }
    }
}
