using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Reflection;
using System.Text;
using System.Text.Json;
using UdemyJwtApp.Front.Models;

namespace UdemyJwtApp.Front.Controllers
{
    [Authorize(Roles = "Admin,Member")]
    public class ProductController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ProductController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> List()
        {
            var token = User.Claims.FirstOrDefault(x => x.Type == "accesToken")?.Value;
            if (token != null)
            {
                var client = _httpClientFactory.CreateClient();
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                var response = await client.GetAsync("http://localhost:5280/api/Products");
                if (response.IsSuccessStatusCode)
                {
                    var jsondata = await response.Content.ReadAsStringAsync();
                    var result = JsonSerializer.Deserialize<List<ProductListModel>>(jsondata, new JsonSerializerOptions
                    {
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                    });
                    return View(result);
                }
            }

            return View();
        }
        public async Task<IActionResult> Remove(int id)
        {
            var token = User.Claims.FirstOrDefault(x => x.Type == "accesToken")?.Value;
            if (token != null)
            {
                var client = _httpClientFactory.CreateClient();
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                await client.DeleteAsync($"http://localhost:5280/api/Products/{id}");
            }
            return RedirectToAction("List");
        }
        public async Task<IActionResult> Create()
        {
            var model = new ProductCreateModel();
            var token = User.Claims.FirstOrDefault(x => x.Type == "accesToken")?.Value;
            if (token != null)
            {
                var client = _httpClientFactory.CreateClient();
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                var response = await client.GetAsync("http://localhost:5280/api/Categories");
                if (response.IsSuccessStatusCode)
                {
                    var jsonData = await response.Content.ReadAsStreamAsync();
                    var data = JsonSerializer.Deserialize<List<CategoryListModel>>(jsonData, new JsonSerializerOptions
                    {
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                    });

                    model.Categories = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(data, "Id", "Definition");
                    return View(model);
                }
            }
            return View(new ProductCreateModel());
        }
        [HttpPost]
        public async Task<IActionResult> Create(ProductCreateModel model)
        {
            var data = TempData["Categories"]?.ToString();
            if (data != null)
            {
                var categories = JsonSerializer.Deserialize<List<SelectListItem>>(data);
                model.Categories = new SelectList(categories, "Value", "Text");
            }
            if (ModelState.IsValid)
            {
                var token = User.Claims.FirstOrDefault(x => x.Type == "accesToken")?.Value;
                if (token != null)
                {
                    var client = _httpClientFactory.CreateClient();
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                    var jsonData = JsonSerializer.Serialize(model);
                    var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("http://localhost:5280/api/Products", content);
                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction("List");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Bir hata oluştu");
                    }
<<<<<<< HEAD
                }

=======
              }
               
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
            }
            return View(model);
        }
        public async Task<IActionResult> Update(int id)
        {
            var model = new ProductCreateModel();
            var token = User.Claims.FirstOrDefault(x => x.Type == "accesToken")?.Value;
            if (token != null)
            {
                var client = _httpClientFactory.CreateClient();
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

<<<<<<< HEAD

=======
             
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
                var responseProduct = await client.GetAsync($"http://localhost:5280/api/Products/{id}");

                if (responseProduct.IsSuccessStatusCode)
                {

                    var jsondata = await responseProduct.Content.ReadAsStringAsync();
                    var result = JsonSerializer.Deserialize<UpdateProductModel>(jsondata, new JsonSerializerOptions
                    {
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                    });
                    var responseCategory = await client.GetAsync("http://localhost:5280/api/Categories");

                    if (responseCategory.IsSuccessStatusCode)
                    {
                        var jsoCategoryData = await responseCategory.Content.ReadAsStreamAsync();
<<<<<<< HEAD

=======
                       
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
                        var data = JsonSerializer.Deserialize<List<CategoryListModel>>(jsoCategoryData, new JsonSerializerOptions
                        {
                            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                        });
<<<<<<< HEAD
                        if (result != null)
                            result.Categories = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(data, "Id", "Definition");
=======
                        if(result!=null)
                        result.Categories = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(data, "Id", "Definition");
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24

                    }
                    return View(result);
                }
<<<<<<< HEAD

=======
 
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
            }
            return RedirectToAction("List");
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateProductModel model)
        {
            var data = TempData["Categories"]?.ToString();
            if (data != null)
            {
                var categories = JsonSerializer.Deserialize<List<SelectListItem>>(data);
<<<<<<< HEAD
                model.Categories = new SelectList(categories, "Value", "Text", model.CategoryId);
=======
                model.Categories = new SelectList(categories, "Value", "Text",model.CategoryId);
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
            }
            if (ModelState.IsValid)
            {
                var token = User.Claims.FirstOrDefault(x => x.Type == "accesToken")?.Value;
                if (token != null)
                {
                    var client = _httpClientFactory.CreateClient();
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                    var jsonData = JsonSerializer.Serialize(model);
                    var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                    var response = await client.PutAsync("http://localhost:5280/api/Products", content);
                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction("List");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Bir hata oluştu");
                    }
                }

            }
            return View(model);
        }

    }
<<<<<<< HEAD
}
=======
}
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
