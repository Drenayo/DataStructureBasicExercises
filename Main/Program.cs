using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataHierarchyBasicExercises.Problem;
using DataHierarchyBasicExercises.Algorithm;
using DataHierarchyBasicExercises.DataStructure;
using DataHierarchyBasicExercises.Utils;
using System.Diagnostics;

namespace DataHierarchyBasicExercises
{
    class Program
    {
        static void Main(string[] args)
        {


            #region 树
            // 子节点链表示法
            TreeChild<string> tree = new TreeChild<string>("Root");
            tree.AddNode("A", tree.Root);
            tree.AddNode("B", tree.Root);
            tree.AddNode("C", tree.Root);
            tree.AddNode("E", tree.AddNode("D", tree.AddNode("C", tree.Root)));
            Console.WriteLine("前序：");
            tree.PreOrderTraversal(tree.Root);
            Console.WriteLine();
            Console.WriteLine("层序：");
            tree.LevelOrderTraversal(tree.Root);
            Console.WriteLine();


            //tree.PrintArray();
            //Console.WriteLine("深度：" + tree.GetDeep());
            //Console.WriteLine("返回根的第二个子节点：" + tree.GetChild(tree.Root, 3));



            //List<TreeChild<string>.Node> list = new List<TreeChild<string>.Node>();
            //list = tree.GetChildren(tree.Root);
            //Console.WriteLine("测试返回Root的子节点集合：");
            //foreach (TreeChild<string>.Node item in list)
            //{
            //    Console.WriteLine(item);
            //}
            // 父节点表示法
            //Tree_Parent<string> tree = new Tree_Parent<string>("Root");
            //Tree_Parent<string>.Node nodeTemp = null;
            //tree.addNode("A", tree.Root);
            //tree.addNode("B", tree.Root);
            //tree.addNode("C", tree.Root);

            //nodeTemp = tree.GetNodeByData("A");
            //tree.addNode("D", nodeTemp);
            //tree.addNode("E", nodeTemp);
            //tree.addNode("F", nodeTemp);

            //nodeTemp = tree.GetNodeByData("F");
            //tree.addNode("I", nodeTemp);
            //tree.addNode("K", nodeTemp);
            //tree.addNode("J", nodeTemp);

            //foreach (Tree_Parent<string>.Node node in tree.GetChildren(nodeTemp))
            //{
            //    Console.WriteLine(node);
            //}
            //tree.PrintArray();
            //Console.WriteLine("树深度:" + tree.GetDeep().ToString());





            // 堆排序验证
            //CompleteBinaryTree<int> tree = new CompleteBinaryTree<int>(122);
            ////for (int i = 100; i > 0; i--)
            ////{
            ////    tree.Add(i);
            ////}
            ////tree.LevelOrderTraversal_();

            ////tree.HeapSort(tree.ToArray(), tree.Count);
            //int[] arr = { 21, 4, 65, 7, 8, 45, 12, 3456, 768, 34 };
            //tree.HeapSort(arr, arr.Length);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //CompleteBinaryTree<String> tree = new CompleteBinaryTree<String>(30);
            //for (char i = 'A'; i <= 'Z'; i++)
            //{
            //    tree.Add(i.ToString());
            //}
            //tree.PreorderTraversal();
            //tree.InorderTraversal();
            //tree.PostorderTraversal();
            //tree.LevelOrderTraversal();

            /*
             * 空树
             * 只有一个根节点的树
             *  
             * 
             * 
             */
            #endregion



            #region 集合 字典 数据结构
            //LinkedListDictionary<string, int> dic = new LinkedListDictionary<string, int>();
            //dic.Add("11", 12);
            //dic.Add("22", 34);
            //dic.Add("33", 56);
            ////dic.Add("33", 56);

            //Console.WriteLine(dic.GetValue("22"));
            //dic.SetValue("22", 3412);
            //// dic.Remove("22");
            //Console.WriteLine(dic.ContainsKey("22"));

            #endregion

            #region 栈与队列 数据结构测试
            // 链表队列
            //LinkedListQueue<String> strList = new LinkedListQueue<string>();
            //strList.Enqueue("dd");
            //strList.Enqueue("ee");
            //strList.Enqueue("aa");
            //Console.WriteLine(strList);
            //strList.Dequeue();
            //Console.WriteLine(strList);



            // 循环数组队列 VS 普通动态数组队列 性能测试  数组越大，普通动态数组队列出队时间越长，10万基本上就等不出来结果了，一万的差距是百倍以上，5万则是千倍
            //Stopwatch t1 = new Stopwatch();
            //Stopwatch t2 = new Stopwatch();

            //ArrayQueue<string> arrQueue = new ArrayQueue<string>();
            //ArrayCycleQueue<string> arrCycle = new ArrayCycleQueue<string>(10);

            //for (int i = 0; i < 100000; i++)
            //{
            //    arrQueue.Enqueue(i.ToString());
            //    arrCycle.Enqueue(i.ToString());
            //}

            //t1.Start();

            //for (int i = 0; i < 50000; i++)
            //    arrQueue.Dequeue();
            //t1.Stop();

            //Console.WriteLine($"普通出队用时：{t1.ElapsedMilliseconds} ms \n\n");

            //t2.Start();
            //for (int i = 0; i < 50000; i++)
            //    arrCycle.Dequeue();
            //t2.Stop();

            //Console.WriteLine($"循环队列出队用时：{t2.ElapsedMilliseconds} ms \n\n");
            // 循环数组队列测试
            //ArrayCycleQueue<string> arr = new ArrayCycleQueue<string>(10);
            //arr.Enqueue("物质");
            //arr.Enqueue("热闹");
            //arr.Enqueue("人类");
            //Console.WriteLine(arr);
            //arr.Dequeue();
            //Console.WriteLine(arr);
            // 数组队列测试
            //ArrayQueue<string> strQu = new ArrayQueue<string>();
            //strQu.Enqueue("物质");
            //strQu.Enqueue("嘻嘻");
            //strQu.Enqueue("牢笼");
            //Console.WriteLine(strQu);
            //strQu.Dequeue();
            //Console.WriteLine(strQu);
            //strQu.Dequeue();
            //Console.WriteLine(strQu);
            //strQu.Dequeue();
            //Console.WriteLine(strQu); 
            // 让所有自定义数据结构都继承同一个父接口
            // 数组队列和链表队列

            // 链表头部栈顶 和 链表尾部栈顶 测试
            // 链表头部O1链表尾部On

            // 数组栈和链表栈性能测试

            // 数组栈 和 链表栈 的测试
            //LinkedListStack<string> stack = new LinkedListStack<string>();

            //stack.Push("第一号");
            //stack.Push("第二号");
            //stack.Push("第三号");
            //Console.WriteLine(stack);
            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack);
            //Console.WriteLine(stack.IsEmpty);
            #endregion

