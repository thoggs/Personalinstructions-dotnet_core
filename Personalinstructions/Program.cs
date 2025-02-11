﻿using System;
using System.Collections.Generic;
using System.Linq;
using Personalinstructions.ContentContext;
using Personalinstructions.SubscriptionContext;

namespace Personalinstructions
{
    internal static class Program
    {
        private static void Main()
        {
            var articles = new List<Article>
            {
                new("Artigo Sobre OOP", "https://google.com"),
                new("Artigo Sobre C#", "https://google.com"),
                new("Artigo Sobre .NET Core", "https://google.com")
            };
            foreach (var a in articles)
            {
                Console.WriteLine(a.Id);
                Console.WriteLine(a.Title);
                Console.WriteLine(a.Url);
            }

            var courseOop = new Course("Fundamentos OOP", "https://google.com");
            var courseCsharp = new Course("Fundamentos C#", "https://google.com");
            var courseAspnet = new Course("Fundamentos ASPNET", "https://google.com");
            var courses = new List<Course> {courseOop, courseCsharp, courseAspnet};

            foreach (var course in courses)
            {
                Console.WriteLine(course.Title);
                Console.WriteLine(course.Url);
            }

            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .NET", "https://google.com");
            var careerItem1 = new CareerItem(1, "Comece por aqui", "", courseOop);
            var careerItem2 = new CareerItem(2, "Aprenda .NET", "", courseCsharp);
            var careerItem3 = new CareerItem(3, "Aprenda OOP", "", courseAspnet);
            
            careerDotnet.Items.Add(careerItem1);
            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem3);
            careers.Add(careerDotnet);
            
            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                Console.WriteLine(career.Url);

                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }

                var payPalSubscrition = new PayPalSubscription();
                var student = new Student();
                student.CreateSubscription(payPalSubscrition);
            }
        }
    }
}