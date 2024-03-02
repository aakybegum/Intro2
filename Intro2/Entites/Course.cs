using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro2.Entites;

public class Course
{
	//özellik tutucu
	public int Id { get; set; }
	public string CourseName { get; set; }
	public string CourseDescription { get; set; }
    public double Price { get; set; }
}
