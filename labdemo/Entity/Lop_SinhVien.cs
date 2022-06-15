using System.ComponentModel.DataAnnotations;
namespace labdemo.Models
{
    public class Lop_SinhVien
    {
        [Key]
        public Guid ID { get; set; }
        public Lophoc Lop { get; set; }
        public User SinhVien { get; set; }
    }
}
