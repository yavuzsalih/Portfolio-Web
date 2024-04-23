using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace İlkProjem.ViewComponents.Dashboard
{
	public class ToDoListPanel : ViewComponent
	{
		ToDoListManager toDoListManager = new ToDoListManager(new EfToDoListDal());
		public IViewComponentResult Invoke()
		{
			var values = toDoListManager.GetList();
			return View(values);
		}
	
	}
}
