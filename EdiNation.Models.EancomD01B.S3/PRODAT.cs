namespace EdiNation.Edifact.EAND01B.S3
{
    using System.Collections.Generic;
    public class Loop_ALI_PRODAT
    {
        public ALI ALI;
    }
    public class Loop_CCI_PRODAT
    {
        public CCI_2 CCI;
        public List<CAV> CAV;
        public List<MEA_4> MEA;
    }
    public class Loop_CTA_PRODAT
    {
        public CTA_14 CTA;
        public List<COM_2> COM;
    }
    public class Loop_DGS_PRODAT
    {
        public DGS_3 DGS;
        public QTY QTY;
        public List<FTX_17> FTX;
    }
    public class Loop_HYN_PRODAT
    {
        public HYN HYN;
        public List<PIA_2> PIA;
        public List<QTY> QTY;
        public List<Loop_CCI_PRODAT> CCILoop;
    }
    public class Loop_IMD_PRODAT
    {
        public IMD IMD;
        public List<FTX_17> FTX;
    }
    public class Loop_LIN_PRODAT
    {
        public LIN LIN;
        public List<PIA_2> PIA;
        public List<DTM_44> DTM;
        public List<MEA_4> MEA;
        public List<HAN> HAN;
        public List<DOC_17> DOC;
        public List<FTX_17> FTX;
        public List<PGI> PGI;
        public List<Loop_IMD_PRODAT> IMDLoop;
        public List<Loop_TRU_PRODAT> TRULoop;
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
        public NAD_27 NAD;
        public List<Loop_CTA_PRODAT> CTALoop;
        public List<Loop_RFF_PRODAT_2> RFFLoop;
    }
    public class Loop_NAD_PRODAT_2
    {
        public NAD_27 NAD;
    }
    public class Loop_PAC_PRODAT
    {
        public PAC_9 PAC;
        public List<MEA_4> MEA;
        public List<HAN> HAN;
        public List<PCI_5> PCI;
    }
    public class Loop_QTY_PRODAT
    {
        public QTY QTY;
    }
    public class Loop_RFF_PRODAT
    {
        public RFF_31 RFF;
        public List<DTM_44> DTM;
    }
    public class Loop_RFF_PRODAT_2
    {
        public RFF_31 RFF;
    }
    public class Loop_TRU_PRODAT
    {
        public TRU TRU;
        public DTM_44 DTM;
    }
    public class TSPRODAT 
    {
        public UNH UNH;
        public BGM_34 BGM;
        public List<DTM_44> DTM;
        public List<FTX_17> FTX;
        public List<PGI> PGI;
        public List<Loop_TRU_PRODAT> TRULoop;
        public List<Loop_RFF_PRODAT> RFFLoop;
        public List<Loop_NAD_PRODAT> NADLoop;
        public List<Loop_CCI_PRODAT> CCILoop;
        public List<Loop_LIN_PRODAT> LINLoop;
        public UNT UNT;
    }
}
