using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab1
{
    public partial class Form1 : Form
    {
        private List<Student> lista_studenti = new List<Student>();

        byte[] getNote()
        {
            byte[] note = new byte[5];
            note[0] = Convert.ToByte(numericUpDown_nota0.Value);
            note[1] = Convert.ToByte(numericUpDown_nota1.Value);
            note[2] = Convert.ToByte(numericUpDown_nota2.Value);
            note[3] = Convert.ToByte(numericUpDown_nota3.Value);
            note[4] = Convert.ToByte(numericUpDown_nota4.Value);
            return note;
        }

        public Form1() { InitializeComponent(); }

        private void button_adaugare_Click(object sender, EventArgs e)
        {
            try
            {
                string nume = textBox_nume.Text;
                byte varsta = Convert.ToByte(numericUpDown_varsta.Value);
                byte an = Convert.ToByte(comboBox_an.Text);
                byte[] nota = getNote();
                Student student = new Student(nume, varsta, an, nota);
                //MessageBox.Show("Nume: " + nume + "\nVârstă: " + varsta + "\nAn studiu: " + an);
                MessageBox.Show($"Nume: {student.Nume}\nVârstă: {student.Varsta}\nAn studiu: {student.AnStudiu}\n Note: {student.getNote(0)}, {student.getNote(1)}, {student.getNote(2)}, {student.getNote(3)}, {student.getNote(4)}\nMedie: {student.Medie}");
                lista_studenti.Add(student);
                syncListbox();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void syncListbox()
        {
            listBox_studenti.Items.Clear();
            //for (int i = 0; i <= lista_studenti.Count; i++) list_studenti.Items.Add(lista_studenti[i]);
            foreach (Student student in lista_studenti) listBox_studenti.Items.Add(student);
        }

        private void button_sortareAsc_Click(object sender, EventArgs e)
        {
            ComparaNumeAsc compara = new ComparaNumeAsc();
            lista_studenti.Sort(compara);
            syncListbox();
        }

        private void button_sortareDesc_Click(object sender, EventArgs e)
        {
            ComparaNumeDesc compara = new ComparaNumeDesc();
            lista_studenti.Sort(compara);
            syncListbox();
        }

        private void button_stergereLista_Click(object sender, EventArgs e)
        {
            lista_studenti.Clear();
            syncListbox();
        }

        private void button_stergereStudent_Click(object sender, EventArgs e)
        {
            try
            {
                lista_studenti.RemoveAt(listBox_studenti.SelectedIndex);
                syncListbox();
            }
            catch (Exception ex) { MessageBox.Show("Niciun student selectat!"); }
        }

        private void button_afisareAn_Click(object sender, EventArgs e)
        {
            try
            {
                byte anAfisare = Convert.ToByte(comboBox_anAfisare.Text);
                listBox_studenti.Items.Clear();
                foreach (Student student in lista_studenti)
                    if (student.AnStudiu == anAfisare) listBox_studenti.Items.Add(student);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button_afisareLista_Click(object sender, EventArgs e)
        {
            syncListbox();
        }

        private void button_cautare_Click(object sender, EventArgs e)
        {
            string numeCautare = textBox_numeCautare.Text;
            foreach (Student student in lista_studenti)
                if (student.Nume == numeCautare) MessageBox.Show($"Student găsit!:\n\nNume: {student.Nume}\nVârstă: {student.Varsta}\nAn studiu: {student.AnStudiu}\n Note: {student.getNote(0)}, {student.getNote(1)}, {student.getNote(2)}, {student.getNote(3)}, {student.getNote(4)}\nMedie: {student.Medie}");
        }

        private void label_nume_Click(object sender, EventArgs e)
        {

        }
    }
}
