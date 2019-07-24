using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CreateSQL_DataTransferCreateTable.Library
{
	public static class ExMessage
	{
		public static void ShowException(Exception ex)
		{
			MessageBox.Show("Error", $"{ex.Message}\r\n{ex.StackTrace}", MessageBoxButton.OK, MessageBoxImage.Error);
		}
	}
}
