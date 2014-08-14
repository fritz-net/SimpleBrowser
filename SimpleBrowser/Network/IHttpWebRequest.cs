using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace SimpleBrowser.Network
{
	public interface IHttpWebRequest
	{
		Task<Stream> GetRequestStream();

		Task<IHttpWebResponse> GetResponse();

		long ContentLength { get; set; }

		WebHeaderCollection Headers { get; set; }
		
		DecompressionMethods AutomaticDecompression { get; set; }

		string ContentType { get; set; }

		string Method { get; set; }

		string UserAgent { get; set; }

		string Accept { get; set; }

		int Timeout { get; set; }

		bool AllowAutoRedirect { get; set; }

		CookieContainer CookieContainer { get; set; }

		IWebProxy Proxy { get; set; }

		string Referer { get; set; }

		string Host { get; set; }
	}
}
