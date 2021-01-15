using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreProject.Models.ViewModels
{
    public class PagingInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; } //trang hiện tại
        public int TotalPages =>
            (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
    }
}

// To support the tag hepler,
// Pass information to the view about the number of page avaible
// The current page and the total numbers of products
// => create ViewModel class to pass data between a controller and a view