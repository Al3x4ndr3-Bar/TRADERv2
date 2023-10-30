using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRADER.Modeles
{
    internal class Transaction
    {
        #region Attributs
        public static List<Transaction> CollClasse = new List<Transaction>();

        private string _nomTrader;
        private string _nomAction;
        private int _nbAction;
        private double _prix;
        private DateTime _date;
        #endregion

        #region Constructeur

        public Transaction(string nomTrader, string nomAction, int nbAction, double prix, DateTime date)
        {
            _nomTrader = nomTrader;
            _nomAction = nomAction;
            _nbAction = nbAction;
            _prix = prix;
            _date = date;

            CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters
        public string NomTrader { get => _nomTrader; set => _nomTrader = value; }
        public string NomAction { get => _nomAction; set => _nomAction = value; }
        public int NbAction { get => _nbAction; set => _nbAction = value; }
        public double Prix { get => _prix; set => _prix = value; }
        public DateTime Date { get => _date; set => _date = value; }
        #endregion

        #region Methodes
        // Tes méthodes ici...
        #endregion

    }
}
