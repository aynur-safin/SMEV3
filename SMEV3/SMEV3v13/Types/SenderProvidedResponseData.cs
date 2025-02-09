﻿using SMEV3v13.Types.Basic;
using System;
using System.Xml.Serialization;
using System.Xml;

namespace SMEV3v13.Types
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3")]
    public class SenderProvidedResponseData
    {
        [XmlElement(Order = 0)]
        public string MessageID { get; set; }

        [XmlElement(Order = 1)]
        public string To { get; set; }

        [XmlElement("AsyncProcessingStatus", typeof(AsyncProcessingStatus), Order = 2)]
        [XmlElement("PersonalSignature", typeof(XmlElement), Order = 2)]
        [XmlElement("RequestRejected", typeof(SenderProvidedResponseDataRequestRejected), Order = 2)]
        [XmlElement("RequestStatus", typeof(SenderProvidedResponseDataRequestStatus), Order = 2)]
        [XmlElement("AttachmentHeaderList", typeof(AttachmentHeaderList), Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", Order = 2)]
        [XmlElement("MessagePrimaryContent", typeof(XmlElement), Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", Order = 2)]
        [XmlElement("RefAttachmentHeaderList", typeof(RefAttachmentHeaderList), Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", Order = 2)]
        [XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items { get; set; }

        [XmlElement("ItemsElementName", Order = 3)]
        [XmlIgnore]
        public ItemsChoiceType[] ItemsElementName { get; set; }

        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }
}
