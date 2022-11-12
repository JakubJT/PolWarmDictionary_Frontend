using System.ComponentModel.DataAnnotations;

namespace PolWarmDictionary_Frontend.Models;
public class Word
{
    public int Id { get; set; }

    private const string ValidationMessageWarmian = "Pole \"Po warmińsku\" powinno zawierać od 1 do 16 liter";
    private const string ValidationMessagePolish = "Pole \"Po polsku\" powinno zawierać od 1 do 16 liter";
    private const string ValidationMessageOnlyLetters = "Teskt powinnien zaczynać się z wielkiej litery i zawierać tylko litery";
    private const string ValidationMessagePartOfSpeech = "Pole \"Część mowy\" jest wymagane";

    [Required]
    [StringLength(16, MinimumLength = 2, ErrorMessage = ValidationMessageWarmian)]
    [RegularExpression(@"^[A-ZĄĘÓŃŻŹĆŁ]+[a-ząężźćóńłA-ZĄĘÓŃŻŹĆŁ\s]*$", ErrorMessage = ValidationMessageOnlyLetters)]
    public string? InWarmian { get; set; }

    [Required]
    [StringLength(16, MinimumLength = 2, ErrorMessage = ValidationMessagePolish)]
    [RegularExpression(@"^[A-ZĄĘÓŃŻŹĆŁ]+[a-ząężźćóńłA-ZĄĘÓŃŻŹĆŁ\s]*$", ErrorMessage = ValidationMessageOnlyLetters)]
    public string? InPolish { get; set; }

    [Required(ErrorMessage = ValidationMessagePartOfSpeech)]
    public int? PartOfSpeechId { get; set; }
    public string? PartOfSpeech { get; set; }
}