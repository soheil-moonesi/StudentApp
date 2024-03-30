

using System.Xml.Linq;
using Uni;

string addScholarStatus = "y";
int tempScholarId;
int tempClassId;

ScholarManager scholarManager = new ScholarManager();
ClassManager classManager = new ClassManager();

static void ScholarIni(ClassManager classManager, ScholarManager scholarManager)
{
    AddingScholar("Soheil", "moonesi", 11111, classManager, scholarManager);
    AddingScholar("Ali", "Najafi", 22222, classManager, scholarManager);
    AddingScholar("soheil", "mohseni", 33333, classManager, scholarManager);
    AddingScholar("mohammadreza", "jafari", 44444, classManager, scholarManager);

}
ScholarIni(classManager,scholarManager);

static void ClassIni(ScholarManager scholarManager,ClassManager classManager)
{
    AddingClass(12345, "computer science", scholarManager,classManager);
    AddingClass(56789, "Math", scholarManager, classManager);
    AddingClass(101112, "Physics", scholarManager, classManager);
}
ClassIni(scholarManager,classManager);


ScholarManager.ScoresIni(scholarManager);


string continueStatus = "y";
while ( continueStatus=="y")

{
    Console.WriteLine("1 add scholar ,2 add class to all shcolars,3 remove shcolar, 4 romve class from all scholars,5 edit scholar info," +
        "7 submit scholar class score,9 sort scholars by name,10 sort scholar by scores,11 minimum score class");
    string z = Console.ReadLine();
    switch (z)
    {

        case "1":
            addScholarStatus = "y";
            while (addScholarStatus == "y")
            {
                Console.WriteLine(value: "insert scholar name:");
                string name = Console.ReadLine();

                Console.WriteLine("insert scholar last name:");
                string lastName = Console.ReadLine();

                tempScholarId = scholarManager.GetAndConvertScholarId("insert scholar id:");
                
                AddingScholar(name,lastName,tempScholarId,classManager,scholarManager);

                Console.WriteLine("do you want to add another Scholar? yes/no");
                addScholarStatus = Console.ReadLine();
            }
            break;

        case "2":
            string addClass = "y";
            while (addClass == "y")
            {
                tempClassId = classManager.GetAndConvertClassId("enter the class id:");

                Console.WriteLine("enter the class name:");
                string className = Console.ReadLine();

                    AddingClass(tempClassId,className,scholarManager, classManager);

                Console.WriteLine("do you want add more class? y/n");
                addClass = Console.ReadLine();
            }
            break;

        case "3":
            string removeScholar = "y";
            while (removeScholar == "y")
            {
               
                tempScholarId = scholarManager.GetAndConvertScholarId("enter scholar id to remove");

                scholarManager.removeScholar(tempScholarId);
            }
            break;

        case "4":
            string removeClass = "y";
            while (removeClass == "y")
            {
                tempClassId = scholarManager.GetAndConvertScholarId("enter class id for emove all class for all scholars");
                scholarManager.RemoveClassScholars(tempClassId);
                classManager.removeClass(tempClassId);
                Console.WriteLine(" do you want to remove more class? y/n");
                removeClass =Console.ReadLine();
                    }
            break;

            case "5":
 
               int tempScholarId2 = scholarManager.GetAndConvertScholarId("wtite scholar id for change");
       
            ScholarManager.ChangeScholar(scholarManager,tempScholarId2);
            break;

        case "7":
            string ScoreAssignStatus = "y";
            while (ScoreAssignStatus == "y")
            {
                tempScholarId = scholarManager.GetAndConvertScholarId("enter scholar id for score assign ");
                 ScholarManager.ScoresAssign(scholarManager,tempScholarId);
                Console.WriteLine(" do you assign score to another scholar? y/n");
                ScoreAssignStatus = Console.ReadLine();
            }
            break;

        case "8":
            ScholarManager.displayScholars(scholarManager);
            break;

        case "9":
            ScholarManager.SortScholarName(scholarManager);
            break;


        case "10":
            ScholarManager.RatingScholar(scholarManager);
            break;

        case "11":
            ScholarManager.MinScoreClass(scholarManager);
            break;

        default:
            Console.WriteLine("Invalid input. Please enter a valid number 1 - 11 ");
            break;


    }
    Console.WriteLine("do u wnat to continue app? y/n");
    continueStatus=Console.ReadLine();
}
static void AddingScholar(string name, string lastName, int tempScholarId,ClassManager classManager,ScholarManager scholarManager)
{
    Scholar scholar = new Scholar(name, lastName, tempScholarId);

    List<UniClass> uniClassUpdate = classManager.GetClasses();

    foreach (UniClass uniClass in uniClassUpdate)
    {
        scholar.ClassScholar.Add(uniClass.GetClassId());
    }

    scholarManager.addScholar(scholar);
}

static void AddingClass(int tempClassId,string className,ScholarManager scholarManager,ClassManager classManager) {
    UniClass uniClass = new UniClass(tempClassId, className);

    scholarManager.AddClassToScholar(tempClassId);
    classManager.addClass(uniClass);
}

public class ScholarComparerRate : IComparer<Scholar>
{
    public int Compare(Scholar x, Scholar y)
    {
        
       return y.Average.CompareTo(x.Average);
    }
}
public class ScholarComparerName : IComparer<Scholar>
{
    public int Compare(Scholar x,Scholar y)
    {
      
        return x.Name.CompareTo(y.Name);
    }
}

