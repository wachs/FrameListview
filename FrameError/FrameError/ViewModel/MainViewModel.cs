using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FrameError.ViewModel
{
    public class MainViewModel : ViewModelBase
	{

		private ObservableCollection<TestModel> _list;
		/// <summary>
		/// List containing the itens of the menu
		/// </summary>
		public ObservableCollection<TestModel> List
		{
			get { return _list; }
			set
			{
				_list = value;
				OnPropertyChanged();
			}
		}


		public MainViewModel()
		{
			var teste = new TestModel()
			{
				Id = 1,
				Name = "Teste 1"
			};
			List = new ObservableCollection<TestModel>()
			{
				teste,
				teste,
				teste,
				teste,
				teste,
				teste,
				teste,
				teste,
				teste,
				teste,
				teste,
			};
		}

	}

	public class TestModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}
}
