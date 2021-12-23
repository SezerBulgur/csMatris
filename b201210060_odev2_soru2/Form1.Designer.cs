
namespace b201210060_odev2_soru2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.numA00 = new System.Windows.Forms.NumericUpDown();
            this.numA02 = new System.Windows.Forms.NumericUpDown();
            this.numA01 = new System.Windows.Forms.NumericUpDown();
            this.numA10 = new System.Windows.Forms.NumericUpDown();
            this.numA12 = new System.Windows.Forms.NumericUpDown();
            this.numA11 = new System.Windows.Forms.NumericUpDown();
            this.numA20 = new System.Windows.Forms.NumericUpDown();
            this.numA22 = new System.Windows.Forms.NumericUpDown();
            this.numA21 = new System.Windows.Forms.NumericUpDown();
            this.numB00 = new System.Windows.Forms.NumericUpDown();
            this.numB10 = new System.Windows.Forms.NumericUpDown();
            this.numB20 = new System.Windows.Forms.NumericUpDown();
            this.numB02 = new System.Windows.Forms.NumericUpDown();
            this.numB12 = new System.Windows.Forms.NumericUpDown();
            this.numB22 = new System.Windows.Forms.NumericUpDown();
            this.numB01 = new System.Windows.Forms.NumericUpDown();
            this.numB11 = new System.Windows.Forms.NumericUpDown();
            this.numB21 = new System.Windows.Forms.NumericUpDown();
            this.butTopla = new System.Windows.Forms.Button();
            this.butCarp = new System.Windows.Forms.Button();
            this.sonucKutusu = new System.Windows.Forms.RichTextBox();
            this.gecmisKutusu = new System.Windows.Forms.RichTextBox();
            this.butGecmis = new System.Windows.Forms.Button();
            this.butCıkıs = new System.Windows.Forms.Button();
            this.butYaz = new System.Windows.Forms.Button();
            this.butTranspoz = new System.Windows.Forms.Button();
            this.butIz = new System.Windows.Forms.Button();
            this.butDeterminant = new System.Windows.Forms.Button();
            this.butEkMatris = new System.Windows.Forms.Button();
            this.butTers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numA00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB21)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(170, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "A MATRİSİ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(610, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(170, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "B MATRİSİ";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numA00
            // 
            this.numA00.DecimalPlaces = 1;
            this.numA00.Location = new System.Drawing.Point(20, 70);
            this.numA00.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numA00.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numA00.Name = "numA00";
            this.numA00.Size = new System.Drawing.Size(38, 23);
            this.numA00.TabIndex = 3;
            this.numA00.ValueChanged += new System.EventHandler(this.numA00_ValueChanged);
            // 
            // numA02
            // 
            this.numA02.DecimalPlaces = 1;
            this.numA02.Location = new System.Drawing.Point(152, 70);
            this.numA02.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numA02.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numA02.Name = "numA02";
            this.numA02.Size = new System.Drawing.Size(38, 23);
            this.numA02.TabIndex = 3;
            this.numA02.ValueChanged += new System.EventHandler(this.numA02_ValueChanged);
            // 
            // numA01
            // 
            this.numA01.DecimalPlaces = 1;
            this.numA01.Location = new System.Drawing.Point(86, 70);
            this.numA01.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numA01.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numA01.Name = "numA01";
            this.numA01.Size = new System.Drawing.Size(38, 23);
            this.numA01.TabIndex = 3;
            this.numA01.ValueChanged += new System.EventHandler(this.numA01_ValueChanged);
            // 
            // numA10
            // 
            this.numA10.DecimalPlaces = 1;
            this.numA10.Location = new System.Drawing.Point(20, 109);
            this.numA10.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numA10.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numA10.Name = "numA10";
            this.numA10.Size = new System.Drawing.Size(38, 23);
            this.numA10.TabIndex = 3;
            this.numA10.ValueChanged += new System.EventHandler(this.numA10_ValueChanged);
            // 
            // numA12
            // 
            this.numA12.DecimalPlaces = 1;
            this.numA12.Location = new System.Drawing.Point(152, 109);
            this.numA12.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numA12.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numA12.Name = "numA12";
            this.numA12.Size = new System.Drawing.Size(38, 23);
            this.numA12.TabIndex = 3;
            this.numA12.ValueChanged += new System.EventHandler(this.numA12_ValueChanged);
            // 
            // numA11
            // 
            this.numA11.DecimalPlaces = 1;
            this.numA11.Location = new System.Drawing.Point(86, 109);
            this.numA11.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numA11.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numA11.Name = "numA11";
            this.numA11.Size = new System.Drawing.Size(38, 23);
            this.numA11.TabIndex = 3;
            this.numA11.ValueChanged += new System.EventHandler(this.numA11_ValueChanged);
            // 
            // numA20
            // 
            this.numA20.DecimalPlaces = 1;
            this.numA20.Location = new System.Drawing.Point(20, 151);
            this.numA20.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numA20.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numA20.Name = "numA20";
            this.numA20.Size = new System.Drawing.Size(38, 23);
            this.numA20.TabIndex = 3;
            this.numA20.ValueChanged += new System.EventHandler(this.numA20_ValueChanged);
            // 
            // numA22
            // 
            this.numA22.DecimalPlaces = 1;
            this.numA22.Location = new System.Drawing.Point(152, 151);
            this.numA22.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numA22.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numA22.Name = "numA22";
            this.numA22.Size = new System.Drawing.Size(38, 23);
            this.numA22.TabIndex = 3;
            this.numA22.ValueChanged += new System.EventHandler(this.numA22_ValueChanged);
            // 
            // numA21
            // 
            this.numA21.DecimalPlaces = 1;
            this.numA21.Location = new System.Drawing.Point(86, 151);
            this.numA21.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numA21.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numA21.Name = "numA21";
            this.numA21.Size = new System.Drawing.Size(38, 23);
            this.numA21.TabIndex = 3;
            this.numA21.ValueChanged += new System.EventHandler(this.numA21_ValueChanged);
            // 
            // numB00
            // 
            this.numB00.DecimalPlaces = 1;
            this.numB00.Location = new System.Drawing.Point(610, 70);
            this.numB00.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numB00.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numB00.Name = "numB00";
            this.numB00.Size = new System.Drawing.Size(38, 23);
            this.numB00.TabIndex = 3;
            this.numB00.ValueChanged += new System.EventHandler(this.numB00_ValueChanged);
            // 
            // numB10
            // 
            this.numB10.DecimalPlaces = 1;
            this.numB10.Location = new System.Drawing.Point(610, 109);
            this.numB10.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numB10.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numB10.Name = "numB10";
            this.numB10.Size = new System.Drawing.Size(38, 23);
            this.numB10.TabIndex = 3;
            this.numB10.ValueChanged += new System.EventHandler(this.numB10_ValueChanged);
            // 
            // numB20
            // 
            this.numB20.DecimalPlaces = 1;
            this.numB20.Location = new System.Drawing.Point(610, 151);
            this.numB20.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numB20.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numB20.Name = "numB20";
            this.numB20.Size = new System.Drawing.Size(38, 23);
            this.numB20.TabIndex = 3;
            this.numB20.ValueChanged += new System.EventHandler(this.numB20_ValueChanged);
            // 
            // numB02
            // 
            this.numB02.DecimalPlaces = 1;
            this.numB02.Location = new System.Drawing.Point(742, 70);
            this.numB02.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numB02.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numB02.Name = "numB02";
            this.numB02.Size = new System.Drawing.Size(38, 23);
            this.numB02.TabIndex = 3;
            this.numB02.ValueChanged += new System.EventHandler(this.numB02_ValueChanged);
            // 
            // numB12
            // 
            this.numB12.DecimalPlaces = 1;
            this.numB12.Location = new System.Drawing.Point(742, 109);
            this.numB12.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numB12.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numB12.Name = "numB12";
            this.numB12.Size = new System.Drawing.Size(38, 23);
            this.numB12.TabIndex = 3;
            this.numB12.ValueChanged += new System.EventHandler(this.numB12_ValueChanged);
            // 
            // numB22
            // 
            this.numB22.DecimalPlaces = 1;
            this.numB22.Location = new System.Drawing.Point(742, 151);
            this.numB22.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numB22.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numB22.Name = "numB22";
            this.numB22.Size = new System.Drawing.Size(38, 23);
            this.numB22.TabIndex = 3;
            this.numB22.ValueChanged += new System.EventHandler(this.numB22_ValueChanged);
            // 
            // numB01
            // 
            this.numB01.DecimalPlaces = 1;
            this.numB01.Location = new System.Drawing.Point(676, 70);
            this.numB01.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numB01.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numB01.Name = "numB01";
            this.numB01.Size = new System.Drawing.Size(38, 23);
            this.numB01.TabIndex = 3;
            this.numB01.ValueChanged += new System.EventHandler(this.numB01_ValueChanged);
            // 
            // numB11
            // 
            this.numB11.DecimalPlaces = 1;
            this.numB11.Location = new System.Drawing.Point(676, 109);
            this.numB11.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numB11.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numB11.Name = "numB11";
            this.numB11.Size = new System.Drawing.Size(38, 23);
            this.numB11.TabIndex = 3;
            this.numB11.ValueChanged += new System.EventHandler(this.numB11_ValueChanged);
            // 
            // numB21
            // 
            this.numB21.DecimalPlaces = 1;
            this.numB21.Location = new System.Drawing.Point(676, 151);
            this.numB21.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numB21.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numB21.Name = "numB21";
            this.numB21.Size = new System.Drawing.Size(38, 23);
            this.numB21.TabIndex = 3;
            this.numB21.ValueChanged += new System.EventHandler(this.numB21_ValueChanged);
            // 
            // butTopla
            // 
            this.butTopla.Location = new System.Drawing.Point(295, 70);
            this.butTopla.Name = "butTopla";
            this.butTopla.Size = new System.Drawing.Size(210, 43);
            this.butTopla.TabIndex = 4;
            this.butTopla.Text = "Topla";
            this.butTopla.UseVisualStyleBackColor = true;
            this.butTopla.Click += new System.EventHandler(this.butTopla_Click);
            // 
            // butCarp
            // 
            this.butCarp.Location = new System.Drawing.Point(295, 131);
            this.butCarp.Name = "butCarp";
            this.butCarp.Size = new System.Drawing.Size(210, 43);
            this.butCarp.TabIndex = 4;
            this.butCarp.Text = "Çarp";
            this.butCarp.UseVisualStyleBackColor = true;
            this.butCarp.Click += new System.EventHandler(this.butCarp_Click);
            // 
            // sonucKutusu
            // 
            this.sonucKutusu.Location = new System.Drawing.Point(295, 226);
            this.sonucKutusu.Name = "sonucKutusu";
            this.sonucKutusu.ReadOnly = true;
            this.sonucKutusu.Size = new System.Drawing.Size(210, 139);
            this.sonucKutusu.TabIndex = 5;
            this.sonucKutusu.Text = "";
            // 
            // gecmisKutusu
            // 
            this.gecmisKutusu.Location = new System.Drawing.Point(610, 240);
            this.gecmisKutusu.Name = "gecmisKutusu";
            this.gecmisKutusu.ReadOnly = true;
            this.gecmisKutusu.Size = new System.Drawing.Size(170, 198);
            this.gecmisKutusu.TabIndex = 6;
            this.gecmisKutusu.Text = "";
            // 
            // butGecmis
            // 
            this.butGecmis.Location = new System.Drawing.Point(610, 193);
            this.butGecmis.Name = "butGecmis";
            this.butGecmis.Size = new System.Drawing.Size(170, 28);
            this.butGecmis.TabIndex = 7;
            this.butGecmis.Text = "Geçmiş/Yenile";
            this.butGecmis.UseVisualStyleBackColor = true;
            this.butGecmis.Click += new System.EventHandler(this.butGecmis_Click);
            // 
            // butCıkıs
            // 
            this.butCıkıs.Location = new System.Drawing.Point(295, 385);
            this.butCıkıs.Name = "butCıkıs";
            this.butCıkıs.Size = new System.Drawing.Size(210, 43);
            this.butCıkıs.TabIndex = 8;
            this.butCıkıs.Text = "Çıkış";
            this.butCıkıs.UseVisualStyleBackColor = true;
            this.butCıkıs.Click += new System.EventHandler(this.butCıkıs_Click);
            // 
            // butYaz
            // 
            this.butYaz.Location = new System.Drawing.Point(20, 193);
            this.butYaz.Name = "butYaz";
            this.butYaz.Size = new System.Drawing.Size(170, 28);
            this.butYaz.TabIndex = 9;
            this.butYaz.Text = "Matris yazdır";
            this.butYaz.UseVisualStyleBackColor = true;
            this.butYaz.Click += new System.EventHandler(this.butYaz_Click);
            // 
            // butTranspoz
            // 
            this.butTranspoz.Location = new System.Drawing.Point(20, 227);
            this.butTranspoz.Name = "butTranspoz";
            this.butTranspoz.Size = new System.Drawing.Size(170, 28);
            this.butTranspoz.TabIndex = 9;
            this.butTranspoz.Text = "Matrisin transpozu";
            this.butTranspoz.UseVisualStyleBackColor = true;
            this.butTranspoz.Click += new System.EventHandler(this.butTranspoz_Click);
            // 
            // butIz
            // 
            this.butIz.Location = new System.Drawing.Point(20, 261);
            this.butIz.Name = "butIz";
            this.butIz.Size = new System.Drawing.Size(170, 28);
            this.butIz.TabIndex = 9;
            this.butIz.Text = "Matrisin izi";
            this.butIz.UseVisualStyleBackColor = true;
            this.butIz.Click += new System.EventHandler(this.butIz_Click);
            // 
            // butDeterminant
            // 
            this.butDeterminant.Location = new System.Drawing.Point(20, 295);
            this.butDeterminant.Name = "butDeterminant";
            this.butDeterminant.Size = new System.Drawing.Size(170, 28);
            this.butDeterminant.TabIndex = 9;
            this.butDeterminant.Text = "Matrisin determinantı";
            this.butDeterminant.UseVisualStyleBackColor = true;
            this.butDeterminant.Click += new System.EventHandler(this.butDeterminant_Click);
            // 
            // butEkMatris
            // 
            this.butEkMatris.Location = new System.Drawing.Point(20, 329);
            this.butEkMatris.Name = "butEkMatris";
            this.butEkMatris.Size = new System.Drawing.Size(170, 28);
            this.butEkMatris.TabIndex = 9;
            this.butEkMatris.Text = "Ek Matrisi";
            this.butEkMatris.UseVisualStyleBackColor = true;
            this.butEkMatris.Click += new System.EventHandler(this.butEkMatris_Click);
            // 
            // butTers
            // 
            this.butTers.Location = new System.Drawing.Point(20, 363);
            this.butTers.Name = "butTers";
            this.butTers.Size = new System.Drawing.Size(170, 28);
            this.butTers.TabIndex = 9;
            this.butTers.Text = "Tersi";
            this.butTers.UseVisualStyleBackColor = true;
            this.butTers.Click += new System.EventHandler(this.butTers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butTers);
            this.Controls.Add(this.butEkMatris);
            this.Controls.Add(this.butDeterminant);
            this.Controls.Add(this.butIz);
            this.Controls.Add(this.butTranspoz);
            this.Controls.Add(this.butYaz);
            this.Controls.Add(this.butCıkıs);
            this.Controls.Add(this.butGecmis);
            this.Controls.Add(this.gecmisKutusu);
            this.Controls.Add(this.sonucKutusu);
            this.Controls.Add(this.butCarp);
            this.Controls.Add(this.butTopla);
            this.Controls.Add(this.numB21);
            this.Controls.Add(this.numA21);
            this.Controls.Add(this.numB11);
            this.Controls.Add(this.numA11);
            this.Controls.Add(this.numB01);
            this.Controls.Add(this.numA01);
            this.Controls.Add(this.numB22);
            this.Controls.Add(this.numA22);
            this.Controls.Add(this.numB12);
            this.Controls.Add(this.numA12);
            this.Controls.Add(this.numB02);
            this.Controls.Add(this.numA02);
            this.Controls.Add(this.numB20);
            this.Controls.Add(this.numA20);
            this.Controls.Add(this.numB10);
            this.Controls.Add(this.numA10);
            this.Controls.Add(this.numB00);
            this.Controls.Add(this.numA00);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numA00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown numA00;
        private System.Windows.Forms.NumericUpDown numA02;
        private System.Windows.Forms.NumericUpDown numA01;
        private System.Windows.Forms.NumericUpDown numA10;
        private System.Windows.Forms.NumericUpDown numA12;
        private System.Windows.Forms.NumericUpDown numA11;
        private System.Windows.Forms.NumericUpDown numA20;
        private System.Windows.Forms.NumericUpDown numA22;
        private System.Windows.Forms.NumericUpDown numA21;
        private System.Windows.Forms.NumericUpDown numB00;
        private System.Windows.Forms.NumericUpDown numB10;
        private System.Windows.Forms.NumericUpDown numB20;
        private System.Windows.Forms.NumericUpDown numB02;
        private System.Windows.Forms.NumericUpDown numB12;
        private System.Windows.Forms.NumericUpDown numB22;
        private System.Windows.Forms.NumericUpDown numB01;
        private System.Windows.Forms.NumericUpDown numB11;
        private System.Windows.Forms.NumericUpDown numB21;
        private System.Windows.Forms.Button butTopla;
        private System.Windows.Forms.Button butCarp;
        private System.Windows.Forms.RichTextBox sonucKutusu;
        private System.Windows.Forms.RichTextBox gecmisKutusu;
        private System.Windows.Forms.Button butGecmis;
        private System.Windows.Forms.Button butCıkıs;
        private System.Windows.Forms.Button butYaz;
        private System.Windows.Forms.Button butTranspoz;
        private System.Windows.Forms.Button butIz;
        private System.Windows.Forms.Button butDeterminant;
        private System.Windows.Forms.Button butEkMatris;
        private System.Windows.Forms.Button butTers;
    }
}

