﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version:2.0.41202.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// This source code was auto-generated by wsdl, Version=2.0.41202.0.
// 


/// <remarks/>
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name="TestServiceSoap", Namespace="http://tempuri.org/")]
public partial class TestService : System.Web.Services.Protocols.SoapHttpClientProtocol, ITestServiceSoap {
    
    private System.Threading.SendOrPostCallback EchoOperationCompleted;
    
    private System.Threading.SendOrPostCallback AddOperationCompleted;
    
    /// <remarks/>
    public TestService() {
        this.Url = "http://jupiter:8008/1.1/webservice/TestService.asmx";
    }
    
    /// <remarks/>
    public event EchoCompletedEventHandler EchoCompleted;
    
    /// <remarks/>
    public event AddCompletedEventHandler AddCompleted;
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Echo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public string Echo(string a) {
        object[] results = this.Invoke("Echo", new object[] {
                    a});
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginEcho(string a, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("Echo", new object[] {
                    a}, callback, asyncState);
    }
    
    /// <remarks/>
    public string EndEcho(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public void EchoAsync(string a) {
        this.EchoAsync(a, null);
    }
    
    /// <remarks/>
    public void EchoAsync(string a, object userState) {
        if ((this.EchoOperationCompleted == null)) {
            this.EchoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEchoOperationCompleted);
        }
        this.InvokeAsync("Echo", new object[] {
                    a}, this.EchoOperationCompleted, userState);
    }
    
    private void OnEchoOperationCompleted(object arg) {
        if ((this.EchoCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.EchoCompleted(this, new EchoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Add", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public int Add(int a, int b) {
        object[] results = this.Invoke("Add", new object[] {
                    a,
                    b});
        return ((int)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginAdd(int a, int b, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("Add", new object[] {
                    a,
                    b}, callback, asyncState);
    }
    
    /// <remarks/>
    public int EndAdd(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((int)(results[0]));
    }
    
    /// <remarks/>
    public void AddAsync(int a, int b) {
        this.AddAsync(a, b, null);
    }
    
    /// <remarks/>
    public void AddAsync(int a, int b, object userState) {
        if ((this.AddOperationCompleted == null)) {
            this.AddOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddOperationCompleted);
        }
        this.InvokeAsync("Add", new object[] {
                    a,
                    b}, this.AddOperationCompleted, userState);
    }
    
    private void OnAddOperationCompleted(object arg) {
        if ((this.AddCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.AddCompleted(this, new AddCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    public new void CancelAsync(object userState) {
        base.CancelAsync(userState);
    }
}

/// <remarks/>
public delegate void EchoCompletedEventHandler(object sender, EchoCompletedEventArgs args);

/// <remarks/>
public partial class EchoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal EchoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
public delegate void AddCompletedEventHandler(object sender, AddCompletedEventArgs args);

/// <remarks/>
public partial class AddCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal AddCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public int Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((int)(this.results[0]));
        }
    }
}
