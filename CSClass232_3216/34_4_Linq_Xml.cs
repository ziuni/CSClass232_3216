using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqEx
{
    class Linq_Xml
    {
        //xml과 Linq 결합!

        //XML - eXtensible Markup Language 확장가능한 마크업 언어
        //<br>같은 닫지 않은 태그는 문법 오류

        //static void Main(string[] args)
        //{
        //    //웹에서 XML가져오기
        //    string url = "http://www.kma.go.kr/wid/quertDFSRSS.jsp?zone=1150061500";
        //    XElement xelement = XElement.Load(url);
        //    Console.WriteLine(xelement);

        //    //XML 파싱
        //    var xmlQuery = from item in xelement.Descendants("data") select item;
        //    foreach (var item in xmlQuery)
        //    //{ Console.WriteLine(item);}
        //    {
        //        Console.Write(item.Element("hour").Value + "\t");
        //        Console.Write(item.Element("day").Value + "\t");
        //        Console.Write(item.Element("temp").Value + "\t");
        //        Console.Write(item.Element("wdKor").Value + "\t");
        //        Console.Write(item.Element("wfKor").Value + "\t");
        //        Console.Write(item.Element("tmn").Value + "\t");
        //        Console.Write(item.Element("tmx").Value + "\t");
        //        Console.WriteLine();
        //    }

        //    //개량
        //    string url2 = "http://www.kma.go.kr/wid/quertDFSRSS.jsp?zone=1150061500";
        //    XElement xelement2 = XElement.Load(url2);
        //    Console.WriteLine(xelement2);

        //    //XML 파싱
        //    var xmlQuery2 = from item in xelement2.Descendants("data")
        //                    select new
        //                    {//익명객체 사용
        //                        Hour = item.Element("hour").Value,
        //                        Day = item.Element("day").Value,
        //                        Temp = item.Element("temp").Value,
        //                        WdKor = item.Element("wdKor").Value,
        //                        WfKor = item.Element("wfKor").Value,
        //                        Tmn = item.Element("tmn").Value,
        //                        Tmx = item.Element("tmx").Value
        //                    };
        //    foreach (var item in xmlQuery2)
        //    {
        //        Console.Write(item.Hour + "\t");
        //        Console.Write(item.Day + "\t");
        //        Console.Write(item.Temp + "\t");
        //        Console.Write(item.WdKor + "\t");
        //        Console.Write(item.WfKor + "\t");
        //        Console.Write(item.Tmn + "\t");
        //        Console.Write(item.Tmx + "\t");
        //        Console.WriteLine();
        //    }

        //    //속성값 추출?
        //    //foreach (var item in xmlQuery2)
        //    //{
        //    //    Console.Write(item.Attribute("Hour").Value + "\t");
        //    //    Console.Write(item.Attribute("Day").Value + "\t");
        //    //}
        //}
    }
}
