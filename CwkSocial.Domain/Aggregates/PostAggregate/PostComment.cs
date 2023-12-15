namespace CwkSocial.Domain.Aggregates.PostAggregate
{
    public class PostComment
    {
        private PostComment() { }
        public Guid CommentId { get; private set; }
        public Guid PostId { get; private set; }
        public string Text { get; private set; }
        public Guid UserProfileId { get; private set; }
        public DateTime DateCreated { get; private set; }
        public DateTime LastModified { get; private set; }

        public static PostComment CreatePostComment(Guid postId, string Text, Guid UserProfileId)
        {
            return new PostComment
            {
                PostId = postId,
                Text = Text,
                UserProfileId = UserProfileId,
                DateCreated = DateTime.UtcNow,
                LastModified = DateTime.UtcNow
            };
        }
        public void UdpateCommentText(string newText)
        {
            Text = newText;
            LastModified = DateTime.UtcNow;
        }
    }
}
