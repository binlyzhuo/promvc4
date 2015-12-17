﻿using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace WebApiProject.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            //===
            //
            return View();
        }

        public ActionResult GetPost()
        {
            string url = "http://localhost:2908/api/persons/getperson";
            string data = "ooo";
            string msg = Post();
            Response.Write(msg);
            return View();
        }

        private string Post()
        {
            var handler = new HttpClientHandler() { AutomaticDecompression = DecompressionMethods.Deflate };
            var client = new HttpClient(handler);
            
            client.BaseAddress = new Uri("http://localhost:2908/api/persons/getperson");
            //client.DefaultRequestHeaders.Accept.Add(new AcceptVerbsAttribute());
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.PostAsync(client.BaseAddress,null).Result;
            string msg="";
            if (response.IsSuccessStatusCode)
            {

                msg = response.Content.ReadAsStringAsync().Result;

            }
            return msg;
        }

        private string GetPost2(string url,string data)
        {
            string result = "";
            HttpWebRequest request = null;
            request = WebRequest.Create(url) as HttpWebRequest;
            request.Timeout = 60000;
            request.KeepAlive = true;
            System.Net.ServicePointManager.Expect100Continue = false;

            request.Method = "POST";
            request.Headers.Add("Accept-Encoding", "gzip");
            byte[] bdata = Encoding.UTF8.GetBytes(data);
            request.ContentType = "application/json;charset=utf-8";
            request.ContentLength = bdata.Length;

            Stream streamOut = request.GetRequestStream();
            streamOut.Write(bdata, 0, bdata.Length);
            streamOut.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream streamIn = response.GetResponseStream();
            if (response.ContentEncoding.ToLower().Contains("gzip"))
            {
                using (GZipStream steam = new GZipStream(streamIn, CompressionMode.Decompress))
                {
                    using (StreamReader reader = new StreamReader(streamIn))
                    {
                        result = reader.ReadToEnd();
                    }
                }
            }
            else
            {
                using (StreamReader reader = new StreamReader(streamIn))
                {
                    result = reader.ReadToEnd();
                }
            }

            streamIn.Close();
            response.Close();
            return result;
        }
    }
}
