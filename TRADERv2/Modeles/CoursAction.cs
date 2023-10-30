using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRADER.Modeles
{
    internal class CoursAction
    {
        #region Attributs
        public static List<CoursAction> CollClasse = new List<CoursAction>();

        private DateTime _date;
        private double _prix;

        #endregion

        #region Constructeur
        public CoursAction(DateTime date, double prix)
        {
            _date = date;
            _prix = prix;

            CollClasse.Add(this);
        }


        #endregion

        #region Getters/Setters
        public DateTime Date { get => _date; set => _date = value; }
        public double Prix { get => _prix; set => _prix = value; }
        #endregion

        #region Methodes
        // Tes méthodes ici...
        #endregion

    }
}
