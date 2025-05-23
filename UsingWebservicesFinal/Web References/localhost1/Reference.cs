﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace UsingWebservicesFinal.localhost1 {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="QuadraticSolverSoap", Namespace="http://tempuri.org/")]
    public partial class QuadraticSolver : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback SolveByFormulaOperationCompleted;
        
        private System.Threading.SendOrPostCallback SolveByCompletingSquareOperationCompleted;
        
        private System.Threading.SendOrPostCallback SolveByFactoringOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public QuadraticSolver() {
            this.Url = global::UsingWebservicesFinal.Properties.Settings.Default.UsingWebservicesFinal_localhost1_QuadraticSolver;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event SolveByFormulaCompletedEventHandler SolveByFormulaCompleted;
        
        /// <remarks/>
        public event SolveByCompletingSquareCompletedEventHandler SolveByCompletingSquareCompleted;
        
        /// <remarks/>
        public event SolveByFactoringCompletedEventHandler SolveByFactoringCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SolveByFormula", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SolveByFormula(double a, double b, double c) {
            object[] results = this.Invoke("SolveByFormula", new object[] {
                        a,
                        b,
                        c});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SolveByFormulaAsync(double a, double b, double c) {
            this.SolveByFormulaAsync(a, b, c, null);
        }
        
        /// <remarks/>
        public void SolveByFormulaAsync(double a, double b, double c, object userState) {
            if ((this.SolveByFormulaOperationCompleted == null)) {
                this.SolveByFormulaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSolveByFormulaOperationCompleted);
            }
            this.InvokeAsync("SolveByFormula", new object[] {
                        a,
                        b,
                        c}, this.SolveByFormulaOperationCompleted, userState);
        }
        
        private void OnSolveByFormulaOperationCompleted(object arg) {
            if ((this.SolveByFormulaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SolveByFormulaCompleted(this, new SolveByFormulaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SolveByCompletingSquare", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SolveByCompletingSquare(double a, double b, double c) {
            object[] results = this.Invoke("SolveByCompletingSquare", new object[] {
                        a,
                        b,
                        c});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SolveByCompletingSquareAsync(double a, double b, double c) {
            this.SolveByCompletingSquareAsync(a, b, c, null);
        }
        
        /// <remarks/>
        public void SolveByCompletingSquareAsync(double a, double b, double c, object userState) {
            if ((this.SolveByCompletingSquareOperationCompleted == null)) {
                this.SolveByCompletingSquareOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSolveByCompletingSquareOperationCompleted);
            }
            this.InvokeAsync("SolveByCompletingSquare", new object[] {
                        a,
                        b,
                        c}, this.SolveByCompletingSquareOperationCompleted, userState);
        }
        
        private void OnSolveByCompletingSquareOperationCompleted(object arg) {
            if ((this.SolveByCompletingSquareCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SolveByCompletingSquareCompleted(this, new SolveByCompletingSquareCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SolveByFactoring", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SolveByFactoring(double a, double b, double c) {
            object[] results = this.Invoke("SolveByFactoring", new object[] {
                        a,
                        b,
                        c});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SolveByFactoringAsync(double a, double b, double c) {
            this.SolveByFactoringAsync(a, b, c, null);
        }
        
        /// <remarks/>
        public void SolveByFactoringAsync(double a, double b, double c, object userState) {
            if ((this.SolveByFactoringOperationCompleted == null)) {
                this.SolveByFactoringOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSolveByFactoringOperationCompleted);
            }
            this.InvokeAsync("SolveByFactoring", new object[] {
                        a,
                        b,
                        c}, this.SolveByFactoringOperationCompleted, userState);
        }
        
        private void OnSolveByFactoringOperationCompleted(object arg) {
            if ((this.SolveByFactoringCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SolveByFactoringCompleted(this, new SolveByFactoringCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void SolveByFormulaCompletedEventHandler(object sender, SolveByFormulaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SolveByFormulaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SolveByFormulaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void SolveByCompletingSquareCompletedEventHandler(object sender, SolveByCompletingSquareCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SolveByCompletingSquareCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SolveByCompletingSquareCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void SolveByFactoringCompletedEventHandler(object sender, SolveByFactoringCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SolveByFactoringCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SolveByFactoringCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591