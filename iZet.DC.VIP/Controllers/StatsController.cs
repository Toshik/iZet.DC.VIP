using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using iZet.DC.VIP.Models;

namespace iZet.DC.VIP.Controllers
{
    public class StatsController
    {

        public void GetStats()
        {
            Socket client;
            client = LMKR.SocksProxy.ConnectToSocks5Proxy(
              "127.0.0.1", 1082, "dc.zet",
              80, "", "");

            string strGet = "POST /?stat&pages=0 HTTP/1.1";
            var post = "vip_nick=toshik&dostatnickform=OK";
            var headers = new string[]
                            {
                                // Request
                                strGet,
                                
//                                "",

                                // Headers
                                "Host: dc.zet",
                                "User-Agent: Mozilla/5.0 (Windows NT 6.2; WOW64; rv:27.0) Gecko/20100101 Firefox/27.0",
                                "Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
                                "Accept-Language: ru-RU,ru;q=0.8,en-US;q=0.5,en;q=0.3",
                                "Referer: http://dc.zet/?stat",
                                "Connection: keep-alive",
                                //"Accept-Encoding: gzip, deflate",
                                
//                                "",

                                // Stream headers
                                "Content-Length: " + Encoding.UTF8.GetByteCount(post),
                                "Content-Type:	application/x-www-form-urlencoded",
                                
                                "",

                                // Content
                                post,
                            } ;

            client.Send(System.Text.Encoding.ASCII.GetBytes(string.Join("\r\n", headers)));
            byte[] buf = new byte[65535];
            client.Receive(buf);

            buf.ToString();
            var aa = Encoding.Default.GetString(buf, 0, buf.Length);

            var name = "toshik";
            var match = Regex.Match(aa,
                name + @".*: (?<date>.+)<br />.*: (?<regdate>.+)<br />.*: (?<slots>\d+)<br />.*: (?<share>\d+)<br />.*: (?<time>\d+)<br />.*: (?<maxshare>\d+)<br />.*: (?<traffic>\d+)<br />", RegexOptions.Singleline | RegexOptions.IgnoreCase);

            Stats.Instance.SharedMax = Convert.ToDecimal(match.Groups["maxshare"].Value);
            Stats.Instance.SharedAverage = Convert.ToDecimal(match.Groups["share"].Value);
            Stats.Instance.OnlineHours = Convert.ToDecimal(match.Groups["time"].Value);
            Stats.Instance.Time = Convert.ToDateTime(match.Groups["date"].Value);
            Stats.Instance.Slots = Convert.ToUInt32(match.Groups["slots"].Value);
            Stats.Instance.Traffic = Convert.ToUInt32(match.Groups["traffic"].Value);
            Stats.Instance.Registered = Convert.ToDateTime(match.Groups["regdate"].Value);

        }

    }
}
