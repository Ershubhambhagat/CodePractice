using System.Xml.Linq;

Console.WriteLine("Hello, World!");
string StudentXML = @"
	<students>

	<student>
		<name>Hood Energy Corp</name>
		<country> Mozambique</country>
		<street>1932 Ashwood Lane</street>
	</student>
	<student>
		<name>Stem Company</name>
		<country> Singapore</country>
		<street>2923 Povey Circle</street>
	</student>
	<student>
		<name>Su Holdings GmbH</name>
		<country> Chad</country>
		<street>5892 Whitehall Street</street>
	</student>
	<student>
		<name>Hygiene A.G</name>
		<country> Austria</country>
		<street>9585 Vesta Avenue</street>
	</student>
	<student>
		<name>Favourites LLC</name>
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
               };
foreach (var student in students)
{
    Console.WriteLine(	"Student name is {0} and Coudtry is {1} and Street is {2}",student.Name,student.Country,student.Street);
}