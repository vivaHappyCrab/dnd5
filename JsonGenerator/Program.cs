using System.IO;
using System.Net;

namespace JsonGenerator
{
    internal class Program
    {
        private const string Url = @"http://dnd5eapi.co/api/";

        private const string FilePath = @"E:\Projects\dnd5\dnd5\dnd5\Resources\";

        private static void Main()
        {
            //Generate classes
            string method = "classes";

            //using (StreamWriter sw = new StreamWriter($"{FilePath}{method}.json"))
            //{
            //    sw.WriteLine($"{{\"{method}\":[");
            //    for (int i = 0; i < 12; ++i)
            //    {
            //        HttpWebRequest request = (HttpWebRequest) WebRequest.Create($"{Url}{method}/{i + 1}");
            //        HttpWebResponse response = (HttpWebResponse) request.GetResponse();
            //        if (response.StatusCode == HttpStatusCode.OK)
            //        {
            //            Stream stream = response.GetResponseStream();
            //            if(stream!=null)
            //                sw.WriteLine(new StreamReader(stream).ReadToEnd());
            //        }
            //        response.Close();
            //        if(i!=11)
            //            sw.WriteLine(",");
            //    }
            //    sw.WriteLine("]}");
            //}

            //Generate features
            method = "features";

            using (StreamWriter sw = new StreamWriter($"{FilePath}{method}.json"))
            {
                sw.WriteLine($"{{\"{method}\":[");
                for (int i = 0; i < 414; ++i)
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"{Url}{method}/{i + 1}");
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        Stream stream = response.GetResponseStream();
                        if (stream != null)
                            sw.WriteLine(new StreamReader(stream).ReadToEnd());
                    }
                    response.Close();
                    if (i != 11)
                        sw.WriteLine(",");
                }
                sw.WriteLine("]}");
            }
        }
    }
}
