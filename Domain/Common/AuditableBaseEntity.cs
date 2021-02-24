using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Common
{
    public abstract class AuditableBaseEntity
    {
        public virtual int Id { get; set; }

        [Column("CriadoPor")]
        public string CreatedBy { get; set; }

        [Column("Criacao")]
        public DateTime Created { get; set; }

        [Column("ModificadoPor")]
        public string LastModifiedBy { get; set; }

        [Column("Modificacao")]
        public DateTime? LastModified { get; set; }
    }
}
