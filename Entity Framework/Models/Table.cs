namespace Entity_Framework.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Table")]
    public partial class Table
    {
        [Key]
        [Column("Product Id")]
        [StringLength(50)]
        public string Product_Id { get; set; }

        [Column("Product Name")]
        [Required]
        [StringLength(50)]
        public string Product_Name { get; set; }

        [Column("Product Quantity")]
        public int Product_Quantity { get; set; }

        [Column("Product Price")]
        public int Product_Price { get; set; }

        [Column("Product Class")]
        [Required]
        [StringLength(50)]
        public string Product_Class { get; set; }
    }
}
