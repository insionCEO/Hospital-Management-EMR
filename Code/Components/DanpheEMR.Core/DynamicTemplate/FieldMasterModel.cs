﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanpheEMR.Core.DynamicTemplate
{
    public class FieldMasterModel
    {
        [Key]
        public int FieldMasterId { get; set; }
        public int TemplateTypeId { get; set; }
        public string FieldName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsCompulsoryField { get; set; }

    }
}
