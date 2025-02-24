using System.ComponentModel.DataAnnotations;

namespace MvcProject.Models
{
    public class HeThongPhanPhoi
    {
        // Thuộc tính mã hệ thống phân phối
        public required string MaHTPP { get; set; }

        // Thuộc tính tên hệ thống phân phối
        public required string TenHTPP { get; set; }
    }
}
