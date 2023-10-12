using MiniConsolEAppEmployment;

public class Program
{
    public static void Main(string[] args)
    {
        Baku baku = new Baku();

        int choice;
        do
        {
            Console.WriteLine("1. Isci elave t");
            Console.WriteLine("2. Telebe elave et");
            Console.WriteLine("3.Isch sayini goster");
            Console.WriteLine("4. Telebe sayin goster");
            Console.WriteLine("5. Iscilere bax");
            Console.WriteLine("6. Telebelere bax");
            Console.WriteLine("7. Adamlari axtar");
            Console.WriteLine("0. Menyudan cix");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddEmployee(baku);
                    break;
                case 2:
                    AddStudent(baku);
                    break;
                case 3:
                    ShowEmployeesCount(baku);
                    break;
                case 4:
                    ShowStudentsCount(baku);
                    break;
                case 5:
                    ShowEmployees(baku);
                    break;
                case 6:
                    ShowStudents(baku);
                    break;
                case 7:
                    SearchPeople(baku);
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Sechim duzgun deyil ");
                    break;
            }
        } while (choice != 0);
    }

    private static void AddEmployee(Baku baku)
    {
        string name, surname;
        int age, position;

        Console.WriteLine("Ad daxil et:");
        name = Console.ReadLine();

        Console.WriteLine("Familia daxil et:");
        surname = Console.ReadLine();

        Console.WriteLine("Yash daxil et:");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Vezife daxil et:");
        position = Convert.ToInt32(Console.ReadLine());

        baku.AddHuman(new Employee(name, surname, age, position.ToString()));
    }

    private static void AddStudent(Baku baku)
    {
        string name, surname;
        int age, grade, groupNo;

        Console.WriteLine("Ad daxil et:");
        name = Console.ReadLine();

        Console.WriteLine("Familia daxil et:");
        surname = Console.ReadLine();

        Console.WriteLine("Yash daxil et:");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Sinifi daxilm et:");
        grade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Qrupun nomresin daxil et:");
        groupNo = Convert.ToInt32(Console.ReadLine());

        baku.AddHuman(new Student(name, surname, age, grade, groupNo));
    }

    private static void ShowEmployeesCount(Baku baku)
    {
        int count = baku.GetEmployees().Count();
        Console.WriteLine("Iscilerin sayi: {0}", count);
    }

    private static void ShowStudentsCount(Baku baku)
    {
        int count = baku.GetStudents().Count();
        Console.WriteLine("Telebellerin sayi: {0}", count);
    }

    private static void ShowEmployees(Baku baku)
    {
        foreach (var employee in baku.GetEmployees())
        {
            employee.ShowInfo();
        }
    }

    private static void ShowStudents(Baku baku)
    {
        foreach (var student in baku.GetStudents())
        {
            student.ShowInfo();
        }
    }

    private static void SearchPeople(Baku baku)
    {
        string name;

        Console.WriteLine("Axtarish ucun ad daxil et:");
        name = Console.ReadLine();

        IEnumerable<Human> people = baku.SearchHumans(name);
        foreach (var person in people)
        {
            person.ShowInfo();
        }
    }
}
