﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        public int RoomId { get; set; }
        [Required(ErrorMessage = "Lütfen oda numarasını giriniz")]
        public string RoomNumber { get; set; }

        [Required(ErrorMessage = "Lütfen oda görseli giriniz")]
        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Lütfen fiyat bilgisini giriniz")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Lütfen oda başlığı bilgisini giriniz")]
        [StringLength(100, ErrorMessage = "Başlık en fazla 100 karakter olabilir")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lütfen yatak sayısı giriniz")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Lütfen banyo sayısı giriniz")]
        public string BathCount { get; set; }

        public string Wifi { get; set; }

        [Required(ErrorMessage = "Lütfen açıklama bilgisini giriniz")]
        public string Description { get; set; }
    }
}
