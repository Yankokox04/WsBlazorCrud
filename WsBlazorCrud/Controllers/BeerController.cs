using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WsBlazorCrud.Models;
using WsBlazorCrud.Models.Request;
using WsBlazorCrud.Models.Response;

namespace WsBlazorCrud.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class BeerController : Controller {
        [HttpGet]
        public IActionResult Get() {
            var response = new DefaultResponse<List<Beer>>();

            try {
                using (BlazorCrudContext db = new BlazorCrudContext()) {
                    var list = db.Beers.ToList();
                    response.Success = 1;
                    response.Data = list;
                }

            } catch (Exception ex) {

                response.Message = ex.Message;
            }
                return Ok(response);
        }

        [HttpGet("{Id}")]
        public IActionResult Get(int Id) {
            var response = new DefaultResponse<Beer>();

            try {
                using (BlazorCrudContext db = new BlazorCrudContext()) {
                    var beer = db.Beers.Find(Id);
                    response.Success = 1;
                    response.Data = beer;
                }

            } catch (Exception ex) {

                response.Message = ex.Message;
            }
                return Ok(response);
        }
        [HttpPost]
        public IActionResult Create(BeerRequest model) {
            var response = new DefaultResponse<object>();

            try {
                using (BlazorCrudContext db = new BlazorCrudContext()) {
                    Beer beer = new Beer();
                    beer.Brand = model.Brand;
                    beer.Name = model.Name;
                    db.Beers.Add(beer);
                    db.SaveChanges();
                    response.Success = 1;
                }

            } catch (Exception ex) {

                response.Message = ex.Message;
            }
            return Ok(response);
        }

        [HttpPut]
        public IActionResult Edit(BeerRequest model) {
            var response = new DefaultResponse<Beer>();

            try {
                using (BlazorCrudContext db = new BlazorCrudContext()) {
                    Beer beer = db.Beers.Find(model.Id);
                    beer.Brand = model.Brand;
                    beer.Name = model.Name;
                    db.Entry(beer).State = EntityState.Modified;
                    db.SaveChanges();
                    response.Success = 1;
                    response.Data = beer;
                }

            } catch (Exception ex) {

                response.Message = ex.Message;
            }
            return Ok(response);
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id) {
            var response = new DefaultResponse<object>();

            try {
                using (BlazorCrudContext db = new BlazorCrudContext()) {
                    Beer beer = db.Beers.Find(Id);
                    db.Remove(beer);
                    db.SaveChanges();
                    response.Success = 1;
                }

            } catch (Exception ex) {

                response.Message = ex.Message;
            }
            return Ok(response);
        }
    }


}
