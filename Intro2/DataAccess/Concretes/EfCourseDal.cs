using Intro2.DataAccess.Abstracts;
using Intro2.Entites;

namespace Intro2.DataAccess.Concretes;

public class EfCourseDal : ICourseDal
{
	List<Course> courses;
	public EfCourseDal()
	{
		//veritabanından gelmiş gibi datalar ve onları array e ekliyoruz.
		Course course1 = new Course();
		course1.Id = 1;
		course1.CourseName = "Python";
		course1.CourseDescription = "python 8...";
		course1.Price = 0;

		Course course2 = new Course();
		course2.Id = 2;
		course2.CourseName = "JavaScript";
		course2.CourseDescription = "javascript 17...";
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
