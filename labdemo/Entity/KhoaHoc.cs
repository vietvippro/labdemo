﻿using System.ComponentModel.DataAnnotations;
namespace labdemo.Models
{
    public class KhoaHoc
    {
        [Key]
        public Guid ID { get; set; }
        public string TenKhoaHoc { get; set; }
        public string NienKhoaHoc { get; set; }
    }
}
