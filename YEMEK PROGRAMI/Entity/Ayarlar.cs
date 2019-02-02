using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YEMEK_PROGRAMI.Entity
{
    class Ayarlar
    {
        [Key]
        [Column("id")]
        public virtual int Id { get; set; }

        [Column("company")]
        public string Company { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("azTabak")]
        public double AzTabak { get; set; }

        [Column("tamTabak")]
        public double TamTabak { get; set; }

        [Column("description1")]
        public string Description1 { get; set; }

        [Column("description2")]
        public string Description2 { get; set; }
    }
}
