using System;
using System.Collections;
using System.ComponentModel;

namespace PizzaSPA.Shared
{
    public class Customer : INotifyDataErrorInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }

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
    }
}