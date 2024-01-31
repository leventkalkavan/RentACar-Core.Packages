namespace Core.Persistence.Dynamic;

public class Sort
{
    public Sort()
    {
        Field = string.Empty;
        Dir = string.Empty;
    }

    public Sort(string field, string dir)
    {
        Field = field;
        Dir = dir;
    }

    public string Field { get; set; }
    public string Dir { get; set; }
}