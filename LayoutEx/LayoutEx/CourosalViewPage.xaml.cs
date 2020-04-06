using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutEx
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CourosalViewPage : ContentPage
    {
        public CourosalViewPage()
        {
            InitializeComponent();

            List<State> objStatesList = new List<State>();
            objStatesList.Add(new State { StatePhoto = "icon.png", StateName = "Telangana" });
            objStatesList.Add(new State { StatePhoto = "icon.png", StateName = "Andrapradesh" });
            objStatesList.Add(new State { StatePhoto = "icon.png", StateName = "Kerala" });
            objStatesList.Add(new State { StatePhoto = "icon.png", StateName = "Odisha" });
            objStatesList.Add(new State { StatePhoto = "icon.png", StateName = "Karnataka" });
            objStatesList.Add(new State { StatePhoto = "icon.png", StateName = "Tamilnadu" });
            objStatesList.Add(new State { StatePhoto = "icon.png", StateName = "Telangana" });
            cvStatesList.ItemsSource = objStatesList;

        }
    }
}