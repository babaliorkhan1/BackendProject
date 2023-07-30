using ClassLibrary1.Core.Entities;

namespace WebApplication11.ViewModels
{
    public class HomeVm
    {
        public IEnumerable<Slider> sliders { get; set; }    
        public IEnumerable<Board> boards { get; set; }    
        public About about { get; set; }    
        public IEnumerable<Course> courses { get; set; }    
        public IEnumerable<Teacher> teachers { get; set; }  
    }
}
