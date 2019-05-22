namespace CinemaTerminal
{
    partial class EditingForm
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label ratingLabel;
            System.Windows.Forms.Label elementLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingForm));
            this.posterLbl = new System.Windows.Forms.Label();
            this.trailerLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.posterAddresBox = new System.Windows.Forms.TextBox();
            this.treillerAddresBox = new System.Windows.Forms.TextBox();
            this.myDataSet = new CinemaTerminal.MyDataSet();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.addTreilerOFD = new System.Windows.Forms.PictureBox();
            this.addPosterOFD = new System.Windows.Forms.PictureBox();
            this.elementTextBox = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ratingLabel = new System.Windows.Forms.Label();
            elementLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingNavigator)).BeginInit();
            this.filmBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addTreilerOFD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPosterOFD)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Gotham Pro Medium", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.Location = new System.Drawing.Point(462, 431);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(164, 49);
            nameLabel.TabIndex = 112;
            nameLabel.Text = "Name:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Gotham Pro Medium", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            descriptionLabel.Location = new System.Drawing.Point(462, 556);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(289, 49);
            descriptionLabel.TabIndex = 113;
            descriptionLabel.Text = "Description:";
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Font = new System.Drawing.Font("Gotham Pro Medium", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ratingLabel.Location = new System.Drawing.Point(553, 668);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(179, 49);
            ratingLabel.TabIndex = 114;
            ratingLabel.Text = "Rating:";
            // 
            // elementLabel1
            // 
            elementLabel1.AutoSize = true;
            elementLabel1.Font = new System.Drawing.Font("Gotham Pro Medium", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            elementLabel1.Location = new System.Drawing.Point(462, 56);
            elementLabel1.Name = "elementLabel1";
            elementLabel1.Size = new System.Drawing.Size(217, 49);
            elementLabel1.TabIndex = 117;
            elementLabel1.Text = "Element:";
            // 
            // posterLbl
            // 
            this.posterLbl.AutoSize = true;
            this.posterLbl.Font = new System.Drawing.Font("Gotham Pro Medium", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posterLbl.Location = new System.Drawing.Point(462, 306);
            this.posterLbl.Name = "posterLbl";
            this.posterLbl.Size = new System.Drawing.Size(377, 49);
            this.posterLbl.TabIndex = 5;
            this.posterLbl.Text = "Постер фильма";
            // 
            // trailerLbl
            // 
            this.trailerLbl.AutoSize = true;
            this.trailerLbl.Font = new System.Drawing.Font("Gotham Pro Medium", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trailerLbl.Location = new System.Drawing.Point(462, 181);
            this.trailerLbl.Name = "trailerLbl";
            this.trailerLbl.Size = new System.Drawing.Size(408, 49);
            this.trailerLbl.TabIndex = 6;
            this.trailerLbl.Text = "Трейлер фильма";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(106)))), ((int)(((byte)(201)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Gotham Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(748, 980);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(171, 50);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Gotham Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(949, 980);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(171, 50);
            this.cancelBtn.TabIndex = 106;
            this.cancelBtn.Text = "Отменить";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // posterAddresBox
            // 
            this.posterAddresBox.Font = new System.Drawing.Font("Gotham Pro Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.posterAddresBox.Location = new System.Drawing.Point(933, 318);
            this.posterAddresBox.Multiline = true;
            this.posterAddresBox.Name = "posterAddresBox";
            this.posterAddresBox.Size = new System.Drawing.Size(525, 33);
            this.posterAddresBox.TabIndex = 109;
            // 
            // treillerAddresBox
            // 
            this.treillerAddresBox.Font = new System.Drawing.Font("Gotham Pro Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treillerAddresBox.Location = new System.Drawing.Point(933, 194);
            this.treillerAddresBox.Multiline = true;
            this.treillerAddresBox.Name = "treillerAddresBox";
            this.treillerAddresBox.Size = new System.Drawing.Size(525, 33);
            this.treillerAddresBox.TabIndex = 110;
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "MyDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataMember = "Film";
            this.filmBindingSource.DataSource = this.myDataSet;
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
            this.filmBindingNavigator.Size = new System.Drawing.Size(1920, 27);
            this.filmBindingNavigator.TabIndex = 111;
            this.filmBindingNavigator.Text = "bindingNavigator1";
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
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmBindingSource, "Name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Gotham Pro Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(933, 442);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(525, 33);
            this.nameTextBox.TabIndex = 113;
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmBindingSource, "Description", true));
            this.descriptionRichTextBox.Font = new System.Drawing.Font("Gotham Pro Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionRichTextBox.Location = new System.Drawing.Point(933, 556);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(525, 400);
            this.descriptionRichTextBox.TabIndex = 114;
            this.descriptionRichTextBox.Text = "";
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmBindingSource, "Rating", true));
            this.ratingTextBox.Font = new System.Drawing.Font("Gotham Pro Medium", 58F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ratingTextBox.Location = new System.Drawing.Point(556, 734);
            this.ratingTextBox.Multiline = true;
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(170, 116);
            this.ratingTextBox.TabIndex = 115;
            // 
            // addTreilerOFD
            // 
            this.addTreilerOFD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addTreilerOFD.Image = ((System.Drawing.Image)(resources.GetObject("addTreilerOFD.Image")));
            this.addTreilerOFD.Location = new System.Drawing.Point(1457, 194);
            this.addTreilerOFD.Name = "addTreilerOFD";
            this.addTreilerOFD.Size = new System.Drawing.Size(35, 34);
            this.addTreilerOFD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addTreilerOFD.TabIndex = 116;
            this.addTreilerOFD.TabStop = false;
            this.addTreilerOFD.Click += new System.EventHandler(this.addTreilerOFD_Click);
            // 
            // addPosterOFD
            // 
            this.addPosterOFD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addPosterOFD.Image = ((System.Drawing.Image)(resources.GetObject("addPosterOFD.Image")));
            this.addPosterOFD.Location = new System.Drawing.Point(1457, 318);
            this.addPosterOFD.Name = "addPosterOFD";
            this.addPosterOFD.Size = new System.Drawing.Size(35, 34);
            this.addPosterOFD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addPosterOFD.TabIndex = 117;
            this.addPosterOFD.TabStop = false;
            this.addPosterOFD.Click += new System.EventHandler(this.addPosterOFD_Click);
            // 
            // elementTextBox
            // 
            this.elementTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmBindingSource, "Element", true));
            this.elementTextBox.Font = new System.Drawing.Font("Gotham Pro Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.elementTextBox.Location = new System.Drawing.Point(933, 63);
            this.elementTextBox.Name = "elementTextBox";
            this.elementTextBox.Size = new System.Drawing.Size(525, 37);
            this.elementTextBox.TabIndex = 118;
            // 
            // EditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(elementLabel1);
            this.Controls.Add(this.elementTextBox);
            this.Controls.Add(this.addPosterOFD);
            this.Controls.Add(this.addTreilerOFD);
            this.Controls.Add(ratingLabel);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.filmBindingNavigator);
            this.Controls.Add(this.treillerAddresBox);
            this.Controls.Add(this.posterAddresBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.trailerLbl);
            this.Controls.Add(this.posterLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditingForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EditingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingNavigator)).EndInit();
            this.filmBindingNavigator.ResumeLayout(false);
            this.filmBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addTreilerOFD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPosterOFD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label posterLbl;
        private System.Windows.Forms.Label trailerLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox posterAddresBox;
        private System.Windows.Forms.TextBox treillerAddresBox;
        private MyDataSet myDataSet;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private MyDataSetTableAdapters.FilmTableAdapter filmTableAdapter;
        private MyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.PictureBox addTreilerOFD;
        private System.Windows.Forms.PictureBox addPosterOFD;
        private System.Windows.Forms.TextBox elementTextBox;
    }
}