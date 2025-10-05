using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITFamily.Models.Entities.Product
{
    public class Product
    {
        [Key()]
        [Display(Name = "شناسه")]
        public int Id { get; set; }

        [Display(Name = "نام محصول")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string? ProductName { get; set; }

        [Display(Name = "قیمت (تومان)")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public float? Price{ get; set; }

        [Display(Name = "درصد تخفیف")]
        public int? Off{ get; set; }

        [Display(Name = "توضیحات محصول")]
        public string? ProductDescription { get; set; }

        //relation        
        public int? CategoryRefId { get; set; }

        [ForeignKey("CategoryRefId")]
        public virtual ProductCategory? Category{ get; set; }
    }
}
