using System.ComponentModel.DataAnnotations;

namespace QuanLySinhVien.Models
{
    public class SinhVien
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Mã sinh viên không được để trống")]
        [Display(Name = "Mã sinh viên")]
        public string MaSinhVien { get; set; }

        [Required(ErrorMessage = "Họ tên không được để trống")]
        [Display(Name = "Họ tên")]
        public string HoTen { get; set; }

        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        public DateTime NgaySinh { get; set; }

        [Display(Name = "Giới tính")]
        public string GioiTinh { get; set; }

        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; }

        [Display(Name = "Số điện thoại")]
        public string SoDienThoai { get; set; }

        [Display(Name = "Địa chỉ")]
        public string DiaChi { get; set; }
    }
}