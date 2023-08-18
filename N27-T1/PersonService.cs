namespace N27_T1;

public class PersonService
{
    private readonly EFCoreContext _context;
    
    
    public PersonService(EFCoreContext context)
    {
        _context = context;
    }
    
}