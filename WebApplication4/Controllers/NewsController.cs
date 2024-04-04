using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class NewsController : Controller
    {
        //атрибуты маршрутизации
        [Route("news")]
        public IActionResult List()
        {
            var news = GetNews();

            return View(news);
        }

        //атрибуты и ограничене id:int
        [Route("news/{id:int}")]
        public IActionResult Details(int id)
        {
            var newsItem = GetNewsItem(id);

            return View(newsItem);
        }

        private List<News> GetNews()
        {
            return new List<News>
    {
        new News { Id = 1, Title = "Новость 1" },
        new News { Id = 2, Title = "Новость 2" },
        new News { Id = 3, Title = "Новость 3" },
        new News { Id = 3, Title = "Новость 4" },
        new News { Id = 3, Title = "Новость 5" }
    };
        }

        // Пример логики получения информации о новости по id (заглушка)
        private News GetNewsItem(int id)
        {
            return new News { Id = id, Title = "Новость " + id };
        }
    }

    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
