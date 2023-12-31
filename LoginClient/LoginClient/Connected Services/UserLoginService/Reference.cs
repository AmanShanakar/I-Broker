﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoginClient.UserLoginService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserLoginService.IUserLoginService")]
    public interface IUserLoginService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserLoginService/GetUser", ReplyAction="http://tempuri.org/IUserLoginService/GetUserResponse")]
        int GetUser(string Name, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserLoginService/GetUser", ReplyAction="http://tempuri.org/IUserLoginService/GetUserResponse")]
        System.Threading.Tasks.Task<int> GetUserAsync(string Name, string Password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserLoginServiceChannel : LoginClient.UserLoginService.IUserLoginService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserLoginServiceClient : System.ServiceModel.ClientBase<LoginClient.UserLoginService.IUserLoginService>, LoginClient.UserLoginService.IUserLoginService {
        
        public UserLoginServiceClient() {
        }
        
        public UserLoginServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserLoginServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserLoginServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserLoginServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int GetUser(string Name, string Password) {
            return base.Channel.GetUser(Name, Password);
        }
        
        public System.Threading.Tasks.Task<int> GetUserAsync(string Name, string Password) {
            return base.Channel.GetUserAsync(Name, Password);
        }
    }
}
