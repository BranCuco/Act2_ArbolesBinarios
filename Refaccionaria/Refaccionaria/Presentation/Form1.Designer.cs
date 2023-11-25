namespace Refaccionaria
{
    partial class Form1
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
        public void InitializeComponent()
        {
            this.name = new System.Windows.Forms.Label();
            this.storageTonnage = new System.Windows.Forms.Label();
            this.licensePlates = new System.Windows.Forms.Label();
            this.carBrand = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.cardBrand_textBox = new System.Windows.Forms.TextBox();
            this.licensePlates_textBox = new System.Windows.Forms.TextBox();
            this.storageTonnage_textBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnFilter = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.Label();
            this.clave_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(119, 221);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(56, 24);
            this.name.TabIndex = 0;
            this.name.Text = "Nombre";
            this.name.Click += new System.EventHandler(this.label1_Click);
            // 
            // storageTonnage
            // 
            this.storageTonnage.AutoSize = true;
            this.storageTonnage.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storageTonnage.Location = new System.Drawing.Point(485, 129);
            this.storageTonnage.Name = "storageTonnage";
            this.storageTonnage.Size = new System.Drawing.Size(144, 24);
            this.storageTonnage.TabIndex = 1;
            this.storageTonnage.Text = "Tonelaje de Almacenaje";
            // 
            // licensePlates
            // 
            this.licensePlates.AutoSize = true;
            this.licensePlates.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licensePlates.Location = new System.Drawing.Point(119, 305);
            this.licensePlates.Name = "licensePlates";
            this.licensePlates.Size = new System.Drawing.Size(49, 24);
            this.licensePlates.TabIndex = 2;
            this.licensePlates.Text = "Placas";
            // 
            // carBrand
            // 
            this.carBrand.AutoSize = true;
            this.carBrand.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carBrand.Location = new System.Drawing.Point(485, 221);
            this.carBrand.Name = "carBrand";
            this.carBrand.Size = new System.Drawing.Size(46, 24);
            this.carBrand.TabIndex = 3;
            this.carBrand.Text = "Marca";
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(122, 249);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(197, 22);
            this.name_textBox.TabIndex = 4;
            // 
            // cardBrand_textBox
            // 
            this.cardBrand_textBox.Location = new System.Drawing.Point(488, 249);
            this.cardBrand_textBox.Name = "cardBrand_textBox";
            this.cardBrand_textBox.Size = new System.Drawing.Size(197, 22);
            this.cardBrand_textBox.TabIndex = 5;
            // 
            // licensePlates_textBox
            // 
            this.licensePlates_textBox.Location = new System.Drawing.Point(122, 341);
            this.licensePlates_textBox.Name = "licensePlates_textBox";
            this.licensePlates_textBox.Size = new System.Drawing.Size(197, 22);
            this.licensePlates_textBox.TabIndex = 6;
            // 
            // storageTonnage_textBox
            // 
            this.storageTonnage_textBox.Location = new System.Drawing.Point(488, 157);
            this.storageTonnage_textBox.Name = "storageTonnage_textBox";
            this.storageTonnage_textBox.Size = new System.Drawing.Size(197, 22);
            this.storageTonnage_textBox.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(83, 405);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(641, 181);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(596, 335);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(110, 34);
            this.btnFilter.TabIndex = 12;
            this.btnFilter.Text = "Buscar";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.Location = new System.Drawing.Point(118, 121);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(40, 24);
            this.Id.TabIndex = 13;
            this.Id.Text = "Clave";
            // 
            // clave_textBox
            // 
            this.clave_textBox.Location = new System.Drawing.Point(122, 157);
            this.clave_textBox.Name = "clave_textBox";
            this.clave_textBox.Size = new System.Drawing.Size(197, 22);
            this.clave_textBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(242, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 72);
            this.label1.TabIndex = 16;
            this.label1.Text = "Refaccionaria";
            // 
            // btnTodo
            // 
            this.btnTodo.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodo.Location = new System.Drawing.Point(464, 335);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(110, 34);
            this.btnTodo.TabIndex = 15;
            this.btnTodo.Text = "Todos";
            this.btnTodo.UseVisualStyleBackColor = true;
            this.btnTodo.Click += new System.EventHandler(this.btnTodo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTodo);
            this.Controls.Add(this.clave_textBox);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.storageTonnage_textBox);
            this.Controls.Add(this.licensePlates_textBox);
            this.Controls.Add(this.cardBrand_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.carBrand);
            this.Controls.Add(this.licensePlates);
            this.Controls.Add(this.storageTonnage);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label storageTonnage;
        private System.Windows.Forms.Label licensePlates;
        private System.Windows.Forms.Label carBrand;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox cardBrand_textBox;
        private System.Windows.Forms.TextBox licensePlates_textBox;
        private System.Windows.Forms.TextBox storageTonnage_textBox;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.TextBox clave_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTodo;
    }
}

