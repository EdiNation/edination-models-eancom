namespace EdiNation.Edifact.EAND01B.S3
{
    using System.Collections.Generic;
    public class Loop_AJT_PAYMUL
    {
        public AJT_3 AJT;
        public MOA_8 MOA;
        public RFF_5 RFF;
    }
    public class Loop_AUT_PAYMUL
    {
        public AUT AUT;
        public DTM_19 DTM;
    }
    public class Loop_CUX_PAYMUL
    {
        public CUX CUX;
        public DTM_19 DTM;
    }
    public class Loop_DLI_PAYMUL
    {
        public DLI_2 DLI;
        public List<MOA_8> MOA;
        public List<PIA_3> PIA;
        public List<Loop_AJT_PAYMUL> AJTLoop;
    }
    public class Loop_DOC_PAYMUL
    {
        public DOC_14 DOC;
        public List<MOA_8> MOA;
        public List<DTM_19> DTM;
        public List<RFF_5> RFF;
        public List<NAD_25> NAD;
        public List<Loop_CUX_PAYMUL> CUXLoop;
        public List<Loop_AJT_PAYMUL> AJTLoop;
        public List<Loop_DLI_PAYMUL> DLILoop;
    }
    public class Loop_FII_PAYMUL
    {
        public FII_5 FII;
    }
    public class Loop_GIS_PAYMUL
    {
        public GIS GIS;
        public MOA_8 MOA;
        public List<LOC> LOC;
        public NAD_25 NAD;
        public RCS RCS;
        public List<FTX_7> FTX;
    }
    public class Loop_GIS_PAYMUL_2
    {
        public GIS GIS;
        public List<MOA_8> MOA;
    }
    public class Loop_INP_PAYMUL
    {
        public INP_2 INP;
        public FTX_7 FTX;
        public List<DTM_19> DTM;
    }
    public class Loop_LIN_PAYMUL
    {
        public LIN LIN;
        public DTM_19 DTM;
        public List<RFF_5> RFF;
        public BUS BUS;
        public FCA_2 FCA;
        public Loop_MOA_PAYMUL MOALoop;
        public List<Loop_FII_PAYMUL> FIILoop;
        public List<Loop_NAD_PAYMUL_2> NADLoop;
        public Loop_INP_PAYMUL INPLoop;
        public List<Loop_GIS_PAYMUL> GISLoop;
        public Loop_PRC_PAYMUL PRCLoop;
        public List<Loop_SEQ_PAYMUL> SEQLoop;
    }
    public class Loop_MOA_PAYMUL
    {
        public MOA_8 MOA;
        public CUX CUX;
        public List<DTM_19> DTM;
        public RFF_5 RFF;
    }
    public class Loop_NAD_PAYMUL
    {
        public NAD_25 NAD;
    }
    public class Loop_NAD_PAYMUL_2
    {
        public NAD_25 NAD;
        public CTA_9 CTA;
        public List<COM_3> COM;
    }
    public class Loop_PRC_PAYMUL
    {
        public PRC PRC;
        public FTX_7 FTX;
    }
    public class Loop_PRC_PAYMUL_2
    {
        public PRC PRC;
        public List<FTX_7> FTX;
        public List<Loop_DOC_PAYMUL> DOCLoop;
        public Loop_GIS_PAYMUL_2 GISLoop;
    }
    public class Loop_SEQ_PAYMUL
    {
        public SEQ SEQ;
        public MOA_8 MOA;
        public DTM_19 DTM;
        public List<RFF_5> RFF;
        public PAI_7 PAI;
        public FCA_2 FCA;
        public List<Loop_FII_PAYMUL> FIILoop;
        public List<Loop_NAD_PAYMUL_2> NADLoop;
        public List<Loop_INP_PAYMUL> INPLoop;
        public List<Loop_GIS_PAYMUL> GISLoop;
        public Loop_PRC_PAYMUL_2 PRCLoop;
    }
    public class TSPAYMUL 
    {
        public UNH UNH;
        public BGM_32 BGM;
        public DTM_19 DTM;
        public BUS BUS;
        public List<Loop_FII_PAYMUL> FIILoop;
        public List<Loop_NAD_PAYMUL> NADLoop;
        public List<Loop_LIN_PAYMUL> LINLoop;
        public List<CNT_3> CNT;
        public List<Loop_AUT_PAYMUL> AUTLoop;
        public UNT UNT;
    }
}
