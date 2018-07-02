using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperHero.Models
{
    public class Superhero
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string AlterEgo { get; set; }
        public int PrimaryAbility { get; set; }
        public int SecondaryAbility { get; set; }
        public int Catchprase { get; set; }

    }
}