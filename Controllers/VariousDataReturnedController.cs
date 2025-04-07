using Microsoft.AspNetCore.Mvc;
[Route("api/[controller]")]
public class VariousDataReturnedController : ControllerBase
{
    [HttpGet("html")]
    public ContentResult GetHtml()
    {
        var html = "<html><div><h1>Header</h1></div></html>";
        return Content(html, "text/html");
    }
    [HttpGet("json")]
    public JsonResult GetJson()
    {
        var json = new {userName = "Name", Age = 20, userEmail = "123@example.com"};
        return new JsonResult(json);
    }
    [HttpGet("file")]
    public IActionResult GetFile()
    {
        var path = Path.Combine(Directory.GetCurrentDirectory(), "testFiles/test.txt");
        var bytes = System.IO.File.ReadAllBytes(path);
        return File(bytes, "text/plain");
    }
}