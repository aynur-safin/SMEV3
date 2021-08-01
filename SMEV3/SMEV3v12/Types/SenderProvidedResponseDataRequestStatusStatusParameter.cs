﻿using System;
using System.Xml.Serialization;

namespace SMEV3v12.Types
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2")]
    public class SenderProvidedResponseDataRequestStatusStatusParameter
    {
        [XmlElement(Order = 0)]
        public string Key { get; set; }

        [XmlElement(Order = 1)]
        public string Value { get; set; }
    }
}
