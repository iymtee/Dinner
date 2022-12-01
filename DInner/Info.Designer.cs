
namespace DInner
{
	partial class Info
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.bsDish = new System.Windows.Forms.BindingSource(this.components);
			this.dsDinner = new DInner.dsDinner();
			this.imagePictureBox = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dishesTableAdapter = new DInner.dsDinnerTableAdapters.DishesTableAdapter();
			this.tableAdapterManager = new DInner.dsDinnerTableAdapters.TableAdapterManager();
			this.panel3 = new System.Windows.Forms.Panel();
			this.consistLabel1 = new System.Windows.Forms.Label();
			this.nameLabel1 = new System.Windows.Forms.Label();
			this.iconButton1 = new FontAwesome.Sharp.IconButton();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bsDish)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsDinner)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.nameLabel1);
			this.panel1.Controls.Add(this.consistLabel1);
			this.panel1.Controls.Add(this.imagePictureBox);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(1, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(598, 498);
			this.panel1.TabIndex = 0;
			// 
			// bsDish
			// 
			this.bsDish.DataMember = "Dishes";
			this.bsDish.DataSource = this.dsDinner;
			// 
			// dsDinner
			// 
			this.dsDinner.DataSetName = "dsDinner";
			this.dsDinner.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// imagePictureBox
			// 
			this.imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bsDish, "image", true));
			this.imagePictureBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.imagePictureBox.Location = new System.Drawing.Point(0, 50);
			this.imagePictureBox.Name = "imagePictureBox";
			this.imagePictureBox.Size = new System.Drawing.Size(598, 250);
			this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imagePictureBox.TabIndex = 2;
			this.imagePictureBox.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(598, 50);
			this.panel2.TabIndex = 0;
			// 
			// dishesTableAdapter
			// 
			this.dishesTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.DishesTableAdapter = this.dishesTableAdapter;
			this.tableAdapterManager.OrderTableAdapter = null;
			this.tableAdapterManager.PeopleTableAdapter = null;
			this.tableAdapterManager.TypeTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = DInner.dsDinnerTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.White;
			this.panel3.Controls.Add(this.iconButton1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(1, 1);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(598, 50);
			this.panel3.TabIndex = 8;
			// 
			// consistLabel1
			// 
			this.consistLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDish, "consist", true));
			this.consistLabel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.consistLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.consistLabel1.Location = new System.Drawing.Point(0, 398);
			this.consistLabel1.Name = "consistLabel1";
			this.consistLabel1.Size = new System.Drawing.Size(598, 100);
			this.consistLabel1.TabIndex = 11;
			this.consistLabel1.Text = "label1";
			this.consistLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// nameLabel1
			// 
			this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDish, "name", true));
			this.nameLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nameLabel1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nameLabel1.Location = new System.Drawing.Point(0, 300);
			this.nameLabel1.Name = "nameLabel1";
			this.nameLabel1.Size = new System.Drawing.Size(598, 98);
			this.nameLabel1.TabIndex = 12;
			this.nameLabel1.Text = "label1";
			this.nameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// iconButton1
			// 
			this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.iconButton1.Dock = System.Windows.Forms.DockStyle.Right;
			this.iconButton1.FlatAppearance.BorderSize = 0;
			this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
			this.iconButton1.IconColor = System.Drawing.Color.Black;
			this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton1.IconSize = 28;
			this.iconButton1.Location = new System.Drawing.Point(457, 0);
			this.iconButton1.Name = "iconButton1";
			this.iconButton1.Size = new System.Drawing.Size(141, 50);
			this.iconButton1.TabIndex = 0;
			this.iconButton1.Text = "Закрыть";
			this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.iconButton1.UseVisualStyleBackColor = true;
			this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
			// 
			// Info
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(600, 500);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Info";
			this.Padding = new System.Windows.Forms.Padding(1);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Info";
			this.Load += new System.EventHandler(this.Info_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bsDish)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsDinner)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private dsDinner dsDinner;
		private dsDinnerTableAdapters.DishesTableAdapter dishesTableAdapter;
		private dsDinnerTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.PictureBox imagePictureBox;
		public System.Windows.Forms.BindingSource bsDish;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label nameLabel1;
		private System.Windows.Forms.Label consistLabel1;
		private System.Windows.Forms.Panel panel3;
		private FontAwesome.Sharp.IconButton iconButton1;
	}
}