using System.Xml;
using System.Net;
using System.IO;
using System;
using Interfaces;


namespace YamahaClient
{
    public class AVReceiver : IAVReceiver
    {
        private IYamahaCommand yamahaCommand;
        public AVReceiver()
        {
            yamahaCommand = new YamahaCommand();
        }
        public void PowerOn()
        {
            SendCommand(yamahaCommand.On);
        }
        public void PowerOff()
        {
            SendCommand(yamahaCommand.Off);
        }
        public void VolumeUp()
        {
            SendCommand(yamahaCommand.VolUp);

        }
        public void VolumeDown()
        {
            SendCommand(yamahaCommand.VolDown);
        }
        
        public void SendCommand(string command)
        {
            var url = "http://192.168.0.186/YamahaRemoteControl/ctrl";
            var body = command;

            XmlDocument soapEnvelopeXml = CreateSoapEnvelope(body);
            HttpWebRequest webRequest = CreateWebRequest(url);
            InsertSoapEnvelopeIntoWebRequest(soapEnvelopeXml, webRequest);

            // begin async call to web request.
            IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);

            // suspend this thread until call is complete. You might want to
            // do something usefull here like update your UI.
            asyncResult.AsyncWaitHandle.WaitOne();

            // get the response from the completed web request.
            string soapResult;
            using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
            {
                using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
                {
                    soapResult = rd.ReadToEnd();
                }
                Console.Write(soapResult);
            }
        }

        private HttpWebRequest CreateWebRequest(string url)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.ContentType = "text/xml;charset=\"utf-8\"";
            webRequest.Accept = "text/xml";
            webRequest.Method = "POST";
            return webRequest;
        }

        private XmlDocument CreateSoapEnvelope(string body)
        {
            XmlDocument soapEnvelop = new XmlDocument();
            soapEnvelop.LoadXml(@body);
            return soapEnvelop;
        }

        private void InsertSoapEnvelopeIntoWebRequest(XmlDocument soapEnvelopeXml, HttpWebRequest webRequest)
        {
            using (Stream stream = webRequest.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
            }
        }
}
}
