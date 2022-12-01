
namespace DInner
{
	partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pButton = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pOrder = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOk = new FontAwesome.Sharp.IconButton();
            this.lblOrder = new System.Windows.Forms.Label();
            this.pDishes = new System.Windows.Forms.Panel();
            this.bsType = new System.Windows.Forms.BindingSource(this.components);
            this.dsDinner = new DInner.dsDinner();
            this.bsDishes = new System.Windows.Forms.BindingSource(this.components);
            this.typeTableAdapter = new DInner.dsDinnerTableAdapters.TypeTableAdapter();
            this.dishesTableAdapter = new DInner.dsDinnerTableAdapters.DishesTableAdapter();
            this.bsPeople = new System.Windows.Forms.BindingSource(this.components);
            this.peopleTableAdapter = new DInner.dsDinnerTableAdapters.PeopleTableAdapter();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDishes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // pButton
            // 
            this.pButton.AutoScroll = true;
            this.pButton.BackColor = System.Drawing.Color.White;
            this.pButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.pButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.pButton.Location = new System.Drawing.Point(25, 25);
            this.pButton.Margin = new System.Windows.Forms.Padding(2);
            this.pButton.Name = "pButton";
            this.pButton.Size = new System.Drawing.Size(275, 618);
            this.pButton.TabIndex = 23;
            this.pButton.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.pOrder);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.lblOrder);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(714, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 618);
            this.panel3.TabIndex = 26;
            this.panel3.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // pOrder
            // 
            this.pOrder.AutoScroll = true;
            this.pOrder.BackColor = System.Drawing.Color.White;
            this.pOrder.Dock = System.Windows.Forms.DockStyle.Right;
            this.pOrder.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.pOrder.Location = new System.Drawing.Point(0, 25);
            this.pOrder.Margin = new System.Windows.Forms.Padding(2);
            this.pOrder.Name = "pOrder";
            this.pOrder.Size = new System.Drawing.Size(450, 486);
            this.pOrder.TabIndex = 33;
            this.pOrder.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblPrice);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 511);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(450, 32);
            this.panel4.TabIndex = 32;
            this.panel4.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPrice.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblPrice.Location = new System.Drawing.Point(73, 0);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(39, 25);
            this.lblPrice.TabIndex = 28;
            this.lblPrice.Text = "0 ₽";
            this.lblPrice.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Итого:";
            this.label1.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 543);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.panel2.Size = new System.Drawing.Size(450, 75);
            this.panel2.TabIndex = 30;
            this.panel2.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 35;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 15);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(212, 60);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "Отменить";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(212, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(26, 60);
            this.panel1.TabIndex = 3;
            this.panel1.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // btnOk
            // 
            this.btnOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnOk.IconColor = System.Drawing.Color.White;
            this.btnOk.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnOk.IconSize = 35;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(238, 15);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(212, 60);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Готово";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOrder.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblOrder.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblOrder.Location = new System.Drawing.Point(0, 0);
            this.lblOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(68, 25);
            this.lblOrder.TabIndex = 24;
            this.lblOrder.Text = "Заказ:";
            this.lblOrder.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // pDishes
            // 
            this.pDishes.AutoScroll = true;
            this.pDishes.BackColor = System.Drawing.Color.Transparent;
            this.pDishes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDishes.Location = new System.Drawing.Point(300, 25);
            this.pDishes.Margin = new System.Windows.Forms.Padding(2);
            this.pDishes.Name = "pDishes";
            this.pDishes.Size = new System.Drawing.Size(414, 618);
            this.pDishes.TabIndex = 27;
            this.pDishes.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // bsType
            // 
            this.bsType.DataMember = "Type";
            this.bsType.DataSource = this.dsDinner;
            // 
            // dsDinner
            // 
            this.dsDinner.DataSetName = "dsDinner";
            this.dsDinner.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsDishes
            // 
            this.bsDishes.DataMember = "Dishes";
            this.bsDishes.DataSource = this.dsDinner;
            // 
            // typeTableAdapter
            // 
            this.typeTableAdapter.ClearBeforeFill = true;
            // 
            // dishesTableAdapter
            // 
            this.dishesTableAdapter.ClearBeforeFill = true;
            // 
            // bsPeople
            // 
            this.bsPeople.DataMember = "People";
            this.bsPeople.DataSource = this.dsDinner;
            // 
            // peopleTableAdapter
            // 
            this.peopleTableAdapter.ClearBeforeFill = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1189, 668);
            this.Controls.Add(this.pDishes);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pButton);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1205, 700);
            this.Name = "Dashboard";
            this.Padding = new System.Windows.Forms.Padding(25);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Терминал";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Click += new System.EventHandler(this.Dashboard_Click);
            this.Resize += new System.EventHandler(this.Dashboard_Resize);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDishes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.BindingSource bsType;
		private dsDinner dsDinner;
		private System.Windows.Forms.BindingSource bsDishes;
		private dsDinnerTableAdapters.TypeTableAdapter typeTableAdapter;
		private dsDinnerTableAdapters.DishesTableAdapter dishesTableAdapter;
		private System.Windows.Forms.Panel pButton;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel pDishes;
		private System.Windows.Forms.Label lblOrder;
		private System.Windows.Forms.BindingSource bsPeople;
		private dsDinnerTableAdapters.PeopleTableAdapter peopleTableAdapter;
		private dsDinnerTableAdapters.OrderTableAdapter orderTableAdapter;
		private System.Windows.Forms.Panel pOrder;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label lblPrice;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private FontAwesome.Sharp.IconButton iconButton1;
		private System.Windows.Forms.Panel panel1;
		private FontAwesome.Sharp.IconButton btnOk;
	}
}

