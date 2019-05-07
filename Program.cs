using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;



namespace PracticeNew
{


    internal class SingleLinkedList
    {
        internal Node head;



    }

    internal class Node
    {
        internal int data;
        internal Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }


        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }


        public class Program
        {
            private static string[] morseCode = new string[]{
            ".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."
            };
            /*
    Data Structures:

    Array
    Linked List
    Binary Tree, Binary Search Tree, Red-Black Tree
    Heap
    Hash Table
    Stack
    Queue
    Trie
    Graph (both directed and undirected)


    Algorithms:

    Sorting
    Bubble Sort
    Merge Sort
    Quick Sort
    Radix/Bucket Sort
    Traversals (On multiple data structures)
    Depth First Search
    Breadth First Search


    Object Oriented Design:

    You should have a working knowledge of a few common and useful design patterns (singleton, factory, adapter, bridge, visitor, command, proxy, observer, etc.) as well as know how to write software in an object oriented way with appropriate use of inheritance and aggregation.



    Cultural Survey:

    It would be good to review our 14 leadership principals, because the survey will focus around those. This portion of the assessment is equally as important as the technical component. Have a look at our 14 leadership principles (link below) and think about experiences in your career that pertain to each principle.

    https://www.amazon.jobs/principles


             */
            static void Main(string[] args)
            {
                int[] houses = new int[] { 1, 0, 0, 1, 0, 1, 0, 0 };
                int daysToCheck = 5;

                HouseLight houseLight = new HouseLight();
                var x = houseLight.whatWillbeTheArrayOnDay(houses, daysToCheck);
                houseLight.printArrayHouseLight<int>(x);

                // TwoSum - Easy Level
                ProgramExtensionMethod.printArray<int>(TwoSum(new int[] { 2, 7, 11, 15 }, 9));
                // ReverseInteger
                Console.WriteLine(ReverseNotReC(123));

                printRec(10);


                birthday(new List<int> { 1, 2, 1, 3, 2 }, 3, 2);

                sockMerchant(9, new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 });
                sockMerchant(10, new int[] { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 });
                int[][] mat = { new int[]{1, 2, 3, 0, 0},
                       new int[] {0, 0, 0, 0, 0},
                       new int[] {2, 1, 4, 0, 0},
                       new int[]{0, 0, 0, 0, 0},
                       new int[] {1, 1, 0, 1, 0}};
                hourglassSum(mat);

                minimumSwaps(new int[] { 1, 3, 5, 2, 4, 6, 7 });

                //rotLeft(new int[]{1,2,3,4,5}, 4);
                rotLeft(new int[] { 1, 2, 3, 4, 5 }, 4);

                var linkedList = new LinkedList<int>();
                linkedList.AddFirst(1);
                linkedList.AddFirst(2);
                linkedList.AddFirst(3);
                linkedList.AddFirst(4);
                linkedList.AddFirst(5);
                linkedList.AddFirst(6);
                searchLinkedList(linkedList.First, 4);
                reverseLinkedList(linkedList.First);

                SingleLinkedList singleList = new SingleLinkedList();
                InsertLast(singleList, 1);
                InsertLast(singleList, 2);
                InsertLast(singleList, 3);

                substrCount(4, "aaaa");
                MyAtoi("  -42");
                LengthOfLongestSubstring("au");
                FindMedianSortedArrays(new int[] { 3 }, new int[] { -2, -1 });
                ToLowerCase("Hello");
                UniqueMorseRepresentations(new string[] { "gin", "zen", "gig", "msg" });
                ReverseString(new char[] { 'h', 'e', 'l', 'l', '0' });
                HammingDistance(1, 4);
                HammingDistance(14, 4);
                SelfDividingNumbers(1, 22);
                UncommonFromSentences("this apple is sweet", "this apple is sour");
                SubdomainVisits(new string[] { "900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org" });

                ListNode aaa1 = new ListNode(2);
                ListNode aaa2 = new ListNode(3);
                ListNode aaa3 = new ListNode(9);

                ListNode aaa = new ListNode(1);
                aaa.next = aaa1;
                aaa1.next = aaa2;
                aaa2.next = aaa3;

                RemoveElements(aaa1, 9);

                SingleNumber(new int[] { 1, 2, 1, 3, 2, 5 });
                NextGreaterElement(new int[] { 4, 1, 2 }, new int[] { 1, 3, 4, 2 });
                StrStr("mississippi", "issipi");
                ConvertToTitle(52);
                IsPalindrome("A man, a plan, a canal -- Panama");
                MostCommonWord("a, a, a, a, b,b,b,c, c", new string[] { "a" });
            }

            public static string MostCommonWord(string paragraph, string[] banned)
            {
                string[] results = Regex.Replace(paragraph, @"\p{P}", " ").ToLower().Split(" ");
                Dictionary<string, int> aaa = new Dictionary<string, int>();
                foreach (string s in results)
                {
                    if(s == "")
                        continue;
                    if (aaa.ContainsKey(s))
                        aaa[s]++;
                    else
                        aaa.Add(s, 1);
                }

                foreach (string s in banned)
                {
                    if (aaa.ContainsKey(s))
                        aaa.Remove(s);
                }


                var items = from pair in aaa
                            orderby pair.Value descending
                            select pair;

                return items.First().Key;


            }

            /*public static int FirstBadVersion(int n)
            {
                int start = 1;
                int end = n;

                while (true)
                {
                    int median = (start + end) / 2;

                    if (IsBadVersion(median + 1) && IsBadVersion(median) && IsBadVersion(median - 1) == false)
                        return median;

                    if (IsBadVersion(median))
                        end = median - 1;
                    else
                        start = median + 1;
                }
            }*/


            public static bool IsPalindrome(string s)
            {
                if (string.IsNullOrEmpty(s))
                    return true;

                Regex rgx = new Regex("[^a-zA-Z0-9]");
                s = rgx.Replace(s, "");
                s = s.Replace(" ", string.Empty).ToLower();

                for (int i = 0, y = s.Length - 1; i < y; i++, y--)
                {
                    if (s[i] != s[y])
                        return false;
                }

                return true;

            }

            public static string ConvertToTitle(int n)
            {
                if (n == 0)
                    return "";
                string ss = "";

                if (n < 27)
                {
                    string aa = ((char)(n + 64)).ToString();
                    return aa;
                }

                if (n > 26 && n < 703)
                {
                    int ammountToCalc = 0;
                    while (ammountToCalc * 26 + 26 < n)
                        ammountToCalc++;
                    var diff = n - (ammountToCalc * 26);
                    string aa = ((char)(ammountToCalc + 64)).ToString() + ((char)(diff + 64)).ToString();
                    return aa;
                }

                int fullNumber = n / 26;
                while (n != 0)
                {
                    int ammount = 26 * fullNumber;
                    int aaa = n - ammount;
                    if (aaa == 0)
                        aaa = 26;
                    ss = ((char)(aaa + 64)).ToString() + ss;
                    n = fullNumber;
                    fullNumber = n / 26;
                }

                return ss;
            }

            public static int StrStr(string haystack, string needle)
            {
                if (needle.Length == 0)
                    return 0;
                if (needle.Length > haystack.Length)
                    return -1;

                Dictionary<char, List<int>> dic = new Dictionary<char, List<int>>();

                for (int i = 0; i < haystack.Length; i++)
                {
                    if (dic.ContainsKey(haystack[i]))
                        dic[haystack[i]].Add(i);
                    else
                        dic.Add(haystack[i], new List<int>() { i });
                }

                if (dic.ContainsKey(needle[0]))
                {
                    var list = dic[needle[0]];
                    for (int i = 0; i < list.Count; i++)
                    {
                        int startingNeedle = list[i];
                        bool isNeedle = true;
                        for (int y = 0; y < needle.Length; y++)
                        {
                            int haystackLength = haystack.Length;
                            int index = startingNeedle;

                            bool aaa = haystackLength > index;

                            if (startingNeedle == haystack.Length || needle[y] != haystack[startingNeedle++])
                            {
                                isNeedle = false;
                                break;
                            }
                        }
                        if (isNeedle)
                            return list[i];
                    }
                    return -1;
                }
                else
                    return -1;
            }

            public static int[] NextGreaterElement(int[] findNums, int[] nums)
            {
                int[] newArray = new int[findNums.Length];
                Dictionary<int, int> dic = new Dictionary<int, int>();

                for (int i = 0; i < nums.Length; i++)
                {
                    dic.Add(nums[i], i);
                }

                for (int i = 0; i < findNums.Length; i++)
                {
                    if (dic.ContainsKey(findNums[i] + 1))
                        newArray[i] = dic[findNums[i] + 1];
                    else
                        newArray[i] = -1;
                }
                return newArray;
            }

            public static int[] SingleNumber(int[] nums)
            {
                return null;
            }



            public static ListNode RemoveElements(ListNode head, int val)
            {
                while (head != null && head.val == val)
                {
                    head = head.next;
                }

                if (head == null) return null;

                ListNode curr = head.next;
                ListNode prev = head;

                while (curr != null)
                {
                    if (curr.val == val)
                    {
                        prev.next = curr.next;
                        curr = curr.next;
                    }
                    else
                    {
                        prev = curr;
                        curr = curr.next;
                    }
                }


                return head;
            }



            public static void DeleteNode(ListNode node)
            {
                ListNode p = null;
                while (node.next != null)
                {
                    node.val = node.next.val;
                    p = node;
                    if (node.next == null)
                        node.next = null;
                    else
                        node = node.next;
                }
                p.next = null;
            }

            public static IList<string> SubdomainVisits(string[] cpdomains)
            {
                Dictionary<string, int> subDomainVisits = new Dictionary<string, int>();
                IList<string> strings = new List<string>();
                bool lastItem = false;
                foreach (string str in cpdomains)
                {
                    int enters = int.Parse(str.Split(' ')[0]);
                    string domains = str.Split(' ')[1];
                    int i = 0;
                    int domainLength = domains.Split('.').Length;
                    while (i < domainLength)
                    {
                        if (subDomainVisits.ContainsKey(domains))
                            subDomainVisits[domains] = subDomainVisits[domains] + enters;
                        else
                            subDomainVisits.Add(domains, enters);
                        domains = domains.Substring(domains.IndexOf('.') + 1);
                        i++;
                    }
                }

                foreach (var item in subDomainVisits)
                    strings.Add($"{item.Value} {item.Key}");

                return strings;
            }

            public static string[] UncommonFromSentences(string A, string B)
            {
                Dictionary<string, int> table = new Dictionary<string, int>();
                string[] arrA = A.Split(' ');
                string[] arrB = B.Split(' ');

                List<string> common = new List<string>();
                for (int i = 0; i < arrA.Length; i++)
                {
                    if (table.ContainsKey(arrA[i]))
                    {
                        table[arrA[i]] = table[arrA[i]] + 1;
                        continue;
                    }
                    table.Add(arrA[i], 1);
                }

                for (int i = 0; i < arrB.Length; i++)
                {
                    if (table.ContainsKey(arrB[i]))
                    {
                        table[arrB[i]] = table[arrB[i]] + 1;
                        continue;
                    }
                    table.Add(arrB[i], 1);
                }

                foreach (var item in table)
                {
                    if (item.Value == 1)
                        common.Add(item.Key);
                }

                return common.ToArray();
            }
            public static IList<int> SelfDividingNumbers(int left, int right)
            {
                IList<int> list = new List<int>();

                for (int i = left; i <= right; i++)
                {
                    string selfDevidingNumber = i.ToString();
                    if (selfDevidingNumber.Contains('0'))
                        continue;

                    bool isDivisible = true;
                    int index = 0;
                    while (index < selfDevidingNumber.Length)
                    {
                        if (i % int.Parse(selfDevidingNumber[index].ToString()) != 0)
                        {
                            isDivisible = false;
                            break;
                        }
                        index++;
                    }

                    if (isDivisible)
                        list.Add(i);
                }

                return list;
            }

            public static int HammingDistance(int x, int y)
            {
                string num1 = Convert.ToString(x, 2); //Convert to binary in a string
                string num2 = Convert.ToString(y, 2); //Convert to binary in a string

                int hammingDis = 0;

                if (num1.Length < num2.Length)
                {
                    while (num1.Length != num2.Length)
                    {
                        num1 = "0" + num1;
                    }
                }
                else if (num1.Length > num2.Length)
                {
                    while (num1.Length != num2.Length)
                    {
                        num2 = "0" + num2;
                    }
                }

                for (int i = 0; i < num1.Length; i++)
                {
                    if (num1[i] != num2[i])
                        hammingDis++;
                }

                return hammingDis;

            }

            public static void ReverseString(char[] s)
            {
                ReverseStringRec(s, 0, s.Length - 1);
            }

            public static void ReverseStringRec(char[] s, int start, int end)
            {
                if (start > end)
                    return;

                char temp = s[start];
                s[start] = s[end];
                s[end] = temp;

                ReverseStringRec(s, start + 1, end - 1);
            }
            public static int UniqueMorseRepresentations(string[] words)
            {
                Hashtable ht = new Hashtable();
                int unique = 0;
                for (int i = 0; i < words.Length; i++)
                {
                    StringBuilder concatWord = new StringBuilder(string.Empty);
                    var wordsToChars = words[i].ToCharArray();
                    for (int y = 0; y < wordsToChars.Length; y++)
                    {
                        int index = char.ToUpper(wordsToChars[y]) - 64;//index == 1
                        concatWord.Append(morseCode[index - 1]);
                    }

                    if (ht.ContainsKey(concatWord.ToString()))
                        continue;
                    else
                    {
                        ht.Add(concatWord.ToString(), 1);
                        unique++;
                    }
                }

                return unique;
            }

            public static string ToLowerCase(string str)
            {

                if (str == null || str.Length == 0)
                    return string.Empty;

                var strCharArray = str.ToCharArray();
                for (int i = 0; i < strCharArray.Length; i++)
                {
                    if (strCharArray[i] >= 'A' && strCharArray[i] <= 'Z')
                        strCharArray[i] = (char)(strCharArray[i] + 32);
                }

                str = new string(strCharArray);

                return str;
            }

            public static char ToLowerFastIf(char c)
            {
                // Use if-statement.
                if (c >= 'A' && c <= 'Z')
                {
                    return (char)(c + 32);
                }
                else
                {
                    return c;
                }
            }


            public static int LengthOfLongestSubstring(string s)
            {
                if (s == null)
                    return 0;
                if (s.Length == 1)
                    return 1;

                int max = 0;
                Hashtable ht = new Hashtable();
                int counter = 0;
                int i = 0;
                int j = 0;

                while (j < s.Length)
                {
                    if (ht.ContainsKey(s[j]) || ht.ContainsKey("***"))
                    {
                        max = counter > max ? counter : max;
                        i++;
                        j = i;
                        ht.Clear();
                        counter = 0;
                    }
                    else
                    {
                        if (s[j] == ' ')
                            ht.Add("***", 1);
                        else
                            ht.Add(s[j], 1);
                        j++;
                        counter++;
                    }
                }
                return max;

            }

            public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
            {



                double count1 = getMedian(nums1);
                double count2 = getMedian(nums2);

                return (double)((count1 + count2) / 2);

            }

            private static double getMedian(int[] arr)
            {
                if (arr.Length == 0)
                    return 0;
                if (arr.Length == 1)
                    return arr[0];
                int count = arr.Length;

                if (count % 2 == 0) // even
                {
                    int item1 = arr[count / 2];
                    int item2 = arr[count / 2 - 1];
                    double sum = item1 + item2;
                    return sum / 2;
                }
                else // odd
                    return (double)(arr[count / 2]);
            }

            public static int MyAtoi(string str)
            {
                string newNumber = str.Trim();
                string potentialNumber = newNumber.Split(' ')[0];
                string NumberToCreate = string.Empty;

                long longNumberToTest;
                int newCreatedNumber;
                bool isTooBig = false;
                bool isTooSmall = false;

                if (potentialNumber.Length == 0 || char.IsLetter(potentialNumber[0]))
                    return 0;
                else
                {
                    int i = 0;
                    StringBuilder stringBuilder = new StringBuilder("");
                    if (potentialNumber.StartsWith("-") || potentialNumber.StartsWith("+"))
                        stringBuilder.Append(potentialNumber[i++]);

                    while (i < potentialNumber.Length && char.IsNumber(potentialNumber[i]))
                    {
                        stringBuilder.Append(potentialNumber[i++]);
                        long.TryParse(stringBuilder.ToString(), out longNumberToTest);
                        if (longNumberToTest > Int32.MaxValue)
                        {
                            isTooBig = true;
                            break;
                        }
                        else if (longNumberToTest < Int32.MinValue)
                        {
                            isTooSmall = true;
                            break;
                        }
                    }

                    if (isTooBig)
                        return Int32.MaxValue;
                    else if (isTooSmall)
                        return Int32.MinValue;
                    else if (int.TryParse(stringBuilder.ToString(), out newCreatedNumber))
                        return newCreatedNumber;
                    else
                        return 0;
                }

            }


            static bool isPolindrom(string text)
            {
                if (text.Length <= 1)
                    return true;
                else
                {
                    if (text[0] != text[text.Length - 1])
                        return false;
                    else
                        return isPolindrom(text.Substring(1, text.Length - 2));
                }
            }

            static bool isAllTheSameButTheMiddleOne(string text)
            {
                int position = text.Length / 2;
                if (text.Length % 2 == 1)
                {
                    string part1 = text.Substring(0, text.Length - position - 1);
                    string part2 = text.Substring(position + 1, text.Length - position - 1);
                    //position++;
                    if (allCharactersSame(part1) && allCharactersSame(part2) && part1 == part2 && text[position] != text[position - 1])
                        return true;
                    else if (allCharactersSame(part1))
                        return true;
                    else
                        return false;

                }
                else
                {

                    string part1 = text.Substring(0, text.Length - position);
                    string part2 = text.Substring(position, text.Length - position);

                    if (allCharactersSame(part1) && allCharactersSame(part2) && part2 == part1)
                        return true;
                    else
                        return false;
                }
            }

            static bool allCharactersSame(string s)
            {
                int n = s.Length;
                for (int i = 1; i < n; i++)
                    if (s[i] != s[0])
                        return false;

                return true;
            }

            static long substrCount(int n, string s)
            {

                long counter = n; // Every letter on it's own
                Hashtable map = new Hashtable();
                for (int i = 0; i <= n; i++)
                {
                    for (int y = n; y > i; y--)
                    {
                        int length = y - i;
                        string sss = s.Substring(i, length);
                        if (length > 1)
                        {
                            // To make sure there are no duplicates
                            if (isAllTheSameButTheMiddleOne(s.Substring(i, length)))
                            {
                                counter++;
                            }
                        }

                    }
                }
                return counter;

            }

            static internal void InsertLast(SingleLinkedList singlyList, int new_data)
            {
                Node new_node = new Node(new_data);
                if (singlyList.head == null)
                {
                    singlyList.head = new_node;
                    return;
                }
                Node lastNode = GetLastNode(singlyList);
                lastNode.next = new_node;
            }

            static internal Node GetLastNode(SingleLinkedList singlyList)
            {
                Node temp = singlyList.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                return temp;
            }

            private static bool searchLinkedList(LinkedListNode<int> linkedList, int valueToSearch)
            {
                if (linkedList.Next == null)
                    return false;
                if (linkedList.Value == valueToSearch)
                    return true;
                else
                    return searchLinkedList(linkedList.Next, valueToSearch);
            }

            private static LinkedListNode<int> reverseLinkedList(LinkedListNode<int> linkedList)
            {
                if (linkedList.Next == null)
                    return linkedList;
                var item = reverseLinkedList(linkedList.Next);
                return linkedList;
            }

            public static int[] TwoSum(int[] nums, int target)
            {
                Hashtable map = new Hashtable();
                for (int i = 0; i < nums.Length; i++)
                {
                    int difference = target - nums[i];
                    if (map.ContainsKey(difference))
                        return new int[] { (int)map[difference], i };
                    map.Add(nums[i], i);
                }
                return new int[] { };
            }


            public static int ReverseNotReC(int num)
            {
                int reverse = 0;
                while (num != 0)
                {
                    reverse = reverse * 10;
                    reverse = reverse + num % 10;
                    num = num / 10;
                }
                return reverse;
            }

            public static int printRec(int itemsToPront)
            {
                if (itemsToPront == 1)
                    return 1;
                Console.Write(itemsToPront);
                return printRec(itemsToPront - 1);
            }

            static int birthday(List<int> s, int d, int m)
            {
                int sum = 0;
                int tempValue = 0;

                if (m != 1)
                {
                    // Make sure you don't check the last m items
                    for (int i = 0; i <= s.Count - m; i++)
                    {
                        int startingIndex = i;
                        int consecutiveNumbersToCheck = m;
                        while (consecutiveNumbersToCheck > 0)
                        {
                            tempValue += s[startingIndex++];
                            consecutiveNumbersToCheck--;
                        }

                        if (tempValue == d)
                            sum++;
                        tempValue = 0;
                    }
                }
                else
                    // Double check the all the items the equals d
                    sum = s.FindAll(x => x == d).Count;

                return sum;
            }

            static int sockMerchant(int n, int[] ar)
            {
                Hashtable map = new Hashtable();
                int pairsToSell = 0;

                for (int i = 0; i < ar.Length; i++)
                {
                    if (map.ContainsKey(ar[i]) && (int)map[ar[i]] == 1)
                    {
                        pairsToSell++;
                        map.Remove(ar[i]);
                    }
                    else
                        map.Add(ar[i], 1);
                }
                return pairsToSell;
            }

            static int hourglassSum(int[][] arr)
            {
                int max_sum = int.MinValue;
                for (int i = 0; i < arr[0].Length - 2; i++)
                {
                    for (int j = 0; j < arr[0].Length - 2; j++)
                    {
                        // left cell of hour glass. 
                        int sum = arr[i][j] + arr[i][j + 1] +
                                   arr[i][j + 2] + arr[i + 1][j + 1] +
                                  arr[i + 2][j] + arr[i + 2][j + 1] +
                                   arr[i + 2][j + 2];

                        // If previous sum is less then  
                        // current sum then update 
                        // new sum in max_sum 
                        max_sum = Math.Max(max_sum, sum);
                    }
                }
                return max_sum;
            }


            static int minimumSwaps(int[] arr)
            {
                bool sorted = false;
                Dictionary<int, int> map = new Dictionary<int, int>();
                for (int i = 1; i <= arr.Length; i++)
                {
                    map.Add(i, arr[i - 1]);
                }

                int amountNotSwapped = 0;
                int minSwaps = 0;
                while (!sorted)
                {
                    for (int i = 1; i <= arr.Length; i++)
                    {
                        if (i != map[i])
                        {
                            //int locationInArray = (int)map[i];
                            int locationForTheCurrentItem = 0;

                            foreach (var dic in map)
                            {
                                if (dic.Value == i)
                                {
                                    locationForTheCurrentItem = dic.Key;
                                    break;
                                }
                            }
                            int itemValue = map[locationForTheCurrentItem];
                            map[locationForTheCurrentItem] = map[i];
                            map[i] = itemValue;
                            minSwaps++;
                            map.Remove(i);
                        }
                        else
                            sorted = true;
                    }
                }
                return minSwaps;
            }

            static int[] rotLeft(int[] a, int d)
            {
                while (d > 0)
                {
                    int storeValue = a[0];
                    for (int i = 1; i < a.Length; i++)
                    {
                        a[i - 1] = a[i];
                    }
                    a[a.Length - 1] = storeValue;
                    d--;
                    if (d == 0)
                        break;

                }
                return a;
            }

        }


    }
}