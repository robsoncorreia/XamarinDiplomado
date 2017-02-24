using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinDiplomado.Model.Entrada;

namespace XamarinDiplomado.View
{
    public partial class FormAssistControlPage : ContentPage
    {
        public FormAssistControlPage()
        {
            InitializeComponent();
            BindingContext = new StudentDirectory();
        }
    }
}
