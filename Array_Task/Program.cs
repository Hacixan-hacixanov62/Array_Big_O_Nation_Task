// Homework


//Task:

//1.Verilmiş Arrayın elementlərinin cəmini ekrana çap edin

//2.Verilmiş int Arrayın ən böyük dəyərə sahib elementini tapın

//3.Verilmiş Arrayın ilk və son elementlərinin cəmini tapın

//4.Verilmiş müsbət tam n ədədinin 2-nin qüvvəti olub-olmamasını tapın

//5.Verilmiş n tam ədədinin neçə mərtəbəli olduğunu tapın. Məs: 23452, output: 5
//
//6.Verilmiş artan sıra ilə düzülmüş ədədlər siyahısındaki n ədədinin yerləşdiryi indexi tapan alqoritm

//(meselen 50 axtaririq egər siyahıda 50 ədədi yoxdursa -1 print olsun, varsa var olduğu index)




//1.Verilmiş Arrayın elementlərinin cəmini ekrana çap edin

//int[] arr = { 1, 2, 3, 4, 5, 1,100 };
//int sum = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//    sum += arr[i];
//}
//Console.WriteLine(sum);

//2.Verilmiş int Arrayın ən böyük dəyərə sahib elementini tapın

//int[] arr = { 1, 2, 3, 4, 12, 32,11 };

//int max = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] > max)
//    {
//        max = arr[i];
//    }
//}
//Console.WriteLine(max);


//3.Verilmiş Arrayın ilk və son elementlərinin cəmini tapın

//int[] arr = { 1, 12, 2, 23, 34, 4, 32 };

//int response = 0;

//for (int i = 0; i < arr[0]; i++)
//{
//    response += arr[0] + arr[arr.Length - 1];
//}
//Console.WriteLine("The sum of the first and last elements is: " + response);



//int[] array = { 1, 12, 2, 23, 34, 4, 32 };
//int sum = 0;

//if (array.Length > 0)
//{
//     sum = array[0] + array[array.Length - 1];
//    Console.WriteLine("The sum of the first and last elements is: " + sum);
//}
//else
//{
//    Console.WriteLine("The array is empty.");
//}


//4.Verilmiş müsbət tam n ədədinin 2-nin qüvvəti olub-olmamasını tapın

//int n = 32;

//if(n <= 0)
//{
//    Console.WriteLine("musbet eded daxil edin");
//}
//else
//{
//    bool isPower = true;

//    for (int i = 2; i < n; i*=2)
//    {
//        if (n % i != 0)
//        {
//            isPower = false;
//            break;
//        }          
//    }
//    if(isPower)
//    {
//        Console.WriteLine($"{n} Quvvetidir 2");
//    }
//    else
//    {
//        Console.WriteLine($"{n} Quvveti deyil 2");
//    }
//}


//int num = 10;
//while (num % 2 == 0)
//{
//    num /= 2;
//}
//if (num == 1)
//{
//    Console.WriteLine("Quvvetidir");
//}
//else
//{
//    Console.WriteLine("Quvveti deyil");
//}


//5.Verilmiş n tam ədədinin neçə mərtəbəli olduğunu tapın. Məs: 23452, output: 5
//

//int n = 10200;
//int count = 0;

//for (int i =10; n>0; )
//{
//    n = n / i;
//    count++;
//}
//Console.WriteLine("Ededin mertebesi: " + count + " - qederdir");


//6.Verilmiş artan sıra ilə düzülmüş ədədlər siyahısındaki n ədədinin yerləşdiryi indexi tapan alqoritm

//(meselen 50 axtaririq egər siyahıda 50 ədədi yoxdursa -1 print olsun, varsa var olduğu index)


//int[] arr = { 1, 2, 4, 5, 7, 8, 12, 14, 21 };
//bool LienarSearch(int[] arr, int result)
//{
//    for (int i = 0; i < arr.Length; i++)
//    {
//        return true;

//    }
//    return false;
//}
//Console.WriteLine(LienarSearch(arr,0));












