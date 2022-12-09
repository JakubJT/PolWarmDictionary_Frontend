using System.ComponentModel.DataAnnotations;

namespace PolWarmDictionary_Frontend.Models;


public class WordGroup
{
    private const string ValidationMessageOnlyLetters = "Nazwa powinna zaczynać się z wielkiej litery i zawierać tylko litery";
    private const string ValidationMessageName = "Pole \"Nazwa\" powinno zawierać od 1 do 16 liter";
    public int WordGroupId { get; set; }
    [Required]
    [StringLength(16, MinimumLength = 2, ErrorMessage = ValidationMessageName)]
    [RegularExpression(@"^[A-ZĄĘÓŃŻŹĆŁŚ]+[a-ząężźćóńłśA-ZĄĘÓŃŻŹĆŁŚ\s]*$", ErrorMessage = ValidationMessageOnlyLetters)]
    public string? Name { get; set; }
    public string? UserADId { get; set; }
    public List<Word>? Words { get; set; }
}