﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC4_AngularJs_RESTWCF.UserServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserDataContract", Namespace="http://schemas.datacontract.org/2004/07/WCF_REST_Service")]
    [System.SerializableAttribute()]
    public partial class UserDataContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CorreoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DNIField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FechaBajaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FechaNacField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombresField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsuarioRedField;
        
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
        public string Apellidos {
            get {
                return this.ApellidosField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidosField, value) != true)) {
                    this.ApellidosField = value;
                    this.RaisePropertyChanged("Apellidos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Correo {
            get {
                return this.CorreoField;
            }
            set {
                if ((object.ReferenceEquals(this.CorreoField, value) != true)) {
                    this.CorreoField = value;
                    this.RaisePropertyChanged("Correo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DNI {
            get {
                return this.DNIField;
            }
            set {
                if ((object.ReferenceEquals(this.DNIField, value) != true)) {
                    this.DNIField = value;
                    this.RaisePropertyChanged("DNI");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FechaBaja {
            get {
                return this.FechaBajaField;
            }
            set {
                if ((object.ReferenceEquals(this.FechaBajaField, value) != true)) {
                    this.FechaBajaField = value;
                    this.RaisePropertyChanged("FechaBaja");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FechaNac {
            get {
                return this.FechaNacField;
            }
            set {
                if ((object.ReferenceEquals(this.FechaNacField, value) != true)) {
                    this.FechaNacField = value;
                    this.RaisePropertyChanged("FechaNac");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombres {
            get {
                return this.NombresField;
            }
            set {
                if ((object.ReferenceEquals(this.NombresField, value) != true)) {
                    this.NombresField = value;
                    this.RaisePropertyChanged("Nombres");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserID {
            get {
                return this.UserIDField;
            }
            set {
                if ((object.ReferenceEquals(this.UserIDField, value) != true)) {
                    this.UserIDField = value;
                    this.RaisePropertyChanged("UserID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UsuarioRed {
            get {
                return this.UsuarioRedField;
            }
            set {
                if ((object.ReferenceEquals(this.UsuarioRedField, value) != true)) {
                    this.UsuarioRedField = value;
                    this.RaisePropertyChanged("UsuarioRed");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserServiceReference.IUserService")]
    public interface IUserService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetAllUsers", ReplyAction="http://tempuri.org/IUserService/GetAllUsersResponse")]
        MVC4_AngularJs_RESTWCF.UserServiceReference.UserDataContract[] GetAllUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetAllUsers", ReplyAction="http://tempuri.org/IUserService/GetAllUsersResponse")]
        System.Threading.Tasks.Task<MVC4_AngularJs_RESTWCF.UserServiceReference.UserDataContract[]> GetAllUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetUserDetails", ReplyAction="http://tempuri.org/IUserService/GetUserDetailsResponse")]
        MVC4_AngularJs_RESTWCF.UserServiceReference.UserDataContract GetUserDetails(string UserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetUserDetails", ReplyAction="http://tempuri.org/IUserService/GetUserDetailsResponse")]
        System.Threading.Tasks.Task<MVC4_AngularJs_RESTWCF.UserServiceReference.UserDataContract> GetUserDetailsAsync(string UserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/AddNewUser", ReplyAction="http://tempuri.org/IUserService/AddNewUserResponse")]
        bool AddNewUser(MVC4_AngularJs_RESTWCF.UserServiceReference.UserDataContract user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/AddNewUser", ReplyAction="http://tempuri.org/IUserService/AddNewUserResponse")]
        System.Threading.Tasks.Task<bool> AddNewUserAsync(MVC4_AngularJs_RESTWCF.UserServiceReference.UserDataContract user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/UpdateUser", ReplyAction="http://tempuri.org/IUserService/UpdateUserResponse")]
        void UpdateUser(MVC4_AngularJs_RESTWCF.UserServiceReference.UserDataContract contact);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/UpdateUser", ReplyAction="http://tempuri.org/IUserService/UpdateUserResponse")]
        System.Threading.Tasks.Task UpdateUserAsync(MVC4_AngularJs_RESTWCF.UserServiceReference.UserDataContract contact);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/DeleteUser", ReplyAction="http://tempuri.org/IUserService/DeleteUserResponse")]
        void DeleteUser(string UserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/DeleteUser", ReplyAction="http://tempuri.org/IUserService/DeleteUserResponse")]
        System.Threading.Tasks.Task DeleteUserAsync(string UserId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserServiceChannel : MVC4_AngularJs_RESTWCF.UserServiceReference.IUserService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServiceClient : System.ServiceModel.ClientBase<MVC4_AngularJs_RESTWCF.UserServiceReference.IUserService>, MVC4_AngularJs_RESTWCF.UserServiceReference.IUserService {
        
        public UserServiceClient() {
        }
        
        public UserServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MVC4_AngularJs_RESTWCF.UserServiceReference.UserDataContract[] GetAllUsers() {
            return base.Channel.GetAllUsers();
        }
        
        public System.Threading.Tasks.Task<MVC4_AngularJs_RESTWCF.UserServiceReference.UserDataContract[]> GetAllUsersAsync() {
            return base.Channel.GetAllUsersAsync();
        }
        
        public MVC4_AngularJs_RESTWCF.UserServiceReference.UserDataContract GetUserDetails(string UserId) {
            return base.Channel.GetUserDetails(UserId);
        }
        
        public System.Threading.Tasks.Task<MVC4_AngularJs_RESTWCF.UserServiceReference.UserDataContract> GetUserDetailsAsync(string UserId) {
            return base.Channel.GetUserDetailsAsync(UserId);
        }
        
        public bool AddNewUser(MVC4_AngularJs_RESTWCF.UserServiceReference.UserDataContract user) {
            return base.Channel.AddNewUser(user);
        }
        
        public System.Threading.Tasks.Task<bool> AddNewUserAsync(MVC4_AngularJs_RESTWCF.UserServiceReference.UserDataContract user) {
            return base.Channel.AddNewUserAsync(user);
        }
        
        public void UpdateUser(MVC4_AngularJs_RESTWCF.UserServiceReference.UserDataContract contact) {
            base.Channel.UpdateUser(contact);
        }
        
        public System.Threading.Tasks.Task UpdateUserAsync(MVC4_AngularJs_RESTWCF.UserServiceReference.UserDataContract contact) {
            return base.Channel.UpdateUserAsync(contact);
        }
        
        public void DeleteUser(string UserId) {
            base.Channel.DeleteUser(UserId);
        }
        
        public System.Threading.Tasks.Task DeleteUserAsync(string UserId) {
            return base.Channel.DeleteUserAsync(UserId);
        }
    }
}
