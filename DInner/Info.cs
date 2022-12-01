using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DInner
{
	public partial class Info : Form
	{
		public Info()
		{
			InitializeComponent();
		}

		private void dishesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.bsDish.EndEdit();
			this.tableAdapterManager.UpdateAll(this.dsDinner);

		}

		private void Info_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dsDinner.Dishes' table. You can move, or remove it, as needed.
			this.dishesTableAdapter.Fill(this.dsDinner.Dishes);

		}

		private void iconButton1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
