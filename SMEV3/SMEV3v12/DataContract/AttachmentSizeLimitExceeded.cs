﻿using System.Runtime.Serialization;

namespace SMEV3v12.DataContract
{
    [DataContract(Name = "AttachmentSizeLimitExceeded", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
    public class AttachmentSizeLimitExceeded : SmevFault
    {
        [DataMember(IsRequired = true)]
        public long PermittedTotalAttachmentSize { get; set; }

        [DataMember(IsRequired = true)]
        public long RealTotalAttachmentSize { get; set; }
    }
}
