namespace PolWarmDictionary_Frontend;

public class Sorting
{
    private bool ascendingOrderInPolish { get; set; } = true;
    private bool ascendingOrderInWarmian { get; set; } = false;
    private bool ascendingOrderPartOfSpeech { get; set; } = false;

    public (string, bool) Sort(string sortBy, (string SortBy, bool AscendingOrder) sortOptions)
    {
        sortOptions.SortBy = sortBy;
        switch (sortBy)
        {
            case "InPolish":
                if (ascendingOrderInPolish)
                {
                    sortOptions.AscendingOrder = false;
                    ascendingOrderInPolish = false;
                    return sortOptions;
                }
                else
                {
                    sortOptions.AscendingOrder = true;
                    ascendingOrderInPolish = true;

                    ascendingOrderInWarmian = false;
                    ascendingOrderPartOfSpeech = false;

                    return sortOptions;
                }
            case "InWarmian":
                if (ascendingOrderInWarmian)
                {
                    sortOptions.AscendingOrder = false;
                    ascendingOrderInWarmian = false;
                    return sortOptions;
                }
                else
                {
                    sortOptions.AscendingOrder = true;
                    ascendingOrderInWarmian = true;

                    ascendingOrderInPolish = false;
                    ascendingOrderPartOfSpeech = false;
                    return sortOptions;
                }
            case "PartOfSpeech":
                if (ascendingOrderPartOfSpeech)
                {
                    sortOptions.AscendingOrder = false;
                    ascendingOrderPartOfSpeech = false;
                    return sortOptions;
                }
                else
                {
                    sortOptions.AscendingOrder = true;
                    ascendingOrderPartOfSpeech = true;

                    ascendingOrderInPolish = false;
                    ascendingOrderInWarmian = false;
                    return sortOptions;
                }
            default:
                return sortOptions;
        }
    }
}