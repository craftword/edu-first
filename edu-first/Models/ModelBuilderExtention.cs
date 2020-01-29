using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace edu_first.Models
{
    public static class ModelBuilderExtention
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Registration>().HasData(
                new Registration
                {
                    RegistrationId = 1,
                    UserId = 1,
                    SessionId = 1,
                    CourseId = 1,
                    User = new User()
                    {
                        FirstName = "Francis",
                        LastName = "Cidos",
                        Gender = "Male",
                        Address = "Traditions building Lekki II, Lagos Nigeria",
                        NewsDetails = new List<News>()
                            {
                                new News{
                                    Id=1, NewsDetails="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                                    NewsTitle = "What is Lorem Ipsum?",
                                    ImagePath = "",
                                    AddedBy = 1,
                                    CreatedAt = new DateTime(2018,6,2),
                                    Tag = "Tech"
                                }
                            },
                        Galleries = new List<Gallery>()
                            {
                                new Gallery{ id=1, ImagePath = "", Description="Inter-Class Volley-Ball Competition", Category="Sports" }
                            }
                    },
                    Session = new Session()
                    {
                        Id = 1,
                        Name = "2020/2021"
                    },
                    Course = new Course()
                    {
                        Id = 1,
                        Title = "English"
                    }
                }
            );

            modelBuilder.Entity<Score>().HasData(
                new Score
                {
                      ScoreId = 1,
                      RegId = 1,
                      CA = 10,
                      Exam = 40,
                      Total = 60,
                      Grade = 'B'
                }
            );
        }
    }
}
