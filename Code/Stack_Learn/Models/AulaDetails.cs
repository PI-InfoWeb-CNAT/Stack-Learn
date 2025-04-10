﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Modelos.Models;

namespace Stack_Learn.Models
{
    public class AulaDetails
    {
        public long? AulaId { get; set; }
        public int Ordem { get; set; }
        public string Titulo { get; set; }
        public long Duracao { get; set; }
        public List<Aula> Aulas { get; set; }
        public long? CursoId { get; set; }
        public Curso Curso { get; set; }
        public long? ConclusaoId { get; set; }
        public Conclusao Conclusao { get; set; }
        public Boolean TrueFalse { get; set; }
        public long? AlunoId { get; set; }
        public CursosUsuarios curso_usuario { get; set; }
    }
}