//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MtconnectTranspiler.Model
//{

//    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.omg.org/spec/XMI/20131001", IsNullable = false)]
//    public partial class XMI
//    {

//        private object[] itemsField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("File_Export_Path", typeof(File_Export_Path), Namespace = "http://www.magicdraw.com/schemas/CCM_Internal_Implementation_Profile.xmi")]
//        [System.Xml.Serialization.XmlElement("Anything", typeof(Anything), Namespace = "http://www.magicdraw.com/schemas/Concept_Modeling_Profile.xmi")]
//        [System.Xml.Serialization.XmlElement("Concept_Model", typeof(Concept_Model), Namespace = "http://www.magicdraw.com/schemas/Concept_Modeling_Profile.xmi")]
//        [System.Xml.Serialization.XmlElement("Disjoint_With", typeof(Disjoint_With), Namespace = "http://www.magicdraw.com/schemas/Concept_Modeling_Profile.xmi")]
//        [System.Xml.Serialization.XmlElement("Equivalent_Class", typeof(Equivalent_Class), Namespace = "http://www.magicdraw.com/schemas/Concept_Modeling_Profile.xmi")]
//        [System.Xml.Serialization.XmlElement("Equivalent_Property", typeof(Equivalent_Property), Namespace = "http://www.magicdraw.com/schemas/Concept_Modeling_Profile.xmi")]
//        [System.Xml.Serialization.XmlElement("Functional", typeof(Functional), Namespace = "http://www.magicdraw.com/schemas/Concept_Modeling_Profile.xmi")]
//        [System.Xml.Serialization.XmlElement("Literal_Annotation", typeof(Literal_Annotation), Namespace = "http://www.magicdraw.com/schemas/Concept_Modeling_Profile.xmi")]
//        [System.Xml.Serialization.XmlElement("Resource", typeof(Resource), Namespace = "http://www.magicdraw.com/schemas/Concept_Modeling_Profile.xmi")]
//        [System.Xml.Serialization.XmlElement("Restriction", typeof(Restriction), Namespace = "http://www.magicdraw.com/schemas/Concept_Modeling_Profile.xmi")]
//        [System.Xml.Serialization.XmlElement("Transitive", typeof(Transitive), Namespace = "http://www.magicdraw.com/schemas/Concept_Modeling_Profile.xmi")]
//        [System.Xml.Serialization.XmlElement("DependencyMatrix", typeof(DependencyMatrix), Namespace = "http://www.magicdraw.com/schemas/Dependency_Matrix_Profile.xmi")]
//        [System.Xml.Serialization.XmlElement("MatrixFilter", typeof(MatrixFilter), Namespace = "http://www.magicdraw.com/schemas/Dependency_Matrix_Profile.xmi")]
//        [System.Xml.Serialization.XmlElement("deprecated", typeof(deprecated), Namespace = "http://www.magicdraw.com/schemas/Profile.xmi")]
//        [System.Xml.Serialization.XmlElement("extensible", typeof(extensible), Namespace = "http://www.magicdraw.com/schemas/Profile.xmi")]
//        [System.Xml.Serialization.XmlElement("informative", typeof(informative), Namespace = "http://www.magicdraw.com/schemas/Profile.xmi")]
//        [System.Xml.Serialization.XmlElement("normative", typeof(normative), Namespace = "http://www.magicdraw.com/schemas/Profile.xmi")]
//        [System.Xml.Serialization.XmlElement("observes", typeof(observes), Namespace = "http://www.magicdraw.com/schemas/Profile.xmi")]
//        [System.Xml.Serialization.XmlElement("organizer", typeof(organizer), Namespace = "http://www.magicdraw.com/schemas/Profile.xmi")]
//        [System.Xml.Serialization.XmlElement("valueType", typeof(valueType), Namespace = "http://www.magicdraw.com/schemas/Profile.xmi")]
//        [System.Xml.Serialization.XmlElement("SimulationConfig", typeof(SimulationConfig), Namespace = "http://www.magicdraw.com/schemas/SimulationProfile.xmi")]
//        [System.Xml.Serialization.XmlElement("validationRule", typeof(validationRule), Namespace = "http://www.magicdraw.com/schemas/Validation_Profile.xmi")]
//        [System.Xml.Serialization.XmlElement("validationSuite", typeof(validationSuite), Namespace = "http://www.magicdraw.com/schemas/Validation_Profile.xmi")]
//        [System.Xml.Serialization.XmlElement("ConstraintParameter", typeof(ConstraintParameter), Namespace = "http://www.magicdraw.com/spec/Customization/180/SysML")]
//        [System.Xml.Serialization.XmlElement("ConstraintProperty", typeof(ConstraintProperty), Namespace = "http://www.magicdraw.com/spec/Customization/180/SysML")]
//        [System.Xml.Serialization.XmlElement("ExternalModel", typeof(ExternalModel), Namespace = "http://www.magicdraw.com/spec/Customization/180/SysML")]
//        [System.Xml.Serialization.XmlElement("PartProperty", typeof(PartProperty), Namespace = "http://www.magicdraw.com/spec/Customization/180/SysML")]
//        [System.Xml.Serialization.XmlElement("ReferenceProperty", typeof(ReferenceProperty), Namespace = "http://www.magicdraw.com/spec/Customization/180/SysML")]
//        [System.Xml.Serialization.XmlElement("ValueProperty", typeof(ValueProperty), Namespace = "http://www.magicdraw.com/spec/Customization/180/SysML")]
//        [System.Xml.Serialization.XmlElement("BindingConnector", typeof(BindingConnector), Namespace = "http://www.omg.org/spec/SysML/20150709/SysML")]
//        [System.Xml.Serialization.XmlElement("Block", typeof(Block), Namespace = "http://www.omg.org/spec/SysML/20150709/SysML")]
//        [System.Xml.Serialization.XmlElement("ConstraintBlock", typeof(ConstraintBlock), Namespace = "http://www.omg.org/spec/SysML/20150709/SysML")]
//        [System.Xml.Serialization.XmlElement("ElementGroup", typeof(ElementGroup), Namespace = "http://www.omg.org/spec/SysML/20150709/SysML")]
//        [System.Xml.Serialization.XmlElement("NestedConnectorEnd", typeof(NestedConnectorEnd), Namespace = "http://www.omg.org/spec/SysML/20150709/SysML")]
//        [System.Xml.Serialization.XmlElement("ParticipantProperty", typeof(ParticipantProperty), Namespace = "http://www.omg.org/spec/SysML/20150709/SysML")]
//        [System.Xml.Serialization.XmlElement("ValueType", typeof(ValueType), Namespace = "http://www.omg.org/spec/SysML/20150709/SysML")]
//        [System.Xml.Serialization.XmlElement("CustomSort", typeof(CustomSort), Namespace = "http://www.omg.org/spec/UML/20131001/MagicDrawProfile")]
//        [System.Xml.Serialization.XmlElement("DiagramInfo", typeof(DiagramInfo), Namespace = "http://www.omg.org/spec/UML/20131001/MagicDrawProfile")]
//        [System.Xml.Serialization.XmlElement("DiagramTable", typeof(DiagramTable), Namespace = "http://www.omg.org/spec/UML/20131001/MagicDrawProfile")]
//        [System.Xml.Serialization.XmlElement("InstanceTable", typeof(InstanceTable), Namespace = "http://www.omg.org/spec/UML/20131001/MagicDrawProfile")]
//        [System.Xml.Serialization.XmlElement("additionalElementImport", typeof(additionalElementImport), Namespace = "http://www.omg.org/spec/UML/20131001/MagicDrawProfile")]
//        [System.Xml.Serialization.XmlElement("additionalPackageImport", typeof(additionalPackageImport), Namespace = "http://www.omg.org/spec/UML/20131001/MagicDrawProfile")]
//        [System.Xml.Serialization.XmlElement("auxiliaryResource", typeof(auxiliaryResource), Namespace = "http://www.omg.org/spec/UML/20131001/MagicDrawProfile")]
//        [System.Xml.Serialization.XmlElement("complete", typeof(complete), Namespace = "http://www.omg.org/spec/UML/20131001/MagicDrawProfile")]
//        [System.Xml.Serialization.XmlElement("control", typeof(control), Namespace = "http://www.omg.org/spec/UML/20131001/MagicDrawProfile")]
//        [System.Xml.Serialization.XmlElement("Model", typeof(Model1), Namespace = "http://www.omg.org/spec/UML/20131001")]
//        [System.Xml.Serialization.XmlElement("Documentation", typeof(XMIDocumentation))]
//        [System.Xml.Serialization.XmlElement("Extension", typeof(XMIExtension))]
//        public object[] Items
//        {
//            get
//            {
//                return itemsField;
//            }
//            set
//            {
//                itemsField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.magicdraw.com/schemas/CCM_Internal_Implementation_Profile.xmi")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.magicdraw.com/schemas/CCM_Internal_Implementation_Profile.xmi", IsNullable = false)]
//    public partial class File_Export_Path
//    {

//        private string idField;

//        private string base_PackageField;

//        private string fileExportPathField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Package
//        {
//            get
//            {
//                return base_PackageField;
//            }
//            set
//            {
//                base_PackageField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string fileExportPath
//        {
//            get
//            {
//                return fileExportPathField;
//            }
//            set
//            {
//                fileExportPathField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.magicdraw.com/schemas/Concept_Modeling_Profile.xmi")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.magicdraw.com/schemas/Concept_Modeling_Profile.xmi", IsNullable = false)]
//    public partial class Anything
//    {

//        private string idField;

//        private string base_ClassField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Class
//        {
//            get
//            {
//                return base_ClassField;
//            }
//            set
//            {
//                base_ClassField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.magicdraw.com/schemas/Concept_Modeling_Profile.xmi")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.magicdraw.com/schemas/Concept_Modeling_Profile.xmi", IsNullable = false)]
//    public partial class Concept_Model
//    {

//        private string idField;

//        private string base_PackageField;

//        private string namespacePrefixField;

//        private string iRIField;

//        private string versionIRIField;

//        private string labelField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Package
//        {
//            get
//            {
//                return base_PackageField;
//            }
//            set
//            {
//                base_PackageField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string namespacePrefix
//        {
//            get
//            {
//                return namespacePrefixField;
//            }
//            set
//            {
//                namespacePrefixField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string IRI
//        {
//            get
//            {
//                return iRIField;
//            }
//            set
//            {
//                iRIField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string versionIRI
//        {
//            get
//            {
//                return versionIRIField;
//            }
//            set
//            {
//                versionIRIField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string label
//        {
//            get
//            {
//                return labelField;
//            }
//            set
//            {
//                labelField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.magicdraw.com/schemas/Concept_Modeling_Profile.xmi")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.magicdraw.com/schemas/Concept_Modeling_Profile.xmi", IsNullable = false)]
//    public partial class Disjoint_With
//    {

//        private string idField;

//        private string base_DependencyField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Dependency
//        {
//            get
//            {
//                return base_DependencyField;
//            }
//            set
//            {
//                base_DependencyField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.magicdraw.com/schemas/Concept_Modeling_Profile.xmi")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.magicdraw.com/schemas/Concept_Modeling_Profile.xmi", IsNullable = false)]
//    public partial class Equivalent_Class
//    {

//        private string idField;

//        private string base_GeneralizationField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Generalization
//        {
//            get
//            {
//                return base_GeneralizationField;
//            }
//            set
//            {
//                base_GeneralizationField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.magicdraw.com/schemas/Concept_Modeling_Profile.xmi")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.magicdraw.com/schemas/Concept_Modeling_Profile.xmi", IsNullable = false)]
//    public partial class Equivalent_Property
//    {

//        private string idField;

//        private string base_PropertyField;

//        private string equivalent_toField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Property
//        {
//            get
//            {
//                return base_PropertyField;
//            }
//            set
//            {
//                base_PropertyField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string equivalent_to
//        {
//            get
//            {
//                return equivalent_toField;
//            }
//            set
//            {
//                equivalent_toField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.magicdraw.com/schemas/Concept_Modeling_Profile.xmi")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.magicdraw.com/schemas/Concept_Modeling_Profile.xmi", IsNullable = false)]
//    public partial class Functional
//    {

//        private string idField;

//        private string base_PropertyField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Property
//        {
//            get
//            {
//                return base_PropertyField;
//            }
//            set
//            {
//                base_PropertyField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.magicdraw.com/schemas/Concept_Modeling_Profile.xmi")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.magicdraw.com/schemas/Concept_Modeling_Profile.xmi", IsNullable = false)]
//    public partial class Literal_Annotation
//    {

//        private string idField;

//        private string base_CommentField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Comment
//        {
//            get
//            {
//                return base_CommentField;
//            }
//            set
//            {
//                base_CommentField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.magicdraw.com/schemas/Concept_Modeling_Profile.xmi")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.magicdraw.com/schemas/Concept_Modeling_Profile.xmi", IsNullable = false)]
//    public partial class Resource
//    {

//        private string idField;

//        private string base_ClassField;

//        private string iRIField;

//        private string base_PropertyField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Class
//        {
//            get
//            {
//                return base_ClassField;
//            }
//            set
//            {
//                base_ClassField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string IRI
//        {
//            get
//            {
//                return iRIField;
//            }
//            set
//            {
//                iRIField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Property
//        {
//            get
//            {
//                return base_PropertyField;
//            }
//            set
//            {
//                base_PropertyField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.magicdraw.com/schemas/Concept_Modeling_Profile.xmi")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.magicdraw.com/schemas/Concept_Modeling_Profile.xmi", IsNullable = false)]
//    public partial class Restriction
//    {

//        private string idField;

//        private string base_PropertyField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Property
//        {
//            get
//            {
//                return base_PropertyField;
//            }
//            set
//            {
//                base_PropertyField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.magicdraw.com/schemas/Concept_Modeling_Profile.xmi")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.magicdraw.com/schemas/Concept_Modeling_Profile.xmi", IsNullable = false)]
//    public partial class Transitive
//    {

//        private string idField;

//        private string base_PropertyField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Property
//        {
//            get
//            {
//                return base_PropertyField;
//            }
//            set
//            {
//                base_PropertyField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.magicdraw.com/schemas/Dependency_Matrix_Profile.xmi")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.magicdraw.com/schemas/Dependency_Matrix_Profile.xmi", IsNullable = false)]
//    public partial class DependencyMatrix
//    {

//        private string rowCollapsedNodesField;

//        private string dependencyCriteriaField;

//        private string idField;

//        private string base_DiagramField;

//        private string columnTextDirectionField;

//        private string columnOwnerDisplayModeField;

//        private bool showInnerDependenciesField;

//        private string showElementsField;

//        private ushort columnHeaderHeightField;

//        private ushort rowHeaderWidthField;

//        private string rowOwnerDisplayModeField;

//        private string directionField;

//        private bool suppressCriteriaAreaField;

//        private bool hideTypesField;

//        private bool hideScopeField;

//        private bool hideDependencyCriteriaField;

//        private string rowSortingModeField;

//        private string columnSortingModeField;

//        private bool readOnlyField;

//        private bool takeWholeModelAsScopeField;

//        private string legendLocationField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "")]
//        public string rowCollapsedNodes
//        {
//            get
//            {
//                return rowCollapsedNodesField;
//            }
//            set
//            {
//                rowCollapsedNodesField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "")]
//        public string dependencyCriteria
//        {
//            get
//            {
//                return dependencyCriteriaField;
//            }
//            set
//            {
//                dependencyCriteriaField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Diagram
//        {
//            get
//            {
//                return base_DiagramField;
//            }
//            set
//            {
//                base_DiagramField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string columnTextDirection
//        {
//            get
//            {
//                return columnTextDirectionField;
//            }
//            set
//            {
//                columnTextDirectionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string columnOwnerDisplayMode
//        {
//            get
//            {
//                return columnOwnerDisplayModeField;
//            }
//            set
//            {
//                columnOwnerDisplayModeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool showInnerDependencies
//        {
//            get
//            {
//                return showInnerDependenciesField;
//            }
//            set
//            {
//                showInnerDependenciesField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string showElements
//        {
//            get
//            {
//                return showElementsField;
//            }
//            set
//            {
//                showElementsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public ushort columnHeaderHeight
//        {
//            get
//            {
//                return columnHeaderHeightField;
//            }
//            set
//            {
//                columnHeaderHeightField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public ushort rowHeaderWidth
//        {
//            get
//            {
//                return rowHeaderWidthField;
//            }
//            set
//            {
//                rowHeaderWidthField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string rowOwnerDisplayMode
//        {
//            get
//            {
//                return rowOwnerDisplayModeField;
//            }
//            set
//            {
//                rowOwnerDisplayModeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string direction
//        {
//            get
//            {
//                return directionField;
//            }
//            set
//            {
//                directionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool suppressCriteriaArea
//        {
//            get
//            {
//                return suppressCriteriaAreaField;
//            }
//            set
//            {
//                suppressCriteriaAreaField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool hideTypes
//        {
//            get
//            {
//                return hideTypesField;
//            }
//            set
//            {
//                hideTypesField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool hideScope
//        {
//            get
//            {
//                return hideScopeField;
//            }
//            set
//            {
//                hideScopeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool hideDependencyCriteria
//        {
//            get
//            {
//                return hideDependencyCriteriaField;
//            }
//            set
//            {
//                hideDependencyCriteriaField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string rowSortingMode
//        {
//            get
//            {
//                return rowSortingModeField;
//            }
//            set
//            {
//                rowSortingModeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string columnSortingMode
//        {
//            get
//            {
//                return columnSortingModeField;
//            }
//            set
//            {
//                columnSortingModeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool readOnly
//        {
//            get
//            {
//                return readOnlyField;
//            }
//            set
//            {
//                readOnlyField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool takeWholeModelAsScope
//        {
//            get
//            {
//                return takeWholeModelAsScopeField;
//            }
//            set
//            {
//                takeWholeModelAsScopeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string legendLocation
//        {
//            get
//            {
//                return legendLocationField;
//            }
//            set
//            {
//                legendLocationField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.magicdraw.com/schemas/Dependency_Matrix_Profile.xmi")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.magicdraw.com/schemas/Dependency_Matrix_Profile.xmi", IsNullable = false)]
//    public partial class MatrixFilter
//    {

//        private rowElementType rowElementTypeField;

//        private columnElementType columnElementTypeField;

//        private rowScope[] rowScopeField;

//        private string idField;

//        private string base_DiagramField;

//        private bool rowTypesIncludeSubtypesField;

//        private bool columnTypesIncludeSubtypesField;

//        private bool columnScopeDefinedField;

//        private bool rowScopeDefinedField;

//        private string columnScopeField;

//        private string rowQueryField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "")]
//        public rowElementType rowElementType
//        {
//            get
//            {
//                return rowElementTypeField;
//            }
//            set
//            {
//                rowElementTypeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "")]
//        public columnElementType columnElementType
//        {
//            get
//            {
//                return columnElementTypeField;
//            }
//            set
//            {
//                columnElementTypeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("rowScope", Namespace = "")]
//        public rowScope[] rowScope
//        {
//            get
//            {
//                return rowScopeField;
//            }
//            set
//            {
//                rowScopeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Diagram
//        {
//            get
//            {
//                return base_DiagramField;
//            }
//            set
//            {
//                base_DiagramField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool rowTypesIncludeSubtypes
//        {
//            get
//            {
//                return rowTypesIncludeSubtypesField;
//            }
//            set
//            {
//                rowTypesIncludeSubtypesField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool columnTypesIncludeSubtypes
//        {
//            get
//            {
//                return columnTypesIncludeSubtypesField;
//            }
//            set
//            {
//                columnTypesIncludeSubtypesField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool columnScopeDefined
//        {
//            get
//            {
//                return columnScopeDefinedField;
//            }
//            set
//            {
//                columnScopeDefinedField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool rowScopeDefined
//        {
//            get
//            {
//                return rowScopeDefinedField;
//            }
//            set
//            {
//                rowScopeDefinedField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string columnScope
//        {
//            get
//            {
//                return columnScopeField;
//            }
//            set
//            {
//                columnScopeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string rowQuery
//        {
//            get
//            {
//                return rowQueryField;
//            }
//            set
//            {
//                rowQueryField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
//    public partial class rowElementType
//    {

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
//    public partial class columnElementType
//    {

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
//    public partial class rowScope
//    {

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.magicdraw.com/schemas/Profile.xmi")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.magicdraw.com/schemas/Profile.xmi", IsNullable = false)]
//    public partial class deprecated
//    {

//        private string idField;

//        private string base_ElementField;

//        private decimal versionField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Element
//        {
//            get
//            {
//                return base_ElementField;
//            }
//            set
//            {
//                base_ElementField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public decimal version
//        {
//            get
//            {
//                return versionField;
//            }
//            set
//            {
//                versionField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.magicdraw.com/schemas/Profile.xmi")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.magicdraw.com/schemas/Profile.xmi", IsNullable = false)]
//    public partial class extensible
//    {

//        private string idField;

//        private string base_EnumerationField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Enumeration
//        {
//            get
//            {
//                return base_EnumerationField;
//            }
//            set
//            {
//                base_EnumerationField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.magicdraw.com/schemas/Profile.xmi")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.magicdraw.com/schemas/Profile.xmi", IsNullable = false)]
//    public partial class informative
//    {

//        private string idField;

//        private string base_ElementField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Element
//        {
//            get
//            {
//                return base_ElementField;
//            }
//            set
//            {
//                base_ElementField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.magicdraw.com/schemas/Profile.xmi")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.magicdraw.com/schemas/Profile.xmi", IsNullable = false)]
//    public partial class normative
//    {

//        private string idField;

//        private string base_ElementField;

//        private string versionField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Element
//        {
//            get
//            {
//                return base_ElementField;
//            }
//            set
//            {
//                base_ElementField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string version
//        {
//            get
//            {
//                return versionField;
//            }
//            set
//            {
//                versionField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.magicdraw.com/schemas/Profile.xmi")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.magicdraw.com/schemas/Profile.xmi", IsNullable = false)]
//    public partial class observes
//    {

//        private string idField;

//        private string base_AssociationField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Association
//        {
//            get
//            {
//                return base_AssociationField;
//            }
//            set
//            {
//                base_AssociationField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.magicdraw.com/schemas/Profile.xmi")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.magicdraw.com/schemas/Profile.xmi", IsNullable = false)]
//    public partial class organizer
//    {

//        private string idField;

//        private string base_ElementField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Element
//        {
//            get
//            {
//                return base_ElementField;
//            }
//            set
//            {
//                base_ElementField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.magicdraw.com/schemas/Profile.xmi")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.magicdraw.com/schemas/Profile.xmi", IsNullable = false)]
//    public partial class valueType
//    {

//        private string idField;

//        private string base_ClassField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Class
//        {
//            get
//            {
//                return base_ClassField;
//            }
//            set
//            {
//                base_ClassField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.magicdraw.com/schemas/SimulationProfile.xmi")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.magicdraw.com/schemas/SimulationProfile.xmi", IsNullable = false)]
//    public partial class SimulationConfig
//    {

//        private string idField;

//        private string base_ClassField;

//        private bool silentField;

//        private bool autoStartField;

//        private bool autostartActiveObjectsField;

//        private bool fireValueChangeEventField;

//        private bool constraintFailureAsBreakpointField;

//        private bool rememberFailureStatusField;

//        private bool treatAllClassifiersAsActiveField;

//        private bool initializeReferencesField;

//        private string timeVariableNameField;

//        private bool runForksInParallelField;

//        private bool cloneReferencesField;

//        private bool startWebServerField;

//        private bool solveAfterInitializationField;

//        private bool addControlPanelField;

//        private byte animationSpeedField;

//        private byte numberOfRunsField;

//        private bool recordTimestampField;

//        private string executionTargetField;

//        private string resultLocationField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Class
//        {
//            get
//            {
//                return base_ClassField;
//            }
//            set
//            {
//                base_ClassField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool silent
//        {
//            get
//            {
//                return silentField;
//            }
//            set
//            {
//                silentField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool autoStart
//        {
//            get
//            {
//                return autoStartField;
//            }
//            set
//            {
//                autoStartField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool autostartActiveObjects
//        {
//            get
//            {
//                return autostartActiveObjectsField;
//            }
//            set
//            {
//                autostartActiveObjectsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool fireValueChangeEvent
//        {
//            get
//            {
//                return fireValueChangeEventField;
//            }
//            set
//            {
//                fireValueChangeEventField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool constraintFailureAsBreakpoint
//        {
//            get
//            {
//                return constraintFailureAsBreakpointField;
//            }
//            set
//            {
//                constraintFailureAsBreakpointField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool rememberFailureStatus
//        {
//            get
//            {
//                return rememberFailureStatusField;
//            }
//            set
//            {
//                rememberFailureStatusField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool treatAllClassifiersAsActive
//        {
//            get
//            {
//                return treatAllClassifiersAsActiveField;
//            }
//            set
//            {
//                treatAllClassifiersAsActiveField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool initializeReferences
//        {
//            get
//            {
//                return initializeReferencesField;
//            }
//            set
//            {
//                initializeReferencesField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string timeVariableName
//        {
//            get
//            {
//                return timeVariableNameField;
//            }
//            set
//            {
//                timeVariableNameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool runForksInParallel
//        {
//            get
//            {
//                return runForksInParallelField;
//            }
//            set
//            {
//                runForksInParallelField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool cloneReferences
//        {
//            get
//            {
//                return cloneReferencesField;
//            }
//            set
//            {
//                cloneReferencesField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool startWebServer
//        {
//            get
//            {
//                return startWebServerField;
//            }
//            set
//            {
//                startWebServerField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool solveAfterInitialization
//        {
//            get
//            {
//                return solveAfterInitializationField;
//            }
//            set
//            {
//                solveAfterInitializationField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool addControlPanel
//        {
//            get
//            {
//                return addControlPanelField;
//            }
//            set
//            {
//                addControlPanelField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public byte animationSpeed
//        {
//            get
//            {
//                return animationSpeedField;
//            }
//            set
//            {
//                animationSpeedField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public byte numberOfRuns
//        {
//            get
//            {
//                return numberOfRunsField;
//            }
//            set
//            {
//                numberOfRunsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool recordTimestamp
//        {
//            get
//            {
//                return recordTimestampField;
//            }
//            set
//            {
//                recordTimestampField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string executionTarget
//        {
//            get
//            {
//                return executionTargetField;
//            }
//            set
//            {
//                executionTargetField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string resultLocation
//        {
//            get
//            {
//                return resultLocationField;
//            }
//            set
//            {
//                resultLocationField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.magicdraw.com/schemas/Validation_Profile.xmi")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.magicdraw.com/schemas/Validation_Profile.xmi", IsNullable = false)]
//    public partial class validationRule
//    {

//        private string idField;

//        private string base_ConstraintField;

//        private string severityField;

//        private string errorMessageField;

//        private string abbreviationField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Constraint
//        {
//            get
//            {
//                return base_ConstraintField;
//            }
//            set
//            {
//                base_ConstraintField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string severity
//        {
//            get
//            {
//                return severityField;
//            }
//            set
//            {
//                severityField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string errorMessage
//        {
//            get
//            {
//                return errorMessageField;
//            }
//            set
//            {
//                errorMessageField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string abbreviation
//        {
//            get
//            {
//                return abbreviationField;
//            }
//            set
//            {
//                abbreviationField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.magicdraw.com/schemas/Validation_Profile.xmi")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.magicdraw.com/schemas/Validation_Profile.xmi", IsNullable = false)]
//    public partial class validationSuite
//    {

//        private string idField;

//        private string base_PackageField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Package
//        {
//            get
//            {
//                return base_PackageField;
//            }
//            set
//            {
//                base_PackageField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.magicdraw.com/spec/Customization/180/SysML")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.magicdraw.com/spec/Customization/180/SysML", IsNullable = false)]
//    public partial class ConstraintParameter
//    {

//        private string idField;

//        private string base_PortField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Port
//        {
//            get
//            {
//                return base_PortField;
//            }
//            set
//            {
//                base_PortField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.magicdraw.com/spec/Customization/180/SysML")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.magicdraw.com/spec/Customization/180/SysML", IsNullable = false)]
//    public partial class ConstraintProperty
//    {

//        private string idField;

//        private string base_PropertyField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Property
//        {
//            get
//            {
//                return base_PropertyField;
//            }
//            set
//            {
//                base_PropertyField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.magicdraw.com/spec/Customization/180/SysML")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.magicdraw.com/spec/Customization/180/SysML", IsNullable = false)]
//    public partial class ExternalModel
//    {

//        private string idField;

//        private string base_ElementField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Element
//        {
//            get
//            {
//                return base_ElementField;
//            }
//            set
//            {
//                base_ElementField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.magicdraw.com/spec/Customization/180/SysML")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.magicdraw.com/spec/Customization/180/SysML", IsNullable = false)]
//    public partial class PartProperty
//    {

//        private string idField;

//        private string base_PropertyField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Property
//        {
//            get
//            {
//                return base_PropertyField;
//            }
//            set
//            {
//                base_PropertyField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.magicdraw.com/spec/Customization/180/SysML")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.magicdraw.com/spec/Customization/180/SysML", IsNullable = false)]
//    public partial class ReferenceProperty
//    {

//        private string idField;

//        private string base_PropertyField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Property
//        {
//            get
//            {
//                return base_PropertyField;
//            }
//            set
//            {
//                base_PropertyField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.magicdraw.com/spec/Customization/180/SysML")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.magicdraw.com/spec/Customization/180/SysML", IsNullable = false)]
//    public partial class ValueProperty
//    {

//        private string idField;

//        private string base_PropertyField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Property
//        {
//            get
//            {
//                return base_PropertyField;
//            }
//            set
//            {
//                base_PropertyField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/SysML/20150709/SysML")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.omg.org/spec/SysML/20150709/SysML", IsNullable = false)]
//    public partial class BindingConnector
//    {

//        private string idField;

//        private string base_ConnectorField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Connector
//        {
//            get
//            {
//                return base_ConnectorField;
//            }
//            set
//            {
//                base_ConnectorField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/SysML/20150709/SysML")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.omg.org/spec/SysML/20150709/SysML", IsNullable = false)]
//    public partial class Block
//    {

//        private string idField;

//        private string base_ClassField;

//        private bool isEncapsulatedField;

//        private bool isEncapsulatedFieldSpecified;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Class
//        {
//            get
//            {
//                return base_ClassField;
//            }
//            set
//            {
//                base_ClassField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool isEncapsulated
//        {
//            get
//            {
//                return isEncapsulatedField;
//            }
//            set
//            {
//                isEncapsulatedField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool isEncapsulatedSpecified
//        {
//            get
//            {
//                return isEncapsulatedFieldSpecified;
//            }
//            set
//            {
//                isEncapsulatedFieldSpecified = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/SysML/20150709/SysML")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.omg.org/spec/SysML/20150709/SysML", IsNullable = false)]
//    public partial class ConstraintBlock
//    {

//        private string idField;

//        private string base_ClassField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Class
//        {
//            get
//            {
//                return base_ClassField;
//            }
//            set
//            {
//                base_ClassField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/SysML/20150709/SysML")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.omg.org/spec/SysML/20150709/SysML", IsNullable = false)]
//    public partial class ElementGroup
//    {

//        private string idField;

//        private string base_CommentField;

//        private string memberField;

//        private byte sizeField;

