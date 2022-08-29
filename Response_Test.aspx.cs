using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PaymentGateway;
using Newtonsoft.Json;

namespace WebApplication1
{
    public partial class Response_Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FristPayRequest FRObj = new FristPayRequest();
            FristPayResponse frobject = new FristPayResponse();
            Response res = new Response();
            string strfpTxnId = Request["fpTxnId"];
            string strencData = Request["encData"];
            string merchantId = Request["merchantId"];
            //string udf1 = Request["ref_id"];
            Result rr = new Result();
            rr.merchantId = merchantId;
            rr.encData = strencData;
            rr.fpTxnId = strfpTxnId;
            //rr.udf1 = "strref_id";
            dynamic data = JsonConvert.SerializeObject(rr);
            string sResponsePayRequest = frobject.getresponse("https://www.fdconnect.com/FDConnectL3Services/decryptMerchantResponse", "", merchantId, data);
            dynamic data1 = JsonConvert.DeserializeObject(sResponsePayRequest);
            lblres.Text = sResponsePayRequest.ToString();

        }
    }
}
