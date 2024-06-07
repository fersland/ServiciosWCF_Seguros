﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WS_SEGUROS_CLIENT.DepartamentosService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Departamento", Namespace="http://schemas.datacontract.org/2004/07/WS_SEGUROS")]
    [System.SerializableAttribute()]
    public partial class Departamento : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DepartamentosService.IDepartamentoService")]
    public interface IDepartamentoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepartamentoService/GetAllDepartamentos", ReplyAction="http://tempuri.org/IDepartamentoService/GetAllDepartamentosResponse")]
        System.Data.DataSet GetAllDepartamentos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepartamentoService/GetAllDepartamentos", ReplyAction="http://tempuri.org/IDepartamentoService/GetAllDepartamentosResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetAllDepartamentosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepartamentoService/GetByIdDepartamentos", ReplyAction="http://tempuri.org/IDepartamentoService/GetByIdDepartamentosResponse")]
        System.Data.DataSet GetByIdDepartamentos(WS_SEGUROS_CLIENT.DepartamentosService.Departamento departamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepartamentoService/GetByIdDepartamentos", ReplyAction="http://tempuri.org/IDepartamentoService/GetByIdDepartamentosResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetByIdDepartamentosAsync(WS_SEGUROS_CLIENT.DepartamentosService.Departamento departamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepartamentoService/InsertDepartamento", ReplyAction="http://tempuri.org/IDepartamentoService/InsertDepartamentoResponse")]
        string InsertDepartamento(WS_SEGUROS_CLIENT.DepartamentosService.Departamento departamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepartamentoService/InsertDepartamento", ReplyAction="http://tempuri.org/IDepartamentoService/InsertDepartamentoResponse")]
        System.Threading.Tasks.Task<string> InsertDepartamentoAsync(WS_SEGUROS_CLIENT.DepartamentosService.Departamento departamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepartamentoService/UpdateDepartamento", ReplyAction="http://tempuri.org/IDepartamentoService/UpdateDepartamentoResponse")]
        string UpdateDepartamento(WS_SEGUROS_CLIENT.DepartamentosService.Departamento departamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepartamentoService/UpdateDepartamento", ReplyAction="http://tempuri.org/IDepartamentoService/UpdateDepartamentoResponse")]
        System.Threading.Tasks.Task<string> UpdateDepartamentoAsync(WS_SEGUROS_CLIENT.DepartamentosService.Departamento departamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepartamentoService/DeleteDepartamento", ReplyAction="http://tempuri.org/IDepartamentoService/DeleteDepartamentoResponse")]
        bool DeleteDepartamento(WS_SEGUROS_CLIENT.DepartamentosService.Departamento departamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepartamentoService/DeleteDepartamento", ReplyAction="http://tempuri.org/IDepartamentoService/DeleteDepartamentoResponse")]
        System.Threading.Tasks.Task<bool> DeleteDepartamentoAsync(WS_SEGUROS_CLIENT.DepartamentosService.Departamento departamento);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDepartamentoServiceChannel : WS_SEGUROS_CLIENT.DepartamentosService.IDepartamentoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DepartamentoServiceClient : System.ServiceModel.ClientBase<WS_SEGUROS_CLIENT.DepartamentosService.IDepartamentoService>, WS_SEGUROS_CLIENT.DepartamentosService.IDepartamentoService {
        
        public DepartamentoServiceClient() {
        }
        
        public DepartamentoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DepartamentoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DepartamentoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DepartamentoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet GetAllDepartamentos() {
            return base.Channel.GetAllDepartamentos();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetAllDepartamentosAsync() {
            return base.Channel.GetAllDepartamentosAsync();
        }
        
        public System.Data.DataSet GetByIdDepartamentos(WS_SEGUROS_CLIENT.DepartamentosService.Departamento departamento) {
            return base.Channel.GetByIdDepartamentos(departamento);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetByIdDepartamentosAsync(WS_SEGUROS_CLIENT.DepartamentosService.Departamento departamento) {
            return base.Channel.GetByIdDepartamentosAsync(departamento);
        }
        
        public string InsertDepartamento(WS_SEGUROS_CLIENT.DepartamentosService.Departamento departamento) {
            return base.Channel.InsertDepartamento(departamento);
        }
        
        public System.Threading.Tasks.Task<string> InsertDepartamentoAsync(WS_SEGUROS_CLIENT.DepartamentosService.Departamento departamento) {
            return base.Channel.InsertDepartamentoAsync(departamento);
        }
        
        public string UpdateDepartamento(WS_SEGUROS_CLIENT.DepartamentosService.Departamento departamento) {
            return base.Channel.UpdateDepartamento(departamento);
        }
        
        public System.Threading.Tasks.Task<string> UpdateDepartamentoAsync(WS_SEGUROS_CLIENT.DepartamentosService.Departamento departamento) {
            return base.Channel.UpdateDepartamentoAsync(departamento);
        }
        
        public bool DeleteDepartamento(WS_SEGUROS_CLIENT.DepartamentosService.Departamento departamento) {
            return base.Channel.DeleteDepartamento(departamento);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteDepartamentoAsync(WS_SEGUROS_CLIENT.DepartamentosService.Departamento departamento) {
            return base.Channel.DeleteDepartamentoAsync(departamento);
        }
    }
}