//        private string orderedMemberField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Comment
//        {
//            get
//            {
//                return base_CommentField;
//            }
//            set
//            {
//                base_CommentField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string member
//        {
//            get
//            {
//                return memberField;
//            }
//            set
//            {
//                memberField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public byte size
//        {
//            get
//            {
//                return sizeField;
//            }
//            set
//            {
//                sizeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string orderedMember
//        {
//            get
//            {
//                return orderedMemberField;
//            }
//            set
//            {
//                orderedMemberField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/SysML/20150709/SysML")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.omg.org/spec/SysML/20150709/SysML", IsNullable = false)]
//    public partial class NestedConnectorEnd
//    {

//        private string idField;

//        private string base_ConnectorEndField;

//        private string propertyPathField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_ConnectorEnd
//        {
//            get
//            {
//                return base_ConnectorEndField;
//            }
//            set
//            {
//                base_ConnectorEndField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string propertyPath
//        {
//            get
//            {
//                return propertyPathField;
//            }
//            set
//            {
//                propertyPathField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/SysML/20150709/SysML")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.omg.org/spec/SysML/20150709/SysML", IsNullable = false)]
//    public partial class ParticipantProperty
//    {

//        private string idField;

//        private string base_PropertyField;

//        private string endField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Property
//        {
//            get
//            {
//                return base_PropertyField;
//            }
//            set
//            {
//                base_PropertyField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string end
//        {
//            get
//            {
//                return endField;
//            }
//            set
//            {
//                endField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/SysML/20150709/SysML")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.omg.org/spec/SysML/20150709/SysML", IsNullable = false)]
//    public partial class ValueType
//    {

//        private string idField;

//        private string base_DataTypeField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_DataType
//        {
//            get
//            {
//                return base_DataTypeField;
//            }
//            set
//            {
//                base_DataTypeField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/UML/20131001/MagicDrawProfile")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.omg.org/spec/UML/20131001/MagicDrawProfile", IsNullable = false)]
//    public partial class CustomSort
//    {

//        private string idField;

//        private string base_ElementField;

//        private decimal sortPriorityField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Element
//        {
//            get
//            {
//                return base_ElementField;
//            }
//            set
//            {
//                base_ElementField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public decimal sortPriority
//        {
//            get
//            {
//                return sortPriorityField;
//            }
//            set
//            {
//                sortPriorityField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/UML/20131001/MagicDrawProfile")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.omg.org/spec/UML/20131001/MagicDrawProfile", IsNullable = false)]
//    public partial class DiagramInfo
//    {

//        private string idField;

//        private string base_DiagramField;

//        private string authorField;

//        private string creation_dateField;

//        private string modification_dateField;

//        private string last_modified_byField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Diagram
//        {
//            get
//            {
//                return base_DiagramField;
//            }
//            set
//            {
//                base_DiagramField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string Author
//        {
//            get
//            {
//                return authorField;
//            }
//            set
//            {
//                authorField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string Creation_date
//        {
//            get
//            {
//                return creation_dateField;
//            }
//            set
//            {
//                creation_dateField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string Modification_date
//        {
//            get
//            {
//                return modification_dateField;
//            }
//            set
//            {
//                modification_dateField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string Last_modified_by
//        {
//            get
//            {
//                return last_modified_byField;
//            }
//            set
//            {
//                last_modified_byField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/UML/20131001/MagicDrawProfile")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.omg.org/spec/UML/20131001/MagicDrawProfile", IsNullable = false)]
//    public partial class DiagramTable
//    {

//        private string customColumnsField;

//        private string[] columnIdsField;

//        private sbyte[] columnWidthField;

//        private string[] rowElementsField;

//        private string sortField;

//        private string idField;

//        private string base_DiagramField;

//        private bool showDetailedColumnNameField;

//        private bool typesIncludeSubtypesField;

//        private string displayModeField;

//        private bool showElementNumberField;

//        private bool showColumnIconsField;

//        private bool showScopeAsRootField;

//        private bool showScopeField;

//        private bool showFilterField;

//        private bool showElementTypeField;

//        private string additionalElementsField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "")]
//        public string customColumns
//        {
//            get
//            {
//                return customColumnsField;
//            }
//            set
//            {
//                customColumnsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("columnIds", Namespace = "")]
//        public string[] columnIds
//        {
//            get
//            {
//                return columnIdsField;
//            }
//            set
//            {
//                columnIdsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("columnWidth", Namespace = "")]
//        public sbyte[] columnWidth
//        {
//            get
//            {
//                return columnWidthField;
//            }
//            set
//            {
//                columnWidthField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("rowElements", Namespace = "")]
//        public string[] rowElements
//        {
//            get
//            {
//                return rowElementsField;
//            }
//            set
//            {
//                rowElementsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "")]
//        public string sort
//        {
//            get
//            {
//                return sortField;
//            }
//            set
//            {
//                sortField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Diagram
//        {
//            get
//            {
//                return base_DiagramField;
//            }
//            set
//            {
//                base_DiagramField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool showDetailedColumnName
//        {
//            get
//            {
//                return showDetailedColumnNameField;
//            }
//            set
//            {
//                showDetailedColumnNameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool typesIncludeSubtypes
//        {
//            get
//            {
//                return typesIncludeSubtypesField;
//            }
//            set
//            {
//                typesIncludeSubtypesField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string displayMode
//        {
//            get
//            {
//                return displayModeField;
//            }
//            set
//            {
//                displayModeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool showElementNumber
//        {
//            get
//            {
//                return showElementNumberField;
//            }
//            set
//            {
//                showElementNumberField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool showColumnIcons
//        {
//            get
//            {
//                return showColumnIconsField;
//            }
//            set
//            {
//                showColumnIconsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool showScopeAsRoot
//        {
//            get
//            {
//                return showScopeAsRootField;
//            }
//            set
//            {
//                showScopeAsRootField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool showScope
//        {
//            get
//            {
//                return showScopeField;
//            }
//            set
//            {
//                showScopeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool showFilter
//        {
//            get
//            {
//                return showFilterField;
//            }
//            set
//            {
//                showFilterField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool showElementType
//        {
//            get
//            {
//                return showElementTypeField;
//            }
//            set
//            {
//                showElementTypeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string additionalElements
//        {
//            get
//            {
//                return additionalElementsField;
//            }
//            set
//            {
//                additionalElementsField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/UML/20131001/MagicDrawProfile")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.omg.org/spec/UML/20131001/MagicDrawProfile", IsNullable = false)]
//    public partial class InstanceTable
//    {

//        private string[] hideColumnsField;

//        private string[] columnIdsField;

//        private string[] rowElementsField;

//        private string expandedRowsField;

//        private string idField;

//        private string base_DiagramField;

//        private bool showColumnIconsField;

//        private string classifiersField;

//        private bool showFilterField;

//        private string scopeField;

//        private bool showUnitsOnValuesField;

//        private bool typesIncludeSubtypesField;

//        private bool showDetailedColumnNameField;

//        private bool showElementTypeField;

//        private string displayModeField;

//        private string rowsOrderField;

//        private bool showScopeField;

//        private bool showScopeAsRootField;

//        private bool showElementNumberField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("hideColumns", Namespace = "")]
//        public string[] hideColumns
//        {
//            get
//            {
//                return hideColumnsField;
//            }
//            set
//            {
//                hideColumnsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("columnIds", Namespace = "")]
//        public string[] columnIds
//        {
//            get
//            {
//                return columnIdsField;
//            }
//            set
//            {
//                columnIdsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("rowElements", Namespace = "")]
//        public string[] rowElements
//        {
//            get
//            {
//                return rowElementsField;
//            }
//            set
//            {
//                rowElementsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "")]
//        public string expandedRows
//        {
//            get
//            {
//                return expandedRowsField;
//            }
//            set
//            {
//                expandedRowsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Diagram
//        {
//            get
//            {
//                return base_DiagramField;
//            }
//            set
//            {
//                base_DiagramField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool showColumnIcons
//        {
//            get
//            {
//                return showColumnIconsField;
//            }
//            set
//            {
//                showColumnIconsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string classifiers
//        {
//            get
//            {
//                return classifiersField;
//            }
//            set
//            {
//                classifiersField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool showFilter
//        {
//            get
//            {
//                return showFilterField;
//            }
//            set
//            {
//                showFilterField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string scope
//        {
//            get
//            {
//                return scopeField;
//            }
//            set
//            {
//                scopeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool showUnitsOnValues
//        {
//            get
//            {
//                return showUnitsOnValuesField;
//            }
//            set
//            {
//                showUnitsOnValuesField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool typesIncludeSubtypes
//        {
//            get
//            {
//                return typesIncludeSubtypesField;
//            }
//            set
//            {
//                typesIncludeSubtypesField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool showDetailedColumnName
//        {
//            get
//            {
//                return showDetailedColumnNameField;
//            }
//            set
//            {
//                showDetailedColumnNameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool showElementType
//        {
//            get
//            {
//                return showElementTypeField;
//            }
//            set
//            {
//                showElementTypeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string displayMode
//        {
//            get
//            {
//                return displayModeField;
//            }
//            set
//            {
//                displayModeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string rowsOrder
//        {
//            get
//            {
//                return rowsOrderField;
//            }
//            set
//            {
//                rowsOrderField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool showScope
//        {
//            get
//            {
//                return showScopeField;
//            }
//            set
//            {
//                showScopeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool showScopeAsRoot
//        {
//            get
//            {
//                return showScopeAsRootField;
//            }
//            set
//            {
//                showScopeAsRootField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool showElementNumber
//        {
//            get
//            {
//                return showElementNumberField;
//            }
//            set
//            {
//                showElementNumberField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/UML/20131001/MagicDrawProfile")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.omg.org/spec/UML/20131001/MagicDrawProfile", IsNullable = false)]
//    public partial class additionalElementImport
//    {

//        private string idField;

//        private string base_ElementImportField;

//        private bool treatAsAuxiliaryInOwningProjectField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_ElementImport
//        {
//            get
//            {
//                return base_ElementImportField;
//            }
//            set
//            {
//                base_ElementImportField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool treatAsAuxiliaryInOwningProject
//        {
//            get
//            {
//                return treatAsAuxiliaryInOwningProjectField;
//            }
//            set
//            {
//                treatAsAuxiliaryInOwningProjectField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/UML/20131001/MagicDrawProfile")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.omg.org/spec/UML/20131001/MagicDrawProfile", IsNullable = false)]
//    public partial class additionalPackageImport
//    {

//        private string idField;

//        private string base_PackageImportField;

//        private bool treatAsAuxiliaryInOwningProjectField;

//        private bool treatAsAuxiliaryInOwningProjectFieldSpecified;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_PackageImport
//        {
//            get
//            {
//                return base_PackageImportField;
//            }
//            set
//            {
//                base_PackageImportField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool treatAsAuxiliaryInOwningProject
//        {
//            get
//            {
//                return treatAsAuxiliaryInOwningProjectField;
//            }
//            set
//            {
//                treatAsAuxiliaryInOwningProjectField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool treatAsAuxiliaryInOwningProjectSpecified
//        {
//            get
//            {
//                return treatAsAuxiliaryInOwningProjectFieldSpecified;
//            }
//            set
//            {
//                treatAsAuxiliaryInOwningProjectFieldSpecified = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/UML/20131001/MagicDrawProfile")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.omg.org/spec/UML/20131001/MagicDrawProfile", IsNullable = false)]
//    public partial class auxiliaryResource
//    {

//        private string idField;

//        private string base_ElementField;

//        private bool treatAsAuxiliaryInOwningProjectField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Element
//        {
//            get
//            {
//                return base_ElementField;
//            }
//            set
//            {
//                base_ElementField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool treatAsAuxiliaryInOwningProject
//        {
//            get
//            {
//                return treatAsAuxiliaryInOwningProjectField;
//            }
//            set
//            {
//                treatAsAuxiliaryInOwningProjectField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/UML/20131001/MagicDrawProfile")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.omg.org/spec/UML/20131001/MagicDrawProfile", IsNullable = false)]
//    public partial class complete
//    {

//        private string idField;

//        private string base_DiagramField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Diagram
//        {
//            get
//            {
//                return base_DiagramField;
//            }
//            set
//            {
//                base_DiagramField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/UML/20131001/MagicDrawProfile")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.omg.org/spec/UML/20131001/MagicDrawProfile", IsNullable = false)]
//    public partial class control
//    {

//        private string idField;

//        private string base_ClassField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string base_Class
//        {
//            get
//            {
//                return base_ClassField;
//            }
//            set
//            {
//                base_ClassField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/UML/20131001")]
//    [System.Xml.Serialization.XmlRoot("Model", Namespace = "http://www.omg.org/spec/UML/20131001", IsNullable = false)]
//    public partial class Model1
//    {

//        private ownedComment ownedCommentField;

//        private packageImport[] packageImportField;

//        private packagedElement[] packagedElementField;

//        private profileApplication profileApplicationField;

//        private string typeField;

//        private string idField;

//        private string nameField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "")]
//        public ownedComment ownedComment
//        {
//            get
//            {
//                return ownedCommentField;
//            }
//            set
//            {
//                ownedCommentField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("packageImport", Namespace = "")]
//        public packageImport[] packageImport
//        {
//            get
//            {
//                return packageImportField;
//            }
//            set
//            {
//                packageImportField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("packagedElement", Namespace = "")]
//        public packagedElement[] packagedElement
//        {
//            get
//            {
//                return packagedElementField;
//            }
//            set
//            {
//                packagedElementField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "")]
//        public profileApplication profileApplication
//        {
//            get
//            {
//                return profileApplicationField;
//            }
//            set
//            {
//                profileApplicationField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
//    public partial class ownedComment
//    {

//        private ownedCommentAnnotatedElement annotatedElementField;

//        private string typeField;

//        private string idField;

//        private string bodyField;

//        /// <remarks/>
//        public ownedCommentAnnotatedElement annotatedElement
//        {
//            get
//            {
//                return annotatedElementField;
//            }
//            set
//            {
//                annotatedElementField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string body
//        {
//            get
//            {
//                return bodyField;
//            }
//            set
//            {
//                bodyField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class ownedCommentAnnotatedElement
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
//    public partial class packageImport
//    {

//        private string typeField;

//        private string idField;

//        private string importedPackageField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string importedPackage
//        {
//            get
//            {
//                return importedPackageField;
//            }
//            set
//            {
//                importedPackageField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
//    public partial class packagedElement
//    {

//        private object[] itemsField;

//        private string typeField;

//        private string idField;

//        private string nameField;

//        private string uRIField;

//        private string id1Field;

//        private string idField1;

//        private string memberEndField;

//        private string _extensionEndOfTypeField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("_extensionEndOfType", typeof(packagedElement_extensionEndOfType))]
//        [System.Xml.Serialization.XmlElement("appliedStereotypeInstance", typeof(packagedElementAppliedStereotypeInstance))]
//        [System.Xml.Serialization.XmlElement("elementImport", typeof(packagedElementElementImport))]
//        [System.Xml.Serialization.XmlElement("generalization", typeof(packagedElementGeneralization))]
//        [System.Xml.Serialization.XmlElement("Extension", typeof(Extension), Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        [System.Xml.Serialization.XmlElement("memberEnd", typeof(packagedElementMemberEnd))]
//        [System.Xml.Serialization.XmlElement("metamodelReference", typeof(packagedElementMetamodelReference))]
//        [System.Xml.Serialization.XmlElement("ownedAttribute", typeof(packagedElementOwnedAttribute))]
//        [System.Xml.Serialization.XmlElement("ownedComment", typeof(packagedElementOwnedComment))]
//        [System.Xml.Serialization.XmlElement("ownedEnd", typeof(packagedElementOwnedEnd))]
//        [System.Xml.Serialization.XmlElement("packageImport", typeof(packagedElementPackageImport))]
//        [System.Xml.Serialization.XmlElement("packagedElement", typeof(packagedElementPackagedElement))]
//        public object[] Items
//        {
//            get
//            {
//                return itemsField;
//            }
//            set
//            {
//                itemsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string URI
//        {
//            get
//            {
//                return uRIField;
//            }
//            set
//            {
//                uRIField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("id", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id1
//        {
//            get
//            {
//                return id1Field;
//            }
//            set
//            {
//                id1Field = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string memberEnd
//        {
//            get
//            {
//                return memberEndField;
//            }
//            set
//            {
//                memberEndField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string _extensionEndOfType
//        {
//            get
//            {
//                return _extensionEndOfTypeField;
//            }
//            set
//            {
//                _extensionEndOfTypeField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElement_extensionEndOfType
//    {

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementAppliedStereotypeInstance
//    {

//        private packagedElementAppliedStereotypeInstanceSlot[] slotField;

//        private packagedElementAppliedStereotypeInstanceClassifier classifierField;

//        private string idField;

//        private string idField1;

//        private string classifier1Field;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("slot")]
//        public packagedElementAppliedStereotypeInstanceSlot[] slot
//        {
//            get
//            {
//                return slotField;
//            }
//            set
//            {
//                slotField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementAppliedStereotypeInstanceClassifier classifier
//        {
//            get
//            {
//                return classifierField;
//            }
//            set
//            {
//                classifierField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("classifier")]
//        public string classifier1
//        {
//            get
//            {
//                return classifier1Field;
//            }
//            set
//            {
//                classifier1Field = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementAppliedStereotypeInstanceSlot
//    {

//        private packagedElementAppliedStereotypeInstanceSlotDefiningFeature definingFeatureField;

//        private string idField;

//        private string idField1;

//        /// <remarks/>
//        public packagedElementAppliedStereotypeInstanceSlotDefiningFeature definingFeature
//        {
//            get
//            {
//                return definingFeatureField;
//            }
//            set
//            {
//                definingFeatureField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementAppliedStereotypeInstanceSlotDefiningFeature
//    {

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementAppliedStereotypeInstanceClassifier
//    {

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementElementImport
//    {

//        private string typeField;

//        private string idField;

//        private string importedElementField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string importedElement
//        {
//            get
//            {
//                return importedElementField;
//            }
//            set
//            {
//                importedElementField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementGeneralization
//    {

//        private packagedElementGeneralizationAppliedStereotypeInstance appliedStereotypeInstanceField;

//        private packagedElementGeneralizationGeneral generalField;

//        private string idField;

//        private string idField1;

//        private string general1Field;

//        /// <remarks/>
//        public packagedElementGeneralizationAppliedStereotypeInstance appliedStereotypeInstance
//        {
//            get
//            {
//                return appliedStereotypeInstanceField;
//            }
//            set
//            {
//                appliedStereotypeInstanceField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementGeneralizationGeneral general
//        {
//            get
//            {
//                return generalField;
//            }
//            set
//            {
//                generalField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("general")]
//        public string general1
//        {
//            get
//            {
//                return general1Field;
//            }
//            set
//            {
//                general1Field = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementGeneralizationAppliedStereotypeInstance
//    {

//        private packagedElementGeneralizationAppliedStereotypeInstanceSlot[] slotField;

//        private packagedElementGeneralizationAppliedStereotypeInstanceClassifier classifierField;

//        private string idField;

//        private string idField1;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("slot")]
//        public packagedElementGeneralizationAppliedStereotypeInstanceSlot[] slot
//        {
//            get
//            {
//                return slotField;
//            }
//            set
//            {
//                slotField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementGeneralizationAppliedStereotypeInstanceClassifier classifier
//        {
//            get
//            {
//                return classifierField;
//            }
//            set
//            {
//                classifierField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementGeneralizationAppliedStereotypeInstanceSlot
//    {

//        private packagedElementGeneralizationAppliedStereotypeInstanceSlotDefiningFeature definingFeatureField;

//        private string idField;

//        private string idField1;

//        /// <remarks/>
//        public packagedElementGeneralizationAppliedStereotypeInstanceSlotDefiningFeature definingFeature
//        {
//            get
//            {
//                return definingFeatureField;
//            }
//            set
//            {
//                definingFeatureField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementGeneralizationAppliedStereotypeInstanceSlotDefiningFeature
//    {

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementGeneralizationAppliedStereotypeInstanceClassifier
//    {

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementGeneralizationGeneral
//    {

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.omg.org/spec/XMI/20131001", IsNullable = false)]
//    public partial class Extension
//    {

//        private diagramRepresentation diagramRepresentationField;

//        private modelExtension modelExtensionField;

//        private referenceExtension referenceExtensionField;

//        private string extenderField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "")]
//        public diagramRepresentation diagramRepresentation
//        {
//            get
//            {
//                return diagramRepresentationField;
//            }
//            set
//            {
//                diagramRepresentationField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "")]
//        public modelExtension modelExtension
//        {
//            get
//            {
//                return modelExtensionField;
//            }
//            set
//            {
//                modelExtensionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "")]
//        public referenceExtension referenceExtension
//        {
//            get
//            {
//                return referenceExtensionField;
//            }
//            set
//            {
//                referenceExtensionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string extender
//        {
//            get
//            {
//                return extenderField;
//            }
//            set
//            {
//                extenderField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
//    public partial class diagramRepresentation
//    {

//        private DiagramRepresentationObject diagramRepresentationObjectField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "http://www.nomagic.com/ns/magicdraw/core/diagram/1.0")]
//        public DiagramRepresentationObject DiagramRepresentationObject
//        {
//            get
//            {
//                return diagramRepresentationObjectField;
//            }
//            set
//            {
//                diagramRepresentationObjectField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.nomagic.com/ns/magicdraw/core/diagram/1.0")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.nomagic.com/ns/magicdraw/core/diagram/1.0", IsNullable = false)]
//    public partial class DiagramRepresentationObject
//    {

//        private diagramContents diagramContentsField;

//        private string idField;

//        private string diagramStyleIDField;

//        private bool initialFrameSizeSetField;

//        private bool initialFrameSizeSetFieldSpecified;

//        private string requiredFeatureField;

//        private string typeField;

//        private string umlTypeField;

//        private string idField1;

//        private decimal versionField;

//        private string diagramPropertiesField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "")]
//        public diagramContents diagramContents
//        {
//            get
//            {
//                return diagramContentsField;
//            }
//            set
//            {
//                diagramContentsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string diagramStyleID
//        {
//            get
//            {
//                return diagramStyleIDField;
//            }
//            set
//            {
//                diagramStyleIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool initialFrameSizeSet
//        {
//            get
//            {
//                return initialFrameSizeSetField;
//            }
//            set
//            {
//                initialFrameSizeSetField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool initialFrameSizeSetSpecified
//        {
//            get
//            {
//                return initialFrameSizeSetFieldSpecified;
//            }
//            set
//            {
//                initialFrameSizeSetFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string requiredFeature
//        {
//            get
//            {
//                return requiredFeatureField;
//            }
//            set
//            {
//                requiredFeatureField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string umlType
//        {
//            get
//            {
//                return umlTypeField;
//            }
//            set
//            {
//                umlTypeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public decimal version
//        {
//            get
//            {
//                return versionField;
//            }
//            set
//            {
//                versionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string diagramProperties
//        {
//            get
//            {
//                return diagramPropertiesField;
//            }
//            set
//            {
//                diagramPropertiesField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
//    public partial class diagramContents
//    {

//        private diagramContentsBinaryObject binaryObjectField;

//        private diagramContentsUsedObjects[] usedObjectsField;

//        private string[] usedElementsField;

//        private string contentHashField;

//        private string exporterNameField;

//        private string exporterVersionField;

//        private string idField;

//        /// <remarks/>
//        public diagramContentsBinaryObject binaryObject
//        {
//            get
//            {
//                return binaryObjectField;
//            }
//            set
//            {
//                binaryObjectField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("usedObjects")]
//        public diagramContentsUsedObjects[] usedObjects
//        {
//            get
//            {
//                return usedObjectsField;
//            }
//            set
//            {
//                usedObjectsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("usedElements")]
//        public string[] usedElements
//        {
//            get
//            {
//                return usedElementsField;
//            }
//            set
//            {
//                usedElementsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string contentHash
//        {
//            get
//            {
//                return contentHashField;
//            }
//            set
//            {
//                contentHashField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string exporterName
//        {
//            get
//            {
//                return exporterNameField;
//            }
//            set
//            {
//                exporterNameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string exporterVersion
//        {
//            get
//            {
//                return exporterVersionField;
//            }
//            set
//            {
//                exporterVersionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class diagramContentsBinaryObject
//    {

//        private string streamContentIDField;

//        private string idField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string streamContentID
//        {
//            get
//            {
//                return streamContentIDField;
//            }
//            set
//            {
//                streamContentIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class diagramContentsUsedObjects
//    {

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
//    public partial class modelExtension
//    {

//        private modelExtensionSpecification specificationField;

//        private modelExtensionEvent[] eventField;

//        private modelExtensionArgument argumentField;

//        private modelExtensionLowerValue lowerValueField;

//        private modelExtensionUpperValue upperValueField;

//        private modelExtensionOwnedDiagram[] ownedDiagramField;

//        /// <remarks/>
//        public modelExtensionSpecification specification
//        {
//            get
//            {
//                return specificationField;
//            }
//            set
//            {
//                specificationField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("event")]
//        public modelExtensionEvent[] @event
//        {
//            get
//            {
//                return eventField;
//            }
//            set
//            {
//                eventField = value;
//            }
//        }

//        /// <remarks/>
//        public modelExtensionArgument argument
//        {
//            get
//            {
//                return argumentField;
//            }
//            set
//            {
//                argumentField = value;
//            }
//        }

//        /// <remarks/>
//        public modelExtensionLowerValue lowerValue
//        {
//            get
//            {
//                return lowerValueField;
//            }
//            set
//            {
//                lowerValueField = value;
//            }
//        }

//        /// <remarks/>
//        public modelExtensionUpperValue upperValue
//        {
//            get
//            {
//                return upperValueField;
//            }
//            set
//            {
//                upperValueField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("ownedDiagram")]
//        public modelExtensionOwnedDiagram[] ownedDiagram
//        {
//            get
//            {
//                return ownedDiagramField;
//            }
//            set
//            {
//                ownedDiagramField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class modelExtensionSpecification
//    {

//        private string typeField;

//        private string idField;

//        private string elementField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string element
//        {
//            get
//            {
//                return elementField;
//            }
//            set
//            {
//                elementField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class modelExtensionEvent
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class modelExtensionArgument
//    {

//        private string typeField;

//        private string idField;

//        private string elementField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string element
//        {
//            get
//            {
//                return elementField;
//            }
//            set
//            {
//                elementField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class modelExtensionLowerValue
//    {

//        private string typeField;

//        private string idField;

//        private byte valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public byte value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class modelExtensionUpperValue
//    {

//        private string typeField;

//        private string idField;

//        private byte valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public byte value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class modelExtensionOwnedDiagram
//    {

//        private Extension extensionField;

//        private modelExtensionOwnedDiagramOwnedComment ownedCommentField;

//        private string typeField;

//        private string idField;

//        private string nameField;

//        private string visibilityField;

//        private string ownerOfDiagramField;

//        private string contextField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public Extension Extension
//        {
//            get
//            {
//                return extensionField;
//            }
//            set
//            {
//                extensionField = value;
//            }
//        }

//        /// <remarks/>
//        public modelExtensionOwnedDiagramOwnedComment ownedComment
//        {
//            get
//            {
//                return ownedCommentField;
//            }
//            set
//            {
//                ownedCommentField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ownerOfDiagram
//        {
//            get
//            {
//                return ownerOfDiagramField;
//            }
//            set
//            {
//                ownerOfDiagramField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string context
//        {
//            get
//            {
//                return contextField;
//            }
//            set
//            {
//                contextField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class modelExtensionOwnedDiagramOwnedComment
//    {

//        private modelExtensionOwnedDiagramOwnedCommentAnnotatedElement annotatedElementField;

//        private string typeField;

//        private string idField;

//        private string bodyField;

//        /// <remarks/>
//        public modelExtensionOwnedDiagramOwnedCommentAnnotatedElement annotatedElement
//        {
//            get
//            {
//                return annotatedElementField;
//            }
//            set
//            {
//                annotatedElementField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string body
//        {
//            get
//            {
//                return bodyField;
//            }
//            set
//            {
//                bodyField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class modelExtensionOwnedDiagramOwnedCommentAnnotatedElement
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
//    public partial class referenceExtension
//    {

//        private string referentPathField;

//        private string referentTypeField;

//        private string originalIDField;

//        private string referentClientField;

//        private string referentSupplierField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string referentPath
//        {
//            get
//            {
//                return referentPathField;
//            }
//            set
//            {
//                referentPathField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string referentType
//        {
//            get
//            {
//                return referentTypeField;
//            }
//            set
//            {
//                referentTypeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string originalID
//        {
//            get
//            {
//                return originalIDField;
//            }
//            set
//            {
//                originalIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string referentClient
//        {
//            get
//            {
//                return referentClientField;
//            }
//            set
//            {
//                referentClientField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string referentSupplier
//        {
//            get
//            {
//                return referentSupplierField;
//            }
//            set
//            {
//                referentSupplierField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementMemberEnd
//    {

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementMetamodelReference
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementOwnedAttribute
//    {

//        private packagedElementOwnedAttributeType typeField;

//        private packagedElementOwnedAttributeAssociation associationField;

//        private string idField;

//        private string idField1;

//        private string nameField;

//        private string visibilityField;

//        private string association1Field;

//        private string type1Field;

//        /// <remarks/>
//        public packagedElementOwnedAttributeType type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementOwnedAttributeAssociation association
//        {
//            get
//            {
//                return associationField;
//            }
//            set
//            {
//                associationField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("association")]
//        public string association1
//        {
//            get
//            {
//                return association1Field;
//            }
//            set
//            {
//                association1Field = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("type")]
//        public string type1
//        {
//            get
//            {
//                return type1Field;
//            }
//            set
//            {
//                type1Field = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementOwnedAttributeType
//    {

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementOwnedAttributeAssociation
//    {

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementOwnedComment
//    {

//        private packagedElementOwnedCommentOwnedComment ownedCommentField;

//        private packagedElementOwnedCommentAnnotatedElement annotatedElementField;

//        private string typeField;

//        private string idField;

//        private string bodyField;

//        /// <remarks/>
//        public packagedElementOwnedCommentOwnedComment ownedComment
//        {
//            get
//            {
//                return ownedCommentField;
//            }
//            set
//            {
//                ownedCommentField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementOwnedCommentAnnotatedElement annotatedElement
//        {
//            get
//            {
//                return annotatedElementField;
//            }
//            set
//            {
//                annotatedElementField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string body
//        {
//            get
//            {
//                return bodyField;
//            }
//            set
//            {
//                bodyField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementOwnedCommentOwnedComment
//    {

//        private packagedElementOwnedCommentOwnedCommentAnnotatedElement annotatedElementField;

//        private string typeField;

//        private string idField;

//        private string bodyField;

//        /// <remarks/>
//        public packagedElementOwnedCommentOwnedCommentAnnotatedElement annotatedElement
//        {
//            get
//            {
//                return annotatedElementField;
//            }
//            set
//            {
//                annotatedElementField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string body
//        {
//            get
//            {
//                return bodyField;
//            }
//            set
//            {
//                bodyField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementOwnedCommentOwnedCommentAnnotatedElement
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementOwnedCommentAnnotatedElement
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementOwnedEnd
//    {

//        private packagedElementOwnedEndType typeField;

//        private packagedElementOwnedEndAssociation associationField;

//        private string idField;

//        private string idField1;

//        private string nameField;

//        private string visibilityField;

//        private string type1Field;

//        private string aggregationField;

//        private string association1Field;

