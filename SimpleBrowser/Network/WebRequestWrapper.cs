using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace SimpleBrowser.Network
{
	class WebRequestWrapper : IHttpWebRequest
	{
		public WebRequestWrapper(Uri url)
		{
			_wr = (HttpWebRequest)HttpWebRequest.Create(url);
		}
		HttpWebRequest _wr = null;

		#region IHttpWebRequest Members

		public async Task<Stream> GetRequestStream()
		{
			return await _wr.GetRequestStreamAsync();
		}

		public async Task<IHttpWebResponse> GetResponse()
		{
			((HttpWebResponse)_wr.GetResponse()).GetResponseStream();
			var response = await _wr.GetResponseAsync();
			return new WebResponseWrapper((HttpWebResponse)response);
		}

		public DecompressionMethods AutomaticDecompression
		{
			get
			{
				return _wr.AutomaticDecompression;
			}
			set
			{
				_wr.AutomaticDecompression = value;
			}
		}

		public long ContentLength
		{
			get
			{
				return _wr.ContentLength;
			}
			set
			{
				_wr.ContentLength = value;
			}
		}

		public WebHeaderCollection Headers
		{
			get
			{
				return _wr.Headers;
			}
			set
			{
				_wr.Headers = value;
			}
		}

		public string ContentType
		{
			get
			{
				return _wr.ContentType;
			}
			set
			{
				_wr.ContentType = value;
			}
		}

		public string Method
		{
			get
			{
				return _wr.Method;
			}
			set
			{
				_wr.Method = value;
			}
		}

		public string UserAgent
		{
			get
			{
				return _wr.UserAgent;
			}
			set
			{
				_wr.UserAgent = value;
			}
		}

		public string Accept
		{
			get
			{
				return _wr.Accept;
			}
			set
			{
				_wr.Accept = value; ;
			}
		}

		public int Timeout
		{
			get
			{
				return _wr.Timeout;
			}
			set
			{
				_wr.Timeout = value;
			}
		}

		public bool AllowAutoRedirect
		{
			get
			{
				return _wr.AllowAutoRedirect;
			}
			set
			{
				_wr.AllowAutoRedirect = value;
			}
		}

		public CookieContainer CookieContainer
		{
			get
			{
				return _wr.CookieContainer;
			}
			set
			{
				_wr.CookieContainer = value;
			}
		}

		public IWebProxy Proxy
		{
			get
			{
				return _wr.Proxy;
			}
			set
			{
				_wr.Proxy = value;
			}
		}

		public string Referer
		{
			get
			{
				return _wr.Referer;
			}
			set
			{
				_wr.Referer = value;
			}
		}

		public string Host
		{
			get
			{
				return _wr.Host;
			}
			set
			{
				_wr.Host = value;
			}
		}
	  #endregion
	}
}
