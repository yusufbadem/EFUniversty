using EFUniversty.Models;

namespace EFUniversty;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnCityAdd_Click(object sender, EventArgs e)
    {
        AkademiDbContext db = new AkademiDbContext();
        City city = new City();
        city.Name = txtCity.Text.Trim();

        if (city.Name == "")
        {
            MessageBox.Show("þehir boþ geçilemez");
            return;
        }

        //2:YOL
        //if (string.IsNullOrEmpty(city.Name))
        //{
        //    MessageBox.Show("þehir adý gereklidir");
        //    return;
        //}

        db.Cities.Add(city);
        db.SaveChanges();

        SehirleriGetir();
        txtCity.Text = "";
        MessageBox.Show("Þehir Ekleme Baþarlýlý");
       
        

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {
        SehirleriGetir();
    }

    private void SehirleriGetir()
    {
        AkademiDbContext db = new AkademiDbContext();

        List<City> cities = db.Cities.ToList();
        dataGridView1.DataSource = cities;

        //2.Yol
        //dataGridView1.DataSource = db.Cities.ToList();
    }
}
