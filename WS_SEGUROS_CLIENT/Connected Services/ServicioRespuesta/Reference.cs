﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WS_SEGUROS_CLIENT.ServicioRespuesta {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cliente", Namespace="http://schemas.datacontract.org/2004/07/WS_SEGUROS")]
    [System.SerializableAttribute()]
    public partial class Cliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CedulaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EdadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelefonoField;
        
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
        public string Cedula {
            get {
                return this.CedulaField;
            }
            set {
                if ((object.ReferenceEquals(this.CedulaField, value) != true)) {
                    this.CedulaField = value;
                    this.RaisePropertyChanged("Cedula");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Edad {
            get {
                return this.EdadField;
            }
            set {
                if ((this.EdadField.Equals(value) != true)) {
                    this.EdadField = value;
                    this.RaisePropertyChanged("Edad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Id {
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
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telefono {
            get {
                return this.TelefonoField;
            }
            set {
                if ((object.ReferenceEquals(this.TelefonoField, value) != true)) {
                    this.TelefonoField = value;
                    this.RaisePropertyChanged("Telefono");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioRespuesta.IServiceCliente")]
    public interface IServiceCliente {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/GetClientes", ReplyAction="http://tempuri.org/IServiceCliente/GetClientesResponse")]
        System.Data.DataSet GetClientes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/GetClientes", ReplyAction="http://tempuri.org/IServiceCliente/GetClientesResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetClientesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/GetClienteById", ReplyAction="http://tempuri.org/IServiceCliente/GetClienteByIdResponse")]
        System.Data.DataSet GetClienteById(WS_SEGUROS_CLIENT.ServicioRespuesta.Cliente cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/GetClienteById", ReplyAction="http://tempuri.org/IServiceCliente/GetClienteByIdResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetClienteByIdAsync(WS_SEGUROS_CLIENT.ServicioRespuesta.Cliente cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/InsertClientes", ReplyAction="http://tempuri.org/IServiceCliente/InsertClientesResponse")]
        string InsertClientes(WS_SEGUROS_CLIENT.ServicioRespuesta.Cliente cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/InsertClientes", ReplyAction="http://tempuri.org/IServiceCliente/InsertClientesResponse")]
        System.Threading.Tasks.Task<string> InsertClientesAsync(WS_SEGUROS_CLIENT.ServicioRespuesta.Cliente cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/UpdateClientes", ReplyAction="http://tempuri.org/IServiceCliente/UpdateClientesResponse")]
        string UpdateClientes(WS_SEGUROS_CLIENT.ServicioRespuesta.Cliente cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/UpdateClientes", ReplyAction="http://tempuri.org/IServiceCliente/UpdateClientesResponse")]
        System.Threading.Tasks.Task<string> UpdateClientesAsync(WS_SEGUROS_CLIENT.ServicioRespuesta.Cliente cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/DeleteClientes", ReplyAction="http://tempuri.org/IServiceCliente/DeleteClientesResponse")]
        bool DeleteClientes(WS_SEGUROS_CLIENT.ServicioRespuesta.Cliente cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/DeleteClientes", ReplyAction="http://tempuri.org/IServiceCliente/DeleteClientesResponse")]
        System.Threading.Tasks.Task<bool> DeleteClientesAsync(WS_SEGUROS_CLIENT.ServicioRespuesta.Cliente cliente);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceClienteChannel : WS_SEGUROS_CLIENT.ServicioRespuesta.IServiceCliente, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClienteClient : System.ServiceModel.ClientBase<WS_SEGUROS_CLIENT.ServicioRespuesta.IServiceCliente>, WS_SEGUROS_CLIENT.ServicioRespuesta.IServiceCliente {
        
        public ServiceClienteClient() {
        }
        
        public ServiceClienteClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClienteClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClienteClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClienteClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet GetClientes() {
            return base.Channel.GetClientes();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetClientesAsync() {
            return base.Channel.GetClientesAsync();
        }
        
        public System.Data.DataSet GetClienteById(WS_SEGUROS_CLIENT.ServicioRespuesta.Cliente cliente) {
            return base.Channel.GetClienteById(cliente);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetClienteByIdAsync(WS_SEGUROS_CLIENT.ServicioRespuesta.Cliente cliente) {
            return base.Channel.GetClienteByIdAsync(cliente);
        }
        
        public string InsertClientes(WS_SEGUROS_CLIENT.ServicioRespuesta.Cliente cliente) {
            return base.Channel.InsertClientes(cliente);
        }
        
        public System.Threading.Tasks.Task<string> InsertClientesAsync(WS_SEGUROS_CLIENT.ServicioRespuesta.Cliente cliente) {
            return base.Channel.InsertClientesAsync(cliente);
        }
        
        public string UpdateClientes(WS_SEGUROS_CLIENT.ServicioRespuesta.Cliente cliente) {
            return base.Channel.UpdateClientes(cliente);
        }
        
        public System.Threading.Tasks.Task<string> UpdateClientesAsync(WS_SEGUROS_CLIENT.ServicioRespuesta.Cliente cliente) {
            return base.Channel.UpdateClientesAsync(cliente);
        }
        
        public bool DeleteClientes(WS_SEGUROS_CLIENT.ServicioRespuesta.Cliente cliente) {
            return base.Channel.DeleteClientes(cliente);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteClientesAsync(WS_SEGUROS_CLIENT.ServicioRespuesta.Cliente cliente) {
            return base.Channel.DeleteClientesAsync(cliente);
        }
    }
}
