namespace Calculator.bases
{
    class Octal
    {
        public static string[] Algarism = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
        public static string To(string n)
        {
            int InputNumber = Int32.Parse(n);
            int nextDivison = InputNumber;
            string result = "";
            while (nextDivison > 0)
            {
                var Number = nextDivison % 8;
                nextDivison /= 8;
                result = $"{Algarism[Number]}{result}";
            }
            return result;
        }
        public static string From(string n)
        {
            string InputNumber = n;
            int result = 0;
            var elementNumber = 0;
            for (int i = InputNumber.Length; i > 0; i--)
            {
                int dec = Array.IndexOf(Algarism, InputNumber[i - 1].ToString());
                int number = dec * (int)Math.Pow(8, elementNumber);
                result += number;
                elementNumber++;
            }
            return result.ToString();
        }
    }
}