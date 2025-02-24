using System.ComponentModel.DataAnnotations;

namespace MvcProject.Models
{
    public class Daily : HeThongPhanPhoi
    {
        // Thuộc tính mã hệ thống phân phối
        public required string MaDaiLy { get; set; }

        // Thuộc tính tên hệ thống phân phối
        public required string TenDaiLy { get; set; }
        public required string DiaChi{ get; set; }
        public required string NguoiDaiDien { get; set; }
        public required string DienThoai { get; set; }       
        
    }
}
