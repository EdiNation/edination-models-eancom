namespace EdiNation.Edifact.EAND01B.S3
{
    using System.Collections.Generic;
    public class Loop_AJT_DIRDEB
    {
        public AJT_2 AJT;
        public MOA_7 MOA;
        public RFF_4 RFF;
    }
    public class Loop_AUT_DIRDEB
    {
        public AUT AUT;
        public DTM_18 DTM;
    }
    public class Loop_CUX_DIRDEB
    {
        public CUX CUX;
        public DTM_18 DTM;
    }
    public class Loop_DLI_DIRDEB
    {
        public DLI_2 DLI;
        public List<MOA_7> MOA;
        public List<PIA_3> PIA;
        public List<Loop_AJT_DIRDEB> AJTLoop;
    }
    public class Loop_DOC_DIRDEB
    {
        public DOC_9 DOC;
        public List<MOA_7> MOA;
        public List<DTM_18> DTM;
        public List<RFF_4> RFF;
        public List<NAD_11> NAD;
        public List<Loop_CUX_DIRDEB> CUXLoop;
        public List<Loop_AJT_DIRDEB> AJTLoop;
        public List<Loop_DLI_DIRDEB> DLILoop;
    }
    public class Loop_FII_DIRDEB
    {
        public FII_4 FII;
    }
    public class Loop_GIS_DIRDEB
    {
        public GIS GIS;
        public MOA_7 MOA;
        public List<LOC> LOC;
        public NAD_11 NAD;
        public RCS RCS;
        public List<FTX_7> FTX;
    }
    public class Loop_GIS_DIRDEB_2
    {
        public GIS GIS;
        public List<MOA_7> MOA;
    }
    public class Loop_INP_DIRDEB
    {
        public INP INP;
        public FTX_7 FTX;
        public List<DTM_18> DTM;
    }
    public class Loop_LIN_DIRDEB
    {
        public LIN LIN;
        public DTM_18 DTM;
        public List<RFF_4> RFF;
        public BUS_2 BUS;
        public FCA_2 FCA;
        public Loop_MOA_DIRDEB MOALoop;
        public Loop_FII_DIRDEB FIILoop;
        public List<Loop_NAD_DIRDEB> NADLoop;
        public Loop_INP_DIRDEB INPLoop;
        public List<Loop_GIS_DIRDEB> GISLoop;
        public Loop_PRC_DIRDEB PRCLoop;
        public List<Loop_SEQ_DIRDEB> SEQLoop;
    }
    public class Loop_MOA_DIRDEB
    {
        public MOA_7 MOA;
        public CUX CUX;
        public List<DTM_18> DTM;
        public RFF_4 RFF;
    }
    public class Loop_NAD_DIRDEB
    {
        public NAD_11 NAD;
    }
    public class Loop_PRC_DIRDEB
    {
        public PRC PRC;
        public FTX_7 FTX;
    }
    public class Loop_PRC_DIRDEB_2
    {
        public PRC PRC;
        public List<FTX_7> FTX;
        public List<Loop_DOC_DIRDEB> DOCLoop;
        public Loop_GIS_DIRDEB_2 GISLoop;
    }
    public class Loop_SEQ_DIRDEB
    {
        public SEQ SEQ;
        public MOA_7 MOA;
        public DTM_18 DTM;
        public List<RFF_4> RFF;
        public FCA_2 FCA;
        public List<Loop_FII_DIRDEB> FIILoop;
        public List<Loop_NAD_DIRDEB> NADLoop;
        public List<Loop_INP_DIRDEB> INPLoop;
        public List<Loop_GIS_DIRDEB> GISLoop;
        public Loop_PRC_DIRDEB_2 PRCLoop;
    }
    public class TSDIRDEB 
    {
        public UNH UNH;
        public BGM_11 BGM;
        public DTM_18 DTM;
        public BUS_2 BUS;
        public List<Loop_FII_DIRDEB> FIILoop;
        public List<Loop_NAD_DIRDEB> NADLoop;
        public List<Loop_LIN_DIRDEB> LINLoop;
        public List<CNT_3> CNT;
        public List<Loop_AUT_DIRDEB> AUTLoop;
        public UNT UNT;
    }
}
