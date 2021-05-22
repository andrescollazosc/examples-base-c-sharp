using RestSharp;
using RestSharp.Authenticators;
using System;

namespace AppConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = SendSimpleMessage();
            Console.WriteLine(result.StatusCode + "  " + result.Content);
        }


        public static IRestResponse SendSimpleMessage()
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri("https://api.mailgun.net/v3");

            client.Authenticator = new HttpBasicAuthenticator("api", "e3c09d420ed0b4262758eee5196a7879-4de08e90-b8eadc6f");
            RestRequest request = new RestRequest();
            request.AddParameter("domain", "sandbox229e6c9ae7224914828e96686b1409ea.mailgun.org", ParameterType.UrlSegment);
            request.Resource = "{domain}/messages";
            request.AddParameter("from", "Mailgun Sandbox <postmaster@sandbox229e6c9ae7224914828e96686b1409ea.mailgun.org>");
            request.AddParameter("to", "Andres Collazos <andrescollazosc@gmail.com>");
            request.AddParameter("subject", "Hola Andres Collazos");
            request.AddParameter("html", $"{ GetTemplate() }");
            request.Method = Method.POST;
            
            return client.Execute(request);
        }

        public static string GetTemplate()
        {
            string html = @"<!DOCTYPE html>
<html lang='en'>
<head>
    <meta charset='UTF-8'>
    <meta http-equiv='X-UA-Compatible' content='IE=edge'>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
    <style>
        .container {
            display: flex;
            flex-direction: row;
            height: 250px;
            width: 70%;
            border: 1px;
        }

        .title {
            background-color: lightgray;
        }
    </style>
</head>
<body>
    
    <div class='container'>
        <div class='title'>Nombres</div>
        <div class='title'>Apellidos</div>
    </div>

</body>
</html>";

            return html;
        }

    }
}
