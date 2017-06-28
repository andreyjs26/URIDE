using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.ComponentModel;

namespace URIDE.Models
{
   public class User
    {
        private int _id;
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get{return _id;}
            set{this._id = value; OnPropertyChanged(nameof(Id)); }
        }
        private string _name;
        [NotNull]
        public string name
        {
            get{return _name; }
            set{this._name = value; OnPropertyChanged(nameof(name));}
        }
        private string _lastName;
        [NotNull]
        public string lastName
        {
            get { return _lastName; }
            set { this._lastName = value; OnPropertyChanged(nameof(lastName)); }
        }
        private string _email;
        [NotNull]
        public string email
        {
            get { return _email; }
            set { this._email = value; OnPropertyChanged(nameof(email)); }
        }
        private string _password;
        [NotNull]
        public string password
        {
            get { return _password; }
            set { this._password = value; OnPropertyChanged(nameof(password)); }
        }
        private string _residence;
        [NotNull]
        public string residence
        {
            get { return _residence; }
            set { this._residence = value; OnPropertyChanged(nameof(residence)); }
        }
        private string _destination;
        [NotNull]
        public string destination
        {
            get { return _destination; }
            set { this._destination = value; OnPropertyChanged(nameof(destination)); }
        }
        private TimeSpan _entrance;
        [NotNull]
        public TimeSpan entrance
        {
            get { return _entrance; }
            set { this._entrance = value; OnPropertyChanged(nameof(entrance)); }
        }
        private TimeSpan _exit;
        [NotNull]
        public TimeSpan exit
        {
            get { return _exit; }
            set { this._exit = value; OnPropertyChanged(nameof(exit)); }
        }
        private bool _discapacity;
        [NotNull]
        public bool discapacity
        {
            get { return _discapacity; }
            set { this._discapacity = value; OnPropertyChanged(nameof(discapacity)); }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this,
              new PropertyChangedEventArgs(propertyName));
        }

    }
}
