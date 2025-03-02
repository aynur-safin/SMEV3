﻿using SMEV3v11.Types;
using System.ComponentModel;
using System.ServiceModel;
using System.Xml.Serialization;

namespace SMEV3v11.MessageContract
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(WrapperName = "GetIncomingQueueStatisticsResponse", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", IsWrapped = true)]
    public class GetIncomingQueueStatisticsResponseContract
    {
        /// <summary/>
        protected GetIncomingQueueStatisticsResponseContract() { }

        public GetIncomingQueueStatisticsResponseContract(QueueStatistics[] queueStatistics)
        {
            QueueStatistics = queueStatistics;
        }

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", Order = 0)]
        [XmlElement("QueueStatistics")]
        public QueueStatistics[] QueueStatistics;  
    }
}
