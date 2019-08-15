// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1318
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#pragma warning disable 1591

namespace System.Data.Tests {


    /// <summary>
    ///Represents a strongly typed in-memory cache of data.
    ///</summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [global::System.Serializable()]
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema")]
    [global::System.Xml.Serialization.XmlRootAttribute("DataSet1")]
//    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")]
    public partial class DataSet1 : global::System.Data.DataSet {

        private DataTable1DataTable tableDataTable1;

        private global::System.Data.SchemaSerializationMode _schemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public DataSet1() {
            this.BeginInit();
            this.InitClass();
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            base.Relations.CollectionChanged += schemaChangedHandler;
            this.EndInit();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected DataSet1(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
                base(info, context, false) {
            if ((this.IsBinarySerialized(info, context) == true)) {
                this.InitVars(false);
                global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler1 = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
                this.Tables.CollectionChanged += schemaChangedHandler1;
                this.Relations.CollectionChanged += schemaChangedHandler1;
                return;
            }
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((this.DetermineSchemaSerializationMode(info, context) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
                if ((ds.Tables["DataTable1"] != null)) {
                    base.Tables.Add(new DataTable1DataTable(ds.Tables["DataTable1"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
            }
            this.GetSerializationData(info, context);
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public DataTable1DataTable DataTable1 {
            get {
                return this.tableDataTable1;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.BrowsableAttribute(true)]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public override global::System.Data.SchemaSerializationMode SchemaSerializationMode {
            get {
                return this._schemaSerializationMode;
            }
            set {
                this._schemaSerializationMode = value;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataTableCollection Tables {
            get {
                return base.Tables;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataRelationCollection Relations {
            get {
                return base.Relations;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override void InitializeDerivedDataSet() {
            this.BeginInit();
            this.InitClass();
            this.EndInit();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public override global::System.Data.DataSet Clone() {
            DataSet1 cln = ((DataSet1)(base.Clone()));
            cln.InitVars();
            cln.SchemaSerializationMode = this.SchemaSerializationMode;
            return cln;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override bool ShouldSerializeTables() {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override bool ShouldSerializeRelations() {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override void ReadXmlSerializable(global::System.Xml.XmlReader reader) {
            if ((this.DetermineSchemaSerializationMode(reader) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                this.Reset();
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXml(reader);
                if ((ds.Tables["DataTable1"] != null)) {
                    base.Tables.Add(new DataTable1DataTable(ds.Tables["DataTable1"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXml(reader);
                this.InitVars();
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override global::System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            global::System.IO.MemoryStream stream = new global::System.IO.MemoryStream();
            this.WriteXmlSchema(new global::System.Xml.XmlTextWriter(stream, null));
            stream.Position = 0;
            return global::System.Xml.Schema.XmlSchema.Read(new global::System.Xml.XmlTextReader(stream), null);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        internal void InitVars() {
            this.InitVars(true);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        internal void InitVars(bool initTable) {
            this.tableDataTable1 = ((DataTable1DataTable)(base.Tables["DataTable1"]));
            if ((initTable == true)) {
                if ((this.tableDataTable1 != null)) {
                    this.tableDataTable1.InitVars();
                }
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void InitClass() {
            this.DataSetName = "DataSet1";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/DataSet1.xsd";
            this.EnforceConstraints = true;
            this.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
            this.tableDataTable1 = new DataTable1DataTable();
            base.Tables.Add(this.tableDataTable1);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private bool ShouldSerializeDataTable1() {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void SchemaChanged(object sender, global::System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == global::System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedDataSetSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
            DataSet1 ds = new DataSet1();
            global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
            global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
            xs.Add(ds.GetSchemaSerializable());
            global::System.Xml.Schema.XmlSchemaAny any = new global::System.Xml.Schema.XmlSchemaAny();
            any.Namespace = ds.Namespace;
            sequence.Items.Add(any);
            type.Particle = sequence;
            return type;
        }

        public delegate void DataTable1RowChangeEventHandler(object sender, DataTable1RowChangeEvent e);

        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class DataTable1DataTable : global::System.Data.DataTable, global::System.Collections.IEnumerable {

            private global::System.Data.DataColumn columnColumn1;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public DataTable1DataTable() {
                this.TableName = "DataTable1";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal DataTable1DataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected DataTable1DataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
                    base(info, context) {
                this.InitVars();
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn Column1Column {
                get {
                    return this.columnColumn1;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public DataTable1Row this[int index] {
                get {
                    return ((DataTable1Row)(this.Rows[index]));
                }
            }

            public event DataTable1RowChangeEventHandler DataTable1RowChanging;

            public event DataTable1RowChangeEventHandler DataTable1RowChanged;

            public event DataTable1RowChangeEventHandler DataTable1RowDeleting;

            public event DataTable1RowChangeEventHandler DataTable1RowDeleted;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void AddDataTable1Row(DataTable1Row row) {
                this.Rows.Add(row);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public DataTable1Row AddDataTable1Row(string Column1) {
                DataTable1Row rowDataTable1Row = ((DataTable1Row)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        Column1};
                rowDataTable1Row.ItemArray = columnValuesArray;
                this.Rows.Add(rowDataTable1Row);
                return rowDataTable1Row;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public virtual global::System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public override global::System.Data.DataTable Clone() {
                DataTable1DataTable cln = ((DataTable1DataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override global::System.Data.DataTable CreateInstance() {
                return new DataTable1DataTable();
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal void InitVars() {
                this.columnColumn1 = base.Columns["Column1"];
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private void InitClass() {
                this.columnColumn1 = new global::System.Data.DataColumn("Column1", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnColumn1);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public DataTable1Row NewDataTable1Row() {
                return ((DataTable1Row)(this.NewRow()));
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new DataTable1Row(builder);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override global::System.Type GetRowType() {
                return typeof(DataTable1Row);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.DataTable1RowChanged != null)) {
                    this.DataTable1RowChanged(this, new DataTable1RowChangeEvent(((DataTable1Row)(e.Row)), e.Action));
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.DataTable1RowChanging != null)) {
                    this.DataTable1RowChanging(this, new DataTable1RowChangeEvent(((DataTable1Row)(e.Row)), e.Action));
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.DataTable1RowDeleted != null)) {
                    this.DataTable1RowDeleted(this, new DataTable1RowChangeEvent(((DataTable1Row)(e.Row)), e.Action));
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.DataTable1RowDeleting != null)) {
                    this.DataTable1RowDeleting(this, new DataTable1RowChangeEvent(((DataTable1Row)(e.Row)), e.Action));
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void RemoveDataTable1Row(DataTable1Row row) {
                this.Rows.Remove(row);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                DataSet1 ds = new DataSet1();
                xs.Add(ds.GetSchemaSerializable());
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "DataTable1DataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                return type;
            }
        }

        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        public partial class DataTable1Row : global::System.Data.DataRow {

            private DataTable1DataTable tableDataTable1;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal DataTable1Row(global::System.Data.DataRowBuilder rb) :
                    base(rb) {
                this.tableDataTable1 = ((DataTable1DataTable)(this.Table));
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public string Column1 {
                get {
                    try {
                        return ((string)(this[this.tableDataTable1.Column1Column]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Column1\' in table \'DataTable1\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableDataTable1.Column1Column] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public bool IsColumn1Null() {
                return this.IsNull(this.tableDataTable1.Column1Column);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void SetColumn1Null() {
                this[this.tableDataTable1.Column1Column] = global::System.DBNull.Value;
            }
        }

        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        public class DataTable1RowChangeEvent : global::System.EventArgs {

            private DataTable1Row eventRow;

            private global::System.Data.DataRowAction eventAction;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public DataTable1RowChangeEvent(DataTable1Row row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public DataTable1Row Row {
                get {
                    return this.eventRow;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}

#pragma warning restore 1591
