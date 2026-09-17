List<Student> students = new List<Student>();
List<Course> courses = new List<Course>();
int i;
int q;
bool on = true;
while(on)
{
    Console.Clear();
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
            "4.   Skriv ut en students schema\n" +
            "5.   Gå back ett steg");
            

            while(!int.TryParse(Console.ReadLine(), out i) || i > 5 || i < 1)
            {
                Console.WriteLine("Skiv ett nummer mellan 1-5");
            }
            if(i == 5)
                break;
            fStudent(i);

            break;
        case "Kurs":
        case "kurs":
        Console.WriteLine("Kurs:\n" +
            "1.   Registrera ny kurs\n" +
            "2.   Lägga till en student i en kurs\n" +
            "3.   Ta bort en student i från en kurs\n" +
            "4.   Skriv ut kursens studenter\n" +
            "5.   Antal platser kvar i en kurs\n" +
            "6.   Gå back ett steg");

            while(!int.TryParse(Console.ReadLine(), out i) || i > 6 || i < 1)
            {
                Console.WriteLine("Skiv ett nummer mellan 1-6");
            }
            if(i == 6)
                break;
            fCourse(i);

            break;
        default:

            break;
    }
}

void fStudent(int s)
{
    string? sName;
    string? cName;
    Student _s;
    Course _c;
    
    switch(i)
    {
        
        case 1: //lägga till student
        Console.WriteLine("Skriv namnet på studenten du vill registrera.");
        students.Add(new Student(Console.ReadLine()));

        break;
        case 2:// reg student till kurs
        Console.WriteLine("Studentens namn: ");
        sName = Console.ReadLine();

        Console.WriteLine("Kursens namn: ");
        cName = Console.ReadLine();

        _s = students.Find(s => s.Name == sName);
        _c = courses.Find(c => c.Name == cName);

        if(_s != null && _c != null)
        {
            _s.JoinCourse(_c);
            Console.WriteLine($"{_s.Name} gick med i kursen {_c.Name}");
        }
        else
            Console.WriteLine("Studenten eller kursen hittades inte");

        break;
        case 3:// ta bort student från kurs
        Console.WriteLine("Studentens namn: ");
        sName = Console.ReadLine();

        Console.WriteLine("Kursens namn: ");
        cName = Console.ReadLine();

        _s = students.Find(s => s.Name == sName);
        _c = courses.Find(c => c.Name == cName);

        if(_s != null && _c != null)
        {
            _s.LeaveCourse(_c);
            Console.WriteLine($"{_s.Name} lämnade kursen {_c.Name}");
        }
        else
            Console.WriteLine("Studenten eller kursen hittades inte");


        break;
        case 4://schema
        Console.WriteLine("Studentens namn: ");
        sName = Console.ReadLine();
        _s = students.Find(s => s.Name == sName);
        if(_s != null)
            _s.Schedule();
        else
            Console.WriteLine("Kunde inte hitta en student med det namnet");

        break;
    }
    Console.WriteLine("Tryck på retur för att fortsätta");
    Console.ReadLine();
}

void fCourse(int c)
{
    switch(i)
    {
        case 1://ny kurs
        Console.WriteLine("Skriv namnet på kursen du vill skapa");
        string kN = Console.ReadLine();
        Console.WriteLine("Antal max platser");
        while(!int.TryParse(Console.ReadLine(), out q))
        {
            Console.WriteLine("Skiv ett nummer");
        }
        courses.Add(new Course(kN,q));
        

        break;
        case 2:// lägga till student i kurs

        break;
        case 3: // ta bort student ifrån kurs

        break;
        case 4: // studenter i en kurs

        break;
        case 5: // antal plater / max antal platser i en kurs


        break;
    }
    Console.WriteLine("Tryck på retur för att fortsätta");
    Console.ReadLine();
}