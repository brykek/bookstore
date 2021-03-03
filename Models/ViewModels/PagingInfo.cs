using System;
namespace Bookstore2.Models.ViewModels
{
    public class PagingInfo
    {
        //class for calculating pages and items per page
        public int TotalNumItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages => (int)(Math.Ceiling((decimal)TotalNumItems / ItemsPerPage));
    }
}
