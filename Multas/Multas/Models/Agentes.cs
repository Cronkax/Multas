using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Multas.Models{
    public class Agentes{

        public int ID { get; set; }

        [Required(ErrorMessage ="Por favor escreva o Nome do Agente.")]
        //([A-ZÁÉÌÓÚa-záéíóúàèìòùãõâêîôûçñ]+( |-|')?)+
        [RegularExpression("([A-ZÁÉÌÓÚa-záéíóúàèìòùãõâêîôûçñ]+( |-|')?)+", 
            ErrorMessage = "Só pode escrever letras no nome.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Não se esqueça de escrever a Esquadra onde o Agente trabalha, por favor.")]
        [RegularExpression("([A-ZÁÉÌÓÚa-záéíóúàèìòùãõâêîôûçñ]+( |-|')?)+",
            ErrorMessage = "Só pode escrever letras no nome.")]
        public string Esquadra { get; set; }

        public string Fotografia { get; set; }

        //identifica as multas passadas pelo Agente

        public ICollection<Multas> ListaDasMultas { get; set; }
    }
}