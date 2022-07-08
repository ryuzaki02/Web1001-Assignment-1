using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace Assignment_1.Pages
{
	public class IntroModel: PageModel
	{
        [FromQuery]
		public double leftNumber { get; set; }
		[FromQuery]
		public double rightNumber { get; set; }

		public void OnGet()
        {
			ViewData["Result"] = leftNumber + rightNumber;
        }
	}
}

