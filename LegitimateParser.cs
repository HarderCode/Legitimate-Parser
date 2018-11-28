using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net.Http.Headers;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Module1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take a localpath in C:
            string path = ("C://Users//user//Desktop//Legitimates.txt");
            StreamReader reader = File.OpenText(path);
            //open and read the file
            

            string urls;
            string[] legitimate_list = File.ReadAllLines(path);
            //pass in to a list which is named legitimate_list
            for (int i = 0; i < legitimate_list.Count() - 1; i++)
            //count every element in list and take them into for loop
            {
                urls = legitimate_list[i];
                Uri uri = new Uri(urls);
                //every legitimate_list element became uri
                System.Console.WriteLine("AbsolutePath = {0}", uri.AbsolutePath);
                System.Console.WriteLine("AbsoluteUri = {0}", uri.AbsoluteUri);
                System.Console.WriteLine("Authority = {0}", uri.Authority);
                System.Console.WriteLine("DnsSafeHost = {0}", uri.DnsSafeHost);
                System.Console.WriteLine("HostNameType = {0}", uri.HostNameType);
                System.Console.WriteLine("IsAbsoluteUri = {0}", uri.IsAbsoluteUri);
                System.Console.WriteLine("IsDefaultPort = {0}", uri.IsDefaultPort);
                System.Console.WriteLine("IsFile = {0}", uri.IsFile);
                System.Console.WriteLine("IsLoopback = {0}", uri.IsLoopback);
                System.Console.WriteLine("IsUnc = {0}", uri.IsUnc);
                System.Console.WriteLine("LocalPath = {0}", uri.LocalPath);
                System.Console.WriteLine("PathAndQuery = {0}", uri.PathAndQuery);
                System.Console.WriteLine("Port = {0}", uri.Port);
                System.Console.WriteLine("Query = {0}", uri.Query);
                System.Console.WriteLine("Scheme = {0}", uri.Scheme);
                //All the circumstances are showed in console

            }






        }


    }
}
