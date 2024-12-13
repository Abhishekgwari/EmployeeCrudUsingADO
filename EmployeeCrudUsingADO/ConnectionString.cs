 namespace EmployeeCrudUsingADO
{
    public static class ConnectionString
    {
        private static string cs = "Server=ABHISHEK_ASUS\\SQLEXPRESS; Database= CrudADOdb; Trusted_Connection=True;";
    
    public static string dbcs { get => cs; }
    
    }
}
