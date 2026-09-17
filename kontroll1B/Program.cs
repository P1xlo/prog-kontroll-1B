List<Student> students = new List<Student>();
List<Course> courses = new List<Course>();
int i;
int q;
bool on = true;
while(on)
{
    Console.WriteLine("Skriv in antingen Student eller Kurs för vad du vill göra");
    string? ans = Console.ReadLine();
    switch(ans)
    {
        case "Student":
        case "student":

        Console.WriteLine("Student:\n" +
            "1.   Registrera ny student\n" +
            "2.   Lägga till en student i en kurs\n" +
            "3.   Ta bort en student i från en kurs\n" +
            "4.   Skriv ut en students schema" );

            while(!int.TryParse(Console.ReadLine(), out i) || i > 4 || i < 1)
            {
                Console.WriteLine("Skiv ett nummer mellan 1-4");
            }
            fStudent(i);

            break;
        case "Kurs":
        case "kurs":
        Console.WriteLine("Student:\n" +
            "1.   Registrera ny kurs\n" +
            "2.   Lägga till en student i en kurs\n" +
            "3.   Ta bort en student i från en kurs\n" +
            "4.   Skriv ut kursens studenter\n" +
            "5.   Antal platser kvar i en kurs");

            while(!int.TryParse(Console.ReadLine(), out i) || i > 5 || i < 1)
            {
                Console.WriteLine("Skiv ett nummer mellan 1-5");
            }
            fCourse(i);

            break;
        default:

            break;
    }
}

void fStudent(int s)
{
    
    switch(i)
    {
        case 1:
        Console.WriteLine("Skriv namnet på studenten du vill registrera.");
        students.Add(new Student(Console.ReadLine()));

        break;
        case 2:
        Console.WriteLine("Studentens namn: ");
        string sName = Console.ReadLine();

        Console.WriteLine("Kursens namn: ");
        string cName = Console.ReadLine();

        Student _s = students.Find(s => s.Name == sName);
        Course _c = courses.Find(c => c.Name == cName);

        if(_s != null && _c != null)
        {
            _s.JoinCourse(_c);
            Console.WriteLine($"{_s.Name} gick med i kursen {_c.Name}");
        }
        else
            Console.WriteLine("Studenten eller kursen hittades inte");

        break;
        case 3:

        break;
        case 4:

        break;
    }
}

void fCourse(int c)
{
    switch(i)
    {
        case 1:
        Console.WriteLine("Skriv namnet på kursen du vill skapa");
        string kN = Console.ReadLine();
        Console.WriteLine("Antal max platser");
        while(!int.TryParse(Console.ReadLine(), out q))
        {
            Console.WriteLine("Skiv ett nummer");
        }
        courses.Add(new Course(kN,q));
        

        break;
        case 2:

        break;
        case 3:

        break;
        case 4:

        break;
    }
}