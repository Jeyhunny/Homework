using DomainLayer.Models;
using Operator__overloading__Collections.Controllers;

#region Author
//2) Author tipinden listiniz olacaq.
//Yashi 40-dan yuxari olan authorlarin ad ve soyadini gosteren method yazmaq.


//AuthorController controller = new AuthorController();

//controller.ShowFullNameOfAuthorByFiltered();
#endregion


#region Employee
//4) Employee tipinden ibaret listiniz olacaq.
//Employee classinin icinde Name, Surname, Birthday, Salary propertileri olacaq.
//Employelerin icinden metoda iki verqli tarix ve salary gelir.
//Dogum gunu hemin tarixler arasinda olan ve maashi 2000 - den boyuk olan ishcilerin sayini gosteren method yazin.


EmployeeController controller = new EmployeeController();

controller.GetEmployeeCountByFiltered();
#endregion

