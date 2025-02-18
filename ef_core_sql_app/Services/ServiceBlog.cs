using ef_core_sql_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ef_core_sql_app.Services
{
    public interface IServiceBlog
    {
        void CreateBlog(Blog blog);
        IEnumerable<Blog> GetBlogs();
        Blog GetBlogById(int id);
        void UpdateBlog(int id, Blog blog);
        void DeleteBlogById(int id);
        void AddPostToBlog(int blogId, Post post);
        void RemovePostFromBlog(int postId);
        IEnumerable<Post> GetPostsByBlogId(int blogId);
        void UpdatePostById(int postId);
    }
    public class ServiceBlog : IServiceBlog, IDisposable
    {
        private readonly Blogging context;
        public ServiceBlog(Blogging context)
        {
            this.context = context;
        }

        public void AddPostToBlog(int blogId, Post post)
        {
            
        }

        public void CreateBlog(Blog blog)
        {
            context.Database.ExecuteSqlCommand("INSERT INTO Blogs(Name) VALUES({0})", blog.Name);
        }

        public void DeleteBlogById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public Blog GetBlogById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Blog> GetBlogs()
        {
            return context.Blogs.SqlQuery("SELECT * FROM Blogs")
                .ToList();
        }

        public IEnumerable<Post> GetPostsByBlogId(int blogId)
        {
            throw new System.NotImplementedException();
        }

        public void RemovePostFromBlog(int postId)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateBlog(int id, Blog blog)
        {
            throw new System.NotImplementedException();
        }

        public void UpdatePostById(int postId)
        {
            throw new System.NotImplementedException();
        }
    }
}
