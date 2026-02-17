namespace FirstApp
{
    public class Logic
    {
        public static string Convert(int cop)
        {
            string text;
            string normrub;
            string normcop;

            if (cop % 100 > 4)
            {
                normcop = "копеек";
            }
            else if (cop == 1)
            {
                normcop = "копейка";
            }
            else
            {
                normcop = "копейки";
            }

            if (cop >= 100)
            {

                int rub = cop / 100;
                int ost = cop % 100;

                if (rub % 100 == 1)
                {
                    normrub = "рубль";
                }
                else if (rub % 100 < 5)
                {
                    normrub = "рубля";
                }
                else
                {
                    normrub = "рублей";
                }

                if (ost > 0)
                {
                    text = rub + " " + normrub + "  " + ost + " " + normcop;
                }
                else
                {
                    text = rub + " " + normrub;
                }
            }
            else
            {
                text = cop + " " + normcop;
            }
            return text;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            int cop = int.Parse(Console.ReadLine());

            string text = Logic.Convert(cop);

            Console.WriteLine(text);
        }
    }
}