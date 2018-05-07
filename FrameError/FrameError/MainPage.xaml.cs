using FrameError.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FrameError
{
	public partial class MainPage : ContentPage
	{
		MainViewModel _vm;
		int count = 0;
		public MainPage()
		{
			InitializeComponent();

			BindingContext = _vm = new MainViewModel();
			count = _vm.List.Count;
		}

		void AddItem(object sender, EventArgs e)
		{
			//_vm.List.Add("Item " + count++);
		}

		void RemoveItem(object sender, EventArgs e)
		{
			//_vm.List.Remove("Item " + count--);
		}
	}
}
