namespace EdiNation.Edifact.EAND96A
{
    using System.Collections.Generic;    
    public class UNH
    {
        public string MessageReferenceNumber_01;
        public S009 MessageIdentifier_02;
        public string CommonAccessReference_03;
        public S010 StatusoftheTransfer_04;
        public S016 MessageSubsetIdentification_05;
        public S017 MessageImplementationGuidelineIdentification_06;
        public S018 ScenarioIdentification_07;
    }
    public class UNT
    {
        public string NumberofSegmentsinaMessage_01;
        public string MessageReferenceNumber_02;
    }   
    public class UCD
    {
        public string Syntaxerrorcoded_01;
        public S011 DATAELEMENTIDENTIFICATION_02;
    }
    public class UCS
    {
        public string Segmentpositioninmessagebody_01;
        public string Syntaxerrorcoded_02;
    }
    public class UCM
    {
        public string Messagereferencenumber_01;
        public S009 MESSAGEIDENTIFIER_02;
        public string Actioncoded_03;
        public string Syntaxerrorcoded_04;
        public string Servicesegmenttagcoded_05;
        public S011 DATAELEMENTIDENTIFICATION_06;
        public string Packagereferencenumber_07;
        public List<S020> REFERENCEIDENTIFICATION_08;
        public string Securityreferencenumber_09;
        public string Securitysegmentposition_10;
    }
    public class UCF
    {
        public string Groupreferencenumber_01;
        public S006 APPLICATIONSENDERIDENTIFICATION_02;
        public S007 APPLICATIONRECIPIENTIDENTIFICATION_03;
        public string Actioncoded_04;
        public string Syntaxerrorcoded_05;
        public string Servicesegmenttagcoded_06;
        public S011 DATAELEMENTIDENTIFICATION_07;
        public string Securityreferencenumber_08;
        public string Securitysegmentposition_09;
    }
    public class UCI
    {
        public string Interchangecontrolreference_01;
        public S002 INTERCHANGESENDER_02;
        public S003 INTERCHANGERECIPIENT_03;
        public string Actioncoded_04;
        public string Syntaxerrorcoded_05;
        public string Servicesegmenttagcoded_06;
        public S011 DATAELEMENTIDENTIFICATION_07;
        public string Securityreferencenumber_08;
        public string Securitysegmentposition_09;
    }
    public class USA
    {
        public S502 SECURITYALGORITHM_01;
        public S503 ALGORITHMPARAMETER_02;
    }
    public class USB
    {
        public string Responsetypecoded_01;
        public S501 SECURITYDATEANDTIME_02;
        public S002 INTERCHANGESENDER_03;
        public S003 INTERCHANGERECIPIENT_04;
    }
    public class USC
    {
        public string Certificatereference_01;
        public S500 SECURITYIDENTIFICATIONDETAILS_02;
        public string Certificatesyntaxandversioncoded_03;
        public string Filterfunctioncoded_04;
        public string Originalcharactersetencodingcoded_05;
        public string Certificateoriginalcharactersetrepertoirecoded_06;
        public string Userauthorisationlevel_07;
        public S505 SERVICECHARACTERFORSIGNATURE_08;
        public S501 SECURITYDATEANDTIME_09;
        public string Securitystatuscoded_10;
        public string Revocationreasoncoded_11;
    }
    public class USH
    {
        public string Securityservicecoded_01;
        public string Securityreferencenumber_02;
        public string Scopeofsecurityapplicationcoded_03;
        public string Responsetypecoded_04;
        public string Filterfunctioncoded_05;
        public string Originalcharactersetencodingcoded_06;
        public string Roleofsecurityprovidercoded_07;
        public S500 SECURITYIDENTIFICATIONDETAILS_08;
        public string Securitysequencenumber_09;
        public S501 SECURITYDATEANDTIME_10;
    }
    public class USL
    {
        public string Securitystatuscoded_01;
        public S504 LISTPARAMETER_02;
    }
    public class UST
    {
        public string Securityreferencenumber_01;
        public string Numberofsecuritysegments_02;
    }
    public class USX
    {
        public string Interchangecontrolreference_01;
        public S002 INTERCHANGESENDER_02;
        public S003 INTERCHANGERECIPIENT_03;
        public string Groupreferencenumber_04;
        public S006 APPLICATIONSENDERIDENTIFICATION_05;
        public S007 APPLICATIONRECIPIENTIDENTIFICATION_06;
        public string Messagereferencenumber_07;
        public S009 MESSAGEIDENTIFIER_08;
        public string Packagereferencenumber_09;
        public S501 SECURITYDATEANDTIME_10;
    }
    public class USY
    {
        public string Securityreferencenumber_01;
        public S508 VALIDATIONRESULT_02;
        public string Securityerrorcoded_03;
    }
}
