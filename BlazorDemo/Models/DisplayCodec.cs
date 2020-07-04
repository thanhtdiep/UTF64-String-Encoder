using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo.Models
{
    public class DisplayCodec
    {
        [Required]
        [StringLength(45, ErrorMessage = "Encode String is too long.")]
        [MinLength(0, ErrorMessage = "Encode String is too short.")]
        public string EncodeString { get; set; }

        [StringLength(200, ErrorMessage = "Decode String is too long.")]
        [MinLength(0, ErrorMessage = "Decode String is too short.")]
        public string DecodeString { get; set; }

        public string Status { get; set; }
    }
}
