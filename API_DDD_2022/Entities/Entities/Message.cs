﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [Table("TB_MESSAGE")]
    public class Message:Notifies
    {
        [Column("MSN_ID")]
        public int Id { get; set; }

        [Column("MSN_TITLE")]
        [MaxLength(255)]
        public string Title { get; set; }

        [Column("MSN_ACTIVE")]
        public bool Active { get; set; }

        [Column("MSN_DATE_REGISTER")]
        public DateTime DateRegister { get; set; }

        [Column("MSN_DATE_UPDATE")]
        public DateTime DateUpdate { get; set; }

        [ForeignKey("ApplicationUser")]
        [Column(Order = 1)]
        public string UserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}