//        /// <remarks/>
//        public packagedElementOwnedEndType type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementOwnedEndAssociation association
//        {
//            get
//            {
//                return associationField;
//            }
//            set
//            {
//                associationField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("type")]
//        public string type1
//        {
//            get
//            {
//                return type1Field;
//            }
//            set
//            {
//                type1Field = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string aggregation
//        {
//            get
//            {
//                return aggregationField;
//            }
//            set
//            {
//                aggregationField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("association")]
//        public string association1
//        {
//            get
//            {
//                return association1Field;
//            }
//            set
//            {
//                association1Field = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementOwnedEndType
//    {

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementOwnedEndAssociation
//    {

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackageImport
//    {

//        private packagedElementPackageImportImportedPackage importedPackageField;

//        private string typeField;

//        private string idField;

//        /// <remarks/>
//        public packagedElementPackageImportImportedPackage importedPackage
//        {
//            get
//            {
//                return importedPackageField;
//            }
//            set
//            {
//                importedPackageField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackageImportImportedPackage
//    {

//        private Extension extensionField;

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public Extension Extension
//        {
//            get
//            {
//                return extensionField;
//            }
//            set
//            {
//                extensionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElement
//    {

//        private object[] itemsField;

//        private string typeField;

//        private string idField;

//        private string nameField;

//        private bool isAbstractField;

//        private bool isAbstractFieldSpecified;

//        private string uRIField;

//        private string visibilityField;

//        private string classifierBehaviorField;

//        private string signalField;

//        private string id1Field;

//        private string idField1;

//        private string _extensionEndOfTypeField;

//        private string memberEndField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("_extensionEndOfType", typeof(packagedElementPackagedElement_extensionEndOfType))]
//        [System.Xml.Serialization.XmlElement("appliedStereotypeInstance", typeof(packagedElementPackagedElementAppliedStereotypeInstance))]
//        [System.Xml.Serialization.XmlElement("changeExpression", typeof(packagedElementPackagedElementChangeExpression))]
//        [System.Xml.Serialization.XmlElement("client", typeof(packagedElementPackagedElementClient))]
//        [System.Xml.Serialization.XmlElement("edge", typeof(packagedElementPackagedElementEdge))]
//        [System.Xml.Serialization.XmlElement("generalization", typeof(packagedElementPackagedElementGeneralization))]
//        [System.Xml.Serialization.XmlElement("Extension", typeof(Extension), Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        [System.Xml.Serialization.XmlElement("memberEnd", typeof(packagedElementPackagedElementMemberEnd))]
//        [System.Xml.Serialization.XmlElement("node", typeof(packagedElementPackagedElementNode))]
//        [System.Xml.Serialization.XmlElement("ownedAttribute", typeof(packagedElementPackagedElementOwnedAttribute))]
//        [System.Xml.Serialization.XmlElement("ownedBehavior", typeof(packagedElementPackagedElementOwnedBehavior))]
//        [System.Xml.Serialization.XmlElement("ownedComment", typeof(packagedElementPackagedElementOwnedComment))]
//        [System.Xml.Serialization.XmlElement("ownedEnd", typeof(packagedElementPackagedElementOwnedEnd))]
//        [System.Xml.Serialization.XmlElement("ownedLiteral", typeof(packagedElementPackagedElementOwnedLiteral))]
//        [System.Xml.Serialization.XmlElement("ownedOperation", typeof(packagedElementPackagedElementOwnedOperation))]
//        [System.Xml.Serialization.XmlElement("ownedRule", typeof(packagedElementPackagedElementOwnedRule))]
//        [System.Xml.Serialization.XmlElement("ownedTemplateSignature", typeof(packagedElementPackagedElementOwnedTemplateSignature))]
//        [System.Xml.Serialization.XmlElement("packagedElement", typeof(packagedElementPackagedElementPackagedElement))]
//        [System.Xml.Serialization.XmlElement("supplier", typeof(packagedElementPackagedElementSupplier))]
//        public object[] Items
//        {
//            get
//            {
//                return itemsField;
//            }
//            set
//            {
//                itemsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool isAbstract
//        {
//            get
//            {
//                return isAbstractField;
//            }
//            set
//            {
//                isAbstractField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool isAbstractSpecified
//        {
//            get
//            {
//                return isAbstractFieldSpecified;
//            }
//            set
//            {
//                isAbstractFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string URI
//        {
//            get
//            {
//                return uRIField;
//            }
//            set
//            {
//                uRIField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string classifierBehavior
//        {
//            get
//            {
//                return classifierBehaviorField;
//            }
//            set
//            {
//                classifierBehaviorField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string signal
//        {
//            get
//            {
//                return signalField;
//            }
//            set
//            {
//                signalField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("id", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id1
//        {
//            get
//            {
//                return id1Field;
//            }
//            set
//            {
//                id1Field = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string _extensionEndOfType
//        {
//            get
//            {
//                return _extensionEndOfTypeField;
//            }
//            set
//            {
//                _extensionEndOfTypeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string memberEnd
//        {
//            get
//            {
//                return memberEndField;
//            }
//            set
//            {
//                memberEndField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElement_extensionEndOfType
//    {

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementAppliedStereotypeInstance
//    {

//        private packagedElementPackagedElementAppliedStereotypeInstanceClassifier[] classifierField;

//        private string idField;

//        private string idField1;

//        private string classifier1Field;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("classifier")]
//        public packagedElementPackagedElementAppliedStereotypeInstanceClassifier[] classifier
//        {
//            get
//            {
//                return classifierField;
//            }
//            set
//            {
//                classifierField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("classifier")]
//        public string classifier1
//        {
//            get
//            {
//                return classifier1Field;
//            }
//            set
//            {
//                classifier1Field = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementAppliedStereotypeInstanceClassifier
//    {

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementChangeExpression
//    {

//        private string bodyField;

//        private string languageField;

//        private string typeField;

//        private string idField;

//        /// <remarks/>
//        public string body
//        {
//            get
//            {
//                return bodyField;
//            }
//            set
//            {
//                bodyField = value;
//            }
//        }

//        /// <remarks/>
//        public string language
//        {
//            get
//            {
//                return languageField;
//            }
//            set
//            {
//                languageField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementClient
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementEdge
//    {

//        private packagedElementPackagedElementEdgeWeight weightField;

//        private string typeField;

//        private string idField;

//        private string visibilityField;

//        private string sourceField;

//        private string targetField;

//        private string nameField;

//        /// <remarks/>
//        public packagedElementPackagedElementEdgeWeight weight
//        {
//            get
//            {
//                return weightField;
//            }
//            set
//            {
//                weightField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string source
//        {
//            get
//            {
//                return sourceField;
//            }
//            set
//            {
//                sourceField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string target
//        {
//            get
//            {
//                return targetField;
//            }
//            set
//            {
//                targetField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementEdgeWeight
//    {

//        private string typeField;

//        private string idField;

//        private byte valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public byte value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementGeneralization
//    {

//        private packagedElementPackagedElementGeneralizationGeneral generalField;

//        private string typeField;

//        private string idField;

//        private string general1Field;

//        private bool isSubstitutableField;

//        private bool isSubstitutableFieldSpecified;

//        private string id1Field;

//        private string idField1;

//        /// <remarks/>
//        public packagedElementPackagedElementGeneralizationGeneral general
//        {
//            get
//            {
//                return generalField;
//            }
//            set
//            {
//                generalField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("general")]
//        public string general1
//        {
//            get
//            {
//                return general1Field;
//            }
//            set
//            {
//                general1Field = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool isSubstitutable
//        {
//            get
//            {
//                return isSubstitutableField;
//            }
//            set
//            {
//                isSubstitutableField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool isSubstitutableSpecified
//        {
//            get
//            {
//                return isSubstitutableFieldSpecified;
//            }
//            set
//            {
//                isSubstitutableFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("id", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id1
//        {
//            get
//            {
//                return id1Field;
//            }
//            set
//            {
//                id1Field = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementGeneralizationGeneral
//    {

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementMemberEnd
//    {

//        private string idrefField;

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementNode
//    {

//        private string typeField;

//        private string idField;

//        private string visibilityField;

//        private string nameField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedAttribute
//    {

//        private packagedElementPackagedElementOwnedAttributeAppliedStereotypeInstance appliedStereotypeInstanceField;

//        private packagedElementPackagedElementOwnedAttributeType typeField;

//        private packagedElementPackagedElementOwnedAttributeAssociation associationField;

//        private packagedElementPackagedElementOwnedAttributeRedefinedProperty redefinedPropertyField;

//        private packagedElementPackagedElementOwnedAttributeSubsettedProperty subsettedPropertyField;

//        private packagedElementPackagedElementOwnedAttributeOwnedComment[] ownedCommentField;

//        private packagedElementPackagedElementOwnedAttributeLowerValue lowerValueField;

//        private Extension[] extensionField;

//        private packagedElementPackagedElementOwnedAttributeDefaultValue defaultValueField;

//        private packagedElementPackagedElementOwnedAttributeUpperValue upperValueField;

//        private string type1Field;

//        private string idField;

//        private string nameField;

//        private string visibilityField;

//        private string type2Field;

//        private string aggregationField;

//        private string association1Field;

//        private bool isStaticField;

//        private bool isStaticFieldSpecified;

//        private bool isReadOnlyField;

//        private bool isReadOnlyFieldSpecified;

//        private string id1Field;

//        private string idField1;

//        private bool isUniqueField;

//        private bool isUniqueFieldSpecified;

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedAttributeAppliedStereotypeInstance appliedStereotypeInstance
//        {
//            get
//            {
//                return appliedStereotypeInstanceField;
//            }
//            set
//            {
//                appliedStereotypeInstanceField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedAttributeType type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedAttributeAssociation association
//        {
//            get
//            {
//                return associationField;
//            }
//            set
//            {
//                associationField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedAttributeRedefinedProperty redefinedProperty
//        {
//            get
//            {
//                return redefinedPropertyField;
//            }
//            set
//            {
//                redefinedPropertyField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedAttributeSubsettedProperty subsettedProperty
//        {
//            get
//            {
//                return subsettedPropertyField;
//            }
//            set
//            {
//                subsettedPropertyField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("ownedComment")]
//        public packagedElementPackagedElementOwnedAttributeOwnedComment[] ownedComment
//        {
//            get
//            {
//                return ownedCommentField;
//            }
//            set
//            {
//                ownedCommentField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedAttributeLowerValue lowerValue
//        {
//            get
//            {
//                return lowerValueField;
//            }
//            set
//            {
//                lowerValueField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("Extension", Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public Extension[] Extension
//        {
//            get
//            {
//                return extensionField;
//            }
//            set
//            {
//                extensionField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedAttributeDefaultValue defaultValue
//        {
//            get
//            {
//                return defaultValueField;
//            }
//            set
//            {
//                defaultValueField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedAttributeUpperValue upperValue
//        {
//            get
//            {
//                return upperValueField;
//            }
//            set
//            {
//                upperValueField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("type", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type1
//        {
//            get
//            {
//                return type1Field;
//            }
//            set
//            {
//                type1Field = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("type")]
//        public string type2
//        {
//            get
//            {
//                return type2Field;
//            }
//            set
//            {
//                type2Field = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string aggregation
//        {
//            get
//            {
//                return aggregationField;
//            }
//            set
//            {
//                aggregationField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("association")]
//        public string association1
//        {
//            get
//            {
//                return association1Field;
//            }
//            set
//            {
//                association1Field = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool isStatic
//        {
//            get
//            {
//                return isStaticField;
//            }
//            set
//            {
//                isStaticField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool isStaticSpecified
//        {
//            get
//            {
//                return isStaticFieldSpecified;
//            }
//            set
//            {
//                isStaticFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool isReadOnly
//        {
//            get
//            {
//                return isReadOnlyField;
//            }
//            set
//            {
//                isReadOnlyField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool isReadOnlySpecified
//        {
//            get
//            {
//                return isReadOnlyFieldSpecified;
//            }
//            set
//            {
//                isReadOnlyFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("id", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id1
//        {
//            get
//            {
//                return id1Field;
//            }
//            set
//            {
//                id1Field = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool isUnique
//        {
//            get
//            {
//                return isUniqueField;
//            }
//            set
//            {
//                isUniqueField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool isUniqueSpecified
//        {
//            get
//            {
//                return isUniqueFieldSpecified;
//            }
//            set
//            {
//                isUniqueFieldSpecified = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedAttributeAppliedStereotypeInstance
//    {

//        private packagedElementPackagedElementOwnedAttributeAppliedStereotypeInstanceClassifier classifierField;

//        private string idField;

//        private string idField1;

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedAttributeAppliedStereotypeInstanceClassifier classifier
//        {
//            get
//            {
//                return classifierField;
//            }
//            set
//            {
//                classifierField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedAttributeAppliedStereotypeInstanceClassifier
//    {

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedAttributeType
//    {

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedAttributeAssociation
//    {

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedAttributeRedefinedProperty
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedAttributeSubsettedProperty
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedAttributeOwnedComment
//    {

//        private packagedElementPackagedElementOwnedAttributeOwnedCommentOwnedComment ownedCommentField;

//        private packagedElementPackagedElementOwnedAttributeOwnedCommentAnnotatedElement annotatedElementField;

//        private string typeField;

//        private string idField;

//        private string bodyField;

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedAttributeOwnedCommentOwnedComment ownedComment
//        {
//            get
//            {
//                return ownedCommentField;
//            }
//            set
//            {
//                ownedCommentField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedAttributeOwnedCommentAnnotatedElement annotatedElement
//        {
//            get
//            {
//                return annotatedElementField;
//            }
//            set
//            {
//                annotatedElementField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string body
//        {
//            get
//            {
//                return bodyField;
//            }
//            set
//            {
//                bodyField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedAttributeOwnedCommentOwnedComment
//    {

//        private packagedElementPackagedElementOwnedAttributeOwnedCommentOwnedCommentAnnotatedElement annotatedElementField;

//        private string typeField;

//        private string idField;

//        private string bodyField;

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedAttributeOwnedCommentOwnedCommentAnnotatedElement annotatedElement
//        {
//            get
//            {
//                return annotatedElementField;
//            }
//            set
//            {
//                annotatedElementField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string body
//        {
//            get
//            {
//                return bodyField;
//            }
//            set
//            {
//                bodyField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedAttributeOwnedCommentOwnedCommentAnnotatedElement
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedAttributeOwnedCommentAnnotatedElement
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedAttributeLowerValue
//    {

//        private string typeField;

//        private string idField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedAttributeDefaultValue
//    {

//        private string typeField;

//        private string idField;

//        private bool valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedAttributeUpperValue
//    {

//        private string typeField;

//        private string idField;

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedBehavior
//    {

//        private Extension[] extensionField;

//        private packagedElementPackagedElementOwnedBehaviorNestedClassifier[] nestedClassifierField;

//        private packagedElementPackagedElementOwnedBehaviorRegion regionField;

//        private string typeField;

//        private string idField;

//        private string nameField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("Extension", Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public Extension[] Extension
//        {
//            get
//            {
//                return extensionField;
//            }
//            set
//            {
//                extensionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("nestedClassifier")]
//        public packagedElementPackagedElementOwnedBehaviorNestedClassifier[] nestedClassifier
//        {
//            get
//            {
//                return nestedClassifierField;
//            }
//            set
//            {
//                nestedClassifierField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedBehaviorRegion region
//        {
//            get
//            {
//                return regionField;
//            }
//            set
//            {
//                regionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedBehaviorNestedClassifier
//    {

//        private string typeField;

//        private string idField;

//        private string nameField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedBehaviorRegion
//    {

//        private packagedElementPackagedElementOwnedBehaviorRegionSubvertex[] subvertexField;

//        private packagedElementPackagedElementOwnedBehaviorRegionTransition[] transitionField;

//        private string typeField;

//        private string idField;

//        private string nameField;

//        private string visibilityField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("subvertex")]
//        public packagedElementPackagedElementOwnedBehaviorRegionSubvertex[] subvertex
//        {
//            get
//            {
//                return subvertexField;
//            }
//            set
//            {
//                subvertexField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("transition")]
//        public packagedElementPackagedElementOwnedBehaviorRegionTransition[] transition
//        {
//            get
//            {
//                return transitionField;
//            }
//            set
//            {
//                transitionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedBehaviorRegionSubvertex
//    {

//        private packagedElementPackagedElementOwnedBehaviorRegionSubvertexRegion regionField;

//        private string typeField;

//        private string idField;

//        private string nameField;

//        private string visibilityField;

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedBehaviorRegionSubvertexRegion region
//        {
//            get
//            {
//                return regionField;
//            }
//            set
//            {
//                regionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedBehaviorRegionSubvertexRegion
//    {

//        private packagedElementPackagedElementOwnedBehaviorRegionSubvertexRegionSubvertex[] subvertexField;

//        private packagedElementPackagedElementOwnedBehaviorRegionSubvertexRegionTransition transitionField;

//        private string typeField;

//        private string idField;

//        private string visibilityField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("subvertex")]
//        public packagedElementPackagedElementOwnedBehaviorRegionSubvertexRegionSubvertex[] subvertex
//        {
//            get
//            {
//                return subvertexField;
//            }
//            set
//            {
//                subvertexField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedBehaviorRegionSubvertexRegionTransition transition
//        {
//            get
//            {
//                return transitionField;
//            }
//            set
//            {
//                transitionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedBehaviorRegionSubvertexRegionSubvertex
//    {

//        private packagedElementPackagedElementOwnedBehaviorRegionSubvertexRegionSubvertexDoActivity doActivityField;

//        private packagedElementPackagedElementOwnedBehaviorRegionSubvertexRegionSubvertexRegion regionField;

//        private string typeField;

//        private string idField;

//        private string nameField;

//        private string visibilityField;

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedBehaviorRegionSubvertexRegionSubvertexDoActivity doActivity
//        {
//            get
//            {
//                return doActivityField;
//            }
//            set
//            {
//                doActivityField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedBehaviorRegionSubvertexRegionSubvertexRegion region
//        {
//            get
//            {
//                return regionField;
//            }
//            set
//            {
//                regionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedBehaviorRegionSubvertexRegionSubvertexDoActivity
//    {

//        private Extension extensionField;

//        private string typeField;

//        private string idField;

//        private string nameField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public Extension Extension
//        {
//            get
//            {
//                return extensionField;
//            }
//            set
//            {
//                extensionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedBehaviorRegionSubvertexRegionSubvertexRegion
//    {

//        private string typeField;

//        private string idField;

//        private string visibilityField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedBehaviorRegionSubvertexRegionTransition
//    {

//        private packagedElementPackagedElementOwnedBehaviorRegionSubvertexRegionTransitionTrigger triggerField;

//        private string typeField;

//        private string idField;

//        private string visibilityField;

//        private string sourceField;

//        private string targetField;

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedBehaviorRegionSubvertexRegionTransitionTrigger trigger
//        {
//            get
//            {
//                return triggerField;
//            }
//            set
//            {
//                triggerField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string source
//        {
//            get
//            {
//                return sourceField;
//            }
//            set
//            {
//                sourceField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string target
//        {
//            get
//            {
//                return targetField;
//            }
//            set
//            {
//                targetField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedBehaviorRegionSubvertexRegionTransitionTrigger
//    {

//        private string typeField;

//        private string idField;

//        private string visibilityField;

//        private string eventField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string @event
//        {
//            get
//            {
//                return eventField;
//            }
//            set
//            {
//                eventField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedBehaviorRegionTransition
//    {

//        private packagedElementPackagedElementOwnedBehaviorRegionTransitionOwnedComment ownedCommentField;

//        private packagedElementPackagedElementOwnedBehaviorRegionTransitionEffect effectField;

//        private packagedElementPackagedElementOwnedBehaviorRegionTransitionTrigger triggerField;

//        private string typeField;

//        private string idField;

//        private string visibilityField;

//        private string sourceField;

//        private string targetField;

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedBehaviorRegionTransitionOwnedComment ownedComment
//        {
//            get
//            {
//                return ownedCommentField;
//            }
//            set
//            {
//                ownedCommentField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedBehaviorRegionTransitionEffect effect
//        {
//            get
//            {
//                return effectField;
//            }
//            set
//            {
//                effectField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedBehaviorRegionTransitionTrigger trigger
//        {
//            get
//            {
//                return triggerField;
//            }
//            set
//            {
//                triggerField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string source
//        {
//            get
//            {
//                return sourceField;
//            }
//            set
//            {
//                sourceField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string target
//        {
//            get
//            {
//                return targetField;
//            }
//            set
//            {
//                targetField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedBehaviorRegionTransitionOwnedComment
//    {

//        private packagedElementPackagedElementOwnedBehaviorRegionTransitionOwnedCommentAnnotatedElement annotatedElementField;

//        private string typeField;

//        private string idField;

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedBehaviorRegionTransitionOwnedCommentAnnotatedElement annotatedElement
//        {
//            get
//            {
//                return annotatedElementField;
//            }
//            set
//            {
//                annotatedElementField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedBehaviorRegionTransitionOwnedCommentAnnotatedElement
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedBehaviorRegionTransitionEffect
//    {

//        private Extension extensionField;

//        private string typeField;

//        private string idField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public Extension Extension
//        {
//            get
//            {
//                return extensionField;
//            }
//            set
//            {
//                extensionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedBehaviorRegionTransitionTrigger
//    {

//        private string typeField;

//        private string idField;

//        private string visibilityField;

//        private string eventField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string @event
//        {
//            get
//            {
//                return eventField;
//            }
//            set
//            {
//                eventField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedComment
//    {

//        private packagedElementPackagedElementOwnedCommentOwnedComment ownedCommentField;

//        private packagedElementPackagedElementOwnedCommentAnnotatedElement annotatedElementField;

//        private string typeField;

//        private string idField;

//        private string bodyField;

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedCommentOwnedComment ownedComment
//        {
//            get
//            {
//                return ownedCommentField;
//            }
//            set
//            {
//                ownedCommentField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedCommentAnnotatedElement annotatedElement
//        {
//            get
//            {
//                return annotatedElementField;
//            }
//            set
//            {
//                annotatedElementField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string body
//        {
//            get
//            {
//                return bodyField;
//            }
//            set
//            {
//                bodyField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedCommentOwnedComment
//    {

//        private packagedElementPackagedElementOwnedCommentOwnedCommentAnnotatedElement annotatedElementField;

//        private string typeField;

//        private string idField;

//        private string bodyField;

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedCommentOwnedCommentAnnotatedElement annotatedElement
//        {
//            get
//            {
//                return annotatedElementField;
//            }
//            set
//            {
//                annotatedElementField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string body
//        {
//            get
//            {
//                return bodyField;
//            }
//            set
//            {
//                bodyField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedCommentOwnedCommentAnnotatedElement
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedCommentAnnotatedElement
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedEnd
//    {

//        private packagedElementPackagedElementOwnedEndType typeField;

//        private packagedElementPackagedElementOwnedEndAssociation associationField;

//        private Extension extensionField;

//        private packagedElementPackagedElementOwnedEndUpperValue upperValueField;

//        private string type1Field;

//        private string idField;

//        private string visibilityField;

//        private string type2Field;

//        private string association1Field;

//        private string nameField;

//        private string id1Field;

//        private string idField1;

//        private string aggregationField;

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedEndType type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedEndAssociation association
//        {
//            get
//            {
//                return associationField;
//            }
//            set
//            {
//                associationField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public Extension Extension
//        {
//            get
//            {
//                return extensionField;
//            }
//            set
//            {
//                extensionField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedEndUpperValue upperValue
//        {
//            get
//            {
//                return upperValueField;
//            }
//            set
//            {
//                upperValueField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("type", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type1
//        {
//            get
//            {
//                return type1Field;
//            }
//            set
//            {
//                type1Field = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("type")]
//        public string type2
//        {
//            get
//            {
//                return type2Field;
//            }
//            set
//            {
//                type2Field = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("association")]
//        public string association1
//        {
//            get
//            {
//                return association1Field;
//            }
//            set
//            {
//                association1Field = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("id", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id1
//        {
//            get
//            {
//                return id1Field;
//            }
//            set
//            {
//                id1Field = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string aggregation
//        {
//            get
//            {
//                return aggregationField;
//            }
//            set
//            {
//                aggregationField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedEndType
//    {

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedEndAssociation
//    {

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedEndUpperValue
//    {

//        private string typeField;

//        private string idField;

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedLiteral
//    {

//        private packagedElementPackagedElementOwnedLiteralAppliedStereotypeInstance appliedStereotypeInstanceField;

//        private string idField;

//        private string idField1;

//        private string nameField;

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedLiteralAppliedStereotypeInstance appliedStereotypeInstance
//        {
//            get
//            {
//                return appliedStereotypeInstanceField;
//            }
//            set
//            {
//                appliedStereotypeInstanceField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedLiteralAppliedStereotypeInstance
//    {

//        private packagedElementPackagedElementOwnedLiteralAppliedStereotypeInstanceSlot slotField;

//        private string idField;

//        private string idField1;

//        private string classifierField;

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedLiteralAppliedStereotypeInstanceSlot slot
//        {
//            get
//            {
//                return slotField;
//            }
//            set
//            {
//                slotField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string classifier
//        {
//            get
//            {
//                return classifierField;
//            }
//            set
//            {
//                classifierField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedLiteralAppliedStereotypeInstanceSlot
//    {

//        private string idField;

//        private string idField1;

//        private string definingFeatureField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string definingFeature
//        {
//            get
//            {
//                return definingFeatureField;
//            }
//            set
//            {
//                definingFeatureField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedOperation
//    {

//        private packagedElementPackagedElementOwnedOperationOwnedParameter ownedParameterField;

//        private string typeField;

//        private string idField;

//        private string nameField;

//        private string visibilityField;

//        private bool isAbstractField;

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedOperationOwnedParameter ownedParameter
//        {
//            get
//            {
//                return ownedParameterField;
//            }
//            set
//            {
//                ownedParameterField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool isAbstract
//        {
//            get
//            {
//                return isAbstractField;
//            }
//            set
//            {
//                isAbstractField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedOperationOwnedParameter
//    {

//        private packagedElementPackagedElementOwnedOperationOwnedParameterType typeField;

//        private string type1Field;

//        private string idField;

//        private string visibilityField;

