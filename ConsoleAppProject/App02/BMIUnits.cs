using System.ComponentModel.DataAnnotations;

namespace ConsoleAppProject.App02
{
    public enum BMIUnits
    {
        [Display(Name = "No Unit")]
        NoUnit,
        CENTIMETRES,
        INCHES,
        FEET,
        POUNDS,
        STONES,
        KILOGRAMS
    }
}
