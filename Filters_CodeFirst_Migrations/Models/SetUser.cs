using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Filters_CodeFirst_Migrations.Models
{
    [Table("SiteUsers")]
    public class SetUser
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required,StringLength(20),DisplayName("Ad")]
        public string Name { get; set; }
        [Required, StringLength(30), DisplayName("Soyad")]
        public string Surname { get; set; }
        [Required, StringLength(20), DisplayName("Kullanıcı Adı")]
        public string Username { get; set; }
        [Required, StringLength(16), DisplayName("Şifre"),DataType(DataType.Password)]
        public string Password { get; set; }

    }
}