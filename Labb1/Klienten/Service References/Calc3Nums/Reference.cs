﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Klienten.Calc3Nums {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Calc3Nums.CalcThreeNumsSoap")]
    public interface CalcThreeNumsSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalcThree", ReplyAction="*")]
        int CalcThree(int num1, int num2, int num3);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalcThree", ReplyAction="*")]
        System.Threading.Tasks.Task<int> CalcThreeAsync(int num1, int num2, int num3);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CalcThreeNumsSoapChannel : Klienten.Calc3Nums.CalcThreeNumsSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalcThreeNumsSoapClient : System.ServiceModel.ClientBase<Klienten.Calc3Nums.CalcThreeNumsSoap>, Klienten.Calc3Nums.CalcThreeNumsSoap {
        
        public CalcThreeNumsSoapClient() {
        }
        
        public CalcThreeNumsSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalcThreeNumsSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcThreeNumsSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcThreeNumsSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int CalcThree(int num1, int num2, int num3) {
            return base.Channel.CalcThree(num1, num2, num3);
        }
        
        public System.Threading.Tasks.Task<int> CalcThreeAsync(int num1, int num2, int num3) {
            return base.Channel.CalcThreeAsync(num1, num2, num3);
        }
    }
}
