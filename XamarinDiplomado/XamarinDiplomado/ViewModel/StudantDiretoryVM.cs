using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinDiplomado.Model.Entrada;
using XamarinDiplomado.Model.Servico;

namespace XamarinDiplomado.ViewModel
{
    public class StudantDiretoryVM : ObservableBaseObject
    {
        public ObservableCollection<Student> Students { get; set; }
        private bool isBusy = false;
        private Command LoadDirectoryCommand
        {
            get;
            set;
        }
        public bool IsBusy
        {
            get
            {
                return isBusy;
            }

            set
            {
                isBusy = value;
                OnPropertyChanged();
            }
        }
        public StudantDiretoryVM()
        {
            Students = new ObservableCollection<Student>();
            IsBusy = false;
            LoadDirectoryCommand = new Command((obj) => LoadDirectory());
        }

        async void LoadDirectory()
        {
            if (!IsBusy)
            {
                IsBusy = true;

                await Task.Delay(3000);

                var loadedDiretory = StudentDirectoryService.LoadStudentDirectory();

                foreach (var item in loadedDiretory.Students)
                {
                    Students.Add(item);
                }

                IsBusy = false;
            }
        }
    }
}
