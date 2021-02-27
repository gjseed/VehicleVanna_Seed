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
            string url2 = "https://vehiclevannaseed.azurewebsites.net/api/Function1?code=Zgz1B2vIizC1eorWjPzT2sLE4oNauPSBcNL5l7YLi0IMYtenaD97ZA==";
            var client = new HttpClient();
            HttpResponseMessage response = await client.PostAsJsonAsync(url2, newAuto);
            this.Hide();
            MessageBox.Show(response.Content.ReadAsStringAsync().Result.ToString());
            this.Show();
        }
    }
}
