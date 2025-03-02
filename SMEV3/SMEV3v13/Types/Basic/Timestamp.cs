﻿using System;
using System.Xml.Serialization;

namespace SMEV3v13.Types.Basic
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
    public class Timestamp
    {
        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }

        [XmlText]
        public DateTime Value { get; set; }
    }
}
