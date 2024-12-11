namespace Bai1
{
    internal class Program
    {
        static void Main()
        {
            //Nhập số lượng phần tử của mảng
            int n = int.Parse(Console.ReadLine());

            //Nhập mảng có n phần tử số nguyên
            string[] input = Console.ReadLine().Split(' ');
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            //Tìm giá trị lớn nhất và nhỏ nhất và vị trí của chúng trong mảng
            var (max, maxPositions) = FindMaxAndPositions(arr);
            var (min, minPositions) = FindMinAndPositions(arr);

            //In ra kết quả
            Console.WriteLine($"{max} {string.Join(" ", maxPositions)}");
            Console.WriteLine($"{min} {string.Join(" ", minPositions)}");

            Console.ReadKey();
        }

        static (int max, List<int> positions) FindMaxAndPositions(int[] arr)
        {
            int max = arr[0];
            List<int> positions = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    positions.Clear();
                    positions.Add(i);
                }
                else if (arr[i] == max)
                {
                    positions.Add(i);
                }
            }

            return (max, positions);
        }

        static (int min, List<int> positions) FindMinAndPositions(int[] arr)
        {
            int min = arr[0];
            List<int> positions = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    positions.Clear();
                    positions.Add(i);
                }
                else if (arr[i] == min)
                {
                    positions.Add(i);
                }
            }
            return (min, positions);
        }
    }
}

