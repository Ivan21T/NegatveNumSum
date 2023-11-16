using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сума_отрицателни_нечетни
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] separator = { ',' };
            List<int> nums=Console.ReadLine().Split(separator,StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> oddNums=new List<int>();
            for (int i = 0; i < nums.Count-1; i++)
            {
                if (nums[i] < 0 && nums[i] % 2 != 0)
                {
                    if (i >= 0 && nums[i + 1] < 0 && nums[i + 1] % 2 != 0)
                    {
                        oddNums.Add(nums[i]);
                    }
                    else if (i != 0 && nums[i - 1] < 0 && nums[i - 1] % 2 != 0 && (nums[i + 1] >= 0 || nums[i + 1] % 2 == 0))
                    {
                        oddNums.Add(nums[i]);
                    }
                    else if (i != 0 && nums[i + 1] < 0 && nums[i + 1] % 2 != 0 && (nums[i - 1] >= 0 || nums[i - 1] % 2 == 0))
                    {
                        oddNums.Add(nums[i]);
                    }
                }    
            }
            if (nums.Count!=1 && nums[nums.Count-1]<0 && nums[nums.Count-1]%2!=0 && nums[nums.Count-2]<0 && nums[nums.Count-2]%2!=0)
            {
                oddNums.Add(nums[nums.Count - 1]);
            }
            Console.WriteLine("{0}",string.Join(",",oddNums));
            Console.WriteLine("Sum:{0}",oddNums.Sum());
        }
    }
}
