using System.ComponentModel.DataAnnotations;

namespace APIMED.Businnes.ViewModel
{
    public class ContatoViewModel : BaseViewModel
    {
        public string? NomeContato { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DtNascimento { get; set; }
        public string? Sexo { get; set; }
        public bool Ativo { get; set; }
        public int Idade { get; set; }
        public string MsgErro { get; set; }
        public bool Valido { get; set; } = true;
    }
}
