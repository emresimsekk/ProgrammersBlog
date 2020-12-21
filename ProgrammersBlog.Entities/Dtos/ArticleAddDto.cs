using ProgrammersBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProgrammersBlog.Entities.Dtos
{
    public class ArticleAddDto
    {
        [DisplayName("Başlık")]
        [Required(ErrorMessage = "{0} boş bırakılamaz !")]
        [MaxLength(100, ErrorMessage = "{0} {1} karakterden büyük olamaz !")]
        [MinLength(5, ErrorMessage = "{0} {1} karakterden küçük olamaz !")]
        public string Title { get; set; }


        [DisplayName("İçerik")]
        [Required(ErrorMessage = "{0} boş bırakılamaz !")]
        [MinLength(20, ErrorMessage = "{0} {1} karakterden küçük olamaz !")]
        public string Content { get; set; }

        
        [DisplayName("Thumbnail")]
        [Required(ErrorMessage = "{0} boş bırakılamaz !")]
        [MaxLength(250, ErrorMessage = "{0} {1} karakterden büyük olamaz !")]
        [MinLength(5, ErrorMessage = "{0} {1} karakterden küçük olamaz !")]
        public string Thumbnail { get; set; }

        
        [DisplayName("Tarih")]
        [Required(ErrorMessage = "{0} boş bırakılamaz !")]
        [DisplayFormat(ApplyFormatInEditMode =true,DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [DisplayName("Seo Yazar")]
        [Required(ErrorMessage = "{0} boş bırakılamaz !")]
        [MaxLength(50, ErrorMessage = "{0} {1} karakterden büyük olamaz !")]
        [MinLength(0, ErrorMessage = "{0} {1} karakterden küçük olamaz !")]
        public string SeoAuthor { get; set; }

        [DisplayName("Seo Açıklama")]
        [Required(ErrorMessage = "{0} boş bırakılamaz !")]
        [MaxLength(150, ErrorMessage = "{0} {1} karakterden büyük olamaz !")]
        [MinLength(0, ErrorMessage = "{0} {1} karakterden küçük olamaz !")]
        public string SeoDescription { get; set; }

        [DisplayName("Seo Tags")]
        [Required(ErrorMessage = "{0} boş bırakılamaz !")]
        [MaxLength(70, ErrorMessage = "{0} {1} karakterden büyük olamaz !")]
        [MinLength(0, ErrorMessage = "{0} {1} karakterden küçük olamaz !")]
        public string SeoTags { get; set; }

        [DisplayName("Kategori")]
        [Required(ErrorMessage = "{0} boş bırakılamaz !")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [DisplayName("Aktif Mi ?")]
        [Required(ErrorMessage = "{0} boş bırakılamaz !")]
        public bool IsActive { get; set; }
    }
}
