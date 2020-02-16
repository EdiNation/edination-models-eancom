namespace EdiNation.Edifact.EAND96A
{
    using System.Collections.Generic;
    public class Loop_AJT_CREMUL
    {
        public AJT_2 AJT;
        public MOA MOA;
        public RFF_10 RFF;
    }
    public class Loop_ALC_CREMUL
    {
        public ALC_2 ALC;
        public PCD PCD;
        public List<MOA> MOA;
        public CUX CUX;
        public DTM_4 DTM;
        public List<Loop_TAX_CREMUL> TAXLoop;
    }
    public class Loop_ALC_CREMUL_2
    {
        public ALC_2 ALC;
        public PCD PCD;
        public List<MOA> MOA;
        public CUX CUX;
        public List<DTM_4> DTM;
        public List<Loop_TAX_CREMUL> TAXLoop;
    }
    public class Loop_AUT_CREMUL
    {
        public AUT AUT;
        public DTM_4 DTM;
    }
    public class Loop_CUX_CREMUL
    {
        public CUX CUX;
        public DTM_4 DTM;
    }
    public class Loop_DLI_CREMUL
    {
        public DLI_2 DLI;
        public List<MOA> MOA;
        public List<PIA_2> PIA;
        public List<DTM_4> DTM;
        public List<Loop_AJT_CREMUL> AJTLoop;
    }
    public class Loop_DOC_CREMUL
    {
        public DOC_7 DOC;
        public List<MOA> MOA;
        public List<DTM_4> DTM;
        public List<RFF_10> RFF;
        public List<NAD_7> NAD;
        public List<Loop_CUX_CREMUL> CUXLoop;
        public List<Loop_AJT_CREMUL> AJTLoop;
        public List<Loop_DLI_CREMUL> DLILoop;
    }
    public class Loop_FCA_CREMUL
    {
        public FCA FCA;
        public List<MOA> MOA;
        public List<Loop_ALC_CREMUL> ALCLoop;
    }
    public class Loop_FCA_CREMUL_2
    {
        public FCA FCA;
        public List<MOA> MOA;
        public List<Loop_ALC_CREMUL_2> ALCLoop;
    }
    public class Loop_FII_CREMUL
    {
        public FII_2 FII;
    }
    public class Loop_GIS_CREMUL
    {
        public GIS GIS;
        public MOA MOA;
        public List<LOC> LOC;
        public NAD_7 NAD;
        public RCS RCS;
        public List<FTX_7> FTX;
    }
    public class Loop_GIS_CREMUL_2
    {
        public GIS GIS;
        public List<MOA> MOA;
    }
    public class Loop_INP_CREMUL
    {
        public INP_3 INP;
        public FTX_7 FTX;
        public DTM_4 DTM;
    }
    public class Loop_LIN_CREMUL
    {
        public LIN_4 LIN;
        public List<DTM_4> DTM;
        public BUS BUS;
        public List<MOA> MOA;
        public List<Loop_RFF_CREMUL> RFFLoop;
        public Loop_FII_CREMUL FIILoop;
        public List<Loop_FCA_CREMUL> FCALoop;
        public List<Loop_SEQ_CREMUL> SEQLoop;
    }
    public class Loop_MOA_CREMUL
    {
        public MOA MOA;
        public List<DTM_4> DTM;
        public RFF_10 RFF;
    }
    public class Loop_NAD_CREMUL
    {
        public NAD_7 NAD;
    }
    public class Loop_NAD_CREMUL_2
    {
        public NAD_7 NAD;
        public CTA_9 CTA;
        public List<COM_3> COM;
    }
    public class Loop_PAI_CREMUL
    {
        public PAI PAI;
    }
    public class Loop_PRC_CREMUL
    {
        public PRC_2 PRC;
        public List<FTX_7> FTX;
        public List<Loop_DOC_CREMUL> DOCLoop;
        public Loop_GIS_CREMUL_2 GISLoop;
    }
    public class Loop_RFF_CREMUL
    {
        public RFF_10 RFF;
    }
    public class Loop_RFF_CREMUL_2
    {
        public RFF_10 RFF;
        public DTM_4 DTM;
    }
    public class Loop_SEQ_CREMUL
    {
        public SEQ_3 SEQ;
        public List<DTM_4> DTM;
        public BUS BUS;
        public List<FII_2> FII;
        public List<Loop_RFF_CREMUL_2> RFFLoop;
        public Loop_PAI_CREMUL PAILoop;
        public List<Loop_MOA_CREMUL> MOALoop;
        public List<Loop_NAD_CREMUL_2> NADLoop;
        public List<Loop_INP_CREMUL> INPLoop;
        public List<Loop_GIS_CREMUL> GISLoop;
        public List<Loop_FCA_CREMUL_2> FCALoop;
        public Loop_PRC_CREMUL PRCLoop;
    }
    public class Loop_TAX_CREMUL
    {
        public TAX_3 TAX;
        public List<MOA> MOA;
    }
    public class TSCREMUL 
    {
        public UNH UNH;
        public BGM_7 BGM;
        public DTM_4 DTM;
        public BUS BUS;
        public List<Loop_FII_CREMUL> FIILoop;
        public List<Loop_NAD_CREMUL> NADLoop;
        public List<Loop_LIN_CREMUL> LINLoop;
        public List<CNT_3> CNT;
        public List<Loop_AUT_CREMUL> AUTLoop;
        public UNT UNT;
    }
}
