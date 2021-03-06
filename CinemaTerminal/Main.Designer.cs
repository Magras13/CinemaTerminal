﻿namespace CinemaTerminal
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.poster01 = new System.Windows.Forms.PictureBox();
            this.arrowLeft = new System.Windows.Forms.PictureBox();
            this.arrowRight = new System.Windows.Forms.PictureBox();
            this.scheduleIcon = new System.Windows.Forms.PictureBox();
            this.AdminIcon = new System.Windows.Forms.PictureBox();
            this.poster02 = new System.Windows.Forms.PictureBox();
            this.poster03 = new System.Windows.Forms.PictureBox();
            this.posterPnl1 = new System.Windows.Forms.Panel();
            this.posterPnl2 = new System.Windows.Forms.Panel();
            this.posterPnl3 = new System.Windows.Forms.Panel();
            this.extraPoster01 = new System.Windows.Forms.PictureBox();
            this.extraPoster02 = new System.Windows.Forms.PictureBox();
            this.extraPoster03 = new System.Windows.Forms.PictureBox();
            this.extraPoster04 = new System.Windows.Forms.PictureBox();
            this.extraPoster05 = new System.Windows.Forms.PictureBox();
            this.extraPoster06 = new System.Windows.Forms.PictureBox();
            this.extraPanel = new System.Windows.Forms.Panel();
            this.treilerPnl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDataSet = new CinemaTerminal.MyDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.backIcon = new System.Windows.Forms.PictureBox();
            this.VideoPnl = new System.Windows.Forms.Panel();
            this.filmTableAdapter = new CinemaTerminal.MyDataSetTableAdapters.FilmTableAdapter();
            this.tableAdapterManager = new CinemaTerminal.MyDataSetTableAdapters.TableAdapterManager();
            this.filmBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.poster01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poster02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poster03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraPoster01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraPoster02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraPoster03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraPoster04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraPoster05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraPoster06)).BeginInit();
            this.extraPanel.SuspendLayout();
            this.treilerPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingNavigator)).BeginInit();
            this.filmBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // poster01
            // 
            this.poster01.Image = ((System.Drawing.Image)(resources.GetObject("poster01.Image")));
            this.poster01.Location = new System.Drawing.Point(475, 52);
            this.poster01.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.poster01.Name = "poster01";
            this.poster01.Size = new System.Drawing.Size(1096, 507);
            this.poster01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.poster01.TabIndex = 1;
            this.poster01.TabStop = false;
            this.poster01.Click += new System.EventHandler(this.poster01_Click);
            // 
            // arrowLeft
            // 
            this.arrowLeft.Image = ((System.Drawing.Image)(resources.GetObject("arrowLeft.Image")));
            this.arrowLeft.Location = new System.Drawing.Point(416, 286);
            this.arrowLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.arrowLeft.Name = "arrowLeft";
            this.arrowLeft.Size = new System.Drawing.Size(41, 41);
            this.arrowLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.arrowLeft.TabIndex = 8;
            this.arrowLeft.TabStop = false;
            this.arrowLeft.Click += new System.EventHandler(this.arrowLeft_Click);
            // 
            // arrowRight
            // 
            this.arrowRight.Image = ((System.Drawing.Image)(resources.GetObject("arrowRight.Image")));
            this.arrowRight.Location = new System.Drawing.Point(1576, 286);
            this.arrowRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.arrowRight.Name = "arrowRight";
            this.arrowRight.Size = new System.Drawing.Size(41, 41);
            this.arrowRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.arrowRight.TabIndex = 8;
            this.arrowRight.TabStop = false;
            this.arrowRight.Click += new System.EventHandler(this.arrowRight_Click);
            // 
            // scheduleIcon
            // 
            this.scheduleIcon.Image = ((System.Drawing.Image)(resources.GetObject("scheduleIcon.Image")));
            this.scheduleIcon.Location = new System.Drawing.Point(1990, 25);
            this.scheduleIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scheduleIcon.Name = "scheduleIcon";
            this.scheduleIcon.Size = new System.Drawing.Size(28, 24);
            this.scheduleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.scheduleIcon.TabIndex = 9;
            this.scheduleIcon.TabStop = false;
            this.scheduleIcon.Click += new System.EventHandler(this.scheduleIcon_Click);
            // 
            // AdminIcon
            // 
            this.AdminIcon.Image = ((System.Drawing.Image)(resources.GetObject("AdminIcon.Image")));
            this.AdminIcon.Location = new System.Drawing.Point(15, 14);
            this.AdminIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdminIcon.Name = "AdminIcon";
            this.AdminIcon.Size = new System.Drawing.Size(40, 40);
            this.AdminIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AdminIcon.TabIndex = 11;
            this.AdminIcon.TabStop = false;
            this.AdminIcon.Click += new System.EventHandler(this.AdminIcon_Click);
            // 
            // poster02
            // 
            this.poster02.Image = ((System.Drawing.Image)(resources.GetObject("poster02.Image")));
            this.poster02.Location = new System.Drawing.Point(476, 52);
            this.poster02.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.poster02.Name = "poster02";
            this.poster02.Size = new System.Drawing.Size(1096, 507);
            this.poster02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.poster02.TabIndex = 12;
            this.poster02.TabStop = false;
            this.poster02.Visible = false;
            this.poster02.Click += new System.EventHandler(this.poster02_Click);
            // 
            // poster03
            // 
            this.poster03.Image = ((System.Drawing.Image)(resources.GetObject("poster03.Image")));
            this.poster03.Location = new System.Drawing.Point(475, 52);
            this.poster03.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.poster03.Name = "poster03";
            this.poster03.Size = new System.Drawing.Size(1096, 507);
            this.poster03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.poster03.TabIndex = 13;
            this.poster03.TabStop = false;
            this.poster03.Visible = false;
            this.poster03.Click += new System.EventHandler(this.poster03_Click);
            // 
            // posterPnl1
            // 
            this.posterPnl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.posterPnl1.Location = new System.Drawing.Point(955, 566);
            this.posterPnl1.Margin = new System.Windows.Forms.Padding(4);
            this.posterPnl1.Name = "posterPnl1";
            this.posterPnl1.Size = new System.Drawing.Size(40, 18);
            this.posterPnl1.TabIndex = 14;
            this.posterPnl1.Click += new System.EventHandler(this.posterPnl1_Click);
            // 
            // posterPnl2
            // 
            this.posterPnl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.posterPnl2.Location = new System.Drawing.Point(1003, 566);
            this.posterPnl2.Margin = new System.Windows.Forms.Padding(4);
            this.posterPnl2.Name = "posterPnl2";
            this.posterPnl2.Size = new System.Drawing.Size(40, 18);
            this.posterPnl2.TabIndex = 15;
            this.posterPnl2.Click += new System.EventHandler(this.posterPnl2_Click);
            // 
            // posterPnl3
            // 
            this.posterPnl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.posterPnl3.Location = new System.Drawing.Point(1051, 566);
            this.posterPnl3.Margin = new System.Windows.Forms.Padding(4);
            this.posterPnl3.Name = "posterPnl3";
            this.posterPnl3.Size = new System.Drawing.Size(40, 18);
            this.posterPnl3.TabIndex = 16;
            this.posterPnl3.Click += new System.EventHandler(this.posterPnl3_Click);
            // 
            // extraPoster01
            // 
            this.extraPoster01.Image = ((System.Drawing.Image)(resources.GetObject("extraPoster01.Image")));
            this.extraPoster01.Location = new System.Drawing.Point(141, 64);
            this.extraPoster01.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.extraPoster01.Name = "extraPoster01";
            this.extraPoster01.Size = new System.Drawing.Size(248, 341);
            this.extraPoster01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.extraPoster01.TabIndex = 0;
            this.extraPoster01.TabStop = false;
            this.extraPoster01.Click += new System.EventHandler(this.extraPoster01_Click);
            // 
            // extraPoster02
            // 
            this.extraPoster02.Image = ((System.Drawing.Image)(resources.GetObject("extraPoster02.Image")));
            this.extraPoster02.Location = new System.Drawing.Point(443, 64);
            this.extraPoster02.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.extraPoster02.Name = "extraPoster02";
            this.extraPoster02.Size = new System.Drawing.Size(248, 341);
            this.extraPoster02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.extraPoster02.TabIndex = 1;
            this.extraPoster02.TabStop = false;
            this.extraPoster02.Click += new System.EventHandler(this.extraPoster02_Click);
            // 
            // extraPoster03
            // 
            this.extraPoster03.Image = ((System.Drawing.Image)(resources.GetObject("extraPoster03.Image")));
            this.extraPoster03.Location = new System.Drawing.Point(743, 64);
            this.extraPoster03.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.extraPoster03.Name = "extraPoster03";
            this.extraPoster03.Size = new System.Drawing.Size(248, 341);
            this.extraPoster03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.extraPoster03.TabIndex = 2;
            this.extraPoster03.TabStop = false;
            this.extraPoster03.Click += new System.EventHandler(this.extraPoster03_Click);
            // 
            // extraPoster04
            // 
            this.extraPoster04.Image = ((System.Drawing.Image)(resources.GetObject("extraPoster04.Image")));
            this.extraPoster04.Location = new System.Drawing.Point(1043, 64);
            this.extraPoster04.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.extraPoster04.Name = "extraPoster04";
            this.extraPoster04.Size = new System.Drawing.Size(248, 341);
            this.extraPoster04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.extraPoster04.TabIndex = 3;
            this.extraPoster04.TabStop = false;
            this.extraPoster04.Click += new System.EventHandler(this.extraPoster04_Click);
            // 
            // extraPoster05
            // 
            this.extraPoster05.Image = ((System.Drawing.Image)(resources.GetObject("extraPoster05.Image")));
            this.extraPoster05.Location = new System.Drawing.Point(1343, 64);
            this.extraPoster05.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.extraPoster05.Name = "extraPoster05";
            this.extraPoster05.Size = new System.Drawing.Size(248, 341);
            this.extraPoster05.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.extraPoster05.TabIndex = 4;
            this.extraPoster05.TabStop = false;
            this.extraPoster05.Click += new System.EventHandler(this.extraPoster05_Click);
            // 
            // extraPoster06
            // 
            this.extraPoster06.Image = ((System.Drawing.Image)(resources.GetObject("extraPoster06.Image")));
            this.extraPoster06.Location = new System.Drawing.Point(1643, 64);
            this.extraPoster06.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.extraPoster06.Name = "extraPoster06";
            this.extraPoster06.Size = new System.Drawing.Size(248, 341);
            this.extraPoster06.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.extraPoster06.TabIndex = 5;
            this.extraPoster06.TabStop = false;
            this.extraPoster06.Click += new System.EventHandler(this.extraPoster06_Click);
            // 
            // extraPanel
            // 
            this.extraPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
            this.extraPanel.Controls.Add(this.extraPoster06);
            this.extraPanel.Controls.Add(this.extraPoster05);
            this.extraPanel.Controls.Add(this.extraPoster04);
            this.extraPanel.Controls.Add(this.extraPoster03);
            this.extraPanel.Controls.Add(this.extraPoster02);
            this.extraPanel.Controls.Add(this.extraPoster01);
            this.extraPanel.Location = new System.Drawing.Point(0, 606);
            this.extraPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.extraPanel.Name = "extraPanel";
            this.extraPanel.Size = new System.Drawing.Size(2045, 455);
            this.extraPanel.TabIndex = 0;
            // 
            // treilerPnl
            // 
            this.treilerPnl.Controls.Add(this.panel1);
            this.treilerPnl.Controls.Add(this.descriptionRichTextBox);
            this.treilerPnl.Controls.Add(this.backIcon);
            this.treilerPnl.Controls.Add(this.VideoPnl);
            this.treilerPnl.Location = new System.Drawing.Point(115, 182);
            this.treilerPnl.Margin = new System.Windows.Forms.Padding(4);
            this.treilerPnl.Name = "treilerPnl";
            this.treilerPnl.Size = new System.Drawing.Size(1800, 738);
            this.treilerPnl.TabIndex = 17;
            this.treilerPnl.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(176)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.ratingTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1242, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 130);
            this.panel1.TabIndex = 0;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(176)))), ((int)(((byte)(52)))));
            this.ratingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ratingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmBindingSource, "Rating", true));
            this.ratingTextBox.Font = new System.Drawing.Font("Gotham Pro Medium", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ratingTextBox.ForeColor = System.Drawing.Color.White;
            this.ratingTextBox.Location = new System.Drawing.Point(9, 6);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(114, 75);
            this.ratingTextBox.TabIndex = 21;
            this.ratingTextBox.Text = "9.0";
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataMember = "Film";
            this.filmBindingSource.DataSource = this.myDataSet;
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "MyDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(176)))), ((int)(((byte)(52)))));
            this.label2.Font = new System.Drawing.Font("Gotham Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "IMDb";
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmBindingSource, "Description", true));
            this.descriptionRichTextBox.Font = new System.Drawing.Font("Gotham Pro Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionRichTextBox.Location = new System.Drawing.Point(1242, 289);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(500, 391);
            this.descriptionRichTextBox.TabIndex = 19;
            this.descriptionRichTextBox.Text = "";
            // 
            // backIcon
            // 
            this.backIcon.Image = ((System.Drawing.Image)(resources.GetObject("backIcon.Image")));
            this.backIcon.Location = new System.Drawing.Point(4, 4);
            this.backIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backIcon.Name = "backIcon";
            this.backIcon.Size = new System.Drawing.Size(52, 52);
            this.backIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.backIcon.TabIndex = 18;
            this.backIcon.TabStop = false;
            this.backIcon.Click += new System.EventHandler(this.backIcon_Click);
            // 
            // VideoPnl
            // 
            this.VideoPnl.Location = new System.Drawing.Point(74, 51);
            this.VideoPnl.Name = "VideoPnl";
            this.VideoPnl.Size = new System.Drawing.Size(1100, 645);
            this.VideoPnl.TabIndex = 4;
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FilmTableAdapter = this.filmTableAdapter;
            this.tableAdapterManager.UpdateOrder = CinemaTerminal.MyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // filmBindingNavigator
            // 
            this.filmBindingNavigator.AddNewItem = null;
            this.filmBindingNavigator.BindingSource = this.filmBindingSource;
            this.filmBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.filmBindingNavigator.DeleteItem = null;
            this.filmBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.filmBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.filmBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.filmBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.filmBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.filmBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.filmBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.filmBindingNavigator.Name = "filmBindingNavigator";
            this.filmBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.filmBindingNavigator.Size = new System.Drawing.Size(2045, 27);
            this.filmBindingNavigator.TabIndex = 112;
            this.filmBindingNavigator.Text = "bindingNavigator1";
            this.filmBindingNavigator.Visible = false;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Enabled = false;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.filmBindingNavigator);
            this.Controls.Add(this.treilerPnl);
            this.Controls.Add(this.posterPnl3);
            this.Controls.Add(this.posterPnl2);
            this.Controls.Add(this.posterPnl1);
            this.Controls.Add(this.poster03);
            this.Controls.Add(this.poster02);
            this.Controls.Add(this.poster01);
            this.Controls.Add(this.AdminIcon);
            this.Controls.Add(this.scheduleIcon);
            this.Controls.Add(this.arrowRight);
            this.Controls.Add(this.arrowLeft);
            this.Controls.Add(this.extraPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.TransparencyKey = System.Drawing.Color.Indigo;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poster01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poster02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poster03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraPoster01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraPoster02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraPoster03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraPoster04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraPoster05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraPoster06)).EndInit();
            this.extraPanel.ResumeLayout(false);
            this.treilerPnl.ResumeLayout(false);
            this.treilerPnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingNavigator)).EndInit();
            this.filmBindingNavigator.ResumeLayout(false);
            this.filmBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox poster01;
        private System.Windows.Forms.PictureBox arrowLeft;
        private System.Windows.Forms.PictureBox arrowRight;
        private System.Windows.Forms.PictureBox scheduleIcon;
        private System.Windows.Forms.PictureBox AdminIcon;
        private System.Windows.Forms.PictureBox poster02;
        private System.Windows.Forms.PictureBox poster03;
        private System.Windows.Forms.Panel posterPnl1;
        private System.Windows.Forms.Panel posterPnl2;
        private System.Windows.Forms.Panel posterPnl3;
        private System.Windows.Forms.PictureBox extraPoster01;
        private System.Windows.Forms.PictureBox extraPoster02;
        private System.Windows.Forms.PictureBox extraPoster03;
        private System.Windows.Forms.PictureBox extraPoster04;
        private System.Windows.Forms.PictureBox extraPoster05;
        private System.Windows.Forms.PictureBox extraPoster06;
        private System.Windows.Forms.Panel extraPanel;
        private System.Windows.Forms.Panel treilerPnl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel VideoPnl;
        private System.Windows.Forms.PictureBox backIcon;
        private MyDataSet myDataSet;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private MyDataSetTableAdapters.FilmTableAdapter filmTableAdapter;
        private MyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.BindingNavigator filmBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}

