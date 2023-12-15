using CwkSocial.Domain.Aggregates.UserProfileAggregare;

namespace CwkSocial.Domain.Aggregates.PostAggregate
{
    public class Post
    {
        private readonly List<PostComment> _comments = new List<PostComment>();
        private readonly List<PostInteraction> _interactions = new List<PostInteraction>();
        private Post()
        {
        }
        public Guid PostId { get; private set; }
        public Guid UserProfileId { get; private set; }
        public UserProfile UserProfile { get; private set; }
        public string TextContent { get; private set; }
        public DateTime CreateDate { get; private set; }
        public DateTime LastModified { get; private set; }
        public IEnumerable<PostComment> Comments { get { return _comments; } }
        public IEnumerable<PostInteraction> Interactions { get { return _interactions; } }
        public static Post CreatePost(Guid userProfileId, string textContent)
        {
            return new Post
            {
                UserProfileId = userProfileId,
                TextContent = textContent,
                CreateDate = DateTime.UtcNow,
                LastModified = DateTime.UtcNow,
            };
        }
        public void UpdatePostText(string newContentText)
        {
            TextContent = newContentText;
            LastModified = DateTime.UtcNow;
        }
        public void AddPostComment(PostComment newPostComment)
        {
            _comments.Add(newPostComment);
        }
        public void RemoveComment(PostComment toComment)
        {
            _comments.Remove(toComment);
        }
        public void AddInteraction(PostInteraction newInteraction)
        {
            _interactions.Add(newInteraction);
        }
        public void RemoveInteraction(PostInteraction toInteraction)
        {
            _interactions.Remove(toInteraction);
        }
    }
}
