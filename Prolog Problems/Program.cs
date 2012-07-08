using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace Prolog_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            p42();
            Console.Read();
        }

        #region Working with Prolog lists
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
            Console.WriteLine(slist[slist.Count - 2]);
        }

        /// <summary>
        /// (*) Find the K'th element of a list.
        /// </summary>
        private static void p3()
        {
            //List variable 
            List<object> slist = new List<object> { 1, 2, 'a', 4 };
            int i;
            if (int.TryParse(Console.ReadLine(), out i))
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
            List<object> slist = new List<object> { 'a', 'c', 3, "one", 6, 'n', 7 };
            foreach (object value in slist)
            {
                int i;
                if (int.TryParse(value.ToString(), out i))
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
            for (int i = slist.Count() - 1; i >= 0; i--)
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
            List<object> slist = new List<object> { 1, 'x', 'a', 'a', 'x', '1' };
            int j;
            int i;
            bool flag = true;
            for (i = 0, j = slist.Count() - 1; i < slist.Count && j >= 0; i++, j--)
            {

                if (string.Compare(slist[i].ToString(), slist[j].ToString(), true) != 0)
                {
                    flag = false;
                    break;
                }
            }

            Console.WriteLine(flag ? "Its a Palindrome" : "Not a Palindrome");
        }

        /// <summary>
        /// Flatten a nested list structure.
        /// </summary>
        private static void p7()
        {
            //List variable 
            List<List<object>> slist = new List<List<object>> { new List<object> { 'a', 'b' }, new List<object> { 'b' }, new List<object> { 'c' }, new List<object> { 'd' }, new List<object> { 'e' } };
            foreach (var subitem in slist)
            {
                foreach (var subitems in subitem)
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
                switch (item.ToString())
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
        /// (**) Decode a run-length encoded list.
        /// </summary>
        private static void p12()
        {
            List<List<object>> oList = new List<List<object>>() { new List<object> { '6', 'c' }, new List<object> { '2', 'b' }, new List<object> { '2', 'c' }, new List<object> { '2', 'a' }, new List<object> { 'd' }, new List<object> { '4', 'e' } };
            List<object> obList = new List<object>();
            int x = 0;
            bool flag = false;

            foreach (var subitem in oList)
            {

                foreach (var item in subitem)
                {

                    if (subitem.Count == 2 && !flag)
                    {
                        flag = int.TryParse(item.ToString(), out x);
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
            List<object> oList = new List<object>() { 'a', 'b', 'c', 'c', 'd' };

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
            List<object> oList = new List<object>() { 'a', 'b', 'c' };
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
            int temp = x;
            int i = 0;
            foreach (var item in oList)
            {
                i++;
                if (temp == i)
                {
                    temp += x;
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
            List<object> oList = new List<object>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int x = int.Parse(Console.ReadLine().ToString());
            int temp;
            if (x < 0)
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
            List<object> oList = new List<object>() { 'a', 'b', 'c', 'd' };
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
            oList.Insert(x - 1, "aaron");
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


                } while (temp == randomNumber);

                temp = randomNumber;
                Console.Write(oList[randomNumber] + ",");

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
                            where n == oList[x]
                            select n).SingleOrDefault();
                if (temp == 0)
                {
                    tempList.Add(oList[x]);
                    Console.Write(tempList[i] + " ");
                    i++;
                }
            }


        }

        /// <summary>
        /// (**) Generate the combinations of K distinct objects chosen from the N elements of a list
        /// </summary>
        private static void p26()
        {
            List<object> oList = new List<object>() { 'a', 'b', 'c', 'd', 'e' };
            List<List<object>> comList = new List<List<object>>();
            int check = 0;

            long x = long.Parse(Console.ReadLine().ToString());
            Random ran = new Random();

            long temp = (Factorial(long.Parse(oList.Count.ToString())) / (Factorial(x) * (Factorial((long)oList.Count() - x))));

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
                        var tempCom = (from t
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
        private static List<List<object>> RecursiveA(List<List<object>> oList, List<List<object>> rlist)
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

        #endregion

        #region Arithmetic

        /// <summary>
        /// (**) Determine whether a given integer number is prime.
        /// </summary>
        private static void p31()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(isPrime(number));

        }
        static bool isPrime(int number)
        {

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i < number; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;

        }

        /// <summary>
        /// (**) Determine the greatest common divisor of two positive integer numbers.
        /// </summary>
        private static void p32() 
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int temp = x;
            List<int> gcd = new List<int>();

            if (x > y)
                temp = y;

            for (int i = temp; i > 1; i--)
            {
                if (temp % i ==0)
                {
                    gcd.Add(i);
                }
            }

            if (temp == y)
                temp = x;
            else
                temp = y;
            for (int i = 1; i < temp; i++)
            {
                if (temp % i == 0)
                {
                    var common = (from c in gcd
                                  where c == i
                                  select c).SingleOrDefault();
                    if (common != 0)
                    {
                        Console.WriteLine("GCD: {0}",gcd[i]);
                        return;
                    }
                }
            }
            Console.WriteLine("Two Numbers does not have common divisor");
            
        }

        /// <summary>
        /// (*) Determine whether two positive integer numbers are coprime.
        /// </summary>
        private static void p33()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (isPrime(x) && isPrime(y))
                Console.WriteLine(false);
            else
                Console.WriteLine(true);
        }

        /// <summary>
        /// (**) Calculate Euler's totient function phi(m).
        /// </summary>
        private static void p34()
        {
            Console.Write("Totient Phi = ");
            //int num = int.Parse(Console.ReadLine());
            int num = 10090;
            int count = 0;
            for (int a = 1; a < num; a++)
            { //definition of totient: the amount of numbers less than num coprime to it
                if (GCD(num, a) == 1)
                { //coprime
                    count++;
                }
            }
            Console.WriteLine("Phi = "+count);
        }

        /// <summary>
        /// Simple Implementation of Getting GCD
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int GCD(int a, int b)
        { //faster euclidean algorithm-see GCD for explanation
            int temp;
            if (a < b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            if (a % b == 0)
            {
                return (b);
            }
            return (GCD(a % b, b));
        }

        /// <summary>
        /// (**) Determine the prime factors of a given positive integer.
        /// </summary>
        private static void p35()
        {
            List<int> iList = new List<int>();
            int temp =1000;
            int prime = int.Parse(Console.ReadLine());
            temp = prime;
            if (!isPrime(prime))
            {
                for (int i = 3; i < prime; i++)
                {
                    if (isPrime(i))
                    {
                        if (i <= temp && temp % i == 0)
                        {
                            temp = temp / i;
                            iList.Add(i);
                        }
                        else if (i >= temp && temp != 1)
                        {
                            iList.Add(temp);
                            break;
                        }
                    }
                }
            }
            else
                Console.WriteLine("A Prime Number");
            List<int> oList = iList.OrderBy(x => x).ToList();

            foreach (var item in oList)
            {
                Console.Write(item + " ");
            }

        }

        /// <summary>
        /// (**) Determine the prime factors of a given positive integer (2).
        /// </summary>
        private static void p36()
        {
            int count = 1;
            List<int> iList = new List<int>();
            int temp = 1000;
            int prime = int.Parse(Console.ReadLine());
            temp = prime;
            if (!isPrime(prime))
            {
                for (int i = 3; i < prime; i++)
                {
                    if (isPrime(i))
                    {
                        if (i <= temp && temp%i == 0)
                        {
                            temp = temp / i;
                            iList.Add(i);
                        }
                        else if (i>=temp && temp != 1)
                        {
                            iList.Add(temp);
                            break;
                        }
                    }
                }
            }
            else
                Console.WriteLine("A Prime Number");
            List<int> oList = iList.OrderBy(x => x).ToList();

            foreach (var item in oList)
            {
                var items = (from o in oList
                             where o == item
                             select o).ToList();
                
                if (items.Count == 1)
                {
                    count = 1;
                    Console.Write("["+item + "," + count +"],");
                    
                }
                else if(count == 1 || temp != item)
                {
                    temp =item;
                    count = items.Count;
                    Console.Write("[" + item + "," + count + "],");
                }
            }
        
        }

        /// <summary>
        /// (**) Calculate Euler's totient function phi(m) (improved).
        /// </summary>
        private static void p37()
        {
            int count = 1;
            List<int> iList = new List<int>();
            int temp = 1000;
            //int prime = int.Parse(Console.ReadLine());
            int prime = 10090;
            temp = prime;
            int totient = 1;
            if (!isPrime(prime))
            {
                for (int i = 3; i < prime; i++)
                {
                    if (isPrime(i))
                    {
                        if (i <= temp && temp % i == 0)
                        {
                            temp = temp / i;
                            iList.Add(i);
                        }
                        else if (i >= temp && temp != 1)
                        {
                            iList.Add(temp);
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("A Prime Number");
                return;
            }
            List<int> oList = iList.OrderBy(x => x).ToList();

            foreach (var item in oList)
            {
                var items = (from o in oList
                             where o == item
                             select o).ToList();

                if (items.Count == 1)
                {
                    count = 1;
                    totient *= Totient(item, count);

                }
                else if (count == 1 || temp != item)
                {
                    temp = item;
                    count = items.Count;
                    totient *= Totient(item, count);
                }
            }

            if (oList.Count == 0)
                Console.WriteLine("Phi(0)");
            else
                Console.WriteLine("Phi({0})", totient);
        }
        private static int Totient(int number,int phi)
        {
            
            return (number - 1) * (int.Parse(Math.Pow(number,phi-1).ToString())) ;
        }

        /// <summary>
        /// (*) Compare the two methods of calculating Euler's totient function.
        /// </summary>
        private static void p38()
        {
            Console.WriteLine("Problem 34");
            int time = 0;
            int time1 = 0;
            DateTime timeDiff;
            timeDiff = DateTime.Now;
            p34();
            time = DateTime.Now.Subtract(timeDiff).Milliseconds;
            Console.WriteLine("totient took {0}", time);
            Console.WriteLine("Problem 37");
            timeDiff = DateTime.Now;
            p37();
            time1 = DateTime.Now.Subtract(timeDiff).Milliseconds;
            Console.WriteLine("totient took {0}", time1);

            if (time1 > time)
                Console.WriteLine("Problem 34 is faster than Problem 37");
            else
                Console.WriteLine("Problem 37 is faster than Problem 34");
            
        }

        /// <summary>
        /// (*) A list of prime numbers.
        /// </summary>
        private static void p39()
        {
            int prime = int.Parse(Console.ReadLine());

            for (int i = 2; i < prime; i++)
            {
                if (isPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
        }

        /// <summary>
        /// (**) Goldbach's conjecture.
        /// </summary>
        private static void p40()
        {
            List<int> sList = null;
            int gold = int.Parse(Console.ReadLine());
            int temp = gold;
            int count = 0;
            List<int> invalid =new List<int>();
            while (temp != 0)
            {
                temp=gold;
                sList = new List<int>();
                temp = goldbach(ref sList, temp, gold,ref invalid);
                invalid.Add(sList[0]);
                count++;
            }

            List<int> oList = sList.OrderBy(o => o).ToList();
            foreach (var item in oList)
            {
                Console.Write(item + " ");
            }
        }
        private static int goldbach(ref List<int> slist, int temp, int gold,ref List<int> invalid)
        {
            //List<int> tempInvalid = new List<int>();
            for (int i = gold; i > 1; i--)
            {
                if (isPrime(i))
                {
                    var tempInvalid = (from t in invalid
                                   where t == i
                                   select t).SingleOrDefault();

                    if (temp > i && temp - 1 != i && tempInvalid == 0)
                    {
                        temp -= i;
                        slist.Add(i);
                    }
                    else if (temp - i == 0)
                    {
                        slist.Add(i);
                        temp -= i;
                        break;
                    }

                }
            }
            return temp;
        }

        /// <summary>
        /// (**) A list of Goldbach compositions.(A)
        /// </summary>
        private static void p41()
        {
            List<int> sList = null;
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = min; i <= max; i++)
            {
                count = 0;
                if (i % 2==0 )
                {
                    int temp = i;
                    List<int> invalid = new List<int>();
                    while (temp != 0)
                    {
                        temp = i;
                        sList = new List<int>();
                        temp = goldbach(ref sList, temp, i, ref invalid);
                        invalid.Add(sList[0]);
                    }  
                

                    List<int> oList = sList.OrderBy(o => o).ToList();
                    foreach (var item in oList)
                    {

                        if (count==0)
                            Console.Write(i + "=" + item + "+");
                        else if(count == oList.Count-1)
                            Console.Write(item);
                        else
                            Console.Write(item + "+");
                        count++;

                    }
                    Console.WriteLine();
                }
               
            }

        }

        /// <summary>
        /// (**) A list of Goldbach compositions.(B)
        /// </summary>
        private static void p42()
        {
            List<int> sList = new List<int>();
            int max = int.Parse(Console.ReadLine());
            int limit = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 100 ; i <= max; i++)
            {
                count = 0;
                if (i%2==0)
                {
                    int temp = i;
                    List<int> invalid = new List<int>();
                    while (temp != 0 || sList.Count != 2)
                    {
                        temp = i;
                        sList = new List<int>();
                        temp = goldbach(ref sList, temp, i - limit, ref invalid);
                        
                        if (temp==i)
                        {
                            break;
                        }
                        invalid.Add(sList[0]);
                    }


                    List<int> oList = sList.OrderBy(o => o).ToList();
                    var tempLimit = (from x in oList
                                     where x >= 50
                                     orderby x
                                     select x).ToList();

                    if (tempLimit != null && tempLimit.Count > 1)
                    {

                        foreach (var item in tempLimit)
                        {

                            if (count == 0)
                                Console.Write(i + "=" + item + "+");
                            else if (count == tempLimit.Count - 1)
                                Console.Write(item);
                            else
                                Console.Write(item + "+");
                            count++;

                        }
                        Console.WriteLine();
                    } 
                }
                    

            }

        }
        #endregion

    }
}
