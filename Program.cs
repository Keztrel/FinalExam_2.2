class Program {
    static void Main() {
        double b1, b2, b3;
        double payment;
        double balance1, balance2, balance3;
        double left = 0;

        Console.WriteLine("Enter the balance :");
        b1 = ReadPositiveRealNumber("B1");
        b2 = ReadPositiveRealNumber("B2");
        b3 = ReadPositiveRealNumber("B3");

        balance1 = b1;
        balance2 = b2;
        balance3 = b3;

        Console.WriteLine("Enter payment for each receipt :");
        while (true)
        {
            payment = ReadRealNumber("Payment");
            if (payment <= 0)
                break;

            if (balance1 >= payment)
            {
                balance1 -= payment;
            }
            else if (balance2 >= payment)
            {
                balance2 -= payment;
            }
            else if (balance3 >= payment)
            {
                balance3 -= payment;
            }
            else
            {
                left += payment;
            }
        }

        Console.WriteLine("Balance 1: {0}, Balance 2: {1}, Balance 3: {2}", balance1, balance2, balance3);
        Console.WriteLine("Left: {0}", left);
    }

    static double ReadPositiveRealNumber(string name) {
        double number;
        while (true)
        {
            Console.Write("{0}: ", name);
            if (double.TryParse(Console.ReadLine(), out number) && number > 0)
                return number;
        }
    }

    static double ReadRealNumber(string name) {
        double number;
        while (true)
        {
            Console.Write("{0}: ", name);
            if (double.TryParse(Console.ReadLine(), out number))
                return number;
        }
    }
}
