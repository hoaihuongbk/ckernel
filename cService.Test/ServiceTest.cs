using System;
using System.Configuration;
using cModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace cService.Test
{
    [TestClass]
    public class ServiceTest
    {
        private const string Cs = "server=112.213.84.183;database=FutaMarketing;uid=futadev;pwd=CNLuwcRhLT;";
        private const string Cs2 = "server=112.213.84.183;database=FutaTest;uid=futadev;pwd=CNLuwcRhLT;";
        private const string Cs3 = "server=112.213.84.183;database=FutaBooking;uid=futadev;pwd=CNLuwcRhLT";
        private const string Cs4 = "server=118.69.196.250;database=Futa3rdTracking;uid=futa3rdtracking;pwd=OYsLdL10vRNP21mrtu6B;";
        private const string Cs5 = "server=112.213.84.183;database=FutaTaxi;uid=futadev;pwd=CNLuwcRhLT;";
        private const string Cs6 = "server=118.69.196.250;database=TicketOnline;uid=ticket;pwd=qweqw@#$@#sSDFSD(*(*_!#!@ds;";
        private const string Cs7 = "server=118.69.196.250;database=FutaBooking;uid=ftbooking;pwd=OSaWGPfkdOyK9COBm4Wd;";
        private const string Cs8 = "server=USER\\SQLEXPRESS;database=Test;uid=sa;pwd=VpL7YNq72u;";

        [TestMethod]
        public void TestGetMethod()
        {
            var email = string.Empty;
            try
            {
                var s = new S(Cs);
                var obj = new GCRequest()
                {
                    _a = "fGettbl_PT_GmailAccount",
                    _c = new Dictionary<string, object>()
                    {
                        {"Email", "noreply6@futabus.vn" }
                    },
                    _f = "Id,Email,Password,IsPrgCreatedDate"
                };
                var robj = s.P(obj);
                if (robj.Result.Equals(1))
                {
                    email = Convert.ToString(robj.Records[0][1]);
                }
            }
            catch (Exception)
            {
                
            }
            Assert.AreEqual(email, "noreply6@futabus.vn");
        }

        [TestMethod]
        public void TestGetMethod2()
        {
            var email = string.Empty;
            try
            {
                var s = new S(Cs);
                var obj = new GCRequest()
                {
                    _a = "fGettbl_PT_GmailAccount",
                    _c = new Dictionary<string, object>()
                    {
                        {"InUse", "$x > 0" }
                    },
                    _f = "Id,Email,Password,IsPrgCreatedDate"
                };
                var robj = s.P(obj);
                if (robj.Result.Equals(1))
                {
                    email = Convert.ToString(robj.Records[0][1]);
                }
            }
            catch (Exception)
            {

            }
            Assert.AreEqual(email, "noreply7@futabus.vn");
        }
        [TestMethod]
        public void TestGetMethod3()
        {
            var email = string.Empty;
            try
            {
                var s = new S(Cs);
                var obj = new GCRequest()
                {
                    _a = "fGettbl_PT_GmailAccount",
                    _c = new Dictionary<string, object>()
                    {
                        {"Email", "noreply7@futabus.vn" },
                        {"InUse", 1 }
                    },
                    _f = "Id,Email,Password,IsPrgCreatedDate"
                };
                var robj = s.P(obj);
                if (robj.Result.Equals(1))
                {
                    email = Convert.ToString(robj.Records[0][1]);
                }
            }
            catch (Exception)
            {

            }
            Assert.AreEqual(email, "noreply7@futabus.vn");
        }
        [TestMethod]
        public void TestGetMethod4()
        {
            int count = 0;
            try
            {
                var s = new S(Cs);
                var obj = new GCRequest()
                {
                    _a = "pGettbl_PT_MailBox",
                    _c = new Dictionary<string, object>()
                    {
                        {"Status", 1 },
                    },
                    _f = "Id,To,Subject,Body,IsPrgCreatedDate",
                    _od = new Dictionary<string, string>()
                    {
                        {"IsPrgCreatedDate", "DESC" }
                    },
                    _os = 0,
                    _lm = 1
                };
                var robj = s.P(obj);
                if (robj.Result.Equals(1))
                {
                    count = robj.TotalRecordCount;
                }
            }
            catch (Exception)
            {

            }
            Assert.AreEqual(1, count);
        }
        [TestMethod]
        public void TestGetMethod5()
        {
            var count = 0;
            try
            {
                var s = new S(Cs2);
                var obj = new GCRequest()
                {
                    _a = "pGettbl_CPC_XE_OnlineSession_View_001",
                    _c = new Dictionary<string, object>()
                    {
                        { "CurDate", "$x >= '2016-02-01T00:00:00.000' AND $x <= '2016-02-28T23:59:59.000'" },
                        {"Status", "Success"},
                    },
                    _f = "Id,CustName,CustMobile,CustEmail,CustAddress,CustPickupOfficeId,CustCMND,BookingNo,NumberOfTicket,TuyenDuongId,NgayDi,GioDi,TotalMoney,CurDate,Status,PaymentType,ClientApp,PayStatus,MailStatus,SMSStatus,CustId,CanBoCapNhat,Discount,Total",
                    _od = new Dictionary<string, string>()
                    {
                        {"CurDate", "DESC" }
                    },
                    _os = 0,
                    _lm = 10
                };
                var robj = s.P(obj);
                count = robj.Records.Count;
            }
            catch (Exception)
            {

            }
            Assert.AreEqual(10, count);
        }
        [TestMethod]
        public void TestGetMethod6()
        {
            var count = false;
            try
            {
                var s = new S(Cs3);

                var obj = new GCRequest()
                {
                    _a = "fGettbl_PaymentType",
                    _c = new Dictionary<string, object>
                        {
                            {"Status", 1}
                        },
                    _f = "Code, Name"
                };
                var robj = s.P(obj);
                count = robj.Records.Any();
            }
            catch (Exception)
            {

            }
            Assert.AreEqual(true, count);
        }
        [TestMethod]
        public void TestGetMethod7()
        {
            var count = 0;
            try
            {
                var s = new S(Cs5);

                var obj = new GCRequest()
                {
                    _a = "fGettbl_Driver",
                    _c = new Dictionary<string, object>
                    {
                        {"Latitude", 10.770067}
                    },
                    _f = "Code, FullName"
                };
                var robj = s.P(obj);
                count = robj.TotalRecordCount;
            }
            catch (Exception)
            {

            }
            Assert.AreEqual(1, count);
        }

        [TestMethod]
        public void TestGetMethod8()
        {
            var count = 0;
            try
            {
                var s = new S(Cs5);

                var obj = new GCRequest()
                {
                    _a = "fGettbl_Ticket",
                    _c = new Dictionary<string, object>
                    {
                        {"Status", 1}
                    },
                    _f = "SrcLat,SrcLng,DestLat,DestLng"
                };
                var robj = s.P(obj);
                count = robj.Result;
            }
            catch (Exception)
            {

            }
            Assert.AreEqual(1, count);
        }

        [TestMethod]
        public void TestGetMethod9()
        {
            var count = false;
            try
            {
                var s = new S(Cs7);

                var obj = new GCRequest()
                {
                    _a = "fGettbl_Route_Online_View",
                    _c = new Dictionary<string, object>
                    {
                        {"Status", 1}
                    },
                    _f = "Id,Name"
                };
                var robj = s.P(obj);
                count = robj.Records.Count > 0;
            }
            catch (Exception)
            {

            }
            Assert.AreEqual(true, count);
        }

        [TestMethod]
        public void TestInsertMethod()
        {
            var id = 0;
            try
            {
                var s = new S(Cs8);
                var obj = new GCRequest()
                {
                    _a = "InsertDeliveryConversation",
                    _d = new Dictionary<string, object>()
                    {
                        {"OrderId", 22137 },
                        {"Type", 1 },
                        {"CreatedOn", string.Format("{0:yyyy-MM-ddTHH:mm:ss.000}", DateTime.Now) }
                    },
                };
                var robj = s.P(obj);
                if (robj.Result.Equals(1))
                {
                    id = Convert.ToInt32(robj.Records[0][0]);
                }
            }
            catch (Exception)
            {

            }
            Assert.AreEqual(true, id > 0);
        }
        [TestMethod]
        public void TestInsertMethod2()
        {
            var n = 100;
            var ids = new int[n];
            try
            {
                
                var s = new S(Cs8);
                var obj = new GCRequest()
                {
                    _a = "InsertDeliveryConversation",
                    _md = new Dictionary<string, object>[n]
                    //_d = new Dictionary<string, object>()
                    //{
                    //    {"To", "namto87@yahoo.com.vn" },
                    //    {"CC", null },
                    //    {"BCC", null },
                    //    {"Subject", "Test subject" },
                    //    {"Body","<table align=\"center\" border=\"0\" cellpadding=\"10\" cellspacing=\"0\" style=\"font-family:arial; width:100%\">\r\n\t<tbody>\r\n\t\t<tr>\r\n\t\t\t<td>\r\n\t\t\t<table align=\"center\" border=\"0\" cellpadding=\"10\" cellspacing=\"0\" style=\"height:611px; width:650px\">\r\n\t\t\t\t<tbody>\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t<div style=\"position:relative;\"><img src=\"https://futabus.vn/uploads/useravatar/1944722557_giovang_landingpage-SUA-option-2_03.png\" style=\"height:281px; width:650px\" /> <a href=\"https://play.google.com/store/apps/details?id=com.futabus.activity\" style=\"position:absolute; right:65px;bottom:2px;\"> <img src=\"https://futabus.vn/uploads/useravatar/275969533_icon_google.png\" /> </a> <a href=\"https://itunes.apple.com/us/app/futa/id1049039667\" style=\"position:absolute; bottom:2px; right: 129px;\"> <img src=\"https://futabus.vn/uploads/useravatar/1884038435_icon_apple.png\" /> </a></div>\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t<table border=\"0\" cellpadding=\"10\" cellspacing=\"0\">\r\n\t\t\t\t\t\t\t<tbody>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t<p>C&aacute;c tuyến giờ trong khung giờ khuyến m&atilde;i<sup> (*)</sup></p>\r\n\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t<p>___________</p>\r\n\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t<p>H&atilde;y t&igrave;m biểu tượng <img src=\"https://futabus.vn/uploads/useravatar/976887127_icon_giovang.png\" /> để mua v&eacute; với gi&aacute; ưu đ&atilde;i</p>\r\n\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t\t</table>\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t<table border=\"0\" cellpadding=\"10\" cellspacing=\"0\" style=\"height:196px; width:100%\">\r\n\t\t\t\t\t\t\t<tbody>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<th>Bến đi</th>\r\n\t\t\t\t\t\t\t\t\t<th>Bến đến</th>\r\n\t\t\t\t\t\t\t\t\t<th>Loại xe</th>\r\n\t\t\t\t\t\t\t\t\t<th>Gi&aacute; v&eacute;</th>\r\n\t\t\t\t\t\t\t\t\t<th>&nbsp;</th>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<td>S&agrave;i G&ograve;n</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đ&agrave; Lạt</td>\r\n\t\t\t\t\t\t\t\t\t<td>Giường</td>\r\n\t\t\t\t\t\t\t\t\t<td>Chỉ từ 1000</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đặt v&eacute; ngay</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<td>S&agrave;i G&ograve;n</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đ&agrave; Lạt</td>\r\n\t\t\t\t\t\t\t\t\t<td>Giường</td>\r\n\t\t\t\t\t\t\t\t\t<td>Chỉ từ 1000</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đặt v&eacute; ngay</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<td>S&agrave;i G&ograve;n</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đ&agrave; Lạt</td>\r\n\t\t\t\t\t\t\t\t\t<td>Giường</td>\r\n\t\t\t\t\t\t\t\t\t<td>Chỉ từ 1000</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đặt v&eacute; ngay</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<td>S&agrave;i G&ograve;n</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đ&agrave; Lạt</td>\r\n\t\t\t\t\t\t\t\t\t<td>Giường</td>\r\n\t\t\t\t\t\t\t\t\t<td>Chỉ từ 1000</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đặt v&eacute; ngay</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<td>S&agrave;i G&ograve;n</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đ&agrave; Lạt</td>\r\n\t\t\t\t\t\t\t\t\t<td>Giường</td>\r\n\t\t\t\t\t\t\t\t\t<td>Chỉ từ 1000</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đặt v&eacute; ngay</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t\t</table>\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t<table border=\"0\" cellpadding=\"10\" cellspacing=\"0\" style=\"width:100%\">\r\n\t\t\t\t\t\t\t<tbody>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<th>Trung t&acirc;m hỗ trợ &amp; chăm s&oacute;c kh&aacute;ch h&agrave;ng</th>\r\n\t\t\t\t\t\t\t\t\t<th>&nbsp;</th>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t<p>231-233 L&Ecirc; HỒNG PHONG, P4, Q5, TPHCM.</p>\r\n\r\n\t\t\t\t\t\t\t\t\t<p>TỔNG Đ&Agrave;I LI&Ecirc;N HỆ: <strong>1900 6067</strong> (PHỤC VỤ 24/7)</p>\r\n\r\n\t\t\t\t\t\t\t\t\t<p>ĐỂ BIẾT TH&Ecirc;M NHIỀU TH&Ocirc;NG TIN KHUYẾN M&Atilde;I, VUI L&Ograve;NG TRUY CẬP WEBSITE <a href=\"https://futabus.vn/\" style=\"color:#ff4229\" target=\"_blank\">FUTABUS.VN</a> HOẶC LIKE <a href=\"https://www.facebook.com/xephuongtrang\" style=\"color:#ff4229\" target=\"_blank\">FANPAGE</a> CỦA CH&Uacute;NG T&Ocirc;I</p>\r\n\r\n\t\t\t\t\t\t\t\t\t<p>(*) C&aacute;c chuyến xe trong khung giờ khuyến m&atilde;i sẽ được th&ocirc;ng b&aacute;o cụ thể tr&ecirc;n website <a href=\"https://futabus.vn/\" style=\"color:#ff4229\" target=\"_blank\">futabus.vn</a> v&agrave; ứng dụng di động FUTA Bus.</p>\r\n\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t<td><a href=\"https://www.facebook.com/xephuongtrang\" target=\"_blank\"><img src=\"https://futabus.vn/uploads/useravatar/543705534_icon_fb.png\" /> </a> <a href=\"#\"> <img src=\"https://futabus.vn/uploads/useravatar/1990245067_icon_tt.png\" /> </a></td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t\t</table>\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t</tbody>\r\n\t\t\t</table>\r\n\t\t\t</td>\r\n\t\t</tr>\r\n\t</tbody>\r\n</table>\r\n" }
                    //},
                };
                for(var i = 0; i < n; i++)
                {
                    obj._md[i] = new Dictionary<string, object>()
                    {
                        {"OrderId", 22137 + i },
                        {"Type", 1 },
                        {"CreatedOn", string.Format("{0:yyyy-MM-ddTHH:mm:ss.000}", DateTime.Now) }
                    };
                }

                var robj = s.P(obj);
                if (robj.Result.Equals(1))
                {
                    ids = robj.Records.Select(c => Convert.ToInt32(c[0])).ToArray();
                }
            }
            catch (Exception)
            {

            }
            Assert.AreEqual(n, ids.Length);
        }
        [TestMethod]
        public void TestInsertMethod3()
        {
            var id = 0;
            try
            {
                var s = new S(Cs);
                var obj = new GCRequest()
                {
                    _a = "Inserttbl_PT_MailBox",
                    _d = new Dictionary<string, object>()
                    {
                        {"To", "namto87@yahoo.com.vn" },
                        {"CC", null },
                        {"BCC", null },
                        {"Subject", "Test subject" },
                        {"Body","<table align=\"center\" border=\"0\" cellpadding=\"10\" cellspacing=\"0\" style=\"font-family:arial; width:100%\">\r\n\t<tbody>\r\n\t\t<tr>\r\n\t\t\t<td>\r\n\t\t\t<table align=\"center\" border=\"0\" cellpadding=\"10\" cellspacing=\"0\" style=\"height:611px; width:650px\">\r\n\t\t\t\t<tbody>\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t<div style=\"position:relative;\"><img src=\"https://futabus.vn/uploads/useravatar/1944722557_giovang_landingpage-SUA-option-2_03.png\" style=\"height:281px; width:650px\" /> <a href=\"https://play.google.com/store/apps/details?id=com.futabus.activity\" style=\"position:absolute; right:65px;bottom:2px;\"> <img src=\"https://futabus.vn/uploads/useravatar/275969533_icon_google.png\" /> </a> <a href=\"https://itunes.apple.com/us/app/futa/id1049039667\" style=\"position:absolute; bottom:2px; right: 129px;\"> <img src=\"https://futabus.vn/uploads/useravatar/1884038435_icon_apple.png\" /> </a></div>\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t<table border=\"0\" cellpadding=\"10\" cellspacing=\"0\">\r\n\t\t\t\t\t\t\t<tbody>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t<p>C&aacute;c tuyến giờ trong khung giờ khuyến m&atilde;i<sup> (*)</sup></p>\r\n\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t<p>___________</p>\r\n\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t<p>H&atilde;y t&igrave;m biểu tượng <img src=\"https://futabus.vn/uploads/useravatar/976887127_icon_giovang.png\" /> để mua v&eacute; với gi&aacute; ưu đ&atilde;i</p>\r\n\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t\t</table>\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t<table border=\"0\" cellpadding=\"10\" cellspacing=\"0\" style=\"height:196px; width:100%\">\r\n\t\t\t\t\t\t\t<tbody>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<th>Bến đi</th>\r\n\t\t\t\t\t\t\t\t\t<th>Bến đến</th>\r\n\t\t\t\t\t\t\t\t\t<th>Loại xe</th>\r\n\t\t\t\t\t\t\t\t\t<th>Gi&aacute; v&eacute;</th>\r\n\t\t\t\t\t\t\t\t\t<th>&nbsp;</th>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<td>S&agrave;i G&ograve;n</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đ&agrave; Lạt</td>\r\n\t\t\t\t\t\t\t\t\t<td>Giường</td>\r\n\t\t\t\t\t\t\t\t\t<td>Chỉ từ 1000</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đặt v&eacute; ngay</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<td>S&agrave;i G&ograve;n</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đ&agrave; Lạt</td>\r\n\t\t\t\t\t\t\t\t\t<td>Giường</td>\r\n\t\t\t\t\t\t\t\t\t<td>Chỉ từ 1000</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đặt v&eacute; ngay</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<td>S&agrave;i G&ograve;n</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đ&agrave; Lạt</td>\r\n\t\t\t\t\t\t\t\t\t<td>Giường</td>\r\n\t\t\t\t\t\t\t\t\t<td>Chỉ từ 1000</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đặt v&eacute; ngay</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<td>S&agrave;i G&ograve;n</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đ&agrave; Lạt</td>\r\n\t\t\t\t\t\t\t\t\t<td>Giường</td>\r\n\t\t\t\t\t\t\t\t\t<td>Chỉ từ 1000</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đặt v&eacute; ngay</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<td>S&agrave;i G&ograve;n</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đ&agrave; Lạt</td>\r\n\t\t\t\t\t\t\t\t\t<td>Giường</td>\r\n\t\t\t\t\t\t\t\t\t<td>Chỉ từ 1000</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đặt v&eacute; ngay</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t\t</table>\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t<table border=\"0\" cellpadding=\"10\" cellspacing=\"0\" style=\"width:100%\">\r\n\t\t\t\t\t\t\t<tbody>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<th>Trung t&acirc;m hỗ trợ &amp; chăm s&oacute;c kh&aacute;ch h&agrave;ng</th>\r\n\t\t\t\t\t\t\t\t\t<th>&nbsp;</th>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t<p>231-233 L&Ecirc; HỒNG PHONG, P4, Q5, TPHCM.</p>\r\n\r\n\t\t\t\t\t\t\t\t\t<p>TỔNG Đ&Agrave;I LI&Ecirc;N HỆ: <strong>1900 6067</strong> (PHỤC VỤ 24/7)</p>\r\n\r\n\t\t\t\t\t\t\t\t\t<p>ĐỂ BIẾT TH&Ecirc;M NHIỀU TH&Ocirc;NG TIN KHUYẾN M&Atilde;I, VUI L&Ograve;NG TRUY CẬP WEBSITE <a href=\"https://futabus.vn/\" style=\"color:#ff4229\" target=\"_blank\">FUTABUS.VN</a> HOẶC LIKE <a href=\"https://www.facebook.com/xephuongtrang\" style=\"color:#ff4229\" target=\"_blank\">FANPAGE</a> CỦA CH&Uacute;NG T&Ocirc;I</p>\r\n\r\n\t\t\t\t\t\t\t\t\t<p>(*) C&aacute;c chuyến xe trong khung giờ khuyến m&atilde;i sẽ được th&ocirc;ng b&aacute;o cụ thể tr&ecirc;n website <a href=\"https://futabus.vn/\" style=\"color:#ff4229\" target=\"_blank\">futabus.vn</a> v&agrave; ứng dụng di động FUTA Bus.</p>\r\n\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t<td><a href=\"https://www.facebook.com/xephuongtrang\" target=\"_blank\"><img src=\"https://futabus.vn/uploads/useravatar/543705534_icon_fb.png\" /> </a> <a href=\"#\"> <img src=\"https://futabus.vn/uploads/useravatar/1990245067_icon_tt.png\" /> </a></td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t\t</table>\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t</tbody>\r\n\t\t\t</table>\r\n\t\t\t</td>\r\n\t\t</tr>\r\n\t</tbody>\r\n</table>\r\n" },
                        {"Status", 1 }
                    },
                };
                var robj = s.P(obj);
                if (robj.Result.Equals(1))
                {
                    id = Convert.ToInt32(robj.Records[0][0]);
                }
            }
            catch (Exception)
            {

            }
            Assert.AreEqual(true, id > 0);
        }

        [TestMethod]
        public void TestInsertMethod4()
        {
            var id = 0;
            try
            {
                var s = new S(Cs);
                var obj = new GCRequest()
                {
                    _a = "Inserttbl_PT_MailBox",
                    _d = new Dictionary<string, object>()
                    {
                        {"To", "namto87@yahoo.com.vn" },
                        {"CC", null },
                        {"BCC", null },
                        {"Subject", "Test subject" },
                        {"Body","<table align=\"center\" border=\"0\" cellpadding=\"10\" cellspacing=\"0\" style=\"font-family:arial; width:100%\">\r\n\t<tbody>\r\n\t\t<tr>\r\n\t\t\t<td>\r\n\t\t\t<table align=\"center\" border=\"0\" cellpadding=\"10\" cellspacing=\"0\" style=\"height:611px; width:650px\">\r\n\t\t\t\t<tbody>\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t<div style=\"position:relative;\"><img src=\"https://futabus.vn/uploads/useravatar/1944722557_giovang_landingpage-SUA-option-2_03.png\" style=\"height:281px; width:650px\" /> <a href=\"https://play.google.com/store/apps/details?id=com.futabus.activity\" style=\"position:absolute; right:65px;bottom:2px;\"> <img src=\"https://futabus.vn/uploads/useravatar/275969533_icon_google.png\" /> </a> <a href=\"https://itunes.apple.com/us/app/futa/id1049039667\" style=\"position:absolute; bottom:2px; right: 129px;\"> <img src=\"https://futabus.vn/uploads/useravatar/1884038435_icon_apple.png\" /> </a></div>\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t<table border=\"0\" cellpadding=\"10\" cellspacing=\"0\">\r\n\t\t\t\t\t\t\t<tbody>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t<p>C&aacute;c tuyến giờ trong khung giờ khuyến m&atilde;i<sup> (*)</sup></p>\r\n\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t<p>___________</p>\r\n\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t<p>H&atilde;y t&igrave;m biểu tượng <img src=\"https://futabus.vn/uploads/useravatar/976887127_icon_giovang.png\" /> để mua v&eacute; với gi&aacute; ưu đ&atilde;i</p>\r\n\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t\t</table>\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t<table border=\"0\" cellpadding=\"10\" cellspacing=\"0\" style=\"height:196px; width:100%\">\r\n\t\t\t\t\t\t\t<tbody>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<th>Bến đi</th>\r\n\t\t\t\t\t\t\t\t\t<th>Bến đến</th>\r\n\t\t\t\t\t\t\t\t\t<th>Loại xe</th>\r\n\t\t\t\t\t\t\t\t\t<th>Gi&aacute; v&eacute;</th>\r\n\t\t\t\t\t\t\t\t\t<th>&nbsp;</th>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<td>S&agrave;i G&ograve;n</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đ&agrave; Lạt</td>\r\n\t\t\t\t\t\t\t\t\t<td>Giường</td>\r\n\t\t\t\t\t\t\t\t\t<td>Chỉ từ 1000</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đặt v&eacute; ngay</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<td>S&agrave;i G&ograve;n</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đ&agrave; Lạt</td>\r\n\t\t\t\t\t\t\t\t\t<td>Giường</td>\r\n\t\t\t\t\t\t\t\t\t<td>Chỉ từ 1000</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đặt v&eacute; ngay</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<td>S&agrave;i G&ograve;n</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đ&agrave; Lạt</td>\r\n\t\t\t\t\t\t\t\t\t<td>Giường</td>\r\n\t\t\t\t\t\t\t\t\t<td>Chỉ từ 1000</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đặt v&eacute; ngay</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<td>S&agrave;i G&ograve;n</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đ&agrave; Lạt</td>\r\n\t\t\t\t\t\t\t\t\t<td>Giường</td>\r\n\t\t\t\t\t\t\t\t\t<td>Chỉ từ 1000</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đặt v&eacute; ngay</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<td>S&agrave;i G&ograve;n</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đ&agrave; Lạt</td>\r\n\t\t\t\t\t\t\t\t\t<td>Giường</td>\r\n\t\t\t\t\t\t\t\t\t<td>Chỉ từ 1000</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đặt v&eacute; ngay</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t\t</table>\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t<table border=\"0\" cellpadding=\"10\" cellspacing=\"0\" style=\"width:100%\">\r\n\t\t\t\t\t\t\t<tbody>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<th>Trung t&acirc;m hỗ trợ &amp; chăm s&oacute;c kh&aacute;ch h&agrave;ng</th>\r\n\t\t\t\t\t\t\t\t\t<th>&nbsp;</th>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t<p>231-233 L&Ecirc; HỒNG PHONG, P4, Q5, TPHCM.</p>\r\n\r\n\t\t\t\t\t\t\t\t\t<p>TỔNG Đ&Agrave;I LI&Ecirc;N HỆ: <strong>1900 6067</strong> (PHỤC VỤ 24/7)</p>\r\n\r\n\t\t\t\t\t\t\t\t\t<p>ĐỂ BIẾT TH&Ecirc;M NHIỀU TH&Ocirc;NG TIN KHUYẾN M&Atilde;I, VUI L&Ograve;NG TRUY CẬP WEBSITE <a href=\"https://futabus.vn/\" style=\"color:#ff4229\" target=\"_blank\">FUTABUS.VN</a> HOẶC LIKE <a href=\"https://www.facebook.com/xephuongtrang\" style=\"color:#ff4229\" target=\"_blank\">FANPAGE</a> CỦA CH&Uacute;NG T&Ocirc;I</p>\r\n\r\n\t\t\t\t\t\t\t\t\t<p>(*) C&aacute;c chuyến xe trong khung giờ khuyến m&atilde;i sẽ được th&ocirc;ng b&aacute;o cụ thể tr&ecirc;n website <a href=\"https://futabus.vn/\" style=\"color:#ff4229\" target=\"_blank\">futabus.vn</a> v&agrave; ứng dụng di động FUTA Bus.</p>\r\n\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t<td><a href=\"https://www.facebook.com/xephuongtrang\" target=\"_blank\"><img src=\"https://futabus.vn/uploads/useravatar/543705534_icon_fb.png\" /> </a> <a href=\"#\"> <img src=\"https://futabus.vn/uploads/useravatar/1990245067_icon_tt.png\" /> </a></td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t\t</table>\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t</tbody>\r\n\t\t\t</table>\r\n\t\t\t</td>\r\n\t\t</tr>\r\n\t</tbody>\r\n</table>\r\n" },
                        {"Status", 0 }
                    },
                };
                var robj = s.P(obj);
                if (robj.Result.Equals(1))
                {
                    id = Convert.ToInt32(robj.Records[0][0]);
                }
            }
            catch (Exception)
            {

            }
            Assert.AreEqual(true, id > 0);
        }

        [TestMethod]
        public void TestInsertMethod5()
        {
            var id = 0;
            try {
                var target = string.Format("{0}-{1:yyyyMMddHHmmssffff}", "0902363330", DateTime.Now);
                var s = new S(Cs4);
                var obj = new GCRequest()
                {
                    _a = "Inserttbl_SMS",
                    _d = new Dictionary<string, object>()
                {
                    {"Code", target  },
                    {"PhoneNumber", "0902363330" },
                    {"Message", "This is test" }
                },
                };
                var robj = s.P(obj);
                if (robj.Result.Equals(1))
                {
                    id = Convert.ToInt32(robj.Records[0][0]);
                }
            }
            catch (Exception)
            {

            }
            Assert.AreEqual(true, id > 0);
        }

        [TestMethod]
        public void TestInsertMethod6()
        {
            var id = 0;
            var target = "";
            try
            {
                //var target = string.Format("{0}-{1:yyyyMMddHHmmssffff}", "0902363330", DateTime.Now);
                var s = new S(Cs5);
                var obj = new GCRequest()
                {
                    _a = "Inserttbl_SMS",
                    _d = new Dictionary<string, object>()
                {
                    {"Code", target  },
                    {"PhoneNumber", "0902363330" },
                    {"Message", "This is test" }
                },
                };
                var robj = s.P(obj);
                if (robj.Result.Equals(1))
                {
                    id = Convert.ToInt32(robj.Records[0][0]);
                }
            }
            catch (Exception)
            {

            }
            Assert.AreEqual(true, id > 0);
        }


        [TestMethod]
        public void TestUpdateMethod()
        {
            var affected = 0;
            try
            {
                var s = new S(Cs);
                var obj = new GCRequest()
                {
                    _a = "Updatetbl_PT_MailBox",
                    _c = new Dictionary<string, object>()
                    {
                        {"Id", 3 }
                    },
                    _d = new Dictionary<string, object>()
                    {
                        {"Subject", "This is test email subject" },
                    },
                };
                var robj = s.P(obj);
                if (robj.Result.Equals(1))
                {
                    affected = Convert.ToInt32(robj.Records[0][0]);
                }
            }
            catch (Exception)
            {

            }
            Assert.AreEqual(1, affected);
        }

        [TestMethod]
        public void TestSPMethod()
        {
            var setId = 0;
            try
            {
                var s = new S(Cs);
                var obj = new GCRequest()
                {
                    _a = "sslyt_SetNextAccount",
                    _c = new Dictionary<string, object>()
                    {
                        {"CurrentId", 3 }
                    },
                };
                var robj = s.P(obj);
                if (robj.Result.Equals(1))
                {
                    setId = Convert.ToInt32(robj.Records[0][0]);
                }
            }
            catch (Exception)
            {

            }
            Assert.AreEqual(4, setId);
        }
        [TestMethod]
        public void TestSPMethod2()
        {
            var setId = 0;
            try
            {
                var s = new S(Cs6);
                var obj = new GCRequest()
                {
                    _a = "sslyt_GetReportAsTable",
                    _c = new Dictionary<string, object>()
                    {
                        {"Period", 14 }
                    },
                };
                var robj = s.P(obj);
                if (robj.Result.Equals(1))
                {
                    setId = robj.TotalRecordCount;
                }
            }
            catch (Exception)
            {

            }
            Assert.AreEqual(14, setId);
        }
    }
}
