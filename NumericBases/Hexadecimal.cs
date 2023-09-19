namespace Calculator.bases
{
    class Hexadecimal
    {
        public static string[] Algarism = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
        public static string ToHex(string n)
        {
            int InputNumber = Int32.Parse(n);
            int nextDivison = InputNumber;
            string result = "";
            while (nextDivison > 0)
            {
                var hexNumber = nextDivison % 16;
                nextDivison /= 16;
                result = $"{Algarism[hexNumber]}{result}";
            }
            return result;
        }
        public static string FromHex(string hex)
        {
            string InputNumber = hex;
            int result = 0;
            var elementNumber = 0;
            for (int i = InputNumber.Length; i > 0; i--)
            {
                int dec = Array.IndexOf(Algarism, InputNumber[i - 1].ToString());
                int n = dec * (int)Math.Pow(16, elementNumber);
                result += n;
                elementNumber++;
            }
            return result.ToString();
        }
    }
}