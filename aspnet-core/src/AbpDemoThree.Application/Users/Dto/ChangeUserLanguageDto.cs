using System.ComponentModel.DataAnnotations;

namespace AbpDemoThree.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}