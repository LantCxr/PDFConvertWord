using System;
using Spire.Pdf;

namespace PDFConvertWord
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 转换

            Console.WriteLine("开始转换.....");
            PdfDocument doc = new PdfDocument();
            doc.LoadFromFile(@"F:\QQ下载文件\6秋培优.pdf");
            Console.WriteLine("转换期间比较漫长请耐心等待.....");
            doc.SaveToFile(@"F:\QQ下载文件\6秋培优.doc",
                FileFormat.DOC);
            Console.WriteLine("转换成功");
            System.Diagnostics.Process.Start(@"F:\QQ下载文件\6秋培优.doc");

            #endregion
        }
    }
}
