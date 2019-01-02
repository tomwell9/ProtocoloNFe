﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProtocoloNFe.ServiceConsultaNFCe3_0 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta2", ConfigurationName="ServiceConsultaNFCe3_0.NfeConsulta2Soap")]
    public interface NfeConsulta2Soap {
        
        // CODEGEN: Generating message contract since the operation nfeConsultaNF2 is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta2/nfeConsultaNF2", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ProtocoloNFe.ServiceConsultaNFCe3_0.nfeConsultaNF2Response nfeConsultaNF2(ProtocoloNFe.ServiceConsultaNFCe3_0.nfeConsultaNF2Request request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta2/nfeConsultaNF2", ReplyAction="*")]
        System.Threading.Tasks.Task<ProtocoloNFe.ServiceConsultaNFCe3_0.nfeConsultaNF2Response> nfeConsultaNF2Async(ProtocoloNFe.ServiceConsultaNFCe3_0.nfeConsultaNF2Request request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta2")]
    public partial class nfeCabecMsg : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string cUFField;
        
        private string versaoDadosField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string cUF {
            get {
                return this.cUFField;
            }
            set {
                this.cUFField = value;
                this.RaisePropertyChanged("cUF");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string versaoDados {
            get {
                return this.versaoDadosField;
            }
            set {
                this.versaoDadosField = value;
                this.RaisePropertyChanged("versaoDados");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
                this.RaisePropertyChanged("AnyAttr");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class nfeConsultaNF2Request {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta2")]
        public ProtocoloNFe.ServiceConsultaNFCe3_0.nfeCabecMsg nfeCabecMsg;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta2", Order=0)]
        public System.Xml.XmlNode nfeDadosMsg;
        
        public nfeConsultaNF2Request() {
        }
        
        public nfeConsultaNF2Request(ProtocoloNFe.ServiceConsultaNFCe3_0.nfeCabecMsg nfeCabecMsg, System.Xml.XmlNode nfeDadosMsg) {
            this.nfeCabecMsg = nfeCabecMsg;
            this.nfeDadosMsg = nfeDadosMsg;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class nfeConsultaNF2Response {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta2")]
        public ProtocoloNFe.ServiceConsultaNFCe3_0.nfeCabecMsg nfeCabecMsg;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta2", Order=0)]
        public System.Xml.XmlNode nfeConsultaNF2Result;
        
        public nfeConsultaNF2Response() {
        }
        
        public nfeConsultaNF2Response(ProtocoloNFe.ServiceConsultaNFCe3_0.nfeCabecMsg nfeCabecMsg, System.Xml.XmlNode nfeConsultaNF2Result) {
            this.nfeCabecMsg = nfeCabecMsg;
            this.nfeConsultaNF2Result = nfeConsultaNF2Result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface NfeConsulta2SoapChannel : ProtocoloNFe.ServiceConsultaNFCe3_0.NfeConsulta2Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NfeConsulta2SoapClient : System.ServiceModel.ClientBase<ProtocoloNFe.ServiceConsultaNFCe3_0.NfeConsulta2Soap>, ProtocoloNFe.ServiceConsultaNFCe3_0.NfeConsulta2Soap {
        
        public NfeConsulta2SoapClient() {
        }
        
        public NfeConsulta2SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NfeConsulta2SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NfeConsulta2SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NfeConsulta2SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProtocoloNFe.ServiceConsultaNFCe3_0.nfeConsultaNF2Response ProtocoloNFe.ServiceConsultaNFCe3_0.NfeConsulta2Soap.nfeConsultaNF2(ProtocoloNFe.ServiceConsultaNFCe3_0.nfeConsultaNF2Request request) {
            return base.Channel.nfeConsultaNF2(request);
        }
        
        public System.Xml.XmlNode nfeConsultaNF2(ref ProtocoloNFe.ServiceConsultaNFCe3_0.nfeCabecMsg nfeCabecMsg, System.Xml.XmlNode nfeDadosMsg) {
            ProtocoloNFe.ServiceConsultaNFCe3_0.nfeConsultaNF2Request inValue = new ProtocoloNFe.ServiceConsultaNFCe3_0.nfeConsultaNF2Request();
            inValue.nfeCabecMsg = nfeCabecMsg;
            inValue.nfeDadosMsg = nfeDadosMsg;
            ProtocoloNFe.ServiceConsultaNFCe3_0.nfeConsultaNF2Response retVal = ((ProtocoloNFe.ServiceConsultaNFCe3_0.NfeConsulta2Soap)(this)).nfeConsultaNF2(inValue);
            nfeCabecMsg = retVal.nfeCabecMsg;
            return retVal.nfeConsultaNF2Result;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProtocoloNFe.ServiceConsultaNFCe3_0.nfeConsultaNF2Response> ProtocoloNFe.ServiceConsultaNFCe3_0.NfeConsulta2Soap.nfeConsultaNF2Async(ProtocoloNFe.ServiceConsultaNFCe3_0.nfeConsultaNF2Request request) {
            return base.Channel.nfeConsultaNF2Async(request);
        }
        
        public System.Threading.Tasks.Task<ProtocoloNFe.ServiceConsultaNFCe3_0.nfeConsultaNF2Response> nfeConsultaNF2Async(ProtocoloNFe.ServiceConsultaNFCe3_0.nfeCabecMsg nfeCabecMsg, System.Xml.XmlNode nfeDadosMsg) {
            ProtocoloNFe.ServiceConsultaNFCe3_0.nfeConsultaNF2Request inValue = new ProtocoloNFe.ServiceConsultaNFCe3_0.nfeConsultaNF2Request();
            inValue.nfeCabecMsg = nfeCabecMsg;
            inValue.nfeDadosMsg = nfeDadosMsg;
            return ((ProtocoloNFe.ServiceConsultaNFCe3_0.NfeConsulta2Soap)(this)).nfeConsultaNF2Async(inValue);
        }
    }
}