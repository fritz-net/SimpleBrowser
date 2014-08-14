using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBrowser
{
	public class NavigationError
	{
		public NavigationError()
		{
		}

		public NavigationError(WebException webException)
		{
			ErrorType = NavigationErrorType.WebException;
			WebException = webException;
		}

		public NavigationError(NavigationErrorType errorType)
		{
			ErrorType = errorType;
		}

		public WebException WebException { get; set; }
		public NavigationErrorType ErrorType { get; set; }

		public string Message
		{
			get
			{
				switch(ErrorType)
				{
					case NavigationErrorType.WebException:
						return WebException.Message;
					case NavigationErrorType.TooManyRedirects:
						return "Too many 301/302 redirects";
					case NavigationErrorType.UnparsableUrl:
						return "The specified URL could not be parsed";
					default:
						return "Unknown error";
				}
			}
		}
	}

	public enum NavigationErrorType
	{
		WebException,
		TooManyRedirects,
		UnparsableUrl
	}
}
