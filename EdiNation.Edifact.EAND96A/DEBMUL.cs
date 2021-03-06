namespace EdiNation.Edifact.EAND96A
{
    using System.Collections.Generic;
    public class Loop_ALC_DEBMUL
    {
        public ALC_2 ALC;
        public PCD PCD;
        public List<MOA_2> MOA;
        public CUX CUX;
        public DTM_14 DTM;
        public List<Loop_TAX_DEBMUL> TAXLoop;
    }
    public class Loop_ALC_DEBMUL_2
    {
        public ALC_2 ALC;
        public PCD PCD;
        public List<MOA_2> MOA;
        public CUX CUX;
        public DTM_14 DTM;
        public List<Loop_TAX_DEBMUL> TAXLoop;
    }
    public class Loop_AUT_DEBMUL
    {
        public AUT AUT;
        public DTM_14 DTM;
    }
    public class Loop_DOC_DEBMUL
    {
        public DOC_7 DOC;
        public List<MOA_2> MOA;
        public List<RFF_11> RFF;
    }
    public class Loop_FCA_DEBMUL
    {
        public FCA FCA;
        public List<MOA_2> MOA;
        public List<Loop_ALC_DEBMUL> ALCLoop;
    }
    public class Loop_FCA_DEBMUL_2
    {
        public FCA FCA;
        public List<MOA_2> MOA;
        public List<Loop_ALC_DEBMUL_2> ALCLoop;
    }
    public class Loop_FII_DEBMUL
    {
        public FII_3 FII;
    }
    public class Loop_GIS_DEBMUL
    {
        public GIS_2 GIS;
        public MOA_2 MOA;
        public List<LOC> LOC;
        public NAD_8 NAD;
        public RCS RCS;
        public List<FTX_7> FTX;
    }
    public class Loop_GIS_DEBMUL_2
    {
        public GIS_2 GIS;
        public List<MOA_2> MOA;
    }
    public class Loop_INP_DEBMUL
    {
        public INP_4 INP;
        public FTX_7 FTX;
        public List<DTM_14> DTM;
    }
    public class Loop_LIN_DEBMUL
    {
        public LIN_5 LIN;
        public List<DTM_14> DTM;
        public BUS_2 BUS;
        public List<MOA_2> MOA;
        public List<Loop_RFF_DEBMUL> RFFLoop;
        public Loop_FII_DEBMUL FIILoop;
        public List<Loop_FCA_DEBMUL> FCALoop;
        public List<Loop_SEQ_DEBMUL> SEQLoop;
    }
    public class Loop_MOA_DEBMUL
    {
        public MOA_2 MOA;
        public List<DTM_14> DTM;
        public RFF_11 RFF;
    }
    public class Loop_NAD_DEBMUL
    {
        public NAD_8 NAD;
    }
    public class Loop_NAD_DEBMUL_2
    {
        public NAD_8 NAD;
        public CTA_9 CTA;
        public List<COM_3> COM;
    }
    public class Loop_PAI_DEBMUL
    {
        public PAI_2 PAI;
    }
    public class Loop_PRC_DEBMUL
    {
        public PRC PRC;
        public List<FTX_7> FTX;
        public List<Loop_DOC_DEBMUL> DOCLoop;
        public Loop_GIS_DEBMUL_2 GISLoop;
    }
    public class Loop_RFF_DEBMUL
    {
        public RFF_11 RFF;
    }
    public class Loop_RFF_DEBMUL_2
    {
        public RFF_11 RFF;
        public DTM_14 DTM;
    }
    public class Loop_SEQ_DEBMUL
    {
        public SEQ_3 SEQ;
        public List<DTM_14> DTM;
        public BUS_2 BUS;
        public List<FII_3> FII;
        public List<Loop_RFF_DEBMUL_2> RFFLoop;
        public Loop_PAI_DEBMUL PAILoop;
        public List<Loop_MOA_DEBMUL> MOALoop;
        public List<Loop_NAD_DEBMUL_2> NADLoop;
        public List<Loop_INP_DEBMUL> INPLoop;
        public List<Loop_GIS_DEBMUL> GISLoop;
        public List<Loop_FCA_DEBMUL_2> FCALoop;
        public Loop_PRC_DEBMUL PRCLoop;
    }
    public class Loop_TAX_DEBMUL
    {
        public TAX_3 TAX;
        public List<MOA_2> MOA;
    }
    public class TSDEBMUL 
    {
        public UNH UNH;
        public BGM_7 BGM;
        public DTM_14 DTM;
        public BUS_2 BUS;
        public List<Loop_FII_DEBMUL> FIILoop;
        public List<Loop_NAD_DEBMUL> NADLoop;
        public List<Loop_LIN_DEBMUL> LINLoop;
        public List<CNT_3> CNT;
        public List<Loop_AUT_DEBMUL> AUTLoop;
        public UNT UNT;
    }
}
