﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeFluentEntities.Bencher.Production
{
    using CodeFluent.Runtime;
    using CodeFluent.Runtime.Utilities;
    
    
    // CodeFluent Entities generated (http://www.softfluent.com). Date: Tuesday, 18 March 2014 16:33.
    // Build:1.0.61214.0764
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.61214.0764")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DataObjectAttribute()]
    [System.Diagnostics.DebuggerDisplayAttribute("EK={EntityKey}, WorkOrderID={WorkOrderID}")]
    [System.ComponentModel.TypeConverterAttribute(typeof(CodeFluent.Runtime.Design.NameTypeConverter))]
    public partial class WorkOrder : System.ICloneable, System.IComparable, System.IComparable<CodeFluentEntities.Bencher.Production.WorkOrder>, CodeFluent.Runtime.ICodeFluentEntity, System.ComponentModel.IDataErrorInfo, CodeFluent.Runtime.ICodeFluentMemberValidator, CodeFluent.Runtime.ICodeFluentSummaryValidator, System.IEquatable<CodeFluentEntities.Bencher.Production.WorkOrder>
    {
        
        private bool _raisePropertyChangedEvents = true;
        
        private CodeFluent.Runtime.CodeFluentEntityState _entityState;
        
        private int _workOrderID = -1;
        
        private int _orderQty = CodeFluentPersistence.DefaultInt32Value;
        
        private int _stockedQty = CodeFluentPersistence.DefaultInt32Value;
        
        private short _scrappedQty = CodeFluentPersistence.DefaultInt16Value;
        
        private System.DateTime _startDate = CodeFluentPersistence.DefaultDateTimeValue;
        
        private System.Nullable<System.DateTime> _endDate = null;
        
        private System.DateTime _dueDate = CodeFluentPersistence.DefaultDateTimeValue;
        
        private System.DateTime _modifiedDate = CodeFluentPersistence.DefaultDateTimeValue;
        
        private short _scrapReasonScrapReasonID = -1;
        
        [System.NonSerializedAttribute()]
        private CodeFluentEntities.Bencher.Production.ScrapReason _scrapReason = null;
        
        private int _productProductID = -1;
        
        [System.NonSerializedAttribute()]
        private CodeFluentEntities.Bencher.Production.Product _product = null;
        
        public WorkOrder()
        {
            this._entityState = CodeFluent.Runtime.CodeFluentEntityState.Created;
        }
        
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool RaisePropertyChangedEvents
        {
            get
            {
                return this._raisePropertyChangedEvents;
            }
            set
            {
                this._raisePropertyChangedEvents = value;
            }
        }
        
        public virtual string EntityKey
        {
            get
            {
                return this.WorkOrderID.ToString();
            }
            set
            {
                this.WorkOrderID = ((int)(ConvertUtilities.ChangeType(value, typeof(int), -1)));
            }
        }
        
        public virtual string EntityDisplayName
        {
            get
            {
                return this.WorkOrderID.ToString();
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(((int)(-1)))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(int))]
        [System.ComponentModel.DataObjectFieldAttribute(true)]
        public int WorkOrderID
        {
            get
            {
                return this._workOrderID;
            }
            set
            {
                this._workOrderID = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("WorkOrderID"));
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultInt32Value)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(int))]
        public int OrderQty
        {
            get
            {
                return this._orderQty;
            }
            set
            {
                this._orderQty = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("OrderQty"));
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultInt32Value)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(int))]
        public int StockedQty
        {
            get
            {
                return this._stockedQty;
            }
            set
            {
                this._stockedQty = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("StockedQty"));
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultInt16Value)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(short))]
        public short ScrappedQty
        {
            get
            {
                return this._scrappedQty;
            }
            set
            {
                this._scrappedQty = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ScrappedQty"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(System.DateTime))]
        public System.DateTime StartDate
        {
            get
            {
                return this._startDate;
            }
            set
            {
                this._startDate = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("StartDate"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> EndDate
        {
            get
            {
                return this._endDate;
            }
            set
            {
                this._endDate = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("EndDate"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(System.DateTime))]
        public System.DateTime DueDate
        {
            get
            {
                return this._dueDate;
            }
            set
            {
                this._dueDate = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("DueDate"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(System.DateTime))]
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._modifiedDate;
            }
            set
            {
                this._modifiedDate = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ModifiedDate"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false)]
        [System.ComponentModel.DataObjectFieldAttribute(true)]
        public short ScrapReasonScrapReasonID
        {
            get
            {
                if (((this._scrapReasonScrapReasonID == -1) 
                            && (this._scrapReason != null)))
                {
                    this._scrapReasonScrapReasonID = this._scrapReason.ScrapReasonID;
                }
                return this._scrapReasonScrapReasonID;
            }
            set
            {
                if ((System.Collections.Generic.EqualityComparer<short>.Default.Equals(value, this.ScrapReasonScrapReasonID) == true))
                {
                    return;
                }
                this._scrapReason = null;
                this._scrapReasonScrapReasonID = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ScrapReason"));
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ScrapReasonScrapReasonID"));
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public CodeFluentEntities.Bencher.Production.ScrapReason ScrapReason
        {
            get
            {
                if ((this._scrapReason == null))
                {
                    this._scrapReason = CodeFluentEntities.Bencher.Production.ScrapReason.Load(this._scrapReasonScrapReasonID);
                }
                return this._scrapReason;
            }
            set
            {
                this._scrapReasonScrapReasonID = -1;
                this._scrapReason = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ScrapReason"));
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ScrapReasonScrapReasonID"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false)]
        [System.ComponentModel.DataObjectFieldAttribute(true)]
        public int ProductProductID
        {
            get
            {
                if (((this._productProductID == -1) 
                            && (this._product != null)))
                {
                    this._productProductID = this._product.ProductID;
                }
                return this._productProductID;
            }
            set
            {
                if ((System.Collections.Generic.EqualityComparer<int>.Default.Equals(value, this.ProductProductID) == true))
                {
                    return;
                }
                this._product = null;
                this._productProductID = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Product"));
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ProductProductID"));
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public CodeFluentEntities.Bencher.Production.Product Product
        {
            get
            {
                if ((this._product == null))
                {
                    this._product = CodeFluentEntities.Bencher.Production.Product.Load(this._productProductID);
                }
                return this._product;
            }
            set
            {
                this._productProductID = -1;
                this._product = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Product"));
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ProductProductID"));
            }
        }
        
        string System.ComponentModel.IDataErrorInfo.Error
        {
            get
            {
                return this.Validate(System.Globalization.CultureInfo.CurrentCulture);
            }
        }
        
        string System.ComponentModel.IDataErrorInfo.this[string columnName]
        {
            get
            {
                return CodeFluentPersistence.ValidateMember(System.Globalization.CultureInfo.CurrentCulture, this, columnName, null);
            }
        }
        
        public virtual CodeFluent.Runtime.CodeFluentEntityState EntityState
        {
            get
            {
                return this._entityState;
            }
            set
            {
                if ((System.Collections.Generic.EqualityComparer<CodeFluent.Runtime.CodeFluentEntityState>.Default.Equals(value, this.EntityState) == true))
                {
                    return;
                }
                this._entityState = value;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("EntityState"));
            }
        }
        
        [field:System.NonSerializedAttribute()]
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        [field:System.NonSerializedAttribute()]
        public event CodeFluent.Runtime.CodeFluentEntityActionEventHandler EntityAction;
        
        protected virtual void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e)
        {
            if ((this.RaisePropertyChangedEvents == false))
            {
                return;
            }
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, e);
            }
        }
        
        protected virtual void OnEntityAction(CodeFluent.Runtime.CodeFluentEntityActionEventArgs e)
        {
            if ((this.EntityAction != null))
            {
                this.EntityAction(this, e);
            }
        }
        
        public virtual bool Equals(CodeFluentEntities.Bencher.Production.WorkOrder workOrder)
        {
            if ((workOrder == null))
            {
                return false;
            }
            if ((this.WorkOrderID == -1))
            {
                return base.Equals(workOrder);
            }
            return (this.WorkOrderID.Equals(workOrder.WorkOrderID) == true);
        }
        
        public override int GetHashCode()
        {
            return this._workOrderID;
        }
        
        public override bool Equals(object obj)
        {
            CodeFluentEntities.Bencher.Production.WorkOrder workOrder = null;
			workOrder = obj as CodeFluentEntities.Bencher.Production.WorkOrder;
            return this.Equals(workOrder);
        }
        
        int System.IComparable.CompareTo(object value)
        {
            CodeFluentEntities.Bencher.Production.WorkOrder workOrder = null;
workOrder = value as CodeFluentEntities.Bencher.Production.WorkOrder;
            if ((workOrder == null))
            {
                throw new System.ArgumentException("value");
            }
            int localCompareTo = this.CompareTo(workOrder);
            return localCompareTo;
        }
        
        public virtual int CompareTo(CodeFluentEntities.Bencher.Production.WorkOrder workOrder)
        {
            if ((workOrder == null))
            {
                throw new System.ArgumentNullException("workOrder");
            }
            int localCompareTo = this.WorkOrderID.CompareTo(workOrder.WorkOrderID);
            return localCompareTo;
        }
        
        public virtual string Validate(System.Globalization.CultureInfo culture)
        {
            return CodeFluentPersistence.Validate(culture, this, null);
        }
        
        public virtual void Validate(System.Globalization.CultureInfo culture, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Validating, true, results);
            evt.Culture = culture;
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                string externalValidate;
                if ((evt.Argument != null))
                {
                    externalValidate = evt.Argument.ToString();
                }
                else
                {
                    externalValidate = CodeFluentEntities.Bencher.Resources.Manager.GetStringWithDefault(culture, "CodeFluentEntities.Bencher.Production.WorkOrder.ExternalValidate", "Type \'CodeFluentEntities.Bencher.Production.WorkOrder\' cannot be validated.", null);
                }
                CodeFluentPersistence.AddValidationError(results, externalValidate);
            }
            CodeFluentPersistence.ValidateMember(culture, results, this, null);
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Validated, false, results));
        }
        
        public void Validate()
        {
            string var = this.Validate(System.Globalization.CultureInfo.CurrentCulture);
            if ((var != null))
            {
                throw new CodeFluent.Runtime.CodeFluentValidationException(var);
            }
        }
        
        string CodeFluent.Runtime.ICodeFluentValidator.Validate(System.Globalization.CultureInfo culture)
        {
            string localValidate = this.Validate(culture);
            return localValidate;
        }
        
        void CodeFluent.Runtime.ICodeFluentMemberValidator.Validate(System.Globalization.CultureInfo culture, string memberName, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
            this.ValidateMember(culture, memberName, results);
        }
        
        public virtual bool Delete()
        {
            bool ret = false;
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Deleting, true);
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                return ret;
            }
            if ((this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.Deleted))
            {
                return ret;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand("Production", "WorkOrder", "Delete");
            persistence.AddRawParameter("@WorkOrderID", this.WorkOrderID);
            persistence.ExecuteNonQuery();
            this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Deleted;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Deleted, false, false));
            ret = true;
            return ret;
        }
        
        protected virtual void ReadRecord(System.Data.IDataReader reader, CodeFluent.Runtime.CodeFluentReloadOptions options)
        {
            if ((reader == null))
            {
                throw new System.ArgumentNullException("reader");
            }
            if ((((options & CodeFluent.Runtime.CodeFluentReloadOptions.Properties) 
                        == 0) 
                        == false))
            {
                this._workOrderID = CodeFluentPersistence.GetReaderValue(reader, "WorkOrderID", ((int)(-1)));
                this._orderQty = CodeFluentPersistence.GetReaderValue(reader, "OrderQty", ((int)(CodeFluentPersistence.DefaultInt32Value)));
                this._stockedQty = CodeFluentPersistence.GetReaderValue(reader, "StockedQty", ((int)(CodeFluentPersistence.DefaultInt32Value)));
                this._scrappedQty = CodeFluentPersistence.GetReaderValue(reader, "ScrappedQty", ((short)(CodeFluentPersistence.DefaultInt16Value)));
                this._startDate = CodeFluentPersistence.GetReaderValue(reader, "StartDate", ((System.DateTime)(CodeFluentPersistence.DefaultDateTimeValue)));
                this._endDate = CodeFluentPersistence.GetReaderValue<System.DateTime>(reader, "EndDate");
                this._dueDate = CodeFluentPersistence.GetReaderValue(reader, "DueDate", ((System.DateTime)(CodeFluentPersistence.DefaultDateTimeValue)));
                this._modifiedDate = CodeFluentPersistence.GetReaderValue(reader, "ModifiedDate", ((System.DateTime)(CodeFluentPersistence.DefaultDateTimeValue)));
                this.ScrapReasonScrapReasonID = CodeFluentPersistence.GetReaderValue(reader, "ScrapReasonID", ((short)(-1)));
                this.ProductProductID = CodeFluentPersistence.GetReaderValue(reader, "ProductID", ((int)(-1)));
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.ReadRecord, false, false));
        }
        
        void CodeFluent.Runtime.ICodeFluentEntity.ReadRecord(System.Data.IDataReader reader)
        {
            this.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.Default);
        }
        
        protected virtual void ReadRecordOnSave(System.Data.IDataReader reader)
        {
            if ((reader == null))
            {
                throw new System.ArgumentNullException("reader");
            }
            this._workOrderID = CodeFluentPersistence.GetReaderValue(reader, "WorkOrderID", ((int)(-1)));
            this._stockedQty = CodeFluentPersistence.GetReaderValue(reader, "StockedQty", ((int)(CodeFluentPersistence.DefaultInt32Value)));
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.ReadRecordOnSave, false, false));
        }
        
        void CodeFluent.Runtime.ICodeFluentEntity.ReadRecordOnSave(System.Data.IDataReader reader)
        {
            this.ReadRecordOnSave(reader);
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static CodeFluentEntities.Bencher.Production.WorkOrder Load(int workOrderID)
        {
            if ((workOrderID == -1))
            {
                return null;
            }
            CodeFluentEntities.Bencher.Production.WorkOrder workOrder = new CodeFluentEntities.Bencher.Production.WorkOrder();
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand("Production", "WorkOrder", "Load");
            persistence.AddRawParameter("@WorkOrderID", workOrderID);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    workOrder.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.Default);
                    workOrder.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                    return workOrder;
                }
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            return null;
        }
        
        public virtual bool Reload(CodeFluent.Runtime.CodeFluentReloadOptions options)
        {
            bool ret = false;
            if ((this.WorkOrderID == -1))
            {
                return ret;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand("Production", "WorkOrder", "Load");
            persistence.AddRawParameter("@WorkOrderID", this.WorkOrderID);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    this.ReadRecord(reader, options);
                    this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                    ret = true;
                }
                else
                {
                    this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Deleted;
                }
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            return ret;
        }
        
        protected virtual bool BaseSave(bool force)
        {
            if ((this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.ToBeDeleted))
            {
                this.Delete();
                return false;
            }
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Saving, true);
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                return false;
            }
            CodeFluentPersistence.ThrowIfDeleted(this);
            this.Validate();
            if (((force == false) 
                        && (this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.Unchanged)))
            {
                return false;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand("Production", "WorkOrder", "Save");
            persistence.AddRawParameter("@WorkOrderID", this.WorkOrderID);
            persistence.AddRawParameter("@OrderQty", this.OrderQty);
            persistence.AddRawParameter("@ScrappedQty", this.ScrappedQty);
            persistence.AddRawParameter("@StartDate", this.StartDate);
            persistence.AddParameter("@EndDate", this.EndDate);
            persistence.AddRawParameter("@DueDate", this.DueDate);
            persistence.AddRawParameter("@ModifiedDate", this.ModifiedDate);
            persistence.AddRawParameter("@ScrapReasonID", this.ScrapReasonScrapReasonID);
            persistence.AddRawParameter("@ProductID", this.ProductProductID);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    this.ReadRecordOnSave(reader);
                }
                CodeFluentPersistence.NextResults(reader);
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Saved, false, false));
            this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
            return true;
        }
        
        public virtual bool Save()
        {
            bool localSave = this.BaseSave(false);
            return localSave;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, true)]
        public static bool Save(CodeFluentEntities.Bencher.Production.WorkOrder workOrder)
        {
            if ((workOrder == null))
            {
                return false;
            }
            bool ret = workOrder.Save();
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public static bool Insert(CodeFluentEntities.Bencher.Production.WorkOrder workOrder)
        {
            bool ret = CodeFluentEntities.Bencher.Production.WorkOrder.Save(workOrder);
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public static bool Delete(CodeFluentEntities.Bencher.Production.WorkOrder workOrder)
        {
            if ((workOrder == null))
            {
                return false;
            }
            bool ret = workOrder.Delete();
            return ret;
        }
        
        public string Trace()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            System.IO.StringWriter stringWriter = new System.IO.StringWriter(stringBuilder, System.Globalization.CultureInfo.CurrentCulture);
            System.CodeDom.Compiler.IndentedTextWriter writer = new System.CodeDom.Compiler.IndentedTextWriter(stringWriter);
            this.BaseTrace(writer);
            writer.Flush();
            ((System.IDisposable)(writer)).Dispose();
            ((System.IDisposable)(stringWriter)).Dispose();
            string sr = stringBuilder.ToString();
            return sr;
        }
        
        void CodeFluent.Runtime.ICodeFluentObject.Trace(System.CodeDom.Compiler.IndentedTextWriter writer)
        {
            this.BaseTrace(writer);
        }
        
        protected virtual void BaseTrace(System.CodeDom.Compiler.IndentedTextWriter writer)
        {
            writer.Write("[");
            writer.Write("WorkOrderID=");
            writer.Write(this.WorkOrderID);
            writer.Write(",");
            writer.Write("OrderQty=");
            writer.Write(this.OrderQty);
            writer.Write(",");
            writer.Write("StockedQty=");
            writer.Write(this.StockedQty);
            writer.Write(",");
            writer.Write("ScrappedQty=");
            writer.Write(this.ScrappedQty);
            writer.Write(",");
            writer.Write("StartDate=");
            writer.Write(this.StartDate);
            writer.Write(",");
            writer.Write("EndDate=");
            writer.Write(this.EndDate);
            writer.Write(",");
            writer.Write("DueDate=");
            writer.Write(this.DueDate);
            writer.Write(",");
            writer.Write("ModifiedDate=");
            writer.Write(this.ModifiedDate);
            writer.Write(",");
            writer.Write("ScrapReason=");
            if ((this._scrapReason != null))
            {
                ((CodeFluent.Runtime.ICodeFluentObject)(this._scrapReason)).Trace(writer);
            }
            else
            {
                writer.Write("<null>");
            }
            writer.Write(",");
            writer.Write("_scrapReasonScrapReasonID=");
            writer.Write(this._scrapReasonScrapReasonID);
            writer.Write(",");
            writer.Write("Product=");
            if ((this._product != null))
            {
                ((CodeFluent.Runtime.ICodeFluentObject)(this._product)).Trace(writer);
            }
            else
            {
                writer.Write("<null>");
            }
            writer.Write(",");
            writer.Write("_productProductID=");
            writer.Write(this._productProductID);
            writer.Write(", EntityState=");
            writer.Write(this.EntityState);
            writer.Write("]");
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static CodeFluentEntities.Bencher.Production.WorkOrder LoadByEntityKey(string key)
        {
            if ((key == string.Empty))
            {
                return null;
            }
            CodeFluentEntities.Bencher.Production.WorkOrder workOrder;
            int var = ((int)(ConvertUtilities.ChangeType(key, typeof(int), -1)));
            workOrder = CodeFluentEntities.Bencher.Production.WorkOrder.Load(var);
            return workOrder;
        }
        
        protected virtual void ValidateMember(System.Globalization.CultureInfo culture, string memberName, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
        }
        
        public CodeFluentEntities.Bencher.Production.WorkOrder Clone(bool deep)
        {
            CodeFluentEntities.Bencher.Production.WorkOrder workOrder = new CodeFluentEntities.Bencher.Production.WorkOrder();
            this.CopyTo(workOrder, deep);
            return workOrder;
        }
        
        public CodeFluentEntities.Bencher.Production.WorkOrder Clone()
        {
            CodeFluentEntities.Bencher.Production.WorkOrder localClone = this.Clone(true);
            return localClone;
        }
        
        object System.ICloneable.Clone()
        {
            object localClone = this.Clone();
            return localClone;
        }
        
        public virtual void CopyFrom(System.Collections.IDictionary dict, bool deep)
        {
            if ((dict == null))
            {
                throw new System.ArgumentNullException("dict");
            }
            if ((dict.Contains("WorkOrderID") == true))
            {
                this.WorkOrderID = ((int)(ConvertUtilities.ChangeType(dict["WorkOrderID"], typeof(int), -1)));
            }
            if ((dict.Contains("EndDate") == true))
            {
                this.EndDate = ((System.Nullable<System.DateTime>)(ConvertUtilities.ChangeType(dict["EndDate"], typeof(System.Nullable<System.DateTime>), null)));
            }
            if ((dict.Contains("DueDate") == true))
            {
                this.DueDate = ((System.DateTime)(ConvertUtilities.ChangeType(dict["DueDate"], typeof(System.DateTime), CodeFluentPersistence.DefaultDateTimeValue)));
            }
            if ((dict.Contains("ModifiedDate") == true))
            {
                this.ModifiedDate = ((System.DateTime)(ConvertUtilities.ChangeType(dict["ModifiedDate"], typeof(System.DateTime), CodeFluentPersistence.DefaultDateTimeValue)));
            }
            if ((dict.Contains("StartDate") == true))
            {
                this.StartDate = ((System.DateTime)(ConvertUtilities.ChangeType(dict["StartDate"], typeof(System.DateTime), CodeFluentPersistence.DefaultDateTimeValue)));
            }
            if ((dict.Contains("OrderQty") == true))
            {
                this.OrderQty = ((int)(ConvertUtilities.ChangeType(dict["OrderQty"], typeof(int), CodeFluentPersistence.DefaultInt32Value)));
            }
            if ((dict.Contains("StockedQty") == true))
            {
                this.StockedQty = ((int)(ConvertUtilities.ChangeType(dict["StockedQty"], typeof(int), CodeFluentPersistence.DefaultInt32Value)));
            }
            if ((dict.Contains("ScrappedQty") == true))
            {
                this.ScrappedQty = ((short)(ConvertUtilities.ChangeType(dict["ScrappedQty"], typeof(short), CodeFluentPersistence.DefaultInt16Value)));
            }
            if ((dict.Contains("ProductProductID") == true))
            {
                this.ProductProductID = ((int)(ConvertUtilities.ChangeType(dict["ProductProductID"], typeof(int), -1)));
            }
            if ((dict.Contains("ScrapReasonScrapReasonID") == true))
            {
                this.ScrapReasonScrapReasonID = ((short)(ConvertUtilities.ChangeType(dict["ScrapReasonScrapReasonID"], typeof(short), -1)));
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyFrom, false, dict));
        }
        
        public virtual void CopyTo(CodeFluentEntities.Bencher.Production.WorkOrder workOrder, bool deep)
        {
            if ((workOrder == null))
            {
                throw new System.ArgumentNullException("workOrder");
            }
            workOrder.WorkOrderID = this.WorkOrderID;
            workOrder.EndDate = this.EndDate;
            workOrder.DueDate = this.DueDate;
            workOrder.ModifiedDate = this.ModifiedDate;
            workOrder.StartDate = this.StartDate;
            workOrder.OrderQty = this.OrderQty;
            workOrder.StockedQty = this.StockedQty;
            workOrder.ScrappedQty = this.ScrappedQty;
            workOrder.ProductProductID = this.ProductProductID;
            workOrder.ScrapReasonScrapReasonID = this.ScrapReasonScrapReasonID;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, workOrder));
        }
        
        public virtual void CopyTo(System.Collections.IDictionary dict, bool deep)
        {
            if ((dict == null))
            {
                throw new System.ArgumentNullException("dict");
            }
            dict["WorkOrderID"] = this.WorkOrderID;
            dict["EndDate"] = this.EndDate;
            dict["DueDate"] = this.DueDate;
            dict["ModifiedDate"] = this.ModifiedDate;
            dict["StartDate"] = this.StartDate;
            dict["OrderQty"] = this.OrderQty;
            dict["StockedQty"] = this.StockedQty;
            dict["ScrappedQty"] = this.ScrappedQty;
            dict["ProductProductID"] = this.ProductProductID;
            dict["ScrapReasonScrapReasonID"] = this.ScrapReasonScrapReasonID;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, dict));
        }
    }
}