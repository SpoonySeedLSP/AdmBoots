using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using AdmBoots.Infrastructure.Domain;
using AdmBoots.Infrastructure.Framework.Abstractions;

namespace AdmBoots.Domain.Models {

    [Table("MailSetting")]
    public class MailSetting : Entity {

        /// <summary>
        /// 客户端授权码(可存在配置文件中)
        /// </summary>
        [Required, MaxLength(EntityDefault.FieldsLength50)]
        public string Code { get; set; }

        /// <summary>
        /// 收件人地址(多人)
        /// </summary>
        [Required, MaxLength(EntityDefault.FieldsLength2000)]
        public string To { get; set; }

        /// <summary>
        /// 发件服务器
        /// </summary>
        [Required, MaxLength(EntityDefault.FieldsLength50)]
        public string FrHost { get; set; }

        /// <summary>
        /// 发件人
        /// </summary>
        [Required, MaxLength(EntityDefault.FieldsLength50)]
        public string Fr { get; set; }

        /// <summary>
        /// 抄送地址(多人)
        /// </summary>
        [MaxLength(EntityDefault.FieldsLength2000)]
        public string Cc { get; set; }

        /// <summary>
        /// 是否开启邮件提醒
        /// </summary>
        [Required]
        public bool Notify { get; set; }
    }
}
