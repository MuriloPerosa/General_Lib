using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Lib.SMS
{
	public class TwilioAPI
	{
		public string SID { get; set; } = "";
		public string Token { get; set; } = "";
		public string Number { get; set; } = "";

		public TwilioAPI(string sid, string token, string number)
		{
			SID = sid;
			Token = token;
			Number = number;

			//Inicializando Twilio - SID & Token
			Twilio.TwilioClient.Init(SID, Token);
		}

		public void Enviar(string toNumber, string textBody)
		{
			var resultado = Twilio.Rest.Api.V2010.Account.MessageResource.Create(to: new Twilio.Types.PhoneNumber(toNumber), from: new Twilio.Types.PhoneNumber(Number), body: textBody);
		}

	}
}
