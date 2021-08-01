﻿using System.ComponentModel;
using System.ServiceModel;
using System.Xml.Serialization;
using System.Xml;
using SMEV3v11.Types.Basic;

namespace SMEV3v11.MessageContract
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(WrapperName = "GetIncomingQueueStatisticsRequest", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", IsWrapped = true)]
    public class GetIncomingQueueStatisticsRequestContract
    {

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", Order = 0)]
        public string NodeID;

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1", Order = 1)]
        [XmlElement(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1")]
        public Timestamp Timestamp;

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", Order = 2)]
        public XmlElement CallerInformationSystemSignature;

        public GetIncomingQueueStatisticsRequestContract(string NodeID, Timestamp Timestamp, XmlElement CallerInformationSystemSignature)
        {
            this.NodeID = NodeID;
            this.Timestamp = Timestamp;
            this.CallerInformationSystemSignature = CallerInformationSystemSignature;
        }
    }
}