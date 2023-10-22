using System;

namespace circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入圓的半徑：");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("請輸入扇形的角度（度）：");
            double angleDegrees = Convert.ToDouble(Console.ReadLine());

            // 將角度轉換為弧度
            double angleRadians = angleDegrees * Math.PI / 180.0;

            // 計算圓的周長和圓面積
            double circleCircumference = 2 * Math.PI * radius;
            double circleArea = Math.PI * radius * radius;

            // 計算扇形周長和扇形面積
            double sectorCircumference = (2 * Math.PI * radius * angleRadians) / (2 * Math.PI);
            double sectorArea = (angleRadians / (2 * Math.PI)) * circleArea;

            // 印出結果，取小數點第2位
            Console.WriteLine("圓的周長：{0:F2}", circleCircumference);
            Console.WriteLine("圓的面積：{0:F2}", circleArea);
            Console.WriteLine("扇形的周長：{0:F2}", sectorCircumference);
            Console.WriteLine("扇形的面積：{0:F2}", sectorArea);
        }
    }
}