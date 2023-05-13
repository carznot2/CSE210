public class PhoneNumber

{
    
    public int _areaCode;
    public int _numPrefix;
    public int _number;
    public string ToString()
    {
        return $"1-{_areaCode.ToString()}-{_numPrefix.ToString()}-{_number.ToString()}";
    }
    public void Parse(string phoneNumber)
    {
        int partPosition=0;
        string[] parts = phoneNumber.Split("-");
        if (parts[partPosition].CompareTo("1")==0)
        {
            partPosition++;
        };
        _areaCode=int.Parse(parts[partPosition]);
        partPosition++;
        _numPrefix=int.Parse(parts[partPosition]);
        partPosition++;
        _number=int.Parse(parts[partPosition]);
        if (!Valid())
        {
            throw new Exception("Invalid Phone Number Format!");
        }
    }
    public bool Valid()
    {
        if (_areaCode <100 || _areaCode >999)
        {
            return false;
        }
        else if (_numPrefix <100 || _numPrefix >999)
        {
            return false;
        }
        else if (_number >9999)
            {
            return false;
            }
        else 
        {
            return true;
        }

    }
}