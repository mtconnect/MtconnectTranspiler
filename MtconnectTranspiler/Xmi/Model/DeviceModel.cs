using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Contracts.Attributes;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.Model
{
    public class DeviceModel : PackagedElement
    {
        /// <summary>
        /// Description content in Cameo
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT, Namespace = "")]
        public OwnedComment[]? Comments { get; set; }

        // TODO: Add XPATH attribute to get ./*[@xmi:type='uml:Package']
        [XPath("./*[@xmi:type='uml:Package']")]
        public DeviceModel[]? SubModels { get; set; }

        // TODO: Add XPATH attribute to get ./*[@xmi:type='uml:Class']
        [XPath("./*[@xmi:type='uml:Class']")]
        public UmlClass[]? Classes { get; set; }
    }
}