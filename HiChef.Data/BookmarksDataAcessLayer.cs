using System;
using System.Collections.Generic;
using System.Text;
using HiChef.Data.Interfaces;
using HiChef.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HiChef.Data
{
    public class BookmarksDataAcessLayer : DbContext, IBookmarksDataAccessLayer
    {
        private DbSet<BookmarkDataModel> Bookmarks { get; set; }

        public BookmarksDataAcessLayer(DbContextOptions<BookmarksDataAcessLayer> options) 
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
