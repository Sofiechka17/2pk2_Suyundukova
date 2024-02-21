namespace consoleProject
{
    /*
     * ФИО студентов: Суюндукова София , Свиридова Наталия 2пк2 (вар 3)
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            BigWeight bw1 = new BigWeight("кровать", 70.70, 150.150, 15000.0);
            MiddleWeight mw1 = new MiddleWeight("монитор", 5.5, 15.18, 7000);
            LittleWeight lw1 = new LittleWeight("носки", 0.2, 0.3, 50);
            BigWeight bw2 = new BigWeight("шкаф", 60.59, 54.54, 9500.0);
            MiddleWeight mw2 = new MiddleWeight("ПК", 7.8, 10.08, 9000);
            LittleWeight lw2 = new LittleWeight("ручка", 0.1, 0.2, 15);
            BigWeight bw3 = new BigWeight("тумбочка", 40.00, 54.54, 3500.0);
            MiddleWeight mw3 = new MiddleWeight("тетрадка", 0.2, 0.9, 50);
            LittleWeight lw3 = new LittleWeight("кисточки", 0.1, 0.2, 40);
            BigWeight bw4 = new BigWeight("стул", 31.27, 45.54, 4500.0);
            MiddleWeight mw4 = new MiddleWeight("клавиатура", 1.5, 0.7, 2000);
            LittleWeight lw4 = new LittleWeight("карандаш", 0.1, 0.2, 10);
            Console.WriteLine($"bw1({bw1.Costs}) > bw2({bw2.Costs}) = {bw1 > bw2}");
            Console.WriteLine($"mw1({mw1.Costs}) < mw2({mw2.Costs}) = {mw1 < mw2}");
            Console.WriteLine($"lw1({lw1.Costs}) == lw2({lw2.Costs}) = {lw1 == lw2}");
            Console.WriteLine($"bw3({bw3.Costs}) != bw3({bw3.Costs}) = {bw3 != bw4}");
            Console.WriteLine($"bw1({bw1.Costs}) >= bw4({bw4.Costs}) = {bw1 >= bw4}");
            Console.WriteLine($"mw2({mw2.Costs}) <= mw3({mw3.Costs}) = {mw2 <= mw3}");
            Console.WriteLine($"bw4({bw4.Weight}) + bw1({bw1.Weight}) = {bw4 + bw1}");
            Console.WriteLine($"mw2({mw2.Weight}) - mw1({mw1.Weight}) = {mw2 - mw1}");
        }
    }
}