﻿using System.ServiceModel;
using System.Xml.Serialization;
using System.Xml;
using SMEV3v11.Types;
using SMEV3v11.Types.Basic;

namespace SMEV3v11.MessageContract
{
    /// <summary>
    /// Параметры метода "Послать ответ на запрос"
    /// </summary>
    [MessageContract(WrapperName = "SendResponseRequest", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", IsWrapped = true)]
    public class SendResponseRequestContract
    {
        /// <summary/>
        protected SendResponseRequestContract() { }

        public SendResponseRequestContract(SenderProvidedResponseData senderProvidedResponseData, AttachmentContentType[] attachmentContentList, XmlElement callerInformationSystemSignature)
        {
            SenderProvidedResponseData = senderProvidedResponseData;
            AttachmentContentList = attachmentContentList;
            CallerInformationSystemSignature = callerInformationSystemSignature;
        }

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", Order = 0)]
        public SenderProvidedResponseData SenderProvidedResponseData;

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1", Order = 1)]
        [XmlElement("AttachmentContentList", typeof(AttachmentContentList), Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1")]
        public AttachmentContentType[] AttachmentContentList;

        /// <summary>
        /// ЭП-ОВ или ЭП-ПГУ. Подписан элемент //SenderProvidedResponseData
        /// </summary>
        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", Order = 2)]
        public XmlElement CallerInformationSystemSignature;   
    }
}
