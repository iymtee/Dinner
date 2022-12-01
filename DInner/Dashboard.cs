using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DInner
{
	public partial class Dashboard : Form
	{
		SqlConnection con =  new SqlConnection(Properties.Settings.Default.con);
		SqlCommand com;
		string query;
		private Form activeForm = null;
		Button[] masB;
		int btnIndex = 1;

		public struct Dishes
		{
			public int idD, count ;
			public double price;
			public string name, consist;
			public Image image;
		}

		public struct Type
		{
			public int idT;
			public string name;
		}

		public class oD
		{
			public double price { get; set; }
			public int count { get; set; }
			public int idD { get; set; }
			public string name { get; set; }
		}

		List<oD> lstOrder = new List<oD>();
		Dishes[] masDish;

		public Dashboard()
		{
			InitializeComponent();
		}

		public void activeClose()
		{
			if (activeForm != null)
			{
				activeForm.Close();
				activeForm = null;
			}
		}

		private void info_Click(object sender, EventArgs e)
		{
			activeClose();
			Info frm = new Info();
			activeForm = frm;
			frm.bsDish.Filter = "idD ='" + Convert.ToInt32((sender as PictureBox).Name.ToString().Remove(0, 2)) + "'";
			//frm.check();
			frm.Show(this);
		}

		private void type_Click(object sender, EventArgs e)
		{
			activeClose();
			btnIndex = Convert.ToInt32((sender as Button).Name.ToString().Remove(0, 3));
			bsDishes.Filter = "idT = '" 
				+ btnIndex 
				+ "' and count <> 0";
			FillDish(ref masDish);
			FillDishForm(masDish);
		}

		#region ДобавлениеКнопок
		public static Type[] masT;

		void FillType(ref Type[] masT)
		{
			if (0 >= bsType.Count) return;
			masT = new Type[bsType.Count];

			for (int i = 0; i < bsType.Count; i++)
			{
				DataRowView t = (DataRowView)bsType[i];
				masT[i].idT = (int)t[0];
				masT[i].name = t[1].ToString();
			}
		}

		public void FillButton(Type[] masT)
		{
			pButton.Controls.Clear();
			masB = new Button[masT.Length];
			Panel[] p = new Panel[masT.Length];

			for (int i = 0; i < masT.Length; i++)
			{
				//создаем Button с i-товаром
				masB[i] = new Button();
				masB[i].Dock = DockStyle.Top;
				masB[i].Name = "btn" + (masT[i].idT).ToString();
				masB[i].Text = masT[i].name;
				masB[i].TextAlign = ContentAlignment.MiddleLeft;
				//masB[i].ForeColor = Color.White;
				masB[i].Height = 50;
				masB[i].FlatStyle = FlatStyle.Flat;
				masB[i].FlatAppearance.BorderSize = 0;
				//masB[i].BackColor = Color.Gray;
				masB[i].Cursor = Cursors.Hand;
				masB[i].Click += new EventHandler(type_Click);
				p[i] = new Panel();
				p[i].Font = new Font("Segoe UI", 12, FontStyle.Bold);
				p[i].Dock = DockStyle.Top;
				p[i].Size = new Size(0, 1);
				p[i].BackColor = Color.Black;
				p[i].Height = 5;
				pButton.Controls.Add(masB[i]);
				pButton.Controls.SetChildIndex(masB[i], 0);
				pButton.Controls.Add(p[i]);
				pButton.Controls.SetChildIndex(p[i], 0);
			}
		}
		#endregion

		public void check()
		{
			pOrder.Controls.Clear();
			if (lstOrder.Count > 0)
			{
				for (int i = 0; i < lstOrder.Count; i++)
				{
					Label[] lab = new Label[lstOrder.Count];
					Label[] labPrice = new Label[lstOrder.Count];
					Label[] labcount = new Label[lstOrder.Count];
					Panel[] pan = new Panel[lstOrder.Count];
					Panel[] pan2 = new Panel[lstOrder.Count];
					Panel[] pan3 = new Panel[lstOrder.Count];
					Button[] btnAdd = new Button[lstOrder.Count];
					Button[] btnMin = new Button[lstOrder.Count];
					Button[] btnDel = new Button[lstOrder.Count];

					//разделитель
					pan3[i] = new Panel();
					pan3[i].Size = new Size(0, 1);
					pan3[i].BackColor = Color.Black;
					pan3[i].Dock = DockStyle.Top;
					pOrder.Controls.Add(pan3[i]);

					pan[i] = new Panel();
					pan[i].AutoSize = true;
					pan[i].Dock = DockStyle.Top;
					pOrder.Controls.Add(pan[i]);
					//создаем Label с i-товаром
					lab[i] = new Label();
					lab[i].Text = lstOrder[i].name;
					lab[i].MaximumSize = new Size(pOrder.Width, 0);
					lab[i].Dock = DockStyle.Top;
					lab[i].AutoSize = true;					
					lab[i].Font = new Font("Segoe UI", 12.50F, FontStyle.Bold);
					lab[i].TextAlign = ContentAlignment.TopLeft;
					pan[i].Controls.Add(lab[i]);
					//вторая панель pan2
					pan2[i] = new Panel();
					pan2[i].Height = 50;
					pan2[i].Dock = DockStyle.Bottom;
					pan[i].Controls.Add(pan2[i]);
					//btnMin удаление
					btnMin[i] = new Button();
					btnMin[i].FlatStyle = FlatStyle.Flat;
					btnMin[i].FlatAppearance.BorderSize = 0;
					btnMin[i].Size = new Size(50, 50);
					btnMin[i].Name = "mim" + lstOrder[i].idD;
					btnMin[i].Text = "-";
					btnMin[i].Dock = DockStyle.Right;
					btnMin[i].Cursor = Cursors.Hand;
					pan2[i].Controls.Add(btnMin[i]);
					//создаем Label с кол-вом товара
					labcount[i] = new Label();
					labcount[i].Size = new Size(50, 50);
					labcount[i].Text = lstOrder[i].count.ToString();
					labcount[i].Font = new Font("Segoe UI", 12.50F, FontStyle.Bold);
					labcount[i].Dock = DockStyle.Right;
					labcount[i].TextAlign = ContentAlignment.MiddleCenter;
					pan2[i].Controls.Add(labcount[i]);
					//btnAdd добавление
					btnAdd[i] = new Button();
					btnAdd[i].FlatStyle = FlatStyle.Flat;
					btnAdd[i].FlatAppearance.BorderSize = 0;
					btnAdd[i].Size = new Size(50, 50);
					btnAdd[i].Text = "+";
					btnAdd[i].Name = "adm" + lstOrder[i].idD;
					btnAdd[i].Dock = DockStyle.Right;
					btnAdd[i].Cursor = Cursors.Hand;
					pan2[i].Controls.Add(btnAdd[i]);					
					//label с ценой
					labPrice[i] = new Label();
					labPrice[i].Font = new Font("Segoe UI", 12.50F, FontStyle.Bold);
					labPrice[i].Dock = DockStyle.Left;
					labPrice[i].TextAlign = ContentAlignment.MiddleLeft;
					labPrice[i].Text = lstOrder[i].price.ToString() + " ₽";
					labPrice[i].ForeColor = Color.FromArgb(0, 192, 0);
					pan2[i].Controls.Add(labPrice[i]);
					//btnDel удалить
					btnDel[i] = new Button();
					btnDel[i].FlatStyle = FlatStyle.Flat;
					btnDel[i].FlatAppearance.BorderSize = 0;
					btnDel[i].Size = new Size(40, 40);
					btnDel[i].Text = "x";
					btnDel[i].Name = "del" + i;
					btnDel[i].Dock = DockStyle.Right;
					btnDel[i].Cursor = Cursors.Hand;
					pan2[i].Controls.Add(btnDel[i]);

					btnAdd[i].Click += new EventHandler(btnAdd_Click);
					btnDel[i].Click += new EventHandler(btnDel_Click);
					btnMin[i].Click += new EventHandler(btnMin_Click);
				}
			}
			double price = 0;
			foreach (oD ord in lstOrder)
			{
				price += ord.count * ord.price;
			}
			lblPrice.Text = price + " ₽";
		}
		
		public void btnDel_Click(object sender, EventArgs e)
		{
			lstOrder.RemoveAt(Convert.ToInt32((sender as Button).Name.ToString().Remove(0, 3)));
			check();
		}

		public void btnAdd_Click(object sender, EventArgs e)
		{
			int idAdd = Convert.ToInt32((sender as Button).Name.ToString().Remove(0, 3)),
				n = -1;
			for (int i = 0; i < lstOrder.Count; i++)
			{
				if (lstOrder[i].idD == idAdd)
				{
					n = i;
				}
			}
			if (n != -1)
			{
				DataRowView t = (DataRowView)bsDishes[n];
				int count = (int)t["count"];
				if (count == 0) lstOrder.RemoveAt(n);
				else
					if ((count - (lstOrder[n].count + 1)) >= 0)
					lstOrder[n].count = lstOrder[n].count + 1;
			}
			else
			{
				oD addOd = new oD();
				foreach (Dishes d in masDish)
				{
					if (d.idD == idAdd)
					{
						addOd.idD = idAdd;
						addOd.name = d.name;
						addOd.price = d.price;
						addOd.count = 1;
						break;
					}
				}
				lstOrder.Add(addOd);
			}
			check();
		}

		public void btnMin_Click(object sender, EventArgs e)
		{
			int idMin = Convert.ToInt32((sender as Button).Name.ToString().Remove(0, 3)), n=-1; 
			for (int i = 0; i < lstOrder.Count; i++)
			{
				if (lstOrder[i].idD == idMin)
				{
					n = i;
				}
			}
			if (n != -1)
			{
				lstOrder[n].count = lstOrder[n].count - 1;
				if (lstOrder[n].count == 0) lstOrder.RemoveAt(n);
				check();
			}
		}

		#region ДобавлениеБлюд
		void FillDish(ref Dishes[] masDish)
		{
			if (0 >= bsDishes.Count)
			{
				masDish = null;
				pDishes.Controls.Clear();
				return;
			}
			masDish = new Dishes[bsDishes.Count];

			for (int i = 0; i < bsDishes.Count; i++)
			{
				DataRowView t = (DataRowView)bsDishes[i];
				masDish[i].idD = (int)t["idD"];
				masDish[i].name = t["name"].ToString();
				masDish[i].consist = t["consist"].ToString();
				masDish[i].price = (double)t["price"];
				//masDish[i].count = (int)t["count"];
				try
				{
					MemoryStream ms = new MemoryStream((byte[])t["image"]);
					masDish[i].image = Image.FromStream(ms);
				}
				catch
				{
					masDish[i].image = Properties.Resources.error;
				}
			}
		}

		public void FillDishForm(Dishes[] masDish)
		{
			if (bsDishes.Count > 0)
			{
				pDishes.Controls.Clear();
				PictureBox[] masPB = new PictureBox[masDish.Length];
				Label[] lab = new Label[masDish.Length];
				Label[] labPrice = new Label[masDish.Length];
				Panel[] pan = new Panel[masDish.Length];
				Panel[] pan2 = new Panel[masDish.Length];
				Button[] btnAdd = new Button[masDish.Length];
				Button[] btnMin = new Button[masDish.Length];
				Button[] btnDel = new Button[masDish.Length];

				int x = 25, y = 0, dx = x, dy = y, a = 0, width = 350;

				for (int i = 0; i < masDish.Length; i++)
				{
					if (dx + 15 + width > pDishes.Width)
					{
						y = y + a;
						dy = y;
						dx = x;
					}
					pan[i] = new Panel();
					pan[i].MinimumSize = new Size(width, 0);
					pan[i].AutoSize = true;
					pan[i].Left = dx;
					pan[i].Top = dy;
					pan[i].Cursor = Cursors.Hand;
					pDishes.Controls.Add(pan[i]);
					pDishes.Controls.SetChildIndex(pan[i], 0);
					//создаем PictureBox с i-товаром
					masPB[i] = new PictureBox();
					masPB[i].Dock = DockStyle.Top;
					masPB[i].Size = new Size(width, 200);
					masPB[i].SizeMode = PictureBoxSizeMode.Zoom;
					masPB[i].Name = "pb" + masDish[i].idD;
					masPB[i].Image = masDish[i].image;
					pan[i].Controls.Add(masPB[i]);
					pan[i].Controls.SetChildIndex(masPB[i], 0);
					//создаем Label с i-товаром
					lab[i] = new Label();
					lab[i].Size = new Size(width, 60);
					lab[i].Font = new Font("Segoe UI", 12.50F, FontStyle.Bold);
					lab[i].Dock = DockStyle.Top;
					lab[i].TextAlign = ContentAlignment.TopCenter;
					lab[i].Tag = masDish[i].idD;
					lab[i].Text = masDish[i].name.Trim();
					pan[i].Controls.Add(lab[i]);
					pan[i].Controls.SetChildIndex(lab[i], 0);
					//вторая панель pan2
					pan2[i] = new Panel();
					pan2[i].Size = new Size(width, 40);
					pan2[i].Dock = DockStyle.Bottom;
					pan2[i].Cursor = Cursors.Hand;
					pan[i].Controls.Add(pan2[i]);
					//btnAdd добавление
					btnAdd[i] = new Button();
					btnAdd[i].Size = new Size(40, 40);
					btnAdd[i].FlatStyle = FlatStyle.Flat;
					btnAdd[i].FlatAppearance.BorderSize = 0;
					btnAdd[i].Name = "add" + masDish[i].idD;
					btnAdd[i].Text = "+";
					btnAdd[i].Dock = DockStyle.Right;
					btnAdd[i].Cursor = Cursors.Hand;
					pan2[i].Controls.Add(btnAdd[i]);
					pan2[i].Controls.SetChildIndex(btnAdd[i], 0);
					//label с ценой
					labPrice[i] = new Label();
					labPrice[i].AutoSize = true;
					labPrice[i].Font = new Font("Segoe UI", 14.50F, FontStyle.Bold);
					labPrice[i].Dock = DockStyle.Right;
					labPrice[i].TextAlign = ContentAlignment.BottomRight;
					labPrice[i].Text = masDish[i].price.ToString() + " ₽";
					labPrice[i].ForeColor = Color.FromArgb(0, 192, 0);
					pan2[i].Controls.Add(labPrice[i]);
					pan2[i].Controls.SetChildIndex(labPrice[i], 0);
					//btnMin удаление
					btnMin[i] = new Button();
					btnMin[i].FlatStyle = FlatStyle.Flat;
					btnMin[i].FlatAppearance.BorderSize = 0;
					btnMin[i].Size = new Size(50, 50);
					btnMin[i].Name = "mim" + masDish[i].idD;
					btnMin[i].Text = "-";
					btnMin[i].Dock = DockStyle.Right;
					btnMin[i].Cursor = Cursors.Hand;
					pan2[i].Controls.Add(btnMin[i]);
					pan2[i].Controls.SetChildIndex(btnMin[i], 0);


					btnMin[i].Click += new EventHandler(btnMin_Click);
					btnAdd[i].Click += new EventHandler(btnAdd_Click);
					masPB[i].Click += new EventHandler(info_Click);
					lab [i].Click += new EventHandler(info_Click);

					dx = dx + pan[i].Width + 15;
					a = pan[i].Height + 15;
				}
			}
		}
		#endregion

		private void Dashboard_Load(object sender, EventArgs e)
		{
			this.peopleTableAdapter.Fill(this.dsDinner.People);
			this.dishesTableAdapter.Fill(this.dsDinner.Dishes);
			this.typeTableAdapter.Fill(this.dsDinner.Type);
			FillType(ref masT);
			FillButton(masT);
			DataRowView drv = (DataRowView)bsDishes[0];
			bsDishes.Filter = "idT = '" + drv["idD"].ToString() + "' and count <> 0";
			FillDish(ref masDish);
			FillDishForm(masDish);
		}

		private void Dashboard_Click(object sender, EventArgs e)
		{
			activeClose();
		}

		private void iconButton1_Click(object sender, EventArgs e)
		{
			lstOrder.Clear();
			check();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			if (lstOrder.Count > 0)
			{
				string people = "4854854885", email = "", name = "", text = "", numOrd = "", idP = "";
				double allPrice = 0;
				bsPeople.Filter = "card = '" + people + "'";
				DataRowView t = (DataRowView)bsPeople[0];
				email = t["email"].ToString();
				name = t["name"].ToString();
				idP = t["idP"].ToString();
				text = name + ", Ваш ребёнок приобрел в столовой: <br>";
				com = new SqlCommand("select distinct max(numord) from[Order]");
				try
				{
					SqlDataReader sdr = com.ExecuteReader();
					while (sdr.Read())
					{
						numOrd = ((int)sdr.GetValue(0) + 1).ToString();
					}
				}
				catch
				{
				}
				if (numOrd == "") numOrd = "7235";
				foreach (oD ord in lstOrder)
				{
					text += "\r\n <br><strong>" + ord.name.ToLower() + "</strong> - " + ord.count + "  x " + ord.price + " ₽";
					query = "update dishes set count = ((select count from dishes " +
						"where idD = " + ord.idD + ") -" + ord.count + ") where idD = " + ord.idD;
					com = new SqlCommand(query, con);
					allPrice += ord.price * ord.count;
					try
					{
						con.Open();
						com.ExecuteNonQuery();
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
					con.Close();
					query = "insert into [order](numOrd, idP, idD, count, datetime) values (" +
						numOrd + ", " + idP + ", " + ord.idD + ", " + ord.count + ", '" + DateTime.Now + "')";
					com = new SqlCommand(query, con);
					allPrice += ord.price * ord.count;
					try
					{
						con.Open();
						com.ExecuteNonQuery();
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
					con.Close();
				}
				text += "\r\n. <br><br>На сумму: " + allPrice + " ₽\r\n. <br>" + DateTime.Now.ToString("hh:mm; dd.MM.yy");
				// отправитель - устанавливаем адрес и отображаемое в письме имя
				MailAddress from = new MailAddress("umari666ru@gmail.com", "Столовая");
				// кому отправляем
				MailAddress to = new MailAddress(email);
				// создаем объект сообщения
				MailMessage m = new MailMessage(from, to);
				// тема письма
				m.Subject = "Посещение столовой ребенком от " + DateTime.Now.ToString("dd.MM.yy");
				// текст письма
				m.Body = text;
				// письмо представляет код html
				m.IsBodyHtml = true;
				// адрес smtp-сервера и порт, с которого будем отправлять письмо
				SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
				// логин и пароль
				smtp.Credentials = new NetworkCredential("umari666ru@gmail.com", "olhycewghdpnptsp");
				smtp.EnableSsl = true;
				smtp.Send(m);
				lstOrder.Clear();
				check();
			}
		}

		private void Dashboard_Resize(object sender, EventArgs e)
		{
			bsDishes.Filter = "idT = '" + btnIndex +"' and count <> 0";
			FillDish(ref masDish);
			FillDishForm(masDish);
		}
	}
}
