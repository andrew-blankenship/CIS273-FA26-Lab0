using System.Formats.Asn1;

namespace Prayer;

public class Prayer : AuditableRecord

    {
        public string Title { get; set; } = "";
        public string? Subtitle { get; set; }
        public string Body { get; set; } = "";
        public List<ScriptureReference> ScriptureReferences { get; set; } = new();
        public Author? Author { get; set; }
        public List<Tag>? Tags { get; set; }
        public Uri? ImageUrl { get; set; }


    public override string ToString()
    {
        string final = $"{Title}";
        if (Subtitle != null)
            final += $"\n{Subtitle}";
        if (Author != null)
            final += $"\nby {Author}";
        if (ScriptureReferences.Count != 0)
            final += $"\n{string.Join(", ", ScriptureReferences)}";
        if (Tags != null)
            final += $"\nTags: {string.Join(", ", Tags)}";
        return final;
    }



    }
