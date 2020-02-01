using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace edu_first.Models
{
    public class GalleryRepository : IGalleryRepository
    {
        private readonly ApplicationDbContext context;

        public GalleryRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public Gallery AddGallery(Gallery gallery)
        {
            context.Galleries.Add(gallery);
            context.SaveChanges();
            return gallery;
        }

        public Gallery DeleteGallery(int id)
        {
            var gallery = context.Galleries.Find(id);
            if(gallery != null)
            {
                context.Galleries.Remove(gallery);
                context.SaveChanges();
            }
            return gallery;
        }

        public IEnumerable<Gallery> fetchAllGallery()
        {
            return context.Galleries;
        }

        public Gallery fetchGallery(int id)
        {
            return context.Galleries.Find(id);
        }

        public Gallery UpdateGallery(Gallery galleryChanges)
        {
            var gallery = context.Galleries.Attach(galleryChanges);
            gallery.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return galleryChanges;
        }
    }
}
