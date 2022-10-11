using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyRate
{
	public class CurConv
	{
		Dictionary<string, string> symbols;

		public Dictionary<string, string> GetSymbols()
		{
			if (symbols == null)
			{
				symbols = new Dictionary<string, string>();
				string response = getResponse("exchangerates_data/symbols");

				Dictionary<string, object> responseData = JsonConvert.DeserializeObject<Dictionary<string, object>>(response);
				if ((bool)responseData["success"])
				{
					var tempSymbols = (JObject)responseData["symbols"];
					symbols = tempSymbols.ToObject<Dictionary<string, string>>();
				}
			}

			return symbols;
		}

		public double Convert(string fromCurrency, string toCurrency, double currencyAmount)
		{
			string response = getResponse($"https://api.apilayer.com/exchangerates_data/convert?to={toCurrency}&from={fromCurrency}&amount={currencyAmount}");

			Dictionary<string, object> responseData = JsonConvert.DeserializeObject<Dictionary<string, object>>(response);
			if ((bool)responseData["success"])
			{
				return (double)responseData["result"];
			}

			else
			{
				return -1;
			}
		}

		private string getResponse(string relativeURI)
		{
			const string API = "fUrvKByVZohrlwEmwQ8ZAVIZ52KBS6Ep";

			var client = new RestClient($"https://api.apilayer.com/");

			var request = new RestRequest(relativeURI, Method.Get);
			request.AddHeader("apikey", API);

			RestResponse response = client.Execute(request);
			return response.Content;
		}
	}
}
