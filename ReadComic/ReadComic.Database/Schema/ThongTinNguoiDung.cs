﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReadComic.DataBase.Schema
{
    [Table("ThongTinNguoiDung")]
    public class ThongTinNguoiDung : TableHaveIdInt
    {
        public ThongTinNguoiDung()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Ten { get; set; }

        public DateTime? NgaySinh { get; set; }

        public bool GioiTinh { get; set; }

        [StringLength(50)]
        public string token_EmailResetPass { get; set; }

        

    }
}