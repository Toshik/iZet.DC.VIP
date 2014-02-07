﻿/*
using System;
using System.Linq;
using System.Net;
using System.Reflection;

namespace iZet.DC.VIP.Helpers
{
    public class SocksWebClient : WebClient
    {
        public IProxyDetails ProxyDetails { get; set; }
        public string UserAgent { get; set; }

        protected override WebRequest GetWebRequest(Uri address)
        {
            WebRequest result = null;

            if (ProxyDetails != null)
            {
                if (ProxyDetails.ProxyType == ProxyType.Proxy)
                {
                    result = (HttpWebRequest)WebRequest.Create(address);
                    result.Proxy = new WebProxy(ProxyDetails.FullProxyAddress);
                    if (!string.IsNullOrEmpty(UserAgent))
                        ((HttpWebRequest)result).UserAgent = UserAgent;
                }
                else if (ProxyDetails.ProxyType == ProxyType.Socks)
                {
                    result = SocksHttpWebRequest.Create(address);
                    result.Proxy = new WebProxy(ProxyDetails.FullProxyAddress);
                    //TODO: implement user and password

                }
                else if (ProxyDetails.ProxyType == ProxyType.None)
                {
                    result = (HttpWebRequest)WebRequest.Create(address);
                    if (!string.IsNullOrEmpty(UserAgent))
                        ((HttpWebRequest)result).UserAgent = UserAgent;
                }
            }
            else
            {
                result = (HttpWebRequest)WebRequest.Create(address);
                if (!string.IsNullOrEmpty(UserAgent))
                    ((HttpWebRequest)result).UserAgent = UserAgent;
            }


            return result;
        }

    }
}
*/