//        private string directionField;

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedOperationOwnedParameterType type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("type", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type1
//        {
//            get
//            {
//                return type1Field;
//            }
//            set
//            {
//                type1Field = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string direction
//        {
//            get
//            {
//                return directionField;
//            }
//            set
//            {
//                directionField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedOperationOwnedParameterType
//    {

//        private Extension extensionField;

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public Extension Extension
//        {
//            get
//            {
//                return extensionField;
//            }
//            set
//            {
//                extensionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedRule
//    {

//        private packagedElementPackagedElementOwnedRuleConstrainedElement constrainedElementField;

//        private packagedElementPackagedElementOwnedRuleSpecification specificationField;

//        private string typeField;

//        private string idField;

//        private string nameField;

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedRuleConstrainedElement constrainedElement
//        {
//            get
//            {
//                return constrainedElementField;
//            }
//            set
//            {
//                constrainedElementField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedRuleSpecification specification
//        {
//            get
//            {
//                return specificationField;
//            }
//            set
//            {
//                specificationField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedRuleConstrainedElement
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedRuleSpecification
//    {

//        private string bodyField;

//        private string languageField;

//        private string typeField;

//        private string idField;

//        /// <remarks/>
//        public string body
//        {
//            get
//            {
//                return bodyField;
//            }
//            set
//            {
//                bodyField = value;
//            }
//        }

//        /// <remarks/>
//        public string language
//        {
//            get
//            {
//                return languageField;
//            }
//            set
//            {
//                languageField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedTemplateSignature
//    {

//        private packagedElementPackagedElementOwnedTemplateSignatureParameter parameterField;

//        private packagedElementPackagedElementOwnedTemplateSignatureOwnedParameter ownedParameterField;

//        private string typeField;

//        private string idField;

//        private string visibilityField;

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedTemplateSignatureParameter parameter
//        {
//            get
//            {
//                return parameterField;
//            }
//            set
//            {
//                parameterField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedTemplateSignatureOwnedParameter ownedParameter
//        {
//            get
//            {
//                return ownedParameterField;
//            }
//            set
//            {
//                ownedParameterField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedTemplateSignatureParameter
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedTemplateSignatureOwnedParameter
//    {

//        private packagedElementPackagedElementOwnedTemplateSignatureOwnedParameterConstrainingClassifier constrainingClassifierField;

//        private packagedElementPackagedElementOwnedTemplateSignatureOwnedParameterOwnedParameteredElement ownedParameteredElementField;

//        private string typeField;

//        private string idField;

//        private string parameteredElementField;

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedTemplateSignatureOwnedParameterConstrainingClassifier constrainingClassifier
//        {
//            get
//            {
//                return constrainingClassifierField;
//            }
//            set
//            {
//                constrainingClassifierField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementOwnedTemplateSignatureOwnedParameterOwnedParameteredElement ownedParameteredElement
//        {
//            get
//            {
//                return ownedParameteredElementField;
//            }
//            set
//            {
//                ownedParameteredElementField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string parameteredElement
//        {
//            get
//            {
//                return parameteredElementField;
//            }
//            set
//            {
//                parameteredElementField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedTemplateSignatureOwnedParameterConstrainingClassifier
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementOwnedTemplateSignatureOwnedParameterOwnedParameteredElement
//    {

//        private string typeField;

//        private string idField;

//        private string nameField;

//        private string templateParameterField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string templateParameter
//        {
//            get
//            {
//                return templateParameterField;
//            }
//            set
//            {
//                templateParameterField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElement
//    {

//        private object[] itemsField;

//        private string typeField;

//        private string idField;

//        private string nameField;

//        private string visibilityField;

//        private bool isAbstractField;

//        private bool isAbstractFieldSpecified;

//        private bool isLeafField;

//        private bool isLeafFieldSpecified;

//        private string classifierBehaviorField;

//        private string id1Field;

//        private string idField1;

//        private string _extensionEndOfTypeField;

//        private string memberEndField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("appliedStereotypeInstance", typeof(packagedElementPackagedElementPackagedElementAppliedStereotypeInstance))]
//        [System.Xml.Serialization.XmlElement("classifier", typeof(packagedElementPackagedElementPackagedElementClassifier))]
//        [System.Xml.Serialization.XmlElement("client", typeof(packagedElementPackagedElementPackagedElementClient))]
//        [System.Xml.Serialization.XmlElement("generalization", typeof(packagedElementPackagedElementPackagedElementGeneralization))]
//        [System.Xml.Serialization.XmlElement("Extension", typeof(Extension), Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        [System.Xml.Serialization.XmlElement("informationSource", typeof(packagedElementPackagedElementPackagedElementInformationSource))]
//        [System.Xml.Serialization.XmlElement("informationTarget", typeof(packagedElementPackagedElementPackagedElementInformationTarget))]
//        [System.Xml.Serialization.XmlElement("memberEnd", typeof(packagedElementPackagedElementPackagedElementMemberEnd))]
//        [System.Xml.Serialization.XmlElement("navigableOwnedEnd", typeof(packagedElementPackagedElementPackagedElementNavigableOwnedEnd))]
//        [System.Xml.Serialization.XmlElement("ownedAttribute", typeof(packagedElementPackagedElementPackagedElementOwnedAttribute))]
//        [System.Xml.Serialization.XmlElement("ownedBehavior", typeof(packagedElementPackagedElementPackagedElementOwnedBehavior))]
//        [System.Xml.Serialization.XmlElement("ownedComment", typeof(packagedElementPackagedElementPackagedElementOwnedComment))]
//        [System.Xml.Serialization.XmlElement("ownedEnd", typeof(packagedElementPackagedElementPackagedElementOwnedEnd))]
//        [System.Xml.Serialization.XmlElement("ownedLiteral", typeof(packagedElementPackagedElementPackagedElementOwnedLiteral))]
//        [System.Xml.Serialization.XmlElement("ownedRule", typeof(packagedElementPackagedElementPackagedElementOwnedRule))]
//        [System.Xml.Serialization.XmlElement("ownedTemplateSignature", typeof(packagedElementPackagedElementPackagedElementOwnedTemplateSignature))]
//        [System.Xml.Serialization.XmlElement("packagedElement", typeof(packagedElementPackagedElementPackagedElementPackagedElement))]
//        [System.Xml.Serialization.XmlElement("slot", typeof(packagedElementPackagedElementPackagedElementSlot))]
//        [System.Xml.Serialization.XmlElement("supplier", typeof(packagedElementPackagedElementPackagedElementSupplier))]
//        public object[] Items
//        {
//            get
//            {
//                return itemsField;
//            }
//            set
//            {
//                itemsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool isAbstract
//        {
//            get
//            {
//                return isAbstractField;
//            }
//            set
//            {
//                isAbstractField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool isAbstractSpecified
//        {
//            get
//            {
//                return isAbstractFieldSpecified;
//            }
//            set
//            {
//                isAbstractFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool isLeaf
//        {
//            get
//            {
//                return isLeafField;
//            }
//            set
//            {
//                isLeafField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool isLeafSpecified
//        {
//            get
//            {
//                return isLeafFieldSpecified;
//            }
//            set
//            {
//                isLeafFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string classifierBehavior
//        {
//            get
//            {
//                return classifierBehaviorField;
//            }
//            set
//            {
//                classifierBehaviorField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("id", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id1
//        {
//            get
//            {
//                return id1Field;
//            }
//            set
//            {
//                id1Field = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string _extensionEndOfType
//        {
//            get
//            {
//                return _extensionEndOfTypeField;
//            }
//            set
//            {
//                _extensionEndOfTypeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string memberEnd
//        {
//            get
//            {
//                return memberEndField;
//            }
//            set
//            {
//                memberEndField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementAppliedStereotypeInstance
//    {

//        private string idField;

//        private string idField1;

//        private string classifierField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string classifier
//        {
//            get
//            {
//                return classifierField;
//            }
//            set
//            {
//                classifierField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementClassifier
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementClient
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementGeneralization
//    {

//        private packagedElementPackagedElementPackagedElementGeneralizationGeneral generalField;

//        private string typeField;

//        private string idField;

//        private string general1Field;

//        private bool isSubstitutableField;

//        private bool isSubstitutableFieldSpecified;

//        private string id1Field;

//        private string idField1;

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementGeneralizationGeneral general
//        {
//            get
//            {
//                return generalField;
//            }
//            set
//            {
//                generalField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("general")]
//        public string general1
//        {
//            get
//            {
//                return general1Field;
//            }
//            set
//            {
//                general1Field = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool isSubstitutable
//        {
//            get
//            {
//                return isSubstitutableField;
//            }
//            set
//            {
//                isSubstitutableField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool isSubstitutableSpecified
//        {
//            get
//            {
//                return isSubstitutableFieldSpecified;
//            }
//            set
//            {
//                isSubstitutableFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("id", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id1
//        {
//            get
//            {
//                return id1Field;
//            }
//            set
//            {
//                id1Field = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementGeneralizationGeneral
//    {

//        private Extension extensionField;

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public Extension Extension
//        {
//            get
//            {
//                return extensionField;
//            }
//            set
//            {
//                extensionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementInformationSource
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementInformationTarget
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementMemberEnd
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementNavigableOwnedEnd
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedAttribute
//    {

//        private object[] itemsField;

//        private string typeField;

//        private string idField;

//        private string nameField;

//        private string aggregationField;

//        private string type1Field;

//        private string visibilityField;

//        private string associationField;

//        private bool isStaticField;

//        private bool isStaticFieldSpecified;

//        private bool isReadOnlyField;

//        private bool isReadOnlyFieldSpecified;

//        private string id1Field;

//        private string idField1;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("defaultValue", typeof(packagedElementPackagedElementPackagedElementOwnedAttributeDefaultValue))]
//        [System.Xml.Serialization.XmlElement("Extension", typeof(Extension), Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        [System.Xml.Serialization.XmlElement("lowerValue", typeof(packagedElementPackagedElementPackagedElementOwnedAttributeLowerValue))]
//        [System.Xml.Serialization.XmlElement("ownedComment", typeof(packagedElementPackagedElementPackagedElementOwnedAttributeOwnedComment))]
//        [System.Xml.Serialization.XmlElement("redefinedProperty", typeof(packagedElementPackagedElementPackagedElementOwnedAttributeRedefinedProperty))]
//        [System.Xml.Serialization.XmlElement("subsettedProperty", typeof(packagedElementPackagedElementPackagedElementOwnedAttributeSubsettedProperty))]
//        [System.Xml.Serialization.XmlElement("type", typeof(packagedElementPackagedElementPackagedElementOwnedAttributeType))]
//        [System.Xml.Serialization.XmlElement("upperValue", typeof(packagedElementPackagedElementPackagedElementOwnedAttributeUpperValue))]
//        public object[] Items
//        {
//            get
//            {
//                return itemsField;
//            }
//            set
//            {
//                itemsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string aggregation
//        {
//            get
//            {
//                return aggregationField;
//            }
//            set
//            {
//                aggregationField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("type")]
//        public string type1
//        {
//            get
//            {
//                return type1Field;
//            }
//            set
//            {
//                type1Field = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string association
//        {
//            get
//            {
//                return associationField;
//            }
//            set
//            {
//                associationField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool isStatic
//        {
//            get
//            {
//                return isStaticField;
//            }
//            set
//            {
//                isStaticField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool isStaticSpecified
//        {
//            get
//            {
//                return isStaticFieldSpecified;
//            }
//            set
//            {
//                isStaticFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool isReadOnly
//        {
//            get
//            {
//                return isReadOnlyField;
//            }
//            set
//            {
//                isReadOnlyField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool isReadOnlySpecified
//        {
//            get
//            {
//                return isReadOnlyFieldSpecified;
//            }
//            set
//            {
//                isReadOnlyFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("id", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id1
//        {
//            get
//            {
//                return id1Field;
//            }
//            set
//            {
//                id1Field = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedAttributeDefaultValue
//    {

//        private string typeField;

//        private string idField;

//        private string instanceField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string instance
//        {
//            get
//            {
//                return instanceField;
//            }
//            set
//            {
//                instanceField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedAttributeLowerValue
//    {

//        private string typeField;

//        private string idField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedAttributeOwnedComment
//    {

//        private packagedElementPackagedElementPackagedElementOwnedAttributeOwnedCommentAnnotatedElement annotatedElementField;

//        private string typeField;

//        private string idField;

//        private string bodyField;

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementOwnedAttributeOwnedCommentAnnotatedElement annotatedElement
//        {
//            get
//            {
//                return annotatedElementField;
//            }
//            set
//            {
//                annotatedElementField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string body
//        {
//            get
//            {
//                return bodyField;
//            }
//            set
//            {
//                bodyField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedAttributeOwnedCommentAnnotatedElement
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedAttributeRedefinedProperty
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedAttributeSubsettedProperty
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedAttributeType
//    {

//        private Extension extensionField;

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public Extension Extension
//        {
//            get
//            {
//                return extensionField;
//            }
//            set
//            {
//                extensionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedAttributeUpperValue
//    {

//        private string typeField;

//        private string idField;

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedBehavior
//    {

//        private Extension extensionField;

//        private packagedElementPackagedElementPackagedElementOwnedBehaviorOwnedAttribute[] ownedAttributeField;

//        private packagedElementPackagedElementPackagedElementOwnedBehaviorFragment[] fragmentField;

//        private packagedElementPackagedElementPackagedElementOwnedBehaviorLifeline[] lifelineField;

//        private packagedElementPackagedElementPackagedElementOwnedBehaviorMessage[] messageField;

//        private string typeField;

//        private string idField;

//        private string nameField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public Extension Extension
//        {
//            get
//            {
//                return extensionField;
//            }
//            set
//            {
//                extensionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("ownedAttribute")]
//        public packagedElementPackagedElementPackagedElementOwnedBehaviorOwnedAttribute[] ownedAttribute
//        {
//            get
//            {
//                return ownedAttributeField;
//            }
//            set
//            {
//                ownedAttributeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("fragment")]
//        public packagedElementPackagedElementPackagedElementOwnedBehaviorFragment[] fragment
//        {
//            get
//            {
//                return fragmentField;
//            }
//            set
//            {
//                fragmentField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("lifeline")]
//        public packagedElementPackagedElementPackagedElementOwnedBehaviorLifeline[] lifeline
//        {
//            get
//            {
//                return lifelineField;
//            }
//            set
//            {
//                lifelineField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("message")]
//        public packagedElementPackagedElementPackagedElementOwnedBehaviorMessage[] message
//        {
//            get
//            {
//                return messageField;
//            }
//            set
//            {
//                messageField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedBehaviorOwnedAttribute
//    {

//        private string typeField;

//        private string idField;

//        private string nameField;

//        private string visibilityField;

//        private string type1Field;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("type")]
//        public string type1
//        {
//            get
//            {
//                return type1Field;
//            }
//            set
//            {
//                type1Field = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedBehaviorFragment
//    {

//        private packagedElementPackagedElementPackagedElementOwnedBehaviorFragmentCovered coveredField;

//        private packagedElementPackagedElementPackagedElementOwnedBehaviorFragmentInvariant invariantField;

//        private string typeField;

//        private string idField;

//        private string visibilityField;

//        private string messageField;

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementOwnedBehaviorFragmentCovered covered
//        {
//            get
//            {
//                return coveredField;
//            }
//            set
//            {
//                coveredField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementOwnedBehaviorFragmentInvariant invariant
//        {
//            get
//            {
//                return invariantField;
//            }
//            set
//            {
//                invariantField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string message
//        {
//            get
//            {
//                return messageField;
//            }
//            set
//            {
//                messageField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedBehaviorFragmentCovered
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedBehaviorFragmentInvariant
//    {

//        private Extension extensionField;

//        private string typeField;

//        private string idField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public Extension Extension
//        {
//            get
//            {
//                return extensionField;
//            }
//            set
//            {
//                extensionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedBehaviorLifeline
//    {

//        private packagedElementPackagedElementPackagedElementOwnedBehaviorLifelineCoveredBy[] coveredByField;

//        private packagedElementPackagedElementPackagedElementOwnedBehaviorLifelineOwnedComment[] ownedCommentField;

//        private string typeField;

//        private string idField;

//        private string visibilityField;

//        private string representsField;

//        private string nameField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("coveredBy")]
//        public packagedElementPackagedElementPackagedElementOwnedBehaviorLifelineCoveredBy[] coveredBy
//        {
//            get
//            {
//                return coveredByField;
//            }
//            set
//            {
//                coveredByField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("ownedComment")]
//        public packagedElementPackagedElementPackagedElementOwnedBehaviorLifelineOwnedComment[] ownedComment
//        {
//            get
//            {
//                return ownedCommentField;
//            }
//            set
//            {
//                ownedCommentField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string represents
//        {
//            get
//            {
//                return representsField;
//            }
//            set
//            {
//                representsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedBehaviorLifelineCoveredBy
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedBehaviorLifelineOwnedComment
//    {

//        private packagedElementPackagedElementPackagedElementOwnedBehaviorLifelineOwnedCommentAnnotatedElement annotatedElementField;

//        private string typeField;

//        private string idField;

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementOwnedBehaviorLifelineOwnedCommentAnnotatedElement annotatedElement
//        {
//            get
//            {
//                return annotatedElementField;
//            }
//            set
//            {
//                annotatedElementField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedBehaviorLifelineOwnedCommentAnnotatedElement
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedBehaviorMessage
//    {

//        private string typeField;

//        private string idField;

//        private string visibilityField;

//        private string messageSortField;

//        private string receiveEventField;

//        private string sendEventField;

//        private string signatureField;

//        private string nameField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string messageSort
//        {
//            get
//            {
//                return messageSortField;
//            }
//            set
//            {
//                messageSortField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string receiveEvent
//        {
//            get
//            {
//                return receiveEventField;
//            }
//            set
//            {
//                receiveEventField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string sendEvent
//        {
//            get
//            {
//                return sendEventField;
//            }
//            set
//            {
//                sendEventField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string signature
//        {
//            get
//            {
//                return signatureField;
//            }
//            set
//            {
//                signatureField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedComment
//    {

//        private packagedElementPackagedElementPackagedElementOwnedCommentOwnedComment ownedCommentField;

//        private packagedElementPackagedElementPackagedElementOwnedCommentAnnotatedElement annotatedElementField;

//        private string typeField;

//        private string idField;

//        private string bodyField;

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementOwnedCommentOwnedComment ownedComment
//        {
//            get
//            {
//                return ownedCommentField;
//            }
//            set
//            {
//                ownedCommentField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementOwnedCommentAnnotatedElement annotatedElement
//        {
//            get
//            {
//                return annotatedElementField;
//            }
//            set
//            {
//                annotatedElementField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string body
//        {
//            get
//            {
//                return bodyField;
//            }
//            set
//            {
//                bodyField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedCommentOwnedComment
//    {

//        private packagedElementPackagedElementPackagedElementOwnedCommentOwnedCommentAnnotatedElement annotatedElementField;

//        private string typeField;

//        private string idField;

//        private string bodyField;

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementOwnedCommentOwnedCommentAnnotatedElement annotatedElement
//        {
//            get
//            {
//                return annotatedElementField;
//            }
//            set
//            {
//                annotatedElementField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string body
//        {
//            get
//            {
//                return bodyField;
//            }
//            set
//            {
//                bodyField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedCommentOwnedCommentAnnotatedElement
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedCommentAnnotatedElement
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedEnd
//    {

//        private packagedElementPackagedElementPackagedElementOwnedEndLowerValue lowerValueField;

//        private Extension extensionField;

//        private string typeField;

//        private string idField;

//        private string nameField;

//        private string visibilityField;

//        private string aggregationField;

//        private string type1Field;

//        private string associationField;

//        private string id1Field;

//        private string idField1;

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementOwnedEndLowerValue lowerValue
//        {
//            get
//            {
//                return lowerValueField;
//            }
//            set
//            {
//                lowerValueField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public Extension Extension
//        {
//            get
//            {
//                return extensionField;
//            }
//            set
//            {
//                extensionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string aggregation
//        {
//            get
//            {
//                return aggregationField;
//            }
//            set
//            {
//                aggregationField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("type")]
//        public string type1
//        {
//            get
//            {
//                return type1Field;
//            }
//            set
//            {
//                type1Field = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string association
//        {
//            get
//            {
//                return associationField;
//            }
//            set
//            {
//                associationField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("id", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id1
//        {
//            get
//            {
//                return id1Field;
//            }
//            set
//            {
//                id1Field = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedEndLowerValue
//    {

//        private string typeField;

//        private string idField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedLiteral
//    {

//        private packagedElementPackagedElementPackagedElementOwnedLiteralOwnedComment ownedCommentField;

//        private string typeField;

//        private string idField;

//        private string nameField;

//        private string id1Field;

//        private string idField1;

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementOwnedLiteralOwnedComment ownedComment
//        {
//            get
//            {
//                return ownedCommentField;
//            }
//            set
//            {
//                ownedCommentField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("id", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id1
//        {
//            get
//            {
//                return id1Field;
//            }
//            set
//            {
//                id1Field = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedLiteralOwnedComment
//    {

//        private packagedElementPackagedElementPackagedElementOwnedLiteralOwnedCommentAnnotatedElement annotatedElementField;

//        private string typeField;

//        private string idField;

//        private string bodyField;

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementOwnedLiteralOwnedCommentAnnotatedElement annotatedElement
//        {
//            get
//            {
//                return annotatedElementField;
//            }
//            set
//            {
//                annotatedElementField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string body
//        {
//            get
//            {
//                return bodyField;
//            }
//            set
//            {
//                bodyField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedLiteralOwnedCommentAnnotatedElement
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedRule
//    {

//        private packagedElementPackagedElementPackagedElementOwnedRuleConstrainedElement constrainedElementField;

//        private packagedElementPackagedElementPackagedElementOwnedRuleSpecification specificationField;

//        private string typeField;

//        private string idField;

//        private string nameField;

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementOwnedRuleConstrainedElement constrainedElement
//        {
//            get
//            {
//                return constrainedElementField;
//            }
//            set
//            {
//                constrainedElementField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementOwnedRuleSpecification specification
//        {
//            get
//            {
//                return specificationField;
//            }
//            set
//            {
//                specificationField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedRuleConstrainedElement
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedRuleSpecification
//    {

//        private string bodyField;

//        private string languageField;

//        private string typeField;

//        private string idField;

//        /// <remarks/>
//        public string body
//        {
//            get
//            {
//                return bodyField;
//            }
//            set
//            {
//                bodyField = value;
//            }
//        }

//        /// <remarks/>
//        public string language
//        {
//            get
//            {
//                return languageField;
//            }
//            set
//            {
//                languageField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedTemplateSignature
//    {

//        private packagedElementPackagedElementPackagedElementOwnedTemplateSignatureParameter[] parameterField;

//        private packagedElementPackagedElementPackagedElementOwnedTemplateSignatureOwnedParameter[] ownedParameterField;

//        private string typeField;

//        private string idField;

//        private string visibilityField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("parameter")]
//        public packagedElementPackagedElementPackagedElementOwnedTemplateSignatureParameter[] parameter
//        {
//            get
//            {
//                return parameterField;
//            }
//            set
//            {
//                parameterField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("ownedParameter")]
//        public packagedElementPackagedElementPackagedElementOwnedTemplateSignatureOwnedParameter[] ownedParameter
//        {
//            get
//            {
//                return ownedParameterField;
//            }
//            set
//            {
//                ownedParameterField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedTemplateSignatureParameter
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedTemplateSignatureOwnedParameter
//    {

//        private packagedElementPackagedElementPackagedElementOwnedTemplateSignatureOwnedParameterConstrainingClassifier constrainingClassifierField;

//        private packagedElementPackagedElementPackagedElementOwnedTemplateSignatureOwnedParameterOwnedParameteredElement ownedParameteredElementField;

//        private string typeField;

//        private string idField;

//        private string parameteredElementField;

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementOwnedTemplateSignatureOwnedParameterConstrainingClassifier constrainingClassifier
//        {
//            get
//            {
//                return constrainingClassifierField;
//            }
//            set
//            {
//                constrainingClassifierField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementOwnedTemplateSignatureOwnedParameterOwnedParameteredElement ownedParameteredElement
//        {
//            get
//            {
//                return ownedParameteredElementField;
//            }
//            set
//            {
//                ownedParameteredElementField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string parameteredElement
//        {
//            get
//            {
//                return parameteredElementField;
//            }
//            set
//            {
//                parameteredElementField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedTemplateSignatureOwnedParameterConstrainingClassifier
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementOwnedTemplateSignatureOwnedParameterOwnedParameteredElement
//    {

//        private string typeField;

//        private string idField;

//        private string nameField;

//        private string templateParameterField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string templateParameter
//        {
//            get
//            {
//                return templateParameterField;
//            }
//            set
//            {
//                templateParameterField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElement
//    {

//        private object[] itemsField;

//        private string typeField;

//        private string idField;

//        private string nameField;

//        private bool isAbstractField;

//        private bool isAbstractFieldSpecified;

//        private bool isActiveField;

//        private bool isActiveFieldSpecified;

//        private string classifierBehaviorField;

//        private bool isLeafField;

//        private bool isLeafFieldSpecified;

//        private string id1Field;

//        private string idField1;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("appliedStereotypeInstance", typeof(packagedElementPackagedElementPackagedElementPackagedElementAppliedStereotypeInstance))]
//        [System.Xml.Serialization.XmlElement("client", typeof(packagedElementPackagedElementPackagedElementPackagedElementClient))]
//        [System.Xml.Serialization.XmlElement("elementImport", typeof(packagedElementPackagedElementPackagedElementPackagedElementElementImport))]
//        [System.Xml.Serialization.XmlElement("generalization", typeof(packagedElementPackagedElementPackagedElementPackagedElementGeneralization))]
//        [System.Xml.Serialization.XmlElement("Extension", typeof(Extension), Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        [System.Xml.Serialization.XmlElement("memberEnd", typeof(packagedElementPackagedElementPackagedElementPackagedElementMemberEnd))]
//        [System.Xml.Serialization.XmlElement("navigableOwnedEnd", typeof(packagedElementPackagedElementPackagedElementPackagedElementNavigableOwnedEnd))]
//        [System.Xml.Serialization.XmlElement("ownedAttribute", typeof(packagedElementPackagedElementPackagedElementPackagedElementOwnedAttribute))]
//        [System.Xml.Serialization.XmlElement("ownedBehavior", typeof(packagedElementPackagedElementPackagedElementPackagedElementOwnedBehavior))]
//        [System.Xml.Serialization.XmlElement("ownedComment", typeof(packagedElementPackagedElementPackagedElementPackagedElementOwnedComment))]
//        [System.Xml.Serialization.XmlElement("ownedConnector", typeof(packagedElementPackagedElementPackagedElementPackagedElementOwnedConnector))]
//        [System.Xml.Serialization.XmlElement("ownedEnd", typeof(packagedElementPackagedElementPackagedElementPackagedElementOwnedEnd))]
//        [System.Xml.Serialization.XmlElement("ownedLiteral", typeof(packagedElementPackagedElementPackagedElementPackagedElementOwnedLiteral))]
//        [System.Xml.Serialization.XmlElement("ownedOperation", typeof(packagedElementPackagedElementPackagedElementPackagedElementOwnedOperation))]
//        [System.Xml.Serialization.XmlElement("ownedRule", typeof(packagedElementPackagedElementPackagedElementPackagedElementOwnedRule))]
//        [System.Xml.Serialization.XmlElement("packagedElement", typeof(packagedElementPackagedElementPackagedElementPackagedElementPackagedElement))]
//        [System.Xml.Serialization.XmlElement("supplier", typeof(packagedElementPackagedElementPackagedElementPackagedElementSupplier))]
//        [System.Xml.Serialization.XmlElement("templateBinding", typeof(packagedElementPackagedElementPackagedElementPackagedElementTemplateBinding))]
//        [System.Xml.Serialization.XmlElement("when", typeof(packagedElementPackagedElementPackagedElementPackagedElementWhen))]
//        public object[] Items
//        {
//            get
//            {
//                return itemsField;
//            }
//            set
//            {
//                itemsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool isAbstract
//        {
//            get
//            {
//                return isAbstractField;
//            }
//            set
//            {
//                isAbstractField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool isAbstractSpecified
//        {
//            get
//            {
//                return isAbstractFieldSpecified;
//            }
//            set
//            {
//                isAbstractFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool isActive
//        {
//            get
//            {
//                return isActiveField;
//            }
//            set
//            {
//                isActiveField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool isActiveSpecified
//        {
//            get
//            {
//                return isActiveFieldSpecified;
//            }
//            set
//            {
//                isActiveFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string classifierBehavior
//        {
//            get
//            {
//                return classifierBehaviorField;
//            }
//            set
//            {
//                classifierBehaviorField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool isLeaf
//        {
//            get
//            {
//                return isLeafField;
//            }
//            set
//            {
//                isLeafField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool isLeafSpecified
//        {
//            get
//            {
//                return isLeafFieldSpecified;
//            }
//            set
//            {
//                isLeafFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("id", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id1
//        {
//            get
//            {
//                return id1Field;
//            }
//            set
//            {
//                id1Field = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementAppliedStereotypeInstance
//    {

//        private packagedElementPackagedElementPackagedElementPackagedElementAppliedStereotypeInstanceSlot[] slotField;

//        private packagedElementPackagedElementPackagedElementPackagedElementAppliedStereotypeInstanceClassifier classifierField;

//        private string idField;

//        private string idField1;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("slot")]
//        public packagedElementPackagedElementPackagedElementPackagedElementAppliedStereotypeInstanceSlot[] slot
//        {
//            get
//            {
//                return slotField;
//            }
//            set
//            {
//                slotField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementAppliedStereotypeInstanceClassifier classifier
//        {
//            get
//            {
//                return classifierField;
//            }
//            set
//            {
//                classifierField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementAppliedStereotypeInstanceSlot
//    {

//        private packagedElementPackagedElementPackagedElementPackagedElementAppliedStereotypeInstanceSlotDefiningFeature definingFeatureField;

//        private string idField;

//        private string idField1;

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementAppliedStereotypeInstanceSlotDefiningFeature definingFeature
//        {
//            get
//            {
//                return definingFeatureField;
//            }
//            set
//            {
//                definingFeatureField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementAppliedStereotypeInstanceSlotDefiningFeature
//    {

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementAppliedStereotypeInstanceClassifier
//    {

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementClient
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementElementImport
//    {

//        private packagedElementPackagedElementPackagedElementPackagedElementElementImportImportedElement importedElementField;

//        private string typeField;

//        private string idField;

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementElementImportImportedElement importedElement
//        {
//            get
//            {
//                return importedElementField;
//            }
//            set
//            {
//                importedElementField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementElementImportImportedElement
//    {

//        private Extension extensionField;

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public Extension Extension
//        {
//            get
//            {
//                return extensionField;
//            }
//            set
//            {
//                extensionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementGeneralization
//    {

//        private string typeField;

//        private string idField;

//        private string generalField;

//        private bool isSubstitutableField;

//        private bool isSubstitutableFieldSpecified;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string general
//        {
//            get
//            {
//                return generalField;
//            }
//            set
//            {
//                generalField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool isSubstitutable
//        {
//            get
//            {
//                return isSubstitutableField;
//            }
//            set
//            {
//                isSubstitutableField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool isSubstitutableSpecified
//        {
//            get
//            {
//                return isSubstitutableFieldSpecified;
//            }
//            set
//            {
//                isSubstitutableFieldSpecified = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementMemberEnd
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementNavigableOwnedEnd
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedAttribute
//    {

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeType typeField;

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeRedefinedProperty redefinedPropertyField;

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeSubsettedProperty subsettedPropertyField;

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeOwnedComment[] ownedCommentField;

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeLowerValue lowerValueField;

//        private Extension[] extensionField;

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeDefaultValue defaultValueField;

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeUpperValue upperValueField;

//        private string type1Field;

//        private string idField;

//        private string nameField;

//        private string visibilityField;

//        private string type2Field;

//        private string aggregationField;

//        private string associationField;

//        private bool isStaticField;

//        private bool isStaticFieldSpecified;

//        private bool isReadOnlyField;

//        private bool isReadOnlyFieldSpecified;

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeType type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeRedefinedProperty redefinedProperty
//        {
//            get
//            {
//                return redefinedPropertyField;
//            }
//            set
//            {
//                redefinedPropertyField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeSubsettedProperty subsettedProperty
//        {
//            get
//            {
//                return subsettedPropertyField;
//            }
//            set
//            {
//                subsettedPropertyField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("ownedComment")]
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeOwnedComment[] ownedComment
//        {
//            get
//            {
//                return ownedCommentField;
//            }
//            set
//            {
//                ownedCommentField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeLowerValue lowerValue
//        {
//            get
//            {
//                return lowerValueField;
//            }
//            set
//            {
//                lowerValueField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("Extension", Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public Extension[] Extension
//        {
//            get
//            {
//                return extensionField;
//            }
//            set
//            {
//                extensionField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeDefaultValue defaultValue
//        {
//            get
//            {
//                return defaultValueField;
//            }
//            set
//            {
//                defaultValueField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeUpperValue upperValue
//        {
//            get
//            {
//                return upperValueField;
//            }
//            set
//            {
//                upperValueField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("type", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type1
//        {
//            get
//            {
//                return type1Field;
//            }
//            set
//            {
//                type1Field = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("type")]
//        public string type2
//        {
//            get
//            {
//                return type2Field;
//            }
//            set
//            {
//                type2Field = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string aggregation
//        {
//            get
//            {
//                return aggregationField;
//            }
//            set
//            {
//                aggregationField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string association
//        {
//            get
//            {
//                return associationField;
//            }
//            set
//            {
//                associationField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool isStatic
//        {
//            get
//            {
//                return isStaticField;
//            }
//            set
//            {
//                isStaticField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool isStaticSpecified
//        {
//            get
//            {
//                return isStaticFieldSpecified;
//            }
//            set
//            {
//                isStaticFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool isReadOnly
//        {
//            get
//            {
//                return isReadOnlyField;
//            }
//            set
//            {
//                isReadOnlyField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool isReadOnlySpecified
//        {
//            get
//            {
//                return isReadOnlyFieldSpecified;
//            }
//            set
//            {
//                isReadOnlyFieldSpecified = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeType
//    {

//        private Extension extensionField;

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public Extension Extension
//        {
//            get
//            {
//                return extensionField;
//            }
//            set
//            {
//                extensionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeRedefinedProperty
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeSubsettedProperty
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeOwnedComment
//    {

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeOwnedCommentOwnedComment ownedCommentField;

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeOwnedCommentAnnotatedElement annotatedElementField;

//        private string typeField;

//        private string idField;

//        private string bodyField;

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeOwnedCommentOwnedComment ownedComment
//        {
//            get
//            {
//                return ownedCommentField;
//            }
//            set
//            {
//                ownedCommentField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeOwnedCommentAnnotatedElement annotatedElement
//        {
//            get
//            {
//                return annotatedElementField;
//            }
//            set
//            {
//                annotatedElementField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string body
//        {
//            get
//            {
//                return bodyField;
//            }
//            set
//            {
//                bodyField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeOwnedCommentOwnedComment
//    {

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeOwnedCommentOwnedCommentAnnotatedElement annotatedElementField;

//        private string typeField;

//        private string idField;

//        private string bodyField;

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeOwnedCommentOwnedCommentAnnotatedElement annotatedElement
//        {
//            get
//            {
//                return annotatedElementField;
//            }
//            set
//            {
//                annotatedElementField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string body
//        {
//            get
//            {
//                return bodyField;
//            }
//            set
//            {
//                bodyField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeOwnedCommentOwnedCommentAnnotatedElement
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeOwnedCommentAnnotatedElement
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeLowerValue
//    {

//        private string typeField;

//        private string idField;

//        private byte valueField;

//        private bool valueFieldSpecified;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public byte value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool valueSpecified
//        {
//            get
//            {
//                return valueFieldSpecified;
//            }
//            set
//            {
//                valueFieldSpecified = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeDefaultValue
//    {

//        private string bodyField;

//        private string languageField;

//        private string typeField;

//        private string idField;

//        private string instanceField;

//        private string valueField;

//        /// <remarks/>
//        public string body
//        {
//            get
//            {
//                return bodyField;
//            }
//            set
//            {
//                bodyField = value;
//            }
//        }

//        /// <remarks/>
//        public string language
//        {
//            get
//            {
//                return languageField;
//            }
//            set
//            {
//                languageField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string instance
//        {
//            get
//            {
//                return instanceField;
//            }
//            set
//            {
//                instanceField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeUpperValue
//    {

//        private string typeField;

//        private string idField;

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedBehavior
//    {

//        private object[] itemsField;

//        private string typeField;

//        private string idField;

//        private string nameField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("fragment", typeof(packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorFragment))]
//        [System.Xml.Serialization.XmlElement("Extension", typeof(Extension), Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        [System.Xml.Serialization.XmlElement("lifeline", typeof(packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorLifeline))]
//        [System.Xml.Serialization.XmlElement("message", typeof(packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorMessage))]
//        [System.Xml.Serialization.XmlElement("observation", typeof(packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorObservation))]
//        [System.Xml.Serialization.XmlElement("ownedAttribute", typeof(packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorOwnedAttribute))]
//        [System.Xml.Serialization.XmlElement("ownedRule", typeof(packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorOwnedRule))]
//        [System.Xml.Serialization.XmlElement("region", typeof(packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorRegion))]
//        public object[] Items
//        {
//            get
//            {
//                return itemsField;
//            }
//            set
//            {
//                itemsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorFragment
//    {

//        private Extension extensionField;

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorFragmentCovered coveredField;

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorFragmentInvariant invariantField;

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorFragmentOperand operandField;

//        private string typeField;

//        private string idField;

//        private string visibilityField;

//        private string messageField;

//        private string interactionOperatorField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public Extension Extension
//        {
//            get
//            {
//                return extensionField;
//            }
//            set
//            {
//                extensionField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorFragmentCovered covered
//        {
//            get
//            {
//                return coveredField;
//            }
//            set
//            {
//                coveredField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorFragmentInvariant invariant
//        {
//            get
//            {
//                return invariantField;
//            }
//            set
//            {
//                invariantField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorFragmentOperand operand
//        {
//            get
//            {
//                return operandField;
//            }
//            set
//            {
//                operandField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string message
//        {
//            get
//            {
//                return messageField;
//            }
//            set
//            {
//                messageField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string interactionOperator
//        {
//            get
//            {
//                return interactionOperatorField;
//            }
//            set
//            {
//                interactionOperatorField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorFragmentCovered
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorFragmentInvariant
//    {

//        private Extension extensionField;

//        private string typeField;

//        private string idField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public Extension Extension
//        {
//            get
//            {
//                return extensionField;
//            }
//            set
//            {
//                extensionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorFragmentOperand
//    {

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorFragmentOperandFragment[] fragmentField;

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorFragmentOperandGuard guardField;

//        private string typeField;

//        private string idField;

//        private string visibilityField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("fragment")]
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorFragmentOperandFragment[] fragment
//        {
//            get
//            {
//                return fragmentField;
//            }
//            set
//            {
//                fragmentField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorFragmentOperandGuard guard
//        {
//            get
//            {
//                return guardField;
//            }
//            set
//            {
//                guardField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorFragmentOperandFragment
//    {

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorFragmentOperandFragmentCovered coveredField;

//        private string typeField;

//        private string idField;

//        private string visibilityField;

//        private string messageField;

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorFragmentOperandFragmentCovered covered
//        {
//            get
//            {
//                return coveredField;
//            }
//            set
//            {
//                coveredField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string message
//        {
//            get
//            {
//                return messageField;
//            }
//            set
//            {
//                messageField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorFragmentOperandFragmentCovered
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorFragmentOperandGuard
//    {

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorFragmentOperandGuardSpecification specificationField;

//        private string typeField;

//        private string idField;

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorFragmentOperandGuardSpecification specification
//        {
//            get
//            {
//                return specificationField;
//            }
//            set
//            {
//                specificationField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorFragmentOperandGuardSpecification
//    {

//        private string typeField;

//        private string idField;

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorLifeline
//    {

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorLifelineCoveredBy[] coveredByField;

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorLifelineOwnedComment[] ownedCommentField;

//        private string typeField;

//        private string idField;

//        private string nameField;

//        private string visibilityField;

//        private string representsField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("coveredBy")]
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorLifelineCoveredBy[] coveredBy
//        {
//            get
//            {
//                return coveredByField;
//            }
//            set
//            {
//                coveredByField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("ownedComment")]
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorLifelineOwnedComment[] ownedComment
//        {
//            get
//            {
//                return ownedCommentField;
//            }
//            set
//            {
//                ownedCommentField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string represents
//        {
//            get
//            {
//                return representsField;
//            }
//            set
//            {
//                representsField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorLifelineCoveredBy
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorLifelineOwnedComment
//    {

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorLifelineOwnedCommentAnnotatedElement annotatedElementField;

//        private string typeField;

//        private string idField;

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorLifelineOwnedCommentAnnotatedElement annotatedElement
//        {
//            get
//            {
//                return annotatedElementField;
//            }
//            set
//            {
//                annotatedElementField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorLifelineOwnedCommentAnnotatedElement
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorMessage
//    {

//        private Extension extensionField;

//        private string typeField;

//        private string idField;

//        private string nameField;

//        private string visibilityField;

//        private string receiveEventField;

//        private string sendEventField;

//        private string messageSortField;

//        private string signatureField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public Extension Extension
//        {
//            get
//            {
//                return extensionField;
//            }
//            set
//            {
//                extensionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string receiveEvent
//        {
//            get
//            {
//                return receiveEventField;
//            }
//            set
//            {
//                receiveEventField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string sendEvent
//        {
//            get
//            {
//                return sendEventField;
//            }
//            set
//            {
//                sendEventField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string messageSort
//        {
//            get
//            {
//                return messageSortField;
//            }
//            set
//            {
//                messageSortField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string signature
//        {
//            get
//            {
//                return signatureField;
//            }
//            set
//            {
//                signatureField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorObservation
//    {

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorObservationEvent[] eventField;

//        private string typeField;

//        private string idField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("event")]
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorObservationEvent[] @event
//        {
//            get
//            {
//                return eventField;
//            }
//            set
//            {
//                eventField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorObservationEvent
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorOwnedAttribute
//    {

//        private string typeField;

//        private string idField;

//        private string nameField;

//        private string visibilityField;

//        private string type1Field;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("type")]
//        public string type1
//        {
//            get
//            {
//                return type1Field;
//            }
//            set
//            {
//                type1Field = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorOwnedRule
//    {

//        private bool[] firstEventField;

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorOwnedRuleConstrainedElement[] constrainedElementField;

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorOwnedRuleSpecification specificationField;

//        private string typeField;

//        private string idField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("firstEvent")]
//        public bool[] firstEvent
//        {
//            get
//            {
//                return firstEventField;
//            }
//            set
//            {
//                firstEventField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("constrainedElement")]
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorOwnedRuleConstrainedElement[] constrainedElement
//        {
//            get
//            {
//                return constrainedElementField;
//            }
//            set
//            {
//                constrainedElementField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorOwnedRuleSpecification specification
//        {
//            get
//            {
//                return specificationField;
//            }
//            set
//            {
//                specificationField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorOwnedRuleConstrainedElement
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorOwnedRuleSpecification
//    {

//        private string typeField;

//        private string idField;

//        private string maxField;

//        private string minField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string max
//        {
//            get
//            {
//                return maxField;
//            }
//            set
//            {
//                maxField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string min
//        {
//            get
//            {
//                return minField;
//            }
//            set
//            {
//                minField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorRegion
//    {

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorRegionSubvertex[] subvertexField;

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorRegionTransition[] transitionField;

//        private string typeField;

//        private string idField;

//        private string nameField;

//        private string visibilityField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("subvertex")]
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorRegionSubvertex[] subvertex
//        {
//            get
//            {
//                return subvertexField;
//            }
//            set
//            {
//                subvertexField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("transition")]
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorRegionTransition[] transition
//        {
//            get
//            {
//                return transitionField;
//            }
//            set
//            {
//                transitionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorRegionSubvertex
//    {

//        private string typeField;

//        private string idField;

//        private string nameField;

//        private string visibilityField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedBehaviorRegionTransition
//    {

//        private string typeField;

//        private string idField;

//        private string visibilityField;

//        private string sourceField;

//        private string targetField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string source
//        {
//            get
//            {
//                return sourceField;
//            }
//            set
//            {
//                sourceField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string target
//        {
//            get
//            {
//                return targetField;
//            }
//            set
//            {
//                targetField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedComment
//    {

//        private object[] itemsField;

//        private string typeField;

//        private string idField;

//        private string bodyField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("annotatedElement", typeof(packagedElementPackagedElementPackagedElementPackagedElementOwnedCommentAnnotatedElement))]
//        [System.Xml.Serialization.XmlElement("ownedComment", typeof(packagedElementPackagedElementPackagedElementPackagedElementOwnedCommentOwnedComment))]
//        public object[] Items
//        {
//            get
//            {
//                return itemsField;
//            }
//            set
//            {
//                itemsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string body
//        {
//            get
//            {
//                return bodyField;
//            }
//            set
//            {
//                bodyField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedCommentAnnotatedElement
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedCommentOwnedComment
//    {

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedCommentOwnedCommentAnnotatedElement annotatedElementField;

//        private string typeField;

//        private string idField;

//        private string bodyField;

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedCommentOwnedCommentAnnotatedElement annotatedElement
//        {
//            get
//            {
//                return annotatedElementField;
//            }
//            set
//            {
//                annotatedElementField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string body
//        {
//            get
//            {
//                return bodyField;
//            }
//            set
//            {
//                bodyField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedCommentOwnedCommentAnnotatedElement
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedConnector
//    {

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedConnectorEnd[] endField;

//        private string typeField;

//        private string idField;

//        private string visibilityField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("end")]
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedConnectorEnd[] end
//        {
//            get
//            {
//                return endField;
//            }
//            set
//            {
//                endField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedConnectorEnd
//    {

//        private string typeField;

//        private string idField;

//        private string roleField;

//        private string partWithPortField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string role
//        {
//            get
//            {
//                return roleField;
//            }
//            set
//            {
//                roleField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string partWithPort
//        {
//            get
//            {
//                return partWithPortField;
//            }
//            set
//            {
//                partWithPortField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedEnd
//    {

//        private Extension[] extensionField;

//        private string typeField;

//        private string idField;

//        private string visibilityField;

//        private string type1Field;

//        private string associationField;

//        private string nameField;

//        private string aggregationField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("Extension", Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public Extension[] Extension
//        {
//            get
//            {
//                return extensionField;
//            }
//            set
//            {
//                extensionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("type")]
//        public string type1
//        {
//            get
//            {
//                return type1Field;
//            }
//            set
//            {
//                type1Field = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string association
//        {
//            get
//            {
//                return associationField;
//            }
//            set
//            {
//                associationField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string aggregation
//        {
//            get
//            {
//                return aggregationField;
//            }
//            set
//            {
//                aggregationField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedLiteral
//    {

//        private string typeField;

//        private string idField;

//        private string nameField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedOperation
//    {

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedOperationOwnedComment ownedCommentField;

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedOperationOwnedParameter[] ownedParameterField;

//        private string typeField;

//        private string idField;

//        private string nameField;

//        private string visibilityField;

//        private bool isQueryField;

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedOperationOwnedComment ownedComment
//        {
//            get
//            {
//                return ownedCommentField;
//            }
//            set
//            {
//                ownedCommentField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("ownedParameter")]
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedOperationOwnedParameter[] ownedParameter
//        {
//            get
//            {
//                return ownedParameterField;
//            }
//            set
//            {
//                ownedParameterField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool isQuery
//        {
//            get
//            {
//                return isQueryField;
//            }
//            set
//            {
//                isQueryField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedOperationOwnedComment
//    {

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedOperationOwnedCommentAnnotatedElement annotatedElementField;

//        private string typeField;

//        private string idField;

//        private string bodyField;

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedOperationOwnedCommentAnnotatedElement annotatedElement
//        {
//            get
//            {
//                return annotatedElementField;
//            }
//            set
//            {
//                annotatedElementField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string body
//        {
//            get
//            {
//                return bodyField;
//            }
//            set
//            {
//                bodyField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedOperationOwnedCommentAnnotatedElement
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedOperationOwnedParameter
//    {

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedOperationOwnedParameterOwnedComment ownedCommentField;

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedOperationOwnedParameterLowerValue lowerValueField;

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedOperationOwnedParameterUpperValue upperValueField;

//        private Extension extensionField;

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedOperationOwnedParameterDefaultValue defaultValueField;

//        private string typeField;

//        private string idField;

//        private string nameField;

//        private string visibilityField;

//        private string type1Field;

//        private string directionField;

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedOperationOwnedParameterOwnedComment ownedComment
//        {
//            get
//            {
//                return ownedCommentField;
//            }
//            set
//            {
//                ownedCommentField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedOperationOwnedParameterLowerValue lowerValue
//        {
//            get
//            {
//                return lowerValueField;
//            }
//            set
//            {
//                lowerValueField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedOperationOwnedParameterUpperValue upperValue
//        {
//            get
//            {
//                return upperValueField;
//            }
//            set
//            {
//                upperValueField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public Extension Extension
//        {
//            get
//            {
//                return extensionField;
//            }
//            set
//            {
//                extensionField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedOperationOwnedParameterDefaultValue defaultValue
//        {
//            get
//            {
//                return defaultValueField;
//            }
//            set
//            {
//                defaultValueField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("type")]
//        public string type1
//        {
//            get
//            {
//                return type1Field;
//            }
//            set
//            {
//                type1Field = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string direction
//        {
//            get
//            {
//                return directionField;
//            }
//            set
//            {
//                directionField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedOperationOwnedParameterOwnedComment
//    {

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedOperationOwnedParameterOwnedCommentAnnotatedElement annotatedElementField;

//        private string typeField;

//        private string idField;

//        private string bodyField;

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedOperationOwnedParameterOwnedCommentAnnotatedElement annotatedElement
//        {
//            get
//            {
//                return annotatedElementField;
//            }
//            set
//            {
//                annotatedElementField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string body
//        {
//            get
//            {
//                return bodyField;
//            }
//            set
//            {
//                bodyField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedOperationOwnedParameterOwnedCommentAnnotatedElement
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedOperationOwnedParameterLowerValue
//    {

//        private string typeField;

//        private string idField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedOperationOwnedParameterUpperValue
//    {

//        private string typeField;

//        private string idField;

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedOperationOwnedParameterDefaultValue
//    {

//        private string bodyField;

//        private string languageField;

//        private string typeField;

//        private string idField;

//        private string valueField;

//        /// <remarks/>
//        public string body
//        {
//            get
//            {
//                return bodyField;
//            }
//            set
//            {
//                bodyField = value;
//            }
//        }

//        /// <remarks/>
//        public string language
//        {
//            get
//            {
//                return languageField;
//            }
//            set
//            {
//                languageField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedRule
//    {

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedRuleConstrainedElement[] constrainedElementField;

//        private packagedElementPackagedElementPackagedElementPackagedElementOwnedRuleSpecification specificationField;

//        private string typeField;

//        private string idField;

//        private string nameField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("constrainedElement")]
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedRuleConstrainedElement[] constrainedElement
//        {
//            get
//            {
//                return constrainedElementField;
//            }
//            set
//            {
//                constrainedElementField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementOwnedRuleSpecification specification
//        {
//            get
//            {
//                return specificationField;
//            }
//            set
//            {
//                specificationField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedRuleConstrainedElement
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementOwnedRuleSpecification
//    {

//        private string bodyField;

//        private string languageField;

//        private string typeField;

//        private string idField;

//        /// <remarks/>
//        public string body
//        {
//            get
//            {
//                return bodyField;
//            }
//            set
//            {
//                bodyField = value;
//            }
//        }

//        /// <remarks/>
//        public string language
//        {
//            get
//            {
//                return languageField;
//            }
//            set
//            {
//                languageField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementPackagedElement
//    {

//        private object[] itemsField;

//        private string typeField;

//        private string idField;

//        private string nameField;

//        private bool isAbstractField;

//        private bool isAbstractFieldSpecified;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("classifier", typeof(packagedElementPackagedElementPackagedElementPackagedElementPackagedElementClassifier))]
//        [System.Xml.Serialization.XmlElement("generalization", typeof(packagedElementPackagedElementPackagedElementPackagedElementPackagedElementGeneralization))]
//        [System.Xml.Serialization.XmlElement("Extension", typeof(Extension), Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        [System.Xml.Serialization.XmlElement("memberEnd", typeof(packagedElementPackagedElementPackagedElementPackagedElementPackagedElementMemberEnd))]
//        [System.Xml.Serialization.XmlElement("ownedAttribute", typeof(packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedAttribute))]
//        [System.Xml.Serialization.XmlElement("ownedComment", typeof(packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedComment))]
//        [System.Xml.Serialization.XmlElement("ownedConnector", typeof(packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedConnector))]
//        [System.Xml.Serialization.XmlElement("ownedEnd", typeof(packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedEnd))]
//        [System.Xml.Serialization.XmlElement("ownedRule", typeof(packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedRule))]
//        [System.Xml.Serialization.XmlElement("slot", typeof(packagedElementPackagedElementPackagedElementPackagedElementPackagedElementSlot))]
//        public object[] Items
//        {
//            get
//            {
//                return itemsField;
//            }
//            set
//            {
//                itemsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool isAbstract
//        {
//            get
//            {
//                return isAbstractField;
//            }
//            set
//            {
//                isAbstractField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool isAbstractSpecified
//        {
//            get
//            {
//                return isAbstractFieldSpecified;
//            }
//            set
//            {
//                isAbstractFieldSpecified = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementPackagedElementClassifier
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementPackagedElementGeneralization
//    {

//        private string typeField;

//        private string idField;

//        private string generalField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string general
//        {
//            get
//            {
//                return generalField;
//            }
//            set
//            {
//                generalField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementPackagedElementMemberEnd
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedAttribute
//    {

//        private packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeOwnedComment ownedCommentField;

//        private packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeLowerValue lowerValueField;

//        private packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeUpperValue upperValueField;

//        private packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeType typeField;

//        private packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeRedefinedProperty redefinedPropertyField;

//        private Extension[] extensionField;

//        private packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeDefaultValue defaultValueField;

//        private string type1Field;

//        private string idField;

//        private string nameField;

//        private string aggregationField;

//        private string type2Field;

//        private string visibilityField;

//        private string associationField;

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeOwnedComment ownedComment
//        {
//            get
//            {
//                return ownedCommentField;
//            }
//            set
//            {
//                ownedCommentField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeLowerValue lowerValue
//        {
//            get
//            {
//                return lowerValueField;
//            }
//            set
//            {
//                lowerValueField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeUpperValue upperValue
//        {
//            get
//            {
//                return upperValueField;
//            }
//            set
//            {
//                upperValueField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeType type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeRedefinedProperty redefinedProperty
//        {
//            get
//            {
//                return redefinedPropertyField;
//            }
//            set
//            {
//                redefinedPropertyField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("Extension", Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public Extension[] Extension
//        {
//            get
//            {
//                return extensionField;
//            }
//            set
//            {
//                extensionField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeDefaultValue defaultValue
//        {
//            get
//            {
//                return defaultValueField;
//            }
//            set
//            {
//                defaultValueField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("type", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type1
//        {
//            get
//            {
//                return type1Field;
//            }
//            set
//            {
//                type1Field = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string aggregation
//        {
//            get
//            {
//                return aggregationField;
//            }
//            set
//            {
//                aggregationField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("type")]
//        public string type2
//        {
//            get
//            {
//                return type2Field;
//            }
//            set
//            {
//                type2Field = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string association
//        {
//            get
//            {
//                return associationField;
//            }
//            set
//            {
//                associationField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeOwnedComment
//    {

//        private packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeOwnedCommentAnnotatedElement annotatedElementField;

//        private string typeField;

//        private string idField;

//        private string bodyField;

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeOwnedCommentAnnotatedElement annotatedElement
//        {
//            get
//            {
//                return annotatedElementField;
//            }
//            set
//            {
//                annotatedElementField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string body
//        {
//            get
//            {
//                return bodyField;
//            }
//            set
//            {
//                bodyField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeOwnedCommentAnnotatedElement
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeLowerValue
//    {

//        private string typeField;

//        private string idField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeUpperValue
//    {

//        private string typeField;

//        private string idField;

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeType
//    {

//        private Extension extensionField;

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public Extension Extension
//        {
//            get
//            {
//                return extensionField;
//            }
//            set
//            {
//                extensionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeRedefinedProperty
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedAttributeDefaultValue
//    {

//        private string bodyField;

//        private string languageField;

//        private string typeField;

//        private string idField;

//        private string instanceField;

//        /// <remarks/>
//        public string body
//        {
//            get
//            {
//                return bodyField;
//            }
//            set
//            {
//                bodyField = value;
//            }
//        }

//        /// <remarks/>
//        public string language
//        {
//            get
//            {
//                return languageField;
//            }
//            set
//            {
//                languageField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string instance
//        {
//            get
//            {
//                return instanceField;
//            }
//            set
//            {
//                instanceField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedComment
//    {

//        private packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedCommentOwnedComment ownedCommentField;

//        private packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedCommentAnnotatedElement annotatedElementField;

//        private string typeField;

//        private string idField;

//        private string bodyField;

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedCommentOwnedComment ownedComment
//        {
//            get
//            {
//                return ownedCommentField;
//            }
//            set
//            {
//                ownedCommentField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedCommentAnnotatedElement annotatedElement
//        {
//            get
//            {
//                return annotatedElementField;
//            }
//            set
//            {
//                annotatedElementField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string body
//        {
//            get
//            {
//                return bodyField;
//            }
//            set
//            {
//                bodyField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedCommentOwnedComment
//    {

//        private packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedCommentOwnedCommentAnnotatedElement annotatedElementField;

//        private string typeField;

//        private string idField;

//        private string bodyField;

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedCommentOwnedCommentAnnotatedElement annotatedElement
//        {
//            get
//            {
//                return annotatedElementField;
//            }
//            set
//            {
//                annotatedElementField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string body
//        {
//            get
//            {
//                return bodyField;
//            }
//            set
//            {
//                bodyField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedCommentOwnedCommentAnnotatedElement
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedCommentAnnotatedElement
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedConnector
//    {

//        private packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedConnectorEnd[] endField;

//        private string typeField;

//        private string idField;

//        private string visibilityField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("end")]
//        public packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedConnectorEnd[] end
//        {
//            get
//            {
//                return endField;
//            }
//            set
//            {
//                endField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedConnectorEnd
//    {

//        private string typeField;

//        private string idField;

//        private string roleField;

//        private string partWithPortField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string role
//        {
//            get
//            {
//                return roleField;
//            }
//            set
//            {
//                roleField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string partWithPort
//        {
//            get
//            {
//                return partWithPortField;
//            }
//            set
//            {
//                partWithPortField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedEnd
//    {

//        private string typeField;

//        private string idField;

//        private string visibilityField;

//        private string type1Field;

//        private string associationField;

//        private string nameField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("type")]
//        public string type1
//        {
//            get
//            {
//                return type1Field;
//            }
//            set
//            {
//                type1Field = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string association
//        {
//            get
//            {
//                return associationField;
//            }
//            set
//            {
//                associationField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedRule
//    {

//        private packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedRuleConstrainedElement constrainedElementField;

//        private packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedRuleSpecification specificationField;

//        private string typeField;

//        private string idField;

//        private string nameField;

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedRuleConstrainedElement constrainedElement
//        {
//            get
//            {
//                return constrainedElementField;
//            }
//            set
//            {
//                constrainedElementField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedRuleSpecification specification
//        {
//            get
//            {
//                return specificationField;
//            }
//            set
//            {
//                specificationField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedRuleConstrainedElement
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementPackagedElementOwnedRuleSpecification
//    {

//        private string bodyField;

//        private string languageField;

//        private string typeField;

//        private string idField;

//        /// <remarks/>
//        public string body
//        {
//            get
//            {
//                return bodyField;
//            }
//            set
//            {
//                bodyField = value;
//            }
//        }

//        /// <remarks/>
//        public string language
//        {
//            get
//            {
//                return languageField;
//            }
//            set
//            {
//                languageField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementPackagedElementSlot
//    {

//        private packagedElementPackagedElementPackagedElementPackagedElementPackagedElementSlotValue valueField;

//        private string typeField;

//        private string idField;

//        private string definingFeatureField;

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementPackagedElementSlotValue value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string definingFeature
//        {
//            get
//            {
//                return definingFeatureField;
//            }
//            set
//            {
//                definingFeatureField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementPackagedElementSlotValue
//    {

//        private packagedElementPackagedElementPackagedElementPackagedElementPackagedElementSlotValueInstance instanceField;

//        private string typeField;

//        private string idField;

//        private string instance1Field;

//        private decimal valueField;

//        private bool valueFieldSpecified;

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementPackagedElementSlotValueInstance instance
//        {
//            get
//            {
//                return instanceField;
//            }
//            set
//            {
//                instanceField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("instance")]
//        public string instance1
//        {
//            get
//            {
//                return instance1Field;
//            }
//            set
//            {
//                instance1Field = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public decimal value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool valueSpecified
//        {
//            get
//            {
//                return valueFieldSpecified;
//            }
//            set
//            {
//                valueFieldSpecified = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementPackagedElementSlotValueInstance
//    {

//        private Extension extensionField;

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public Extension Extension
//        {
//            get
//            {
//                return extensionField;
//            }
//            set
//            {
//                extensionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementSupplier
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementTemplateBinding
//    {

//        private packagedElementPackagedElementPackagedElementPackagedElementTemplateBindingParameterSubstitution[] parameterSubstitutionField;

//        private string typeField;

//        private string idField;

//        private string signatureField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("parameterSubstitution")]
//        public packagedElementPackagedElementPackagedElementPackagedElementTemplateBindingParameterSubstitution[] parameterSubstitution
//        {
//            get
//            {
//                return parameterSubstitutionField;
//            }
//            set
//            {
//                parameterSubstitutionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string signature
//        {
//            get
//            {
//                return signatureField;
//            }
//            set
//            {
//                signatureField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementTemplateBindingParameterSubstitution
//    {

//        private string typeField;

//        private string idField;

//        private string actualField;

//        private string formalField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string actual
//        {
//            get
//            {
//                return actualField;
//            }
//            set
//            {
//                actualField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string formal
//        {
//            get
//            {
//                return formalField;
//            }
//            set
//            {
//                formalField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementWhen
//    {

//        private packagedElementPackagedElementPackagedElementPackagedElementWhenExpr exprField;

//        private string typeField;

//        private string idField;

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementWhenExpr expr
//        {
//            get
//            {
//                return exprField;
//            }
//            set
//            {
//                exprField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementWhenExpr
//    {

//        private packagedElementPackagedElementPackagedElementPackagedElementWhenExprObservation observationField;

//        private packagedElementPackagedElementPackagedElementPackagedElementWhenExprExpr exprField;

//        private string typeField;

//        private string idField;

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementWhenExprObservation observation
//        {
//            get
//            {
//                return observationField;
//            }
//            set
//            {
//                observationField = value;
//            }
//        }

//        /// <remarks/>
//        public packagedElementPackagedElementPackagedElementPackagedElementWhenExprExpr expr
//        {
//            get
//            {
//                return exprField;
//            }
//            set
//            {
//                exprField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementWhenExprObservation
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementPackagedElementWhenExprExpr
//    {

//        private string typeField;

//        private string idField;

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementSlot
//    {

//        private packagedElementPackagedElementPackagedElementSlotValue[] valueField;

//        private string typeField;

//        private string idField;

//        private string definingFeatureField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("value")]
//        public packagedElementPackagedElementPackagedElementSlotValue[] value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string definingFeature
//        {
//            get
//            {
//                return definingFeatureField;
//            }
//            set
//            {
//                definingFeatureField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementSlotValue
//    {

//        private string typeField;

//        private string idField;

//        private string instanceField;

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string instance
//        {
//            get
//            {
//                return instanceField;
//            }
//            set
//            {
//                instanceField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementPackagedElementSupplier
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class packagedElementPackagedElementSupplier
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
//    public partial class profileApplication
//    {

//        private profileApplicationAppliedProfile appliedProfileField;

//        private string typeField;

//        private string idField;

//        /// <remarks/>
//        public profileApplicationAppliedProfile appliedProfile
//        {
//            get
//            {
//                return appliedProfileField;
//            }
//            set
//            {
//                appliedProfileField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class profileApplicationAppliedProfile
//    {

//        private Extension extensionField;

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public Extension Extension
//        {
//            get
//            {
//                return extensionField;
//            }
//            set
//            {
//                extensionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//    public partial class XMIDocumentation
//    {

//        private string exporterField;

//        private string exporterVersionField;

//        /// <remarks/>
//        public string exporter
//        {
//            get
//            {
//                return exporterField;
//            }
//            set
//            {
//                exporterField = value;
//            }
//        }

//        /// <remarks/>
//        public string exporterVersion
//        {
//            get
//            {
//                return exporterVersionField;
//            }
//            set
//            {
//                exporterVersionField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//    public partial class XMIExtension
//    {

//        private filePart filePartField;

//        private stereotypesHREFS stereotypesHREFSField;

//        private plugin[] pluginField;

//        private req_resource[] req_resourceField;

//        private string extenderField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "")]
//        public filePart filePart
//        {
//            get
//            {
//                return filePartField;
//            }
//            set
//            {
//                filePartField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "")]
//        public stereotypesHREFS stereotypesHREFS
//        {
//            get
//            {
//                return stereotypesHREFSField;
//            }
//            set
//            {
//                stereotypesHREFSField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("plugin", Namespace = "")]
//        public plugin[] plugin
//        {
//            get
//            {
//                return pluginField;
//            }
//            set
//            {
//                pluginField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("req_resource", Namespace = "")]
//        public req_resource[] req_resource
//        {
//            get
//            {
//                return req_resourceField;
//            }
//            set
//            {
//                req_resourceField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string extender
//        {
//            get
//            {
//                return extenderField;
//            }
//            set
//            {
//                extenderField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
//    public partial class filePart
//    {

//        private Model modelField;

//        private Package packageField;

//        private PrivateDependenciesContainer privateDependenciesContainerField;

//        private UserProjectOptions userProjectOptionsField;

//        private CommonProjectOptions commonProjectOptionsField;

//        private SnapshotInfoContainer snapshotInfoContainerField;

//        private XMI1 xMIField;

//        private filePartMdElement[] mdOwnedViewsField;

//        private Project projectField;

//        private string[] textField;

//        private string nameField;

//        private string typeField;

//        private string headerField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "http://www.nomagic.com/magicdraw/UML/2.5.1")]
//        public Model Model
//        {
//            get
//            {
//                return modelField;
//            }
//            set
//            {
//                modelField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "http://www.nomagic.com/magicdraw/UML/2.5.1")]
//        public Package Package
//        {
//            get
//            {
//                return packageField;
//            }
//            set
//            {
//                packageField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "http://www.nomagic.com/ns/cameo/client/snapshot/1.0")]
//        public PrivateDependenciesContainer PrivateDependenciesContainer
//        {
//            get
//            {
//                return privateDependenciesContainerField;
//            }
//            set
//            {
//                privateDependenciesContainerField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "http://www.nomagic.com/ns/magicdraw/core/project/options/1.0")]
//        public UserProjectOptions UserProjectOptions
//        {
//            get
//            {
//                return userProjectOptionsField;
//            }
//            set
//            {
//                userProjectOptionsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "http://www.nomagic.com/ns/magicdraw/core/project/options/1.0")]
//        public CommonProjectOptions CommonProjectOptions
//        {
//            get
//            {
//                return commonProjectOptionsField;
//            }
//            set
//            {
//                commonProjectOptionsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "http://www.nomagic.com/ns/cameo/client/snapshot/1.0")]
//        public SnapshotInfoContainer SnapshotInfoContainer
//        {
//            get
//            {
//                return snapshotInfoContainerField;
//            }
//            set
//            {
//                snapshotInfoContainerField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "http://www.omg.org/XMI")]
//        public XMI1 XMI
//        {
//            get
//            {
//                return xMIField;
//            }
//            set
//            {
//                xMIField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlArrayItem("mdElement", IsNullable = false)]
//        public filePartMdElement[] mdOwnedViews
//        {
//            get
//            {
//                return mdOwnedViewsField;
//            }
//            set
//            {
//                mdOwnedViewsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "http://www.nomagic.com/ns/cameo/client/project/1.0")]
//        public Project Project
//        {
//            get
//            {
//                return projectField;
//            }
//            set
//            {
//                projectField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlText()]
//        public string[] Text
//        {
//            get
//            {
//                return textField;
//            }
//            set
//            {
//                textField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string type
//        {
//            get
//            {
//                return typeField;
//            }
//            set
//            {
//                typeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string header
//        {
//            get
//            {
//                return headerField;
//            }
//            set
//            {
//                headerField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.nomagic.com/magicdraw/UML/2.5.1")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.nomagic.com/magicdraw/UML/2.5.1", IsNullable = false)]
//    public partial class Model
//    {

//        private decimal versionField;

//        private string idField;

//        private string idField1;

//        private string nameField;

//        private string visibilityField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public decimal version
//        {
//            get
//            {
//                return versionField;
//            }
//            set
//            {
//                versionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.nomagic.com/magicdraw/UML/2.5.1")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.nomagic.com/magicdraw/UML/2.5.1", IsNullable = false)]
//    public partial class Package
//    {

//        private owningPackage owningPackageField;

//        private appliedStereotypeInstance appliedStereotypeInstanceField;

//        private packagedElement[] packagedElementField;

//        private string idField;

//        private string idField1;

//        private string nameField;

//        private decimal versionField;

//        private bool versionFieldSpecified;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "")]
//        public owningPackage owningPackage
//        {
//            get
//            {
//                return owningPackageField;
//            }
//            set
//            {
//                owningPackageField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "")]
//        public appliedStereotypeInstance appliedStereotypeInstance
//        {
//            get
//            {
//                return appliedStereotypeInstanceField;
//            }
//            set
//            {
//                appliedStereotypeInstanceField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("packagedElement", Namespace = "")]
//        public packagedElement[] packagedElement
//        {
//            get
//            {
//                return packagedElementField;
//            }
//            set
//            {
//                packagedElementField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public decimal version
//        {
//            get
//            {
//                return versionField;
//            }
//            set
//            {
//                versionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool versionSpecified
//        {
//            get
//            {
//                return versionFieldSpecified;
//            }
//            set
//            {
//                versionFieldSpecified = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
//    public partial class owningPackage
//    {

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
//    public partial class appliedStereotypeInstance
//    {

//        private appliedStereotypeInstanceSlot slotField;

//        private appliedStereotypeInstanceClassifier[] classifierField;

//        private string idField;

//        private string idField1;

//        private string classifier1Field;

//        /// <remarks/>
//        public appliedStereotypeInstanceSlot slot
//        {
//            get
//            {
//                return slotField;
//            }
//            set
//            {
//                slotField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("classifier")]
//        public appliedStereotypeInstanceClassifier[] classifier
//        {
//            get
//            {
//                return classifierField;
//            }
//            set
//            {
//                classifierField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("classifier")]
//        public string classifier1
//        {
//            get
//            {
//                return classifier1Field;
//            }
//            set
//            {
//                classifier1Field = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class appliedStereotypeInstanceSlot
//    {

//        private appliedStereotypeInstanceSlotValue valueField;

//        private appliedStereotypeInstanceSlotDefiningFeature definingFeatureField;

//        private string idField;

//        private string idField1;

//        /// <remarks/>
//        public appliedStereotypeInstanceSlotValue value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }

//        /// <remarks/>
//        public appliedStereotypeInstanceSlotDefiningFeature definingFeature
//        {
//            get
//            {
//                return definingFeatureField;
//            }
//            set
//            {
//                definingFeatureField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class appliedStereotypeInstanceSlotValue
//    {

//        private string idField;

//        private string idField1;

//        private string visibilityField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string visibility
//        {
//            get
//            {
//                return visibilityField;
//            }
//            set
//            {
//                visibilityField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class appliedStereotypeInstanceSlotDefiningFeature
//    {

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class appliedStereotypeInstanceClassifier
//    {

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.nomagic.com/ns/cameo/client/snapshot/1.0")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.nomagic.com/ns/cameo/client/snapshot/1.0", IsNullable = false)]
//    public partial class PrivateDependenciesContainer
//    {

