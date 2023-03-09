using HttpRequestJson.Models;
using HttpRequestJson.Services;

namespace HttpRequestJson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private MexService _mexService;
        private List<SymbolInfo> _symbols = new List<SymbolInfo>();
        private void Form1_Load(object sender, EventArgs e)
        {
            _mexService = new MexService();
            bool status = _mexService.CheckApiStatus();
            this.Text = status ? "API OK" : "API Error";
            //https://api.mexc.com/api/v3/exchangeInfo
            var symbols = _mexService.GetSymbols()
                .Where(x => x.IsSpotTradingAllowed).OrderBy(x => x.Symbol)
                .ToList();
            lstSymbol.DataSource = _symbols;
            
        }

        private void lstSymbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tmrVeri_Tick(object sender, EventArgs e)
        {

        }
    }
}