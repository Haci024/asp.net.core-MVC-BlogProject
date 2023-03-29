using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public  class Blog
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Content { get; set; }

        public string BlogImage { get; set; }

        public string BlogHeadImage { get; set; }

        public bool IsDeactive { get; set; }

        public DateTime BlogCreateDate { get; set; }

        public Category Category { get; set; }

        public  int CategoryId { get; set; }

        public List<Comment> Comments { get; set; }


    }
}
