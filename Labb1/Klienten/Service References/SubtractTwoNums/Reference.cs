﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Klienten.SubtractTwoNums {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SubtractTwoNums.Subtract_2_NumsSoap")]
    public interface Subtract_2_NumsSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Subtractor", ReplyAction="*")]
        int Subtractor(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Subtractor", ReplyAction="*")]
        System.Threading.Tasks.Task<int> SubtractorAsync(int num1, int num2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Subtract_2_NumsSoapChannel : Klienten.SubtractTwoNums.Subtract_2_NumsSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Subtract_2_NumsSoapClient : System.ServiceModel.ClientBase<Klienten.SubtractTwoNums.Subtract_2_NumsSoap>, Klienten.SubtractTwoNums.Subtract_2_NumsSoap {
        
        public Subtract_2_NumsSoapClient() {
        }
        
        public Subtract_2_NumsSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Subtract_2_NumsSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Subtract_2_NumsSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Subtract_2_NumsSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Subtractor(int num1, int num2) {
            return base.Channel.Subtractor(num1, num2);
        }
        
        public System.Threading.Tasks.Task<int> SubtractorAsync(int num1, int num2) {
            return base.Channel.SubtractorAsync(num1, num2);
        }
    }
}