//        private referencedResources[] referencedResourcesField;

//        private decimal versionField;

//        private string idField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("referencedResources", Namespace = "")]
//        public referencedResources[] referencedResources
//        {
//            get
//            {
//                return referencedResourcesField;
//            }
//            set
//            {
//                referencedResourcesField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public decimal version
//        {
//            get
//            {
//                return versionField;
//            }
//            set
//            {
//                versionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
//    public partial class referencedResources
//    {

//        private string[] referencedObjectsField;

//        private string idField;

//        private string originalResourceURIField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("referencedObjects")]
//        public string[] referencedObjects
//        {
//            get
//            {
//                return referencedObjectsField;
//            }
//            set
//            {
//                referencedObjectsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string originalResourceURI
//        {
//            get
//            {
//                return originalResourceURIField;
//            }
//            set
//            {
//                originalResourceURIField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.nomagic.com/ns/magicdraw/core/project/options/1.0")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.nomagic.com/ns/magicdraw/core/project/options/1.0", IsNullable = false)]
//    public partial class UserProjectOptions
//    {

//        private decimal versionField;

//        private string idField;

//        private string optionsStringField;

//        private string diagramViewStyleStringField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public decimal version
//        {
//            get
//            {
//                return versionField;
//            }
//            set
//            {
//                versionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string optionsString
//        {
//            get
//            {
//                return optionsStringField;
//            }
//            set
//            {
//                optionsStringField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string diagramViewStyleString
//        {
//            get
//            {
//                return diagramViewStyleStringField;
//            }
//            set
//            {
//                diagramViewStyleStringField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.nomagic.com/ns/magicdraw/core/project/options/1.0")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.nomagic.com/ns/magicdraw/core/project/options/1.0", IsNullable = false)]
//    public partial class CommonProjectOptions
//    {

