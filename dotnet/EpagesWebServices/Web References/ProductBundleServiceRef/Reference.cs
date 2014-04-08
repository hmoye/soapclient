﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:2.0.50727.3615
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Der Quellcode wurde automatisch mit Microsoft.VSDesigner generiert. Version 2.0.50727.3615.
// 
#pragma warning disable 1591

namespace EpagesWebServices.ProductBundleServiceRef {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="bind_ProductBundle_SOAP", Namespace="urn://epages.de/WebService/ProductBundleService/2007/07")]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TGetInfo_Return))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TExists_Return))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TExists_Input))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TDelete_Return))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TBundledProductPath))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TDelete_Input))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TCreate_Return))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TBundledProduct))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TCreate_Input))]
    public partial class ProductBundleService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback createOperationCompleted;
        
        private System.Threading.SendOrPostCallback deleteOperationCompleted;
        
        private System.Threading.SendOrPostCallback existsOperationCompleted;
        
        private System.Threading.SendOrPostCallback getInfoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ProductBundleService() {
            this.Url = global::EpagesWebServices.Properties.Settings.Default.EpagesWebServices_ProductBundleServiceRef_ProductBundleService;
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
        public event createCompletedEventHandler createCompleted;
        
        /// <remarks/>
        public event deleteCompletedEventHandler deleteCompleted;
        
        /// <remarks/>
        public event existsCompletedEventHandler existsCompleted;
        
        /// <remarks/>
        public event getInfoCompletedEventHandler getInfoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn://epages.de/WebService/ProductBundleService/2007/07#create", RequestNamespace="urn://epages.de/WebService/ProductBundleService/2007/07", ResponseNamespace="urn://epages.de/WebService/ProductBundleService/2007/07")]
        [return: System.Xml.Serialization.SoapElementAttribute("ProductBundles")]
        public TCreate_Return[] create(TCreate_Input[] ProductBundles) {
            object[] results = this.Invoke("create", new object[] {
                        ProductBundles});
            return ((TCreate_Return[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult Begincreate(TCreate_Input[] ProductBundles, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("create", new object[] {
                        ProductBundles}, callback, asyncState);
        }
        
        /// <remarks/>
        public TCreate_Return[] Endcreate(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((TCreate_Return[])(results[0]));
        }
        
        /// <remarks/>
        public void createAsync(TCreate_Input[] ProductBundles) {
            this.createAsync(ProductBundles, null);
        }
        
        /// <remarks/>
        public void createAsync(TCreate_Input[] ProductBundles, object userState) {
            if ((this.createOperationCompleted == null)) {
                this.createOperationCompleted = new System.Threading.SendOrPostCallback(this.OncreateOperationCompleted);
            }
            this.InvokeAsync("create", new object[] {
                        ProductBundles}, this.createOperationCompleted, userState);
        }
        
        private void OncreateOperationCompleted(object arg) {
            if ((this.createCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.createCompleted(this, new createCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn://epages.de/WebService/ProductBundleService/2007/07#delete", RequestNamespace="urn://epages.de/WebService/ProductBundleService/2007/07", ResponseNamespace="urn://epages.de/WebService/ProductBundleService/2007/07")]
        [return: System.Xml.Serialization.SoapElementAttribute("ProductBundles")]
        public TDelete_Return[] delete(TDelete_Input[] ProductBundles) {
            object[] results = this.Invoke("delete", new object[] {
                        ProductBundles});
            return ((TDelete_Return[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult Begindelete(TDelete_Input[] ProductBundles, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("delete", new object[] {
                        ProductBundles}, callback, asyncState);
        }
        
        /// <remarks/>
        public TDelete_Return[] Enddelete(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((TDelete_Return[])(results[0]));
        }
        
        /// <remarks/>
        public void deleteAsync(TDelete_Input[] ProductBundles) {
            this.deleteAsync(ProductBundles, null);
        }
        
        /// <remarks/>
        public void deleteAsync(TDelete_Input[] ProductBundles, object userState) {
            if ((this.deleteOperationCompleted == null)) {
                this.deleteOperationCompleted = new System.Threading.SendOrPostCallback(this.OndeleteOperationCompleted);
            }
            this.InvokeAsync("delete", new object[] {
                        ProductBundles}, this.deleteOperationCompleted, userState);
        }
        
        private void OndeleteOperationCompleted(object arg) {
            if ((this.deleteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.deleteCompleted(this, new deleteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn://epages.de/WebService/ProductBundleService/2007/07#exists", RequestNamespace="urn://epages.de/WebService/ProductBundleService/2007/07", ResponseNamespace="urn://epages.de/WebService/ProductBundleService/2007/07")]
        [return: System.Xml.Serialization.SoapElementAttribute("ProductBundles")]
        public TExists_Return[] exists(TExists_Input[] ProductBundles) {
            object[] results = this.Invoke("exists", new object[] {
                        ProductBundles});
            return ((TExists_Return[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult Beginexists(TExists_Input[] ProductBundles, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("exists", new object[] {
                        ProductBundles}, callback, asyncState);
        }
        
        /// <remarks/>
        public TExists_Return[] Endexists(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((TExists_Return[])(results[0]));
        }
        
        /// <remarks/>
        public void existsAsync(TExists_Input[] ProductBundles) {
            this.existsAsync(ProductBundles, null);
        }
        
        /// <remarks/>
        public void existsAsync(TExists_Input[] ProductBundles, object userState) {
            if ((this.existsOperationCompleted == null)) {
                this.existsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnexistsOperationCompleted);
            }
            this.InvokeAsync("exists", new object[] {
                        ProductBundles}, this.existsOperationCompleted, userState);
        }
        
        private void OnexistsOperationCompleted(object arg) {
            if ((this.existsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.existsCompleted(this, new existsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn://epages.de/WebService/ProductBundleService/2007/07#getInfo", RequestNamespace="urn://epages.de/WebService/ProductBundleService/2007/07", ResponseNamespace="urn://epages.de/WebService/ProductBundleService/2007/07")]
        [return: System.Xml.Serialization.SoapElementAttribute("ProductBundles")]
        public TGetInfo_Return[] getInfo(string[] Products) {
            object[] results = this.Invoke("getInfo", new object[] {
                        Products});
            return ((TGetInfo_Return[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetInfo(string[] Products, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getInfo", new object[] {
                        Products}, callback, asyncState);
        }
        
        /// <remarks/>
        public TGetInfo_Return[] EndgetInfo(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((TGetInfo_Return[])(results[0]));
        }
        
        /// <remarks/>
        public void getInfoAsync(string[] Products) {
            this.getInfoAsync(Products, null);
        }
        
        /// <remarks/>
        public void getInfoAsync(string[] Products, object userState) {
            if ((this.getInfoOperationCompleted == null)) {
                this.getInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetInfoOperationCompleted);
            }
            this.InvokeAsync("getInfo", new object[] {
                        Products}, this.getInfoOperationCompleted, userState);
        }
        
        private void OngetInfoOperationCompleted(object arg) {
            if ((this.getInfoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getInfoCompleted(this, new getInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/ProductBundleTypes/2007/07")]
    public partial class TCreate_Input {
        
        private string productField;
        
        private TBundledProduct[] bundledProductsField;
        
        /// <remarks/>
        public string Product {
            get {
                return this.productField;
            }
            set {
                this.productField = value;
            }
        }
        
        /// <remarks/>
        public TBundledProduct[] BundledProducts {
            get {
                return this.bundledProductsField;
            }
            set {
                this.bundledProductsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/ProductBundleTypes/2007/07")]
    public partial class TBundledProduct {
        
        private string pathField;
        
        private string positionField;
        
        private float quantityField;
        
        private string aliasField;
        
        /// <remarks/>
        public string Path {
            get {
                return this.pathField;
            }
            set {
                this.pathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType="integer")]
        public string Position {
            get {
                return this.positionField;
            }
            set {
                this.positionField = value;
            }
        }
        
        /// <remarks/>
        public float Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
        
        /// <remarks/>
        public string Alias {
            get {
                return this.aliasField;
            }
            set {
                this.aliasField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/ProductBundleTypes/2007/07")]
    public partial class TGetInfo_Return {
        
        private string productField;
        
        private TBundledProduct[] bundledProductsField;
        
        private TError errorField;
        
        /// <remarks/>
        public string Product {
            get {
                return this.productField;
            }
            set {
                this.productField = value;
            }
        }
        
        /// <remarks/>
        public TBundledProduct[] BundledProducts {
            get {
                return this.bundledProductsField;
            }
            set {
                this.bundledProductsField = value;
            }
        }
        
        /// <remarks/>
        public TError Error {
            get {
                return this.errorField;
            }
            set {
                this.errorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/EpagesTypes/2005/01")]
    public partial class TError {
        
        private string messageField;
        
        /// <remarks/>
        public string Message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/ProductBundleTypes/2007/07")]
    public partial class TExists_Return {
        
        private string productField;
        
        private string bundledProductField;
        
        private bool existsField;
        
        private bool existsFieldSpecified;
        
        private TError errorField;
        
        /// <remarks/>
        public string Product {
            get {
                return this.productField;
            }
            set {
                this.productField = value;
            }
        }
        
        /// <remarks/>
        public string BundledProduct {
            get {
                return this.bundledProductField;
            }
            set {
                this.bundledProductField = value;
            }
        }
        
        /// <remarks/>
        public bool exists {
            get {
                return this.existsField;
            }
            set {
                this.existsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool existsSpecified {
            get {
                return this.existsFieldSpecified;
            }
            set {
                this.existsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public TError Error {
            get {
                return this.errorField;
            }
            set {
                this.errorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/ProductBundleTypes/2007/07")]
    public partial class TExists_Input {
        
        private string productField;
        
        private string bundledProductField;
        
        /// <remarks/>
        public string Product {
            get {
                return this.productField;
            }
            set {
                this.productField = value;
            }
        }
        
        /// <remarks/>
        public string BundledProduct {
            get {
                return this.bundledProductField;
            }
            set {
                this.bundledProductField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/ProductBundleTypes/2007/07")]
    public partial class TDelete_Return {
        
        private string productField;
        
        private bool deletedField;
        
        private bool deletedFieldSpecified;
        
        private TError errorField;
        
        /// <remarks/>
        public string Product {
            get {
                return this.productField;
            }
            set {
                this.productField = value;
            }
        }
        
        /// <remarks/>
        public bool deleted {
            get {
                return this.deletedField;
            }
            set {
                this.deletedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool deletedSpecified {
            get {
                return this.deletedFieldSpecified;
            }
            set {
                this.deletedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public TError Error {
            get {
                return this.errorField;
            }
            set {
                this.errorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/ProductBundleTypes/2007/07")]
    public partial class TBundledProductPath {
        
        private string pathField;
        
        /// <remarks/>
        public string Path {
            get {
                return this.pathField;
            }
            set {
                this.pathField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/ProductBundleTypes/2007/07")]
    public partial class TDelete_Input {
        
        private string productField;
        
        private TBundledProductPath[] bundledProductPathsField;
        
        /// <remarks/>
        public string Product {
            get {
                return this.productField;
            }
            set {
                this.productField = value;
            }
        }
        
        /// <remarks/>
        public TBundledProductPath[] BundledProductPaths {
            get {
                return this.bundledProductPathsField;
            }
            set {
                this.bundledProductPathsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/ProductBundleTypes/2007/07")]
    public partial class TCreate_Return {
        
        private string productField;
        
        private bool createdField;
        
        private bool createdFieldSpecified;
        
        private TError errorField;
        
        /// <remarks/>
        public string Product {
            get {
                return this.productField;
            }
            set {
                this.productField = value;
            }
        }
        
        /// <remarks/>
        public bool created {
            get {
                return this.createdField;
            }
            set {
                this.createdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool createdSpecified {
            get {
                return this.createdFieldSpecified;
            }
            set {
                this.createdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public TError Error {
            get {
                return this.errorField;
            }
            set {
                this.errorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void createCompletedEventHandler(object sender, createCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class createCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal createCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TCreate_Return[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TCreate_Return[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void deleteCompletedEventHandler(object sender, deleteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class deleteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal deleteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TDelete_Return[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TDelete_Return[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void existsCompletedEventHandler(object sender, existsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class existsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal existsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TExists_Return[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TExists_Return[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void getInfoCompletedEventHandler(object sender, getInfoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TGetInfo_Return[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TGetInfo_Return[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591