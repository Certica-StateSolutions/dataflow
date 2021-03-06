﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataFlow.Models
{
    public partial class DataMap
    {
        public DataMap()
        {
            DataMapAgents = new HashSet<DataMapAgent>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a map name.")]
        [MaxLength(255)]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please select an entity.")]
        public int EntityId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the JSON Map.")]
        public string Map { get; set; }
        public bool Manual { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        [ForeignKey("EntityId")]
        public Entity Entity { get; set; }
        public ICollection<DataMapAgent> DataMapAgents { get; set; }
    }
}
