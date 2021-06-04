using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Collections;
using System.Net.Sockets;
using System.Net.Http;
using System.Xml;
using Newtonsoft.Json.Linq;
using System.Net;
using Power.Global;
using System.Drawing;

namespace Alroy.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            CommonTools ct = new CommonTools();

            #region 日期
            //DateTime dt = DateTime.Now;
            //Console.WriteLine("当前日期为" + dt);
            //Console.WriteLine("当前年为" + dt.Year);
            //Console.WriteLine("当前月为" + dt.Month);
            //Console.WriteLine("当前日为" + dt.Day);
            //Console.WriteLine("当前时为" + dt.Hour);
            //Console.WriteLine("当前分为" + dt.Minute);
            //Console.WriteLine("当前秒为" + dt.Second);
            //Console.WriteLine("格式化后为：" + dt.ToString("yyyy-MM-dd HH:mm ss"));
            //Console.WriteLine("星期英文为"+dt.DayOfWeek);
            //Console.WriteLine("星期数字为"+Convert.ToInt32(dt.DayOfWeek));
            //Console.WriteLine("日期加一天为"+ dt.AddDays(1));
            //Console.WriteLine("日期减一天为" + dt.AddDays(-1));

            //var time = "201704171012";
            //Console.WriteLine(time.Length);
            //DateTime dt1 = DateTime.ParseExact(time, "yyyyMMddHHmm", System.Globalization.CultureInfo.CurrentCulture);

            //string a = "2021/2/3 10:45:13";
            //string b = "2021/2/3 9:01:00";
            //TimeSpan tsDte =Convert.ToDateTime(a) - Convert.ToDateTime(b);
            //Console.WriteLine(tsDte.Hours);
            //Console.WriteLine(tsDte.Minutes);
            //Console.WriteLine(tsDte.ToString());
            //Console.ReadKey();

            #region str转日期
            //string dt = "2020/6/30 8:00:00";
            //Console.WriteLine(Convert.ToDateTime(dt).ToString());
            //Console.WriteLine(Convert.ToDateTime(dt).ToString("yyyy-MM-dd HH:mm:ss"));
            #endregion

            #region 上个月
            //string last = DateTime.Parse(DateTime.Now.ToString("yyyy-MM")).AddMonths(-1).ToString("yyyy-MM");
            #endregion

            #endregion

            #region 文件

            #region 文件转为base64
            //string filename = "input.rar";
            //string url = @"E:\Test\";
            //FileStream fileStream = new FileStream(url + filename, FileMode.Open);
            //byte[] byt = new byte[fileStream.Length];
            //fileStream.Read(byt, 0, byt.Length);
            //string base64Str = Convert.ToBase64String(byt);
            #endregion

            #region base64转换为文件
            //byte[] buffer = Convert.FromBase64String(base64Str);
            //FileStream fs = new FileStream(@"E:\Test\input\1.rar", FileMode.OpenOrCreate);
            //fs.Write(buffer, 0, buffer.Length);
            //fs.Close();
            //Console.WriteLine(base64Str);
            #endregion

            #region 修改文件名称和类型
            //for (int i = 1; i < 240; i++)
            //{
            //    string url = @"E:\blog\source\about\images\fulls\";

            //    string strNo = "";
            //    if (i < 10)
            //    {
            //        strNo = "0" + i.ToString();
            //    }
            //    else
            //    {
            //        strNo = i.ToString();
            //    }
            //    string fileName = "" + strNo + ".jpg";

            //    string newFileName = (240 - Convert.ToInt32(strNo)).ToString();
            //    if (Convert.ToInt32(newFileName) < 10)
            //    {
            //        newFileName = "0" + newFileName;
            //    }

            //    newFileName = "" + newFileName + ".jpg1";
            //    if (File.Exists(url + fileName))
            //    {
            //        File.Move(url + fileName, url + newFileName);
            //    }
            //}

            //for (int i = 1; i < 240; i++)
            //{
            //    string url = @"E:\blog\source\about\images\fulls\";

            //    string strNo = "";
            //    if (i < 10)
            //    {
            //        strNo = "0" + i.ToString();
            //    }
            //    else
            //    {
            //        strNo = i.ToString();
            //    }
            //    string fileName = "" + strNo + ".jpg1";
            //    string newFileName = "" + strNo + ".jpg";

            //    if (File.Exists(url + fileName))
            //    {
            //        File.Move(url + fileName, url + newFileName);
            //    }
            //}
            #endregion

            #region 隐藏与只读(针对已存在的文件)
            //FileInfo fi = new FileInfo(@"E:\SCP\1.md");
            //Console.WriteLine(fi.Attributes.ToString());
            //fi.Attributes = FileAttributes.Hidden | FileAttributes.ReadOnly;
            //Console.WriteLine(fi.Attributes.ToString());
            #endregion

            #region 创建新文件
            //FileStream fsWrite = new FileStream(@"E:\SCP\1.md", FileMode.Create, FileAccess.Write);
            #endregion

            #region 创建一个写入新文件的文件流
            ////将创建文件流对象的过程写在using当中，会自动的帮助我们释放流所占用的资源
            //using (FileStream fsWrite = new FileStream(@"E:\SCP\1.md", FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    string str = "123";
            //    byte[] buffer = Encoding.Default.GetBytes(str);
            //    fsWrite.Write(buffer, 0, buffer.Length);
            //}
            #endregion

            #region 获取文件真实类型
            //string path = @"C:\Users\Alroy\Pictures\Strangestone\01.jpg";
            //System.IO.FileStream fs = new System.IO.FileStream(path, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            //System.IO.BinaryReader r = new System.IO.BinaryReader(fs);
            //string bx = " ";
            //byte buffer;
            //try
            //{
            //    buffer = r.ReadByte();
            //    bx = buffer.ToString();
            //    buffer = r.ReadByte();
            //    bx += buffer.ToString();
            //}
            //catch (Exception exc)
            //{
            //    Console.WriteLine(exc.Message);
            //}
            //r.Close();
            //fs.Close();
            ////真实的文件类型
            //Console.WriteLine(bx);
            ////文件名，包括格式
            //Console.WriteLine(System.IO.Path.GetFileName(path));
            ////文件名， 不包括格式
            //Console.WriteLine(System.IO.Path.GetFileNameWithoutExtension(path));
            ////文件格式
            //Console.WriteLine(System.IO.Path.GetExtension(path));
            //Console.ReadLine();
            #endregion

            #region 文件真实类型编码

            //JPG = 255216,
            //GIF = 7173,
            //BMP = 6677,
            //PNG = 13780,
            //COM = 7790,
            //EXE = 7790,
            //DLL = 7790,
            //RAR = 8297,
            //ZIP = 8075,
            //XML = 6063,
            //HTML = 6033,
            //ASPX = 239187,
            //CS = 117115,
            //JS = 119105,
            //TXT = 210187,
            //SQL = 255254,
            //BAT = 64101,
            //BTSEED = 10056,
            //RDP = 255254,
            //PSD = 5666,
            //PDF = 3780,
            //CHM = 7384,
            //LOG = 70105,
            //REG = 8269,
            //HLP = 6395,
            //DOC = 208207,
            //XLS = 208207,
            //DOCX = 208207,
            //XLSX = 208207,

            #endregion

            #endregion

            #region 数字计算

            #region 取整取余
            //double cou = 35500;
            //double res1 = cou % 1000;
            //double res = Math.Round(cou / 1000);
            //Console.WriteLine(res1);
            //Console.WriteLine(res);
            #endregion

            #endregion

            #region Task
            //Task.Factory.StartNew(() => Console.WriteLine("Hello from a task!"));

            //var task = new Task(() => Console.Write("Hello"));
            //task.Start();


            //Task.Factory.StartNew(() => Console.Write("123"));
            #endregion

            #region GUID() 32位与36位互相转换
            //string str = "0019c481e7df46c896efc812133973f3";
            //Console.WriteLine(Guid.Parse(str).ToString("D"));

            //Guid guid = Guid.NewGuid();
            //Console.WriteLine(guid.ToString("N"));
            #endregion

            #region Dictionary
            //Dictionary<string, string> dict = new Dictionary<string, string>();
            //dict.Add("ID", 1.ToString());
            //dict.Add("CODE", 1.ToString() + ".0");
            //dict.Add("NAME", 1.ToString() + "名称");
            #endregion

            #region 拼接html - blog
            //for(int i=1;i<246;i++)
            //{
            //    string str = "";
            //    if (i<10)
            //    {
            //        str = "0" + i.ToString();
            //    }
            //    else
            //    {
            //        str = i.ToString();
            //    }

            //    Console.WriteLine("<article class=\"thumb\">");
            //    Console.WriteLine("     <a href=\"images/fulls/"+ str + ".jpg\" class=\"image\"><img src=\"images/fulls/"+str+".jpg\" alt=\"\" /></a>");
            //    Console.WriteLine("     <h2>"+str+"</h2>");
            //    Console.WriteLine("     <p>sidwb.</p>");
            //    Console.WriteLine("</article>");
            //}
            #endregion

            #region 验证-ValidatorHelper
            //string id = "62282619950306191X";
            //bool isIdCard = ValidatorHelper.IsIDCard(id);
            //Console.WriteLine(isIdCard);
            #endregion

            #region 拼json
            //string supplier = "supplier";
            //string inquiryHumanName = "inquiryHumanName";
            //string inquiryEndDate = DateTime.Now.ToString("yyyy-MM-dd");
            //string buyerName = "buyerName";
            //string helpMobile = "helpMobile";

            //Hashtable hs = new Hashtable();
            //hs.Add("supplier", supplier);
            //hs.Add("inquiryHumanName", inquiryHumanName);
            //hs.Add("inquiryEndDate", inquiryEndDate);
            //hs.Add("buyerName", buyerName);
            //hs.Add("helpMobile", helpMobile);

            //string strHs = JsonConvert.SerializeObject(hs);
            //Console.WriteLine(strHs);
            #endregion

            #region 实例

            #region QRCode-生成、转换大小、加入logo
            //QRcode qd = new QRcode();
            //Guid id = Guid.NewGuid();
            //string filePath = qd.Create("http://192.168.118.139:8080/", 10, id, @"E:\SCP\");
            //Console.WriteLine(filePath);
            //System.Drawing.Image img = System.Drawing.Image.FromFile(filePath);
            ////转换大小
            //Image newImg = QRcode.KiResizeImage(img, 200, 200, 0);
            //string newFilePath = @"E:\SCP\" + id + "-new.jpg";
            //newImg.Save(newFilePath);
            //Console.WriteLine(newFilePath);
            ////拼接图片
            //Image newTwoImage = QRcode.CombinImage(newImg, @"C:\Users\Alroy\Pictures\Camera Roll\753.jpg");
            //string newTwoFilePath = @"E:\SCP\" + id + "-newTwo.jpg";
            //newTwoImage.Save(newTwoFilePath);
            //Console.WriteLine(newTwoFilePath);
            #endregion

            #region httpClient预警信息
            //Console.WriteLine("输入城市名，回车结束");
            //string cityInput = Console.ReadLine();
            //var httpClient = new HttpClient();
            //var url = new Uri("http://www.weather.com.cn/data/alarm_xml/alarminfo.xml");
            //var response = httpClient.GetAsync(url).Result;
            //var data = response.Content.ReadAsStringAsync().Result;

            //XmlDocument doc = new XmlDocument();
            //doc.LoadXml(data);
            ////指定一个节点AlermInfo
            //XmlNode root = doc.SelectSingleNode("AlermInfo ");
            ////如果有子节点，获取节点下所有直接子节点
            //if (root.HasChildNodes)
            //{
            //    XmlNodeList childlist = root.ChildNodes;
            //    for (int i = 0; i < childlist.Count; i++)
            //    {
            //        //只显示有值的
            //        if (childlist[i].HasChildNodes)
            //        {
            //            //Console.WriteLine(i + "/" + childlist[i].Name + "/" + childlist[i].SelectNodes("Station").Count);
            //            for (int t = 0; t < childlist[i].SelectNodes("Station").Count; t++)
            //            {
            //                for (int s = 0; s < childlist[i].SelectNodes("Station")[t].Attributes.Count; s++)
            //                {
            //                    //添加城市判断
            //                    if (childlist[i].SelectNodes("Station")[t].Attributes[2].Value.ToString().Contains(cityInput))
            //                    {
            //                        //属性+值
            //                        Console.WriteLine(childlist[i].SelectNodes("Station")[t].Attributes[s].Name + ":" + childlist[i].SelectNodes("Station")[t].Attributes[s].Value);
            //                    }
            //                }
            //            }
            //            //XmlNodeList-有多少个城市预警
            //            //XmlNodeList xmlNodelost = childlist[i].SelectNodes("Station");
            //            //单一城市预警信息
            //            //XmlAttribute xmlElement = childlist[i].SelectNodes("Station")[0].Attributes;
            //        }

            //    }
            //}
            #endregion

            #region httpClient实时天气
            //var httpClient = new HttpClient();
            ////广州101280101，北京101010100
            //var url = new Uri("http://www.weather.com.cn/data/sk/101043700.html");
            //var response = httpClient.GetAsync(url).Result;
            //var data = response.Content.ReadAsStringAsync().Result;

            ////转为json
            //JObject jo = (JObject)JsonConvert.DeserializeObject(data);
            //string city = jo["weatherinfo"]["city"].ToString();
            //string cityid = jo["weatherinfo"]["cityid"].ToString();
            //string temp = jo["weatherinfo"]["temp"].ToString();
            //string WD = jo["weatherinfo"]["WD"].ToString();
            //string WS = jo["weatherinfo"]["WS"].ToString();
            //string SD = jo["weatherinfo"]["SD"].ToString();
            //string AP = jo["weatherinfo"]["AP"].ToString();
            //string njd = jo["weatherinfo"]["njd"].ToString();
            //string WSE = jo["weatherinfo"]["WSE"].ToString();
            //string time = jo["weatherinfo"]["time"].ToString();
            //string sm = jo["weatherinfo"]["sm"].ToString();
            //string isRadar = jo["weatherinfo"]["isRadar"].ToString();
            //string Radar = jo["weatherinfo"]["Radar"].ToString();

            //Console.WriteLine("城市:" + city);
            //Console.WriteLine("城市id:" + cityid);
            //Console.WriteLine("温度:" + temp);
            //Console.WriteLine("风向:" + WD);
            //Console.WriteLine("风速:" + WS);
            //Console.WriteLine("SD，是啥我也不知道:" + SD);
            //Console.WriteLine("帕斯卡，气压？:" + AP);
            //Console.WriteLine("njd:" + njd);
            //Console.WriteLine("WSE:" + WSE);
            //Console.WriteLine("当前时间:" + time);
            //Console.WriteLine("sm:" + sm);
            //Console.WriteLine("isRadar:" + isRadar);
            //Console.WriteLine("Radar:" + Radar);
            #endregion

            #region 天气预报
            //var httpClient = new HttpClient();
            ////广州101280101，北京101010100
            //var url = new Uri("http://www.weather.com.cn/data/cityinfo/101280101.html");
            //var response = httpClient.GetAsync(url).Result;
            //var data = response.Content.ReadAsStringAsync().Result;

            ////转为json
            //JObject jo = (JObject)JsonConvert.DeserializeObject(data);
            //string city = jo["weatherinfo"]["city"].ToString();
            //string cityid = jo["weatherinfo"]["cityid"].ToString();
            //string temp1 = jo["weatherinfo"]["temp1"].ToString();
            //string temp2 = jo["weatherinfo"]["temp2"].ToString();
            //string weather = jo["weatherinfo"]["weather"].ToString();
            //string img1 = jo["weatherinfo"]["img1"].ToString();
            //string img2 = jo["weatherinfo"]["img2"].ToString();
            //string ptime = jo["weatherinfo"]["ptime"].ToString();

            //Console.WriteLine("城市:" + city);
            //Console.WriteLine("城市id:" + cityid);
            //Console.WriteLine("温度:" + temp1);
            //Console.WriteLine("温度:" + temp2);
            //Console.WriteLine("天气:" + weather);
            //Console.WriteLine("img1:" + img1);
            //Console.WriteLine("img2:" + img2);
            //Console.WriteLine("ptime:" + ptime);
            #endregion

            #region  SCP-输入结束页，50条每个.md文件
            //Console.WriteLine("输入结束页");
            //int finishNum = Convert.ToInt32(Console.ReadLine());

            //int pageNum = finishNum / 50;
            //int restNum = finishNum % 50;
            //pageNum += 1;

            //for (int i = 0; i < pageNum; i++)
            //{
            //    int PageStart = i * 50 + 1;
            //    int PageEnd = (i + 1) * 50;
            //    if (i == pageNum - 1)
            //    {
            //        PageEnd = finishNum;
            //    }
            //    //拼分类及tags
            //    string title = "";
            //    title = "---" + "\r\n";
            //    title += "title: SCP " + PageStart + "-" + PageEnd + "" + "\r\n";
            //    title += "date: " + CommonTools.FormatDate(DateTime.Now, "1") + "" + "\r\n";
            //    title += "categories: \"SCP\"" + "\r\n";
            //    title += "tags:" + "\r\n";
            //    title += "- SCP" + "\r\n";
            //    title += "---";
            //    title += "\r\n\r\n\r\n";

            //    //返回内容页
            //    string Ret = "";

            //    for (int s = PageStart; s <= PageEnd; s++)
            //    {
            //        #region Request
            //        string num = ct.ChangeToThreeNum(Convert.ToString(s));

            //        HttpClient hc = new HttpClient();
            //        var url = new Uri("http://scp-wiki-cn.wikidot.com/scp-" + num + "");

            //        string data = string.Empty;
            //        try
            //        {
            //            var response = hc.GetAsync(url).Result;
            //            data = response.Content.ReadAsStringAsync().Result.ToString();
            //        }
            //        catch
            //        {
            //            Console.WriteLine("/" + num + "请求超时/Failure");
            //            continue;
            //        }

            //        string startStr = "<p><strong>项目编号";
            //        string endStr = "<div class=\"footer-wikiwalk-nav\">";

            //        Ret += "\r\n" + "#### SCP-" + s + "" + "\r\n";

            //        try
            //        {
            //            Ret += CommonTools.InterceptStr(data, startStr, endStr);
            //            Ret = Ret.Replace("<h2>", "");
            //            Ret = Ret.Replace("</h2>", "");
            //            Ret = Ret.Substring(0, Ret.Length - 33);
            //        }
            //        catch
            //        {
            //            Console.WriteLine("/" + num + "写入失败/Failure");
            //            Ret += "\r\n" + "------" + "\r\n";
            //            continue;
            //        }
            //        Console.WriteLine("/" + num + "写入成功/Success");
            //        Ret += "\r\n" + "------" + "\r\n";
            //        #endregion
            //    }
            //    Ret = title + Ret;
            //    //生成文件
            //    using (FileStream fsWrite = new FileStream(@"E:\SCP\SCP " + PageStart + "-" + PageEnd + ".md", FileMode.OpenOrCreate, FileAccess.Write))
            //    {
            //        //增量写入
            //        //fsWrite.Position = fsWrite.Length;
            //        Byte[] info = new UTF8Encoding(true).GetBytes(Ret);
            //        fsWrite.Write(info, 0, info.Length);
            //    }
            //}
            #endregion

            #region 通过url下载图片
            //var url = new Uri("http://www.xiuren.org");
            //var url1 = new Uri("http://www.xiuren.org/tag/%E7%99%BD%E8%99%8E.html");
            //var url2 = new Uri("http://www.xiuren.org/XiuRen-N02345.html");
            //string html = CommonTools.RetHtml(url2);
            //int count = html.Split("photoThum").Length - 1;
            ////Console.WriteLine(html);
            //Console.WriteLine("获取到" + count + "张图片");
            //for (int i = 1; i <= count; i++)
            //{
            //    string sequ = CommonTools.ChangeToSevralNum(i, 4);
            //    //var webUrl = url2 + "/" + sequ + ".jpg";
            //    var webUrl = "http://www.xiuren.org/xiuren2/XiuRen-N02345" + "/" + sequ + ".jpg";
            //    Console.WriteLine(webUrl);

            //    #region 下载部分
            //    string LocalPath = @"E:\Reptile\";
            //    string fileName = DateTime.Now.ToString("MM.dd.HH.mm") + sequ + ".jpg";
            //    //http://www.xiuren.org/XiuRen-N02345.html/0001.jpg
            //    //http://www.xiuren.org/xiuren2/XiuRen-N02345/0001.jpg

            //    if (File.Exists(LocalPath + fileName))
            //    {
            //        File.Delete(LocalPath + fileName);
            //    }
            //    if (Directory.Exists(LocalPath) == false)
            //    {
            //        Directory.CreateDirectory(LocalPath);
            //    }

            //    var client = new WebClient();
            //    client.DownloadFile(webUrl, LocalPath + fileName);
            //    #endregion
            //}



            //string fileName = "1.jpg";
            //string LocalPath = @"E:\Reptile\";
            //string WebUrl = "http://www.xiuren.org/xiuren2/XiuRen-N02345/0001.jpg";

            //if (File.Exists(LocalPath + fileName))
            //{
            //    File.Delete(LocalPath + fileName);
            //}
            //if (Directory.Exists(LocalPath) == false)
            //{
            //    Directory.CreateDirectory(LocalPath);
            //}

            //var client = new WebClient();
            //client.DownloadFile(WebUrl, LocalPath + fileName);

            //Console.ReadKey();
            #endregion

            #endregion

            #region arrayList
            //string a = "7b6a9400-7c90-11eb-a547-00163e08851a,7c165fd1-7c90-11eb-a547-00163e08851a,74cb3ff6-7c90-11eb-a547-00163e08851a";
            //List<string> list = new List<string>(a.Split(','));
            //Console.WriteLine(list.Count);
            //foreach(var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();
            #endregion


            #region AngleSharp
            //AngelSharpModel.GetH5Async("http://www.xiuren.org/XiuRen-N02345.html");

            //AngelSharpModel.Method1();
            //AngelSharpModel.Method2();

            //AngelSharpModel.callMethod();


            //Console.ReadKey();
            #endregion

            //string[] CbfsList = { };
            //string text = "脱硫,脱硝,除尘,水务,氢能,光热,固废,环保其他类";
            //text = text.Replace("脱硫", "01");
            //text = text.Replace("脱硝", "02");
            //text = text.Replace("除尘", "03");
            //text = text.Replace("水务", "04");
            //text = text.Replace("氢能", "05");
            //text = text.Replace("光热", "06");
            //text = text.Replace("固废", "07");
            //text = text.Replace("环保其他类", "08");
            //Console.WriteLine(text);

            //ArrayList al = new ArrayList();
            //al.Add(3);
            //al.Add(14);
            //al.Add(27);
            //Console.WriteLine(Convert.ToInt32(al[0]));

            //string str = "20比索";
            //string str1 = "123.990";

            //double d1 = 0;
            //double.TryParse(str, out d1);

            //double d2 = 0;
            //double.TryParse(str1, out d2);

            //Hashtable hs = new Hashtable();
            //hs.Add("Id", "123421");
            //hs.Add("Name", "2222");



            string a = "71de620d-7c90-11eb-a547-00163e08851a,714efc24-7c90-11eb-a547-00163e08851a";
            string[] str = a.Split(",");
            Console.WriteLine(str.Length);
            Console.WriteLine(str[0]);
            Console.ReadKey();

        }


    }
}
