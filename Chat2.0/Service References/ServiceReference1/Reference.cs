﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Chat2._0.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserDTO", Namespace="http://schemas.datacontract.org/2004/07/EntitiesDTO")]
    [System.SerializableAttribute()]
    public partial class UserDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoginField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Login {
            get {
                return this.LoginField;
            }
            set {
                if ((object.ReferenceEquals(this.LoginField, value) != true)) {
                    this.LoginField = value;
                    this.RaisePropertyChanged("Login");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
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
    [System.Runtime.Serialization.DataContractAttribute(Name="MessageDTO", Namespace="http://schemas.datacontract.org/2004/07/EntitiesDTO")]
    [System.SerializableAttribute()]
    public partial class MessageDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Chat2._0.ServiceReference1.UserDTO UserFromField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Chat2._0.ServiceReference1.UserDTO UserToField;
        
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
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Text {
            get {
                return this.TextField;
            }
            set {
                if ((object.ReferenceEquals(this.TextField, value) != true)) {
                    this.TextField = value;
                    this.RaisePropertyChanged("Text");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Chat2._0.ServiceReference1.UserDTO UserFrom {
            get {
                return this.UserFromField;
            }
            set {
                if ((object.ReferenceEquals(this.UserFromField, value) != true)) {
                    this.UserFromField = value;
                    this.RaisePropertyChanged("UserFrom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Chat2._0.ServiceReference1.UserDTO UserTo {
            get {
                return this.UserToField;
            }
            set {
                if ((object.ReferenceEquals(this.UserToField, value) != true)) {
                    this.UserToField = value;
                    this.RaisePropertyChanged("UserTo");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        bool Login([System.ServiceModel.MessageParameterAttribute(Name="login")] string login1, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        System.Threading.Tasks.Task<bool> LoginAsync(string login, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCurrentUser", ReplyAction="http://tempuri.org/IService1/GetCurrentUserResponse")]
        Chat2._0.ServiceReference1.UserDTO GetCurrentUser();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCurrentUser", ReplyAction="http://tempuri.org/IService1/GetCurrentUserResponse")]
        System.Threading.Tasks.Task<Chat2._0.ServiceReference1.UserDTO> GetCurrentUserAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateUser", ReplyAction="http://tempuri.org/IService1/CreateUserResponse")]
        bool CreateUser(Chat2._0.ServiceReference1.UserDTO user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateUser", ReplyAction="http://tempuri.org/IService1/CreateUserResponse")]
        System.Threading.Tasks.Task<bool> CreateUserAsync(Chat2._0.ServiceReference1.UserDTO user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SendMessage", ReplyAction="http://tempuri.org/IService1/SendMessageResponse")]
        void SendMessage(Chat2._0.ServiceReference1.MessageDTO message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SendMessage", ReplyAction="http://tempuri.org/IService1/SendMessageResponse")]
        System.Threading.Tasks.Task SendMessageAsync(Chat2._0.ServiceReference1.MessageDTO message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllMessagesForUser", ReplyAction="http://tempuri.org/IService1/GetAllMessagesForUserResponse")]
        Chat2._0.ServiceReference1.MessageDTO[] GetAllMessagesForUser(Chat2._0.ServiceReference1.UserDTO user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllMessagesForUser", ReplyAction="http://tempuri.org/IService1/GetAllMessagesForUserResponse")]
        System.Threading.Tasks.Task<Chat2._0.ServiceReference1.MessageDTO[]> GetAllMessagesForUserAsync(Chat2._0.ServiceReference1.UserDTO user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllMessagesForUserFromDate", ReplyAction="http://tempuri.org/IService1/GetAllMessagesForUserFromDateResponse")]
        Chat2._0.ServiceReference1.MessageDTO[] GetAllMessagesForUserFromDate(Chat2._0.ServiceReference1.UserDTO user, System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllMessagesForUserFromDate", ReplyAction="http://tempuri.org/IService1/GetAllMessagesForUserFromDateResponse")]
        System.Threading.Tasks.Task<Chat2._0.ServiceReference1.MessageDTO[]> GetAllMessagesForUserFromDateAsync(Chat2._0.ServiceReference1.UserDTO user, System.DateTime date);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Chat2._0.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Chat2._0.ServiceReference1.IService1>, Chat2._0.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Login(string login1, string pass) {
            return base.Channel.Login(login1, pass);
        }
        
        public System.Threading.Tasks.Task<bool> LoginAsync(string login, string pass) {
            return base.Channel.LoginAsync(login, pass);
        }
        
        public Chat2._0.ServiceReference1.UserDTO GetCurrentUser() {
            return base.Channel.GetCurrentUser();
        }
        
        public System.Threading.Tasks.Task<Chat2._0.ServiceReference1.UserDTO> GetCurrentUserAsync() {
            return base.Channel.GetCurrentUserAsync();
        }
        
        public bool CreateUser(Chat2._0.ServiceReference1.UserDTO user) {
            return base.Channel.CreateUser(user);
        }
        
        public System.Threading.Tasks.Task<bool> CreateUserAsync(Chat2._0.ServiceReference1.UserDTO user) {
            return base.Channel.CreateUserAsync(user);
        }
        
        public void SendMessage(Chat2._0.ServiceReference1.MessageDTO message) {
            base.Channel.SendMessage(message);
        }
        
        public System.Threading.Tasks.Task SendMessageAsync(Chat2._0.ServiceReference1.MessageDTO message) {
            return base.Channel.SendMessageAsync(message);
        }
        
        public Chat2._0.ServiceReference1.MessageDTO[] GetAllMessagesForUser(Chat2._0.ServiceReference1.UserDTO user) {
            return base.Channel.GetAllMessagesForUser(user);
        }
        
        public System.Threading.Tasks.Task<Chat2._0.ServiceReference1.MessageDTO[]> GetAllMessagesForUserAsync(Chat2._0.ServiceReference1.UserDTO user) {
            return base.Channel.GetAllMessagesForUserAsync(user);
        }
        
        public Chat2._0.ServiceReference1.MessageDTO[] GetAllMessagesForUserFromDate(Chat2._0.ServiceReference1.UserDTO user, System.DateTime date) {
            return base.Channel.GetAllMessagesForUserFromDate(user, date);
        }
        
        public System.Threading.Tasks.Task<Chat2._0.ServiceReference1.MessageDTO[]> GetAllMessagesForUserFromDateAsync(Chat2._0.ServiceReference1.UserDTO user, System.DateTime date) {
            return base.Channel.GetAllMessagesForUserFromDateAsync(user, date);
        }
    }
}