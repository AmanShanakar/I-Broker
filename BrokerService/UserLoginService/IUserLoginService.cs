using System.ServiceModel;

namespace UserLoginService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUserLoginService" in both code and config file together.
    [ServiceContract]
    public interface IUserLoginService
    {
        [OperationContract]
        int GetUser(string Name, string Password);  //, string Status
    }
}
