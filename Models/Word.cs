using System.ComponentModel.DataAnnotations;

namespace PolWarmDictionary_Frontend.Models;
public class Word
{
    public int Id { get; set; }

    private const string ValidationMessageWarmian = "Pole \"Po warmińsku\" powinno zawierać od 1 do 16 liter";
    private const string ValidationMessagePolish = "Pole \"Po polsku\" powinno zawierać od 1 do 16 liter";
    private const string ValidationMessageOnlyLetters = "Teskt powinnien zaczynać się z wielkiej litery i zawierać tylko litery";

    [Required]
    [StringLength(16, MinimumLength = 2, ErrorMessage = ValidationMessageWarmian)]
    [RegularExpression(@"^[A-ZĄĘÓŃŻŹĆ]+[a-ząężźćóńA-ZĄĘÓŃŻŹĆ\s]*$", ErrorMessage = ValidationMessageOnlyLetters)]
    public string? InWarmian { get; set; }

    [Required]
    [StringLength(16, MinimumLength = 2, ErrorMessage = ValidationMessagePolish)]
    [RegularExpression(@"^[A-ZĄĘÓŃŻŹĆ]+[a-ząężźćóńA-ZĄĘÓŃŻŹĆ\s]*$", ErrorMessage = ValidationMessageOnlyLetters)]
    public string? InPolish { get; set; }

    [Required]
    public string? PartOfSpeech { get; set; }
}