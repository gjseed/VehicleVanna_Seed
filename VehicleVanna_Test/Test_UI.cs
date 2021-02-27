using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;

namespace VehicleVanna_Test
{
    public partial class Test_UI : Form
    {
        public Test_UI()
        {
            InitializeComponent();
        }

        public async void SubmitBtn_Click(object sender, EventArgs e)
        {
            VehicleEnum.AutoEnum newAuto = new VehicleEnum.AutoEnum(MakeBx.Text, ModelBx.Text, YearBx.Text,
                (Int32)ListPBx.Value, VehicleTBx.SelectedIndex.ToString(), EmailBx.Text, FnameBx.Text, LnameBx.Text);
            string url = "http://localhost:7071/api/Function1";
            var client = new HttpClient();
            HttpResponseMessage response = await client.PostAsJsonAsync(url, newAuto);
            this.Hide();
            MessageBox.Show(response.Content.ReadAsStringAsync().Result.ToString());
            this.Show();
        }
    }
}
