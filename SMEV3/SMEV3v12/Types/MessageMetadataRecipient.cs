﻿using System;
using System.Xml.Serialization;

namespace SMEV3v12.Types
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2")]
    public class MessageMetadataRecipient
    {
        [XmlElement(Order = 0)]
        public string Mnemonic { get; set; }
    }
}