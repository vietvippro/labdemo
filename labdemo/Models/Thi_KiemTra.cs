using System.ComponentModel.DataAnnotations;
namespace labdemo.Models
{
    public class Thi_KiemTra
    {
        [Key]
        public Guid ID { get; set; }
        public Lophoc Lop { get; set; }
        public DateTime NgayKiemTra { get; set; }
        public MonHoc MonHoc { get; set; }
        public string NoiDung { get; set; }
        public HinhThuc HinhThuc { get; set; }
        public long ThoiLuong { get; set; }
        public string MoTa { get; set; }
        public string FilePath { get; set; }
        public string Status { get; set; }
    }
}