//        private decimal versionField;

//        private string idField;

//        private string optionsStringField;

//        private string modelElementStyleStringField;

//        private string symbolStylesStringField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public decimal version
//        {
//            get
//            {
//                return versionField;
//            }
//            set
//            {
//                versionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string optionsString
//        {
//            get
//            {
//                return optionsStringField;
//            }
//            set
//            {
//                optionsStringField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string modelElementStyleString
//        {
//            get
//            {
//                return modelElementStyleStringField;
//            }
//            set
//            {
//                modelElementStyleStringField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string symbolStylesString
//        {
//            get
//            {
//                return symbolStylesStringField;
//            }
//            set
//            {
//                symbolStylesStringField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.nomagic.com/ns/cameo/client/snapshot/1.0")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.nomagic.com/ns/cameo/client/snapshot/1.0", IsNullable = false)]
//    public partial class SnapshotInfoContainer
//    {

//        private snaphotDescriptors[] snaphotDescriptorsField;

//        private decimal versionField;

//        private string idField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("snaphotDescriptors", Namespace = "")]
//        public snaphotDescriptors[] snaphotDescriptors
//        {
//            get
//            {
//                return snaphotDescriptorsField;
//            }
//            set
//            {
//                snaphotDescriptorsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public decimal version
//        {
//            get
//            {
//                return versionField;
//            }
//            set
//            {
//                versionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
//    public partial class snaphotDescriptors
//    {

//        private string sharePointObjectsField;

//        private string idField;

//        private string originalResourceURIField;

//        /// <remarks/>
//        public string sharePointObjects
//        {
//            get
//            {
//                return sharePointObjectsField;
//            }
//            set
//            {
//                sharePointObjectsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string originalResourceURI
//        {
//            get
//            {
//                return originalResourceURIField;
//            }
//            set
//            {
//                originalResourceURIField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.omg.org/XMI")]
//    [System.Xml.Serialization.XmlRoot("XMI", Namespace = "http://www.omg.org/XMI", IsNullable = false)]
//    public partial class XMI1
//    {

//        private object[] itemsField;

//        private decimal versionField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("Package", typeof(Package), Namespace = "http://www.nomagic.com/magicdraw/UML/2.5.1")]
//        [System.Xml.Serialization.XmlElement("Profile", typeof(MTConnectProfile), Namespace = "http://www.nomagic.com/magicdraw/UML/2.5.1")]
//        [System.Xml.Serialization.XmlElement("Options", typeof(Options), Namespace = "http://www.nomagic.com/magicdraw/ce/rt/options/1")]
//        [System.Xml.Serialization.XmlElement("MDExtension", typeof(MDExtension), Namespace = "http://www.nomagic.com/magicdraw/foundation")]
//        public object[] Items
//        {
//            get
//            {
//                return itemsField;
//            }
//            set
//            {
//                itemsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
//        public decimal version
//        {
//            get
//            {
//                return versionField;
//            }
//            set
//            {
//                versionField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.nomagic.com/magicdraw/UML/2.5.1")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.nomagic.com/magicdraw/UML/2.5.1", IsNullable = false)]
//    public partial class MTConnectProfile
//    {

//        private owningPackage owningPackageField;

//        private appliedStereotypeInstance appliedStereotypeInstanceField;

//        private packagedElement[] packagedElementField;

//        private string idField;

//        private string idField1;

//        private string nameField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "")]
//        public owningPackage owningPackage
//        {
//            get
//            {
//                return owningPackageField;
//            }
//            set
//            {
//                owningPackageField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "")]
//        public appliedStereotypeInstance appliedStereotypeInstance
//        {
//            get
//            {
//                return appliedStereotypeInstanceField;
//            }
//            set
//            {
//                appliedStereotypeInstanceField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("packagedElement", Namespace = "")]
//        public packagedElement[] packagedElement
//        {
//            get
//            {
//                return packagedElementField;
//            }
//            set
//            {
//                packagedElementField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.nomagic.com/magicdraw/ce/rt/options/1")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.nomagic.com/magicdraw/ce/rt/options/1", IsNullable = false)]
//    public partial class Options
//    {

//        private string recentSourceRootsField;

//        private defaultWorkingPackage defaultWorkingPackageField;

//        private defaultImportedPackages defaultImportedPackagesField;

//        private string idField;

//        private string tempDirectoryField;

//        private string defaultWorkingDirectoryField;

//        private byte deletedElementGenerationOptionsField;

//        private byte analyseTypeField;

//        private bool visualizeModelField;

//        private byte spacesField;

//        private string defaultLanguageField;

//        private byte visualizationOptionField;

//        private byte codeGenerationReverseOptionField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "")]
//        public string recentSourceRoots
//        {
//            get
//            {
//                return recentSourceRootsField;
//            }
//            set
//            {
//                recentSourceRootsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "")]
//        public defaultWorkingPackage defaultWorkingPackage
//        {
//            get
//            {
//                return defaultWorkingPackageField;
//            }
//            set
//            {
//                defaultWorkingPackageField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "")]
//        public defaultImportedPackages defaultImportedPackages
//        {
//            get
//            {
//                return defaultImportedPackagesField;
//            }
//            set
//            {
//                defaultImportedPackagesField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string tempDirectory
//        {
//            get
//            {
//                return tempDirectoryField;
//            }
//            set
//            {
//                tempDirectoryField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string defaultWorkingDirectory
//        {
//            get
//            {
//                return defaultWorkingDirectoryField;
//            }
//            set
//            {
//                defaultWorkingDirectoryField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public byte deletedElementGenerationOptions
//        {
//            get
//            {
//                return deletedElementGenerationOptionsField;
//            }
//            set
//            {
//                deletedElementGenerationOptionsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public byte analyseType
//        {
//            get
//            {
//                return analyseTypeField;
//            }
//            set
//            {
//                analyseTypeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool visualizeModel
//        {
//            get
//            {
//                return visualizeModelField;
//            }
//            set
//            {
//                visualizeModelField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public byte spaces
//        {
//            get
//            {
//                return spacesField;
//            }
//            set
//            {
//                spacesField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string defaultLanguage
//        {
//            get
//            {
//                return defaultLanguageField;
//            }
//            set
//            {
//                defaultLanguageField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public byte visualizationOption
//        {
//            get
//            {
//                return visualizationOptionField;
//            }
//            set
//            {
//                visualizationOptionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public byte codeGenerationReverseOption
//        {
//            get
//            {
//                return codeGenerationReverseOptionField;
//            }
//            set
//            {
//                codeGenerationReverseOptionField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
//    public partial class defaultWorkingPackage
//    {

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
//    public partial class defaultImportedPackages
//    {

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.nomagic.com/magicdraw/foundation")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.nomagic.com/magicdraw/foundation", IsNullable = false)]
//    public partial class MDExtension
//    {

//        private contents contentsField;

//        private string idField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "")]
//        public contents contents
//        {
//            get
//            {
//                return contentsField;
//            }
//            set
//            {
//                contentsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
//    public partial class contents
//    {

//        private contentsDocumentationTagProcessors documentationTagProcessorsField;

//        private contentsUserDefinedAttributeCreationRule userDefinedAttributeCreationRuleField;

//        private string idField;

//        private byte commentStyleField;

//        private string headerField;

//        private string documentationProcessorIDField;

//        private string classpathField;

//        private decimal javaSourceField;

//        private bool javaSourceFieldSpecified;

//        private string macrosField;

//        /// <remarks/>
//        public contentsDocumentationTagProcessors documentationTagProcessors
//        {
//            get
//            {
//                return documentationTagProcessorsField;
//            }
//            set
//            {
//                documentationTagProcessorsField = value;
//            }
//        }

//        /// <remarks/>
//        public contentsUserDefinedAttributeCreationRule userDefinedAttributeCreationRule
//        {
//            get
//            {
//                return userDefinedAttributeCreationRuleField;
//            }
//            set
//            {
//                userDefinedAttributeCreationRuleField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public byte commentStyle
//        {
//            get
//            {
//                return commentStyleField;
//            }
//            set
//            {
//                commentStyleField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string header
//        {
//            get
//            {
//                return headerField;
//            }
//            set
//            {
//                headerField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string documentationProcessorID
//        {
//            get
//            {
//                return documentationProcessorIDField;
//            }
//            set
//            {
//                documentationProcessorIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string classpath
//        {
//            get
//            {
//                return classpathField;
//            }
//            set
//            {
//                classpathField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public decimal javaSource
//        {
//            get
//            {
//                return javaSourceField;
//            }
//            set
//            {
//                javaSourceField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool javaSourceSpecified
//        {
//            get
//            {
//                return javaSourceFieldSpecified;
//            }
//            set
//            {
//                javaSourceFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string macros
//        {
//            get
//            {
//                return macrosField;
//            }
//            set
//            {
//                macrosField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class contentsDocumentationTagProcessors
//    {

//        private contentsDocumentationTagProcessorsDocumentationTagManagers[] documentationTagManagersField;

//        private string idField;

//        private string idField1;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("documentationTagManagers")]
//        public contentsDocumentationTagProcessorsDocumentationTagManagers[] documentationTagManagers
//        {
//            get
//            {
//                return documentationTagManagersField;
//            }
//            set
//            {
//                documentationTagManagersField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class contentsDocumentationTagProcessorsDocumentationTagManagers
//    {

//        private contentsDocumentationTagProcessorsDocumentationTagManagersDocumentationTags[] documentationTagsField;

//        private string idField;

//        private string idField1;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("documentationTags")]
//        public contentsDocumentationTagProcessorsDocumentationTagManagersDocumentationTags[] documentationTags
//        {
//            get
//            {
//                return documentationTagsField;
//            }
//            set
//            {
//                documentationTagsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class contentsDocumentationTagProcessorsDocumentationTagManagersDocumentationTags
//    {

//        private string idField;

//        private string nameField;

//        private bool valueEditableField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool valueEditable
//        {
//            get
//            {
//                return valueEditableField;
//            }
//            set
//            {
//                valueEditableField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class contentsUserDefinedAttributeCreationRule
//    {

//        private contentsUserDefinedAttributeCreationRuleRules rulesField;

//        private string idField;

//        private string defaultField;

//        /// <remarks/>
//        public contentsUserDefinedAttributeCreationRuleRules rules
//        {
//            get
//            {
//                return rulesField;
//            }
//            set
//            {
//                rulesField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string @default
//        {
//            get
//            {
//                return defaultField;
//            }
//            set
//            {
//                defaultField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class contentsUserDefinedAttributeCreationRuleRules
//    {

//        private string idField;

//        private string creationTypeField;

//        private string patternField;

//        private string classTypeField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string creationType
//        {
//            get
//            {
//                return creationTypeField;
//            }
//            set
//            {
//                creationTypeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string pattern
//        {
//            get
//            {
//                return patternField;
//            }
//            set
//            {
//                patternField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string classType
//        {
//            get
//            {
//                return classTypeField;
//            }
//            set
//            {
//                classTypeField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElement
//    {

//        private object[] itemsField;

//        private ItemsChoiceType[] itemsElementNameField;

//        private string elementClassField;

//        private string idField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("ATTRIBUTES_compartmentChildren", typeof(filePartMdElementATTRIBUTES_compartmentChildren))]
//        [System.Xml.Serialization.XmlElement("COMPARTMENT_ID_VALUES_compartmentChildren", typeof(filePartMdElementCOMPARTMENT_ID_VALUES_compartmentChildren))]
//        [System.Xml.Serialization.XmlElement("ENUMERATION_LITERALS_compartmentChildren", typeof(filePartMdElementENUMERATION_LITERALS_compartmentChildren))]
//        [System.Xml.Serialization.XmlElement("active", typeof(filePartMdElementActive))]
//        [System.Xml.Serialization.XmlElement("associationFirstEndID", typeof(filePartMdElementAssociationFirstEndID))]
//        [System.Xml.Serialization.XmlElement("associationSecondEndID", typeof(filePartMdElementAssociationSecondEndID))]
//        [System.Xml.Serialization.XmlElement("baseShape", typeof(filePartMdElementBaseShape))]
//        [System.Xml.Serialization.XmlElement("compartment", typeof(filePartMdElementCompartment))]
//        [System.Xml.Serialization.XmlElement("elementID", typeof(filePartMdElementElementID))]
//        [System.Xml.Serialization.XmlElement("elementProperties", typeof(filePartMdElementElementProperties))]
//        [System.Xml.Serialization.XmlElement("geometry", typeof(string))]
//        [System.Xml.Serialization.XmlElement("horizontalBarLeft", typeof(filePartMdElementHorizontalBarLeft))]
//        [System.Xml.Serialization.XmlElement("horizontalBarRight", typeof(filePartMdElementHorizontalBarRight))]
//        [System.Xml.Serialization.XmlElement("horizontalBarY", typeof(filePartMdElementHorizontalBarY))]
//        [System.Xml.Serialization.XmlElement("horizontalCenterline", typeof(string))]
//        [System.Xml.Serialization.XmlElement("implicitlySetY", typeof(filePartMdElementImplicitlySetY))]
//        [System.Xml.Serialization.XmlElement("linkFirstEndID", typeof(filePartMdElementLinkFirstEndID))]
//        [System.Xml.Serialization.XmlElement("linkNameID", typeof(filePartMdElementLinkNameID))]
//        [System.Xml.Serialization.XmlElement("linkRoleA", typeof(filePartMdElementLinkRoleA))]
//        [System.Xml.Serialization.XmlElement("linkRoleB", typeof(filePartMdElementLinkRoleB))]
//        [System.Xml.Serialization.XmlElement("linkSecondEndID", typeof(filePartMdElementLinkSecondEndID))]
//        [System.Xml.Serialization.XmlElement("linkSlots", typeof(filePartMdElementLinkSlots))]
//        [System.Xml.Serialization.XmlElement("linkStereotypeID", typeof(filePartMdElementLinkStereotypeID))]
//        [System.Xml.Serialization.XmlElement("linkTaggedValuesID", typeof(filePartMdElementLinkTaggedValuesID))]
//        [System.Xml.Serialization.XmlElement("mdOwnedViews", typeof(filePartMdElementMdOwnedViews))]
//        [System.Xml.Serialization.XmlElement("nameID", typeof(filePartMdElementNameID))]
//        [System.Xml.Serialization.XmlElement("nameVisible", typeof(filePartMdElementNameVisible))]
//        [System.Xml.Serialization.XmlElement("operands", typeof(filePartMdElementOperands))]
//        [System.Xml.Serialization.XmlElement("parts", typeof(filePartMdElementParts))]
//        [System.Xml.Serialization.XmlElement("properties", typeof(filePartMdElementProperties))]
//        [System.Xml.Serialization.XmlElement("regions", typeof(filePartMdElementRegions))]
//        [System.Xml.Serialization.XmlElement("text", typeof(string))]
//        [System.Xml.Serialization.XmlElement("treeID", typeof(filePartMdElementTreeID))]
//        [System.Xml.Serialization.XmlElement("vertical", typeof(filePartMdElementVertical))]
//        [System.Xml.Serialization.XmlElement("verticalBarX", typeof(filePartMdElementVerticalBarX))]
//        [System.Xml.Serialization.XmlElement("verticalBarY", typeof(filePartMdElementVerticalBarY))]
//        [System.Xml.Serialization.XmlElement("verticalCenterline", typeof(string))]
//        [System.Xml.Serialization.XmlChoiceIdentifier("ItemsElementName")]
//        public object[] Items
//        {
//            get
//            {
//                return itemsField;
//            }
//            set
//            {
//                itemsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("ItemsElementName")]
//        [System.Xml.Serialization.XmlIgnore()]
//        public ItemsChoiceType[] ItemsElementName
//        {
//            get
//            {
//                return itemsElementNameField;
//            }
//            set
//            {
//                itemsElementNameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string elementClass
//        {
//            get
//            {
//                return elementClassField;
//            }
//            set
//            {
//                elementClassField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementATTRIBUTES_compartmentChildren
//    {

//        private filePartMdElementATTRIBUTES_compartmentChildrenMdElement mdElementField;

//        /// <remarks/>
//        public filePartMdElementATTRIBUTES_compartmentChildrenMdElement mdElement
//        {
//            get
//            {
//                return mdElementField;
//            }
//            set
//            {
//                mdElementField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementATTRIBUTES_compartmentChildrenMdElement
//    {

//        private filePartMdElementATTRIBUTES_compartmentChildrenMdElementElementID elementIDField;

//        private string geometryField;

//        private filePartMdElementATTRIBUTES_compartmentChildrenMdElementCompartment compartmentField;

//        private string elementClassField;

//        private string idField;

//        /// <remarks/>
//        public filePartMdElementATTRIBUTES_compartmentChildrenMdElementElementID elementID
//        {
//            get
//            {
//                return elementIDField;
//            }
//            set
//            {
//                elementIDField = value;
//            }
//        }

//        /// <remarks/>
//        public string geometry
//        {
//            get
//            {
//                return geometryField;
//            }
//            set
//            {
//                geometryField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementATTRIBUTES_compartmentChildrenMdElementCompartment compartment
//        {
//            get
//            {
//                return compartmentField;
//            }
//            set
//            {
//                compartmentField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string elementClass
//        {
//            get
//            {
//                return elementClassField;
//            }
//            set
//            {
//                elementClassField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementATTRIBUTES_compartmentChildrenMdElementElementID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementATTRIBUTES_compartmentChildrenMdElementCompartment
//    {

//        private string compartmentIDField;

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string compartmentID
//        {
//            get
//            {
//                return compartmentIDField;
//            }
//            set
//            {
//                compartmentIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementCOMPARTMENT_ID_VALUES_compartmentChildren
//    {

//        private filePartMdElementCOMPARTMENT_ID_VALUES_compartmentChildrenMdElement[] mdElementField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("mdElement")]
//        public filePartMdElementCOMPARTMENT_ID_VALUES_compartmentChildrenMdElement[] mdElement
//        {
//            get
//            {
//                return mdElementField;
//            }
//            set
//            {
//                mdElementField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementCOMPARTMENT_ID_VALUES_compartmentChildrenMdElement
//    {

//        private filePartMdElementCOMPARTMENT_ID_VALUES_compartmentChildrenMdElementElementID elementIDField;

//        private string geometryField;

//        private filePartMdElementCOMPARTMENT_ID_VALUES_compartmentChildrenMdElementCompartment compartmentField;

//        private string elementClassField;

//        private string idField;

//        /// <remarks/>
//        public filePartMdElementCOMPARTMENT_ID_VALUES_compartmentChildrenMdElementElementID elementID
//        {
//            get
//            {
//                return elementIDField;
//            }
//            set
//            {
//                elementIDField = value;
//            }
//        }

//        /// <remarks/>
//        public string geometry
//        {
//            get
//            {
//                return geometryField;
//            }
//            set
//            {
//                geometryField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementCOMPARTMENT_ID_VALUES_compartmentChildrenMdElementCompartment compartment
//        {
//            get
//            {
//                return compartmentField;
//            }
//            set
//            {
//                compartmentField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string elementClass
//        {
//            get
//            {
//                return elementClassField;
//            }
//            set
//            {
//                elementClassField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementCOMPARTMENT_ID_VALUES_compartmentChildrenMdElementElementID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementCOMPARTMENT_ID_VALUES_compartmentChildrenMdElementCompartment
//    {

//        private string compartmentIDField;

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string compartmentID
//        {
//            get
//            {
//                return compartmentIDField;
//            }
//            set
//            {
//                compartmentIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementENUMERATION_LITERALS_compartmentChildren
//    {

//        private filePartMdElementENUMERATION_LITERALS_compartmentChildrenMdElement[] mdElementField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("mdElement")]
//        public filePartMdElementENUMERATION_LITERALS_compartmentChildrenMdElement[] mdElement
//        {
//            get
//            {
//                return mdElementField;
//            }
//            set
//            {
//                mdElementField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementENUMERATION_LITERALS_compartmentChildrenMdElement
//    {

//        private filePartMdElementENUMERATION_LITERALS_compartmentChildrenMdElementElementID elementIDField;

//        private string geometryField;

//        private filePartMdElementENUMERATION_LITERALS_compartmentChildrenMdElementCompartment compartmentField;

//        private string elementClassField;

//        private string idField;

//        /// <remarks/>
//        public filePartMdElementENUMERATION_LITERALS_compartmentChildrenMdElementElementID elementID
//        {
//            get
//            {
//                return elementIDField;
//            }
//            set
//            {
//                elementIDField = value;
//            }
//        }

//        /// <remarks/>
//        public string geometry
//        {
//            get
//            {
//                return geometryField;
//            }
//            set
//            {
//                geometryField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementENUMERATION_LITERALS_compartmentChildrenMdElementCompartment compartment
//        {
//            get
//            {
//                return compartmentField;
//            }
//            set
//            {
//                compartmentField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string elementClass
//        {
//            get
//            {
//                return elementClassField;
//            }
//            set
//            {
//                elementClassField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementENUMERATION_LITERALS_compartmentChildrenMdElementElementID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementENUMERATION_LITERALS_compartmentChildrenMdElementCompartment
//    {

//        private string compartmentIDField;

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string compartmentID
//        {
//            get
//            {
//                return compartmentIDField;
//            }
//            set
//            {
//                compartmentIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementActive
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementAssociationFirstEndID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementAssociationSecondEndID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementBaseShape
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementCompartment
//    {

//        private string compartmentIDField;

//        private bool isContentLockedField;

//        private bool isContentLockedFieldSpecified;

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string compartmentID
//        {
//            get
//            {
//                return compartmentIDField;
//            }
//            set
//            {
//                compartmentIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool isContentLocked
//        {
//            get
//            {
//                return isContentLockedField;
//            }
//            set
//            {
//                isContentLockedField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool isContentLockedSpecified
//        {
//            get
//            {
//                return isContentLockedFieldSpecified;
//            }
//            set
//            {
//                isContentLockedFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementElementID
//    {

//        private Extension extensionField;

//        private string idrefField;

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public Extension Extension
//        {
//            get
//            {
//                return extensionField;
//            }
//            set
//            {
//                extensionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementElementProperties
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementHorizontalBarLeft
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementHorizontalBarRight
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementHorizontalBarY
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementImplicitlySetY
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementLinkFirstEndID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementLinkNameID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementLinkRoleA
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementLinkRoleB
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementLinkSecondEndID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementLinkSlots
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementLinkStereotypeID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementLinkTaggedValuesID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViews
//    {

//        private filePartMdElementMdOwnedViewsMdElement[] mdElementField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("mdElement")]
//        public filePartMdElementMdOwnedViewsMdElement[] mdElement
//        {
//            get
//            {
//                return mdElementField;
//            }
//            set
//            {
//                mdElementField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElement
//    {

//        private filePartMdElementMdOwnedViewsMdElementVisible visibleField;

//        private filePartMdElementMdOwnedViewsMdElementElementID elementIDField;

//        private filePartMdElementMdOwnedViewsMdElementMdElement[] propertiesField;

//        private filePartMdElementMdOwnedViewsMdElementLinkFirstEndID linkFirstEndIDField;

//        private filePartMdElementMdOwnedViewsMdElementLinkSecondEndID linkSecondEndIDField;

//        private string geometryField;

//        private filePartMdElementMdOwnedViewsMdElementEdge edgeField;

//        private filePartMdElementMdOwnedViewsMdElementBaseShape baseShapeField;

//        private filePartMdElementMdOwnedViewsMdElementVerticalBarX verticalBarXField;

//        private filePartMdElementMdOwnedViewsMdElementVerticalBarY verticalBarYField;

//        private filePartMdElementMdOwnedViewsMdElementHorizontalBarLeft horizontalBarLeftField;

//        private filePartMdElementMdOwnedViewsMdElementHorizontalBarRight horizontalBarRightField;

//        private filePartMdElementMdOwnedViewsMdElementHorizontalBarY horizontalBarYField;

//        private filePartMdElementMdOwnedViewsMdElementImplicitlySetY implicitlySetYField;

//        private filePartMdElementMdOwnedViewsMdElementTreeID treeIDField;

//        private filePartMdElementMdOwnedViewsMdElementCompartment[] compartmentField;

//        private filePartMdElementMdOwnedViewsMdElementNameVisible nameVisibleField;

//        private filePartMdElementMdOwnedViewsMdElementMdElement1[] mdOwnedViewsField;

//        private filePartMdElementMdOwnedViewsMdElementAssociationFirstEndID associationFirstEndIDField;

//        private filePartMdElementMdOwnedViewsMdElementAssociationSecondEndID associationSecondEndIDField;

//        private filePartMdElementMdOwnedViewsMdElementLinkStereotypeID linkStereotypeIDField;

//        private filePartMdElementMdOwnedViewsMdElementNameID nameIDField;

//        private string textField;

//        private filePartMdElementMdOwnedViewsMdElementReverseIcon reverseIconField;

//        private filePartMdElementMdOwnedViewsMdElementRoleNameID roleNameIDField;

//        private filePartMdElementMdOwnedViewsMdElementRoleMultiplicityID roleMultiplicityIDField;

//        private filePartMdElementMdOwnedViewsMdElementRoleStereotypeID roleStereotypeIDField;

//        private filePartMdElementMdOwnedViewsMdElementRoleTaggedValuesID roleTaggedValuesIDField;

//        private filePartMdElementMdOwnedViewsMdElementRolePropertyStringID rolePropertyStringIDField;

//        private string elementClassField;

