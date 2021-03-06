﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimpleSOAPJsonConsumer.SimpleService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AuthenticationRequest", Namespace="http://schemas.datacontract.org/2004/07/WcfSoapRest")]
    [System.SerializableAttribute()]
    public partial class AuthenticationRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AuthorizationResponse", Namespace="http://schemas.datacontract.org/2004/07/WcfSoapRest")]
    [System.SerializableAttribute()]
    public partial class AuthorizationResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReturnUrlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ValidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> ValidToDateField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReturnUrl {
            get {
                return this.ReturnUrlField;
            }
            set {
                if ((object.ReferenceEquals(this.ReturnUrlField, value) != true)) {
                    this.ReturnUrlField = value;
                    this.RaisePropertyChanged("ReturnUrl");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Valid {
            get {
                return this.ValidField;
            }
            set {
                if ((this.ValidField.Equals(value) != true)) {
                    this.ValidField = value;
                    this.RaisePropertyChanged("Valid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ValidToDate {
            get {
                return this.ValidToDateField;
            }
            set {
                if ((this.ValidToDateField.Equals(value) != true)) {
                    this.ValidToDateField = value;
                    this.RaisePropertyChanged("ValidToDate");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SimpleService.ISimpleService")]
    public interface ISimpleService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISimpleService/Authenticate", ReplyAction="http://tempuri.org/ISimpleService/AuthenticateResponse")]
        SimpleSOAPJsonConsumer.SimpleService.AuthorizationResponse Authenticate(SimpleSOAPJsonConsumer.SimpleService.AuthenticationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISimpleService/Authenticate", ReplyAction="http://tempuri.org/ISimpleService/AuthenticateResponse")]
        System.Threading.Tasks.Task<SimpleSOAPJsonConsumer.SimpleService.AuthorizationResponse> AuthenticateAsync(SimpleSOAPJsonConsumer.SimpleService.AuthenticationRequest request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISimpleServiceChannel : SimpleSOAPJsonConsumer.SimpleService.ISimpleService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SimpleServiceClient : System.ServiceModel.ClientBase<SimpleSOAPJsonConsumer.SimpleService.ISimpleService>, SimpleSOAPJsonConsumer.SimpleService.ISimpleService {
        
        public SimpleServiceClient() {
        }
        
        public SimpleServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SimpleServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SimpleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SimpleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SimpleSOAPJsonConsumer.SimpleService.AuthorizationResponse Authenticate(SimpleSOAPJsonConsumer.SimpleService.AuthenticationRequest request) {
            return base.Channel.Authenticate(request);
        }
        
        public System.Threading.Tasks.Task<SimpleSOAPJsonConsumer.SimpleService.AuthorizationResponse> AuthenticateAsync(SimpleSOAPJsonConsumer.SimpleService.AuthenticationRequest request) {
            return base.Channel.AuthenticateAsync(request);
        }
    }
}
