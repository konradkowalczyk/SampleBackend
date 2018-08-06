﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SampleBackend.BusinessLayer.FlightRouteService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FlightRouteRequest", Namespace="http://schemas.datacontract.org/2004/07/FlightRouteService")]
    [System.SerializableAttribute()]
    public partial class FlightRouteRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DestinationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OriginField;
        
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
        public string Destination {
            get {
                return this.DestinationField;
            }
            set {
                if ((object.ReferenceEquals(this.DestinationField, value) != true)) {
                    this.DestinationField = value;
                    this.RaisePropertyChanged("Destination");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Origin {
            get {
                return this.OriginField;
            }
            set {
                if ((object.ReferenceEquals(this.OriginField, value) != true)) {
                    this.OriginField = value;
                    this.RaisePropertyChanged("Origin");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="FlightRouteResponse", Namespace="http://schemas.datacontract.org/2004/07/FlightRouteService")]
    [System.SerializableAttribute()]
    public partial class FlightRouteResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DestinationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal DistanceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal EstimatedLengthInHrsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OriginField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StopOverAtField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SuccessField;
        
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
        public string Destination {
            get {
                return this.DestinationField;
            }
            set {
                if ((object.ReferenceEquals(this.DestinationField, value) != true)) {
                    this.DestinationField = value;
                    this.RaisePropertyChanged("Destination");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Distance {
            get {
                return this.DistanceField;
            }
            set {
                if ((this.DistanceField.Equals(value) != true)) {
                    this.DistanceField = value;
                    this.RaisePropertyChanged("Distance");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal EstimatedLengthInHrs {
            get {
                return this.EstimatedLengthInHrsField;
            }
            set {
                if ((this.EstimatedLengthInHrsField.Equals(value) != true)) {
                    this.EstimatedLengthInHrsField = value;
                    this.RaisePropertyChanged("EstimatedLengthInHrs");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Id {
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
        public string Origin {
            get {
                return this.OriginField;
            }
            set {
                if ((object.ReferenceEquals(this.OriginField, value) != true)) {
                    this.OriginField = value;
                    this.RaisePropertyChanged("Origin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StopOverAt {
            get {
                return this.StopOverAtField;
            }
            set {
                if ((object.ReferenceEquals(this.StopOverAtField, value) != true)) {
                    this.StopOverAtField = value;
                    this.RaisePropertyChanged("StopOverAt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Success {
            get {
                return this.SuccessField;
            }
            set {
                if ((this.SuccessField.Equals(value) != true)) {
                    this.SuccessField = value;
                    this.RaisePropertyChanged("Success");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FlightRouteService.IFlightRouteRetrievalService")]
    public interface IFlightRouteRetrievalService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightRouteRetrievalService/GetFlightRoute", ReplyAction="http://tempuri.org/IFlightRouteRetrievalService/GetFlightRouteResponse")]
        SampleBackend.BusinessLayer.FlightRouteService.FlightRouteResponse GetFlightRoute(SampleBackend.BusinessLayer.FlightRouteService.FlightRouteRequest flightRouteRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightRouteRetrievalService/GetFlightRoute", ReplyAction="http://tempuri.org/IFlightRouteRetrievalService/GetFlightRouteResponse")]
        System.Threading.Tasks.Task<SampleBackend.BusinessLayer.FlightRouteService.FlightRouteResponse> GetFlightRouteAsync(SampleBackend.BusinessLayer.FlightRouteService.FlightRouteRequest flightRouteRequest);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFlightRouteRetrievalServiceChannel : SampleBackend.BusinessLayer.FlightRouteService.IFlightRouteRetrievalService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FlightRouteRetrievalServiceClient : System.ServiceModel.ClientBase<SampleBackend.BusinessLayer.FlightRouteService.IFlightRouteRetrievalService>, SampleBackend.BusinessLayer.FlightRouteService.IFlightRouteRetrievalService {
        
        public FlightRouteRetrievalServiceClient() {
        }
        
        public FlightRouteRetrievalServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FlightRouteRetrievalServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FlightRouteRetrievalServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FlightRouteRetrievalServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SampleBackend.BusinessLayer.FlightRouteService.FlightRouteResponse GetFlightRoute(SampleBackend.BusinessLayer.FlightRouteService.FlightRouteRequest flightRouteRequest) {
            return base.Channel.GetFlightRoute(flightRouteRequest);
        }
        
        public System.Threading.Tasks.Task<SampleBackend.BusinessLayer.FlightRouteService.FlightRouteResponse> GetFlightRouteAsync(SampleBackend.BusinessLayer.FlightRouteService.FlightRouteRequest flightRouteRequest) {
            return base.Channel.GetFlightRouteAsync(flightRouteRequest);
        }
    }
}
