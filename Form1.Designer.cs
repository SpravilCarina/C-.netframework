namespace lab1
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
        private void InitializeComponent()
        {
            this.textBox_nume = new System.Windows.Forms.TextBox();
            this.label_nume = new System.Windows.Forms.Label();
            this.numericUpDown_varsta = new System.Windows.Forms.NumericUpDown();
            this.label_varsta = new System.Windows.Forms.Label();
            this.comboBox_an = new System.Windows.Forms.ComboBox();
            this.label_an = new System.Windows.Forms.Label();
            this.button_adaugare = new System.Windows.Forms.Button();
            this.listBox_studenti = new System.Windows.Forms.ListBox();
            this.label_lista = new System.Windows.Forms.Label();
            this.button_sortareAsc = new System.Windows.Forms.Button();
            this.groupBox_note = new System.Windows.Forms.GroupBox();
            this.numericUpDown_nota4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_nota3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_nota2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_nota1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_nota0 = new System.Windows.Forms.NumericUpDown();
            this.button_sortareDesc = new System.Windows.Forms.Button();
            this.button_stergereLista = new System.Windows.Forms.Button();
            this.groupBox_actiuni = new System.Windows.Forms.GroupBox();
            this.button_stergereStudent = new System.Windows.Forms.Button();
            this.groupBox_afisare = new System.Windows.Forms.GroupBox();
            this.button_afisareLista = new System.Windows.Forms.Button();
            this.textBox_numeCautare = new System.Windows.Forms.TextBox();
            this.comboBox_anAfisare = new System.Windows.Forms.ComboBox();
            this.button_cautare = new System.Windows.Forms.Button();
            this.button_afisareAn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_varsta)).BeginInit();
            this.groupBox_note.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nota4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nota3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nota2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nota1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nota0)).BeginInit();
            this.groupBox_actiuni.SuspendLayout();
            this.groupBox_afisare.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_nume
            // 
            this.textBox_nume.Location = new System.Drawing.Point(84, 18);
            this.textBox_nume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_nume.Name = "textBox_nume";
            this.textBox_nume.Size = new System.Drawing.Size(236, 26);
            this.textBox_nume.TabIndex = 0;
            // 
            // label_nume
            // 
            this.label_nume.AutoSize = true;
            this.label_nume.Location = new System.Drawing.Point(18, 23);
            this.label_nume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_nume.Name = "label_nume";
            this.label_nume.Size = new System.Drawing.Size(55, 20);
            this.label_nume.TabIndex = 1;
            this.label_nume.Text = "Nume:";
            this.label_nume.Click += new System.EventHandler(this.label_nume_Click);
            // 
            // numericUpDown_varsta
            // 
            this.numericUpDown_varsta.Location = new System.Drawing.Point(105, 77);
            this.numericUpDown_varsta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown_varsta.Name = "numericUpDown_varsta";
            this.numericUpDown_varsta.Size = new System.Drawing.Size(129, 26);
            this.numericUpDown_varsta.TabIndex = 2;
            // 
            // label_varsta
            // 
            this.label_varsta.AutoSize = true;
            this.label_varsta.Location = new System.Drawing.Point(15, 80);
            this.label_varsta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_varsta.Name = "label_varsta";
            this.label_varsta.Size = new System.Drawing.Size(60, 20);
            this.label_varsta.TabIndex = 3;
            this.label_varsta.Text = "Vârstă:";
            // 
            // comboBox_an
            // 
            this.comboBox_an.FormattingEnabled = true;
            this.comboBox_an.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox_an.Location = new System.Drawing.Point(105, 134);
            this.comboBox_an.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_an.Name = "comboBox_an";
            this.comboBox_an.Size = new System.Drawing.Size(127, 28);
            this.comboBox_an.TabIndex = 4;
            this.comboBox_an.Text = "1";
            // 
            // label_an
            // 
            this.label_an.AutoSize = true;
            this.label_an.Location = new System.Drawing.Point(15, 138);
            this.label_an.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_an.Name = "label_an";
            this.label_an.Size = new System.Drawing.Size(80, 20);
            this.label_an.TabIndex = 5;
            this.label_an.Text = "An studiu:";
            // 
            // button_adaugare
            // 
            this.button_adaugare.Location = new System.Drawing.Point(9, 29);
            this.button_adaugare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_adaugare.Name = "button_adaugare";
            this.button_adaugare.Size = new System.Drawing.Size(300, 69);
            this.button_adaugare.TabIndex = 6;
            this.button_adaugare.Text = "Adăugare student";
            this.button_adaugare.UseVisualStyleBackColor = true;
            this.button_adaugare.Click += new System.EventHandler(this.button_adaugare_Click);
            // 
            // listBox_studenti
            // 
            this.listBox_studenti.FormattingEnabled = true;
            this.listBox_studenti.ItemHeight = 20;
            this.listBox_studenti.Location = new System.Drawing.Point(352, 58);
            this.listBox_studenti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox_studenti.Name = "listBox_studenti";
            this.listBox_studenti.Size = new System.Drawing.Size(812, 244);
            this.listBox_studenti.TabIndex = 7;
            // 
            // label_lista
            // 
            this.label_lista.AutoSize = true;
            this.label_lista.Location = new System.Drawing.Point(348, 23);
            this.label_lista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_lista.Name = "label_lista";
            this.label_lista.Size = new System.Drawing.Size(139, 20);
            this.label_lista.TabIndex = 8;
            this.label_lista.Text = "Studenți adăugați:";
            // 
            // button_sortareAsc
            // 
            this.button_sortareAsc.Location = new System.Drawing.Point(9, 122);
            this.button_sortareAsc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_sortareAsc.Name = "button_sortareAsc";
            this.button_sortareAsc.Size = new System.Drawing.Size(300, 43);
            this.button_sortareAsc.TabIndex = 9;
            this.button_sortareAsc.Text = "Ordonare studenți (crescător)";
            this.button_sortareAsc.UseVisualStyleBackColor = true;
            this.button_sortareAsc.Click += new System.EventHandler(this.button_sortareAsc_Click);
            // 
            // groupBox_note
            // 
            this.groupBox_note.Controls.Add(this.numericUpDown_nota4);
            this.groupBox_note.Controls.Add(this.numericUpDown_nota3);
            this.groupBox_note.Controls.Add(this.numericUpDown_nota2);
            this.groupBox_note.Controls.Add(this.numericUpDown_nota1);
            this.groupBox_note.Controls.Add(this.numericUpDown_nota0);
            this.groupBox_note.Location = new System.Drawing.Point(18, 189);
            this.groupBox_note.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_note.Name = "groupBox_note";
            this.groupBox_note.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_note.Size = new System.Drawing.Size(300, 120);
            this.groupBox_note.TabIndex = 11;
            this.groupBox_note.TabStop = false;
            this.groupBox_note.Text = "Note:";
            // 
            // numericUpDown_nota4
            // 
            this.numericUpDown_nota4.Location = new System.Drawing.Point(10, 69);
            this.numericUpDown_nota4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown_nota4.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_nota4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_nota4.Name = "numericUpDown_nota4";
            this.numericUpDown_nota4.Size = new System.Drawing.Size(60, 26);
            this.numericUpDown_nota4.TabIndex = 19;
            this.numericUpDown_nota4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_nota3
            // 
            this.numericUpDown_nota3.Location = new System.Drawing.Point(218, 29);
            this.numericUpDown_nota3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown_nota3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_nota3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_nota3.Name = "numericUpDown_nota3";
            this.numericUpDown_nota3.Size = new System.Drawing.Size(60, 26);
            this.numericUpDown_nota3.TabIndex = 18;
            this.numericUpDown_nota3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_nota2
            // 
            this.numericUpDown_nota2.Location = new System.Drawing.Point(148, 29);
            this.numericUpDown_nota2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown_nota2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_nota2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_nota2.Name = "numericUpDown_nota2";
            this.numericUpDown_nota2.Size = new System.Drawing.Size(60, 26);
            this.numericUpDown_nota2.TabIndex = 17;
            this.numericUpDown_nota2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_nota1
            // 
            this.numericUpDown_nota1.Location = new System.Drawing.Point(80, 29);
            this.numericUpDown_nota1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown_nota1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_nota1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_nota1.Name = "numericUpDown_nota1";
            this.numericUpDown_nota1.Size = new System.Drawing.Size(60, 26);
            this.numericUpDown_nota1.TabIndex = 16;
            this.numericUpDown_nota1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_nota0
            // 
            this.numericUpDown_nota0.Location = new System.Drawing.Point(10, 29);
            this.numericUpDown_nota0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown_nota0.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_nota0.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_nota0.Name = "numericUpDown_nota0";
            this.numericUpDown_nota0.Size = new System.Drawing.Size(60, 26);
            this.numericUpDown_nota0.TabIndex = 15;
            this.numericUpDown_nota0.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_sortareDesc
            // 
            this.button_sortareDesc.Location = new System.Drawing.Point(9, 174);
            this.button_sortareDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_sortareDesc.Name = "button_sortareDesc";
            this.button_sortareDesc.Size = new System.Drawing.Size(300, 43);
            this.button_sortareDesc.TabIndex = 12;
            this.button_sortareDesc.Text = "Ordonare studenți (descrescător)";
            this.button_sortareDesc.UseVisualStyleBackColor = true;
            this.button_sortareDesc.Click += new System.EventHandler(this.button_sortareDesc_Click);
            // 
            // button_stergereLista
            // 
            this.button_stergereLista.Location = new System.Drawing.Point(9, 294);
            this.button_stergereLista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_stergereLista.Name = "button_stergereLista";
            this.button_stergereLista.Size = new System.Drawing.Size(300, 43);
            this.button_stergereLista.TabIndex = 13;
            this.button_stergereLista.Text = "Ștergere listă";
            this.button_stergereLista.UseVisualStyleBackColor = true;
            this.button_stergereLista.Click += new System.EventHandler(this.button_stergereLista_Click);
            // 
            // groupBox_actiuni
            // 
            this.groupBox_actiuni.Controls.Add(this.button_stergereStudent);
            this.groupBox_actiuni.Controls.Add(this.button_adaugare);
            this.groupBox_actiuni.Controls.Add(this.button_sortareDesc);
            this.groupBox_actiuni.Controls.Add(this.button_sortareAsc);
            this.groupBox_actiuni.Controls.Add(this.button_stergereLista);
            this.groupBox_actiuni.Location = new System.Drawing.Point(20, 318);
            this.groupBox_actiuni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_actiuni.Name = "groupBox_actiuni";
            this.groupBox_actiuni.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_actiuni.Size = new System.Drawing.Size(322, 346);
            this.groupBox_actiuni.TabIndex = 14;
            this.groupBox_actiuni.TabStop = false;
            this.groupBox_actiuni.Text = "Acțiuni:";
            // 
            // button_stergereStudent
            // 
            this.button_stergereStudent.Location = new System.Drawing.Point(9, 242);
            this.button_stergereStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_stergereStudent.Name = "button_stergereStudent";
            this.button_stergereStudent.Size = new System.Drawing.Size(300, 43);
            this.button_stergereStudent.TabIndex = 14;
            this.button_stergereStudent.Text = "Ștergere student selectat";
            this.button_stergereStudent.UseVisualStyleBackColor = true;
            this.button_stergereStudent.Click += new System.EventHandler(this.button_stergereStudent_Click);
            // 
            // groupBox_afisare
            // 
            this.groupBox_afisare.Controls.Add(this.button_afisareLista);
            this.groupBox_afisare.Controls.Add(this.textBox_numeCautare);
            this.groupBox_afisare.Controls.Add(this.comboBox_anAfisare);
            this.groupBox_afisare.Controls.Add(this.button_cautare);
            this.groupBox_afisare.Controls.Add(this.button_afisareAn);
            this.groupBox_afisare.Location = new System.Drawing.Point(352, 318);
            this.groupBox_afisare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_afisare.Name = "groupBox_afisare";
            this.groupBox_afisare.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_afisare.Size = new System.Drawing.Size(321, 346);
            this.groupBox_afisare.TabIndex = 15;
            this.groupBox_afisare.TabStop = false;
            this.groupBox_afisare.Text = "Afișare:";
            // 
            // button_afisareLista
            // 
            this.button_afisareLista.Location = new System.Drawing.Point(9, 29);
            this.button_afisareLista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_afisareLista.Name = "button_afisareLista";
            this.button_afisareLista.Size = new System.Drawing.Size(300, 43);
            this.button_afisareLista.TabIndex = 17;
            this.button_afisareLista.Text = "Afișare toți studenții";
            this.button_afisareLista.UseVisualStyleBackColor = true;
            this.button_afisareLista.Click += new System.EventHandler(this.button_afisareLista_Click);
            // 
            // textBox_numeCautare
            // 
            this.textBox_numeCautare.Location = new System.Drawing.Point(9, 300);
            this.textBox_numeCautare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_numeCautare.Name = "textBox_numeCautare";
            this.textBox_numeCautare.Size = new System.Drawing.Size(236, 26);
            this.textBox_numeCautare.TabIndex = 16;
            // 
            // comboBox_anAfisare
            // 
            this.comboBox_anAfisare.FormattingEnabled = true;
            this.comboBox_anAfisare.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox_anAfisare.Location = new System.Drawing.Point(9, 174);
            this.comboBox_anAfisare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_anAfisare.Name = "comboBox_anAfisare";
            this.comboBox_anAfisare.Size = new System.Drawing.Size(127, 28);
            this.comboBox_anAfisare.TabIndex = 16;
            // 
            // button_cautare
            // 
            this.button_cautare.Location = new System.Drawing.Point(9, 248);
            this.button_cautare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_cautare.Name = "button_cautare";
            this.button_cautare.Size = new System.Drawing.Size(300, 43);
            this.button_cautare.TabIndex = 12;
            this.button_cautare.Text = "Căutare student:";
            this.button_cautare.UseVisualStyleBackColor = true;
            this.button_cautare.Click += new System.EventHandler(this.button_cautare_Click);
            // 
            // button_afisareAn
            // 
            this.button_afisareAn.Location = new System.Drawing.Point(9, 122);
            this.button_afisareAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_afisareAn.Name = "button_afisareAn";
            this.button_afisareAn.Size = new System.Drawing.Size(300, 43);
            this.button_afisareAn.TabIndex = 9;
            this.button_afisareAn.Text = "Afișare studenți din anul";
            this.button_afisareAn.UseVisualStyleBackColor = true;
            this.button_afisareAn.Click += new System.EventHandler(this.button_afisareAn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.groupBox_afisare);
            this.Controls.Add(this.groupBox_actiuni);
            this.Controls.Add(this.groupBox_note);
            this.Controls.Add(this.label_lista);
            this.Controls.Add(this.listBox_studenti);
            this.Controls.Add(this.label_an);
            this.Controls.Add(this.comboBox_an);
            this.Controls.Add(this.label_varsta);
            this.Controls.Add(this.numericUpDown_varsta);
            this.Controls.Add(this.label_nume);
            this.Controls.Add(this.textBox_nume);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Studenți";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_varsta)).EndInit();
            this.groupBox_note.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nota4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nota3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nota2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nota1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nota0)).EndInit();
            this.groupBox_actiuni.ResumeLayout(false);
            this.groupBox_afisare.ResumeLayout(false);
            this.groupBox_afisare.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_nume;
        private System.Windows.Forms.Label label_nume;
        private System.Windows.Forms.NumericUpDown numericUpDown_varsta;
        private System.Windows.Forms.Label label_varsta;
        private System.Windows.Forms.ComboBox comboBox_an;
        private System.Windows.Forms.Label label_an;
        private System.Windows.Forms.Button button_adaugare;
        private System.Windows.Forms.ListBox listBox_studenti;
        private System.Windows.Forms.Label label_lista;
        private System.Windows.Forms.Button button_sortareAsc;
        private System.Windows.Forms.GroupBox groupBox_note;
        private System.Windows.Forms.Button button_sortareDesc;
        private System.Windows.Forms.Button button_stergereLista;
        private System.Windows.Forms.GroupBox groupBox_actiuni;
        private System.Windows.Forms.Button button_stergereStudent;
        private System.Windows.Forms.NumericUpDown numericUpDown_nota0;
        private System.Windows.Forms.NumericUpDown numericUpDown_nota4;
        private System.Windows.Forms.NumericUpDown numericUpDown_nota3;
        private System.Windows.Forms.NumericUpDown numericUpDown_nota2;
        private System.Windows.Forms.NumericUpDown numericUpDown_nota1;
        private System.Windows.Forms.GroupBox groupBox_afisare;
        private System.Windows.Forms.Button button_cautare;
        private System.Windows.Forms.Button button_afisareAn;
        private System.Windows.Forms.ComboBox comboBox_anAfisare;
        private System.Windows.Forms.TextBox textBox_numeCautare;
        private System.Windows.Forms.Button button_afisareLista;
    }
}

