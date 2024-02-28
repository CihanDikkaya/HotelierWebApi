using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelier.DTOLayer.DTOS.RoomDTO
{
    public class UpdateRoomDTO
    {
        public int RoomID { get; set; }

        [Required(ErrorMessage = "Lütfen oda numarasını giriniz.")]
        public string RoomNumber { get; set; }

        [Required(ErrorMessage = "Lütfen oda görseli giriniz.")]
        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "lütfen fiyat bilgisi giriniz.")]
 
        public int Price { get; set; }

        [Required(ErrorMessage = "lütfen oda bilgisi giriniz.")]
        [StringLength(100,ErrorMessage ="lütfen en fazla 100 karakter kulanınız.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "lütfen yatak sayısı giriniz.")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "lütfen banyo sayısı giriniz.")]
        public string BathCount { get; set; }

        public string Wifi { get; set; }

        [Required(ErrorMessage = "Lütfen oda açıklamasını giriniz.")]
        public string Description { get; set; }
    }
}
