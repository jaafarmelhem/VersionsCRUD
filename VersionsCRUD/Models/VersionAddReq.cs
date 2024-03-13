namespace VersionsCRUD.Models
{
    public class VersionAddReq
    {
        public int projectId { get; set; }
        public string? versionNumber { get; set; }
    }
}
