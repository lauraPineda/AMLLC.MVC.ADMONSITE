﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AMMLC.MVC.COMMON.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IReferenceService")]
    public interface IReferenceService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReferenceService/OK", ReplyAction="http://tempuri.org/IReferenceService/OKResponse")]
        void OK();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReferenceService/OK", ReplyAction="http://tempuri.org/IReferenceService/OKResponse")]
        System.Threading.Tasks.Task OKAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IReferenceServiceChannel : AMMLC.MVC.COMMON.ServiceReference.IReferenceService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ReferenceServiceClient : System.ServiceModel.ClientBase<AMMLC.MVC.COMMON.ServiceReference.IReferenceService>, AMMLC.MVC.COMMON.ServiceReference.IReferenceService {
        
        public ReferenceServiceClient() {
        }
        
        public ReferenceServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ReferenceServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReferenceServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReferenceServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void OK() {
            base.Channel.OK();
        }
        
        public System.Threading.Tasks.Task OKAsync() {
            return base.Channel.OKAsync();
        }
    }
}
