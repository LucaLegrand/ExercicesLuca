﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceLinqLicornes
{
    public class Licorne : Animal
    {    
        public string Couleur { get; set; }
        public int Age { get; set; }
        public List<string> ListePeronnalites { get; set; }

        public static Licorne FaireUnBebe(Licorne licorne1, Licorne licorne2)
        {
            return new Licorne() { Couleur = licorne1.Couleur + licorne2.Couleur };
        }

        public static Licorne Fusiiioooon(Licorne licorne1, Licorne licorne2)
        {
            return new Licorne() { Couleur = licorne1.Couleur + licorne2.Couleur, ListePeronnalites = licorne1.ListePeronnalites.Concat(licorne2.ListePeronnalites).ToList() };
        }
    }
}
