using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRADER.Modeles
{
    internal class Actionn
    {
        #region Attributs
        public static List<Actionn> CollClasse = new List<Actionn>();

        private string _societe;
        private string _isin;
        private double _prixInitial;
        #endregion

        #region Constructeur
        public Actionn(string societe, string isin, double prixInitial)
        {
            _societe = societe;
            _isin = isin;
            _prixInitial = prixInitial;

            CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters
        public string Societe { get => _societe; set => _societe = value; }
        public string Isin { get => _isin; set => _isin = value; }
        public double PrixInitial { get => _prixInitial; set => _prixInitial = value; }
        #endregion

        #region Methodes
        // Tes méthodes ici...
        #endregion

    }
}