            #region  自定义链表数据结构测试

            //SingleLinkedList<string> strList = new SingleLinkedList<string>();
            //strList.Add("测试1");
            //strList.Add("无敌2");
            //strList.Add("好好3");
            //strList.Add("迭代4");
            //strList.Add("滴滴5");
            //Console.WriteLine(strList);
            //strList.Remove("无敌2");
            //Console.WriteLine(strList);
            //strList.Remove("好好3");
            //Console.WriteLine(strList);
            //strList.Remove("滴滴5");
            //Console.WriteLine(strList);
            //strList.Remove("滴滴5sa");
            //Console.WriteLine(strList);
            //Console.WriteLine(strList);
            //strList.Insert(1, "无敌之前");
            //Console.WriteLine(strList);
            //strList.Insert(1, "无敌之前2");
            //Console.WriteLine(strList);
            //Console.WriteLine(strList.GetValue(1) + "   " + strList.GetValue(2));
            //strList.SetValue(2, "测试修改无敌");
            //Console.WriteLine(strList.GetValue(1) + "   " + strList.GetValue(2));
            //Console.WriteLine(strList);
            //Console.WriteLine("//----------------------");
            //Console.WriteLine(strList);
            //Console.WriteLine(strList.Contains("滴滴s"));
            //strList.SetValue(4, "nullllll设置");
            //strList.SetValue(1, null);
            //Console.WriteLine(strList);
            //Console.WriteLine("//----------------------");
            ////strList.RemoveAt(1);
            //strList.Remove("测试1");
            //Console.WriteLine(strList);

            #endregion

            #region 各种查找算法 查找速度ms对比
            // 二分查找的性能消耗 VS 系统自带的
            //Stopwatch t1 = new Stopwatch();


            //List<int> list1 = GenerateTestData.GetRandomLengthList(10000, 10000);
            //Sort.BubbleSort(list1);


            //t1.Start();

            //// 对一个一万大小，一万以内随机数的List，重复查询一百万次
            //// 系统 600ms
            //// 二分 100ms
            //for (int i = 0; i < 1000000; i++)
            //{
            //    //list1.IndexOf(999);
            //    Search.BinarySearch(list1, 999);
            //}


            //t1.Stop();
            //Console.WriteLine($"查询用时：{t1.ElapsedMilliseconds} ms \n\n");

            #endregion

            #region 各种排序算法 排序List 性能问题
            //// 准备
            //Stopwatch t1 = new Stopwatch();
            //Stopwatch t2 = new Stopwatch();

            //t1.Start();

            //for (int i = 0; i < 100000; i++)
            //{
            //    List<int> list1 = GenerateTestData.GetRandomLengthList(50, 100);
            //    Sort.BubbleSort(list1);
            //}

            //t1.Stop();

            //t2.Start();
            //for (int i = 0; i < 100000; i++)
            //{
            //    List<int> list2 = GenerateTestData.GetRandomLengthList(50, 100);
            //    Sort.InsertSort2(list2);
            //}
            //t2.Stop();

            //Console.WriteLine($"冒泡List排序用时：{t1.ElapsedMilliseconds} ms \n\n");
            //Console.WriteLine($"插入List排序用时：{t2.ElapsedMilliseconds} ms \n\n");




