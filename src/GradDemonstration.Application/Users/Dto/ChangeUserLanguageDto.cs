using System.ComponentModel.DataAnnotations;

namespace GradDemonstration.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}