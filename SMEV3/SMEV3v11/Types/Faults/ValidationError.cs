﻿using System;
using System.Xml.Serialization;

namespace SMEV3v11.Types.Faults
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.1")]
    public class ValidationError
    {
        /// <summary>
        /// Позиция в XML-документе, в которой валидатор обнаружил ошибку.
        /// </summary>
        [XmlAttribute]
        public int errorPosition { get; set; }

        [XmlText]
        public string Value { get; set; }
    }
}
