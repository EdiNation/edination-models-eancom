namespace EdiNation.Edifact.EAND96A
{
    using System.Collections.Generic;
    public class Loop_AJT_PAYMUL
    {
        public AJT_2 AJT;
        public MOA_7 MOA;
        public RFF_5 RFF;
    }
    public class Loop_AUT_PAYMUL
    {
        public AUT AUT;
        public DTM_15 DTM;
    }
    public class Loop_CUX_PAYMUL
    {
        public CUX_2 CUX;
        public DTM_15 DTM;
    }
    public class Loop_DLI_PAYMUL
    {
        public DLI_2 DLI;
        public List<MOA_7> MOA;
        public List<PIA_2> PIA;
        public List<Loop_AJT_PAYMUL> AJTLoop;
    }
    public class Loop_DOC_PAYMUL
    {
        public DOC_11 DOC;
        public List<MOA_7> MOA;
        public List<DTM_15> DTM;
        public List<RFF_5> RFF;
        public List<NAD_22> NAD;
        public List<Loop_CUX_PAYMUL> CUXLoop;
        public List<Loop_AJT_PAYMUL> AJTLoop;
        public List<Loop_DLI_PAYMUL> DLILoop;
    }
    public class Loop_FII_PAYMUL
    {
        public FII_4 FII;
    }
    public class Loop_GIS_PAYMUL
    {
        public GIS_2 GIS;
        public MOA_7 MOA;
        public List<LOC> LOC;
        public NAD_22 NAD;
        public RCS RCS;
        public List<FTX_8> FTX;
    }
    public class Loop_GIS_PAYMUL_2
    {
        public GIS_2 GIS;
        public List<MOA_7> MOA;
    }
    public class Loop_INP_PAYMUL
    {
        public INP INP;
        public FTX_8 FTX;
        public List<DTM_15> DTM;
    }
    public class Loop_LIN_PAYMUL
    {
        public LIN_4 LIN;
        public DTM_15 DTM;
        public List<RFF_5> RFF;
        public BUS_3 BUS;
        public FCA FCA;
        public Loop_MOA_PAYMUL MOALoop;
        public Loop_FII_PAYMUL FIILoop;
        public List<Loop_NAD_PAYMUL_2> NADLoop;
        public Loop_INP_PAYMUL INPLoop;
        public List<Loop_GIS_PAYMUL> GISLoop;
        public Loop_PRC_PAYMUL PRCLoop;
        public List<Loop_SEQ_PAYMUL> SEQLoop;
    }
    public class Loop_MOA_PAYMUL
    {
        public MOA_7 MOA;
        public CUX_2 CUX;
        public List<DTM_15> DTM;
        public RFF_5 RFF;
    }
    public class Loop_NAD_PAYMUL
    {
        public NAD_22 NAD;
    }
    public class Loop_NAD_PAYMUL_2
    {
        public NAD_22 NAD;
        public CTA_9 CTA;
        public List<COM_3> COM;
    }
    public class Loop_PRC_PAYMUL
    {
        public PRC PRC;
        public FTX_8 FTX;
    }
    public class Loop_PRC_PAYMUL_2
    {
        public PRC PRC;
        public List<FTX_8> FTX;
        public List<Loop_DOC_PAYMUL> DOCLoop;
        public Loop_GIS_PAYMUL_2 GISLoop;
    }
    public class Loop_SEQ_PAYMUL
    {
        public SEQ_3 SEQ;
        public MOA_7 MOA;
        public DTM_15 DTM;
        public List<RFF_5> RFF;
        public PAI_4 PAI;
        public FCA FCA;
        public List<Loop_FII_PAYMUL> FIILoop;
        public List<Loop_NAD_PAYMUL_2> NADLoop;
        public List<Loop_INP_PAYMUL> INPLoop;
        public List<Loop_GIS_PAYMUL> GISLoop;
        public Loop_PRC_PAYMUL_2 PRCLoop;
    }
    public class TSPAYMUL 
    {
        public UNH UNH;
        public BGM_31 BGM;
        public DTM_15 DTM;
        public BUS_3 BUS;
        public List<Loop_FII_PAYMUL> FIILoop;
        public List<Loop_NAD_PAYMUL> NADLoop;
        public List<Loop_LIN_PAYMUL> LINLoop;
        public List<CNT_12> CNT;
        public List<Loop_AUT_PAYMUL> AUTLoop;
        public UNT UNT;
    }
}
