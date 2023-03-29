using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public  class Comment
    {
        [Key]// Primary key 
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime SendDate { get; set; }

        public bool Status { get; set; }

        public Blog Blogs { get; set; }
       
        public int  BlogId { get; set; }//One-to-Many (Relation key)

    }
}
