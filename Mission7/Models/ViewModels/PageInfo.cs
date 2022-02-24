using System;
namespace Mission7.Models.ViewModels
{
    // Create the information so that we can do the pagination 
    public class PageInfo
    {
        public int TotalNumProjects { get; set; }

        public int ProjectsPerPage { get; set; }

        public int CurrentPage { get; set; }

        public int TotalPages => (int) Math.Ceiling((double)TotalNumProjects / ProjectsPerPage);
    }
}
