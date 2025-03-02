﻿using System;
using System.Xml.Serialization;

namespace SMEV3v13.Types
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3")]
    public class AsyncProcessingStatusData
    {
        [XmlElement(Order = 0)]
        public AsyncProcessingStatus AsyncProcessingStatus { get; set; }

        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }
}
