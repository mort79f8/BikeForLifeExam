using System.ComponentModel.DataAnnotations;

namespace BikeForLife.Entities
{
    public enum Difficulty
    {
        [Display(Name = "Nem")]
        Easy,
        Normal,
        [Display(Name = "Svær")]
        Hard,
        Expert
    }

    public static class DifficultyHelper
    {
        public static string GetDescription(Difficulty diff)
        {
            switch (diff)
            {
                case Difficulty.Easy:
                    return "Nem";
                case Difficulty.Normal:
                    return "Normal";
                case Difficulty.Hard:
                    return "Svær";
                case Difficulty.Expert:
                    return "Expert";
                default:
                    return "";
            }
        }
    }
}