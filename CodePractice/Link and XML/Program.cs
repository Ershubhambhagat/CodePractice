using System.Xml.Linq;

Console.WriteLine("Hello, World!");
string StudentXML = @"
	<students>

	<student>
		<name>Hood Energy Corp</name>
		<age>22</age>
		<country> Mozambique</country>
		<street>1932 Ashwood Lane</street>
	</student>
	<student>
		<name>Stem Company</name>

		<age>29</age>
		
		<country> Singapore</country>
		<street>2923 Povey Circle</street>
	</student>
	<student>
		<name>Su Holdings GmbH</name>
		<age>20</age>

		<country> Chad</country>
		<street>5892 Whitehall Street</street>
	</student>
	<student>
		<name>Hygiene A.G</name>
		<age>19</age>

		<country> Austria</country>
		<street>9585 Vesta Avenue</street>
	</student>
	<student>
		<name>Favourites LLC</name>
		<age>24</age>

		<country> Georgia</country>
		<street>2382 Moresby Road</street>
	</student>
</students>
";

XDocument StudentsxDocument = new XDocument();
StudentsxDocument=XDocument.Parse(StudentXML);

var students = from student in StudentsxDocument.Descendants("student")
			   select new
			   {
                   Name = student.Element("name").Value,
                   Country =student.Element("country").Value,
                   Street = student.Element("street").Value,
				   Age=student.Element("age").Value

               };
foreach (var student in students)
{
    Console.WriteLine(	"Student name is {0} andCoudtry is {1} and Street is {2} and age is  {3}",student.Name,student.Country,student.Street,student.Age);
}
var shortbyAge = from student2 in students 
				 orderby student2.Age
				 select student2;

foreach (var student3 in shortbyAge)
{
    Console.WriteLine("Order By Age is {0}",student3.Age	);
}
Console.ReadKey();
