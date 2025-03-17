using CSProjeDemo1.Data.Data;
using CSProjeDemo1.Entities.Entities;
using CSProjeDemo1.Islem.Services;

namespace CSProjeDemo1.Presentation
{
	public partial class frmAnasayfa : Form
	{
		public frmAnasayfa()
		{
			InitializeComponent();

			
		}

	

		private void btnUyeIslemler_Click(object sender, EventArgs e)
		{
			frmUyeIslemler frmUyeIslemler = new frmUyeIslemler();
			frmUyeIslemler.ShowDialog();
		}

		private void btnKitapIslemler_Click(object sender, EventArgs e)
		{
			frmKitapIslemler frmKitapIslemler = new frmKitapIslemler();
			frmKitapIslemler.ShowDialog();
		}

		private void btnEmanetIslemler_Click(object sender, EventArgs e)
		{
			frmEmanetIslemler frmEmanetIslemler = new frmEmanetIslemler();
			frmEmanetIslemler.ShowDialog();
		}
	}
}
