using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;

namespace Currency_Price
{
    public partial class Form1 : Form
    {
        string base_url = "https://www.tgju.org/profile/";
        string pattern = @"<.*?""info.last_trade.PDrCotVal"">(?<currency>.*?)<.*?>";

        string[] currency_name = new string[]
        {
            "price_dollar_rl",
            "price_eur",
            "price_gbp",
            "price_try",
            "price_cny",
            "price_rub"
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Task.Run(() => GetAllCurrencyPrice());
        }

        private void GetAllCurrencyPrice()
        {
            foreach (string curency in currency_name)
            {
                using (WebClient wb = new WebClient())
                {
                    string result = wb.DownloadString(base_url + curency);
                    RegexOptions options = RegexOptions.Multiline;

                    Match m = Regex.Match(result, pattern);

                    Button btn = this.Controls.Find(curency, true).FirstOrDefault() as Button;
                    btn.Text = m.Groups["currency"].Value;
                }
            }
        }
    }
}
