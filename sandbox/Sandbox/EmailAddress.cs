public class EmailAddress

{
    
    public string _account;
    public string _domain;
    
    public string ToString()
    {
        return $"{_account}@{_domain}";
    }
    public void Parse(string emailAddress)
    {
       
        string[] parts = emailAddress.Split("@");
       
        _account=parts[0];
        _domain=parts[1];
       
        if (!Valid())
        {
            throw new Exception("Invalid email address format!");
        }
    }
    public bool Valid()
    {
        if (_account.CompareTo("") ==0)
        {
            return false;
        }
        else if (!_domain.Contains("."))
        {
            return false;
        }
       
        else 
        {
            return true;
        }

    }
}