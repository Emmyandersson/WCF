﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NextThousand__Win.ThousandDays {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ThousandDays.CalculatorSoap")]
    public interface CalculatorSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NextThousandDays", ReplyAction="*")]
        System.DateTime NextThousandDays(System.DateTime birthDay);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NextThousandDays", ReplyAction="*")]
        System.Threading.Tasks.Task<System.DateTime> NextThousandDaysAsync(System.DateTime birthDay);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CalculatorSoapChannel : NextThousand__Win.ThousandDays.CalculatorSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorSoapClient : System.ServiceModel.ClientBase<NextThousand__Win.ThousandDays.CalculatorSoap>, NextThousand__Win.ThousandDays.CalculatorSoap {
        
        public CalculatorSoapClient() {
        }
        
        public CalculatorSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.DateTime NextThousandDays(System.DateTime birthDay) {
            return base.Channel.NextThousandDays(birthDay);
        }
        
        public System.Threading.Tasks.Task<System.DateTime> NextThousandDaysAsync(System.DateTime birthDay) {
            return base.Channel.NextThousandDaysAsync(birthDay);
        }
    }
}