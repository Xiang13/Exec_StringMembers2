using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_StringMembers2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Q1 將" abc " 左右的空白刪除
			string str = "  abc  ";
			str = str.Trim();
			Console.WriteLine($"Q1: {str}");  // abc
			Console.WriteLine();


			// Q2 將字串 "Allen Kuo" 轉成大寫 "ALLEN KUO"
			string name = "Allen Kuo";
			name = name.ToUpper();
			Console.WriteLine($"Q2: {name}");  // ALLEN KUO
			Console.WriteLine();


			// Q3 將字串 "aLLeN kUO" 轉換成 "Allen Kuo"
			string name1 = "aLLeN kUO";
			name1 = name1.ToUpper();
			string first = name1.Substring(0, 1);
			string second = name1.Substring(6, 1);
			string mid = name1.Substring(1, 5);
			mid = mid.ToLower();
			string last = name1.Substring(7, 2);
			last = last.ToLower();
			string template = "{0}{1}{2}{3}";
			string message = string.Format(template, first, mid, second, last);
			Console.WriteLine($"Q3: {message}");
			Console.WriteLine();


			// Q4 假設有表示日期的字串"1100225", 請將它轉成表示西元年的日期"20210225"
			string date = "1100225";
			string roc = date.Substring(0, 3);
			int era = Convert.ToInt32(roc);
			int length = date.Length;

			era += 1911;
			string date1 = date.Substring(3, 4);
			Console.WriteLine($"Q4: {era + date1}");
			Console.WriteLine();


			// Q5 比對使用者輸入值是否為 "Allen" 不拘大小寫
			string answer = "Allen";
			Console.Write("Q5: 請輸入名字(Allen): ");
			string input = Console.ReadLine();

			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("Q5: 你沒有輸入名字");
				return;
			}
			if (input.ToLower() == answer.ToLower())
			{
				Console.WriteLine("Q5: 輸入正確");
			}
			else
			{
				Console.WriteLine("Q5: 輸入錯誤");
			}
			Console.WriteLine();


			// Q6 比對使用者輸入值是否為 "Allen", 區分大小寫
			string answer1 = "Allen";
			Console.Write("Q6: 請輸入名字(Allen): ");
			string input1 = Console.ReadLine();

			if (string.IsNullOrEmpty(input1))
			{
				Console.WriteLine("Q6: 你沒有輸入名字");
				return;
			}
			if (input1 == answer1)
			{
				Console.WriteLine("Q6: 輸入正確");
			}
			else
			{
				Console.WriteLine("Q6: 輸入錯誤");
			}
			Console.WriteLine();


			// Q7 計算兩數之和,並只呈現小數二位數
			double d1 = 45.821;
			double d2 = 55.0272;
			double sum = d1 + d2;

			string value = sum.ToString("0.##");
			Console.WriteLine($"Q7: {value}");
			Console.WriteLine();


			// Q8 隱藏手機的資訊
			string phone = "0912111111";
			string firstNum = phone.Substring(0, 4);
			string lastNum = phone.Substring(8, 2);
			string star = new string('*', 4);
			string template1 = "{0}{1}{2}";
			string phoneNum = string.Format(template1, firstNum, star, lastNum);
			Console.WriteLine($"Q8: {phoneNum}");




		}
	}
}
