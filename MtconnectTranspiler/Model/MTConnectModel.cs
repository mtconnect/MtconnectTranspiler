using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Contracts.Attributes;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Xmi.Profile;
using MtconnectTranspiler.Xmi.UML;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Model
{
    /// <summary>
    /// Represents the root model for the MTConnect structure
    /// </summary>
    [Serializable, XmlRoot(ElementName = "Model", Namespace = XmlHelper.UmlNamespace)]
    public class MTConnectModel : XmiElement
    {
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT, Namespace = "")]
        public OwnedComment[]? Comments { get; set; }

        [XPath("./packagedElement[@xmi:type='uml:Profile'][@name='Profile']")]
        public MTConnectProfile? Profile { get; set; }

        [XPath("./packagedElement[@xmi:type='uml:Package'][@name='Asset Information Model']")]
        public MTConnectAssetInformationModel? AssetInformationModel { get; set; }

        [XPath("./packagedElement[@xmi:type='uml:Package'][@name='Fundamentals']")]
        public MTConnectFundamentals? Fundamentals { get; set; }

        [XPath("./packagedElement[@xmi:type='uml:Package'][@name='Observation Information Model']")]
        public MTConnectObservationInformationModel? ObservationInformationModel { get; set; }

        [XPath("./packagedElement[@xmi:type='uml:Package'][@name='Glossary']")]
        public MTConnectGlossary? Glossary { get; set; }

        [XPath("./packagedElement[@xmi:type='uml:Package'][@name='Agent Architecture']")]
        public MTConnectAgentArchitecture? AgentArchitecture { get; set; }


        [XPath("../Profile:normative")]
        public Normative[]? NormativeReferences { get; set; }

        [XPath("../Profile:deprecated")]
        public Deprecated[]? DeprecatedReferences { get; set; }

        [XPath("..//packagedElement[@xmi:type='uml:DataType']")]
        public UmlDataType[]? AllDataTypes { get; set; }

        [XPath("./packagedElement[@xmi:type='uml:Package'][@name='Device Information Model']")]
        public MTConnectDeviceInformationModel? DeviceModel { get; set; }
    }
}