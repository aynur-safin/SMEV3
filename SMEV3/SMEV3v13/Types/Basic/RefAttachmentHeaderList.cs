﻿using System;
using System.Xml.Serialization;

namespace SMEV3v13.Types.Basic
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
    public class RefAttachmentHeaderList
    {
        [XmlElement("RefAttachmentHeader", Order = 0)]
        public RefAttachmentHeaderType[] RefAttachmentHeader { get; set; }
    }
}
