using System.Text.Json;
using Newtonsoft.Json;
using System.Text;
using System.Net.Http;

namespace AveryGameOfferCreator
{
    public partial class Form1 : Form
    {

        Dictionary<string, Reward> RewardDictionary = new();
        string SelectedKey = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OptionsForm options = new OptionsForm();
            options.Show();
        }

        private void copyOfferPayloadToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Offer offer = new Offer();
            offer.offerName = textBox2.Text;
            offer.redemptionMessage = textBox3.Text;
            offer.promotionalOffer = checkBox1.Checked;
            offer.promotionalCode = textBox1.Text;
            offer.microtransactionalRequirement = checkBox2.Checked;
            offer.cost = (int)numericUpDown1.Value;
            offer.rewards = RewardDictionary.Values.ToList();

            var options = new JsonSerializerOptions { WriteIndented = true };
            string str = System.Text.Json.JsonSerializer.Serialize<Offer>(offer, options);
            Clipboard.SetText(str);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = checkBox1.Checked;
            button1.Enabled = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            textBox1.Text = new string(Enumerable.Repeat(chars, 13).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = checkBox2.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RewardDictionary.Add($"Reward {RewardDictionary.Count + 1}", new Reward());
            comboBox1.Items.Add($"Reward {RewardDictionary.Count}");
            comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
            SelectedKey = RewardDictionary.Keys.ElementAt(comboBox1.SelectedIndex);
            RewardDictionary[SelectedKey].rewardName = $"Reward {RewardDictionary.Count}";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            StatRewardCheck.Enabled = true;
            MicroChecked.Enabled = true;
            SelectedKey = RewardDictionary.Keys.ElementAt(comboBox1.SelectedIndex);
            if (string.IsNullOrWhiteSpace(SelectedKey))
                return;
            Reward currentReward = RewardDictionary[SelectedKey];
            StatRewardCheck.Checked = currentReward.statReward;
            MicroChecked.Checked = currentReward.microtransactionalReward;
            StatName.Text = currentReward.statName;
            StatValue.Text = currentReward.statValue;
            MicroReward.Value = currentReward.microtransactionalAmount;
        }

        private void StatRewardCheck_CheckedChanged(object sender, EventArgs e)
        {
            StatName.Enabled = StatRewardCheck.Checked;
            StatValue.Enabled = StatRewardCheck.Checked;
            RewardDictionary[SelectedKey].statReward = StatRewardCheck.Checked;
        }

        private void MicroChecked_CheckedChanged(object sender, EventArgs e)
        {
            MicroReward.Enabled = MicroChecked.Checked;
            RewardDictionary[SelectedKey].microtransactionalReward = MicroChecked.Checked;
        }

        private void StatName_TextChanged(object sender, EventArgs e)
        {
            RewardDictionary[SelectedKey].statName = StatName.Text;
        }

        private void StatValue_TextChanged(object sender, EventArgs e)
        {
            RewardDictionary[SelectedKey].statValue = StatValue.Text;
        }

        private void MicroReward_ValueChanged(object sender, EventArgs e)
        {
            RewardDictionary[SelectedKey].microtransactionalAmount = (int)MicroReward.Value;
        }

        private async void uploadOfferToBackendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var BaseURL = Helper.GetBaseURL();
            var username = Helper.GetUsername();
            var password = Helper.GetPassword();
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Valid credentials have not been entered in options. Please enter valid credentials to upload to the backend.", "No Credentials", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Offer offer = new Offer();
            offer.offerName = textBox2.Text;
            offer.redemptionMessage = textBox3.Text;
            offer.promotionalOffer = checkBox1.Checked;
            offer.promotionalCode = textBox1.Text;
            offer.microtransactionalRequirement = checkBox2.Checked;
            offer.cost = (int)numericUpDown1.Value;
            offer.rewards = RewardDictionary.Values.ToList();

            OfferRequest requestObj = new OfferRequest();
            requestObj.offer = offer;
            requestObj.username = username;
            requestObj.password = password;

            var options = new JsonSerializerOptions { WriteIndented = true };
            string str = System.Text.Json.JsonSerializer.Serialize<OfferRequest>(requestObj, options);
            var content = new StringContent(str, Encoding.UTF8, "application/json");
            HttpClient _client = new HttpClient();
            try
            {
                var response = await _client.PostAsync(BaseURL + "api/v1/admin/offer/createOffer", content);

                if (response.Content == null)
                {
                    MessageBox.Show("An unknown error has occurred.", "Backend Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = await response.Content.ReadAsStringAsync();
                DefaultResponse stuff = System.Text.Json.JsonSerializer.Deserialize<DefaultResponse>(result);
                if (stuff.code == 200)
                {
                    MessageBox.Show($"Successfully created offer '{offer.offerName}' on backend.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{stuff.message}", "Backend Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Failed to connect to backend.", "Backend Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetAllFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatRewardCheck.Enabled = false;
            StatName.Enabled = false;
            StatValue.Enabled = false;
            MicroChecked.Enabled = false;
            StatName.Text = "";
            StatValue.Text = "";
            numericUpDown1.Value = 0;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            MicroReward.Value = 0;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            comboBox1.Items.Clear();
            RewardDictionary.Clear();
            SelectedKey = "";
            comboBox1.SelectedItem = "";
        }
    }
}