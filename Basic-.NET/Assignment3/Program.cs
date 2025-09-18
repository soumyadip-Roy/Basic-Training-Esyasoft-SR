namespace Data_structure_demo
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            //List Example
            List<Student> students = new List<Student>();

            // Add Student objects to the list
            Student first = new Student(1, "Alice", 10);
            Student second = new Student(2, "Bob", 90);
            Student third = new Student(3, "Charlie", 78);
            students.Add(first);
            students.Add(second);
            students.Add(third);


            // Access and display each student using foreach
            Console.WriteLine("Student List:");
            foreach (Student s in students)
            {
                Console.WriteLine($"ID: {s.id}, Name: {s.name}, Marks: {s.marks}");
            }

            // Access a specific object by index
            Console.WriteLine($"\nSecond student is: {students[1].name}");


            //Dictionay Example
            Dictionary<string, Student> students_dict = new Dictionary<string, Student>();
            students_dict.Add("firstStudent", first);
            students_dict.Add("secondStudent", second);
            students_dict.Add("thirdStudent", third);


            foreach (KeyValuePair<string, Student> student in students_dict)
            {
                Console.WriteLine(student.Value.id);
            }


            //Hashset Example
            Console.WriteLine("HashSet demo");
            HashSet<Student> students_hashset = new HashSet<Student>();
            students_hashset.Add(first);
            students_hashset.Add(second);
            students_hashset.Add(first);
            students_hashset.Add(third);

            foreach (Student student in students_hashset)
            {
                Console.WriteLine(student.id);
            }


            //StackDemo


            Stack<Student> students_stack = new Stack<Student>();
            students_stack.Push(first);
            students_stack.Push(second);
            students_stack.Push(third);

            Student pop_stack = students_stack.Pop();
            Console.WriteLine(pop_stack.name);


            //Queue demo
            Console.WriteLine("Queue demo");
            Queue<Student> students_queue = new Queue<Student>();
            students_queue.Enqueue(first);
            students_queue.Enqueue(second);
            students_queue.Enqueue(third);

            Console.WriteLine(students_queue.Dequeue().name);

            //Linked List Example
            LinkedList<Student> students_list = new LinkedList<Student>();
            students_list.AddFirst(first);
            students_list.AddLast(second);
            students_list.AddLast(third);

            Console.WriteLine("Linked List data of Student: ");

            foreach (Student student_node_data in students_list)
            {
                Console.WriteLine("");
                Console.WriteLine("Name: "+student_node_data.name);
                Console.WriteLine("Id: "+student_node_data.id);
                Console.WriteLine("Marks: "+student_node_data.marks);
            }

            // Tuple Implementation

            Tuple<Student> student_first = new Tuple<Student>(first);
            Tuple<Student> student_second = new Tuple<Student>(second);
            Tuple<Student> student_third = new Tuple<Student>(third);

            List<Tuple<Student>> students_tuple_list = new List<Tuple<Student>>();

            // Add Student objects to the list
            students_tuple_list.Add(student_first);
            students_tuple_list.Add(student_second);
            students_tuple_list.Add(student_third);

            Console.WriteLine("Tuple data of Student: ");

            foreach (Tuple<Student> student_data in students_tuple_list)
            {
                Console.WriteLine("");
                Console.WriteLine("Name: " + student_data.Item1.name);
                Console.WriteLine("Id: " + student_data.Item1.id);
                Console.WriteLine("Marks: " + student_data.Item1.marks);
            }







        }
    }
}
