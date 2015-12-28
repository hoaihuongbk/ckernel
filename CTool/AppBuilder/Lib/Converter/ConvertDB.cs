using System.Runtime.InteropServices;

namespace Toyota.Financial.Core.Converter
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class ConvertFont
    {
        private const int nCode = 8;
        private const int iNCR = 0;
        private const int iUTF = 1;
        private const int iTCV = 2;
        private const int iVNI = 3;
        private const int iUNI = 6;
        private const int iUTH = 5;
        private const int iCP1258 = 4;
        private const int iVIQ = 8;
        private const int iNOSIGN = 7;
        private string[,] Code;
        private FontCase m_CharCase = FontCase.Normal;

        public ConvertFont()
        {
            InitData();
        }

        public FontCase CharCase
        {
            get { return m_CharCase; }
            set { m_CharCase = value; }
        }

        private void InitData()
        {
            Code = new string[135, 8];
            Code[0, 0] = 0.ToString();
            Code[0, 1] = 1.ToString();
            Code[0, 2] = 2.ToString();
            Code[0, 3] = 3.ToString();
            Code[0, 5] = 5.ToString();
            Code[0, 6] = 6.ToString();
            Code[0, 4] = 4.ToString();
            Code[0, 7] = 7.ToString();
            MapUnicode();
            MapVNI();
            MapTCV();
            MapUTH();
            MapUTF8();
            MapNCR();
            MapNoSign();
            MapCP1258();
        }

        private int GetnChar(FontIndex index)
        {
            if (index == FontIndex.iUTF)
                return 3;
            if (index == FontIndex.iUNI || index == FontIndex.iUTH || index == FontIndex.iNOSIGN)
                return 1;
            return index == FontIndex.iNCR ? 7 : 2;
        }

        private int getIntCode(string code)
        {
            for (int index = 0; index < 8; ++index)
            {
                if (Code[0, index] == code)
                    return index;
            }
            return -1;
        }

        private bool isSpecialChar(string s)
        {
            return isSpecialChar(s, false);
        }

        private bool isSpecialChar(string s, bool isUNI)
        {
            if (s.Length > 2)
                return false;
            var strArray1 = new string[37]
            {
                "í",
                "ì",
                "ó",
                "ò",
                "ô",
                "ñ",
                "î",
                "Ê",
                "È",
                "É",
                "á",
                "à",
                "â",
                "è",
                "é",
                "ê",
                "ù",
                "ý",
                "ú",
                "ö",
                "Í",
                "Ì",
                "Ó",
                "Ò",
                "Ô",
                "Ñ",
                "Î",
                "Õ",
                "Ý",
                "Ã",
                "oà",
                "oá",
                "oã",
                "uû",
                "OÁ",
                "OÀ",
                "OÃ"
            };
            var strArray2 = new string[44]
            {
                "ă",
                "â",
                "ê",
                "ô",
                "ơ",
                "ư",
                "đ",
                "í",
                "ì",
                "ó",
                "ò",
                "ô",
                "ñ",
                "î",
                "Ê",
                "È",
                "É",
                "á",
                "à",
                "â",
                "è",
                "é",
                "ê",
                "ù",
                "ý",
                "ú",
                "ö",
                "Í",
                "Ì",
                "Ó",
                "Ò",
                "Ô",
                "Ñ",
                "Î",
                "Õ",
                "Ý",
                "Ã",
                "oà",
                "oá",
                "oã",
                "uû",
                "OÁ",
                "OÀ",
                "OÃ"
            };
            foreach (string strB in isUNI ? strArray2 : strArray1)
            {
                if (string.Compare(s, strB, true) == 0)
                    return true;
            }
            return false;
        }

        public FontIndex getCode(string str)
        {
            if (str.Trim() == "")
                return FontIndex.iNotKnown;
            int index1 = -1;
            str = str + "       ";
            int startIndex = 0;
            while (startIndex < str.Length - 7)
            {
                if (str.Substring(startIndex, 1) == " ")
                {
                    ++startIndex;
                }
                else
                {
                    for (int length = 7; length > 0; --length)
                    {
                        string s = str.Substring(startIndex, length);
                        for (int index2 = 0;
                            index2 < 7 && (length != 4 && length != 5 && (length < 6 || index2 == 0));
                            ++index2)
                        {
                            if ((length != 3 || index2 == 1) &&
                                (index2 != 3 && index2 != 2 && (index2 != 5 && index2 != 4) || length <= 2))
                            {
                                for (int index3 = 1; index3 < 135; ++index3)
                                {
                                    if (s == Code[index3, index2])
                                    {
                                        if (!isSpecialChar(s, index2 == 5 || index2 == 6))
                                            return (FontIndex) int.Parse(Code[0, index2]);
                                        index1 = index2;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    ++startIndex;
                }
            }
            return index1 >= 0 ? (FontIndex) int.Parse(Code[0, index1]) : FontIndex.iNotKnown;
        }

        public bool Convert(ref string strConv, FontIndex iSource, FontIndex iDestination)
        {
            var index1 = (int) iSource;
            var index2 = (int) iDestination;
            if (strConv.Trim() == "" || index1 == index2)
                return false;
            string str1 = "";
            string str2 = "";
            if (index1 == -1)
            {
                var num = (int) getCode(strConv);
                if (num <= -1)
                    return false;
                index1 = num;
            }
            if (index2 == -1)
                index2 = 0;
            int num1 = GetnChar((FontIndex) int.Parse(Code[0, index1]));
            int num2 = num1 > 1 ? num1 - 1 : 1;
            string str3 = "";
            bool flag = false;
            string local = strConv;
            string str4 = local + "       ";
            strConv = str4;
            int startIndex = 0;
            while (startIndex < strConv.Length - 7)
            {
                for (int length = num1; length >= num2; --length)
                {
                    str2 = "";
                    if (strConv.Substring(startIndex, 1) == " ")
                    {
                        str1 = " ";
                        break;
                    }
                    str1 = strConv.Substring(startIndex, length);
                    for (int index3 = 1; index3 < 135; ++index3)
                    {
                        if (str1 == Code[index3, index1])
                        {
                            str2 = m_CharCase != FontCase.UpperCase || index3 >= 68
                                ? (m_CharCase != FontCase.LowerCase || index3 < 68
                                    ? Code[index3, index2]
                                    : Code[index3 - 67, index2])
                                : Code[index3 + 67, index2];
                            startIndex += length;
                            break;
                        }
                    }
                    if (str2 != "" || length == 5)
                        break;
                }
                if (str2 != "")
                {
                    str3 = str3 + str2;
                    flag = true;
                }
                else
                {
                    str3 = m_CharCase != FontCase.UpperCase
                        ? (m_CharCase != FontCase.LowerCase
                            ? str3 + str1.Substring(0, 1)
                            : str3 + str1.Substring(0, 1).ToLower())
                        : str3 + str1.Substring(0, 1).ToUpper();
                    ++startIndex;
                }
            }
            if (!flag)
            {
                strConv = strConv.Remove(strConv.Length - 7, 7);
                if (m_CharCase == FontCase.UpperCase)
                    {
                        strConv = strConv.ToUpper();
                        return true;
                    }
                    if (m_CharCase != FontCase.LowerCase)
                        return false;
                    strConv = strConv.ToLower();
                    return true;
            }
            strConv = str3.TrimEnd(new char[0]);
            return true;
        }

        public bool isVietnamese(string s, ref FontIndex code)
        {
            code = getCode(s);
            return code > FontIndex.iNotKnown;
        }

        public bool isVietnamese(string s)
        {
            return getCode(s) != FontIndex.iNotKnown;
        }

        private void MapUnicode()
        {
            Code[1, 6] = "á";
            Code[2, 6] = "à";
            Code[3, 6] = "ả";
            Code[4, 6] = "ã";
            Code[5, 6] = "ạ";
            Code[6, 6] = "ă";
            Code[7, 6] = "ắ";
            Code[8, 6] = "ằ";
            Code[9, 6] = "ẳ";
            Code[10, 6] = "ẵ";
            Code[11, 6] = "ặ";
            Code[12, 6] = "â";
            Code[13, 6] = "ấ";
            Code[14, 6] = "ầ";
            Code[15, 6] = "ẩ";
            Code[16, 6] = "ẫ";
            Code[17, 6] = "ậ";
            Code[18, 6] = "é";
            Code[19, 6] = "è";
            Code[20, 6] = "ẻ";
            Code[21, 6] = "ẽ";
            Code[22, 6] = "ẹ";
            Code[23, 6] = "ê";
            Code[24, 6] = "ế";
            Code[25, 6] = "ề";
            Code[26, 6] = "ể";
            Code[27, 6] = "ễ";
            Code[28, 6] = "ệ";
            Code[29, 6] = "í";
            Code[30, 6] = "ì";
            Code[31, 6] = "ỉ";
            Code[32, 6] = "ĩ";
            Code[33, 6] = "ị";
            Code[34, 6] = "ó";
            Code[35, 6] = "ò";
            Code[36, 6] = "ỏ";
            Code[37, 6] = "õ";
            Code[38, 6] = "ọ";
            Code[39, 6] = "ô";
            Code[40, 6] = "ố";
            Code[41, 6] = "ồ";
            Code[42, 6] = "ổ";
            Code[43, 6] = "ỗ";
            Code[44, 6] = "ộ";
            Code[45, 6] = "ơ";
            Code[46, 6] = "ớ";
            Code[47, 6] = "ờ";
            Code[48, 6] = "ở";
            Code[49, 6] = "ỡ";
            Code[50, 6] = "ợ";
            Code[51, 6] = "ú";
            Code[52, 6] = "ù";
            Code[53, 6] = "ủ";
            Code[54, 6] = "ũ";
            Code[55, 6] = "ụ";
            Code[56, 6] = "ư";
            Code[57, 6] = "ứ";
            Code[58, 6] = "ừ";
            Code[59, 6] = "ử";
            Code[60, 6] = "ữ";
            Code[61, 6] = "ự";
            Code[62, 6] = "ý";
            Code[63, 6] = "ỳ";
            Code[64, 6] = "ỷ";
            Code[65, 6] = "ỹ";
            Code[66, 6] = "ỵ";
            Code[67, 6] = "đ";
            Code[68, 6] = "Á";
            Code[69, 6] = "À";
            Code[70, 6] = "Ả";
            Code[71, 6] = "Ã";
            Code[72, 6] = "Ạ";
            Code[73, 6] = "Ă";
            Code[74, 6] = "Ắ";
            Code[75, 6] = "Ằ";
            Code[76, 6] = "Ẳ";
            Code[77, 6] = "Ẵ";
            Code[78, 6] = "Ặ";
            Code[79, 6] = "Â";
            Code[80, 6] = "Ấ";
            Code[81, 6] = "Ầ";
            Code[82, 6] = "Ẩ";
            Code[83, 6] = "Ẫ";
            Code[84, 6] = "Ậ";
            Code[85, 6] = "É";
            Code[86, 6] = "È";
            Code[87, 6] = "Ẻ";
            Code[88, 6] = "Ẽ";
            Code[89, 6] = "Ẹ";
            Code[90, 6] = "Ê";
            Code[91, 6] = "Ế";
            Code[92, 6] = "Ề";
            Code[93, 6] = "Ể";
            Code[94, 6] = "Ễ";
            Code[95, 6] = "Ệ";
            Code[96, 6] = "Í";
            Code[97, 6] = "Ì";
            Code[98, 6] = "Ỉ";
            Code[99, 6] = "Ĩ";
            Code[100, 6] = "Ị";
            Code[101, 6] = "Ó";
            Code[102, 6] = "Ò";
            Code[103, 6] = "Ỏ";
            Code[104, 6] = "Õ";
            Code[105, 6] = "Ọ";
            Code[106, 6] = "Ô";
            Code[107, 6] = "Ố";
            Code[108, 6] = "Ồ";
            Code[109, 6] = "Ổ";
            Code[110, 6] = "Ỗ";
            Code[111, 6] = "Ộ";
            Code[112, 6] = "Ơ";
            Code[113, 6] = "Ớ";
            Code[114, 6] = "Ờ";
            Code[115, 6] = "Ở";
            Code[116, 6] = "Ỡ";
            Code[117, 6] = "Ợ";
            Code[118, 6] = "Ú";
            Code[119, 6] = "Ù";
            Code[120, 6] = "Ủ";
            Code[121, 6] = "Ũ";
            Code[122, 6] = "Ụ";
            Code[123, 6] = "Ư";
            Code[124, 6] = "Ứ";
            Code[125, 6] = "Ừ";
            Code[126, 6] = "Ử";
            Code[sbyte.MaxValue, 6] = "Ữ";
            Code[128, 6] = "Ự";
            Code[129, 6] = "Ý";
            Code[130, 6] = "Ỳ";
            Code[131, 6] = "Ỷ";
            Code[132, 6] = "Ỹ";
            Code[133, 6] = "Ỵ";
            Code[134, 6] = "Đ";
        }

        private void MapNoSign()
        {
            Code[1, 7] = "a";
            Code[2, 7] = "a";
            Code[3, 7] = "a";
            Code[4, 7] = "a";
            Code[5, 7] = "a";
            Code[6, 7] = "a";
            Code[7, 7] = "a";
            Code[8, 7] = "a";
            Code[9, 7] = "a";
            Code[10, 7] = "a";
            Code[11, 7] = "a";
            Code[12, 7] = "a";
            Code[13, 7] = "a";
            Code[14, 7] = "a";
            Code[15, 7] = "a";
            Code[16, 7] = "a";
            Code[17, 7] = "a";
            Code[18, 7] = "e";
            Code[19, 7] = "e";
            Code[20, 7] = "e";
            Code[21, 7] = "e";
            Code[22, 7] = "e";
            Code[23, 7] = "e";
            Code[24, 7] = "e";
            Code[25, 7] = "e";
            Code[26, 7] = "e";
            Code[27, 7] = "e";
            Code[28, 7] = "e";
            Code[29, 7] = "i";
            Code[30, 7] = "i";
            Code[31, 7] = "i";
            Code[32, 7] = "i";
            Code[33, 7] = "i";
            Code[34, 7] = "o";
            Code[35, 7] = "o";
            Code[36, 7] = "o";
            Code[37, 7] = "o";
            Code[38, 7] = "o";
            Code[39, 7] = "o";
            Code[40, 7] = "o";
            Code[41, 7] = "o";
            Code[42, 7] = "o";
            Code[43, 7] = "o";
            Code[44, 7] = "o";
            Code[45, 7] = "o";
            Code[46, 7] = "o";
            Code[47, 7] = "o";
            Code[48, 7] = "o";
            Code[49, 7] = "o";
            Code[50, 7] = "o";
            Code[51, 7] = "u";
            Code[52, 7] = "u";
            Code[53, 7] = "u";
            Code[54, 7] = "u";
            Code[55, 7] = "u";
            Code[56, 7] = "u";
            Code[57, 7] = "u";
            Code[58, 7] = "u";
            Code[59, 7] = "u";
            Code[60, 7] = "u";
            Code[61, 7] = "u";
            Code[62, 7] = "y";
            Code[63, 7] = "y";
            Code[64, 7] = "y";
            Code[65, 7] = "y";
            Code[66, 7] = "y";
            Code[67, 7] = "d";
            Code[68, 7] = "A";
            Code[69, 7] = "A";
            Code[70, 7] = "A";
            Code[71, 7] = "A";
            Code[72, 7] = "A";
            Code[73, 7] = "A";
            Code[74, 7] = "A";
            Code[75, 7] = "A";
            Code[76, 7] = "A";
            Code[77, 7] = "A";
            Code[78, 7] = "A";
            Code[79, 7] = "A";
            Code[80, 7] = "A";
            Code[81, 7] = "A";
            Code[82, 7] = "A";
            Code[83, 7] = "A";
            Code[84, 7] = "A";
            Code[85, 7] = "E";
            Code[86, 7] = "E";
            Code[87, 7] = "E";
            Code[88, 7] = "E";
            Code[89, 7] = "E";
            Code[90, 7] = "E";
            Code[91, 7] = "E";
            Code[92, 7] = "E";
            Code[93, 7] = "E";
            Code[94, 7] = "E";
            Code[95, 7] = "E";
            Code[96, 7] = "I";
            Code[97, 7] = "I";
            Code[98, 7] = "I";
            Code[99, 7] = "I";
            Code[100, 7] = "I";
            Code[101, 7] = "O";
            Code[102, 7] = "O";
            Code[103, 7] = "O";
            Code[104, 7] = "O";
            Code[105, 7] = "O";
            Code[106, 7] = "O";
            Code[107, 7] = "O";
            Code[108, 7] = "O";
            Code[109, 7] = "O";
            Code[110, 7] = "O";
            Code[111, 7] = "O";
            Code[112, 7] = "O";
            Code[113, 7] = "O";
            Code[114, 7] = "O";
            Code[115, 7] = "O";
            Code[116, 7] = "O";
            Code[117, 7] = "O";
            Code[118, 7] = "U";
            Code[119, 7] = "U";
            Code[120, 7] = "U";
            Code[121, 7] = "U";
            Code[122, 7] = "U";
            Code[123, 7] = "U";
            Code[124, 7] = "U";
            Code[125, 7] = "U";
            Code[126, 7] = "U";
            Code[sbyte.MaxValue, 7] = "U";
            Code[128, 7] = "U";
            Code[129, 7] = "Y";
            Code[130, 7] = "Y";
            Code[131, 7] = "Y";
            Code[132, 7] = "Y";
            Code[133, 7] = "Y";
            Code[134, 7] = "D";
        }

        private void MapVNI()
        {
            Code[1, 3] = "aù";
            Code[2, 3] = "aø";
            Code[3, 3] = "aû";
            Code[4, 3] = "aõ";
            Code[5, 3] = "aï";
            Code[6, 3] = "aê";
            Code[7, 3] = "aé";
            Code[8, 3] = "aè";
            Code[9, 3] = "aú";
            Code[10, 3] = "aü";
            Code[11, 3] = "aë";
            Code[12, 3] = "aâ";
            Code[13, 3] = "aá";
            Code[14, 3] = "aà";
            Code[15, 3] = "aå";
            Code[16, 3] = "aã";
            Code[17, 3] = "aä";
            Code[18, 3] = "eù";
            Code[19, 3] = "eø";
            Code[20, 3] = "eû";
            Code[21, 3] = "eõ";
            Code[22, 3] = "eï";
            Code[23, 3] = "eâ";
            Code[24, 3] = "eá";
            Code[25, 3] = "eà";
            Code[26, 3] = "eå";
            Code[27, 3] = "eã";
            Code[28, 3] = "eä";
            Code[29, 3] = "í";
            Code[30, 3] = "ì";
            Code[31, 3] = "æ";
            Code[32, 3] = "ó";
            Code[33, 3] = "ò";
            Code[34, 3] = "où";
            Code[35, 3] = "oø";
            Code[36, 3] = "oû";
            Code[37, 3] = "oõ";
            Code[38, 3] = "oï";
            Code[39, 3] = "oâ";
            Code[40, 3] = "oá";
            Code[41, 3] = "oà";
            Code[42, 3] = "oå";
            Code[43, 3] = "oã";
            Code[44, 3] = "oä";
            Code[45, 3] = "ô";
            Code[46, 3] = "ôù";
            Code[47, 3] = "ôø";
            Code[48, 3] = "ôû";
            Code[49, 3] = "ôõ";
            Code[50, 3] = "ôï";
            Code[51, 3] = "uù";
            Code[52, 3] = "uø";
            Code[53, 3] = "uû";
            Code[54, 3] = "uõ";
            Code[55, 3] = "uï";
            Code[56, 3] = "ö";
            Code[57, 3] = "öù";
            Code[58, 3] = "öø";
            Code[59, 3] = "öû";
            Code[60, 3] = "öõ";
            Code[61, 3] = "öï";
            Code[62, 3] = "yù";
            Code[63, 3] = "yø";
            Code[64, 3] = "yû";
            Code[65, 3] = "yõ";
            Code[66, 3] = "î";
            Code[67, 3] = "ñ";
            Code[68, 3] = "AÙ";
            Code[69, 3] = "AØ";
            Code[70, 3] = "AÛ";
            Code[71, 3] = "AÕ";
            Code[72, 3] = "AÏ";
            Code[73, 3] = "AÊ";
            Code[74, 3] = "AÉ";
            Code[75, 3] = "AÈ";
            Code[76, 3] = "AÚ";
            Code[77, 3] = "AÜ";
            Code[78, 3] = "AË";
            Code[79, 3] = "AÂ";
            Code[80, 3] = "AÁ";
            Code[81, 3] = "AÀ";
            Code[82, 3] = "AÅ";
            Code[83, 3] = "AÃ";
            Code[84, 3] = "AÄ";
            Code[85, 3] = "EÙ";
            Code[86, 3] = "EØ";
            Code[87, 3] = "EÛ";
            Code[88, 3] = "EÕ";
            Code[89, 3] = "EÏ";
            Code[90, 3] = "EÂ";
            Code[91, 3] = "EÁ";
            Code[92, 3] = "EÀ";
            Code[93, 3] = "EÅ";
            Code[94, 3] = "EÃ";
            Code[95, 3] = "EÄ";
            Code[96, 3] = "Í";
            Code[97, 3] = "Ì";
            Code[98, 3] = "Æ";
            Code[99, 3] = "Ó";
            Code[100, 3] = "Ò";
            Code[101, 3] = "OÙ";
            Code[102, 3] = "OØ";
            Code[103, 3] = "OÛ";
            Code[104, 3] = "OÕ";
            Code[105, 3] = "OÏ";
            Code[106, 3] = "OÂ";
            Code[107, 3] = "OÁ";
            Code[108, 3] = "OÀ";
            Code[109, 3] = "OÅ";
            Code[110, 3] = "OÃ";
            Code[111, 3] = "OÄ";
            Code[112, 3] = "Ô";
            Code[113, 3] = "ÔÙ";
            Code[114, 3] = "ÔØ";
            Code[115, 3] = "ÔÛ";
            Code[116, 3] = "ÔÕ";
            Code[117, 3] = "ÔÏ";
            Code[118, 3] = "UÙ";
            Code[119, 3] = "UØ";
            Code[120, 3] = "UÛ";
            Code[121, 3] = "UÕ";
            Code[122, 3] = "UÏ";
            Code[123, 3] = "Ö";
            Code[124, 3] = "ÖÙ";
            Code[125, 3] = "ÖØ";
            Code[126, 3] = "ÖÛ";
            Code[sbyte.MaxValue, 3] = "ÖÕ";
            Code[128, 3] = "ÖÏ";
            Code[129, 3] = "YÙ";
            Code[130, 3] = "YØ";
            Code[131, 3] = "YÛ";
            Code[132, 3] = "YÕ";
            Code[133, 3] = "Î";
            Code[134, 3] = "Ñ";
        }

        private void MapTCV()
        {
            Code[1, 2] = "¸";
            Code[2, 2] = "µ";
            Code[3, 2] = "¶";
            Code[4, 2] = "·";
            Code[5, 2] = "\x00B9";
            Code[6, 2] = "¨";
            Code[7, 2] = "\x00BE";
            Code[8, 2] = "»";
            Code[9, 2] = "\x00BC";
            Code[10, 2] = "\x00BD";
            Code[11, 2] = "Æ";
            Code[12, 2] = "©";
            Code[13, 2] = "Ê";
            Code[14, 2] = "Ç";
            Code[15, 2] = "È";
            Code[16, 2] = "É";
            Code[17, 2] = "Ë";
            Code[18, 2] = "Ð";
            Code[19, 2] = "Ì";
            Code[20, 2] = "Î";
            Code[21, 2] = "Ï";
            Code[22, 2] = "Ñ";
            Code[23, 2] = "ª";
            Code[24, 2] = "Õ";
            Code[25, 2] = "Ò";
            Code[26, 2] = "Ó";
            Code[27, 2] = "Ô";
            Code[28, 2] = "Ö";
            Code[29, 2] = "Ý";
            Code[30, 2] = "×";
            Code[31, 2] = "Ø";
            Code[32, 2] = "Ü";
            Code[33, 2] = "Þ";
            Code[34, 2] = "ã";
            Code[35, 2] = "ß";
            Code[36, 2] = "á";
            Code[37, 2] = "â";
            Code[38, 2] = "ä";
            Code[39, 2] = "«";
            Code[40, 2] = "è";
            Code[41, 2] = "å";
            Code[42, 2] = "æ";
            Code[43, 2] = "ç";
            Code[44, 2] = "é";
            Code[45, 2] = "¬";
            Code[46, 2] = "í";
            Code[47, 2] = "ê";
            Code[48, 2] = "ë";
            Code[49, 2] = "ì";
            Code[50, 2] = "î";
            Code[51, 2] = "ó";
            Code[52, 2] = "ï";
            Code[53, 2] = "ñ";
            Code[54, 2] = "ò";
            Code[55, 2] = "ô";
            Code[56, 2] = "\x00AD";
            Code[57, 2] = "ø";
            Code[58, 2] = "õ";
            Code[59, 2] = "ö";
            Code[60, 2] = "÷";
            Code[61, 2] = "ù";
            Code[62, 2] = "ý";
            Code[63, 2] = "ú";
            Code[64, 2] = "û";
            Code[65, 2] = "ü";
            Code[66, 2] = "þ";
            Code[67, 2] = "®";
            Code[68, 2] = "¸";
            Code[69, 2] = "µ";
            Code[70, 2] = "¶";
            Code[71, 2] = "·";
            Code[72, 2] = "\x00B9";
            Code[73, 2] = "¡";
            Code[74, 2] = "\x00BE";
            Code[75, 2] = "»";
            Code[76, 2] = "\x00BC";
            Code[77, 2] = "\x00BD";
            Code[78, 2] = "Æ";
            Code[79, 2] = "¢";
            Code[80, 2] = "Ê";
            Code[81, 2] = "Ç";
            Code[82, 2] = "È";
            Code[83, 2] = "É";
            Code[84, 2] = "Ë";
            Code[85, 2] = "Ð";
            Code[86, 2] = "Ì";
            Code[87, 2] = "Î";
            Code[88, 2] = "Ï";
            Code[89, 2] = "Ñ";
            Code[90, 2] = "£";
            Code[91, 2] = "Õ";
            Code[92, 2] = "Ò";
            Code[93, 2] = "Ó";
            Code[94, 2] = "Ô";
            Code[95, 2] = "Ö";
            Code[96, 2] = "Ý";
            Code[97, 2] = "×";
            Code[98, 2] = "Ø";
            Code[99, 2] = "Ü";
            Code[100, 2] = "Þ";
            Code[101, 2] = "ã";
            Code[102, 2] = "ß";
            Code[103, 2] = "á";
            Code[104, 2] = "â";
            Code[105, 2] = "ä";
            Code[106, 2] = "¤";
            Code[107, 2] = "è";
            Code[108, 2] = "å";
            Code[109, 2] = "æ";
            Code[110, 2] = "ç";
            Code[111, 2] = "é";
            Code[112, 2] = "¥";
            Code[113, 2] = "í";
            Code[114, 2] = "ê";
            Code[115, 2] = "ë";
            Code[116, 2] = "ì";
            Code[117, 2] = "î";
            Code[118, 2] = "ó";
            Code[119, 2] = "ï";
            Code[120, 2] = "ñ";
            Code[121, 2] = "ò";
            Code[122, 2] = "ô";
            Code[123, 2] = "¦";
            Code[124, 2] = "ø";
            Code[125, 2] = "õ";
            Code[126, 2] = "ö";
            Code[sbyte.MaxValue, 2] = "÷";
            Code[128, 2] = "ù";
            Code[129, 2] = "ý";
            Code[130, 2] = "ú";
            Code[131, 2] = "û";
            Code[132, 2] = "ü";
            Code[133, 2] = "þ";
            Code[134, 2] = "§";
        }

        private void MapUTH()
        {
            Code[1, 5] = "á";
            Code[2, 5] = "à";
            Code[3, 5] = "ả";
            Code[4, 5] = "ã";
            Code[5, 5] = "ạ";
            Code[6, 5] = "ă";
            Code[7, 5] = "ắ";
            Code[8, 5] = "ằ";
            Code[9, 5] = "ẳ";
            Code[10, 5] = "ẵ";
            Code[11, 5] = "ặ";
            Code[12, 5] = "â";
            Code[13, 5] = "ấ";
            Code[14, 5] = "ầ";
            Code[15, 5] = "ẩ";
            Code[16, 5] = "ẫ";
            Code[17, 5] = "ậ";
            Code[18, 5] = "é";
            Code[19, 5] = "è";
            Code[20, 5] = "ẻ";
            Code[21, 5] = "ẽ";
            Code[22, 5] = "ẹ";
            Code[23, 5] = "ê";
            Code[24, 5] = "ế";
            Code[25, 5] = "ề";
            Code[26, 5] = "ể";
            Code[27, 5] = "ễ";
            Code[28, 5] = "ệ";
            Code[29, 5] = "í";
            Code[30, 5] = "ì";
            Code[31, 5] = "ỉ";
            Code[32, 5] = "ĩ";
            Code[33, 5] = "ị";
            Code[34, 5] = "ó";
            Code[35, 5] = "ò";
            Code[36, 5] = "ỏ";
            Code[37, 5] = "õ";
            Code[38, 5] = "ọ";
            Code[39, 5] = "ô";
            Code[40, 5] = "ố";
            Code[41, 5] = "ồ";
            Code[42, 5] = "ổ";
            Code[43, 5] = "ỗ";
            Code[44, 5] = "ộ";
            Code[45, 5] = "ơ";
            Code[46, 5] = "ớ";
            Code[47, 5] = "ờ";
            Code[48, 5] = "ở";
            Code[49, 5] = "ỡ";
            Code[50, 5] = "ợ";
            Code[51, 5] = "ú";
            Code[52, 5] = "ù";
            Code[53, 5] = "ủ";
            Code[54, 5] = "ũ";
            Code[55, 5] = "ụ";
            Code[56, 5] = "ư";
            Code[57, 5] = "ứ";
            Code[58, 5] = "ừ";
            Code[59, 5] = "ử";
            Code[60, 5] = "ữ";
            Code[61, 5] = "ự";
            Code[62, 5] = "ý";
            Code[63, 5] = "ỳ";
            Code[64, 5] = "ỷ";
            Code[65, 5] = "ỹ";
            Code[66, 5] = "ỵ";
            Code[67, 5] = "đ";
            Code[68, 5] = "Á";
            Code[69, 5] = "À";
            Code[70, 5] = "Ả";
            Code[71, 5] = "Ã";
            Code[72, 5] = "Ạ";
            Code[73, 5] = "Ă";
            Code[74, 5] = "Ắ";
            Code[75, 5] = "Ằ";
            Code[76, 5] = "Ẳ";
            Code[77, 5] = "Ẵ";
            Code[78, 5] = "Ặ";
            Code[79, 5] = "Â";
            Code[80, 5] = "Ấ";
            Code[81, 5] = "Ầ";
            Code[82, 5] = "Ẩ";
            Code[83, 5] = "Ẫ";
            Code[84, 5] = "Ậ";
            Code[85, 5] = "É";
            Code[86, 5] = "È";
            Code[87, 5] = "Ẻ";
            Code[88, 5] = "Ẽ";
            Code[89, 5] = "Ẹ";
            Code[90, 5] = "Ê";
            Code[91, 5] = "Ế";
            Code[92, 5] = "Ề";
            Code[93, 5] = "Ể";
            Code[94, 5] = "Ễ";
            Code[95, 5] = "Ệ";
            Code[96, 5] = "Í";
            Code[97, 5] = "Ì";
            Code[98, 5] = "Ỉ";
            Code[99, 5] = "Ĩ";
            Code[100, 5] = "Ị";
            Code[101, 5] = "Ó";
            Code[102, 5] = "Ò";
            Code[103, 5] = "Ỏ";
            Code[104, 5] = "Õ";
            Code[105, 5] = "Ọ";
            Code[106, 5] = "Ô";
            Code[107, 5] = "Ố";
            Code[108, 5] = "Ồ";
            Code[109, 5] = "Ổ";
            Code[110, 5] = "Ỗ";
            Code[111, 5] = "Ộ";
            Code[112, 5] = "Ơ";
            Code[113, 5] = "Ớ";
            Code[114, 5] = "Ờ";
            Code[115, 5] = "Ở";
            Code[116, 5] = "Ỡ";
            Code[117, 5] = "Ợ";
            Code[118, 5] = "Ú";
            Code[119, 5] = "Ù";
            Code[120, 5] = "Ủ";
            Code[121, 5] = "Ũ";
            Code[122, 5] = "Ụ";
            Code[123, 5] = "Ư";
            Code[124, 5] = "Ứ";
            Code[125, 5] = "Ừ";
            Code[126, 5] = "Ử";
            Code[sbyte.MaxValue, 5] = "Ữ";
            Code[128, 5] = "Ự";
            Code[129, 5] = "Ý";
            Code[130, 5] = "Ỳ";
            Code[131, 5] = "Ỷ";
            Code[132, 5] = "Ỹ";
            Code[133, 5] = "Ỵ";
            Code[134, 5] = "Đ";
        }

        private void MapUTF8()
        {
            Code[1, 1] = "Ã¡";
            Code[2, 1] = "Ã ";
            Code[3, 1] = "áº£";
            Code[4, 1] = "Ã£";
            Code[5, 1] = "áº¡";
            Code[6, 1] = "Äƒ";
            Code[7, 1] = "áº¯";
            Code[8, 1] = "áº±";
            Code[9, 1] = "áº\x00B3";
            Code[10, 1] = "áºµ";
            Code[11, 1] = "áº·";
            Code[12, 1] = "Ã¢";
            Code[13, 1] = "áº¥";
            Code[14, 1] = "áº§";
            Code[15, 1] = "áº©";
            Code[16, 1] = "áº«";
            Code[17, 1] = "áº\x00AD";
            Code[18, 1] = "Ã©";
            Code[19, 1] = "Ã¨";
            Code[20, 1] = "áº»";
            Code[21, 1] = "áº\x00BD";
            Code[22, 1] = "áº\x00B9";
            Code[23, 1] = "Ãª";
            Code[24, 1] = "áº¿";
            Code[25, 1] = "á»\x0081";
            Code[26, 1] = "á»ƒ";
            Code[27, 1] = "á»…";
            Code[28, 1] = "á»‡";
            Code[29, 1] = "Ã\x00AD";
            Code[30, 1] = "Ã¬";
            Code[31, 1] = "á»‰";
            Code[32, 1] = "Ä©";
            Code[33, 1] = "á»‹";
            Code[34, 1] = "Ã\x00B3";
            Code[35, 1] = "Ã\x00B2";
            Code[36, 1] = "á»\x008F";
            Code[37, 1] = "Ãµ";
            Code[38, 1] = "á»\x008D";
            Code[39, 1] = "Ã´";
            Code[40, 1] = "á»‘";
            Code[41, 1] = "á»“";
            Code[42, 1] = "á»•";
            Code[43, 1] = "á»—";
            Code[44, 1] = "á»™";
            Code[45, 1] = "Æ¡";
            Code[46, 1] = "á»›";
            Code[47, 1] = "á»\x009D";
            Code[48, 1] = "á»Ÿ";
            Code[49, 1] = "á»¡";
            Code[50, 1] = "á»£";
            Code[51, 1] = "Ãº";
            Code[52, 1] = "Ã\x00B9";
            Code[53, 1] = "á»§";
            Code[54, 1] = "Å©";
            Code[55, 1] = "á»¥";
            Code[56, 1] = "Æ°";
            Code[57, 1] = "á»©";
            Code[58, 1] = "á»«";
            Code[59, 1] = "á»\x00AD";
            Code[60, 1] = "á»¯";
            Code[61, 1] = "á»±";
            Code[62, 1] = "Ã\x00BD";
            Code[63, 1] = "á»\x00B3";
            Code[64, 1] = "\x009Dá»·".Substring(1);
            Code[65, 1] = "á»\x00B9";
            Code[66, 1] = "á»µ";
            Code[67, 1] = "Ä‘";
            Code[68, 1] = "Ã\x0081";
            Code[69, 1] = "Ã€";
            Code[70, 1] = "áº¢";
            Code[71, 1] = "Ãƒ";
            Code[72, 1] = "áº ";
            Code[73, 1] = "Ä‚";
            Code[74, 1] = "áº®";
            Code[75, 1] = "áº°";
            Code[76, 1] = "áº\x00B2";
            Code[77, 1] = "áº´";
            Code[78, 1] = "áº¶";
            Code[79, 1] = "Ã‚";
            Code[80, 1] = "áº¤";
            Code[81, 1] = "áº¦";
            Code[82, 1] = "áº¨";
            Code[83, 1] = "áºª";
            Code[84, 1] = "áº¬";
            Code[85, 1] = "Ã‰";
            Code[86, 1] = "Ã\x02C6";
            Code[87, 1] = "áºº";
            Code[88, 1] = "áº\x00BC";
            Code[89, 1] = "áº¸";
            Code[90, 1] = "ÃŠ";
            Code[91, 1] = "áº\x00BE";
            Code[92, 1] = "á»€";
            Code[93, 1] = "á»‚";
            Code[94, 1] = "á»„";
            Code[95, 1] = "á»†";
            Code[96, 1] = "Ã\x008D";
            Code[97, 1] = "ÃŒ";
            Code[98, 1] = "á»\x02C6";
            Code[99, 1] = "Ä¨";
            Code[100, 1] = "á»Š";
            Code[101, 1] = "Ã“";
            Code[102, 1] = "Ã’";
            Code[103, 1] = "á»Ž";
            Code[104, 1] = "Ã•";
            Code[105, 1] = "á»Œ";
            Code[106, 1] = "Ã”";
            Code[107, 1] = "á»\x0090";
            Code[108, 1] = "á»’";
            Code[109, 1] = "á»”";
            Code[110, 1] = "á»–";
            Code[111, 1] = "á»˜";
            Code[112, 1] = "Æ ";
            Code[113, 1] = "á»š";
            Code[114, 1] = "á»œ";
            Code[115, 1] = "á»ž";
            Code[116, 1] = "á» ";
            Code[117, 1] = "á»¢";
            Code[118, 1] = "Ãš";
            Code[119, 1] = "Ã™";
            Code[120, 1] = "á»¦";
            Code[121, 1] = "Å¨";
            Code[122, 1] = "á»¤";
            Code[123, 1] = "Æ¯";
            Code[124, 1] = "á»¨";
            Code[125, 1] = "á»ª";
            Code[126, 1] = "á»¬";
            Code[sbyte.MaxValue, 1] = "á»®";
            Code[128, 1] = "á»°";
            Code[129, 1] = "Ã\x009D";
            Code[130, 1] = "á»\x00B2";
            Code[131, 1] = "á»¶";
            Code[132, 1] = "á»¸";
            Code[133, 1] = "á»´";
            Code[134, 1] = "Ä\x0090";
        }

        private void MapVIQR()
        {
            Code[1, 8] = "a'";
            Code[2, 8] = "a`";
            Code[3, 8] = "a?";
            Code[4, 8] = "a~";
            Code[5, 8] = "a.";
            Code[6, 8] = "a(";
            Code[7, 8] = "a('";
            Code[8, 8] = "a(`";
            Code[9, 8] = "a(?";
            Code[10, 8] = "a(~";
            Code[11, 8] = "a(.";
            Code[12, 8] = "a^";
            Code[13, 8] = "a^'";
            Code[14, 8] = "a^`";
            Code[15, 8] = "a^?";
            Code[16, 8] = "a^~";
            Code[17, 8] = "a^.";
            Code[18, 8] = "e'";
            Code[19, 8] = "e`";
            Code[20, 8] = "e?";
            Code[21, 8] = "e~";
            Code[22, 8] = "e.";
            Code[23, 8] = "e^";
            Code[24, 8] = "e^'";
            Code[25, 8] = "e^`";
            Code[26, 8] = "e^?";
            Code[27, 8] = "e^~";
            Code[28, 8] = "e^.";
            Code[29, 8] = "i'";
            Code[30, 8] = "i`";
            Code[31, 8] = "i?";
            Code[32, 8] = "i~";
            Code[33, 8] = "i.";
            Code[34, 8] = "o'";
            Code[35, 8] = "o`";
            Code[36, 8] = "o?";
            Code[37, 8] = "o~";
            Code[38, 8] = "o.";
            Code[39, 8] = "o^";
            Code[40, 8] = "o^'";
            Code[41, 8] = "o^`";
            Code[42, 8] = "o^?";
            Code[43, 8] = "o^~";
            Code[44, 8] = "o^.";
            Code[45, 8] = "o+";
            Code[46, 8] = "o+'";
            Code[47, 8] = "o+`";
            Code[48, 8] = "o+?";
            Code[49, 8] = "o+~";
            Code[50, 8] = "o+.";
            Code[51, 8] = "u'";
            Code[52, 8] = "u`";
            Code[53, 8] = "u?";
            Code[54, 8] = "u~";
            Code[55, 8] = "u.";
            Code[56, 8] = "u+";
            Code[57, 8] = "u+'";
            Code[58, 8] = "u+`";
            Code[59, 8] = "u+?";
            Code[60, 8] = "u+~";
            Code[61, 8] = "u+.";
            Code[62, 8] = "y'";
            Code[63, 8] = "y`";
            Code[64, 8] = "y?";
            Code[65, 8] = "y~";
            Code[66, 8] = "y.";
            Code[67, 8] = "dd";
            Code[68, 8] = "A'";
            Code[69, 8] = "A`";
            Code[70, 8] = "A?";
            Code[71, 8] = "A~";
            Code[72, 8] = "A.";
            Code[73, 8] = "A(";
            Code[74, 8] = "A('";
            Code[75, 8] = "A(`";
            Code[76, 8] = "A(?";
            Code[77, 8] = "A(~";
            Code[78, 8] = "A(.";
            Code[79, 8] = "A^";
            Code[80, 8] = "A^'";
            Code[81, 8] = "A^`";
            Code[82, 8] = "A^?";
            Code[83, 8] = "A^~";
            Code[84, 8] = "A^.";
            Code[85, 8] = "E'";
            Code[86, 8] = "E`";
            Code[87, 8] = "E?";
            Code[88, 8] = "E~";
            Code[89, 8] = "E.";
            Code[90, 8] = "E^";
            Code[91, 8] = "E^'";
            Code[92, 8] = "E^`";
            Code[93, 8] = "E^?";
            Code[94, 8] = "E^~";
            Code[95, 8] = "E^.";
            Code[96, 8] = "I'";
            Code[97, 8] = "I`";
            Code[98, 8] = "I?";
            Code[99, 8] = "I~";
            Code[100, 8] = "I.";
            Code[101, 8] = "O'";
            Code[102, 8] = "O`";
            Code[103, 8] = "O?";
            Code[104, 8] = "O~";
            Code[105, 8] = "O.";
            Code[106, 8] = "O^";
            Code[107, 8] = "O^'";
            Code[108, 8] = "O^`";
            Code[109, 8] = "O^?";
            Code[110, 8] = "O^~";
            Code[111, 8] = "O^.";
            Code[112, 8] = "O+";
            Code[113, 8] = "O+'";
            Code[114, 8] = "O+`";
            Code[115, 8] = "O+?";
            Code[116, 8] = "O+~";
            Code[117, 8] = "O+.";
            Code[118, 8] = "U'";
            Code[119, 8] = "U`";
            Code[120, 8] = "U?";
            Code[121, 8] = "U~";
            Code[122, 8] = "U.";
            Code[123, 8] = "U+";
            Code[124, 8] = "U+'";
            Code[125, 8] = "U+`";
            Code[126, 8] = "U+?";
            Code[sbyte.MaxValue, 8] = "U+~";
            Code[128, 8] = "U+.";
            Code[129, 8] = "Y'";
            Code[130, 8] = "Y`";
            Code[131, 8] = "Y?";
            Code[132, 8] = "Y~";
            Code[133, 8] = "Y.";
            Code[134, 8] = "DD";
        }

        private void MapNCR()
        {
            Code[1, 0] = "&#225;";
            Code[2, 0] = "&#224;";
            Code[3, 0] = "&#7843;";
            Code[4, 0] = "&#227;";
            Code[5, 0] = "&#7841;";
            Code[6, 0] = "&#259;";
            Code[7, 0] = "&#7855;";
            Code[8, 0] = "&#7857;";
            Code[9, 0] = "&#7859;";
            Code[10, 0] = "&#7861;";
            Code[11, 0] = "&#7863;";
            Code[12, 0] = "&#226;";
            Code[13, 0] = "&#7845;";
            Code[14, 0] = "&#7847;";
            Code[15, 0] = "&#7849;";
            Code[16, 0] = "&#7851;";
            Code[17, 0] = "&#7853;";
            Code[18, 0] = "&#233;";
            Code[19, 0] = "&#232;";
            Code[20, 0] = "&#7867;";
            Code[21, 0] = "&#7869;";
            Code[22, 0] = "&#7865;";
            Code[23, 0] = "&#234;";
            Code[24, 0] = "&#7871;";
            Code[25, 0] = "&#7873;";
            Code[26, 0] = "&#7875;";
            Code[27, 0] = "&#7877;";
            Code[28, 0] = "&#7879;";
            Code[29, 0] = "&#237;";
            Code[30, 0] = "&#236;";
            Code[31, 0] = "&#7881;";
            Code[32, 0] = "&#297;";
            Code[33, 0] = "&#7883;";
            Code[34, 0] = "&#243;";
            Code[35, 0] = "&#242;";
            Code[36, 0] = "&#7887;";
            Code[37, 0] = "&#245;";
            Code[38, 0] = "&#7885;";
            Code[39, 0] = "&#244;";
            Code[40, 0] = "&#7889;";
            Code[41, 0] = "&#7891;";
            Code[42, 0] = "&#7893;";
            Code[43, 0] = "&#7895;";
            Code[44, 0] = "&#7897;";
            Code[45, 0] = "&#417;";
            Code[46, 0] = "&#7899;";
            Code[47, 0] = "&#7901;";
            Code[48, 0] = "&#7903;";
            Code[49, 0] = "&#7905;";
            Code[50, 0] = "&#7907;";
            Code[51, 0] = "&#250;";
            Code[52, 0] = "&#249;";
            Code[53, 0] = "&#7911;";
            Code[54, 0] = "&#361;";
            Code[55, 0] = "&#7909;";
            Code[56, 0] = "&#432;";
            Code[57, 0] = "&#7913;";
            Code[58, 0] = "&#7915;";
            Code[59, 0] = "&#7917;";
            Code[60, 0] = "&#7919;";
            Code[61, 0] = "&#7921;";
            Code[62, 0] = "&#253;";
            Code[63, 0] = "&#7923;";
            Code[64, 0] = "&#7927;";
            Code[65, 0] = "&#7929;";
            Code[66, 0] = "&#7925;";
            Code[67, 0] = "&#273;";
            Code[68, 0] = "&#193;";
            Code[69, 0] = "&#192;";
            Code[70, 0] = "&#7842;";
            Code[71, 0] = "&#195;";
            Code[72, 0] = "&#7840;";
            Code[73, 0] = "&#258;";
            Code[74, 0] = "&#7854;";
            Code[75, 0] = "&#7856;";
            Code[76, 0] = "&#7858;";
            Code[77, 0] = "&#7860;";
            Code[78, 0] = "&#7862;";
            Code[79, 0] = "&#194;";
            Code[80, 0] = "&#7844;";
            Code[81, 0] = "&#7846;";
            Code[82, 0] = "&#7848;";
            Code[83, 0] = "&#7850;";
            Code[84, 0] = "&#7852;";
            Code[85, 0] = "&#201;";
            Code[86, 0] = "&#200;";
            Code[87, 0] = "&#7866;";
            Code[88, 0] = "&#7868;";
            Code[89, 0] = "&#7864;";
            Code[90, 0] = "&#202;";
            Code[91, 0] = "&#7870;";
            Code[92, 0] = "&#7872;";
            Code[93, 0] = "&#7874;";
            Code[94, 0] = "&#7876;";
            Code[95, 0] = "&#7878;";
            Code[96, 0] = "&#205;";
            Code[97, 0] = "&#204;";
            Code[98, 0] = "&#7880;";
            Code[99, 0] = "&#296;";
            Code[100, 0] = "&#7882;";
            Code[101, 0] = "&#211;";
            Code[102, 0] = "&#210;";
            Code[103, 0] = "&#7886;";
            Code[104, 0] = "&#213;";
            Code[105, 0] = "&#7884;";
            Code[106, 0] = "&#212;";
            Code[107, 0] = "&#7888;";
            Code[108, 0] = "&#7890;";
            Code[109, 0] = "&#7892;";
            Code[110, 0] = "&#7894;";
            Code[111, 0] = "&#7896;";
            Code[112, 0] = "&#416;";
            Code[113, 0] = "&#7898;";
            Code[114, 0] = "&#7900;";
            Code[115, 0] = "&#7902;";
            Code[116, 0] = "&#7904;";
            Code[117, 0] = "&#7906;";
            Code[118, 0] = "&#218;";
            Code[119, 0] = "&#217;";
            Code[120, 0] = "&#7910;";
            Code[121, 0] = "&#360;";
            Code[122, 0] = "&#7908;";
            Code[123, 0] = "&#431;";
            Code[124, 0] = "&#7912;";
            Code[125, 0] = "&#7914;";
            Code[126, 0] = "&#7916;";
            Code[sbyte.MaxValue, 0] = "&#7918;";
            Code[128, 0] = "&#7920;";
            Code[129, 0] = "&#221;";
            Code[130, 0] = "&#7922;";
            Code[131, 0] = "&#7926;";
            Code[132, 0] = "&#7928;";
            Code[133, 0] = "&#7924;";
            Code[134, 0] = "&#272;";
        }

        private void MapCP1258()
        {
            Code[1, 4] = "aì";
            Code[2, 4] = "aÌ";
            Code[3, 4] = "aÒ";
            Code[4, 4] = "aÞ";
            Code[5, 4] = "aò";
            Code[6, 4] = "ã";
            Code[7, 4] = "ãì";
            Code[8, 4] = "ãÌ";
            Code[9, 4] = "ãÒ";
            Code[10, 4] = "ãÞ";
            Code[11, 4] = "ãò";
            Code[12, 4] = "â";
            Code[13, 4] = "âì";
            Code[14, 4] = "âÌ";
            Code[15, 4] = "âÒ";
            Code[16, 4] = "âÞ";
            Code[17, 4] = "âò";
            Code[18, 4] = "eì";
            Code[19, 4] = "eÌ";
            Code[20, 4] = "eÒ";
            Code[21, 4] = "eÞ";
            Code[22, 4] = "eò";
            Code[23, 4] = "ê";
            Code[24, 4] = "êì";
            Code[25, 4] = "êÌ";
            Code[26, 4] = "êÒ";
            Code[27, 4] = "êÞ";
            Code[28, 4] = "êò";
            Code[29, 4] = "iì";
            Code[30, 4] = "iÌ";
            Code[31, 4] = "iÒ";
            Code[32, 4] = "iÞ";
            Code[33, 4] = "iò";
            Code[34, 4] = "oì";
            Code[35, 4] = "oÌ";
            Code[36, 4] = "oÒ";
            Code[37, 4] = "oÞ";
            Code[38, 4] = "oò";
            Code[39, 4] = "ô";
            Code[40, 4] = "ôì";
            Code[41, 4] = "ôÌ";
            Code[42, 4] = "ôÒ";
            Code[43, 4] = "ôÞ";
            Code[44, 4] = "ôò";
            Code[45, 4] = "õ";
            Code[46, 4] = "õì";
            Code[47, 4] = "õÌ";
            Code[48, 4] = "õÒ";
            Code[49, 4] = "õÞ";
            Code[50, 4] = "õò";
            Code[51, 4] = "uì";
            Code[52, 4] = "uÌ";
            Code[53, 4] = "uÒ";
            Code[54, 4] = "uÞ";
            Code[55, 4] = "uò";
            Code[56, 4] = "ý";
            Code[57, 4] = "ýì";
            Code[58, 4] = "ýÌ";
            Code[59, 4] = "ýÒ";
            Code[60, 4] = "ýÞ";
            Code[61, 4] = "ýò";
            Code[62, 4] = "yì";
            Code[63, 4] = "yÌ";
            Code[64, 4] = "yÒ";
            Code[65, 4] = "yÞ";
            Code[66, 4] = "yò";
            Code[67, 4] = "ð";
            Code[68, 4] = "Aì";
            Code[69, 4] = "AÌ";
            Code[70, 4] = "AÒ";
            Code[71, 4] = "AÞ";
            Code[72, 4] = "Aò";
            Code[73, 4] = "Ã";
            Code[74, 4] = "Ãì";
            Code[75, 4] = "ÃÌ";
            Code[76, 4] = "ÃÒ";
            Code[77, 4] = "ÃÞ";
            Code[78, 4] = "Ãò";
            Code[79, 4] = "Â";
            Code[80, 4] = "Âì";
            Code[81, 4] = "ÂÌ";
            Code[82, 4] = "ÂÒ";
            Code[83, 4] = "ÂÞ";
            Code[84, 4] = "Âò";
            Code[85, 4] = "Eì";
            Code[86, 4] = "EÌ";
            Code[87, 4] = "EÒ";
            Code[88, 4] = "EÞ";
            Code[89, 4] = "Eò";
            Code[90, 4] = "Ê";
            Code[91, 4] = "Êì";
            Code[92, 4] = "ÊÌ";
            Code[93, 4] = "ÊÒ";
            Code[94, 4] = "ÊÞ";
            Code[95, 4] = "Êò";
            Code[96, 4] = "Iì";
            Code[97, 4] = "IÌ";
            Code[98, 4] = "IÒ";
            Code[99, 4] = "IÞ";
            Code[100, 4] = "Iò";
            Code[101, 4] = "Oì";
            Code[102, 4] = "OÌ";
            Code[103, 4] = "OÒ";
            Code[104, 4] = "OÞ";
            Code[105, 4] = "Oò";
            Code[106, 4] = "Ô";
            Code[107, 4] = "Ôì";
            Code[108, 4] = "ÔÌ";
            Code[109, 4] = "ÔÒ";
            Code[110, 4] = "ÔÞ";
            Code[111, 4] = "Ôò";
            Code[112, 4] = "Õ";
            Code[113, 4] = "Õì";
            Code[114, 4] = "ÕÌ";
            Code[115, 4] = "ÕÒ";
            Code[116, 4] = "ÕÞ";
            Code[117, 4] = "Õò";
            Code[118, 4] = "Uì";
            Code[119, 4] = "UÌ";
            Code[120, 4] = "UÒ";
            Code[121, 4] = "UÞ";
            Code[122, 4] = "Uò";
            Code[123, 4] = "Ý";
            Code[124, 4] = "Ýì";
            Code[125, 4] = "ÝÌ";
            Code[126, 4] = "ÝÒ";
            Code[sbyte.MaxValue, 4] = "ÝÞ";
            Code[128, 4] = "Ýò";
            Code[129, 4] = "Yì";
            Code[130, 4] = "YÌ";
            Code[131, 4] = "YÒ";
            Code[132, 4] = "YÞ";
            Code[133, 4] = "Yò";
            Code[134, 4] = "Ð";
        }

        private void MapVISCII()
        {
            Code[1, 6] = "á";
            Code[2, 6] = "à";
            Code[3, 6] = "ä";
            Code[4, 6] = "ã";
            Code[5, 6] = "Õ";
            Code[6, 6] = "å";
            Code[7, 6] = "¡";
            Code[8, 6] = "¢";
            Code[9, 6] = "Æ";
            Code[10, 6] = "Ç";
            Code[11, 6] = "£";
            Code[12, 6] = "â";
            Code[13, 6] = "¤";
            Code[14, 6] = "¥";
            Code[15, 6] = "¦";
            Code[16, 6] = "ç";
            Code[17, 6] = "§";
            Code[18, 6] = "é";
            Code[19, 6] = "è";
            Code[20, 6] = "ë";
            Code[21, 6] = "¨";
            Code[22, 6] = "©";
            Code[23, 6] = "ê";
            Code[24, 6] = "ª";
            Code[25, 6] = "«";
            Code[26, 6] = "¬";
            Code[27, 6] = "\x00AD";
            Code[28, 6] = "®";
            Code[29, 6] = "í";
            Code[30, 6] = "ì";
            Code[31, 6] = "ï";
            Code[32, 6] = "î";
            Code[33, 6] = "¸";
            Code[34, 6] = "ó";
            Code[35, 6] = "ò";
            Code[36, 6] = "ö";
            Code[37, 6] = "õ";
            Code[38, 6] = "÷";
            Code[39, 6] = "ô";
            Code[40, 6] = "¯";
            Code[41, 6] = "°";
            Code[42, 6] = "±";
            Code[43, 6] = "\x00B2";
            Code[44, 6] = "µ";
            Code[45, 6] = "\x00BD";
            Code[46, 6] = "\x00BE";
            Code[47, 6] = "¶";
            Code[48, 6] = "·";
            Code[49, 6] = "Þ";
            Code[50, 6] = "þ";
            Code[51, 6] = "ú";
            Code[52, 6] = "ù";
            Code[53, 6] = "ü";
            Code[54, 6] = "û";
            Code[55, 6] = "ø";
            Code[56, 6] = "ß";
            Code[57, 6] = "Ñ";
            Code[58, 6] = "×";
            Code[59, 6] = "Ø";
            Code[60, 6] = "æ";
            Code[61, 6] = "ñ";
            Code[62, 6] = "ý";
            Code[63, 6] = "Ï";
            Code[64, 6] = "Ö";
            Code[65, 6] = "Û";
            Code[66, 6] = "Ü";
            Code[67, 6] = "ð";
            Code[68, 6] = "Á";
            Code[69, 6] = "À";
            Code[70, 6] = "Ä";
            Code[71, 6] = "Ã";
            Code[72, 6] = "€";
            Code[73, 6] = "Å";
            Code[74, 6] = "\x0081";
            Code[75, 6] = "‚";
            Code[76, 6] = "Æ";
            Code[77, 6] = "Ç";
            Code[78, 6] = "ƒ";
            Code[79, 6] = "Â";
            Code[80, 6] = "„";
            Code[81, 6] = "…";
            Code[82, 6] = "†";
            Code[83, 6] = "ç";
            Code[84, 6] = "‡";
            Code[85, 6] = "É";
            Code[86, 6] = "È";
            Code[87, 6] = "Ë";
            Code[88, 6] = "\x02C6";
            Code[89, 6] = "‰";
            Code[90, 6] = "Ê";
            Code[91, 6] = "Š";
            Code[92, 6] = "‹";
            Code[93, 6] = "Œ";
            Code[94, 6] = "\x008D";
            Code[95, 6] = "Ž";
            Code[96, 6] = "Í";
            Code[97, 6] = "Ì";
            Code[98, 6] = "›";
            Code[99, 6] = "Î";
            Code[100, 6] = "˜";
            Code[101, 6] = "Ó";
            Code[102, 6] = "Ò";
            Code[103, 6] = "™";
            Code[104, 6] = "õ";
            Code[105, 6] = "š";
            Code[106, 6] = "Ô";
            Code[107, 6] = "\x008F";
            Code[108, 6] = "\x0090";
            Code[109, 6] = "‘";
            Code[110, 6] = "’";
            Code[111, 6] = "“";
            Code[112, 6] = "´";
            Code[113, 6] = "•";
            Code[114, 6] = "–";
            Code[115, 6] = "—";
            Code[116, 6] = "\x00B3";
            Code[117, 6] = "”";
            Code[118, 6] = "Ú";
            Code[119, 6] = "Ù";
            Code[120, 6] = "œ";
            Code[121, 6] = "\x009D";
            Code[122, 6] = "ž";
            Code[123, 6] = "¿";
            Code[124, 6] = "º";
            Code[125, 6] = "»";
            Code[126, 6] = "\x00BC";
            Code[sbyte.MaxValue, 6] = "ÿ";
            Code[128, 6] = "\x00B9";
            Code[129, 6] = "Ý";
            Code[130, 6] = "Ÿ";
            Code[131, 6] = "Ö";
            Code[132, 6] = "Û";
            Code[133, 6] = "Ü";
            Code[134, 6] = "Ð";
        }

        private void MapVPS()
        {
            Code[1, 6] = "á";
            Code[2, 6] = "à";
            Code[3, 6] = "ä";
            Code[4, 6] = "ã";
            Code[5, 6] = "å";
            Code[6, 6] = "æ";
            Code[7, 6] = "¡";
            Code[8, 6] = "¢";
            Code[9, 6] = "£";
            Code[10, 6] = "¤";
            Code[11, 6] = "¥";
            Code[12, 6] = "â";
            Code[13, 6] = "Ã";
            Code[14, 6] = "À";
            Code[15, 6] = "Ä";
            Code[16, 6] = "Å";
            Code[17, 6] = "Æ";
            Code[18, 6] = "é";
            Code[19, 6] = "è";
            Code[20, 6] = "È";
            Code[21, 6] = "ë";
            Code[22, 6] = "Ë";
            Code[23, 6] = "ê";
            Code[24, 6] = "‰";
            Code[25, 6] = "Š";
            Code[26, 6] = "‹";
            Code[27, 6] = "Í";
            Code[28, 6] = "Œ";
            Code[29, 6] = "í";
            Code[30, 6] = "ì";
            Code[31, 6] = "Ì";
            Code[32, 6] = "ï";
            Code[33, 6] = "Î";
            Code[34, 6] = "ó";
            Code[35, 6] = "ò";
            Code[36, 6] = "Õ";
            Code[37, 6] = "õ";
            Code[38, 6] = "†";
            Code[39, 6] = "ô";
            Code[40, 6] = "Ó";
            Code[41, 6] = "Ò";
            Code[42, 6] = "°";
            Code[43, 6] = "‡";
            Code[44, 6] = "¶";
            Code[45, 6] = "Ö";
            Code[46, 6] = "§";
            Code[47, 6] = "©";
            Code[48, 6] = "ª";
            Code[49, 6] = "«";
            Code[50, 6] = "®";
            Code[51, 6] = "ú";
            Code[52, 6] = "ù";
            Code[53, 6] = "û";
            Code[54, 6] = "Û";
            Code[55, 6] = "ø";
            Code[56, 6] = "Ü";
            Code[57, 6] = "Ù";
            Code[58, 6] = "Ø";
            Code[59, 6] = "º";
            Code[60, 6] = "»";
            Code[61, 6] = "¿";
            Code[62, 6] = "š";
            Code[63, 6] = "ÿ";
            Code[64, 6] = "›";
            Code[65, 6] = "Ï";
            Code[66, 6] = "œ";
            Code[67, 6] = "Ç";
            Code[68, 6] = "Á";
            Code[69, 6] = "€";
            Code[70, 6] = "\x0081";
            Code[71, 6] = "‚";
            Code[72, 6] = "å";
            Code[73, 6] = "\x02C6";
            Code[74, 6] = "\x008D";
            Code[75, 6] = "Ž";
            Code[76, 6] = "\x008F";
            Code[77, 6] = "ð";
            Code[78, 6] = "¥";
            Code[79, 6] = "Â";
            Code[80, 6] = "ƒ";
            Code[81, 6] = "„";
            Code[82, 6] = "…";
            Code[83, 6] = "Å";
            Code[84, 6] = "Æ";
            Code[85, 6] = "É";
            Code[86, 6] = "×";
            Code[87, 6] = "Þ";
            Code[88, 6] = "þ";
            Code[89, 6] = "Ë";
            Code[90, 6] = "Ê";
            Code[91, 6] = "\x0090";
            Code[92, 6] = "“";
            Code[93, 6] = "”";
            Code[94, 6] = "•";
            Code[95, 6] = "Œ";
            Code[96, 6] = "´";
            Code[97, 6] = "µ";
            Code[98, 6] = "·";
            Code[99, 6] = "¸";
            Code[100, 6] = "Î";
            Code[101, 6] = "\x00B9";
            Code[102, 6] = "\x00BC";
            Code[103, 6] = "\x00BD";
            Code[104, 6] = "\x00BE";
            Code[105, 6] = "†";
            Code[106, 6] = "Ô";
            Code[107, 6] = "–";
            Code[108, 6] = "—";
            Code[109, 6] = "˜";
            Code[110, 6] = "™";
            Code[111, 6] = "¶";
            Code[112, 6] = "÷";
            Code[113, 6] = "\x009D";
            Code[114, 6] = "ž";
            Code[115, 6] = "Ÿ";
            Code[116, 6] = "¦";
            Code[117, 6] = "®";
            Code[118, 6] = "Ú";
            Code[119, 6] = "¨";
            Code[120, 6] = "Ñ";
            Code[121, 6] = "¬";
            Code[122, 6] = "ø";
            Code[123, 6] = "Ð";
            Code[124, 6] = "\x00AD";
            Code[125, 6] = "¯";
            Code[126, 6] = "±";
            Code[sbyte.MaxValue, 6] = "»";
            Code[128, 6] = "¿";
            Code[129, 6] = "Ý";
            Code[130, 6] = "\x00B2";
            Code[131, 6] = "ý";
            Code[132, 6] = "\x00B3";
            Code[133, 6] = "œ";
            Code[134, 6] = "ñ";
        }

        private void MapBKHCM2()
        {
            Code[1, 6] = "aá";
            Code[2, 6] = "aâ";
            Code[3, 6] = "aã";
            Code[4, 6] = "aä";
            Code[5, 6] = "aå";
            Code[6, 6] = "ù";
            Code[7, 6] = "ùæ";
            Code[8, 6] = "ùç";
            Code[9, 6] = "ùè";
            Code[10, 6] = "ùé";
            Code[11, 6] = "ùå";
            Code[12, 6] = "ê";
            Code[13, 6] = "êë";
            Code[14, 6] = "êì";
            Code[15, 6] = "êí";
            Code[16, 6] = "êî";
            Code[17, 6] = "êå";
            Code[18, 6] = "eá";
            Code[19, 6] = "eâ";
            Code[20, 6] = "eã";
            Code[21, 6] = "eä";
            Code[22, 6] = "eå";
            Code[23, 6] = "ï";
            Code[24, 6] = "ïë";
            Code[25, 6] = "ïì";
            Code[26, 6] = "ïí";
            Code[27, 6] = "ïî";
            Code[28, 6] = "ïå";
            Code[29, 6] = "ñ";
            Code[30, 6] = "ò";
            Code[31, 6] = "ó";
            Code[32, 6] = "ô";
            Code[33, 6] = "õ";
            Code[34, 6] = "oá";
            Code[35, 6] = "oâ";
            Code[36, 6] = "oã";
            Code[37, 6] = "oä";
            Code[38, 6] = "oå";
            Code[39, 6] = "ö";
            Code[40, 6] = "öë";
            Code[41, 6] = "öì";
            Code[42, 6] = "öí";
            Code[43, 6] = "öî";
            Code[44, 6] = "öå";
            Code[45, 6] = "ú";
            Code[46, 6] = "úá";
            Code[47, 6] = "úâ";
            Code[48, 6] = "úã";
            Code[49, 6] = "úä";
            Code[50, 6] = "úå";
            Code[51, 6] = "uá";
            Code[52, 6] = "uâ";
            Code[53, 6] = "uã";
            Code[54, 6] = "uä";
            Code[55, 6] = "uå";
            Code[56, 6] = "û";
            Code[57, 6] = "ûá";
            Code[58, 6] = "ûâ";
            Code[59, 6] = "ûã";
            Code[60, 6] = "ûä";
            Code[61, 6] = "ûå";
            Code[62, 6] = "yá";
            Code[63, 6] = "yâ";
            Code[64, 6] = "yã";
            Code[65, 6] = "yä";
            Code[66, 6] = "yå";
            Code[67, 6] = "à";
            Code[68, 6] = "AÁ";
            Code[69, 6] = "AÂ";
            Code[70, 6] = "AÃ";
            Code[71, 6] = "AÄ";
            Code[72, 6] = "AÅ";
            Code[73, 6] = "Ù";
            Code[74, 6] = "ÙÆ";
            Code[75, 6] = "ÙÇ";
            Code[76, 6] = "ÙÈ";
            Code[77, 6] = "ÙÉ";
            Code[78, 6] = "ÙÅ";
            Code[79, 6] = "Ê";
            Code[80, 6] = "ÊË";
            Code[81, 6] = "ÊÌ";
            Code[82, 6] = "ÊÍ";
            Code[83, 6] = "ÊÎ";
            Code[84, 6] = "ÊÅ";
            Code[85, 6] = "EÁ";
            Code[86, 6] = "EÂ";
            Code[87, 6] = "EÃ";
            Code[88, 6] = "EÄ";
            Code[89, 6] = "EÅ";
            Code[90, 6] = "Ï";
            Code[91, 6] = "ÏË";
            Code[92, 6] = "ÏÌ";
            Code[93, 6] = "ÏÍ";
            Code[94, 6] = "ÏÎ";
            Code[95, 6] = "Ïå";
            Code[96, 6] = "Ñ";
            Code[97, 6] = "Ò";
            Code[98, 6] = "Ó";
            Code[99, 6] = "Ô";
            Code[100, 6] = "Õ";
            Code[101, 6] = "OÁ";
            Code[102, 6] = "OÂ";
            Code[103, 6] = "OÃ";
            Code[104, 6] = "OÄ";
            Code[105, 6] = "OÅ";
            Code[106, 6] = "Ö";
            Code[107, 6] = "ÖË";
            Code[108, 6] = "ÖÌ";
            Code[109, 6] = "ÖÍ";
            Code[110, 6] = "ÖÎ";
            Code[111, 6] = "ÖÅ";
            Code[112, 6] = "Ú";
            Code[113, 6] = "ÚÁ";
            Code[114, 6] = "ÚÂ";
            Code[115, 6] = "ÚÃ";
            Code[116, 6] = "ÚÄ";
            Code[117, 6] = "ÚÅ";
            Code[118, 6] = "UÁ";
            Code[119, 6] = "UÂ";
            Code[120, 6] = "UÃ";
            Code[121, 6] = "UÄ";
            Code[122, 6] = "UÅ";
            Code[123, 6] = "Û";
            Code[124, 6] = "ÛÁ";
            Code[125, 6] = "ÛÂ";
            Code[126, 6] = "ÛÃ";
            Code[sbyte.MaxValue, 6] = "ÛÄ";
            Code[128, 6] = "ÛÅ";
            Code[129, 6] = "YÁ";
            Code[130, 6] = "YÂ";
            Code[131, 6] = "YÃ";
            Code[132, 6] = "YÄ";
            Code[133, 6] = "YÅ";
            Code[134, 6] = "À";
        }

        private void MapBKHCM1()
        {
            Code[1, 6] = "\x00BE";
            Code[2, 6] = "¿";
            Code[3, 6] = "À";
            Code[4, 6] = "Á";
            Code[5, 6] = "Â";
            Code[6, 6] = "×";
            Code[7, 6] = "Ø";
            Code[8, 6] = "Ù";
            Code[9, 6] = "Ú";
            Code[10, 6] = "Û";
            Code[11, 6] = "Ü";
            Code[12, 6] = "Ý";
            Code[13, 6] = "Þ";
            Code[14, 6] = "ß";
            Code[15, 6] = "à";
            Code[16, 6] = "á";
            Code[17, 6] = "â";
            Code[18, 6] = "Ã";
            Code[19, 6] = "Ä";
            Code[20, 6] = "Å";
            Code[21, 6] = "Æ";
            Code[22, 6] = "Ç";
            Code[23, 6] = "ã";
            Code[24, 6] = "ä";
            Code[25, 6] = "å";
            Code[26, 6] = "æ";
            Code[27, 6] = "ç";
            Code[28, 6] = "è";
            Code[29, 6] = "È";
            Code[30, 6] = "É";
            Code[31, 6] = "Ê";
            Code[32, 6] = "Ë";
            Code[33, 6] = "Ì";
            Code[34, 6] = "Í";
            Code[35, 6] = "Î";
            Code[36, 6] = "Ï";
            Code[37, 6] = "Ð";
            Code[38, 6] = "Ñ";
            Code[39, 6] = "é";
            Code[40, 6] = "ê";
            Code[41, 6] = "ë";
            Code[42, 6] = "ì";
            Code[43, 6] = "í";
            Code[44, 6] = "î";
            Code[45, 6] = "ï";
            Code[46, 6] = "ð";
            Code[47, 6] = "ñ";
            Code[48, 6] = "ò";
            Code[49, 6] = "ó";
            Code[50, 6] = "ô";
            Code[51, 6] = "Ò";
            Code[52, 6] = "Ó";
            Code[53, 6] = "Ô";
            Code[54, 6] = "Õ";
            Code[55, 6] = "Ö";
            Code[56, 6] = "õ";
            Code[57, 6] = "ö";
            Code[58, 6] = "÷";
            Code[59, 6] = "ø";
            Code[60, 6] = "ù";
            Code[61, 6] = "ú";
            Code[62, 6] = "û";
            Code[63, 6] = "ü";
            Code[64, 6] = "ý";
            Code[65, 6] = "þ";
            Code[66, 6] = "ÿ";
            Code[67, 6] = "\x00BD";
            Code[68, 6] = "€";
            Code[69, 6] = "\x0081";
            Code[70, 6] = "‚";
            Code[71, 6] = "ƒ";
            Code[72, 6] = "„";
            Code[73, 6] = "™";
            Code[74, 6] = "š";
            Code[75, 6] = "›";
            Code[76, 6] = "œ";
            Code[77, 6] = "\x009D";
            Code[78, 6] = "˜";
            Code[79, 6] = "Ÿ";
            Code[80, 6] = "~";
            Code[81, 6] = "¡";
            Code[82, 6] = "¢";
            Code[83, 6] = "£";
            Code[84, 6] = "¤";
            Code[85, 6] = "…";
            Code[86, 6] = "†";
            Code[87, 6] = "‡";
            Code[88, 6] = "\x02C6";
            Code[89, 6] = "‰";
            Code[90, 6] = "¥";
            Code[91, 6] = "¦";
            Code[92, 6] = "§";
            Code[93, 6] = "¨";
            Code[94, 6] = "©";
            Code[95, 6] = "ª";
            Code[96, 6] = "Š";
            Code[97, 6] = "‹";
            Code[98, 6] = "Œ";
            Code[99, 6] = "\x008D";
            Code[100, 6] = "Ž";
            Code[101, 6] = "\x008F";
            Code[102, 6] = "\x0090";
            Code[103, 6] = "‘";
            Code[104, 6] = "’";
            Code[105, 6] = "“";
            Code[106, 6] = "«";
            Code[107, 6] = "¬";
            Code[108, 6] = "\x00AD";
            Code[109, 6] = "®";
            Code[110, 6] = "¯";
            Code[111, 6] = "°";
            Code[112, 6] = "±";
            Code[113, 6] = "\x00B2";
            Code[114, 6] = "\x00B3";
            Code[115, 6] = "´";
            Code[116, 6] = "µ";
            Code[117, 6] = "¶";
            Code[118, 6] = "”";
            Code[119, 6] = "•";
            Code[120, 6] = "–";
            Code[121, 6] = "—";
            Code[122, 6] = "˜";
            Code[123, 6] = "·";
            Code[124, 6] = "¸";
            Code[125, 6] = "\x00B9";
            Code[126, 6] = "º";
            Code[sbyte.MaxValue, 6] = "»";
            Code[128, 6] = "\x00BC";
            Code[129, 6] = "{";
            Code[130, 6] = "^";
            Code[131, 6] = "`";
            Code[132, 6] = "|";
            Code[133, 6] = "Ž";
            Code[134, 6] = "}";
        }

        private void MapVietwareX()
        {
            Code[1, 6] = "aï";
            Code[2, 6] = "aì";
            Code[3, 6] = "aí";
            Code[4, 6] = "aî";
            Code[5, 6] = "aû";
            Code[6, 6] = "à";
            Code[7, 6] = "àõ";
            Code[8, 6] = "àò";
            Code[9, 6] = "àó";
            Code[10, 6] = "àô";
            Code[11, 6] = "àû";
            Code[12, 6] = "á";
            Code[13, 6] = "áú";
            Code[14, 6] = "áö";
            Code[15, 6] = "áø";
            Code[16, 6] = "áù";
            Code[17, 6] = "áû";
            Code[18, 6] = "eï";
            Code[19, 6] = "eì";
            Code[20, 6] = "eí";
            Code[21, 6] = "eî";
            Code[22, 6] = "eû";
            Code[23, 6] = "ã";
            Code[24, 6] = "ãú";
            Code[25, 6] = "ãö";
            Code[26, 6] = "ãø";
            Code[27, 6] = "ãù";
            Code[28, 6] = "ãû";
            Code[29, 6] = "ê";
            Code[30, 6] = "ç";
            Code[31, 6] = "è";
            Code[32, 6] = "é";
            Code[33, 6] = "ë";
            Code[34, 6] = "oï";
            Code[35, 6] = "oì";
            Code[36, 6] = "oí";
            Code[37, 6] = "oî";
            Code[38, 6] = "oü";
            Code[39, 6] = "ä";
            Code[40, 6] = "äú";
            Code[41, 6] = "äö";
            Code[42, 6] = "äø";
            Code[43, 6] = "äù";
            Code[44, 6] = "äü";
            Code[45, 6] = "å";
            Code[46, 6] = "åï";
            Code[47, 6] = "åì";
            Code[48, 6] = "åí";
            Code[49, 6] = "åî";
            Code[50, 6] = "åü";
            Code[51, 6] = "uï";
            Code[52, 6] = "uì";
            Code[53, 6] = "uí";
            Code[54, 6] = "uî";
            Code[55, 6] = "uû";
            Code[56, 6] = "æ";
            Code[57, 6] = "æï";
            Code[58, 6] = "æì";
            Code[59, 6] = "æí";
            Code[60, 6] = "æî";
            Code[61, 6] = "æû";
            Code[62, 6] = "yï";
            Code[63, 6] = "yì";
            Code[64, 6] = "yí";
            Code[65, 6] = "yî";
            Code[66, 6] = "yñ";
            Code[67, 6] = "â";
            Code[68, 6] = "AÏ";
            Code[69, 6] = "AÌ";
            Code[70, 6] = "AÍ";
            Code[71, 6] = "AÎ";
            Code[72, 6] = "AÛ";
            Code[73, 6] = "À";
            Code[74, 6] = "ÀÕ";
            Code[75, 6] = "ÀÒ";
            Code[76, 6] = "ÀÓ";
            Code[77, 6] = "ÀÔ";
            Code[78, 6] = "ÀÛ";
            Code[79, 6] = "Á";
            Code[80, 6] = "ÁÚ";
            Code[81, 6] = "ÁÖ";
            Code[82, 6] = "ÁØ";
            Code[83, 6] = "ÁÙ";
            Code[84, 6] = "ÁÛ";
            Code[85, 6] = "EÏ";
            Code[86, 6] = "EÌ";
            Code[87, 6] = "EÍ";
            Code[88, 6] = "EÎ";
            Code[89, 6] = "EÛ";
            Code[90, 6] = "Ã";
            Code[91, 6] = "ÃÚ";
            Code[92, 6] = "ÃÖ";
            Code[93, 6] = "ÃØ";
            Code[94, 6] = "ÃÙ";
            Code[95, 6] = "ÃÛ";
            Code[96, 6] = "Ê";
            Code[97, 6] = "Ç";
            Code[98, 6] = "È";
            Code[99, 6] = "É";
            Code[100, 6] = "Ë";
            Code[101, 6] = "OÏ";
            Code[102, 6] = "OÌ";
            Code[103, 6] = "OÍ";
            Code[104, 6] = "OÎ";
            Code[105, 6] = "OÜ";
            Code[106, 6] = "Ä";
            Code[107, 6] = "ÄÚ";
            Code[108, 6] = "ÄÖ";
            Code[109, 6] = "ÄØ";
            Code[110, 6] = "ÄÙ";
            Code[111, 6] = "ÄÜ";
            Code[112, 6] = "Å";
            Code[113, 6] = "ÅÏ";
            Code[114, 6] = "ÅÌ";
            Code[115, 6] = "ÅÍ";
            Code[116, 6] = "ÅÎ";
            Code[117, 6] = "ÅÜ";
            Code[118, 6] = "UÏ";
            Code[119, 6] = "UÌ";
            Code[120, 6] = "UÍ";
            Code[121, 6] = "UÎ";
            Code[122, 6] = "UÛ";
            Code[123, 6] = "Æ";
            Code[124, 6] = "ÆÏ";
            Code[125, 6] = "ÆÌ";
            Code[126, 6] = "ÆÍ";
            Code[sbyte.MaxValue, 6] = "ÆÎ";
            Code[128, 6] = "ÆÛ";
            Code[129, 6] = "YÏ";
            Code[130, 6] = "YÌ";
            Code[131, 6] = "YÍ";
            Code[132, 6] = "YÎ";
            Code[133, 6] = "YÑ";
            Code[134, 6] = "Â";
        }

        private void MapVietwareF()
        {
            Code[1, 6] = "À";
            Code[2, 6] = "ª";
            Code[3, 6] = "¶";
            Code[4, 6] = "º";
            Code[5, 6] = "Á";
            Code[6, 6] = "Ÿ";
            Code[7, 6] = "Å";
            Code[8, 6] = "Â";
            Code[9, 6] = "Ã";
            Code[10, 6] = "Ä";
            Code[11, 6] = "Æ";
            Code[12, 6] = "¡";
            Code[13, 6] = "Ê";
            Code[14, 6] = "Ç";
            Code[15, 6] = "È";
            Code[16, 6] = "É";
            Code[17, 6] = "Ë";
            Code[18, 6] = "Ï";
            Code[19, 6] = "Ì";
            Code[20, 6] = "Í";
            Code[21, 6] = "Î";
            Code[22, 6] = "Ñ";
            Code[23, 6] = "£";
            Code[24, 6] = "Õ";
            Code[25, 6] = "Ò";
            Code[26, 6] = "Ó";
            Code[27, 6] = "Ô";
            Code[28, 6] = "Ö";
            Code[29, 6] = "Û";
            Code[30, 6] = "Ø";
            Code[31, 6] = "Ù";
            Code[32, 6] = "Ú";
            Code[33, 6] = "Ü";
            Code[34, 6] = "â";
            Code[35, 6] = "ß";
            Code[36, 6] = "à";
            Code[37, 6] = "á";
            Code[38, 6] = "ã";
            Code[39, 6] = "¤";
            Code[40, 6] = "ç";
            Code[41, 6] = "ä";
            Code[42, 6] = "å";
            Code[43, 6] = "æ";
            Code[44, 6] = "è";
            Code[45, 6] = "¥";
            Code[46, 6] = "ì";
            Code[47, 6] = "é";
            Code[48, 6] = "ê";
            Code[49, 6] = "ë";
            Code[50, 6] = "í";
            Code[51, 6] = "ò";
            Code[52, 6] = "î";
            Code[53, 6] = "ï";
            Code[54, 6] = "ñ";
            Code[55, 6] = "ó";
            Code[56, 6] = "§";
            Code[57, 6] = "÷";
            Code[58, 6] = "ô";
            Code[59, 6] = "õ";
            Code[60, 6] = "ö";
            Code[61, 6] = "ø";
            Code[62, 6] = "ü";
            Code[63, 6] = "ù";
            Code[64, 6] = "ú";
            Code[65, 6] = "û";
            Code[66, 6] = "ÿ";
            Code[67, 6] = "¢";
            Code[68, 6] = "À";
            Code[69, 6] = "ª";
            Code[70, 6] = "¶";
            Code[71, 6] = "º";
            Code[72, 6] = "Á";
            Code[73, 6] = "–";
            Code[74, 6] = "Å";
            Code[75, 6] = "Â";
            Code[76, 6] = "Ã";
            Code[77, 6] = "Ä";
            Code[78, 6] = "Æ";
            Code[79, 6] = "—";
            Code[80, 6] = "Ê";
            Code[81, 6] = "Ç";
            Code[82, 6] = "È";
            Code[83, 6] = "É";
            Code[84, 6] = "Ë";
            Code[85, 6] = "Ï";
            Code[86, 6] = "Ì";
            Code[87, 6] = "Í";
            Code[88, 6] = "Î";
            Code[89, 6] = "Ñ";
            Code[90, 6] = "™";
            Code[91, 6] = "Õ";
            Code[92, 6] = "Ò";
            Code[93, 6] = "Ó";
            Code[94, 6] = "Ô";
            Code[95, 6] = "Ö";
            Code[96, 6] = "Û";
            Code[97, 6] = "Ø";
            Code[98, 6] = "Ù";
            Code[99, 6] = "Ú";
            Code[100, 6] = "Ü";
            Code[101, 6] = "â";
            Code[102, 6] = "ß";
            Code[103, 6] = "à";
            Code[104, 6] = "á";
            Code[105, 6] = "ã";
            Code[106, 6] = "š";
            Code[107, 6] = "ç";
            Code[108, 6] = "ä";
            Code[109, 6] = "å";
            Code[110, 6] = "æ";
            Code[111, 6] = "è";
            Code[112, 6] = "›";
            Code[113, 6] = "ì";
            Code[114, 6] = "é";
            Code[115, 6] = "ê";
            Code[116, 6] = "ë";
            Code[117, 6] = "í";
            Code[118, 6] = "ò";
            Code[119, 6] = "î";
            Code[120, 6] = "ï";
            Code[121, 6] = "ñ";
            Code[122, 6] = "ó";
            Code[123, 6] = "œ";
            Code[124, 6] = "÷";
            Code[125, 6] = "ô";
            Code[126, 6] = "õ";
            Code[sbyte.MaxValue, 6] = "ö";
            Code[128, 6] = "ø";
            Code[129, 6] = "ü";
            Code[130, 6] = "ù";
            Code[131, 6] = "ú";
            Code[132, 6] = "û";
            Code[133, 6] = "ÿ";
            Code[134, 6] = "˜";
        }

        private void MapNCRHex()
        {
            Code[1, 6] = "á";
            Code[2, 6] = "à";
            Code[3, 6] = "&#x1EA3;";
            Code[4, 6] = "ã";
            Code[5, 6] = "&#x1EA1;";
            Code[6, 6] = "&#x103;";
            Code[7, 6] = "&#x1EAF;";
            Code[8, 6] = "&#x1EB1;";
            Code[9, 6] = "&#x1EB3;";
            Code[10, 6] = "&#x1EB5;";
            Code[11, 6] = "&#x1EB7;";
            Code[12, 6] = "â";
            Code[13, 6] = "&#x1EA5;";
            Code[14, 6] = "&#x1EA7;";
            Code[15, 6] = "&#x1EA9;";
            Code[16, 6] = "&#x1EAB;";
            Code[17, 6] = "&#x1EAD;";
            Code[18, 6] = "é";
            Code[19, 6] = "è";
            Code[20, 6] = "&#x1EBB;";
            Code[21, 6] = "&#x1EBD;";
            Code[22, 6] = "&#x1EB9;";
            Code[23, 6] = "ê";
            Code[24, 6] = "&#x1EBF;";
            Code[25, 6] = "&#x1EC1;";
            Code[26, 6] = "&#x1EC3;";
            Code[27, 6] = "&#x1EC5;";
            Code[28, 6] = "&#x1EC7;";
            Code[29, 6] = "í";
            Code[30, 6] = "ì";
            Code[31, 6] = "&#x1EC9;";
            Code[32, 6] = "&#x129;";
            Code[33, 6] = "&#x1ECB;";
            Code[34, 6] = "ó";
            Code[35, 6] = "ò";
            Code[36, 6] = "&#x1ECF;";
            Code[37, 6] = "õ";
            Code[38, 6] = "&#x1ECD;";
            Code[39, 6] = "ô";
            Code[40, 6] = "&#x1ED1;";
            Code[41, 6] = "&#x1ED3;";
            Code[42, 6] = "&#x1ED5;";
            Code[43, 6] = "&#x1ED7;";
            Code[44, 6] = "&#x1ED9;";
            Code[45, 6] = "&#x1A1;";
            Code[46, 6] = "&#x1EDB;";
            Code[47, 6] = "&#x1EDD;";
            Code[48, 6] = "&#x1EDF;";
            Code[49, 6] = "&#x1EE1;";
            Code[50, 6] = "&#x1EE3;";
            Code[51, 6] = "ú";
            Code[52, 6] = "ù";
            Code[53, 6] = "&#x1EE7;";
            Code[54, 6] = "&#x169;";
            Code[55, 6] = "&#x1EE5;";
            Code[56, 6] = "&#x1B0;";
            Code[57, 6] = "&#x1EE9;";
            Code[58, 6] = "&#x1EEB;";
            Code[59, 6] = "&#x1EED;";
            Code[60, 6] = "&#x1EEF;";
            Code[61, 6] = "&#x1EF1;";
            Code[62, 6] = "ý";
            Code[63, 6] = "&#x1EF3;";
            Code[64, 6] = "&#x1EF7;";
            Code[65, 6] = "&#x1EF9;";
            Code[66, 6] = "&#x1EF5;";
            Code[67, 6] = "&#x111;";
            Code[68, 6] = "Á";
            Code[69, 6] = "À";
            Code[70, 6] = "&#x1EA2;";
            Code[71, 6] = "Ã";
            Code[72, 6] = "&#x1EA0;";
            Code[73, 6] = "&#x102;";
            Code[74, 6] = "&#x1EAE;";
            Code[75, 6] = "&#x1EB0;";
            Code[76, 6] = "&#x1EB2;";
            Code[77, 6] = "&#x1EB4;";
            Code[78, 6] = "&#x1EB6;";
            Code[79, 6] = "Â";
            Code[80, 6] = "&#x1EA4;";
            Code[81, 6] = "&#x1EA6;";
            Code[82, 6] = "&#x1EA8;";
            Code[83, 6] = "&#x1EAA;";
            Code[84, 6] = "&#x1EAC;";
            Code[85, 6] = "É";
            Code[86, 6] = "È";
            Code[87, 6] = "&#x1EBA;";
            Code[88, 6] = "&#x1EBC;";
            Code[89, 6] = "&#x1EB8;";
            Code[90, 6] = "Ê";
            Code[91, 6] = "&#x1EBE;";
            Code[92, 6] = "&#x1EC0;";
            Code[93, 6] = "&#x1EC2;";
            Code[94, 6] = "&#x1EC4;";
            Code[95, 6] = "&#x1EC6;";
            Code[96, 6] = "Í";
            Code[97, 6] = "Ì";
            Code[98, 6] = "&#x1EC8;";
            Code[99, 6] = "&#x128;";
            Code[100, 6] = "&#x1ECA;";
            Code[101, 6] = "Ó";
            Code[102, 6] = "Ò";
            Code[103, 6] = "&#x1ECE;";
            Code[104, 6] = "Õ";
            Code[105, 6] = "&#x1ECC;";
            Code[106, 6] = "Ô";
            Code[107, 6] = "&#x1ED0;";
            Code[108, 6] = "&#x1ED2;";
            Code[109, 6] = "&#x1ED4;";
            Code[110, 6] = "&#x1ED6;";
            Code[111, 6] = "&#x1ED8;";
            Code[112, 6] = "&#x1A0;";
            Code[113, 6] = "&#x1EDA;";
            Code[114, 6] = "&#x1EDC;";
            Code[115, 6] = "&#x1EDE;";
            Code[116, 6] = "&#x1EE0;";
            Code[117, 6] = "&#x1EE2;";
            Code[118, 6] = "Ú";
            Code[119, 6] = "Ù";
            Code[120, 6] = "&#x1EE6;";
            Code[121, 6] = "&#x168;";
            Code[122, 6] = "&#x1EE4;";
            Code[123, 6] = "&#x1AF;";
            Code[124, 6] = "&#x1EE8;";
            Code[125, 6] = "&#x1EEA;";
            Code[126, 6] = "&#x1EEC;";
            Code[sbyte.MaxValue, 6] = "&#x1EEE;";
            Code[128, 6] = "&#x1EF0;";
            Code[129, 6] = "Ý";
            Code[130, 6] = "&#x1EF2;";
            Code[131, 6] = "&#x1EF6;";
            Code[132, 6] = "&#x1EF8;";
            Code[133, 6] = "&#x1EF4;";
            Code[134, 6] = "&#x110;";
        }

        private void MapCString()
        {
            Code[1, 6] = "á";
            Code[2, 6] = "à";
            Code[3, 6] = "ả";
            Code[4, 6] = "ã";
            Code[5, 6] = "ạ";
            Code[6, 6] = "ă";
            Code[7, 6] = "ắ";
            Code[8, 6] = "ằ";
            Code[9, 6] = "ẳ";
            Code[10, 6] = "ẵ";
            Code[11, 6] = "ặ";
            Code[12, 6] = "â";
            Code[13, 6] = "ấ";
            Code[14, 6] = "ầ";
            Code[15, 6] = "ẩ";
            Code[16, 6] = "ẫ";
            Code[17, 6] = "ậ";
            Code[18, 6] = "é";
            Code[19, 6] = "è";
            Code[20, 6] = "ẻ";
            Code[21, 6] = "ẽ";
            Code[22, 6] = "ẹ";
            Code[23, 6] = "ê";
            Code[24, 6] = "ế";
            Code[25, 6] = "ề";
            Code[26, 6] = "ể";
            Code[27, 6] = "ễ";
            Code[28, 6] = "ệ";
            Code[29, 6] = "í";
            Code[30, 6] = "ì";
            Code[31, 6] = "ỉ";
            Code[32, 6] = "ĩ";
            Code[33, 6] = "ị";
            Code[34, 6] = "ó";
            Code[35, 6] = "ò";
            Code[36, 6] = "ỏ";
            Code[37, 6] = "õ";
            Code[38, 6] = "ọ";
            Code[39, 6] = "ô";
            Code[40, 6] = "ố";
            Code[41, 6] = "ồ";
            Code[42, 6] = "ổ";
            Code[43, 6] = "ỗ";
            Code[44, 6] = "ộ";
            Code[45, 6] = "ơ";
            Code[46, 6] = "ớ";
            Code[47, 6] = "ờ";
            Code[48, 6] = "ở";
            Code[49, 6] = "ỡ";
            Code[50, 6] = "ợ";
            Code[51, 6] = "ú";
            Code[52, 6] = "ù";
            Code[53, 6] = "ủ";
            Code[54, 6] = "ũ";
            Code[55, 6] = "ụ";
            Code[56, 6] = "ư";
            Code[57, 6] = "ứ";
            Code[58, 6] = "ừ";
            Code[59, 6] = "ử";
            Code[60, 6] = "ữ";
            Code[61, 6] = "ự";
            Code[62, 6] = "ý";
            Code[63, 6] = "ỳ";
            Code[64, 6] = "ỷ";
            Code[65, 6] = "ỹ";
            Code[66, 6] = "ỵ";
            Code[67, 6] = "đ";
            Code[68, 6] = "Á";
            Code[69, 6] = "À";
            Code[70, 6] = "Ả";
            Code[71, 6] = "Ã";
            Code[72, 6] = "Ạ";
            Code[73, 6] = "Ă";
            Code[74, 6] = "Ắ";
            Code[75, 6] = "Ằ";
            Code[76, 6] = "Ẳ";
            Code[77, 6] = "Ẵ";
            Code[78, 6] = "Ặ";
            Code[79, 6] = "Â";
            Code[80, 6] = "Ấ";
            Code[81, 6] = "Ầ";
            Code[82, 6] = "Ẩ";
            Code[83, 6] = "Ẫ";
            Code[84, 6] = "Ậ";
            Code[85, 6] = "É";
            Code[86, 6] = "È";
            Code[87, 6] = "Ẻ";
            Code[88, 6] = "Ẽ";
            Code[89, 6] = "Ẹ";
            Code[90, 6] = "Ê";
            Code[91, 6] = "Ế";
            Code[92, 6] = "Ề";
            Code[93, 6] = "Ể";
            Code[94, 6] = "Ễ";
            Code[95, 6] = "Ệ";
            Code[96, 6] = "Í";
            Code[97, 6] = "Ì";
            Code[98, 6] = "Ỉ";
            Code[99, 6] = "Ĩ";
            Code[100, 6] = "Ị";
            Code[101, 6] = "Ó";
            Code[102, 6] = "Ò";
            Code[103, 6] = "Ỏ";
            Code[104, 6] = "Õ";
            Code[105, 6] = "Ọ";
            Code[106, 6] = "Ô";
            Code[107, 6] = "Ố";
            Code[108, 6] = "Ồ";
            Code[109, 6] = "Ổ";
            Code[110, 6] = "Ỗ";
            Code[111, 6] = "Ộ";
            Code[112, 6] = "Ơ";
            Code[113, 6] = "Ớ";
            Code[114, 6] = "Ờ";
            Code[115, 6] = "Ở";
            Code[116, 6] = "Ỡ";
            Code[117, 6] = "Ợ";
            Code[118, 6] = "Ú";
            Code[119, 6] = "Ù";
            Code[120, 6] = "Ủ";
            Code[121, 6] = "Ũ";
            Code[122, 6] = "Ụ";
            Code[123, 6] = "Ư";
            Code[124, 6] = "Ứ";
            Code[125, 6] = "Ừ";
            Code[126, 6] = "Ử";
            Code[sbyte.MaxValue, 6] = "Ữ";
            Code[128, 6] = "Ự";
            Code[129, 6] = "Ý";
            Code[130, 6] = "Ỳ";
            Code[131, 6] = "Ỷ";
            Code[132, 6] = "Ỹ";
            Code[133, 6] = "Ỵ";
            Code[134, 6] = "Đ";
        }
    }

    public enum FontCase
    {
        UpperCase,
        LowerCase,
        Normal
    }

    public enum FontIndex
    {
        iNotKnown = -1,
        iNCR = 0,
        iUTF = 1,
        iTCV = 2,
        iVNI = 3,
        iCP1258 = 4,
        iUTH = 5,
        iUNI = 6,
        iNOSIGN = 7,
        iVIQ = 8
    }
}