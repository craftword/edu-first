using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace edu_first.Models
{
    public class NewsRepository : INewsRepository
    {
        private readonly ApplicationDbContext context;

        public NewsRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public News AddCourse(News newsDetails)
        {
            context.NewsDetails.Add(newsDetails);
            context.SaveChanges();
            return newsDetails;
        }

        public News DeleteCourse(int id)
        {
            News newDetail =  context.NewsDetails.Find(id);
            if(newDetail != null)
            {
                context.NewsDetails.Remove(newDetail);
                context.SaveChanges();
            }
            return newDetail;
        }

        public IEnumerable<News> fetchAllCourses()
        {
            return context.NewsDetails;
        }

        public News fetchCourse(int id)
        {
            return context.NewsDetails.Find(id);
        }

        public News UpdateCourse(News newsChanges)
        {
            var newsDetail = context.NewsDetails.Attach(newsChanges);
            newsDetail.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return newsChanges;
        }
    }
}
