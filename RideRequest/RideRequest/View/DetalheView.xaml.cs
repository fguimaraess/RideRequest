using RideRequest.Model;
using RideRequest.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RideRequest.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalheView : ContentPage
    {
        public DetalheView(Address[] lugares)
        {
            InitializeComponent();
            this.BindingContext = new DetalheViewModel(lugares);
        }
    }
}