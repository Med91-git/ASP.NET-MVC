﻿using System.ComponentModel.DataAnnotations;

namespace ASP.NET_CORE_MVC.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Contenu { get; set; } 

    }
}
