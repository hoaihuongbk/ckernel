using System;
using System.Configuration;
using cModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace cService.Test
{
    [TestClass]
    public class ServiceTest
    {
        private const string Cs = "server=112.213.84.183;database=FutaMarketing;uid=futadev;pwd=CNLuwcRhLT;";
        //private const string Cs = "server=118.69.196.250;database=FutaMarketing;uid=ftmarketing;pwd=dcSGNgIep0OAvXK8tFGO;";


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
        public void TestInsertMethod()
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
                        {"To", "hoaihuongvuonghuynh@gmail.com" },
                        {"Subject", "Test subject" },
                        {"Body","<!DOCTYPE html><meta name=viewport content=\"width=device-width\"><meta http-equiv=Content-Type content=\"text/html; charset = UTF - 8\"><title>Really Simple HTML Email Template</title><style>*{font-family:\"Helvetica Neue\",Helvetica,Helvetica,Arial,sans-serif;font-size:100%;line-height:1.6em;margin:0;padding:0}img{max-width:600px;width:auto}body{-webkit-font-smoothing:antialiased;height:100%;-webkit-text-size-adjust:none;width:100%!important}a{color:#348eda}.btn-primary{Margin-bottom:10px;width:auto!important}.btn-primary td{background-color:#348eda;border-radius:25px;font-family:\"Helvetica Neue\",Helvetica,Arial,\"Lucida Grande\",sans-serif;font-size:14px;text-align:center;vertical-align:top}.btn-primary td a{background-color:#348eda;border:solid 1px #348eda;border-radius:25px;border-width:10px 20px;display:inline-block;color:#fff;cursor:pointer;font-weight:700;line-height:2;text-decoration:none}.last{margin-bottom:0}.first{margin-top:0}.padding{padding:10px 0}table.body-wrap{padding:20px;width:100%}table.body-wrap .container{border:1px solid #f0f0f0}table.footer-wrap{clear:both!important;width:100%}.footer-wrap .container p{color:#666;font-size:12px}table.footer-wrap a{color:#999}h1,h2,h3{color:#111;font-family:\"Helvetica Neue\",Helvetica,Arial,\"Lucida Grande\",sans-serif;font-weight:200;line-height:1.2em;margin:40px 0 10px}h1{font-size:36px}h2{font-size:28px}h3{font-size:22px}ol,p,ul{font-size:14px;font-weight:400;margin-bottom:10px}ol li,ul li{margin-left:5px;list-style-position:inside}.container{clear:both!important;display:block!important;Margin:0 auto!important;max-width:600px!important}.body-wrap .container{padding:20px}.content{display:block;margin:0 auto;max-width:600px}.content table{width:100%}</style><body bgcolor=#f6f6f6><table class=body-wrap bgcolor=#f6f6f6><tr><td><td class=container bgcolor=#FFFFFF><div class=content><table><tr><td><p>Hi there,<p>Sometimes all you want is to send a simple HTML email with a basic design.<h1>Really simple HTML email template</h1><p>This is a really simple email template. Its sole purpose is to get you to click the button below.<h2>How do I use it?</h2><p>All the information you need is on GitHub.<table class=btn-primary cellpadding=0 cellspacing=0 border=0><tr><td><a href=https://github.com/leemunroe/html-email-template>View the source and instructions on GitHub</a></table><p>Feel free to use, copy, modify this email template as you wish.<p>Thanks, have a lovely day.<p><a href=http://twitter.com/leemunroe>Follow @leemunroe on Twitter</a></table></div><td></table><table class=footer-wrap><tr><td><td class=container><div class=content><table><tr><td align=center><p>Don't like these annoying emails? <a href=#><unsubscribe>Unsubscribe</unsubscribe></a>.</table></div><td></table>" }
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
                        {"Body","<table align=\"center\" border=\"0\" cellpadding=\"10\" cellspacing=\"0\" style=\"font-family:arial; width:100%\">\r\n\t<tbody>\r\n\t\t<tr>\r\n\t\t\t<td>\r\n\t\t\t<table align=\"center\" border=\"0\" cellpadding=\"10\" cellspacing=\"0\" style=\"height:611px; width:650px\">\r\n\t\t\t\t<tbody>\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t<div style=\"position:relative;\"><img src=\"https://futabus.vn/uploads/useravatar/1944722557_giovang_landingpage-SUA-option-2_03.png\" style=\"height:281px; width:650px\" /> <a href=\"https://play.google.com/store/apps/details?id=com.futabus.activity\" style=\"position:absolute; right:65px;bottom:2px;\"> <img src=\"https://futabus.vn/uploads/useravatar/275969533_icon_google.png\" /> </a> <a href=\"https://itunes.apple.com/us/app/futa/id1049039667\" style=\"position:absolute; bottom:2px; right: 129px;\"> <img src=\"https://futabus.vn/uploads/useravatar/1884038435_icon_apple.png\" /> </a></div>\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t<table border=\"0\" cellpadding=\"10\" cellspacing=\"0\">\r\n\t\t\t\t\t\t\t<tbody>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t<p>C&aacute;c tuyến giờ trong khung giờ khuyến m&atilde;i<sup> (*)</sup></p>\r\n\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t<p>___________</p>\r\n\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t<p>H&atilde;y t&igrave;m biểu tượng <img src=\"https://futabus.vn/uploads/useravatar/976887127_icon_giovang.png\" /> để mua v&eacute; với gi&aacute; ưu đ&atilde;i</p>\r\n\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t\t</table>\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t<table border=\"0\" cellpadding=\"10\" cellspacing=\"0\" style=\"height:196px; width:100%\">\r\n\t\t\t\t\t\t\t<tbody>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<th>Bến đi</th>\r\n\t\t\t\t\t\t\t\t\t<th>Bến đến</th>\r\n\t\t\t\t\t\t\t\t\t<th>Loại xe</th>\r\n\t\t\t\t\t\t\t\t\t<th>Gi&aacute; v&eacute;</th>\r\n\t\t\t\t\t\t\t\t\t<th>&nbsp;</th>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<td>S&agrave;i G&ograve;n</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đ&agrave; Lạt</td>\r\n\t\t\t\t\t\t\t\t\t<td>Giường</td>\r\n\t\t\t\t\t\t\t\t\t<td>Chỉ từ 1000</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đặt v&eacute; ngay</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<td>S&agrave;i G&ograve;n</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đ&agrave; Lạt</td>\r\n\t\t\t\t\t\t\t\t\t<td>Giường</td>\r\n\t\t\t\t\t\t\t\t\t<td>Chỉ từ 1000</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đặt v&eacute; ngay</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<td>S&agrave;i G&ograve;n</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đ&agrave; Lạt</td>\r\n\t\t\t\t\t\t\t\t\t<td>Giường</td>\r\n\t\t\t\t\t\t\t\t\t<td>Chỉ từ 1000</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đặt v&eacute; ngay</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<td>S&agrave;i G&ograve;n</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đ&agrave; Lạt</td>\r\n\t\t\t\t\t\t\t\t\t<td>Giường</td>\r\n\t\t\t\t\t\t\t\t\t<td>Chỉ từ 1000</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đặt v&eacute; ngay</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<td>S&agrave;i G&ograve;n</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đ&agrave; Lạt</td>\r\n\t\t\t\t\t\t\t\t\t<td>Giường</td>\r\n\t\t\t\t\t\t\t\t\t<td>Chỉ từ 1000</td>\r\n\t\t\t\t\t\t\t\t\t<td>Đặt v&eacute; ngay</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t\t</table>\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t<table border=\"0\" cellpadding=\"10\" cellspacing=\"0\" style=\"width:100%\">\r\n\t\t\t\t\t\t\t<tbody>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<th>Trung t&acirc;m hỗ trợ &amp; chăm s&oacute;c kh&aacute;ch h&agrave;ng</th>\r\n\t\t\t\t\t\t\t\t\t<th>&nbsp;</th>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t<p>231-233 L&Ecirc; HỒNG PHONG, P4, Q5, TPHCM.</p>\r\n\r\n\t\t\t\t\t\t\t\t\t<p>TỔNG Đ&Agrave;I LI&Ecirc;N HỆ: <strong>1900 6067</strong> (PHỤC VỤ 24/7)</p>\r\n\r\n\t\t\t\t\t\t\t\t\t<p>ĐỂ BIẾT TH&Ecirc;M NHIỀU TH&Ocirc;NG TIN KHUYẾN M&Atilde;I, VUI L&Ograve;NG TRUY CẬP WEBSITE <a href=\"https://futabus.vn/\" style=\"color:#ff4229\" target=\"_blank\">FUTABUS.VN</a> HOẶC LIKE <a href=\"https://www.facebook.com/xephuongtrang\" style=\"color:#ff4229\" target=\"_blank\">FANPAGE</a> CỦA CH&Uacute;NG T&Ocirc;I</p>\r\n\r\n\t\t\t\t\t\t\t\t\t<p>(*) C&aacute;c chuyến xe trong khung giờ khuyến m&atilde;i sẽ được th&ocirc;ng b&aacute;o cụ thể tr&ecirc;n website <a href=\"https://futabus.vn/\" style=\"color:#ff4229\" target=\"_blank\">futabus.vn</a> v&agrave; ứng dụng di động FUTA Bus.</p>\r\n\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t<td><a href=\"https://www.facebook.com/xephuongtrang\" target=\"_blank\"><img src=\"https://futabus.vn/uploads/useravatar/543705534_icon_fb.png\" /> </a> <a href=\"#\"> <img src=\"https://futabus.vn/uploads/useravatar/1990245067_icon_tt.png\" /> </a></td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t\t</table>\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t</tbody>\r\n\t\t\t</table>\r\n\t\t\t</td>\r\n\t\t</tr>\r\n\t</tbody>\r\n</table>\r\n" }
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
    }
}
