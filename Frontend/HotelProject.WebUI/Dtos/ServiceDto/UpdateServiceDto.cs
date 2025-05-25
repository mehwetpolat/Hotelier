using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceId { get; set; }

        [Required(ErrorMessage = "Hizmet Başlığı Giriniz")]
        [StringLength(100, ErrorMessage = "Hizmet Başlığı En Fazla 100 Karakteri Desteklemektedir")]
        public string ServiceTitle { get; set; }

        [Required(ErrorMessage = "Hizmet Resim Bilgisi Giriniz")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Hizmet Açıklama Bilgisi Giriniz")]
        [StringLength(1000, ErrorMessage = "Hizmet Açıklaması En Fazla 1000 Karakteri Desteklemektedir")]
        public string Description { get; set; }
    }
}
