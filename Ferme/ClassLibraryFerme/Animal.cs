using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Champs
{
    /// <summary>
    /// Fait par Clément
    /// classe qui représente un animal
    /// </summary>
    internal class Animal : Etre
    {
        private uint _nbPattes;
        private string _race;
        private uint _faim = 100; //sur 100%
        /// <summary>
        /// la faim de l'animal en pourcentage
        /// </summary>
        protected uint Faim { get { return _faim; } set { _faim = value; } }

        /// <summary>
        /// le constructeur de l'animal
        /// </summary>
        /// <param name="nom">le nom de l'animal</param>
        /// <param name="nbPattes">le nombre de pattes de l'animal</param>
        /// <param name="race">la race de l'animal</param>
        public Animal(string nom, uint nbPattes, string race) : base(nom)
        {
            _nbPattes = nbPattes;
            _race = race;
        }

        /// <summary>
        /// méthode pour manger
        /// consomme un être vivant et restaure sa faim au complet
        /// </summary>
        /// <param name="repas">l'être à manger</param>
        public virtual void Manger(Etre repas)
        {
            _faim = 100;
            repas.Crever();
        }
    }
}
