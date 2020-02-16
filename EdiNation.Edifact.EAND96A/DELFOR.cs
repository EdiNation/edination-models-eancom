namespace EdiNation.Edifact.EAND96A
{
    using System.Collections.Generic;
    public class Loop_CTA_DELFOR
    {
        public CTA_11 CTA;
        public List<COM> COM;
    }
    public class Loop_LIN_DELFOR
    {
        public LIN LIN;
        public List<PIA> PIA;
        public List<Loop_RFF_DELFOR> RFFLoop;
        public List<Loop_QTY_DELFOR> QTYLoop;
        public List<Loop_PAC_DELFOR> PACLoop;
    }
    public class Loop_LIN_DELFOR_2
    {
        public LIN LIN;
        public List<PIA> PIA;
        public List<Loop_RFF_DELFOR> RFFLoop;
        public List<Loop_QTY_DELFOR> QTYLoop;
        public List<Loop_PAC_DELFOR> PACLoop;
        public List<Loop_NAD_DELFOR_3> NADLoop;
    }
    public class Loop_NAD_DELFOR
    {
        public NAD_9 NAD;
        public List<Loop_CTA_DELFOR> CTALoop;
    }
    public class Loop_NAD_DELFOR_2
    {
        public NAD_9 NAD;
        public List<Loop_TDT_DELFOR> TDTLoop;
        public List<Loop_LIN_DELFOR> LINLoop;
    }
    public class Loop_NAD_DELFOR_3
    {
        public NAD_9 NAD;
        public List<Loop_TDT_DELFOR> TDTLoop;
    }
    public class Loop_PAC_DELFOR
    {
        public PAC PAC;
    }
    public class Loop_QTY_DELFOR
    {
        public QTY_12 QTY;
        public SCC SCC;
        public List<DTM_21> DTM;
    }
    public class Loop_RFF_DELFOR
    {
        public RFF_12 RFF;
        public DTM_21 DTM;
    }
    public class Loop_TDT_DELFOR
    {
        public TDT TDT;
        public List<DTM_21> DTM;
    }
    public class TSDELFOR 
    {
        public UNH UNH;
        public BGM_8 BGM;
        public List<DTM_21> DTM;
        public List<Loop_RFF_DELFOR> RFFLoop;
        public List<Loop_NAD_DELFOR> NADLoop;
        public UNS UNS;
        public List<Loop_NAD_DELFOR_2> NADLoop2;
        public List<Loop_LIN_DELFOR_2> LINLoop;
        public UNS UNS2;
        public List<CNT_4> CNT;
        public List<FTX_28> FTX;
        public UNT UNT;
    }
}
