using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YEMEK_PROGRAMI.Entity
{
    class MenuIc
    {
        [Key]
        [Column("id")]
        public virtual int Id { get; set; }

        [Column("menuid")]
        public int MenuId { get; set; }

        [Column("yemekid")]
        public int YemekId { get; set; }

        [Column("status")]
        public int Status { get; set; }
    }
}
