using System;

namespace Application.Comments
{
    public class CommentDto
    {
        public Guid Id { get; set; }
        public string Body { get; set; }
        public virtual DateTime CreatedAt { get; set; }
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string Image { get; set; }
    }
}