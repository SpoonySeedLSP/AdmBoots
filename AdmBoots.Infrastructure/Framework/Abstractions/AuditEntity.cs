using System;
using System.ComponentModel.DataAnnotations;
using AdmBoots.Infrastructure.Domain;

namespace AdmBoots.Infrastructure.Framework.Abstractions {

    public class AuditEntity : CreationEntity {
        public int? ModifierId { get; set; }

        [MaxLength(EntityDefault.LongNameLength)]
        public string ModifierName { get; set; }

        public DateTime? ModifyTime { get; set; }
    }
}
