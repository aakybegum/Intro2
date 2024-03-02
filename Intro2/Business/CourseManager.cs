using Intro2.DataAccess.Abstracts;
using Intro2.DataAccess.Concretes;
using Intro2.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro2.Business;

public class CourseManager
{ //operasyon tutucu

	private readonly ICourseDal _courseDal;

	public CourseManager(ICourseDal courseDal) //Eğer CourseManager ı new lersen bana bir coursedal vermek zorundasın.
	{
		_courseDal = courseDal;
	}

	public List<Course> GetAll() //sen getAll ı çağırırsan ben sana Course datası veriyorum.
	{
		//Veritabanı katmanına gidip, bu bütün kurallardan geçti datayı(kursları) getir.
		

		return _courseDal.GetAll();

	}
}
