namespace task18._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            //int[] numbers = { 5, 7, 3, 2, 5, 1 };
            //GetFactorial(numbers);
            //foreach (var item in GetFactorial(numbers))
            //{
            //    Console.WriteLine(item);
            //}


            //task2
            //int[] nums = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(SmallestNumber(nums));

            //task3
            //string symbols = "kertenkele";
            //Console.WriteLine(LeastUsedSymbol(symbols));


            //task4
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(PrimeComplex(num));


            //task5
            //Console.WriteLine(PalindromeNumber(100,1000));

            //task6
            //string str = Console.ReadLine();
            //Console.WriteLine(MostNumber(str));


            //task7
            //Console.WriteLine(TriangleChecker(3,4,5));


            //task8
            //string text = Console.ReadLine();
            //Console.WriteLine(MiddleElement(text));


            //task9
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine(SumOfPrimeDigits(number));


            //task10
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(BiggestNumberGeneretor(num));


            //task11
            //int num=int.Parse(Console.ReadLine());
            //Console.WriteLine(IncreasingOrder(num));

            //task12
            //string num= Console.ReadLine();
            //Console.WriteLine(AllNumbersSame(num.ToString()));

            //ad soyad yazan
            //string name= Console.ReadLine();
            //string surname= Console.ReadLine(); 
            //NameSurname(name,surname);



            //2 ededin cemini tapan
            //int a=int.Parse(Console.ReadLine());
            //int b=int.Parse(Console.ReadLine());
            //Console.WriteLine(SumOfTwoNumbers(a,b));



            //3 ededin cemini tapan 
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //int z = int.Parse(Console.ReadLine());
            //Console.WriteLine(SumOfThreeNumbers(x,y,z));



            //a nin b den boyuk olub olmamasini yoxlayan
            //int a=int.Parse(Console.ReadLine());
            //int b =int.Parse(Console.ReadLine());
            //Console.WriteLine(Compare(a,b));



            //arrayin elementlerinin cemi
            //int[] array = { 1, 5, 3, 6, 3, 6 };
            //Console.WriteLine(SumArray(array));




            //stringde butun bsoluqlari silen 
            //string str=Console.ReadLine();
            //Console.WriteLine(GapRemover(str));



            //arrayin elementlerini cap eden
            //int[] numbers = { 1, 2, 3, 4 };
            //Console.WriteLine(PrintArray(numbers));



            //arraya element elave eden
            //int[] arr = { 1, 2, 3 };
            //int element = int.Parse(Console.ReadLine());
            //int[] newArr = AddElement(arr, element);
            //for (int i = 0;i<newArr.Length;i++)
            //{
            //    Console.WriteLine(newArr[i]);
            //}





        }
        //public static int[] GetFactorial(int[] arr )
        //{
        //    int[] result = new int[arr.Length];
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        int factorial = 1;
        //        for (int j = 1; j <= arr[i]; j++)
        //        {
        //            factorial *= j;
        //        }
        //        result[i] = factorial;
        //    }
        //    return result;
        //}


        //public static int SmallestNumber(int[] arr)
        //{
        //    int min = arr[0];
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] < min)
        //            min = arr[i];
        //    }
        //    return min;
        //}


        //public static string LeastUsedSymbol(string symbols)
        //{
        //    for (int i = 0; i < symbols.Length; i++)
        //    {
        //        int count = 0;
        //        for (int j = 0; j < symbols.Length; j++)
        //        {
        //            if (symbols[i] == symbols[j])
        //            {
        //                count++;
        //            }
        //        }
        //        if (count == 1)
        //        {
        //            return symbols[i].ToString();
        //        }      
        //    }
        //    return "No unique symbol";
        //}



        //public static string PrimeComplex(int num)
        //{
        //    if (num < 2)
        //        return "Neither Prime nor Complex"; 
        //    for (int i = 2; i <= Math.Sqrt(num); i++)
        //    {
        //        if (num % i == 0)
        //        {
        //            return "Complex"; 
        //        }
        //    }
        //    return "Prime"; 
        //}




        //public static int PalindromeNumber(int N, int M)
        //{
        //    for (int i = N; i <= M; i++)
        //    {
        //        int temp = 0;
        //        int elementcopy = i;
        //        int remainder;
        //        int num = i;
        //        while (num > 0)
        //        {
        //            remainder = num % 10;
        //            temp = temp * 10 + remainder;
        //            num /= 10;
        //        }
        //        if (elementcopy == temp)
        //        {
        //            Console.WriteLine(elementcopy);
        //        }
        //    }
        //    return 0;
        //}
        //



        //public static (string symbol,string min) MostNumber(string str)
        //{
        //    int min = 0;
        //    string symbol = str[0].ToString();
        //    for (int i = 0; i < str.Length; i++)
        //    {

        //        int count = 0;
        //        for (int j = 0; j < str.Length; j++)
        //        {
        //            if (str[i] == str[j])
        //                count++;
        //            if (count > min)
        //            {
        //                min = count;
        //                symbol = str[i].ToString();
        //            }
        //        }

        //    }
        //    return (symbol, min.ToString());
        //}


        //public static string TriangleChecker(int side1, int side2, int side3)
        //{
        //    if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
        //    {
        //        double a2 = Math.Pow(side1, 2);
        //        double b2 = Math.Pow(side2, 2);
        //        double c2 = Math.Pow(side3, 2);

        //        if (a2 == b2 + c2 || b2 == a2 + c2 || c2 == a2 + b2)
        //        {
        //            return "duzbucaqli ucbucaqdir";
        //        }
        //        if (side1 == side2 && side2 == side3)
        //        {
        //            return "beraberterefli ucbucaqdir";
        //        }
        //        else if (side1 == side2 || side1 == side3 || side2 == side3)
        //        {
        //            return "beraberyanli ucbucaqdir";
        //        }
        //        else
        //        {
        //            return "muxtelifterefli ucbucaqdir";
        //        }
        //    }
        //    else
        //    {
        //        return "ucbucaq yaratmaq mumkun deyil";
        //    }
        //}



        //public static string  MiddleElement(string text)
        //{
        //    if(text.Length%2==0)
        //    {
        //        return text[text.Length / 2 - 1].ToString() + text[text.Length / 2].ToString();

        //    }
        //    else
        //    {
        //        return text[text.Length / 2].ToString();
        //    }
        //}   



        //public static int SumOfPrimeDigits(int number)
        //{
        //    int sum = 0;
        //    while (number > 0)
        //    {
        //        int k = number % 10;
        //        number = number / 10;
        //        if (k > 1)
        //        {
        //            int i;
        //            for (i = 2; i < k; i++)
        //            {
        //                if (k % i == 0)
        //                {
        //                    break;
        //                }
        //            }
        //            if (i == k)
        //            {
        //                sum += k;
        //            }
        //        }
        //    }
        //    return sum;

        //}



        //public static int BiggestNumberGeneretor(int num)
        //{
        //    int[] arr = new int[3];
        //    int newnum = 0;
        //    for (int i = 0; i < 3; i++)
        //    {
        //        arr[i] = num % 10;
        //        num /= 10;
        //    }
        //    Array.Sort(arr);
        //    for (int j = arr.Length - 1; j >= 0; j--)
        //    {
        //        newnum = newnum * 10 + arr[j];
        //    }
        //    return newnum;

        //}




        //public static string IncreasingOrder(int num)
        //{
        //    int original = num;
        //    int temp = num;
        //    int count = 0;
        //    while (num > 0)
        //    {
        //        count++;
        //        num /= 10;
        //    }
        //    int[] numbers = new int[count];
        //    for (int j = 0; j < count; j++)
        //    {
        //        numbers[j] = temp % 10;
        //        temp /= 10;
        //    }
        //    Array.Sort(numbers);
        //    int num1 = 0;
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        num1 = num1 * 10 + numbers[i];
        //    }
        //    if (num1 == original)
        //    {
        //        return "yes";
        //    }
        //    else
        //    {
        //        return "no";
        //    }
        //}



        //public static string AllNumbersSame(string num)
        //{
        //    bool AllAreSame = true;
        //    for (int i = 1; i < num.Length; i++)
        //    {
        //        if (num[i] != num[0])
        //        {
        //            AllAreSame = false;
        //            break;
        //        }
        //    }
        //    if (!AllAreSame)
        //    {
        //        return "eyni deyil";
        //    }
        //    else
        //    {
        //        return "eynidir";
        //    }
        //}




        //public static void NameSurname(string name, string surname)
        //{
        //    Console.WriteLine($"Name: {name}, Surname: {surname}");
        //}


        //public static int SumOfTwoNumbers(int a, int b)
        //{
        //    return a + b;
        //}


        //public static int SumOfThreeNumbers(int x, int y, int z)
        //{
        //    return SumOfTwoNumbers(x, y) + z;
        //}


        //public static bool Compare(int a, int b)
        //{
        //    if (a > b) 
        //        return true;
        //    else
        //        return false;
        //}


        //public static int SumArray(int[] array)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        sum += array[i];
        //    }
        //    return sum;
        //}



        //public static string GapRemover(string str)
        //{
        //    string newstr = "";
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (str[i] != ' ')
        //            newstr += str[i];
        //    }
        //    return newstr;
        //}



        //public static string PrintArray(int[] numbers)
        //{
        //    string result = "";
        //    foreach (int n in numbers)
        //    {
        //        result += n + " ";
        //    }
        //    return result; 
        //}



        //public static int[] AddElement(int[] arr, int element)
        //{
        //    int[] newArr = new int[arr.Length + 1];
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        newArr[i] = arr[i];
        //    }
        //    newArr[newArr.Length - 1] = element;
        //    return newArr;
        //}


        
    }
}



