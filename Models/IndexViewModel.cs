using occupy.Models.Entities;

namespace occupy.Models;

public class IndexViewModel
{
    public IEnumerable<Site>? Sites { get; set; }
    public Site? Site { get; set; }
}
