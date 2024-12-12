using System;
using System.Collections.Generic;

namespace LB3;

public partial class Post
{
    public int Id { get; set; }

    public int IdUser { get; set; }

    public string Title { get; set; } = null!;

    public string Context { get; set; } = null!;

    public DateTime DareOfPublication { get; set; }

    public virtual User IdUserNavigation { get; set; } = null!;
}
