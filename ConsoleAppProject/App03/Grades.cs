using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// Grade A is First Class   : 70 - 100
    /// Grade B is Upper Second  : 60 - 69
    /// Grade C is Lower Second  : 50 - 59
    /// Grade D is Third Class   : 45 - 49
    /// Grade E is Ordinary Degree: 40 - 45
    /// Grade F is Fail          :  0 - 39
    /// </summary>
    public enum Grades
    {
        [Display(Name = "Unknown")]
        [Description("Incorrect Value")]
        NoGrade,
        [Display(Name = "Fail")]
        [Description("Referred")]
        F,
        [Display(Name = "Pass")]
        [Description("Ordinary Degree")]
        E,
        [Display(Name = "III")]
        [Description("BSc(Hons) Third Class")]
        D,
        [Display(Name = "II-2")]
        [Description("BSc(Hons) Lower Second")]
        C,
        [Display(Name = "II-1")]
        [Description("BSc(Hons) Upper Second")]
        B,
        [Display(Name = "1st")]
        [Description("BSc(Hons) First Class")]
        A
    }
}
