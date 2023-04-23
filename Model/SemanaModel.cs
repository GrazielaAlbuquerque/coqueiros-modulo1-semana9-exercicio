using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Semana09.Model
{
    [Table ("Semana")]
    public class SemanaModel
    {
        [Key]
        [Column("Código")]
        public int Id {get; set; }

        [NotNull]
        [Column("Dia")]
        public DateTime DataSemana {get; set;}

        [MaxLength(100)]
        [Column("Contéudo")]
        public string Conteudo {get; set;}

        [NotNull]
        [Column("Aplicação")]
        public bool AplicadoConteudo {get; set; }
    }
}

/*Propriedades da classe
Id Int PK
DataSemana DateTime NOT NULL
Conteudo String Max(100)
AplicadoConteudo Bool NOT NULL*/