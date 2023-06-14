using Carver;
using Opdracht_Carver;

namespace Opdracht_Carver
{
    public partial class Form1 : Form
    {

        Database db = new Database();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // paar controles en dan object aanmaken
            // naam, email en rijbewijs

            if (tbNaam.Text != "" && tbEmail.Text != "" && rijbewijs.Text != "" && rijbewijs.Text != "Geen")
            {
                maakProspect();
            }
            else
            {
                MessageBox.Show("Graag de gegevens invullen!");
            }
        }
        private void maakProspect()
        {
            Prospect p = new Prospect(tbNaam.Text, textBox4.Text, textBox2.Text, tbEmail.Text, rijbewijs.SelectedIndex);
            p.insertInDb();
        }

        private void btnLoadProspects_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Prospect";
            gvProspects2.DataSource = db.ShowDataInGridView(sql);
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }

}
//select prospect.naam, Rijbewijzen.[type - naam] from prospect left outer join Rijbewijzen ON prospect.rijbewijstype = Rijbewijzen.[rijbewijs - id]