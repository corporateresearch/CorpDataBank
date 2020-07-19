using System.ComponentModel.DataAnnotations;


namespace CorpDataBank.Models
{
    public class AdminResponse
    {
        [Required(ErrorMessage = "社名を入力してください。")]
        public string Name { get; set; }
        [Required(ErrorMessage = "登録番号を入力してください。")]
        public string RegistrationNumber { get; set; }
        [Required(ErrorMessage ="住所を入力してください。")]
        public string Address { get; set; }
        [Required(ErrorMessage = "データを登録するかどうか確認してください。")]
        public bool? Agree { get; set; }
    }
}
