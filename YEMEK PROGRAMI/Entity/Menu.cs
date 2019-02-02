using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YEMEK_PROGRAMI.Entity
{
    class Menu
    {
        [Key]
        [Column("id")]
        public virtual int Id { get; set; }

        [Column("tarih")]
        public DateTime Tarih { get; set; }

    }
}
