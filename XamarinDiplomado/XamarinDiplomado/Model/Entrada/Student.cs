using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinDiplomado.Model.Entrada
{
    public class Student : ObservableBaseObject
    {
        private String name;
        private String lastName;
        private String group;
        private String studentNumber;
        private double average;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
                OnPropertyChanged();
            }
        }

        public string Group
        {
            get
            {
                return group;
            }

            set
            {
                group = value;
                OnPropertyChanged();
            }
        }

        public string StudentNumber
        {
            get
            {
                return studentNumber;
            }

            set
            {
                studentNumber = value;
                OnPropertyChanged();
            }
        }

        public double Average
        {
            get
            {
                return average;
            }

            set
            {
                average = value;
                OnPropertyChanged();
            }
        }
    }
}
