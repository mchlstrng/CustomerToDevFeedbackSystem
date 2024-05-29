using CustomerToDevFeedbackSystem.Enums;

namespace CustomerToDevFeedbackSystem.Services
{
    public interface IProjectService
    {
        ProjectService.ProjectItem GetProjectById(int id);
    }

    public class ProjectService : IProjectService
    {

        public ProjectItem GetProjectById(int id)
        {
            return new ProjectItem
            {
                Title = "Project 1",
                Description = "This is a project",
                Votes = 10,
                ProjectState = ProjectState.Open,
                Creator = "John Doe",
                Created = new DateTime(2021, 1, 1),
                Updated = new DateTime(2021, 1, 2),
                Comments = new List<Comment>
                {
                    new Comment
                    {
                        Text = "This is a comment",
                        Author = "Jane Doe",
                        Created = new DateTime(2021, 1, 2)
                    }
                }
            };
        }



        public class ProjectItem
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public int Votes { get; set; }
            public ProjectState ProjectState { get; set; }
            public string Creator { get; set; }
            public DateTime Created { get; set; }
            public DateTime Updated { get; set; }
            public List<Comment> Comments { get; set; }
        }
    }

    public class Comment
    {
        public string Text { get; set; }
        public string Author { get; set; }
        public DateTime Created { get; set; }
    }
}