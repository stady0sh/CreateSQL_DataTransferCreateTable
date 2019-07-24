using CreateSQL_DataTransferCreateTable.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CreateSQL_DataTransferCreateTable
{
	/// <summary>
	/// MainWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}


		#region event

		private void btnSelection_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				this.ShowOpenFileDialog();
			}
			catch (Exception ex)
			{
				ExMessage.ShowException(ex);
			}
		}

		private void btnEnter_Click(object sender, RoutedEventArgs e)
		{
			try
			{

			}
			catch (Exception ex)
			{
				ExMessage.ShowException(ex);
			}
		}

		#endregion

		#region method

		/// <summary>
		/// ファイルを開くダイアログボックスを表示
		/// </summary>
		private void ShowOpenFileDialog()
		{
			// ダイアログのインスタンスを生成
			var dialog = new Microsoft.Win32.OpenFileDialog();

			// ファイルの種類を設定
			dialog.Filter = "SQLファイル (*.sql)|*.txt|全てのファイル (*.*)|*.*";

			// ダイアログを表示する
			if (dialog.ShowDialog() == true)
			{
				// 選択されたファイル名 (ファイルパス) をメッセージボックスに表示
				//txtPath.Text = dialog.FileName;
			
			}
		}


		#endregion
	}
}

