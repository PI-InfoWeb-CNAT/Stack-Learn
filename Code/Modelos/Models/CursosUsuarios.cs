﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelos.Models
{
    public class CursosUsuarios
    {
        public long? CursosUsuariosId { get; set; }
        public long? AlunoId { get; set; }
        public long? ProfessorId { get; set; }
        public List<Curso> Cursos {get; set; }
        public List<Categoria> Categorias { get; set; }
    }
}