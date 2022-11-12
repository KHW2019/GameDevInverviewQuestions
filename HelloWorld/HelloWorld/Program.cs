using System;
using System.Linq;
using System.Reflection;

namespace HelloWorld
{
    class Program
    {
        //public static string ReverseCase(string str)
        //{
        //    char[] reviseCase = new char[str.Length];
        //    for (int i = 0; i < reviseCase.Length; i++)
        //    {
        //        char c = str[i];
        //        if (char.IsLetter(c))
        //        {
        //            reviseCase[i] = char.IsUpper(c) ? char.ToLower(c)/*<-true*/ : char.ToUpper(c)/*<-false*/;
        //        }
        //        else
        //        {
        //            reviseCase[i] = c;
        //        }

        //    }
        //    return new string(reviseCase);
        //}

        //mutiples the num with the legnth and list it out the result base on the length
        //public static int[] ArrayOfMultiples(int num, int length) => Enumerable.Range(1, length).Select(x => x * num).ToArray();

        //public static int[] ArrayOfMultiples(int num, int length)
        //{
        //    int[] Mutiples = new int[length];
        //    for (int i = 0; i < length; i++)
        //    {
        //        Mutiples[i] = num * (i + 1);
        //    }
        //    return Mutiples;
        //}

        //public static int Solution(int[] A)
        //{
        //var positives = A.Where(x => x > 0).Distinct().OrderBy(x => x).ToArray();

        //if (positives.Count() == 0) return 1;

        //int prev = 0;

        //for (int i = 0; i < positives.Count(); i++)
        //{
        //    if (positives[i] != prev + 1)
        //    {
        //        return prev + 1;
        //    }
        //    prev = positives[i];
        //}

        //return positives.Last() + 1;

        //int N = 1;
        //Array.Sort(A);

        //for (int i = 0; i < A.Length; i++)
        //{
        //    if (A[i] == N)
        //        N++;
        //}
        //return N;
        //}

        //Shows the number of points inside the circle;
        //outer > inter
        //public int pointOfCircle(int inner, int outer, int[]Pointx, int[] PointY)
        //{

        //}

        //the max number N of the k value 
        public static int MaxNumber(int N, int K)
        {
            int Max = 999;
            int Min = 100;
            int InputNumber = N;
            int AddOnMax = K;

            string INTString = InputNumber.ToString();
            int[] INTChar = INTString.ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();

            if (!(InputNumber > Max) && !(InputNumber < Min) && !(AddOnMax >= 10) && !(AddOnMax <= 0))
            {
                /*use for loop to check is the AddOnMax Value Bigger then current Value*/
                for (int i = 0; i < INTChar.Count(); i++)
                {
                    var currentValue = INTChar[i];
                    if (currentValue + K > 9)
                    {
                        currentValue = 9;
                    }
                    else
                    {
                        currentValue = currentValue + K;
                    }
                    
                    Console.WriteLine(currentValue);
                }
            }
            else
            {
                if (InputNumber >= Max)
                {
                    Console.WriteLine("Out Of boundary the input number need to be inside the rage of 100 to 999");
                    Console.WriteLine("The Number is Too Big!");
                }
                else if(InputNumber < Min)
                {
                    Console.WriteLine("Out Of boundary the input number need to be inside the rage of 100 to 999");
                    Console.WriteLine("The Number is Too Small!");
                }
                else if(AddOnMax >= 10)
                {
                    Console.WriteLine("Out Of boundary the mutipler number need to be inside the rage of 1 to 10");
                    Console.WriteLine("The Number is Too Big!");
                }
                else
                {
                    Console.WriteLine("Out Of boundary the mutipler number need to be inside the rage of 1 to 10");
                    Console.WriteLine("The Number is Too Small!");
                }
            }

            return N;
        }





        public static void Main(string[] args)
        {
            //Attribute
            //Attribute a = new Attribute(0,"");
            //Attribute b = new Attribute(0,"");
            //a.number = 5;
            //a.Str = "Hello";
            //b.number = 10;
            //b.Str = "Hello";
            //Console.WriteLine(a.Str.Equals(b.Str));

            //Excution
            //var a = Execution.IndexOfCapitialsX("fWgSgEW");

            //Console.WriteLine(string.Join(",", a));

            //int[] A = { 1, 3, 5, 6, 7, 8 };

            //Console.WriteLine(Solution(A));

            //Console.WriteLine(ArrayOfMultiples(5,6));

            //Console.WriteLine(ReverseCase("HwearFDSAF"));
            Console.WriteLine(MaxNumber(648,4));
           
        }
    }

    public class Attribute
    {
        public int number { get; set; }
        public string Str { get; set; }

        public Attribute(int num, string str)
        {
            number = num;
            Str = str;
        }

        public static bool CheckEquality(object a, object b)
        {
            if (a == null || b == null)
            {
                return false;
            }
            return true;
        }
    }
    
    public class Execution
    {
        //public static int[] IndexOfCapitals(string str)
        //{
        //    put a string into a char array
        //    char[] CharArr = str.ToCharArray();
        //    int index = -1;

        //    loop the array
        //    for (int i = 0; i < CharArr.Length; i++)
        //    {
        //        get char from array
        //        char charInList = CharArr[i];

        //        if there is upper char in array
        //        if (char.IsUpper(charInList))
        //        {
        //            return the position of the upperchar into a new array
        //            ;
        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }
        //    return;

        //}

        public static int[] IndexOfCapitialsX(string str)
        {
            return str.Select((ch, index) =>
            (Char.IsLetter(ch) && Char.IsUpper(ch)) ? index : -1)
                .Where(num => num > -1).ToArray();
        }
    }

    
}

