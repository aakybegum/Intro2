using Intro2.Business;
using Intro2.DataAccess.Concretes;
using Intro2.Entites;

CourseManager courseManager = new CourseManager(new EfCourseDal());

List<Course> courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Count; i++)
{
	Console.WriteLine(courses2[i].CourseName + " / " + courses2[i].Price);
}

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "11225478965";
customer1.FirstName = "Begüm";
customer1.LastName = "Akyazıcı";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "11225478967";
customer2.FirstName = "Batuhan";
customer2.LastName = "Akyazıcı";
customer2.CustomerNumber = "012345";

CoorporateCustomer customer3 = new CoorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlama.io";
customer3.CustomerNumber = "112344";
customer3.TaxNumber = "1234567891";

CoorporateCustomer customer4 = new CoorporateCustomer();
customer4.Id = 4;
customer4.Name = "ABC";
customer4.CustomerNumber = "112348";
customer4.TaxNumber = "1234567890";

BaseCustomer[] baseCustomers =  new BaseCustomer[] {customer1,customer2,customer3,customer4};

//polymorphism
foreach (BaseCustomer customers in baseCustomers)
{
	Console.WriteLine(customers.CustomerNumber);
}