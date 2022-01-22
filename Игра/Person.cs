using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;

namespace Игра
{
   class Person
   {
        public ObjectId Id { get; set; }
        public string _name;
        public string _surname;
        public string _othestvo;
        public string _gender;
        public int _ageHappy;
        public int _numbersGroup;
        public int _averageScore;
        public bool _commerce;
        public int _payment;
        public string _activity;


        public Person(string name, string surname, string gender, string othestvo, int ageHappy, int numbersGroup, int averageScore, bool commerce, int payment, string activity)
        {
            this._name = name;
            this._surname = surname;
            this._gender = gender;
            this._othestvo = othestvo;
            this._ageHappy = ageHappy;
            this._numbersGroup = numbersGroup;
            this._averageScore = averageScore;
            this._commerce = commerce;
            this._payment = payment;
            this._activity = activity;
        }
    }
}
