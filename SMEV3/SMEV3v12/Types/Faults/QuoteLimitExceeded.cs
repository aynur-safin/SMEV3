﻿using SMEV3v12.Types.Basic;
using System;
using System.Xml.Serialization;

namespace SMEV3v12.Types.Faults
{
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
    public class QuoteLimitExceeded : SmevFault
    {
        [XmlElement(Order = 0)]
        public long RemainedTotalQuoteSize { get; set; }

        [XmlElement(Order = 1)]
        public long RealTotalAttachmentSize { get; set; }
    }
}
