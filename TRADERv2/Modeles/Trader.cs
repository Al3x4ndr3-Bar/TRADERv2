using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRADER.Modeles
{
    internal class Trader
    {
        #region Attributs
        public static List<Trader> CollClasse = new List<Trader>();

        private string _nom;
        private string _prenom;
        private DateTime _dateNaissance;
        private string _sexe;
        private string _email;
        private int _telephone;
        #endregion

        #region Constructeur
        public Trader(string prenom, string nom, DateTime dateNaissance, string sexe, string email, int telephone)
        {
            _nom = nom;
            _prenom = prenom;
            _dateNaissance = dateNaissance;
            _sexe = sexe;
            _email = email;
            _telephone = telephone;

            CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public DateTime DateNaissance { get => _dateNaissance; set => _dateNaissance = value; }
        public string Sexe { get => _sexe; set => _sexe = value; }
        public string Email { get => _email; set => _email = value; }
        public int Telephone { get => _telephone; set => _telephone = value; }
        #endregion

        #region Methodes
        
        #endregion

    }
}
