using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Omniworlds_Control_Panel
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
            listShops();
        }

        private void lstShops_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("yay");
            if (lstShops.SelectedItems.Count > 0)
            {
                String[] name = lstShops.Text.Split(new string[] { ": " }, 2, StringSplitOptions.RemoveEmptyEntries);
                txtName.Text = name[1];
                Console.WriteLine(name[0].Trim(':'));
                populateShop(name[0].Trim(':'));
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var menu = new MainMenu();

            menu.Show();
            this.Close();
        }

        private async void listShops()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://gapi.itslit.uk/");
            HttpResponseMessage output = await client.GetAsync("Shop/listShops");

            string response = await output.Content.ReadAsStringAsync();
            //txtNotes.Text = response;

            JObject parseOutput = JObject.Parse(response);

            // get JSON result objects into a list
            IList<JToken> results = parseOutput["response"].Children().ToList();

            // serialize JSON results into .NET objects
            IList<API> searchResults = new List<API>();
            foreach (JToken result in results)
            {
                API searchResult = JsonConvert.DeserializeObject<API>(result.ToString());
                searchResults.Add(searchResult);
            }

            // List the properties of the searchResults IList
            foreach (API item in searchResults)
            {
                if (Convert.ToInt32(item.sid) < 10)
                {
                    lstShops.Items.Add("00" + item.sid + ": " + item.shop_name);
                }
                else
                {
                    lstShops.Items.Add("0" + item.sid + ": " + item.shop_name);
                }

            }
        }

        private async void populateShop(String id)
        {
            id = id.TrimStart('0');
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://gapi.itslit.uk/");
            HttpResponseMessage output = await client.GetAsync("Shop/listShops");

            string response = await output.Content.ReadAsStringAsync();
            //txtNotes.Text = response;

            JObject parseOutput = JObject.Parse(response);

            // get JSON result objects into a list
            IList<JToken> results = parseOutput["response"].Children().ToList();

            // serialize JSON results into .NET objects
            IList<API> searchResults = new List<API>();
            foreach (JToken result in results)
            {
                API searchResult = JsonConvert.DeserializeObject<API>(result.ToString());
                searchResults.Add(searchResult);
            }

            // List the properties of the searchResults IList
            foreach (API item in searchResults)
            {

                if (item.sid == id)
                {
                    Console.WriteLine(item.sid.ToString());
                    if (item.open == "1")
                    {
                        Console.WriteLine("yay");
                        chkActive.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        Console.WriteLine("nay");
                    }
                    Console.WriteLine(Convert.ToDecimal(item.balance));
                    numBalance.Value = Convert.ToDecimal(item.balance);
                    numLevel.Value = Convert.ToDecimal(item.min_level);

                    //Need to make sure the list of locations is already added and check Vas Aven
                    chkLstLocation.Items.Add("Vas Aven");
                    chkLstLocation.Text = "Vas Aven";
                    cmbShopkeep.Items.Add(item.shopkeep);
                    cmbShopkeep.Text = item.shopkeep;
                    Console.WriteLine(item.open);


                }
                else
                {
                    cmbShopkeep.Items.Add(item.shopkeep);
                }

            }
        }
    }
}
