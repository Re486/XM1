using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Threading;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = DateTime.Now.ToString("yyMMdd");
            //string s1 = DateTime.Now.ToString("yMMdd");
            //string sCustomer = Regex.Replace("scp01234", @"[^\d]*", "");
            //sCustomer = sCustomer.PadLeft(6, '0');
            DateTime oDateTime = new DateTime(2019, 3, 4);
            DateTimeOffset oDateTimeOffset = new DateTimeOffset(oDateTime);
            var aaa = (DateTimeOffset.Now - oDateTimeOffset).Days;

            string s111 = "12332154ab";
            string sNormalSkuCode = s111.Substring(0, s111.Length - 2);
            //int a = 0;
            //for (int i = 0; i < 100; i++)
            //{
            //    a = i;
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(a);
            //List<modelc> os = new List<modelc>();

            //os.Add(new modelc()
            //{
            //    Date1 = new DateTime(2018, 6, 27),
            //    ID = 1,
            //    Name = "a",
            //    Value =1

            //});
            //os.Add(new modelc()
            //{
            //    Date1 = new DateTime(2018, 6, 27),
            //    ID = 2,
            //    Name = "b",
            //    Value = 1
            //});
            //os.Add(new modelc()
            //{
            //    Date1 = new DateTime(2018, 5, 27),
            //    ID = 1,
            //    Name = "c",
            //    Value = 1
            //});
            //os.Add(new modelc()
            //{
            //    Date1 = new DateTime(2018, 6, 27),
            //    ID = 2,
            //    Name = "d",
            //    Value = 1
            //});
            //var bb = (from o in os
            //          group o by new
            //          {
            //              date = o.sDate1,
            //              id = o.ID
            //          }
            //          into w
            //          select new {
            //              v1 = w.Key.date,
            //              v2 = w.Key.id
            //          });
            //var bac = (from o in os
            //          group o by new
            //          {
            //              date = o.sDate1,
            //              id = o.ID
            //          } into g
            //          select g);
            //int a=1, b=2, c=3, d=4;
            //Console.WriteLine(a + b + c + d);

            //List<int> inta = new List<int>();
            //foreach (var ab in bac)
            //{
            //    var aaaaaa = ab;
            //    int int1 = ab.Select(o => o.Value).Sum();
            //    foreach (var ab1 in ab)
            //    {

            //    }
            //}
            //var aaa = os.GroupBy(o => new { date = o.sDate1, id = o.ID });

            //if (true)
            //{
            //    int abc = 111;
            //}
            ////foreach (int i in Power(2, 8, ""))
            ////{
            ////    Console.Write("{0} ", i);
            ////}
            //oFunc += aint;
            //int na = 1; Intadd(na);
            //Console.WriteLine("na" + na);


            ////V1 v1 = new V1() {Gid = Guid.NewGuid(),s1="1111",s3="3333"};
            ////string s = "";
            ////s = v1.ToString();
            ////V1 v2 = new V1();
            ////B1 b1 = new B1() { s1 = s };
            ////b1.Create(v2);
            ////Console.ReadKey();

            //aa11();

            //People p = new People() { ID = 100, Name = "liu", Province = "广东", Age = 100 };
            //People p1 = p;
            //People p2 = p1;
            //IEnumerable<People> ListPeople = new List<People>()
            //{
            //    p,
            //    p1,
            //    p2,
            //    new People(){ID=0,Name="li",Province="湖北",Age=20},
            //    new People(){ID=0,Name="li",Province="湖北",Age=20},
            //    new People(){ID=1,Name="li",Province="湖北",Age=20},
            //    new People(){ID=1,Name="li",Province="湖南",Age=20},
            //    new People(){ID=2,Name="li",Province="湖北",Age=20},
            //    new People(){ID=3,Name="li",Province="湖南",Age=21},
            //    new People(){ID=4,Name="li",Province="湖北",Age=22},
            //};
            //ListPeople.Distinct(new PeopleCompareByID()).ToList().ForEach(x => Console.WriteLine(x));
            //DateTime oD1 = new DateTime(2017, 5, 14);
            //DateTime oD2 = new DateTime(2018, 1, 22);
            //DateTime oD3 = new DateTime(2017, 5, 23);
            //int aa = oD2.Subtract(oD1).Days;
            //int aa2 = oD2.Subtract(oD3).Days;
            //string s1 = "SkuCode={SkuCode}#SupplierTrackLot={SupplierTrackLot}#Quantity={Quantity}#MesNo={MesNo}#FactoryCode={FactoryCode}#SupplierCode={SupplierCode}#Align={Align}#RefDocCode={RefDocCode}#RefDocItem={RefDocItem}#BatchNo={BatchNo}";

            //Regex reg = new Regex("#Quantity=(.+?)#");
            //string sNewQuantity = "#Quantity=100#";
            //string modified = reg.Replace(s1, "#Quantity=100#");

            //string s122 = Regex.Replace(s1, "#Quantity=(.+?)#", sNewQuantity);

            //var aaa111 = Regex.Match(s1,"#Quantity=(.+?)#");


            //Regex reg1 = new Regex("SkuCode=(.+)#");

            //Match match1 = reg.Match(s1);

            //string value1 = match1.Groups[1].Value;


            //var aaa = Regex.Match(s1, "SkuCode=(.+)#");

            //decimal o1 = 70000;
            //decimal o2 = 0.05m/365;
            //int day = 40*365;
            //for (int i = 1; i <= day; i++)
            //{
            //    o1 = o1 * o2 + o1;
            //}
            //Console.WriteLine(o1);
            //decimal o3 = 70000;

            //decimal o4 = o3 * o2 * day + o3;
            //Console.WriteLine(o4);
            //string sDate = DateTime.Now.ToString("yyMMdd");
            //char[] s =new char[1];
            //s[0] = ':';
            //char a = ';';
            //string[] strList1 = "abccc:ab:adfdf:asdfasdf".Split(a, 2);
            //string[] strList2 = "abccc:ab:adfdf:asdfasdf".Split(s,2);
            var tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;
            var task = Task.Factory.StartNew(() =>
            {
                for (var i = 0; i < 1000; i++)
                {
                    System.Threading.Thread.Sleep(1000);
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Abort mission success!");
                        return;
                    }
                }
            }, token);
            token.Register(() =>
            {
                Console.WriteLine("Canceled");
            });
            Console.WriteLine("Press enter to cancel task...");
            Console.ReadKey();
            tokenSource.Cancel();
            Console.ReadKey();
        }

        //public static void UseParams2(char[] list,int i)
        //{
        //    for (int i = 0; i < list.Length; i++)
        //    {
        //        Console.Write(list[i] + " ");
        //    }
        //    Console.WriteLine();
        //}

        public static string aa11()
        {
            List<string> lists = new List<string>();
            lists.Add("asdfasdfasdfasdaaaaaaaaaaasdfasdfbbbbbbbbbbbasdfascccccccccccasdfasd");
            lists.Add("asdfasdfasdfasdfasdfasdcccccccccccsdfasdfasdfasdfasdfasd");
            lists.Add("a:bbbbbbbbbbb,fasdfasdfasdfasdcccccccccccsdfasdfasdfasdfasdfasd");
            //Dictionary<string, object> InsideObject = new Dictionary<string, object>();
            //InsideObject["bbb"] = "bbbbbbbbbbb";
            //InsideObject["ccc"] = "ccccccccccc";
            //InsideObject["aaa"] = "aaaaaaaaaaa";
            //var a = InsideObject.OrderBy(o => o.Key).ToDictionary(o => o.Key, p => p.Value.ToString());
            //string str = "";
            //foreach(var aitem in a.Values)
            //{
            //    str += " " + aitem;

            //}
            //var listsss = lists.Where(o => o.Contains(str)).ToList();
            //var aaa = a.Values;
            var aaa111 = (from o in lists
                          where o.Contains("%sdfa%ccccsdfasd%")
                          select o).First();
            //return InsideObject.Values.ToString();
            return "";
        }

        public static void Intadd(int nI)
        {
            
            nI++;
            Console.WriteLine("Intadd" + nI);
        }

        public static int aint()
        {
            return 1;
        }
        public static IEnumerable<int> Power(int number, int exponent, string s)
        {
            int result = 1;
            yield return result;

            for (int i = 0; i < exponent; i++)
            {
                result = result * number;
                yield return result;
            }
            yield return 3;
            yield return 4;
            yield return 5;
        }

        public static int aint111()
        {
            return 1;
        }
    }
    public class PeopleCompareByID : IEqualityComparer<People>
    {
        public bool Equals(People x, People y)
        {
            if (x == null || y == null)
                return false;
            if (x.ID == y.ID)
                return true;
            else
                return false;
        }

        public int GetHashCode(People obj)
        {
            if (obj == null)
                return 0;
            else
                return obj.ID.GetHashCode();
        }
    }

    public class V1 {
        public Guid Gid;
        public string s1;
        public string s2;
        public string s3;
        public string s4;
        public override string ToString()
        {
            string sReturnValue = "";
            foreach (var oItem in this.GetType().GetFields())
            {
                if (oItem.GetValue(this) != null)
                {
                    sReturnValue += oItem.Name + ":" + oItem.GetValue(this)+";";
                }
            }
            return sReturnValue;
        }

        public string ToString(char cSplit1 = ':', char cSplit2 = ';')
        {
            string sReturnValue = "";
            foreach (var oItem in this.GetType().GetFields())
            {
                if (oItem.GetValue(this) != null)
                {
                    sReturnValue += oItem.Name + ":" + oItem.GetValue(this) + ";";
                }
            }
            return sReturnValue;
        }
        
    }

    public class B1
    {
        public string s1;
        public void Create(object oObj) {
            Type type = oObj.GetType();
            string[] oS1 = s1.Split(';');
            foreach (string oItem in oS1)
            {
                string[] oS2 = oItem.Split(':');
                System.Reflection.FieldInfo oFieldInfo = oObj.GetType().GetField(oS2[0]);
                Type oFIT = oFieldInfo.FieldType;
                var oFI1 = Activator.CreateInstance(oFIT, oS2[2]);
                oObj.GetType().GetField(oS2[0]).SetValue(oObj, oFI1);
            }
        }
    }
    public class modelc {
        public DateTime Date1 { get; set; }
        public string sDate1 {
            get { return string.Format("{0:Y}", Date1); }
        }
        public DateTime Date2 { get; set; }
        public string sDate2{
            get { return string.Format("{0:Y}", Date2); }
        }
        public int ID { get; set; }

        public string Name { get; set; }
        public int Value { get; set; }

    }

    public class People
    {
        public int ID { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 所属省份
        /// </summary>
        public string Province { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }
        public override string ToString()
        {
            return string.Format("ID:{0} Name:{1} Province:{2} Age:{3}", ID, Name, Province, Age);
        }
    }
}
