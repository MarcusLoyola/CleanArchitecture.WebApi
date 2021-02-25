using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    [Table("PRODUTO")]
    public class Product : AuditableBaseEntity
    {
        [Column("Nome")]
        public string Name { get; set; }
        
        [Column("CodigoDeBarras")]
        public string Barcode { get; set; }
        
        [Column("Descricao")]
        public string Description { get; set; }
        
        [Column("Taxa")]
        public decimal Rate { get; set; }
    }
}
