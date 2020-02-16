namespace EdiNation.Edifact.EAND93A
{
    public class S001
    {
        public string SyntaxIdentifier_1;
        public string SyntaxVersionNumber_2;
        public string ServiceCodeListDirectoryVersionNumber_3;
        public string CharacterEncoding_4;
    }
    public class S002
    {
        public string InterchangeSenderIdentification_1;
        public string IdentificationCodeQualifier_2;
        public string InterchangeSenderInternalIdentification_3;
        public string InterchangeSenderInternalSubIdentification_4;
    }
    public class S003
    {
        public string InterchangeRecipientIdentification_1;
        public string IdentificationCodeQualifier_2;
        public string InterchangeRecipientInternalIdentification_3;
        public string InterchangeRecipientInternalSubIdentification_4;
    }
    public class S004
    {
        public string Date_1;
        public string Time_2;
    }
    public class S005
    {
        public string RecipientReferencePassword_1;
        public string RecipientReferencePasswordQualifier_2;
    }
    public class S006
    {
        public string ApplicationSenderIdentification_1;
        public string IdentificationCodeQualifier_2;
    }
    public class S007
    {
        public string ApplicationRecipientIdentification_1;
        public string IdentificationCodeQualifier_2;
    }
    public class S008
    {
        public string MessageVersionNumber_1;
        public string MessageReleaseNumber_2;
        public string AssociationAssignedCode_3;
    }
    public class S009
    {
        public string MessageType_01;
        public string MessageVersionNumber_02;
        public string MessageReleaseNumber_03;
        public string ControllingAgencyCoded_04;
        public string AssociationAssignedCode_05;
        public string CodelistDirectoryVersionNumber_06;
        public string MessageTypeSubfunctionIdentification_07;
    }
    public class S010
    {
        public string SequenceMessageTransferNumber_01;
        public string FirstLastSequenceMessageTransferIndication_02;
    }
    public class S011
    {
        public string ErroneousDataelementPositionInSegment_01;
        public string ErroneousComponentDataelementPosition_02;
        public string ErroneousDataelementOccurrence_03;
    }
    public class S016
    {
        public string MessageSubsetIdentification_01;
        public string MessageSubsetVersionNumber_02;
        public string MessageSubsetReleaseNumber_03;
        public string ControllingAgencyCoded_04;
    }
    public class S017
    {
        public string MessageImplementationGuidelineIdentification_01;
        public string MessageImplementationGuidelineVersionNumber_02;
        public string MessageImplementationGuidelineReleaseNumber_03;
        public string ControllingAgencyCoded_04;
    }
    public class S018
    {
        public string ScenarioIdentification_01;
        public string ScenarioVersionNumber_02;
        public string ScenarioReleaseNumber_03;
        public string ControllingAgencyCoded_04;
    }
    public class S020
    {
        public string ReferenceQualifier_01;
        public string ReferenceIdentificationNumber_02;
    }
    public class S500
    {
        public string Securitypartyqualifier_01;
        public string Keyname_02;
        public string Securitypartyidentification_03;
        public string Securitypartycodelistqualifier_04;
        public string Securitypartycodelistresponsibleagencycoded_05;
        public string Securitypartyname_06;
        public string Securitypartyname_07;
        public string Securitypartyname_08;
    }
    public class S501
    {
        public string Dateandtimequalifier_01;
        public string Eventdate_02;
        public string Eventtime_03;
        public string Timeoffset_04;
    }
    public class S502
    {
        public string Useofalgorithmcoded_01;
        public string Cryptographicmodeofoperationcoded_02;
        public string Modeofoperationcodelistidentifier_03;
        public string Algorithmcoded_04;
        public string Algorithmcodelistidentifier_05;
        public string Paddingmechanismcoded_06;
        public string Paddingmechanismcodelistidentifier_07;
    }
    public class S503
    {
        public string Algorithmparameterqualifier_01;
        public string Algorithmparametervalue_02;
    }
    public class S504
    {
        public string Listparameterqualifier_01;
        public string Listparameter_02;
    }
    public class S505
    {
        public string Servicecharacterforsignaturequalifier_01;
        public string Servicecharacterforsignature_02;
    }
    public class S508
    {
        public string Validationvaluequalifier_01;
        public string Validationvalue_02;
    }
}
