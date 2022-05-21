using System.ComponentModel;

namespace amirtest2
{
    public class testmodel : INotifyPropertyChanged
    {
        private string _name;
        private int _age;
        private string _phone;


        public string name
        {
            get { return _name; }
            set
            {
                if (value != _name)
                {
                    _name = value;
                    OnPropertyChanged("name changed");
                }
            }
        }

        public int age
        {
            get { return _age; }
            set
            {
                if (value != _age)
                {
                    _age = value;
                    OnPropertyChanged("age changed");
                }
            }
        }

        public string phone
        {
            get { return _phone; }
            set
            {
                if (value != _phone)
                {
                    _phone = value;
                    OnPropertyChanged("phone changed");
                }
            }
        }


        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, e);
        }

        protected void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }
     
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