//        private string idField;

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementVisible visible
//        {
//            get
//            {
//                return visibleField;
//            }
//            set
//            {
//                visibleField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementElementID elementID
//        {
//            get
//            {
//                return elementIDField;
//            }
//            set
//            {
//                elementIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlArrayItem("mdElement", IsNullable = false)]
//        public filePartMdElementMdOwnedViewsMdElementMdElement[] properties
//        {
//            get
//            {
//                return propertiesField;
//            }
//            set
//            {
//                propertiesField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementLinkFirstEndID linkFirstEndID
//        {
//            get
//            {
//                return linkFirstEndIDField;
//            }
//            set
//            {
//                linkFirstEndIDField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementLinkSecondEndID linkSecondEndID
//        {
//            get
//            {
//                return linkSecondEndIDField;
//            }
//            set
//            {
//                linkSecondEndIDField = value;
//            }
//        }

//        /// <remarks/>
//        public string geometry
//        {
//            get
//            {
//                return geometryField;
//            }
//            set
//            {
//                geometryField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementEdge edge
//        {
//            get
//            {
//                return edgeField;
//            }
//            set
//            {
//                edgeField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementBaseShape baseShape
//        {
//            get
//            {
//                return baseShapeField;
//            }
//            set
//            {
//                baseShapeField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementVerticalBarX verticalBarX
//        {
//            get
//            {
//                return verticalBarXField;
//            }
//            set
//            {
//                verticalBarXField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementVerticalBarY verticalBarY
//        {
//            get
//            {
//                return verticalBarYField;
//            }
//            set
//            {
//                verticalBarYField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementHorizontalBarLeft horizontalBarLeft
//        {
//            get
//            {
//                return horizontalBarLeftField;
//            }
//            set
//            {
//                horizontalBarLeftField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementHorizontalBarRight horizontalBarRight
//        {
//            get
//            {
//                return horizontalBarRightField;
//            }
//            set
//            {
//                horizontalBarRightField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementHorizontalBarY horizontalBarY
//        {
//            get
//            {
//                return horizontalBarYField;
//            }
//            set
//            {
//                horizontalBarYField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementImplicitlySetY implicitlySetY
//        {
//            get
//            {
//                return implicitlySetYField;
//            }
//            set
//            {
//                implicitlySetYField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementTreeID treeID
//        {
//            get
//            {
//                return treeIDField;
//            }
//            set
//            {
//                treeIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("compartment")]
//        public filePartMdElementMdOwnedViewsMdElementCompartment[] compartment
//        {
//            get
//            {
//                return compartmentField;
//            }
//            set
//            {
//                compartmentField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementNameVisible nameVisible
//        {
//            get
//            {
//                return nameVisibleField;
//            }
//            set
//            {
//                nameVisibleField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlArrayItem("mdElement", IsNullable = false)]
//        public filePartMdElementMdOwnedViewsMdElementMdElement1[] mdOwnedViews
//        {
//            get
//            {
//                return mdOwnedViewsField;
//            }
//            set
//            {
//                mdOwnedViewsField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementAssociationFirstEndID associationFirstEndID
//        {
//            get
//            {
//                return associationFirstEndIDField;
//            }
//            set
//            {
//                associationFirstEndIDField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementAssociationSecondEndID associationSecondEndID
//        {
//            get
//            {
//                return associationSecondEndIDField;
//            }
//            set
//            {
//                associationSecondEndIDField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementLinkStereotypeID linkStereotypeID
//        {
//            get
//            {
//                return linkStereotypeIDField;
//            }
//            set
//            {
//                linkStereotypeIDField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementNameID nameID
//        {
//            get
//            {
//                return nameIDField;
//            }
//            set
//            {
//                nameIDField = value;
//            }
//        }

//        /// <remarks/>
//        public string text
//        {
//            get
//            {
//                return textField;
//            }
//            set
//            {
//                textField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementReverseIcon reverseIcon
//        {
//            get
//            {
//                return reverseIconField;
//            }
//            set
//            {
//                reverseIconField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementRoleNameID roleNameID
//        {
//            get
//            {
//                return roleNameIDField;
//            }
//            set
//            {
//                roleNameIDField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementRoleMultiplicityID roleMultiplicityID
//        {
//            get
//            {
//                return roleMultiplicityIDField;
//            }
//            set
//            {
//                roleMultiplicityIDField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementRoleStereotypeID roleStereotypeID
//        {
//            get
//            {
//                return roleStereotypeIDField;
//            }
//            set
//            {
//                roleStereotypeIDField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementRoleTaggedValuesID roleTaggedValuesID
//        {
//            get
//            {
//                return roleTaggedValuesIDField;
//            }
//            set
//            {
//                roleTaggedValuesIDField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementRolePropertyStringID rolePropertyStringID
//        {
//            get
//            {
//                return rolePropertyStringIDField;
//            }
//            set
//            {
//                rolePropertyStringIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string elementClass
//        {
//            get
//            {
//                return elementClassField;
//            }
//            set
//            {
//                elementClassField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementVisible
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementElementID
//    {

//        private Extension extensionField;

//        private string idrefField;

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public Extension Extension
//        {
//            get
//            {
//                return extensionField;
//            }
//            set
//            {
//                extensionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementMdElement
//    {

//        private string propertyIDField;

//        private string propertyDescriptionIDField;

//        private string valueField;

//        private filePartMdElementMdOwnedViewsMdElementMdElementChoice choiceField;

//        private filePartMdElementMdOwnedViewsMdElementMdElementIndex indexField;

//        private string elementClassField;

//        /// <remarks/>
//        public string propertyID
//        {
//            get
//            {
//                return propertyIDField;
//            }
//            set
//            {
//                propertyIDField = value;
//            }
//        }

//        /// <remarks/>
//        public string propertyDescriptionID
//        {
//            get
//            {
//                return propertyDescriptionIDField;
//            }
//            set
//            {
//                propertyDescriptionIDField = value;
//            }
//        }

//        /// <remarks/>
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementMdElementChoice choice
//        {
//            get
//            {
//                return choiceField;
//            }
//            set
//            {
//                choiceField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementMdElementIndex index
//        {
//            get
//            {
//                return indexField;
//            }
//            set
//            {
//                indexField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string elementClass
//        {
//            get
//            {
//                return elementClassField;
//            }
//            set
//            {
//                elementClassField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementMdElementChoice
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementMdElementIndex
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementLinkFirstEndID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementLinkSecondEndID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementEdge
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementBaseShape
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementVerticalBarX
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementVerticalBarY
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementHorizontalBarLeft
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementHorizontalBarRight
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementHorizontalBarY
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementImplicitlySetY
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementTreeID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementCompartment
//    {

//        private string compartmentIDField;

//        private string valueField;

//        private bool isContentLockedField;

//        private bool isContentLockedFieldSpecified;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string compartmentID
//        {
//            get
//            {
//                return compartmentIDField;
//            }
//            set
//            {
//                compartmentIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool isContentLocked
//        {
//            get
//            {
//                return isContentLockedField;
//            }
//            set
//            {
//                isContentLockedField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool isContentLockedSpecified
//        {
//            get
//            {
//                return isContentLockedFieldSpecified;
//            }
//            set
//            {
//                isContentLockedFieldSpecified = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementNameVisible
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementMdElement1
//    {

//        private filePartMdElementMdOwnedViewsMdElementMdElementVisible visibleField;

//        private filePartMdElementMdOwnedViewsMdElementMdElementElementID elementIDField;

//        private filePartMdElementMdOwnedViewsMdElementMdElementProperties propertiesField;

//        private filePartMdElementMdOwnedViewsMdElementMdElementLinkFirstEndID linkFirstEndIDField;

//        private filePartMdElementMdOwnedViewsMdElementMdElementLinkSecondEndID linkSecondEndIDField;

//        private string geometryField;

//        private filePartMdElementMdOwnedViewsMdElementMdElementResizedByUser resizedByUserField;

//        private filePartMdElementMdOwnedViewsMdElementMdElementCompartment[] compartmentField;

//        private filePartMdElementMdOwnedViewsMdElementMdElementLinkNameID linkNameIDField;

//        private filePartMdElementMdOwnedViewsMdElementMdElementNameVisible nameVisibleField;

//        private filePartMdElementMdOwnedViewsMdElementMdElementMdElement[] mdOwnedViewsField;

//        private filePartMdElementMdOwnedViewsMdElementMdElementRoleNameID roleNameIDField;

//        private filePartMdElementMdOwnedViewsMdElementMdElementRoleMultiplicityID roleMultiplicityIDField;

//        private filePartMdElementMdOwnedViewsMdElementMdElementRoleStereotypeID roleStereotypeIDField;

//        private filePartMdElementMdOwnedViewsMdElementMdElementLinkConstraintID linkConstraintIDField;

//        private string textField;

//        private string elementClassField;

//        private string idField;

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementMdElementVisible visible
//        {
//            get
//            {
//                return visibleField;
//            }
//            set
//            {
//                visibleField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementMdElementElementID elementID
//        {
//            get
//            {
//                return elementIDField;
//            }
//            set
//            {
//                elementIDField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementMdElementProperties properties
//        {
//            get
//            {
//                return propertiesField;
//            }
//            set
//            {
//                propertiesField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementMdElementLinkFirstEndID linkFirstEndID
//        {
//            get
//            {
//                return linkFirstEndIDField;
//            }
//            set
//            {
//                linkFirstEndIDField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementMdElementLinkSecondEndID linkSecondEndID
//        {
//            get
//            {
//                return linkSecondEndIDField;
//            }
//            set
//            {
//                linkSecondEndIDField = value;
//            }
//        }

//        /// <remarks/>
//        public string geometry
//        {
//            get
//            {
//                return geometryField;
//            }
//            set
//            {
//                geometryField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementMdElementResizedByUser resizedByUser
//        {
//            get
//            {
//                return resizedByUserField;
//            }
//            set
//            {
//                resizedByUserField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("compartment")]
//        public filePartMdElementMdOwnedViewsMdElementMdElementCompartment[] compartment
//        {
//            get
//            {
//                return compartmentField;
//            }
//            set
//            {
//                compartmentField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementMdElementLinkNameID linkNameID
//        {
//            get
//            {
//                return linkNameIDField;
//            }
//            set
//            {
//                linkNameIDField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementMdElementNameVisible nameVisible
//        {
//            get
//            {
//                return nameVisibleField;
//            }
//            set
//            {
//                nameVisibleField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlArrayItem("mdElement", IsNullable = false)]
//        public filePartMdElementMdOwnedViewsMdElementMdElementMdElement[] mdOwnedViews
//        {
//            get
//            {
//                return mdOwnedViewsField;
//            }
//            set
//            {
//                mdOwnedViewsField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementMdElementRoleNameID roleNameID
//        {
//            get
//            {
//                return roleNameIDField;
//            }
//            set
//            {
//                roleNameIDField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementMdElementRoleMultiplicityID roleMultiplicityID
//        {
//            get
//            {
//                return roleMultiplicityIDField;
//            }
//            set
//            {
//                roleMultiplicityIDField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementMdElementRoleStereotypeID roleStereotypeID
//        {
//            get
//            {
//                return roleStereotypeIDField;
//            }
//            set
//            {
//                roleStereotypeIDField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementMdElementLinkConstraintID linkConstraintID
//        {
//            get
//            {
//                return linkConstraintIDField;
//            }
//            set
//            {
//                linkConstraintIDField = value;
//            }
//        }

//        /// <remarks/>
//        public string text
//        {
//            get
//            {
//                return textField;
//            }
//            set
//            {
//                textField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string elementClass
//        {
//            get
//            {
//                return elementClassField;
//            }
//            set
//            {
//                elementClassField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementMdElementVisible
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementMdElementElementID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementMdElementProperties
//    {

//        private filePartMdElementMdOwnedViewsMdElementMdElementPropertiesMdElement mdElementField;

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementMdElementPropertiesMdElement mdElement
//        {
//            get
//            {
//                return mdElementField;
//            }
//            set
//            {
//                mdElementField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementMdElementPropertiesMdElement
//    {

//        private string propertyIDField;

//        private string propertyDescriptionIDField;

//        private filePartMdElementMdOwnedViewsMdElementMdElementPropertiesMdElementValue valueField;

//        private string elementClassField;

//        /// <remarks/>
//        public string propertyID
//        {
//            get
//            {
//                return propertyIDField;
//            }
//            set
//            {
//                propertyIDField = value;
//            }
//        }

//        /// <remarks/>
//        public string propertyDescriptionID
//        {
//            get
//            {
//                return propertyDescriptionIDField;
//            }
//            set
//            {
//                propertyDescriptionIDField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementMdElementPropertiesMdElementValue value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string elementClass
//        {
//            get
//            {
//                return elementClassField;
//            }
//            set
//            {
//                elementClassField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementMdElementPropertiesMdElementValue
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementMdElementLinkFirstEndID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementMdElementLinkSecondEndID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementMdElementResizedByUser
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementMdElementCompartment
//    {

//        private string compartmentIDField;

//        private string valueField;

//        private bool isContentLockedField;

//        private bool isContentLockedFieldSpecified;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string compartmentID
//        {
//            get
//            {
//                return compartmentIDField;
//            }
//            set
//            {
//                compartmentIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool isContentLocked
//        {
//            get
//            {
//                return isContentLockedField;
//            }
//            set
//            {
//                isContentLockedField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool isContentLockedSpecified
//        {
//            get
//            {
//                return isContentLockedFieldSpecified;
//            }
//            set
//            {
//                isContentLockedFieldSpecified = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementMdElementLinkNameID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementMdElementNameVisible
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementMdElementMdElement
//    {

//        private filePartMdElementMdOwnedViewsMdElementMdElementMdElementElementID elementIDField;

//        private filePartMdElementMdOwnedViewsMdElementMdElementMdElementVisible visibleField;

//        private string geometryField;

//        private object mdOwnedViewsField;

//        private string textField;

//        private string elementClassField;

//        private string idField;

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementMdElementMdElementElementID elementID
//        {
//            get
//            {
//                return elementIDField;
//            }
//            set
//            {
//                elementIDField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementMdOwnedViewsMdElementMdElementMdElementVisible visible
//        {
//            get
//            {
//                return visibleField;
//            }
//            set
//            {
//                visibleField = value;
//            }
//        }

//        /// <remarks/>
//        public string geometry
//        {
//            get
//            {
//                return geometryField;
//            }
//            set
//            {
//                geometryField = value;
//            }
//        }

//        /// <remarks/>
//        public object mdOwnedViews
//        {
//            get
//            {
//                return mdOwnedViewsField;
//            }
//            set
//            {
//                mdOwnedViewsField = value;
//            }
//        }

//        /// <remarks/>
//        public string text
//        {
//            get
//            {
//                return textField;
//            }
//            set
//            {
//                textField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string elementClass
//        {
//            get
//            {
//                return elementClassField;
//            }
//            set
//            {
//                elementClassField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementMdElementMdElementElementID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementMdElementMdElementVisible
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementMdElementRoleNameID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementMdElementRoleMultiplicityID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementMdElementRoleStereotypeID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementMdElementLinkConstraintID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementAssociationFirstEndID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementAssociationSecondEndID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementLinkStereotypeID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementNameID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementReverseIcon
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementRoleNameID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementRoleMultiplicityID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementRoleStereotypeID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementRoleTaggedValuesID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementMdOwnedViewsMdElementRolePropertyStringID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementNameID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementNameVisible
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementOperands
//    {

//        private filePartMdElementOperandsMdElement mdElementField;

//        /// <remarks/>
//        public filePartMdElementOperandsMdElement mdElement
//        {
//            get
//            {
//                return mdElementField;
//            }
//            set
//            {
//                mdElementField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementOperandsMdElement
//    {

//        private filePartMdElementOperandsMdElementElementID elementIDField;

//        private string geometryField;

//        private object mdOwnedViewsField;

//        private string textField;

//        private string elementClassField;

//        private string idField;

//        /// <remarks/>
//        public filePartMdElementOperandsMdElementElementID elementID
//        {
//            get
//            {
//                return elementIDField;
//            }
//            set
//            {
//                elementIDField = value;
//            }
//        }

//        /// <remarks/>
//        public string geometry
//        {
//            get
//            {
//                return geometryField;
//            }
//            set
//            {
//                geometryField = value;
//            }
//        }

//        /// <remarks/>
//        public object mdOwnedViews
//        {
//            get
//            {
//                return mdOwnedViewsField;
//            }
//            set
//            {
//                mdOwnedViewsField = value;
//            }
//        }

//        /// <remarks/>
//        public string text
//        {
//            get
//            {
//                return textField;
//            }
//            set
//            {
//                textField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string elementClass
//        {
//            get
//            {
//                return elementClassField;
//            }
//            set
//            {
//                elementClassField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementOperandsMdElementElementID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementParts
//    {

//        private filePartMdElementPartsMdElement[] mdElementField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("mdElement")]
//        public filePartMdElementPartsMdElement[] mdElement
//        {
//            get
//            {
//                return mdElementField;
//            }
//            set
//            {
//                mdElementField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElement
//    {

//        private filePartMdElementPartsMdElementElementID elementIDField;

//        private filePartMdElementPartsMdElementLinkFirstEndID linkFirstEndIDField;

//        private filePartMdElementPartsMdElementLinkSecondEndID linkSecondEndIDField;

//        private filePartMdElementPartsMdElementProperties propertiesField;

//        private string geometryField;

//        private filePartMdElementPartsMdElementCompartment[] compartmentField;

//        private filePartMdElementPartsMdElementNameVisible nameVisibleField;

//        private filePartMdElementPartsMdElementMdElement[] mdOwnedViewsField;

//        private filePartMdElementPartsMdElementConnectorEndAID connectorEndAIDField;

//        private filePartMdElementPartsMdElementConnectorEndBID connectorEndBIDField;

//        private filePartMdElementPartsMdElementMdElement1[] partsField;

//        private string elementClassField;

//        private string idField;

//        /// <remarks/>
//        public filePartMdElementPartsMdElementElementID elementID
//        {
//            get
//            {
//                return elementIDField;
//            }
//            set
//            {
//                elementIDField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPartsMdElementLinkFirstEndID linkFirstEndID
//        {
//            get
//            {
//                return linkFirstEndIDField;
//            }
//            set
//            {
//                linkFirstEndIDField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPartsMdElementLinkSecondEndID linkSecondEndID
//        {
//            get
//            {
//                return linkSecondEndIDField;
//            }
//            set
//            {
//                linkSecondEndIDField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPartsMdElementProperties properties
//        {
//            get
//            {
//                return propertiesField;
//            }
//            set
//            {
//                propertiesField = value;
//            }
//        }

//        /// <remarks/>
//        public string geometry
//        {
//            get
//            {
//                return geometryField;
//            }
//            set
//            {
//                geometryField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("compartment")]
//        public filePartMdElementPartsMdElementCompartment[] compartment
//        {
//            get
//            {
//                return compartmentField;
//            }
//            set
//            {
//                compartmentField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPartsMdElementNameVisible nameVisible
//        {
//            get
//            {
//                return nameVisibleField;
//            }
//            set
//            {
//                nameVisibleField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlArrayItem("mdElement", IsNullable = false)]
//        public filePartMdElementPartsMdElementMdElement[] mdOwnedViews
//        {
//            get
//            {
//                return mdOwnedViewsField;
//            }
//            set
//            {
//                mdOwnedViewsField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPartsMdElementConnectorEndAID connectorEndAID
//        {
//            get
//            {
//                return connectorEndAIDField;
//            }
//            set
//            {
//                connectorEndAIDField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPartsMdElementConnectorEndBID connectorEndBID
//        {
//            get
//            {
//                return connectorEndBIDField;
//            }
//            set
//            {
//                connectorEndBIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlArrayItem("mdElement", IsNullable = false)]
//        public filePartMdElementPartsMdElementMdElement1[] parts
//        {
//            get
//            {
//                return partsField;
//            }
//            set
//            {
//                partsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string elementClass
//        {
//            get
//            {
//                return elementClassField;
//            }
//            set
//            {
//                elementClassField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementElementID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementLinkFirstEndID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementLinkSecondEndID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementProperties
//    {

//        private filePartMdElementPartsMdElementPropertiesMdElement mdElementField;

//        /// <remarks/>
//        public filePartMdElementPartsMdElementPropertiesMdElement mdElement
//        {
//            get
//            {
//                return mdElementField;
//            }
//            set
//            {
//                mdElementField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementPropertiesMdElement
//    {

//        private string propertyIDField;

//        private string propertyGroupField;

//        private string propertyDescriptionIDField;

//        private filePartMdElementPartsMdElementPropertiesMdElementEditable editableField;

//        private filePartMdElementPartsMdElementPropertiesMdElementSelectableTypes selectableTypesField;

//        private filePartMdElementPartsMdElementPropertiesMdElementUseUnspecified useUnspecifiedField;

//        private filePartMdElementPartsMdElementPropertiesMdElementContainment containmentField;

//        private filePartMdElementPartsMdElementPropertiesMdElementTypeElement typeElementField;

//        private filePartMdElementPartsMdElementPropertiesMdElementParentApplicant parentApplicantField;

//        private string valueField;

//        private string elementClassField;

//        /// <remarks/>
//        public string propertyID
//        {
//            get
//            {
//                return propertyIDField;
//            }
//            set
//            {
//                propertyIDField = value;
//            }
//        }

//        /// <remarks/>
//        public string propertyGroup
//        {
//            get
//            {
//                return propertyGroupField;
//            }
//            set
//            {
//                propertyGroupField = value;
//            }
//        }

//        /// <remarks/>
//        public string propertyDescriptionID
//        {
//            get
//            {
//                return propertyDescriptionIDField;
//            }
//            set
//            {
//                propertyDescriptionIDField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPartsMdElementPropertiesMdElementEditable editable
//        {
//            get
//            {
//                return editableField;
//            }
//            set
//            {
//                editableField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPartsMdElementPropertiesMdElementSelectableTypes selectableTypes
//        {
//            get
//            {
//                return selectableTypesField;
//            }
//            set
//            {
//                selectableTypesField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPartsMdElementPropertiesMdElementUseUnspecified useUnspecified
//        {
//            get
//            {
//                return useUnspecifiedField;
//            }
//            set
//            {
//                useUnspecifiedField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPartsMdElementPropertiesMdElementContainment containment
//        {
//            get
//            {
//                return containmentField;
//            }
//            set
//            {
//                containmentField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPartsMdElementPropertiesMdElementTypeElement typeElement
//        {
//            get
//            {
//                return typeElementField;
//            }
//            set
//            {
//                typeElementField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPartsMdElementPropertiesMdElementParentApplicant parentApplicant
//        {
//            get
//            {
//                return parentApplicantField;
//            }
//            set
//            {
//                parentApplicantField = value;
//            }
//        }

//        /// <remarks/>
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string elementClass
//        {
//            get
//            {
//                return elementClassField;
//            }
//            set
//            {
//                elementClassField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementPropertiesMdElementEditable
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementPropertiesMdElementSelectableTypes
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementPropertiesMdElementUseUnspecified
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementPropertiesMdElementContainment
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementPropertiesMdElementTypeElement
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementPropertiesMdElementParentApplicant
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementCompartment
//    {

//        private string compartmentIDField;

//        private bool isContentLockedField;

//        private bool isContentLockedFieldSpecified;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string compartmentID
//        {
//            get
//            {
//                return compartmentIDField;
//            }
//            set
//            {
//                compartmentIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool isContentLocked
//        {
//            get
//            {
//                return isContentLockedField;
//            }
//            set
//            {
//                isContentLockedField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool isContentLockedSpecified
//        {
//            get
//            {
//                return isContentLockedFieldSpecified;
//            }
//            set
//            {
//                isContentLockedFieldSpecified = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementNameVisible
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementMdElement
//    {

//        private filePartMdElementPartsMdElementMdElementElementID elementIDField;

//        private string geometryField;

//        private filePartMdElementPartsMdElementMdElementEdge edgeField;

//        private filePartMdElementPartsMdElementMdElementCompartment compartmentField;

//        private filePartMdElementPartsMdElementMdElementMdOwnedViews mdOwnedViewsField;

//        private filePartMdElementPartsMdElementMdElementNameID nameIDField;

//        private string elementClassField;

//        private string idField;

//        /// <remarks/>
//        public filePartMdElementPartsMdElementMdElementElementID elementID
//        {
//            get
//            {
//                return elementIDField;
//            }
//            set
//            {
//                elementIDField = value;
//            }
//        }

//        /// <remarks/>
//        public string geometry
//        {
//            get
//            {
//                return geometryField;
//            }
//            set
//            {
//                geometryField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPartsMdElementMdElementEdge edge
//        {
//            get
//            {
//                return edgeField;
//            }
//            set
//            {
//                edgeField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPartsMdElementMdElementCompartment compartment
//        {
//            get
//            {
//                return compartmentField;
//            }
//            set
//            {
//                compartmentField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPartsMdElementMdElementMdOwnedViews mdOwnedViews
//        {
//            get
//            {
//                return mdOwnedViewsField;
//            }
//            set
//            {
//                mdOwnedViewsField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPartsMdElementMdElementNameID nameID
//        {
//            get
//            {
//                return nameIDField;
//            }
//            set
//            {
//                nameIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string elementClass
//        {
//            get
//            {
//                return elementClassField;
//            }
//            set
//            {
//                elementClassField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementMdElementElementID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementMdElementEdge
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementMdElementCompartment
//    {

//        private string compartmentIDField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string compartmentID
//        {
//            get
//            {
//                return compartmentIDField;
//            }
//            set
//            {
//                compartmentIDField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementMdElementMdOwnedViews
//    {

//        private filePartMdElementPartsMdElementMdElementMdOwnedViewsMdElement mdElementField;

//        /// <remarks/>
//        public filePartMdElementPartsMdElementMdElementMdOwnedViewsMdElement mdElement
//        {
//            get
//            {
//                return mdElementField;
//            }
//            set
//            {
//                mdElementField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementMdElementMdOwnedViewsMdElement
//    {

//        private string geometryField;

//        private object mdOwnedViewsField;

//        private string textField;

//        private string elementClassField;

//        private string idField;

//        /// <remarks/>
//        public string geometry
//        {
//            get
//            {
//                return geometryField;
//            }
//            set
//            {
//                geometryField = value;
//            }
//        }

//        /// <remarks/>
//        public object mdOwnedViews
//        {
//            get
//            {
//                return mdOwnedViewsField;
//            }
//            set
//            {
//                mdOwnedViewsField = value;
//            }
//        }

//        /// <remarks/>
//        public string text
//        {
//            get
//            {
//                return textField;
//            }
//            set
//            {
//                textField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string elementClass
//        {
//            get
//            {
//                return elementClassField;
//            }
//            set
//            {
//                elementClassField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementMdElementNameID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementConnectorEndAID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementConnectorEndBID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementMdElement1
//    {

//        private filePartMdElementPartsMdElementMdElementElementID1 elementIDField;

//        private filePartMdElementPartsMdElementMdElementLinkFirstEndID linkFirstEndIDField;

//        private filePartMdElementPartsMdElementMdElementLinkSecondEndID linkSecondEndIDField;

//        private filePartMdElementPartsMdElementMdElementProperties propertiesField;

//        private string geometryField;

//        private filePartMdElementPartsMdElementMdElementCompartment1[] compartmentField;

//        private filePartMdElementPartsMdElementMdElementNameVisible nameVisibleField;

//        private filePartMdElementPartsMdElementMdElementMdElement[] mdOwnedViewsField;

//        private filePartMdElementPartsMdElementMdElementConnectorEndAID connectorEndAIDField;

//        private filePartMdElementPartsMdElementMdElementConnectorEndBID connectorEndBIDField;

//        private string elementClassField;

//        private string idField;

//        /// <remarks/>
//        public filePartMdElementPartsMdElementMdElementElementID1 elementID
//        {
//            get
//            {
//                return elementIDField;
//            }
//            set
//            {
//                elementIDField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPartsMdElementMdElementLinkFirstEndID linkFirstEndID
//        {
//            get
//            {
//                return linkFirstEndIDField;
//            }
//            set
//            {
//                linkFirstEndIDField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPartsMdElementMdElementLinkSecondEndID linkSecondEndID
//        {
//            get
//            {
//                return linkSecondEndIDField;
//            }
//            set
//            {
//                linkSecondEndIDField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPartsMdElementMdElementProperties properties
//        {
//            get
//            {
//                return propertiesField;
//            }
//            set
//            {
//                propertiesField = value;
//            }
//        }

//        /// <remarks/>
//        public string geometry
//        {
//            get
//            {
//                return geometryField;
//            }
//            set
//            {
//                geometryField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("compartment")]
//        public filePartMdElementPartsMdElementMdElementCompartment1[] compartment
//        {
//            get
//            {
//                return compartmentField;
//            }
//            set
//            {
//                compartmentField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPartsMdElementMdElementNameVisible nameVisible
//        {
//            get
//            {
//                return nameVisibleField;
//            }
//            set
//            {
//                nameVisibleField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlArrayItem("mdElement", IsNullable = false)]
//        public filePartMdElementPartsMdElementMdElementMdElement[] mdOwnedViews
//        {
//            get
//            {
//                return mdOwnedViewsField;
//            }
//            set
//            {
//                mdOwnedViewsField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPartsMdElementMdElementConnectorEndAID connectorEndAID
//        {
//            get
//            {
//                return connectorEndAIDField;
//            }
//            set
//            {
//                connectorEndAIDField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPartsMdElementMdElementConnectorEndBID connectorEndBID
//        {
//            get
//            {
//                return connectorEndBIDField;
//            }
//            set
//            {
//                connectorEndBIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string elementClass
//        {
//            get
//            {
//                return elementClassField;
//            }
//            set
//            {
//                elementClassField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementMdElementElementID1
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementMdElementLinkFirstEndID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementMdElementLinkSecondEndID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementMdElementProperties
//    {

//        private filePartMdElementPartsMdElementMdElementPropertiesMdElement mdElementField;

//        /// <remarks/>
//        public filePartMdElementPartsMdElementMdElementPropertiesMdElement mdElement
//        {
//            get
//            {
//                return mdElementField;
//            }
//            set
//            {
//                mdElementField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementMdElementPropertiesMdElement
//    {

//        private string propertyIDField;

//        private string propertyGroupField;

//        private string propertyDescriptionIDField;

//        private filePartMdElementPartsMdElementMdElementPropertiesMdElementEditable editableField;

//        private filePartMdElementPartsMdElementMdElementPropertiesMdElementSelectableTypes selectableTypesField;

//        private filePartMdElementPartsMdElementMdElementPropertiesMdElementUseUnspecified useUnspecifiedField;

//        private filePartMdElementPartsMdElementMdElementPropertiesMdElementContainment containmentField;

//        private filePartMdElementPartsMdElementMdElementPropertiesMdElementTypeElement typeElementField;

//        private filePartMdElementPartsMdElementMdElementPropertiesMdElementParentApplicant parentApplicantField;

//        private string valueField;

//        private string elementClassField;

//        /// <remarks/>
//        public string propertyID
//        {
//            get
//            {
//                return propertyIDField;
//            }
//            set
//            {
//                propertyIDField = value;
//            }
//        }

//        /// <remarks/>
//        public string propertyGroup
//        {
//            get
//            {
//                return propertyGroupField;
//            }
//            set
//            {
//                propertyGroupField = value;
//            }
//        }

