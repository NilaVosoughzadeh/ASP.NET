using System.ComponentModel.DataAnnotations;

namespace ITFamily.Models.Entities.Product
{
    public class ProductCategory
    {
        [Key()]
        [Display(Name = "شناسه")]
        public int Id { get; set; }

        [Display(Name = "عنوان دسته بندی")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string? CategoryTitle { get; set; }

        [Display(Name = "ترتیب نمایش")]
        public int? Sort { get; set; }


        [Display(Name = "تصویر")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string? CategoryPhoto { get; set; }

    }
}
