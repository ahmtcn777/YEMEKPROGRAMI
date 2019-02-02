using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YEMEK_PROGRAMI.Entity
{
    public class Yemekler
    {
        [Key]
        [Column("id")]
        public virtual int Id { get; set; }
        
        [Column("yemekAdi")]
        public string YemekAdi { get; set; }

        [Column("fiyat")]
        public double Fiyat { get; set; }

        [Column("status")]
        public int Status { get; set; }

        public override string ToString()
        {
            return YemekAdi;
        }
        public override bool Equals(object obj)
        {
            if (obj is Yemekler yemekler)
                return yemekler.Id == Id;
            return base.Equals(obj);
        }
    }
}
