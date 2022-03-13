using System;
using System.Text;

namespace String_StringBuilder_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //int c = a;
            //c = 15;
            //Console.WriteLine(a);

            //string word = "lorem";
            //string word2 = word;
            //word2 = "ipsum";
            ////Console.WriteLine(word);
            //string word3 = "ipsum";
            ////Console.WriteLine(word2 == word3);
            ////int[] arr = {1,2,3};
            ////int[] arr2 = {1,2,3};
            ////Console.WriteLine(arr==arr2);
            //string mm = ""; //empty
            //string aa = "   ";//white space

            //string a = "   Word Salam   ";
            ////Console.WriteLine(a.Length);
            ////Console.WriteLine(a.ToString());
            ////Console.WriteLine(a.ToUpper());// Butun stringi boyuk herflere cevirir.
            ////Console.WriteLine(a.ToLower());// Butun stringi kicik herflere cevirir.
            //Console.WriteLine(a.ToLower().Equals("word".ToLower()));//konkret deyeri muqayise edir 
            //Console.WriteLine(a.Trim());//evvelderki ve sondaki boshluqlari silir.
            //Console.WriteLine(a.TrimStart());
            //Console.WriteLine(a.TrimEnd());
            //Console.WriteLine(a.Contains('a'));icinde hansisa deyerin olub oolmadigini yoxlayir
            //Console.WriteLine(a.ToLower().Contains("w".ToLower()));/* icinde hansisa deyerin olub oolmadigini yoxlayir*/
            //Console.WriteLine(a.Replace("r", "o"));//birinci parametr deyishilecek simvol ve ya soz ikinci ise elave olunacaq 
            //Console.WriteLine(a.IndexOf("r"));//indexin simvolun index nomresini gosterir
            //Console.WriteLine(a.IndexOf("a"));// soldan sayir ilk a ni goturur
            //Console.WriteLine(a.LastIndexOf("a")); sagdan sola saymaga bashlayir ve ilk a ni goturur
            //Console.WriteLine(a.Remove(0,3)); // 0-dan bashla saga dogru 3 denesini sil
            //string str = "";
            //Console.WriteLine(String.IsNullOrEmpty(str)); //True

            //string asd = " ";
            //Console.WriteLine(String.IsNullOrWhiteSpace(asd)); //True



            //string soz = "Salam";
            //Console.WriteLine(ReverseWord(soz));


            //----------------------------------------------------------------------------//

            //Array methods

            //string[] arr = { "lorem", "dolor", "sit", "amet" };

            int[] arr = { 1, -2, 3, -4, 5, 6, 7 };

            //Console.WriteLine(String.Join("-",arr)); //arrayi stringe cevirir ve biz orda seperator veririk ki ne ile ayi meselen "-" ile

            //string aaa = "Hello World";
            //string[] words = aaa.Split(' ');
            //foreach (string word in words)
            //{
            //    Console.WriteLine(word);
            //}

            //Array.Sort(arr);// azdan coxa dogru siralayir
            //Array.Reverse(arr); // arrayi tersine cevirir 0 ci index sona kecir.
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] arr3 = new int[3]; // ancaq 3 dene element ala biler 
            //arr3[0] = 1;
            //arr3[1] = 2;
            //arr3[2] = 3;
            //foreach (int i in arr3)
            //{
            //    Console.WriteLine(i);
            //}
            ////arraylar fixe size-dir
            //Array.Resize(ref arr3, 4);

        //    int[] nums = { 1, 2, 3, };

        //    int[] result = Resize(ref nums,4);
        //    result[3] = 6;
        //    foreach (int item in result)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //static int[]  Resize(ref int[] arr, int count)
        //{

        //    int[] newArr = new int[count];
        //    for(int i=0; i<arr.Length; i++)
        //    {
        //        newArr[i] = arr[i];
        //    }
        //    return newArr;



        //}


        //static StringBuilder ReverseWord(string soz)
        //{
        //    StringBuilder word = new StringBuilder();
        //    for (int i = soz.Length - 1; i >= 0; i--)
        //    {
        //        word.Append(soz[i]);
        //    }
        //    return word;


            //string word = "";
            //for (int i = soz.Length - 1; i >= 0; i--)
            //{
            //    word += soz[i];
            //}
            //return word;

        }
    }
}
