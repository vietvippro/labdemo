using System.ComponentModel.DataAnnotations;
namespace labdemo.Models
{
    public class Lophoc
    {
        [Key]
        public Guid ID { get; set; }
        public string TenLop { get; set; }
        public string MoTa { get; set; }
        public User GiangVien { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string ThoiLuong { get; set; }
        public string Status { get; set; }
        public KhoaHoc KhoaHoc { get; set; }
    }   
}
