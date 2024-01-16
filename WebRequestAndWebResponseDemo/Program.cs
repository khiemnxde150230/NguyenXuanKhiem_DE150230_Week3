using System;
using System.IO;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        //Create request for the url
        WebRequest request = WebRequest.Create("https://github.com/khiemnxde150230/git-test/blob/master/index.html");
        //if required by the server, set the credentials
        request.Credentials = CredentialCache.DefaultCredentials;
        // get the response
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        //display the status
        Console.WriteLine("Status: " + response.StatusDescription);
        Console.WriteLine(new string('*',50));
        //get the stream using a streamreader for easy accsess
        Stream dataStream = response.GetResponseStream();
        //open the stream using a streamreader for easy accsess
        StreamReader reader = new StreamReader(dataStream);
        //read the content
        string responseFromServer = reader.ReadToEnd();
        //display the content
        Console.WriteLine(responseFromServer);
        Console.WriteLine(new string('*', 50));
        //cleanup the streams and the response
        reader.Close();
        dataStream.Close();
        response.Close();
    }
}