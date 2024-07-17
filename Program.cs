internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("chương trình giải phương trình bậc 1");
        double a, b;

        Console.Write(" Nhập số a: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write(" Nhập số b: ");
        b = Convert.ToDouble(Console.ReadLine());

        string ketqua = GiaiPTbac1_cach1(a,b);
        Console.WriteLine(ketqua);

        GiaiPTbac1_cach2(a, b);
    }
    /// <summary>
    /// Hàm giải phương trình bậc 1
    /// </summary>
    /// <param name="a">Đổi số a kiểu double</param>
    /// <param name="b">Đổi số b kiểu double</param>
    /// <returnsChuỗi kêt quả</returns>
        private static string GiaiPTbac1_cach1(double a, double b)
        {
            if (a == 0)
            {
                 if (b == 0) return "Phương trình vô số nghiệm";
                 else return "Phương trình vô nghiệm";
             }
        else return "Phương trình có 1 nghiệm là" + (-b / a).ToString();
    }
    private static void GiaiPTbac1_cach2(double a, double b)
    {
        if (a == 0)
        {
            if (b == 0) Console.WriteLine("Phương trình vô số nghiệm");
            else Console.WriteLine ("Phương trình vô nghiệm");
        }
        else Console.WriteLine ("Phương trình có 1 nghiệm là" + (-b / a).ToString());
    }
}
