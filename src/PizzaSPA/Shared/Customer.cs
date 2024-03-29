﻿using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using PizzaSPA.Shared.Annotations;

namespace PizzaSPA.Shared
{
    public class Customer : INotifyDataErrorInfo, INotifyPropertyChanged
    {
        private string _name;
        public int Id { get; set; }

        public string Name
        {
            get => _name;
            set { _name = value;  OnPropertyChanged();}
        }

        private string _street;
        public string Street
        {
            get => _street;
            set { _street = value; OnPropertyChanged(); }
        }
        private string _city;
        public string City
        {
            get => _city;
            set { _city = value; OnPropertyChanged(); }
        }


        public Order Order { get; set; }

        #region others
        public IEnumerable GetErrors(string propertyName)
        {
            if (string.IsNullOrEmpty(propertyName) || propertyName == nameof(Name))
            {
                if (string.IsNullOrEmpty(Name))
                    yield return "Имя должно быть заполнено";
                else if (Name.Contains("Пицца")) yield return "Имя не должно содержать Пицца";
            }


            if (string.IsNullOrEmpty(propertyName) || propertyName == nameof(Street))
                if (string.IsNullOrEmpty(Street))
                    yield return "Улица должна быть заполнена";
            if (string.IsNullOrEmpty(propertyName) || propertyName == nameof(City))
                if (string.IsNullOrEmpty(City))
                    yield return "Город должен быть заполнен";
        }

        public bool HasErrors => GetErrors(string.Empty).Any();

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        #endregion

    }
}