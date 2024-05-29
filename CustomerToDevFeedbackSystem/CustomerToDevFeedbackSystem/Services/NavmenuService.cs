using static CustomerToDevFeedbackSystem.Services.NavmenuService;

namespace CustomerToDevFeedbackSystem.Services
{
    public interface INavmenuService
    {
        List<NavMenuItem> GetAllProjects();
    }

    public class NavmenuService : INavmenuService
    {
        public List<NavMenuItem> GetAllProjects()
        {
            return
            [
                new NavMenuItem { Id = 1, Title = "Project 1" },
                new NavMenuItem { Id = 2, Title = "Project 2" },
                new NavMenuItem { Id = 3, Title = "Project 3" },
                new NavMenuItem { Id = 4, Title = "Project 4" },
            ];
        }

        public class NavMenuItem
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Url => $"/project/{Id}";
        }
    }
}
