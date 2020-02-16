namespace EdiNation.Edifact.EAND93A
{
    using System.Collections.Generic;
    public class Loop_ALI_PRODAT
    {
        public ALI_8 ALI;
    }
    public class Loop_CCI_PRODAT
    {
        public CCI_2 CCI;
        public List<CAV> CAV;
        public List<MEA> MEA;
    }
    public class Loop_CTA_PRODAT
    {
        public CTA_11 CTA;
        public List<COM_2> COM;
    }
    public class Loop_DGS_PRODAT
    {
        public DGS_3 DGS;
        public QTY_3 QTY;
        public List<FTX_8> FTX;
    }
    public class Loop_HYN_PRODAT
    {
        public HYN HYN;
        public List<QTY_3> QTY;
        public List<Loop_CCI_PRODAT> CCILoop;
    }
    public class Loop_IMD_PRODAT
    {
        public IMD_7 IMD;
        public List<FTX_8> FTX;
    }
    public class Loop_LIN_PRODAT
    {
        public LIN_6 LIN;
        public List<PIA_11> PIA;
        public List<DTM_24> DTM;
        public List<MEA> MEA;
        public List<HAN_2> HAN;
        public List<DOC_12> DOC;
        public List<FTX_8> FTX;
        public PGI PGI;
        public List<Loop_IMD_PRODAT> IMDLoop;
        public List<Loop_TRU_PRODAT_2> TRULoop;
        public List<Loop_QTY_PRODAT> QTYLoop;
        public List<Loop_CCI_PRODAT> CCILoop;
        public List<Loop_ALI_PRODAT> ALILoop;
        public List<Loop_RFF_PRODAT> RFFLoop;
        public List<Loop_NAD_PRODAT_2> NADLoop;
        public List<Loop_DGS_PRODAT> DGSLoop;
        public List<Loop_PAC_PRODAT> PACLoop;
        public List<Loop_HYN_PRODAT> HYNLoop;
    }
    public class Loop_NAD_PRODAT
    {
        public NAD_15 NAD;
        public List<Loop_CTA_PRODAT> CTALoop;
        public List<Loop_RFF_PRODAT_2> RFFLoop;
    }
    public class Loop_NAD_PRODAT_2
    {
        public NAD_15 NAD;
    }
    public class Loop_PAC_PRODAT
    {
        public PAC_16 PAC;
        public List<MEA> MEA;
        public List<HAN_2> HAN;
        public List<PCI_6> PCI;
    }
    public class Loop_QTY_PRODAT
    {
        public QTY_3 QTY;
    }
    public class Loop_RFF_PRODAT
    {
        public RFF_20 RFF;
        public List<DTM_24> DTM;
    }
    public class Loop_RFF_PRODAT_2
    {
        public RFF_20 RFF;
    }
    public class Loop_TRU_PRODAT
    {
        public TRU TRU;
        public List<DTM_24> DTM;
    }
    public class Loop_TRU_PRODAT_2
    {
        public TRU TRU;
        public DTM_24 DTM;
    }
    public class TSPRODAT 
    {
        public UNH UNH;
        public BGM_18 BGM;
        public List<DTM_24> DTM;
        public List<FTX_30> FTX;
        public List<PGI> PGI;
        public List<Loop_TRU_PRODAT> TRULoop;
        public List<Loop_RFF_PRODAT> RFFLoop;
        public List<Loop_NAD_PRODAT> NADLoop;
        public List<Loop_LIN_PRODAT> LINLoop;
        public UNT UNT;
    }
}
