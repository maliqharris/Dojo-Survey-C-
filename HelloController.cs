using Microsoft.AspNetCore.Mvc;
namespace Firstweb.Controllers;

public class HelloController : Controller
{
    [HttpGet("")] 
    public ViewResult Index()        
    {        
        ViewBag.Name = "Your name";  
    	return View("Index");        
    }
   
    [HttpPost("results")]
    public IActionResult Process(string TextField, int NumberField,  string NameField, string LocationField, string LanguageField)
    {    
    // Do something with form input  
        Console.WriteLine($"My text was: {TextField}");
        Console.WriteLine($"My number was: {NumberField}");
         ViewBag.TextField = TextField;
         ViewBag.NameField = NameField;
         ViewBag.LocationField = LocationField;
         ViewBag.LanguageField = LanguageField;
        ViewBag.NumberField = NumberField;
    // Then don't forget to return some kind of result!
        return View("Result");
    }  
    
}