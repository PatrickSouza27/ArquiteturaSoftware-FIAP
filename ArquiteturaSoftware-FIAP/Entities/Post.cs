namespace ArquiteturaSoftware_FIAP.Entities;

public class Post
{
    public Guid PostId { get; private set; }
    public Guid UserId { get; private set; }
    public string Content { get; private set; }
    public DateTime DateCreated { get; private set; }
    public List<Comment> Comments { get; private set; }

    public Post(Guid userId, string content, DateTime dateCreated, List<Comment> comments)
    {
        PostId = Guid.NewGuid();
        UserId = userId;
        Content = content;
        DateCreated = DateTime.Now;
        Comments = new List<Comment>();
    }
    
    public void AddComment(Comment comment)
        => Comments.Add(comment);
}

public class Comment
{
    public Guid CommentId { get; private set; }
    public Guid UserId { get; private set; }
    public string Text { get; private set; }
    public DateTime DateCreated { get; private set; }

    public Comment(Guid commentId, Guid userId, string text, DateTime dateCreated)
    {
        CommentId = commentId;
        UserId = userId;
        Text = text;
        DateCreated = dateCreated;
    }
}