using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFCoreGetStarted
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        // By default the db will be assumed to be the runtime folder and since the migration 
        // has created it in the source code folder. On running 1st time there isn't a database 
        // so a new blank one is created and therefore no tables are visvibe and an exception is 
        // raised. Make sure you set the full path either a relateive 
        //string myDataSource = "C:\\Users\\steve\\Documents\\Visual Studio Work\\TRY\\EFCoreGetStarted"
        //    +"\\"+"blogging.db";
        // 
        // OR
        //
        // Copy yhr migrated db from the source folder to the deployment folder before running
        string myDataSource = "blogging.db";

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=blogging.db"); 
    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        public DateTime CreatedTimestamp { get; set; }

        public List<Post> Posts { get; } = new List<Post>();
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
