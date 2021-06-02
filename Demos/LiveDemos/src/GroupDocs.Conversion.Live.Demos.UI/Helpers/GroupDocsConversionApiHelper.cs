using GroupDocs.Conversion.Live.Demos.UI.Models;
using GroupDocs.Conversion.Live.Demos.UI.Config;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Threading;
using System;

namespace GroupDocs.Conversion.Live.Demos.UI.Helpers
{
	public class GroupDocsConversionApiHelper
	{
		public static Response ConvertFile(string fileName, string folderName, string outputType, string productName, bool isMultiple)
		{
			Response convertResponse = null;            

            using (var client = new HttpClient())
			{
				//client.Timeout = new System.TimeSpan(0, 2, 0);
				client.DefaultRequestHeaders.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                System.Threading.Tasks.Task taskUpload = client.GetAsync(Configuration.GroupDocsAppsAPIBasePath + "api/GroupDocsConversion/ConvertFile?fileName=" + HttpUtility.UrlEncode(fileName) + "&folderName=" + folderName + "&outputType=" + outputType + "&productName=" + productName + "&isMultiple=" + isMultiple.ToString()).ContinueWith(task =>                
                {
					  if (task.Status == System.Threading.Tasks.TaskStatus.RanToCompletion)
					  {
						  HttpResponseMessage response = task.Result;
						  if (response.IsSuccessStatusCode)
						  {
							  convertResponse = response.Content.ReadAsAsync<Response>().Result;
						  }
					  }
				  });

				try
				{
					taskUpload.Wait();// (Configuration.ThreadAbortSeconds + 4) * 1000, new CancellationToken(false));
				}
				catch (Exception exc)
				{
					client.Dispose();
					throw exc;// new Exception("We regret to inform you that your file took more than expected time. We cannot process it at the moment.");
				}
			}

			return convertResponse;
		}

		public static Response GetAllSupportedFormats(string strFromFormat)
		{
			Response convertResponse = null;

			using (var client = new HttpClient())
			{
				client.Timeout = new System.TimeSpan(0, 1, 0);
				client.DefaultRequestHeaders.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                System.Threading.Tasks.Task taskUpload = client.GetAsync(Configuration.GroupDocsAppsAPIBasePath + "api/GroupDocsConversion/GetAllSupportedFormats").ContinueWith(task =>
                {
					if (task.Status == System.Threading.Tasks.TaskStatus.RanToCompletion)
					{
						HttpResponseMessage response = task.Result;
						if (response.IsSuccessStatusCode)
						{
							convertResponse = response.Content.ReadAsAsync<Response>().Result;
						}
					}
				});
				try
				{
					taskUpload.Wait((Configuration.ThreadAbortSeconds + 3) * 1000, new CancellationToken(false));
				}
				catch
				{
					client.Dispose();
					throw new Exception("API response timeout, please try again.");
				}
			}

			return convertResponse;
		}
	}
}