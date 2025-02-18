using ef_core_sql_app.Models;
using ef_core_sql_app.Services;
using System;

namespace ef_core_sql_app
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var serviceBlog = new ServiceBlog(new Blogging()))
            {
                //serviceBlog.CreateBlog(new Blog { Name = "Blog 1" });
                var blogs = serviceBlog.GetBlogs();
                foreach (var item in blogs)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
}