            //// 遍历
            //Console.WriteLine("遍历查找:");
            //for()

            //// 二分
            //Console.WriteLine("二分查找:");


            #endregion

            #region List与ArrayList装箱拆箱性能测试   List 9ms,ArrayList 79ms
            //int n = 1000000;
            //Stopwatch t1 = new Stopwatch();
            //Console.WriteLine("测试List");
            //t1.Start();

            //List<int> l = new List<int>();
            //for (int i = 0; i < n; i++)
            //{
            //    l.Add(i);
            //    int x = l[i];
            //}

            //t1.Stop();
            //Console.WriteLine($"用时：{t1.ElapsedMilliseconds} ms \n\n");

            //Stopwatch t2 = new Stopwatch();
            //Console.WriteLine("测试ArrayList");
            //t2.Start();
            //ArrayList arr = new ArrayList();
            //for (int i = 0; i < n; i++)
            //{
            //    arr.Add(i);
            //    int x = (int)arr[i];
            //}

            //t2.Stop();
            //Console.WriteLine($"用时：{t2.ElapsedMilliseconds} ms \n\n");


            #endregion

            #region MyArrayList 与 MyArrayList2<T> 数据结构测试

            //-------------------------
            // Conslog
            //[元素数量:3,数组容量: 10]
            //[ccccasda, 我giao, 32门]
            //[元素数量:2,数组容量: 5]
            //[ccccasda, 32门]
            //MyArrayList2<string> strList = new MyArrayList2<string>(10);
            //strList.Add("ccccasda");
            //strList.Add("我giao");
            //strList.Add("32门");
            //Console.WriteLine(strList.ToString());
            //strList.Remove("我giao");
            //Console.WriteLine(strList.ToString());

            //使用测试MyArrayList Sort----------------------
            //MyArrayList myList = new MyArrayList(10);
            //myList.Add(5);
            //myList.Add(6);
            //myList.Add(3);
            //myList.Add(4);
            //myList.Add(32);
            //myList.Sort();
            //Console.WriteLine(myList.ToString());

            //--------------------
            //MyArrayList myList = new MyArrayList(10);
            //myList.Add(1);
            //myList.Add(2);
            //myList.Add(3);
            //myList.Add(4);
            //myList.Add(4);

            //Console.WriteLine(myList.ToString());
            //Console.WriteLine(myList.Contains(2));
            //Console.WriteLine(myList.Contains(4));
            //Console.WriteLine(myList.Contains(5));

            //---------------
            //ArrayList list = new ArrayList(100);
            //list.Insert(4, 1);
            //ToString_(list.Count, list.Capacity, list.ToArray());
            #endregion

            #region 第二天练习 空 累加和的做法、等概率随机数应用、其他待看
            // 无

            #endregion

            #region 第一天练习 位操作、3种简单排序、对数器的写法
            // 对数器
            // AlgorithmTester.Testor(100);

            //int[] arr = AlgorithmTester.GenerateRandomArray(39,1000);

            //Console.WriteLine("插入测试 原数组");
            //SortHelp.PrintArray(arr);

            //Console.WriteLine("插入测试 排序后");

            //Sort.InsertSort2(arr);
            //SortHelp.PrintArray(arr);


            ///二进制与位操作测试

            /*
            int aNumber = 50;
            int bNumber = 340;

            Console.Write("原始值A打印       ");
            PrintBinary.PrintNumberBinary(aNumber);
            Console.Write("原始值B打印       ");
            PrintBinary.PrintNumberBinary(bNumber);

            Console.Write("AB 按位与 & 打印  ");
            PrintBinary.PrintNumberBinary(aNumber & bNumber);

            Console.Write("AB 按位或 | 打印：");
            PrintBinary.PrintNumberBinary(aNumber | bNumber);

            Console.Write("AB 按位异或 ^ 打印");
            PrintBinary.PrintNumberBinary(aNumber ^ bNumber);

            Console.Write("A 按位取反 ~ 打印 ");
            PrintBinary.PrintNumberBinary(aNumber<<1);

            Console.Write("A 按位右移   打印 ");
            PrintBinary.PrintNumberBinary(aNumber>>1);*/




            ///测试排序算法
            /* int[] arr = SortHelp.GetRandom(10);

             Console.WriteLine("冒泡测试 原数组");
             SortHelp.PrintArray(arr);

             Console.WriteLine("冒泡测试 排序后");

             Sort.InsertSort2(arr);
             SortHelp.PrintArray(arr);*/

            #endregion

            Console.ReadKey();
        }

        static void ToString_(int count, int Capacity, object[] data)
        {
            StringBuilder res = new StringBuilder();
            res.Append(string.Format($"[元素数量:{count},数组容量:{Capacity}]\n"));
            res.Append(string.Format("["));

            for (int i = 0; i < count; i++)
            {
                res.Append(data[i]);
                if (i != count - 1)
                    res.Append(", ");
            }

            res.Append(string.Format("]"));
            Console.WriteLine(res.ToString());
        }
    }
}
