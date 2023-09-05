using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ApiDAL
    {
        public object getData()
        {
            string link = "http://data.gonsa.com.vn/api/depot/getKhoHang";
            HttpWebRequest req = HttpWebRequest.CreateHttp(link);
            WebResponse res = req.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(List<KhoHang>));
            object data = js.ReadObject(res.GetResponseStream());
            return data;
        }
    }
}
