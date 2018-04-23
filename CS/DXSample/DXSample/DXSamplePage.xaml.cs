using System.ComponentModel;
using DevExpress.Mobile.Core.Containers;
using Xamarin.Forms;

namespace DXSample
{
	public partial class DXSamplePage : ContentPage
	{
		BindingList<Data> List = new BindingList<Data>();
		public DXSamplePage()
		{
			InitializeComponent();

			for (int i = 0; i < 10; i++)
			{
				Data data = new Data();
				data.Text = "Row " + i;
				data.IsSelected = (i % 2) == 0;

				List.Add(data);
			}

			grid.ItemsSource = List;
			grid.RowTap += (sender, e) => {
				if (e.FieldName == "IsSelected") {
					int sourceRowIndex = grid.GetSourceRowIndex(e.RowHandle);
					List[sourceRowIndex].IsSelected = !List[sourceRowIndex].IsSelected;
				}
			};
		}
	}

	public class Data : INotifyPropertyChanged {
		bool isSelected = false;
		public bool IsSelected { 
			get { return isSelected; }
			set {
				isSelected = value;

				if (PropertyChanged != null)
					PropertyChanged(this, new PropertyChangedEventArgs("IsSelected"));
			}
		}

		public string Text { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
