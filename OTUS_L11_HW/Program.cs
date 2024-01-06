namespace OTUS_L11_HW
{  

    internal class Program
    {
        static void Main(string[] args)
        {
            // Основное
            var s = new Stack("a", "b", "c");
            // size = 3, Top = 'c'
            Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");
            var deleted = s.Pop();
            // Извлек верхний элемент 'c' Size = 2
            Console.WriteLine($"Извлек верхний элемент '{deleted}' Size = {s.Size}");
            s.Add("d");
            // size = 3, Top = 'd'
            Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");
            s.Pop();
            s.Pop();
            s.Pop();
            // size = 0, Top = null
            Console.WriteLine($"size = {s.Size}, Top = {(s.Top == null ? "null" : s.Top)}");
            s.Pop();

            //Доп 1
            var q = new Stack("a", "b", "c");
            q.Merge(new Stack("1", "2", "3"));
            // в стеке s теперь элементы - "a", "b", "c", "3", "2", "1" <- верхний

            //Доп 2
            var z = Stack.Concat(new Stack("a", "b", "c"), new Stack("1", "2", "3"), new Stack("А", "Б", "В"));
            // в стеке z теперь элементы - "c", "b", "a" "3", "2", "1", "В", "Б", "А" <- верхний
        }
    }
}