using Intro2.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro2.DataAccess.Abstracts;

public interface ICourseDal
{
	List<Course> GetAll();

	void Add(Course course);
}
