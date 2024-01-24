namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (AcademyContext context = new AcademyContext())
            {
                context.Database.EnsureCreated();
            }

            using (var context = new AcademyContext())
            {
                context.Departments.ToList();
                context.Faculties.ToList();
                context.Groups.ToList();
            }
        }
    }
}
