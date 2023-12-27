using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.Json;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace AveryGameOfferCreator
{
    public partial class OptionsForm : Form
    {

        HttpClient _client = new();
        string BaseURL = Helper.GetBaseURL();

        public OptionsForm()
        {
            InitializeComponent();
            var baseurl = Helper.GetBaseURL();
            textBox1.Text = baseurl.Split("://")[0];
            if (baseurl.Split("://")[1].IndexOf(":") != -1)
            {
                checkBox1.Checked = true;
                textBox2.Text = baseurl.Split("://")[1].Split(":")[0];
                numericUpDown1.Value = int.Parse(baseurl.Split("://")[1].Split(":")[1].Split("/")[0]);
            }
            else
            {
                checkBox1.Checked = false;
                textBox2.Text = baseurl.Split("://")[1].Split("/")[0];
            }

            textBox3.Text = string.IsNullOrWhiteSpace(Program.ini.GetValue("authentication", "username")) ? "" : Program.ini.GetValue("authentication", "username");
            textBox4.Text = string.IsNullOrWhiteSpace(Program.ini.GetValue("authentication", "password")) ? "" : Program.ini.GetValue("authentication", "password");
            BaseURLChanged();
        }

        private void BaseURLChanged()
        {
            BaseURL = textBox1.Text + "://" + textBox2.Text + (checkBox1.Checked ? ":" + numericUpDown1.Value.ToString() : "") + "/";
            Helper.SetBaseURL(BaseURL);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = checkBox1.Checked;
            BaseURLChanged();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BaseURLChanged();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            BaseURLChanged();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            BaseURLChanged();
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            //Attempt server heartbeat
            string result = "";
            try
            {
                result = await _client.GetStringAsync(BaseURL + "api/v1/game/heartbeat");
                DefaultResponse? response = JsonSerializer.Deserialize<DefaultResponse>(result);

                if (response.code == 200)
                {
                    MessageBox.Show("Connected to backend successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("An unknown error has occurred.", "Backend Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("Connection to backend service failed.", "Backend Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string result = "";
            try
            {
                AdminCredentials credentials = new AdminCredentials();
                credentials.username = textBox3.Text;
                credentials.password = textBox4.Text;
                var stringPayload = JsonConvert.SerializeObject(credentials);
                var content = new StringContent(stringPayload, Encoding.UTF8, "application/json");
                var response = await _client.PostAsync(BaseURL + "api/v1/account/authenticateAdmin", content);

                if (response.Content == null)
                {
                    MessageBox.Show("An unknown error has occurred.", "Backend Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                result = await response.Content.ReadAsStringAsync();
                AuthenticateAdminResponse stuff = JsonSerializer.Deserialize<AuthenticateAdminResponse>(result);
                if (stuff.code == 200)
                {
                    MessageBox.Show($"Authenticated successfully. User ID: {stuff.userId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{stuff.message}", "Backend Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection to backend failed.", "Backend Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Program.ini.SetValue("authentication", "username", textBox3.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Program.ini.SetValue("authentication", "password", textBox4.Text);
        }
    }
}
