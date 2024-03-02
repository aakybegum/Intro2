using Intro2.DataAccess.Abstracts;
using Intro2.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro2.DataAccess.Concretes;

public class CourseDal : ICourseDal
{
	List<Course> courses;
    public CourseDal()
    {
		//veritabanından gelmiş gibi datalar ve onları array e ekliyoruz.
		Course course1 = new Course();
		course1.Id = 1;
		course1.CourseName = "C#";
		course1.CourseDescription = ".NET 8...";
		course1.Price = 0;

		Course course2 = new Course();
		course2.Id = 2;
		course2.CourseName = "Java";
		course2.CourseDescription = "java 17...";
		course2.Price = 20;

		courses = new List<Course> { course1, course2 };
	}
    public List<Course> GetAll()
	{
		return courses;

	}

	public void Add(Course course)
	{
		courses.Add(course);
	}
}
