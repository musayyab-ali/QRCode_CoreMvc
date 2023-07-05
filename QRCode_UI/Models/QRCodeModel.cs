using System.ComponentModel.DataAnnotations;

namespace QRCode_UI.Models
{
    public class QRCodeModel
    {
        [Display(Name = "Enter QRCode Text")]
        public string QRCodeText { get; set; }
    }
}
