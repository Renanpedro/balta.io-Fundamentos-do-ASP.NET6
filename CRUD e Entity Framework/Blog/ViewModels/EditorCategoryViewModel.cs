﻿using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels
{
    public class EditorCategoryViewModel
    {
        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "Este campo deve conter de 3 a 40 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Slug é obrigatório")]
        public string Slug { get; set; }
    }
}
