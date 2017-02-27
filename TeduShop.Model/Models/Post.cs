﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Posts")]
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [ForeignKey("ID")]
        public virtual OrderDetail OrderDetail { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [Required]
        [MaxLength(256)]
        [Column(TypeName = "varchar")]
        public string Alias { get; set; }

        public int CategoryID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Image { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public string Content { get; set; }
        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }
        public int? ViewCount { get; set; }

        [ForeignKey("CategoryID")]
        public virtual PostCategory PostCategogy { get; set; }
    }
}