using System.ComponentModel.DataAnnotations;
namespace labdemo.Models
{
    public class DiemSV
    {
        [Key]
        public Guid ID { get; set; }
        public User SinhVien { get; set; }
        public DateTime NgayKiemTra { get; set; }
        public Lophoc Lop { get; set; }
        public MonHoc MonHoc { get; set; }
        public HinhThuc HinhThuc { get; set; }
        public string FilePath { get; set; }
        public double Diem { get; set; }
        public string NhanXet { get; set; }
    }
}
