namespace OOPInheritance
{
    public class Program
    {
        public static void Main()
        {
            File[] files = new File[] { new ExcelFile("Paycheck", "Excel 2019"), new PdfFile("Book Abc", false), new PdfFile("Declaratie pe proprie raspundere", true) };
            foreach (File file in files)
            {
                file.Open();
            }

            ExcelFile xslxFile = files[0] as ExcelFile;
            xslxFile.PerformCalculation("A2 = B2 + C2");
            PdfFile pdfFile = files[1] as PdfFile;
            pdfFile.AttemptEdit();
        }
    }
}
