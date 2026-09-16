List<Student> students;
List<Course> courses;
int i;

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

        break;
        case 2:

        break;
        case 3:

        break;
        case 4:

        break;
    }
}

void fCourse(int c)
{
    
}