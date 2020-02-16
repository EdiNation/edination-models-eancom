namespace EdiNation.Edifact.EAND01B.S3
{
    using System.Collections.Generic;
    public class Loop_CTA_DELFOR
    {
        public CTA_11 CTA;
        public List<COM> COM;
    }
    public class Loop_GIS_DELFOR
    {
        public GIS_2 GIS;
        public Loop_NAD_DELFOR_2 NADLoop;
        public List<Loop_LIN_DELFOR> LINLoop;
    }
    public class Loop_LIN_DELFOR
    {
        public LIN_2 LIN;
        public List<PIA_6> PIA;
        public List<IMD_3> IMD;
        public List<MEA_13> MEA;
        public List<FTX_10> FTX;
        public List<Loop_RFF_DELFOR> RFFLoop;
        public List<Loop_SCC_DELFOR> SCCLoop;
        public List<Loop_PAC_DELFOR> PACLoop;
        public List<Loop_NAD_DELFOR_3> NADLoop;
    }
    public class Loop_NAD_DELFOR
    {
        public NAD_10 NAD;
        public List<Loop_CTA_DELFOR> CTALoop;
    }
    public class Loop_NAD_DELFOR_2
    {
        public NAD_10 NAD;
        public List<Loop_TDT_DELFOR> TDTLoop;
    }
    public class Loop_NAD_DELFOR_3
    {
        public NAD_10 NAD;
        public List<Loop_SCC_DELFOR_2> SCCLoop;
        public List<Loop_TDT_DELFOR> TDTLoop;
    }
    public class Loop_PAC_DELFOR
    {
        public PAC_5 PAC;
    }
    public class Loop_QTY_DELFOR
    {
        public QTY_13 QTY;
        public List<DTM_24> DTM;
    }
    public class Loop_RFF_DELFOR
    {
        public RFF_13 RFF;
        public DTM_24 DTM;
    }
    public class Loop_SCC_DELFOR
    {
        public SCC SCC;
        public List<Loop_QTY_DELFOR> QTYLoop;
    }
    public class Loop_SCC_DELFOR_2
    {
        public SCC SCC;
        public List<Loop_QTY_DELFOR> QTYLoop;
    }
    public class Loop_TDT_DELFOR
    {
        public TDT TDT;
        public List<DTM_24> DTM;
    }
    public class TSDELFOR 
    {
        public UNH UNH;
        public BGM_9 BGM;
        public List<DTM_24> DTM;
        public List<FTX_10> FTX;
        public List<Loop_RFF_DELFOR> RFFLoop;
        public List<Loop_NAD_DELFOR> NADLoop;
        public List<Loop_GIS_DELFOR> GISLoop;
        public UNT UNT;
    }
}
