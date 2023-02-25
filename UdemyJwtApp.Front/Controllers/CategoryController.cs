﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json;
using UdemyJwtApp.Front.Models;

namespace UdemyJwtApp.Front.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CategoryController(IHttpClientFactory httpClientFactory)
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
                var response = await client.GetAsync("http://localhost:5280/api/Categories");
                if (response.IsSuccessStatusCode)
                {
                    var jsondata = await response.Content.ReadAsStringAsync();
                    var result = JsonSerializer.Deserialize<List<CategoryListModel>>(jsondata, new JsonSerializerOptions
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
                var response = await client.DeleteAsync($"http://localhost:5280/api/Categories/{id}");
            }
            return RedirectToAction("List");
        }
        public IActionResult Create()
        {
            return View(new CategoryCreateModel());
        }
        [HttpPost]
        public async Task<IActionResult> Create(CategoryCreateModel model)
        {
            if (ModelState.IsValid)
<<<<<<< HEAD
            {
                var token = User.Claims.FirstOrDefault(x => x.Type == "accesToken")?.Value;
                if (token != null)
                {
                    var client = _httpClientFactory.CreateClient();
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                    var jsonData = JsonSerializer.Serialize(model);
                    var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("http://localhost:5280/api/Categories", content);
                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction("List");
                    }
=======
            { 
           var token = User.Claims.FirstOrDefault(x => x.Type == "accesToken")?.Value;
            if (token != null)
            {
                var client = _httpClientFactory.CreateClient();
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                    var jsonData = JsonSerializer.Serialize(model);
                    var content = new StringContent(jsonData,Encoding.UTF8,"application/json");
                var response = await client.PostAsync("http://localhost:5280/api/Categories",content);
                    if(response.IsSuccessStatusCode)
                    {
                        return RedirectToAction("List");
                     }
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
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
            return View();

        }
        public async Task<IActionResult> Update(int id)
        {
            var token = User.Claims.FirstOrDefault(x => x.Type == "accesToken")?.Value;
            if (token != null)
            {
                var client = _httpClientFactory.CreateClient();
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
<<<<<<< HEAD
                var response = await client.GetAsync($"http://localhost:5280/api/Categories/{id}");
                if (response.IsSuccessStatusCode)
=======
           var response=   await  client.GetAsync($"http://localhost:5280/api/Categories/{id}");
                if(response.IsSuccessStatusCode)
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
                {

                    var jsondata = await response.Content.ReadAsStringAsync();
                    var result = JsonSerializer.Deserialize<UpdateCategoryModel>(jsondata, new JsonSerializerOptions
                    {
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                    });
                    return View(result);
                }
<<<<<<< HEAD

=======
              
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
            }
            return RedirectToAction("List");
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateCategoryModel model)
        {
            if (ModelState.IsValid)
            {
                var token = User.Claims.FirstOrDefault(x => x.Type == "accesToken")?.Value;
                if (token != null)
                {
                    var client = _httpClientFactory.CreateClient();
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                    var jsonData = JsonSerializer.Serialize(model);
                    var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                    var response = await client.PutAsync("http://localhost:5280/api/Categories", content);
<<<<<<< HEAD
                    if (response.IsSuccessStatusCode)
=======
                    if(response.IsSuccessStatusCode)
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
                    {
                        return RedirectToAction("List");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Bir hata oluştu");
                    }
<<<<<<< HEAD

=======
                    
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
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
