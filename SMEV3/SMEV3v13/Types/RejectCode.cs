﻿using System;
using System.Xml.Serialization;

namespace SMEV3v13.Types
{
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3")]
    public enum RejectCode
    {
        ACCESS_DENIED,

        NO_DATA,

        UNKNOWN_REQUEST_DESCRIPTION,

        FAILURE,
    }
}
