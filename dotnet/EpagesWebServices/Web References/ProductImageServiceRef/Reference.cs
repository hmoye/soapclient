﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:2.0.50727.3053
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Der Quellcode wurde automatisch mit Microsoft.VSDesigner generiert. Version 2.0.50727.3053.
// 
#pragma warning disable 1591

namespace EpagesWebServices.ProductImageServiceRef {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="bind_ProductImage_SOAP", Namespace="urn://epages.de/WebService/ProductImageService/2006/03")]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TUploadScale_Return))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TUpload_Return))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TImageData))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TDelete_Return))]
    public partial class ProductImageService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback existsOperationCompleted;
        
        private System.Threading.SendOrPostCallback deleteOperationCompleted;
        
        private System.Threading.SendOrPostCallback uploadOperationCompleted;
        
        private System.Threading.SendOrPostCallback uploadscaleOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ProductImageService() {
            this.Url = "http://localhost/epages/Store.soap";
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
        public event existsCompletedEventHandler existsCompleted;
        
        /// <remarks/>
        public event deleteCompletedEventHandler deleteCompleted;
        
        /// <remarks/>
        public event uploadCompletedEventHandler uploadCompleted;
        
        /// <remarks/>
        public event uploadscaleCompletedEventHandler uploadscaleCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn://epages.de/WebService/ProductImageService/2006/03#exists", RequestNamespace="urn://epages.de/WebService/ProductImageService/2006/03", ResponseNamespace="urn://epages.de/WebService/ProductImageService/2006/03")]
        [return: System.Xml.Serialization.SoapElementAttribute("Exists")]
        public bool exists(string TObjectPath, string TFileName) {
            object[] results = this.Invoke("exists", new object[] {
                        TObjectPath,
                        TFileName});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult Beginexists(string TObjectPath, string TFileName, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("exists", new object[] {
                        TObjectPath,
                        TFileName}, callback, asyncState);
        }
        
        /// <remarks/>
        public bool Endexists(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void existsAsync(string TObjectPath, string TFileName) {
            this.existsAsync(TObjectPath, TFileName, null);
        }
        
        /// <remarks/>
        public void existsAsync(string TObjectPath, string TFileName, object userState) {
            if ((this.existsOperationCompleted == null)) {
                this.existsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnexistsOperationCompleted);
            }
            this.InvokeAsync("exists", new object[] {
                        TObjectPath,
                        TFileName}, this.existsOperationCompleted, userState);
        }
        
        private void OnexistsOperationCompleted(object arg) {
            if ((this.existsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.existsCompleted(this, new existsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn://epages.de/WebService/ProductImageService/2006/03#delete", RequestNamespace="urn://epages.de/WebService/ProductImageService/2006/03", ResponseNamespace="urn://epages.de/WebService/ProductImageService/2006/03")]
        [return: System.Xml.Serialization.SoapElementAttribute("Files")]
        public TDelete_Return[] delete(string TObjectPath, string[] TListOfFileNames) {
            object[] results = this.Invoke("delete", new object[] {
                        TObjectPath,
                        TListOfFileNames});
            return ((TDelete_Return[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult Begindelete(string TObjectPath, string[] TListOfFileNames, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("delete", new object[] {
                        TObjectPath,
                        TListOfFileNames}, callback, asyncState);
        }
        
        /// <remarks/>
        public TDelete_Return[] Enddelete(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((TDelete_Return[])(results[0]));
        }
        
        /// <remarks/>
        public void deleteAsync(string TObjectPath, string[] TListOfFileNames) {
            this.deleteAsync(TObjectPath, TListOfFileNames, null);
        }
        
        /// <remarks/>
        public void deleteAsync(string TObjectPath, string[] TListOfFileNames, object userState) {
            if ((this.deleteOperationCompleted == null)) {
                this.deleteOperationCompleted = new System.Threading.SendOrPostCallback(this.OndeleteOperationCompleted);
            }
            this.InvokeAsync("delete", new object[] {
                        TObjectPath,
                        TListOfFileNames}, this.deleteOperationCompleted, userState);
        }
        
        private void OndeleteOperationCompleted(object arg) {
            if ((this.deleteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.deleteCompleted(this, new deleteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn://epages.de/WebService/ProductImageService/2006/03#upload", RequestNamespace="urn://epages.de/WebService/ProductImageService/2006/03", ResponseNamespace="urn://epages.de/WebService/ProductImageService/2006/03")]
        [return: System.Xml.Serialization.SoapElementAttribute("Files")]
        public TUpload_Return[] upload(string TObjectPath, TUpload_Input ImageData) {
            object[] results = this.Invoke("upload", new object[] {
                        TObjectPath,
                        ImageData});
            return ((TUpload_Return[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult Beginupload(string TObjectPath, TUpload_Input ImageData, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("upload", new object[] {
                        TObjectPath,
                        ImageData}, callback, asyncState);
        }
        
        /// <remarks/>
        public TUpload_Return[] Endupload(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((TUpload_Return[])(results[0]));
        }
        
        /// <remarks/>
        public void uploadAsync(string TObjectPath, TUpload_Input ImageData) {
            this.uploadAsync(TObjectPath, ImageData, null);
        }
        
        /// <remarks/>
        public void uploadAsync(string TObjectPath, TUpload_Input ImageData, object userState) {
            if ((this.uploadOperationCompleted == null)) {
                this.uploadOperationCompleted = new System.Threading.SendOrPostCallback(this.OnuploadOperationCompleted);
            }
            this.InvokeAsync("upload", new object[] {
                        TObjectPath,
                        ImageData}, this.uploadOperationCompleted, userState);
        }
        
        private void OnuploadOperationCompleted(object arg) {
            if ((this.uploadCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.uploadCompleted(this, new uploadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn://epages.de/WebService/ProductImageService/2006/03#uploadscale", RequestNamespace="urn://epages.de/WebService/ProductImageService/2006/03", ResponseNamespace="urn://epages.de/WebService/ProductImageService/2006/03")]
        [return: System.Xml.Serialization.SoapElementAttribute("Files")]
        public TUploadScale_Return[] uploadscale(string TObjectPath, TUploadScale_Input ImageData, TScaleParams ScaleParams) {
            object[] results = this.Invoke("uploadscale", new object[] {
                        TObjectPath,
                        ImageData,
                        ScaleParams});
            return ((TUploadScale_Return[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult Beginuploadscale(string TObjectPath, TUploadScale_Input ImageData, TScaleParams ScaleParams, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("uploadscale", new object[] {
                        TObjectPath,
                        ImageData,
                        ScaleParams}, callback, asyncState);
        }
        
        /// <remarks/>
        public TUploadScale_Return[] Enduploadscale(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((TUploadScale_Return[])(results[0]));
        }
        
        /// <remarks/>
        public void uploadscaleAsync(string TObjectPath, TUploadScale_Input ImageData, TScaleParams ScaleParams) {
            this.uploadscaleAsync(TObjectPath, ImageData, ScaleParams, null);
        }
        
        /// <remarks/>
        public void uploadscaleAsync(string TObjectPath, TUploadScale_Input ImageData, TScaleParams ScaleParams, object userState) {
            if ((this.uploadscaleOperationCompleted == null)) {
                this.uploadscaleOperationCompleted = new System.Threading.SendOrPostCallback(this.OnuploadscaleOperationCompleted);
            }
            this.InvokeAsync("uploadscale", new object[] {
                        TObjectPath,
                        ImageData,
                        ScaleParams}, this.uploadscaleOperationCompleted, userState);
        }
        
        private void OnuploadscaleOperationCompleted(object arg) {
            if ((this.uploadscaleCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.uploadscaleCompleted(this, new uploadscaleCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/ProductImageTypes/2006/03")]
    public partial class TDelete_Return {
        
        private string pathField;
        
        private bool deletedField;
        
        private bool deletedFieldSpecified;
        
        private TError errorField;
        
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/ProductImageTypes/2006/03")]
    public partial class TUploadScale_Return {
        
        private bool writeOKField;
        
        private bool writeOKFieldSpecified;
        
        private bool scaleOKField;
        
        private bool scaleOKFieldSpecified;
        
        private string fileField;
        
        private TError errorField;
        
        /// <remarks/>
        public bool WriteOK {
            get {
                return this.writeOKField;
            }
            set {
                this.writeOKField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool WriteOKSpecified {
            get {
                return this.writeOKFieldSpecified;
            }
            set {
                this.writeOKFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool ScaleOK {
            get {
                return this.scaleOKField;
            }
            set {
                this.scaleOKField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool ScaleOKSpecified {
            get {
                return this.scaleOKFieldSpecified;
            }
            set {
                this.scaleOKFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string File {
            get {
                return this.fileField;
            }
            set {
                this.fileField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/ProductImageTypes/2006/03")]
    public partial class TScaleParams {
        
        private bool sCALE_BORDER_IMAGE_hField;
        
        private bool sCALE_BORDER_IMAGE_hFieldSpecified;
        
        private bool sCALE_BORDER_IMAGE_mField;
        
        private bool sCALE_BORDER_IMAGE_mFieldSpecified;
        
        private string sCALE_BORDER_COLOR_hField;
        
        private string sCALE_BORDER_COLOR_mField;
        
        private string sCALE_NAME_hField;
        
        private string sCALE_NAME_mField;
        
        private string sCALE_NAME_sField;
        
        private string sCALE_SIZE_hField;
        
        private string sCALE_SIZE_mField;
        
        private string sCALE_SIZE_sField;
        
        /// <remarks/>
        public bool SCALE_BORDER_IMAGE_h {
            get {
                return this.sCALE_BORDER_IMAGE_hField;
            }
            set {
                this.sCALE_BORDER_IMAGE_hField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool SCALE_BORDER_IMAGE_hSpecified {
            get {
                return this.sCALE_BORDER_IMAGE_hFieldSpecified;
            }
            set {
                this.sCALE_BORDER_IMAGE_hFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool SCALE_BORDER_IMAGE_m {
            get {
                return this.sCALE_BORDER_IMAGE_mField;
            }
            set {
                this.sCALE_BORDER_IMAGE_mField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool SCALE_BORDER_IMAGE_mSpecified {
            get {
                return this.sCALE_BORDER_IMAGE_mFieldSpecified;
            }
            set {
                this.sCALE_BORDER_IMAGE_mFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string SCALE_BORDER_COLOR_h {
            get {
                return this.sCALE_BORDER_COLOR_hField;
            }
            set {
                this.sCALE_BORDER_COLOR_hField = value;
            }
        }
        
        /// <remarks/>
        public string SCALE_BORDER_COLOR_m {
            get {
                return this.sCALE_BORDER_COLOR_mField;
            }
            set {
                this.sCALE_BORDER_COLOR_mField = value;
            }
        }
        
        /// <remarks/>
        public string SCALE_NAME_h {
            get {
                return this.sCALE_NAME_hField;
            }
            set {
                this.sCALE_NAME_hField = value;
            }
        }
        
        /// <remarks/>
        public string SCALE_NAME_m {
            get {
                return this.sCALE_NAME_mField;
            }
            set {
                this.sCALE_NAME_mField = value;
            }
        }
        
        /// <remarks/>
        public string SCALE_NAME_s {
            get {
                return this.sCALE_NAME_sField;
            }
            set {
                this.sCALE_NAME_sField = value;
            }
        }
        
        /// <remarks/>
        public string SCALE_SIZE_h {
            get {
                return this.sCALE_SIZE_hField;
            }
            set {
                this.sCALE_SIZE_hField = value;
            }
        }
        
        /// <remarks/>
        public string SCALE_SIZE_m {
            get {
                return this.sCALE_SIZE_mField;
            }
            set {
                this.sCALE_SIZE_mField = value;
            }
        }
        
        /// <remarks/>
        public string SCALE_SIZE_s {
            get {
                return this.sCALE_SIZE_sField;
            }
            set {
                this.sCALE_SIZE_sField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/ProductImageTypes/2006/03")]
    public partial class TUploadScale_Input {
        
        private TImageData[] imageDataField;
        
        private string imagesSlideShowStringField;
        
        /// <remarks/>
        public TImageData[] ImageData {
            get {
                return this.imageDataField;
            }
            set {
                this.imageDataField = value;
            }
        }
        
        /// <remarks/>
        public string ImagesSlideShowString {
            get {
                return this.imagesSlideShowStringField;
            }
            set {
                this.imagesSlideShowStringField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/ProductImageTypes/2006/03")]
    public partial class TImageData {
        
        private string fileNameField;
        
        private byte[] contentField;
        
        /// <remarks/>
        public string FileName {
            get {
                return this.fileNameField;
            }
            set {
                this.fileNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType="base64Binary")]
        public byte[] Content {
            get {
                return this.contentField;
            }
            set {
                this.contentField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/ProductImageTypes/2006/03")]
    public partial class TUpload_Return {
        
        private bool writeOKField;
        
        private bool writeOKFieldSpecified;
        
        private string fileField;
        
        private TError errorField;
        
        /// <remarks/>
        public bool WriteOK {
            get {
                return this.writeOKField;
            }
            set {
                this.writeOKField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool WriteOKSpecified {
            get {
                return this.writeOKFieldSpecified;
            }
            set {
                this.writeOKFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string File {
            get {
                return this.fileField;
            }
            set {
                this.fileField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/ProductImageTypes/2006/03")]
    public partial class TUpload_Input {
        
        private TImageData[] imageDataField;
        
        private string imagesSlideShowStringField;
        
        /// <remarks/>
        public TImageData[] ImageData {
            get {
                return this.imageDataField;
            }
            set {
                this.imageDataField = value;
            }
        }
        
        /// <remarks/>
        public string ImagesSlideShowString {
            get {
                return this.imagesSlideShowStringField;
            }
            set {
                this.imagesSlideShowStringField = value;
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
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
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
    public delegate void uploadCompletedEventHandler(object sender, uploadCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class uploadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal uploadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TUpload_Return[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TUpload_Return[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void uploadscaleCompletedEventHandler(object sender, uploadscaleCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class uploadscaleCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal uploadscaleCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TUploadScale_Return[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TUploadScale_Return[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591