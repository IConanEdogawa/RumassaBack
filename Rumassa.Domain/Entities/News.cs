using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumassa.Domain.Entities
{
    public class News
    {

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string CardPhotoPath { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public Guid? UserId { get; set; }

    }
}