//        /// <remarks/>
//        public string propertyDescriptionID
//        {
//            get
//            {
//                return propertyDescriptionIDField;
//            }
//            set
//            {
//                propertyDescriptionIDField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPartsMdElementMdElementPropertiesMdElementEditable editable
//        {
//            get
//            {
//                return editableField;
//            }
//            set
//            {
//                editableField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPartsMdElementMdElementPropertiesMdElementSelectableTypes selectableTypes
//        {
//            get
//            {
//                return selectableTypesField;
//            }
//            set
//            {
//                selectableTypesField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPartsMdElementMdElementPropertiesMdElementUseUnspecified useUnspecified
//        {
//            get
//            {
//                return useUnspecifiedField;
//            }
//            set
//            {
//                useUnspecifiedField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPartsMdElementMdElementPropertiesMdElementContainment containment
//        {
//            get
//            {
//                return containmentField;
//            }
//            set
//            {
//                containmentField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPartsMdElementMdElementPropertiesMdElementTypeElement typeElement
//        {
//            get
//            {
//                return typeElementField;
//            }
//            set
//            {
//                typeElementField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPartsMdElementMdElementPropertiesMdElementParentApplicant parentApplicant
//        {
//            get
//            {
//                return parentApplicantField;
//            }
//            set
//            {
//                parentApplicantField = value;
//            }
//        }

//        /// <remarks/>
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string elementClass
//        {
//            get
//            {
//                return elementClassField;
//            }
//            set
//            {
//                elementClassField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementMdElementPropertiesMdElementEditable
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementMdElementPropertiesMdElementSelectableTypes
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementMdElementPropertiesMdElementUseUnspecified
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementMdElementPropertiesMdElementContainment
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementMdElementPropertiesMdElementTypeElement
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementMdElementPropertiesMdElementParentApplicant
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementMdElementCompartment1
//    {

//        private string compartmentIDField;

//        private bool isContentLockedField;

//        private bool isContentLockedFieldSpecified;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string compartmentID
//        {
//            get
//            {
//                return compartmentIDField;
//            }
//            set
//            {
//                compartmentIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool isContentLocked
//        {
//            get
//            {
//                return isContentLockedField;
//            }
//            set
//            {
//                isContentLockedField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool isContentLockedSpecified
//        {
//            get
//            {
//                return isContentLockedFieldSpecified;
//            }
//            set
//            {
//                isContentLockedFieldSpecified = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementMdElementNameVisible
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementMdElementMdElement
//    {

//        private filePartMdElementPartsMdElementMdElementMdElementElementID elementIDField;

//        private string geometryField;

//        private filePartMdElementPartsMdElementMdElementMdElementCompartment compartmentField;

//        private string elementClassField;

//        private string idField;

//        /// <remarks/>
//        public filePartMdElementPartsMdElementMdElementMdElementElementID elementID
//        {
//            get
//            {
//                return elementIDField;
//            }
//            set
//            {
//                elementIDField = value;
//            }
//        }

//        /// <remarks/>
//        public string geometry
//        {
//            get
//            {
//                return geometryField;
//            }
//            set
//            {
//                geometryField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPartsMdElementMdElementMdElementCompartment compartment
//        {
//            get
//            {
//                return compartmentField;
//            }
//            set
//            {
//                compartmentField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string elementClass
//        {
//            get
//            {
//                return elementClassField;
//            }
//            set
//            {
//                elementClassField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementMdElementMdElementElementID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementMdElementMdElementCompartment
//    {

//        private string compartmentIDField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string compartmentID
//        {
//            get
//            {
//                return compartmentIDField;
//            }
//            set
//            {
//                compartmentIDField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementMdElementConnectorEndAID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPartsMdElementMdElementConnectorEndBID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementProperties
//    {

//        private filePartMdElementPropertiesMdElement[] mdElementField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("mdElement")]
//        public filePartMdElementPropertiesMdElement[] mdElement
//        {
//            get
//            {
//                return mdElementField;
//            }
//            set
//            {
//                mdElementField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPropertiesMdElement
//    {

//        private string propertyIDField;

//        private string propertyGroupField;

//        private string propertyDescriptionIDField;

//        private string propertyResourceIDField;

//        private filePartMdElementPropertiesMdElementEditable editableField;

//        private filePartMdElementPropertiesMdElementSelectableTypes selectableTypesField;

//        private filePartMdElementPropertiesMdElementUseUnspecified useUnspecifiedField;

//        private filePartMdElementPropertiesMdElementContainment containmentField;

//        private filePartMdElementPropertiesMdElementTypeElement typeElementField;

//        private filePartMdElementPropertiesMdElementParentApplicant parentApplicantField;

//        private filePartMdElementPropertiesMdElementValue valueField;

//        private filePartMdElementPropertiesMdElementChoice choiceField;

//        private filePartMdElementPropertiesMdElementIndex indexField;

//        private string elementClassField;

//        /// <remarks/>
//        public string propertyID
//        {
//            get
//            {
//                return propertyIDField;
//            }
//            set
//            {
//                propertyIDField = value;
//            }
//        }

//        /// <remarks/>
//        public string propertyGroup
//        {
//            get
//            {
//                return propertyGroupField;
//            }
//            set
//            {
//                propertyGroupField = value;
//            }
//        }

//        /// <remarks/>
//        public string propertyDescriptionID
//        {
//            get
//            {
//                return propertyDescriptionIDField;
//            }
//            set
//            {
//                propertyDescriptionIDField = value;
//            }
//        }

//        /// <remarks/>
//        public string propertyResourceID
//        {
//            get
//            {
//                return propertyResourceIDField;
//            }
//            set
//            {
//                propertyResourceIDField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPropertiesMdElementEditable editable
//        {
//            get
//            {
//                return editableField;
//            }
//            set
//            {
//                editableField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPropertiesMdElementSelectableTypes selectableTypes
//        {
//            get
//            {
//                return selectableTypesField;
//            }
//            set
//            {
//                selectableTypesField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPropertiesMdElementUseUnspecified useUnspecified
//        {
//            get
//            {
//                return useUnspecifiedField;
//            }
//            set
//            {
//                useUnspecifiedField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPropertiesMdElementContainment containment
//        {
//            get
//            {
//                return containmentField;
//            }
//            set
//            {
//                containmentField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPropertiesMdElementTypeElement typeElement
//        {
//            get
//            {
//                return typeElementField;
//            }
//            set
//            {
//                typeElementField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPropertiesMdElementParentApplicant parentApplicant
//        {
//            get
//            {
//                return parentApplicantField;
//            }
//            set
//            {
//                parentApplicantField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPropertiesMdElementValue value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPropertiesMdElementChoice choice
//        {
//            get
//            {
//                return choiceField;
//            }
//            set
//            {
//                choiceField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementPropertiesMdElementIndex index
//        {
//            get
//            {
//                return indexField;
//            }
//            set
//            {
//                indexField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string elementClass
//        {
//            get
//            {
//                return elementClassField;
//            }
//            set
//            {
//                elementClassField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPropertiesMdElementEditable
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPropertiesMdElementSelectableTypes
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPropertiesMdElementUseUnspecified
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPropertiesMdElementContainment
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPropertiesMdElementTypeElement
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPropertiesMdElementParentApplicant
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPropertiesMdElementValue
//    {

//        private string valueField;

//        private string valueField1;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlText()]
//        public string Value
//        {
//            get
//            {
//                return valueField1;
//            }
//            set
//            {
//                valueField1 = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPropertiesMdElementChoice
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementPropertiesMdElementIndex
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementRegions
//    {

//        private filePartMdElementRegionsMdElement mdElementField;

//        /// <remarks/>
//        public filePartMdElementRegionsMdElement mdElement
//        {
//            get
//            {
//                return mdElementField;
//            }
//            set
//            {
//                mdElementField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementRegionsMdElement
//    {

//        private filePartMdElementRegionsMdElementElementID elementIDField;

//        private string geometryField;

//        private filePartMdElementRegionsMdElementMdElement[] mdOwnedViewsField;

//        private string elementClassField;

//        private string idField;

//        /// <remarks/>
//        public filePartMdElementRegionsMdElementElementID elementID
//        {
//            get
//            {
//                return elementIDField;
//            }
//            set
//            {
//                elementIDField = value;
//            }
//        }

//        /// <remarks/>
//        public string geometry
//        {
//            get
//            {
//                return geometryField;
//            }
//            set
//            {
//                geometryField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlArrayItem("mdElement", IsNullable = false)]
//        public filePartMdElementRegionsMdElementMdElement[] mdOwnedViews
//        {
//            get
//            {
//                return mdOwnedViewsField;
//            }
//            set
//            {
//                mdOwnedViewsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string elementClass
//        {
//            get
//            {
//                return elementClassField;
//            }
//            set
//            {
//                elementClassField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementRegionsMdElementElementID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementRegionsMdElementMdElement
//    {

//        private filePartMdElementRegionsMdElementMdElementElementID elementIDField;

//        private filePartMdElementRegionsMdElementMdElementLinkFirstEndID linkFirstEndIDField;

//        private filePartMdElementRegionsMdElementMdElementLinkSecondEndID linkSecondEndIDField;

//        private filePartMdElementRegionsMdElementMdElementMdElement[] propertiesField;

//        private string geometryField;

//        private filePartMdElementRegionsMdElementMdElementCompartment compartmentField;

//        private filePartMdElementRegionsMdElementMdElementLinkNameID linkNameIDField;

//        private filePartMdElementRegionsMdElementMdElementNameVisible nameVisibleField;

//        private filePartMdElementRegionsMdElementMdElementMdOwnedViews mdOwnedViewsField;

//        private filePartMdElementRegionsMdElementMdElementRegions regionsField;

//        private string elementClassField;

//        private string idField;

//        /// <remarks/>
//        public filePartMdElementRegionsMdElementMdElementElementID elementID
//        {
//            get
//            {
//                return elementIDField;
//            }
//            set
//            {
//                elementIDField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementRegionsMdElementMdElementLinkFirstEndID linkFirstEndID
//        {
//            get
//            {
//                return linkFirstEndIDField;
//            }
//            set
//            {
//                linkFirstEndIDField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementRegionsMdElementMdElementLinkSecondEndID linkSecondEndID
//        {
//            get
//            {
//                return linkSecondEndIDField;
//            }
//            set
//            {
//                linkSecondEndIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlArrayItem("mdElement", IsNullable = false)]
//        public filePartMdElementRegionsMdElementMdElementMdElement[] properties
//        {
//            get
//            {
//                return propertiesField;
//            }
//            set
//            {
//                propertiesField = value;
//            }
//        }

//        /// <remarks/>
//        public string geometry
//        {
//            get
//            {
//                return geometryField;
//            }
//            set
//            {
//                geometryField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementRegionsMdElementMdElementCompartment compartment
//        {
//            get
//            {
//                return compartmentField;
//            }
//            set
//            {
//                compartmentField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementRegionsMdElementMdElementLinkNameID linkNameID
//        {
//            get
//            {
//                return linkNameIDField;
//            }
//            set
//            {
//                linkNameIDField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementRegionsMdElementMdElementNameVisible nameVisible
//        {
//            get
//            {
//                return nameVisibleField;
//            }
//            set
//            {
//                nameVisibleField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementRegionsMdElementMdElementMdOwnedViews mdOwnedViews
//        {
//            get
//            {
//                return mdOwnedViewsField;
//            }
//            set
//            {
//                mdOwnedViewsField = value;
//            }
//        }

//        /// <remarks/>
//        public filePartMdElementRegionsMdElementMdElementRegions regions
//        {
//            get
//            {
//                return regionsField;
//            }
//            set
//            {
//                regionsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string elementClass
//        {
//            get
//            {
//                return elementClassField;
//            }
//            set
//            {
//                elementClassField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementRegionsMdElementMdElementElementID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementRegionsMdElementMdElementLinkFirstEndID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementRegionsMdElementMdElementLinkSecondEndID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementRegionsMdElementMdElementMdElement
//    {

//        private string propertyIDField;

//        private string propertyDescriptionIDField;

//        private string elementClassField;

//        /// <remarks/>
//        public string propertyID
//        {
//            get
//            {
//                return propertyIDField;
//            }
//            set
//            {
//                propertyIDField = value;
//            }
//        }

//        /// <remarks/>
//        public string propertyDescriptionID
//        {
//            get
//            {
//                return propertyDescriptionIDField;
//            }
//            set
//            {
//                propertyDescriptionIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string elementClass
//        {
//            get
//            {
//                return elementClassField;
//            }
//            set
//            {
//                elementClassField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementRegionsMdElementMdElementCompartment
//    {

//        private string compartmentIDField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string compartmentID
//        {
//            get
//            {
//                return compartmentIDField;
//            }
//            set
//            {
//                compartmentIDField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementRegionsMdElementMdElementLinkNameID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementRegionsMdElementMdElementNameVisible
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementRegionsMdElementMdElementMdOwnedViews
//    {

//        private filePartMdElementRegionsMdElementMdElementMdOwnedViewsMdElement mdElementField;

//        /// <remarks/>
//        public filePartMdElementRegionsMdElementMdElementMdOwnedViewsMdElement mdElement
//        {
//            get
//            {
//                return mdElementField;
//            }
//            set
//            {
//                mdElementField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementRegionsMdElementMdElementMdOwnedViewsMdElement
//    {

//        private string geometryField;

//        private object mdOwnedViewsField;

//        private string textField;

//        private string elementClassField;

//        private string idField;

//        /// <remarks/>
//        public string geometry
//        {
//            get
//            {
//                return geometryField;
//            }
//            set
//            {
//                geometryField = value;
//            }
//        }

//        /// <remarks/>
//        public object mdOwnedViews
//        {
//            get
//            {
//                return mdOwnedViewsField;
//            }
//            set
//            {
//                mdOwnedViewsField = value;
//            }
//        }

//        /// <remarks/>
//        public string text
//        {
//            get
//            {
//                return textField;
//            }
//            set
//            {
//                textField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string elementClass
//        {
//            get
//            {
//                return elementClassField;
//            }
//            set
//            {
//                elementClassField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementRegionsMdElementMdElementRegions
//    {

//        private filePartMdElementRegionsMdElementMdElementRegionsMdElement mdElementField;

//        /// <remarks/>
//        public filePartMdElementRegionsMdElementMdElementRegionsMdElement mdElement
//        {
//            get
//            {
//                return mdElementField;
//            }
//            set
//            {
//                mdElementField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementRegionsMdElementMdElementRegionsMdElement
//    {

//        private filePartMdElementRegionsMdElementMdElementRegionsMdElementElementID elementIDField;

//        private string geometryField;

//        private object mdOwnedViewsField;

//        private string elementClassField;

//        private string idField;

//        /// <remarks/>
//        public filePartMdElementRegionsMdElementMdElementRegionsMdElementElementID elementID
//        {
//            get
//            {
//                return elementIDField;
//            }
//            set
//            {
//                elementIDField = value;
//            }
//        }

//        /// <remarks/>
//        public string geometry
//        {
//            get
//            {
//                return geometryField;
//            }
//            set
//            {
//                geometryField = value;
//            }
//        }

//        /// <remarks/>
//        public object mdOwnedViews
//        {
//            get
//            {
//                return mdOwnedViewsField;
//            }
//            set
//            {
//                mdOwnedViewsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string elementClass
//        {
//            get
//            {
//                return elementClassField;
//            }
//            set
//            {
//                elementClassField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementRegionsMdElementMdElementRegionsMdElementElementID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementTreeID
//    {

//        private string idrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string idref
//        {
//            get
//            {
//                return idrefField;
//            }
//            set
//            {
//                idrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementVertical
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementVerticalBarX
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class filePartMdElementVerticalBarY
//    {

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/spec/XMI/20131001")]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.Xml.Serialization.XmlType(IncludeInSchema = false)]
//    public enum ItemsChoiceType
//    {

//        /// <remarks/>
//        ATTRIBUTES_compartmentChildren,

//        /// <remarks/>
//        COMPARTMENT_ID_VALUES_compartmentChildren,

//        /// <remarks/>
//        ENUMERATION_LITERALS_compartmentChildren,

//        /// <remarks/>
//        active,

//        /// <remarks/>
//        associationFirstEndID,

//        /// <remarks/>
//        associationSecondEndID,

//        /// <remarks/>
//        baseShape,

//        /// <remarks/>
//        compartment,

//        /// <remarks/>
//        elementID,

//        /// <remarks/>
//        elementProperties,

//        /// <remarks/>
//        geometry,

//        /// <remarks/>
//        horizontalBarLeft,

//        /// <remarks/>
//        horizontalBarRight,

//        /// <remarks/>
//        horizontalBarY,

//        /// <remarks/>
//        horizontalCenterline,

//        /// <remarks/>
//        implicitlySetY,

//        /// <remarks/>
//        linkFirstEndID,

//        /// <remarks/>
//        linkNameID,

//        /// <remarks/>
//        linkRoleA,

//        /// <remarks/>
//        linkRoleB,

//        /// <remarks/>
//        linkSecondEndID,

//        /// <remarks/>
//        linkSlots,

//        /// <remarks/>
//        linkStereotypeID,

//        /// <remarks/>
//        linkTaggedValuesID,

//        /// <remarks/>
//        mdOwnedViews,

//        /// <remarks/>
//        nameID,

//        /// <remarks/>
//        nameVisible,

//        /// <remarks/>
//        operands,

//        /// <remarks/>
//        parts,

//        /// <remarks/>
//        properties,

//        /// <remarks/>
//        regions,

//        /// <remarks/>
//        text,

//        /// <remarks/>
//        treeID,

//        /// <remarks/>
//        vertical,

//        /// <remarks/>
//        verticalBarX,

//        /// <remarks/>
//        verticalBarY,

//        /// <remarks/>
//        verticalCenterline,
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.nomagic.com/ns/cameo/client/project/1.0")]
//    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.nomagic.com/ns/cameo/client/project/1.0", IsNullable = false)]
//    public partial class Project
//    {

//        private ownedSections[] ownedSectionsField;

//        private userParts userPartsField;

//        private projectUsages[] projectUsagesField;

//        private features[] featuresField;

//        private properties[] propertiesField;

//        private projectUsers projectUsersField;

//        private decimal versionField;

//        private string idField;

//        private string descriptionField;

//        private string id1Field;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("ownedSections", Namespace = "")]
//        public ownedSections[] ownedSections
//        {
//            get
//            {
//                return ownedSectionsField;
//            }
//            set
//            {
//                ownedSectionsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "")]
//        public userParts userParts
//        {
//            get
//            {
//                return userPartsField;
//            }
//            set
//            {
//                userPartsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("projectUsages", Namespace = "")]
//        public projectUsages[] projectUsages
//        {
//            get
//            {
//                return projectUsagesField;
//            }
//            set
//            {
//                projectUsagesField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("features", Namespace = "")]
//        public features[] features
//        {
//            get
//            {
//                return featuresField;
//            }
//            set
//            {
//                featuresField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("properties", Namespace = "")]
//        public properties[] properties
//        {
//            get
//            {
//                return propertiesField;
//            }
//            set
//            {
//                propertiesField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement(Namespace = "")]
//        public projectUsers projectUsers
//        {
//            get
//            {
//                return projectUsersField;
//            }
//            set
//            {
//                projectUsersField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public decimal version
//        {
//            get
//            {
//                return versionField;
//            }
//            set
//            {
//                versionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string description
//        {
//            get
//            {
//                return descriptionField;
//            }
//            set
//            {
//                descriptionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute("id")]
//        public string id1
//        {
//            get
//            {
//                return id1Field;
//            }
//            set
//            {
//                id1Field = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
//    public partial class ownedSections
//    {

//        private ownedSectionsSharePoints sharePointsField;

//        private string idField;

//        private string nameField;

//        private string featuredByField;

//        private bool sharedField;

//        private bool sharedFieldSpecified;

//        private string belongsToField;

//        /// <remarks/>
//        public ownedSectionsSharePoints sharePoints
//        {
//            get
//            {
//                return sharePointsField;
//            }
//            set
//            {
//                sharePointsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string featuredBy
//        {
//            get
//            {
//                return featuredByField;
//            }
//            set
//            {
//                featuredByField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool shared
//        {
//            get
//            {
//                return sharedField;
//            }
//            set
//            {
//                sharedField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool sharedSpecified
//        {
//            get
//            {
//                return sharedFieldSpecified;
//            }
//            set
//            {
//                sharedFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string belongsTo
//        {
//            get
//            {
//                return belongsToField;
//            }
//            set
//            {
//                belongsToField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class ownedSectionsSharePoints
//    {

//        private ownedSectionsSharePointsObject objectField;

//        private ownedSectionsSharePointsOptions optionsField;

//        private string idField;

//        private string idField1;

//        /// <remarks/>
//        public ownedSectionsSharePointsObject @object
//        {
//            get
//            {
//                return objectField;
//            }
//            set
//            {
//                objectField = value;
//            }
//        }

//        /// <remarks/>
//        public ownedSectionsSharePointsOptions options
//        {
//            get
//            {
//                return optionsField;
//            }
//            set
//            {
//                optionsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string ID
//        {
//            get
//            {
//                return idField1;
//            }
//            set
//            {
//                idField1 = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class ownedSectionsSharePointsObject
//    {

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class ownedSectionsSharePointsOptions
//    {

//        private string idField;

//        private string keyField;

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string key
//        {
//            get
//            {
//                return keyField;
//            }
//            set
//            {
//                keyField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
//    public partial class userParts
//    {

//        private string idField;

//        private string userField;

//        private string sectionsField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string user
//        {
//            get
//            {
//                return userField;
//            }
//            set
//            {
//                userField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string sections
//        {
//            get
//            {
//                return sectionsField;
//            }
//            set
//            {
//                sectionsField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
//    public partial class projectUsages
//    {

//        private projectUsagesUsedProject usedProjectField;

//        private projectUsagesMountPoints mountPointsField;

//        private projectUsagesProperties[] propertiesField;

//        private string idField;

//        private string usedProjectURIField;

//        private bool resharedField;

//        private bool resharedFieldSpecified;

//        private bool readonlyField;

//        private string preferredProjectRepositoryTypeField;

//        private bool loadedAutomaticallyField;

//        private bool loadedAutomaticallyFieldSpecified;

//        private bool withPrivateDependenciesField;

//        private bool withPrivateDependenciesFieldSpecified;

//        private bool automaticField;

//        private bool automaticFieldSpecified;

//        private string alternateLocationField;

//        private bool resharedAutomaticallyField;

//        private bool resharedAutomaticallyFieldSpecified;

//        /// <remarks/>
//        public projectUsagesUsedProject usedProject
//        {
//            get
//            {
//                return usedProjectField;
//            }
//            set
//            {
//                usedProjectField = value;
//            }
//        }

//        /// <remarks/>
//        public projectUsagesMountPoints mountPoints
//        {
//            get
//            {
//                return mountPointsField;
//            }
//            set
//            {
//                mountPointsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("properties")]
//        public projectUsagesProperties[] properties
//        {
//            get
//            {
//                return propertiesField;
//            }
//            set
//            {
//                propertiesField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string usedProjectURI
//        {
//            get
//            {
//                return usedProjectURIField;
//            }
//            set
//            {
//                usedProjectURIField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool reshared
//        {
//            get
//            {
//                return resharedField;
//            }
//            set
//            {
//                resharedField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool resharedSpecified
//        {
//            get
//            {
//                return resharedFieldSpecified;
//            }
//            set
//            {
//                resharedFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool @readonly
//        {
//            get
//            {
//                return readonlyField;
//            }
//            set
//            {
//                readonlyField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string preferredProjectRepositoryType
//        {
//            get
//            {
//                return preferredProjectRepositoryTypeField;
//            }
//            set
//            {
//                preferredProjectRepositoryTypeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool loadedAutomatically
//        {
//            get
//            {
//                return loadedAutomaticallyField;
//            }
//            set
//            {
//                loadedAutomaticallyField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool loadedAutomaticallySpecified
//        {
//            get
//            {
//                return loadedAutomaticallyFieldSpecified;
//            }
//            set
//            {
//                loadedAutomaticallyFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool withPrivateDependencies
//        {
//            get
//            {
//                return withPrivateDependenciesField;
//            }
//            set
//            {
//                withPrivateDependenciesField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool withPrivateDependenciesSpecified
//        {
//            get
//            {
//                return withPrivateDependenciesFieldSpecified;
//            }
//            set
//            {
//                withPrivateDependenciesFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool automatic
//        {
//            get
//            {
//                return automaticField;
//            }
//            set
//            {
//                automaticField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool automaticSpecified
//        {
//            get
//            {
//                return automaticFieldSpecified;
//            }
//            set
//            {
//                automaticFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string alternateLocation
//        {
//            get
//            {
//                return alternateLocationField;
//            }
//            set
//            {
//                alternateLocationField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public bool resharedAutomatically
//        {
//            get
//            {
//                return resharedAutomaticallyField;
//            }
//            set
//            {
//                resharedAutomaticallyField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool resharedAutomaticallySpecified
//        {
//            get
//            {
//                return resharedAutomaticallyFieldSpecified;
//            }
//            set
//            {
//                resharedAutomaticallyFieldSpecified = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class projectUsagesUsedProject
//    {

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class projectUsagesMountPoints
//    {

//        private projectUsagesMountPointsMountedPoint mountedPointField;

//        private projectUsagesMountPointsMountedOn mountedOnField;

//        private projectUsagesMountPointsOptions optionsField;

//        private projectUsagesMountPointsMountedSharePoint mountedSharePointField;

//        private string idField;

//        private string sharePointIDField;

//        private byte containmentFeatureIDField;

//        private string featureNameField;

//        private sbyte containmentIndexField;

//        private bool containmentIndexFieldSpecified;

//        private string containmentFeatureNameField;

//        /// <remarks/>
//        public projectUsagesMountPointsMountedPoint mountedPoint
//        {
//            get
//            {
//                return mountedPointField;
//            }
//            set
//            {
//                mountedPointField = value;
//            }
//        }

//        /// <remarks/>
//        public projectUsagesMountPointsMountedOn mountedOn
//        {
//            get
//            {
//                return mountedOnField;
//            }
//            set
//            {
//                mountedOnField = value;
//            }
//        }

//        /// <remarks/>
//        public projectUsagesMountPointsOptions options
//        {
//            get
//            {
//                return optionsField;
//            }
//            set
//            {
//                optionsField = value;
//            }
//        }

//        /// <remarks/>
//        public projectUsagesMountPointsMountedSharePoint mountedSharePoint
//        {
//            get
//            {
//                return mountedSharePointField;
//            }
//            set
//            {
//                mountedSharePointField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string sharePointID
//        {
//            get
//            {
//                return sharePointIDField;
//            }
//            set
//            {
//                sharePointIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public byte containmentFeatureID
//        {
//            get
//            {
//                return containmentFeatureIDField;
//            }
//            set
//            {
//                containmentFeatureIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string featureName
//        {
//            get
//            {
//                return featureNameField;
//            }
//            set
//            {
//                featureNameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public sbyte containmentIndex
//        {
//            get
//            {
//                return containmentIndexField;
//            }
//            set
//            {
//                containmentIndexField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnore()]
//        public bool containmentIndexSpecified
//        {
//            get
//            {
//                return containmentIndexFieldSpecified;
//            }
//            set
//            {
//                containmentIndexFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string containmentFeatureName
//        {
//            get
//            {
//                return containmentFeatureNameField;
//            }
//            set
//            {
//                containmentFeatureNameField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class projectUsagesMountPointsMountedPoint
//    {

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class projectUsagesMountPointsMountedOn
//    {

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class projectUsagesMountPointsOptions
//    {

//        private string idField;

//        private string keyField;

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string key
//        {
//            get
//            {
//                return keyField;
//            }
//            set
//            {
//                keyField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class projectUsagesMountPointsMountedSharePoint
//    {

//        private string hrefField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string href
//        {
//            get
//            {
//                return hrefField;
//            }
//            set
//            {
//                hrefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class projectUsagesProperties
//    {

//        private string idField;

//        private string keyField;

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string key
//        {
//            get
//            {
//                return keyField;
//            }
//            set
//            {
//                keyField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
//    public partial class features
//    {

//        private string idField;

//        private string nameField;

//        private string namespaceField;

//        private decimal versionField;

//        private string sectionsField;

//        private byte internalVersionField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string @namespace
//        {
//            get
//            {
//                return namespaceField;
//            }
//            set
//            {
//                namespaceField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public decimal version
//        {
//            get
//            {
//                return versionField;
//            }
//            set
//            {
//                versionField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string sections
//        {
//            get
//            {
//                return sectionsField;
//            }
//            set
//            {
//                sectionsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public byte internalVersion
//        {
//            get
//            {
//                return internalVersionField;
//            }
//            set
//            {
//                internalVersionField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
//    public partial class properties
//    {

//        private string idField;

//        private string keyField;

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string key
//        {
//            get
//            {
//                return keyField;
//            }
//            set
//            {
//                keyField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string value
//        {
//            get
//            {
//                return valueField;
//            }
//            set
//            {
//                valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
//    public partial class projectUsers
//    {

//        private string idField;

//        private string userIdField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.omg.org/XMI")]
//        public string id
//        {
//            get
//            {
//                return idField;
//            }
//            set
//            {
//                idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string userId
//        {
//            get
//            {
//                return userIdField;
//            }
//            set
//            {
//                userIdField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
//    public partial class stereotypesHREFS
//    {

//        private object[] itemsField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElement("stereotype", typeof(stereotypesHREFSStereotype))]
//        [System.Xml.Serialization.XmlElement("tag", typeof(stereotypesHREFSTag))]
//        public object[] Items
//        {
//            get
//            {
//                return itemsField;
//            }
//            set
//            {
//                itemsField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class stereotypesHREFSStereotype
//    {

//        private string nameField;

//        private string stereotypeHREFField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string stereotypeHREF
//        {
//            get
//            {
//                return stereotypeHREFField;
//            }
//            set
//            {
//                stereotypeHREFField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    public partial class stereotypesHREFSTag
//    {

//        private string nameField;

//        private string tagIDField;

//        private string tagURIField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string name
//        {
//            get
//            {
//                return nameField;
//            }
//            set
//            {
//                nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string tagID
//        {
//            get
//            {
//                return tagIDField;
//            }
//            set
//            {
//                tagIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string tagURI
//        {
//            get
//            {
//                return tagURIField;
//            }
//            set
//            {
//                tagURIField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
//    public partial class plugin
//    {

//        private string pluginNameField;

//        private decimal pluginVersionField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string pluginName
//        {
//            get
//            {
//                return pluginNameField;
//            }
//            set
//            {
//                pluginNameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public decimal pluginVersion
//        {
//            get
//            {
//                return pluginVersionField;
//            }
//            set
//            {
//                pluginVersionField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [System.Xml.Serialization.XmlType(AnonymousType = true)]
//    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
//    public partial class req_resource
//    {

//        private ushort resourceIDField;

//        private string resourceNameField;

//        private string resourceValueNameField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public ushort resourceID
//        {
//            get
//            {
//                return resourceIDField;
//            }
//            set
//            {
//                resourceIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string resourceName
//        {
//            get
//            {
//                return resourceNameField;
//            }
//            set
//            {
//                resourceNameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttribute()]
//        public string resourceValueName
//        {
//            get
//            {
//                return resourceValueNameField;
//            }
//            set
//            {
//                resourceValueNameField = value;
//            }
//        }
//    }


//}
