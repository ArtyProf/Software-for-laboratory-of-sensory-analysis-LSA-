﻿using LSA.Interfaces;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LSA.Entity
{
    public class TastingHistory : IBlock
    {
        [Key]
        public int TastingHistoryId { get; set; }
        public int? TastingHistoryPreviousId { get; set; }
        public Tasting Tasting { get; set; }
        public Taster Taster { get; set; }
        public Product Product { get; set; }
        public int ViewProse { get; set; }
        public int ViewColour { get; set; }
        public int BouquetClean { get; set; }
        public int BouquetIntensity { get; set; }
        public int BouquetQuality { get; set; }
        public int TasteColour { get; set; }
        public int TasteIntensity { get; set; }
        public int TasteAftertaste { get; set; }
        public int TastePotencial { get; set; }
        public int TasteQuality { get; set; }
        public int Garmony { get; set; }
        public int Penalty { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTimeOffset TransactionDate { get; set; }
        [Required]
        [ValidateNever]
        public string Hash { get; set; }
        [NotMapped]
        public bool IsValid { get; set; }
        public virtual TastingHistory Previous { get; set; }
    }
}
