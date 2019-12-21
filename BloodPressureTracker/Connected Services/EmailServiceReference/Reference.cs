﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BloodPressureTracker.EmailServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmailServiceReference.IEmailService")]
    public interface IEmailService {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IEmailService/remind_userByEmail")]
        void remind_userByEmail(string email, System.DateTime Endtime);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IEmailService/remind_userByEmail")]
        System.Threading.Tasks.Task remind_userByEmailAsync(string email, System.DateTime Endtime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/get_time", ReplyAction="http://tempuri.org/IEmailService/get_timeResponse")]
        System.DateTime get_time();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/get_time", ReplyAction="http://tempuri.org/IEmailService/get_timeResponse")]
        System.Threading.Tasks.Task<System.DateTime> get_timeAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmailServiceChannel : BloodPressureTracker.EmailServiceReference.IEmailService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmailServiceClient : System.ServiceModel.ClientBase<BloodPressureTracker.EmailServiceReference.IEmailService>, BloodPressureTracker.EmailServiceReference.IEmailService {
        
        public EmailServiceClient() {
        }
        
        public EmailServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmailServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmailServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmailServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void remind_userByEmail(string email, System.DateTime Endtime) {
            base.Channel.remind_userByEmail(email, Endtime);
        }
        
        public System.Threading.Tasks.Task remind_userByEmailAsync(string email, System.DateTime Endtime) {
            return base.Channel.remind_userByEmailAsync(email, Endtime);
        }
        
        public System.DateTime get_time() {
            return base.Channel.get_time();
        }
        
        public System.Threading.Tasks.Task<System.DateTime> get_timeAsync() {
            return base.Channel.get_timeAsync();
        }
    }
}