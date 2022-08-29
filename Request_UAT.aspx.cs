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
    public partial class Request_UAT : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FristPayRequest FRObj = new FristPayRequest();
            FristPayRequestSample FRSample = new FristPayRequestSample();
            FristPayResponse frobject = new FristPayResponse();
            //string udf1 = null;
            //FristPayRequestSample request = new FristPayRequestSample("470000000332252", "CNy+HimxmI4PmrJWrpLarBfbo6jIY/CHcezg2VQ8u5o=", "9T4hd3Nx0b0sMgYuyWLCTg==", "https://WWW.test.fdconnect.com/FirstPayL2Services/getToken", "1.5", "INR", "123456", "SALE", "Prashanth", "Kumar", "M", "9769970899", "prashanth@gmail.com", "/FirstPayL2Services/merchantSuccessPage.jsp","");
            ///FristPayRequestSample request = new FristPayRequestSample("470000000332260", "CNy+HimxmI4PmrJWrpLarBfbo6jIY/CHcezg2VQ8u5o=", "9T4hd3Nx0b0sMgYuyWLCTg==", "https://test.fdconnect.com/FirstPayL2Services/getToken", "1", "INR", "STR_68", "SALE", "Prashanth", "Kumar", "M", "9176672126", "Test_8876421@gmail.com", "http://localhost:63448/Response_Test.aspx"," ","UDF_1TEST","UDF_2TEST","UDF_3TEST","uDF_4TEST","","","","","","");
            // FristPayRequestSample request = new FristPayRequestSample("470000014911046", "vdl/f7f19hmKxdpVGcFMffNmRU3yfrfDNerRTaAfAYg=", "tOnFWVSz+j21LNWQlZqScw==", "https://test.fdconnect.com/FirstPayL2Services/getToken", "1", "INR", "STR_70", "SALE", "Prashanth", "Kumar", "M", "9176672126", "Test_8876421@gmail.com", "http://localhost:63448/Response_Test.aspx", " ", "UDF_1TEST", "UDF_2TEST", "UDF_3TEST", "uDF_4TEST", "", "", "", "", "", "");
            //FristPayRequestSample request = new FristPayRequestSample("470000000255972", "kCTAu4TOmirjC0BiJXuM3wORDsm03ITpsDpZYbZ0TTE=", "dLZmkqqFBGmnJ2LtLIY0fA==", "https://www.fdconnect.com/FDConnectL3Services/getToken", "1", "INR", "STR_106", "SALE", "Prashanth", "Kumar", "M", "9176672126", "Test_8876421@gmail.com", "http://localhost:63448/Response_Test.aspx", "", "UDF_1TEST", "UDF_2TEST", "UDF_3TEST", "uDF_4TEST", "", "", "", "", "", "");
            //List<String> obj = new List<String>();
            //obj.Add("KRS1220ESFFTR8490");
            //FristPayRequestSample request = new FristPayRequestSample("http://localhost:63448/Response_Test.aspx", "1", "INR", "STR_106", "SALE", "MERCHANT_PAYMENT_MODE_CARD_INTEGRATION", "CREDITCARD", "", "", "", "", "", "", "", "", "", "", "470000000255972", "kCTAu4TOmirjC0BiJXuM3wORDsm03ITpsDpZYbZ0TTE=", "dLZmkqqFBGmnJ2LtLIY0fA==", "https://www.fdconnect.com/FDConnectL3Services/getToken", "",obj, "9176672126", "Test_8876421@gmail.com", "5419190406084395", "01", "24", "397", "Theeban", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "PageId2019120415869", "");


            /*string sResponsePayRequest= FRObj.sale(request);
            frobject =
            JsonConvert.DeserializeObject<FristPayResponse>(sResponsePayRequest);
            dynamic data1 = JsonConvert.DeserializeObject(sResponsePayRequest);
            if (frobject.response.sessionTokenId != null)
            {
                string URL = "https://www.fdconnect.com/Pay/?sessionToken=" + frobject.response.sessionTokenId + "&configId=PageId2019120415869";
                Response.Redirect(URL.ToString(), false);
            }

            /*string sResponsePayRequest = FRObj.sale(request);
            frobject = JsonConvert.DeserializeObject<FristPayResponse>(sResponsePayRequest);



            dynamic data1 = JsonConvert.DeserializeObject(sResponsePayRequest);
            if (frobject.response.sessionTokenId != null)
            {
                string URL = "https://www.fdconnect.com/Pay/?sessionToken=" + frobject.response.sessionTokenId + "&configId=PageId2019120415869";
                Response.Redirect(URL.ToString(), false);
            }*/

            FRSample.amount = "1.5";
            FRSample.currencyCode = "INR";
            FRSample.clientTransactionId = "STR_143";
            FRSample.transactionType = "SALE";
            FRSample.fpURL = "https://www.fdconnect.com/FDConnectL3Services/getToken";
            FRSample.merchantid = "470000000255972";
            FRSample.Key = "kCTAu4TOmirjC0BiJXuM3wORDsm03ITpsDpZYbZ0TTE=";
            FRSample.IV = "dLZmkqqFBGmnJ2LtLIY0fA==";
            FRSample.customerId = "ABC1234";
            List<String> obj = new List<String>();
            obj.Add("KRS1220ESFFTR8490");
            FRSample.hostedIds = obj;
            FRSample.firstName = "ABC";
            FRSample.lastName = "XYZ";
            FRSample.middleName = "DEF";
            FRSample.suffix = "ADX";
            FRSample.mobileNo = "1234567890";
            FRSample.emailId = "abc@gmail.com";
            FRSample.street1 = "Ghodbandar Rode";
            FRSample.stree2 = "Sai Nagar";
            FRSample.city = "Mumbai";
            FRSample.state = "Maharashtra";
            FRSample.country = "India";
            FRSample.zipcode = "400000";
            FRSample.street1 = "Ghodbandar Rode";
            FRSample.stree2 = "Sai nagar";
            FRSample.city = "Mumbai";
            FRSample.state = "Maharashtra";
            FRSample.country = "India";
            FRSample.zipcode = "400000";
            /*FRSample.paymentMethodType = "CREDITCARD";
            FRSample.integrationType = "MERCHANT_PAYMENT_MODE_INTEGRATION";
            /*FRSample.configId = "PageId2019120415869";
            FRSample.sessionTokenExpireDate = "23-03-2022";
            FRSample.cardNumber = "4585460004797693";
            FRSample.expMonth = "12";
            FRSample.expYear = "23";
            FRSample.cVV = "123";
            FRSample.nameOnCard = "shweta";*/
            FRSample.resultURL = "http://localhost:63448/Response_Test.aspx";



            /*string sResponsePayRequest = FRObj.sale(FRSample);
            Console.Write(sResponsePayRequest);
            System.Diagnostics.Debug.WriteLine(sResponsePayRequest); ELINK*/
            //System.OutOfMemoryException.println(sResponsePayRequest)

            string sResponsePayRequest = FRObj.sale(FRSample);
            frobject = JsonConvert.DeserializeObject<FristPayResponse>(sResponsePayRequest);
             dynamic data1 = JsonConvert.DeserializeObject(sResponsePayRequest);

           if (frobject.response.sessionTokenId != null)
            {
                string URL = "https://www.fdconnect.com/Pay/?sessionToken=" + frobject.response.sessionTokenId + "&configId=PageId2019120415869";
                Response.Redirect(URL.ToString(), false);
            }

            /*REFUND*/
            /*FirstPayRefundRequest frpayrefreq = new FirstPayRefundRequest();
            FirstPayRefundResponse frpayrefres = new FirstPayRefundResponse();
            /*FRRefndsample.merchantTxnId = "123456";
            FRRefndsample.fpTransactionId = "2019092618971403";//2019092618971403
            FRRefndsample.refundAmount = "1.00";
            FRRefndsample.fpURL = "https://www.test.fdmerchantservices.com/FirstPayL2Services/refundTxnDetail";
            FRRefndsample.merchantId = "470000000332252";
            FRRefndsample.key = "CNy+HimxmI4PmrJWrpLarBfbo6jIY/CHcezg2VQ8u5o=";
            FRRefndsample.iv = "9T4hd3Nx0b0sMgYuyWLCTg==";
            FRRefndsample.logpath = "C:\\PaymentGateway_Log\\";*/
            FirstPayRefundRequestSample FRRefndsampleCons = new FirstPayRefundRequestSample("STR_126", "2022032430844880", "1.00", "https://www.fdconnect.com/FDConnectL3Services/refundTxnDetail", "470000000255972","kCTAu4TOmirjC0BiJXuM3wORDsm03ITpsDpZYbZ0TTE=", "dLZmkqqFBGmnJ2LtLIY0fA==", "");
            /*string sResponsePayRequest3 = frpayrefreq.getresponsePayInquiryandRefundRequest(FRRefndsampleCons);
            frpayrefres = JsonConvert.DeserializeObject<FirstPayRefundResponse>(sResponsePayRequest3);
            System.Diagnostics.Debug.WriteLine(sResponsePayRequest3);

            /*INQUERY
            FirstPayInquiryRequest frpayeqyrqt = new FirstPayInquiryRequest();
            FirstPayInquiryRequestSample FRINQsample = new FirstPayInquiryRequestSample();
            FirstPayInquiryResponse frpayeqyresponse = new FirstPayInquiryResponse();

            /*FRINQsample.merchantTxnId = "123456";
            FRINQsample.fpTransactionId = "2019092618971403";
            FRINQsample.fpURL = "https://www.test.fdmerchantservices.com/FirstPayL2Services/getTxnInquiryDetail";
            FRINQsample.merchantId = "470000000332252";
            FRINQsample.key = "CNy+HimxmI4PmrJWrpLarBfbo6jIY/CHcezg2VQ8u5o=";
            FRINQsample.iv = "9T4hd3Nx0b0sMgYuyWLCTg==";
            FRINQsample.logpath = "C:\\PaymentGateway_Log\\";*/

            /*FirstPayInquiryRequestSample FRINQsampleCons = new FirstPayInquiryRequestSample("STR_74", "2022032187093052", "https://www.fdconnect.com/FDConnectL3Services/getTxnInquiryDetail", "470000000255972", "kCTAu4TOmirjC0BiJXuM3wORDsm03ITpsDpZYbZ0TTE=", "dLZmkqqFBGmnJ2LtLIY0fA==", "C:\\PaymentGateway_Log\\");
            string sResponsePayRequest2 = frpayeqyrqt.getresponsePayInquiryandRefundRequest(FRINQsampleCons);
            frpayeqyresponse = JsonConvert.DeserializeObject<FirstPayInquiryResponse>(sResponsePayRequest2);
            System.Diagnostics.Debug.WriteLine(sResponsePayRequest2);*/
        }
    }
}

       

