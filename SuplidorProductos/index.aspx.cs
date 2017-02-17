using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SuplidorProductos
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                requestFireBase();
            }
            
        }
        public void writeFireBase() { 
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(new
            {
                name = name.Text,
                email = email.Text,
                telephones = tel1.Text + "-" + tel2.Text + "-" + tel3.Text,
                message = message.Text,
            });
            var request = WebRequest.CreateHttp("https://suplidorproductos.firebaseio.com/.json");
            request.Method = "POST";
            request.ContentType = "application/json";
            var buffer = Encoding.UTF8.GetBytes(json);
            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);
            var response = request.GetResponse();
            json = (new StreamReader(response.GetResponseStream())).ReadToEnd();
        }
        public void requestFireBase(){
            try
            {
                var request = WebRequest.CreateHttp("https://suplidorproductos.firebaseio.com/.json");
                var response = request.GetResponse();
                var json = (new StreamReader(response.GetResponseStream())).ReadToEnd();

                JObject my_obj = JsonConvert.DeserializeObject<JObject>(json);

                foreach (KeyValuePair<string, JToken> sub_obj in (JObject)my_obj)
                {
                    Response.Write("---------------------------------------------------------");
                    foreach (KeyValuePair<string, JToken> sub_objt in (JObject)my_obj[sub_obj.Key])
                    {
                        Response.Write("<h1>" + sub_objt.Key + ": " + "</h1> " + "<h2>" + sub_objt.Value + "</h2>");
                    }
                    Response.Write("---------------------------------------------------------");
                }
            }
            catch (Exception ex) { Response.Write(ex.Message); }
        }

        protected void Unnamed7_Click(object sender, EventArgs e)
        {
            writeFireBase();
            requestFireBase();
        }
    }
}