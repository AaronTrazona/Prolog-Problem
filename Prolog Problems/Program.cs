using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prolog_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            p27A();
            Console.Read();
        }

        /// <summary>
        /// (*)Find the last element of a list.
        /// </summary>
        private static void p1()
        { 
           //list variable
            List<object> slist = new List<object> { 1, 2, 3, 4 };
            Console.WriteLine(slist.Last());
        }

        /// <summary>
        /// (*)Find the last but one element of a list.
        /// </summary>
        private static void p2()
        { 
            //List variable 
            List<object> slist = new List<object> { 1, 2, 3, 4 };
            Console.WriteLine(slist[slist.Count-2]);
        }

        /// <summary>
        /// (*) Find the K'th element of a list.
        /// </summary>
        private static void p3()
        { 
            //List variable 
            List<object> slist = new List<object> { 1, 2, 'a', 4 };
            int i;
            if (int.TryParse(Console.ReadLine(),out i))
            {
                Console.WriteLine(slist[i]);
            }
        }

        /// <summary>
        /// (*) Find the number of elements of a list.
        /// </summary>
        private static void p4()
        {
            //List variable 
            List<object> slist = new List<object> { 'a', 'c', 3, "one",6,'n',7 };
            foreach (object value in slist)
            {
                int i;
                if (int.TryParse(value.ToString(),out i)) 
                {
                    Console.WriteLine(i.ToString()); 
                }
            }
            
        }

        /// <summary>
        /// (*) Reverse a list.
        /// </summary>
        private static void p5()
        {
            //List variable 
            List<object> slist = new List<object> { 'a', 'c', 3, "one", 6, 'n', 7 };
            for (int i = slist.Count()-1; i >= 0; i--)
            {
                Console.WriteLine(slist[i]);
            }

        }

        /// <summary>
        /// (*) Find out whether a list is a palindrome.
        /// </summary>
        private static void p6()
        {
            //List variable 
            List<object> slist = new List<object> { 1,'x', 'a', 'a','x','1' };
            int j;
            int i;
            bool flag = true;
            for (i = 0 ,j = slist.Count() - 1; i < slist.Count && j >= 0 ; i++,j--)
            {

                if (string.Compare(slist[i].ToString(), slist[j].ToString(), true) != 0)
                {
                    flag = false;
                    break;
                }
            }

            Console.WriteLine(flag?"Its a Palindrome" :"Not a Palindrome");
        }

        /// <summary>
        /// Flatten a nested list structure.
        /// </summary>
        private static void p7()
        {
            //List variable 
            List<List<object>> slist = new List<List<object>> { new List<object> { 'a','b' }, new List<object> { 'b' }, new List<object> { 'c' }, new List<object> { 'd' }, new List<object> { 'e' } };
            foreach (var subitem in slist)
            {
                foreach(var subitems in subitem)
                {
                    Console.WriteLine(subitems.ToString());
                }
            }
        }

        /// <summary>
        /// Eliminate consecutive duplicates of list elements.
        /// </summary>
        private static void p8()
        {
            List<object> slist = new List<object> { 'a', 'a', 'a', 'a', 'b', 'c', 'c', 'a', 'a', 'd', 'e', 'e', 'e', 'e' };
            
            foreach (var item in slist.Distinct())
            {
                Console.WriteLine(item.ToString());
            }             
        }

        /// <summary>
        /// (**) Pack consecutive duplicates of list elements into sublists.
        /// </summary>
        private static void p9()
        {
            List<object> slist = new List<object> { 'a', 'a', 'a', 'a', 'b', 'c', 'c', 'a', 'a', 'd', 'e', 'e', 'e', 'e' };
            List<List<object>> alist = new List<List<object>>();
            List<object> list1 = new List<object>();
            List<object> list2 = new List<object>();
            List<object> list3 = new List<object>();
            List<object> list4 = new List<object>();
            List<object> list5 = new List<object>();

            foreach (var item in slist)
            {
                switch(item.ToString())
                {
                    case "a": 
                        list1.Add(item);
                        break;
                    case "b": list2.Add(item); 
                        break;
                    case "c": list3.Add(item); 
                        break;
                    case "d": list4.Add(item); 
                        break;
                    case "e": list5.Add(item); 
                        break;

                }
            }
            alist.Add(list1);
            alist.Add(list2);
            alist.Add(list3);
            alist.Add(list4);
            alist.Add(list5);

            foreach (var subitem in alist)
            {
                foreach (var subitems in subitem)
                {
                    Console.Write(subitems.ToString() + ",");
                }
                Console.WriteLine();
            }
            
        }

        /// <summary>
        /// (*) Run-length encoding of a list.
        /// </summary>
        private static void p10()
        {
            List<object> slist = new List<object> { 'a', 'a', 'a', 'a', 'b', 'c', 'c', 'a', 'a', 'd', 'e', 'e', 'e', 'e' };
            List<List<object>> alist = new List<List<object>>();
            List<object> list1 = new List<object>();
            List<object> list2 = new List<object>();
            List<object> list3 = new List<object>();
            List<object> list4 = new List<object>();
            List<object> list5 = new List<object>();
            int[] intVar = new int[5];

            foreach (var item in slist)
            {
                switch (item.ToString())
                {
                    case "a": intVar[0]++;
                        if (intVar[0] == 1) list1.Add(item); 
                        break;
                    case "b": intVar[1]++;
                        if (intVar[1] == 1) list2.Add(item);
                        break;
                    case "c": intVar[2]++;
                        if (intVar[2] == 1) list3.Add(item);
                        break;
                    case "d": intVar[3]++;
                        if (intVar[3] == 1) list4.Add(item);
                        break;
                    case "e": intVar[4]++;
                        if (intVar[4] == 1) list5.Add(item);
                        break;

                }
            }
            list1.Add(intVar[0]);
            list2.Add(intVar[1]);
            list3.Add(intVar[2]);
            list4.Add(intVar[3]);
            list5.Add(intVar[4]);
            alist.Add(list1);
            alist.Add(list2);
            alist.Add(list3);
            alist.Add(list4);
            alist.Add(list5);

            foreach (var subitem in alist)
            {
                foreach (var subitems in subitem)
                {
                    Console.Write(subitems.ToString() + ",");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// (*) Modified run-length encoding.
        /// </summary>
        private static void p11()
        {
            List<object> slist = new List<object> { 'a', 'a', 'a', 'a', 'b', 'c', 'c', 'a', 'a', 'd', 'e', 'e', 'e', 'e' };
            List<List<object>> alist = new List<List<object>>();
            List<object> list1 = new List<object>();
            List<object> list2 = new List<object>();
            List<object> list3 = new List<object>();
            List<object> list4 = new List<object>();
            List<object> list5 = new List<object>();
            int[] intVar = new int[5];

            foreach (var item in slist)
            {
                switch (item.ToString())
                {
                    case "a": intVar[0]++;
                        if (intVar[0] == 1) list1.Add(item);
                        break;
                    case "b": intVar[1]++;
                        if (intVar[1] == 1) list2.Add(item);
                        break;
                    case "c": intVar[2]++;
                        if (intVar[2] == 1) list3.Add(item);
                        break;
                    case "d": intVar[3]++;
                        if (intVar[3] == 1) list4.Add(item);
                        break;
                    case "e": intVar[4]++;
                        if (intVar[4] == 1) list5.Add(item);
                        break;

                }
            }
            for (int i = 0; i < 5; i++)
            {
                if (intVar[i] > 1)
                {
                    switch (i+1)
                    {
                        case 1: list1.Add(intVar[i]);
                            break;
                        case 2: list2.Add(intVar[i]);
                            break;
                        case 3: list3.Add(intVar[i]);
                            break;
                        case 4: list4.Add(intVar[i]);
                            break;
                        case 5: list5.Add(intVar[i]); 
                            break;
                    }
                }
               

            }


            alist.Add(list1);
            alist.Add(list2);
            alist.Add(list3);
            alist.Add(list4);
            alist.Add(list5);

            foreach (var subitem in alist)
            {
                foreach (var subitems in subitem)
                {
                    Console.Write(subitems.ToString() + ",");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// (**) Decode a run-length encoded list.
        /// </summary>
        private static void p12()
        {
            List<List<object>> oList = new List<List<object>>() { new List<object> { '6', 'c' }, new List<object> {'2', 'b' }, new List<object> { '2', 'c' }, new List<object> { '2', 'a' }, new List<object> { 'd' }, new List<object> { '4', 'e' } };
            List<object> obList = new List<object>();
            int x =0;
            bool flag = false ;

            foreach ( var subitem in oList)
            {

                foreach (var item in subitem)
                {

                    if (subitem.Count == 2 && !flag)
                    {
                         flag = int.TryParse(item.ToString(),out x);
                         continue;
                    }
                    else if (!flag)
                        x = 1;
                    
                    for (int i = 0; i < x; i++)
                    {
                        Console.Write(item + ",");    
                    }

                    flag = false;
                }
            }
        }

        /// <summary>
        /// (**) Run-length encoding of a list (direct solution).
        /// </summary>
        private static void p13()
        {
            List<object> slist = new List<object> { 'a', 'a', 'a', 'a', 'b', 'c', 'c', 'a', 'a', 'd', 'e', 'e', 'e', 'e' };
            List<List<object>> alist = new List<List<object>>();
            List<object> list1 = new List<object>();
            List<object> list2 = new List<object>();
            List<object> list3 = new List<object>();
            List<object> list4 = new List<object>();
            List<object> list5 = new List<object>();
            int[] intVar = new int[5];

            foreach (var item in slist)
            {
                switch (item.ToString())
                {
                    case "a": intVar[0]++;
                        if (intVar[0] == 1) list1.Add(item);
                        break;
                    case "b": intVar[1]++;
                        if (intVar[1] == 1) list2.Add(item);
                        break;
                    case "c": intVar[2]++;
                        if (intVar[2] == 1) list3.Add(item);
                        break;
                    case "d": intVar[3]++;
                        if (intVar[3] == 1) list4.Add(item);
                        break;
                    case "e": intVar[4]++;
                        if (intVar[4] == 1) list5.Add(item);
                        break;

                }
            }
            for (int i = 0; i < 5; i++)
            {
                if (intVar[i] > 1)
                {
                    switch (i + 1)
                    {
                        case 1: list1.Add(intVar[i]);
                            break;
                        case 2: list2.Add(intVar[i]);
                            break;
                        case 3: list3.Add(intVar[i]);
                            break;
                        case 4: list4.Add(intVar[i]);
                            break;
                        case 5: list5.Add(intVar[i]);
                            break;
                    }
                }


            }


            alist.Add(list1);
            alist.Add(list2);
            alist.Add(list3);
            alist.Add(list4);
            alist.Add(list5);

            foreach (var subitem in alist)
            {
                foreach (var subitems in subitem)
                {
                    Console.Write(subitems.ToString() + ",");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// (*) Duplicate the elements of a list.
        /// </summary>
        private static void p14()
        {
            List<object> oList = new List<object>() {'a','b','c','c','d'};

            foreach (var item in oList)
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.Write(item + ",");
                }
            }
        
        }

        /// <summary>
        /// (**) Duplicate the elements of a list a given number of times.
        /// </summary>
        private static void p15()
        {
            List<object> oList = new List<object>() {'a','b','c' };
            int x = 3;

            foreach (var item in oList)
            {
                for (int i = 0; i < x; i++)
                {
                    Console.Write(item + ",");
                }
            }
        }

        /// <summary>
        /// (**) Drop every N'th element from a list.
        /// </summary>
        private static void p16()
        {
            List<object> oList = new List<object>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'k' };
            int x = int.Parse(Console.ReadLine().ToString());
            int temp=x;
            int i=0;
            foreach (var item in oList)
            {
                i++; 
                if (temp == i)
                {
                    temp+=x;
                    continue;
                }
                Console.Write(item + ",");
            }

        }

        /// <summary>
        /// (*) Split a list into two parts; the length of the first part is given.
        /// </summary>
        private static void p17()
        {
            List<object> oList = new List<object>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'k' };
            int x = int.Parse(Console.ReadLine().ToString());
            int i = 0;
            foreach (var item in oList)
            {
                i++;
                if (x <= i)
                {
                    Console.Write(item + ",");
                    if (x == i) Console.WriteLine();
                }
                else
                Console.Write(item + ",");
            }
        }

        /// <summary>
        /// (**) Extract a slice from a list.
        /// </summary>
        private static void p18()
        {
            List<object> oList = new List<object>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'k' };
            int x = int.Parse(Console.ReadLine().ToString());
            int y = int.Parse(Console.ReadLine().ToString());
            int i = 0;
            foreach (var item in oList)
            {
                i++;
                if (x <= i && i <= y)
                {
                    Console.Write(item + ",");
                }
            }
        }

        /// <summary>
        /// (**) Rotate a list N places to the left.
        /// </summary>
        private static void p19()
        {
            List<object> oList = new List<object>() { 1, 2, 3, 4, 5, 6, 7, 8,9, 10};
            int x = int.Parse(Console.ReadLine().ToString());
            int temp;
            if (x <0)
                temp = oList.Count() + x;
            else
                temp = x;

            for (int i = temp; i < oList.Count(); i++)
            {
                    Console.Write(oList[i] + " ");
            }

            for (int i = 0; i < temp; i++)
            {
                Console.Write(oList[i] + " ");
            }
        }

        /// <summary>
        /// (*) Remove the K'th element from a list.
        /// </summary>
        private static void p20()
        {
            List<object> oList = new List<object>() { 'a','b','c','d' };
            char remove = char.Parse(Console.ReadLine());
            
            foreach (var item in oList)
            {
                if (char.Parse(item.ToString()) != remove)
                {
                    Console.Write(item + ",");
                }    
            }
        }

        /// <summary>
        /// (*) Insert an element at a given position into a list.
        /// </summary>
        private static void p21()
        {
            List<object> oList = new List<object>() { 'a', 'b', 'c', 'd' };
            int x = int.Parse(Console.ReadLine());
            oList.Insert(x-1, "aaron");
            foreach (var item in oList)
            {
                Console.Write(item + ",");
            }
        }

        /// <summary>
        /// (*) Create a list containing all integers within a given range.
        /// </summary>
        private static void p22()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                Console.Write(i + ",");
            }
        }

        /// <summary>
        /// (**) Extract a given number of randomly selected elements from a list.
        /// </summary>
        private static void p23()
        {
            List<object> oList = new List<object>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            int x = int.Parse(Console.ReadLine());
            int temp = -1;
            int randomNumber;
            Random rand = new Random();
            for (int i = 0; i < x; i++)
            {


                do
                {
                    
                    randomNumber = rand.Next(0, oList.Count());
                     

                } while (temp==randomNumber);

                temp = randomNumber;
                Console.Write(oList[randomNumber]+",");

            }
        }

        /// <summary>
        /// (*) Lotto: Draw N different random numbers from the set 1..M.
        /// </summary>
        private static void p24()
        {

            Random rand = new Random();
            

            for (int i = 0; i < 6; i++)
            {
                int random = rand.Next(0, 49);
                Console.Write(random + ",");
            }
        }

        /// <summary>
        /// (*) Generate a random permutation of the elements of a list.
        /// </summary>
        private static void p25() 
        {
            List<int> oList = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> tempList = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < oList.Count(); )
            {
                int x = rand.Next(0, 6);
                var temp = (from n
                     in tempList
                     where n==oList[x]
                     select n).SingleOrDefault();
                if (temp==0)
                {
                    tempList.Add(oList[x]);
                    Console.Write(tempList[i] +" ");
                    i++;
                }
            }

        
        }

        /// <summary>
        /// (**) Generate the combinations of K distinct objects chosen from the N elements of a list
        /// </summary>
        private static void p26()
        {
            List<object> oList = new List<object>() { 'a', 'b', 'c', 'd', 'e'};
            List<List<object>> comList = new List<List<object>>();
            int check = 0;
            
            long x = long.Parse(Console.ReadLine().ToString());
            Random ran = new Random();

            long temp = (Factorial(long.Parse(oList.Count.ToString())) /(Factorial(x)*(Factorial((long)oList.Count() - x))));

            for (int i = 0; i < temp; )
            {
                check = 0;
                List<object> tempList = new List<object>();

                for (int j = 0; j < x; )
                {
                    int k = ran.Next(0, oList.Count());
                    var tempVar = (from n
                                in tempList
                                where n == oList[k]
                                select n).SingleOrDefault();
                    if (tempVar == null)
                    {
                        tempList.Add(oList[k]);
                        j++;
                    }

                }

                foreach (var subitem in comList)
                {
                    for (int v = 0; v < subitem.Count(); v++)
                    {
                        var tempCom = ( from t
                                        in subitem
                                        where t == tempList[v]
                                        select t).SingleOrDefault();
                        if (tempCom != null)
                        {
                            check++;
                        }
                    }
                }

                if (check != 3)
                {
                    comList.Add(tempList);
                    i++;
                } 
           }

            foreach (var subitem in comList)
            {
                foreach (var item in subitem)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        
        }

        static long Factorial(long number)
        {
            if (number <= 1)
                return 1;
            else
                return number * Factorial(number - 1);
        }

        /// <summary>
        /// (**) Group the elements of a set into disjoint subsets. (A)
        /// </summary>
        private static void p27A() 
        {
            List<int> oList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int group = int.Parse(Console.ReadLine().ToString());
            int inc = 0;
            int plus = 0;
            int rem = 0;
            int cycle = oList.Count / group;
            rem = oList.Count % group;
            for (int i = 0; i < oList.Count; i++)
            {
                if (rem > 0)
                    plus = 1;
                else
                    plus = 0;
                if (inc % (cycle + plus) == 0 && i != 0)
                {
                    rem--;
                    Console.WriteLine();
                    inc = 0;
                    
                }
                inc++;
                Console.Write(oList[i] + " ");
                
            }

        }

        /// <summary>
        /// (**) Group the elements of a set into disjoint subsets. (B)
        /// </summary>
        private static void p27B()
        {
            List<int> oList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            string[] group = Console.ReadLine().Split(',');
            int k = 0;
            int x = 0; 
            for (int i = 0; i < oList.Count; i++)
            {

                if (int.Parse(group[k]) == x)
                {
                    Console.WriteLine();
                    x = 0;
                    k++;
                }
                x++;
                Console.Write(oList[i] + " ");

            }

        }

        /// <summary>
        /// (**) Sorting a list of lists according to length of sublists. (A)
        /// </summary>
        private static void p28A()
        {
            List<List<object>> oList = new List<List<object>>() { 
            new List<object> { 'a','b','c' }, new List<object> {'d','e' }, new List<object> { 'f','g','h' }, new List<object> {'d','e' }, new List<object> { 'i','j','k','l' },
            new List<object> { 'm','n'}, new List<object> { 'o'}
            };

            List<List<object>> rlist = new List<List<object>>();

            rlist = RecursiveA(oList, rlist);
            
            foreach (var subitem in rlist)
            {
                Console.Write("[");
                foreach (var subitems in subitem)
                {
                    Console.Write(subitems + ",");
                }
                Console.Write("], ");
            }            
        }
        private static List<List<object>> RecursiveA(List<List<object>> oList,  List<List<object>> rlist)
        {
            List<object> recList = new List<object>();

            int temp = 1000;
            int x = 0;
            for (int i = 0; i < oList.Count; i++)
            {
                foreach (var item in oList[i])
                {

                    if (oList[i].Count < temp)
                    {
                        temp = oList[i].Count;
                        x = i;
                    }
                }
            }

            if (oList.Count == 1)
            {
                recList.AddRange(oList[x]);
                rlist.Add(recList);
                oList.RemoveAt(x);
                return rlist; 
            }
            else
            {
                recList.AddRange(oList[x]);
                rlist.Add(recList);
                oList.RemoveAt(x);
                return RecursiveA(oList, rlist);
            }

        }

        /// <summary>
        /// (**) Sorting a list of lists according to length of sublists. (B)
        /// </summary>
        private static void p28B()
        {
            List<List<object>> oList = new List<List<object>>() { 
            new List<object> { 'a','b','c' }, new List<object> {'d','e' }, new List<object> { 'f','g','h' }, new List<object> {'d','e' }, new List<object> { 'i','j','k','l' },
            new List<object> { 'm','n'}, new List<object> { 'o'}
            };

            List<List<object>> rlist = new List<List<object>>();

            rlist = RecursiveB(oList, rlist);

            foreach (var subitem in rlist)
            {
                Console.Write("[");
                foreach (var subitems in subitem)
                {
                    Console.Write(subitems + ",");
                }
                Console.Write("], ");
            }


        }
        private static List<List<object>> RecursiveB(List<List<object>> oList, List<List<object>> rlist)
        {
            List<object> recList = new List<object>();

            int temp = 0;
            int x = 0;
            int flag = 0;
            for (int i = 0; i < oList.Count; i++)
            {
                foreach (var item in oList[i])
                {
                    flag = 0;
                    if (oList[i].Count > temp)
                    {
                        for (int v = 0; v < oList.Count; v++)
                        {
                            if (oList[i].Count == oList[v].Count)
                            {

                                flag++;
                            }
                        }
                        if (flag == 1)
                        {
                            temp = i;
                            x = temp;
                        }
                        else
                        { 
                        
                        }
                            
                        
                    }
                }
            }

            if (oList.Count == 1)
            {
                recList.AddRange(oList[x]);
                rlist.Add(recList);
                oList.RemoveAt(x);
                return rlist;
            }
            else
            {
                recList.AddRange(oList[x]);
                rlist.Add(recList);
                oList.RemoveAt(x);
                return RecursiveB(oList, rlist);
            }

        }

    }
}
