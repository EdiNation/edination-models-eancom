namespace EdiNation.Edifact.EAND01B.S4
{
    using System.Collections.Generic;
    public class Loop_ALC_PRICAT
    {
        public ALC_5 ALC;
        public List<ALI> ALI;
        public List<DTM_3> DTM;
        public List<Loop_QTY_PRICAT> QTYLoop;
        public List<Loop_PCD_PRICAT> PCDLoop;
        public List<Loop_MOA_PRICAT> MOALoop;
        public List<Loop_RTE_PRICAT> RTELoop;
        public List<Loop_TAX_PRICAT_2> TAXLoop;
    }
    public class Loop_ALC_PRICAT_2
    {
        public ALC_5 ALC;
        public List<ALI> ALI;
        public Loop_QTY_PRICAT QTYLoop;
        public Loop_PCD_PRICAT PCDLoop;
        public List<Loop_MOA_PRICAT> MOALoop;
        public Loop_RTE_PRICAT RTELoop;
        public List<Loop_TAX_PRICAT_3> TAXLoop;
    }
    public class Loop_ALC_PRICAT_3
    {
        public ALC_5 ALC;
        public List<ALI> ALI;
        public List<DTM_3> DTM;
        public List<Loop_QTY_PRICAT> QTYLoop;
        public List<Loop_PCD_PRICAT> PCDLoop;
        public List<Loop_MOA_PRICAT> MOALoop;
        public List<Loop_RTE_PRICAT> RTELoop;
        public List<Loop_TAX_PRICAT_2> TAXLoop;
    }
    public class Loop_CCI_PRICAT
    {
        public CCI_2 CCI;
        public List<CAV> CAV;
        public List<MEA_3> MEA;
    }
    public class Loop_CCI_PRICAT_2
    {
        public CCI_2 CCI;
        public List<CAV> CAV;
        public List<MEA_3> MEA;
    }
    public class Loop_CTA_PRICAT
    {
        public CTA_8 CTA;
        public List<COM_2> COM;
    }
    public class Loop_CTA_PRICAT_2
    {
        public CTA_8 CTA;
        public List<COM_2> COM;
    }
    public class Loop_CUX_PRICAT
    {
        public CUX CUX;
        public List<DTM_3> DTM;
    }
    public class Loop_DGS_PRICAT
    {
        public DGS DGS;
        public QTY_11 QTY;
        public List<FTX_22> FTX;
    }
    public class Loop_EFI_PRICAT
    {
        public EFI EFI;
        public List<CED> CED;
        public List<RFF_31> RFF;
        public List<DTM_3> DTM;
        public List<QTY_11> QTY;
    }
    public class Loop_HYN_PRICAT
    {
        public HYN HYN;
        public List<PIA> PIA;
        public List<QTY_11> QTY;
        public List<Loop_CCI_PRICAT_2> CCILoop;
    }
    public class Loop_LIN_PRICAT
    {
        public LIN LIN;
        public List<PIA> PIA;
        public List<IMD_12> IMD;
        public List<MEA_3> MEA;
        public List<QTY_11> QTY;
        public List<HAN_3> HAN;
        public List<ALI> ALI;
        public List<DTM_3> DTM;
        public List<RFF_31> RFF;
        public LOC_12 LOC;
        public List<FTX_22> FTX;
        public List<Loop_CCI_PRICAT> CCILoop;
        public List<Loop_TAX_PRICAT_2> TAXLoop;
        public List<Loop_PRI_PRICAT_2> PRILoop;
        public List<Loop_ALC_PRICAT_3> ALCLoop;
        public List<Loop_PAC_PRICAT_2> PACLoop;
        public List<Loop_PAT_PRICAT_2> PATLoop;
        public List<Loop_EFI_PRICAT> EFILoop;
        public List<Loop_NAD_PRICAT_3> NADLoop;
        public List<Loop_TRU_PRICAT> TRULoop;
        public List<Loop_DGS_PRICAT> DGSLoop;
        public List<Loop_HYN_PRICAT> HYNLoop;
    }
    public class Loop_MOA_PRICAT
    {
        public MOA_20 MOA;
        public RNG RNG;
    }
    public class Loop_NAD_PRICAT
    {
        public NAD_27 NAD;
        public List<Loop_RFF_PRICAT_2> RFFLoop;
        public List<Loop_CTA_PRICAT> CTALoop;
    }
    public class Loop_NAD_PRICAT_2
    {
        public NAD_27 NAD;
        public List<LOC_12> LOC;
        public List<Loop_RFF_PRICAT> RFFLoop;
        public List<Loop_CTA_PRICAT> CTALoop;
    }
    public class Loop_NAD_PRICAT_3
    {
        public NAD_27 NAD;
        public List<Loop_CTA_PRICAT_2> CTALoop;
    }
    public class Loop_PAC_PRICAT
    {
        public PAC_4 PAC;
        public List<MEA_3> MEA;
    }
    public class Loop_PAC_PRICAT_2
    {
        public PAC_4 PAC;
        public List<MEA_3> MEA;
        public List<HAN_3> HAN;
    }
    public class Loop_PAT_PRICAT
    {
        public PAT_2 PAT;
        public PCD_2 PCD;
    }
    public class Loop_PAT_PRICAT_2
    {
        public PAT_2 PAT;
        public List<DTM_3> DTM;
        public PCD_2 PCD;
        public MOA_20 MOA;
    }
    public class Loop_PCD_PRICAT
    {
        public PCD_2 PCD;
        public RNG RNG;
    }
    public class Loop_PGI_PRICAT
    {
        public PGI_3 PGI;
        public List<DTM_3> DTM;
        public List<QTY_11> QTY;
        public List<ALI> ALI;
        public List<FTX_22> FTX;
        public List<Loop_CUX_PRICAT> CUXLoop;
        public List<Loop_PRI_PRICAT> PRILoop;
        public List<Loop_TAX_PRICAT_2> TAXLoop;
        public List<Loop_ALC_PRICAT_2> ALCLoop;
        public List<Loop_NAD_PRICAT_2> NADLoop;
        public List<Loop_PAT_PRICAT> PATLoop;
        public List<Loop_TDT_PRICAT> TDTLoop;
        public List<Loop_TOD_PRICAT> TODLoop;
        public List<Loop_PAC_PRICAT> PACLoop;
        public List<Loop_EFI_PRICAT> EFILoop;
        public List<Loop_TRU_PRICAT> TRULoop;
        public List<Loop_LIN_PRICAT> LINLoop;
    }
    public class Loop_PRI_PRICAT
    {
        public PRI_2 PRI;
        public CUX CUX;
        public List<APR> APR;
        public RNG RNG;
        public List<DTM_3> DTM;
    }
    public class Loop_PRI_PRICAT_2
    {
        public PRI_2 PRI;
        public CUX CUX;
        public List<APR> APR;
        public RNG RNG;
        public List<DTM_3> DTM;
        public List<LOC_12> LOC;
    }
    public class Loop_QTY_PRICAT
    {
        public QTY_11 QTY;
        public RNG RNG;
    }
    public class Loop_RFF_PRICAT
    {
        public RFF_31 RFF;
        public List<DTM_3> DTM;
    }
    public class Loop_RFF_PRICAT_2
    {
        public RFF_31 RFF;
    }
    public class Loop_RTE_PRICAT
    {
        public RTE RTE;
        public RNG RNG;
    }
    public class Loop_TAX_PRICAT
    {
        public TAX_5 TAX;
    }
    public class Loop_TAX_PRICAT_2
    {
        public TAX_5 TAX;
        public MOA_20 MOA;
    }
    public class Loop_TAX_PRICAT_3
    {
        public TAX_5 TAX;
        public MOA_20 MOA;
    }
    public class Loop_TDT_PRICAT
    {
        public TDT_7 TDT;
    }
    public class Loop_TOD_PRICAT
    {
        public TOD_3 TOD;
        public List<LOC_12> LOC;
    }
    public class Loop_TRU_PRICAT
    {
        public TRU TRU;
        public List<DTM_3> DTM;
    }
    public class TSPRICAT 
    {
        public UNH UNH;
        public BGM_34 BGM;
        public List<DTM_3> DTM;
        public List<FTX_22> FTX;
        public List<Loop_RFF_PRICAT> RFFLoop;
        public List<Loop_NAD_PRICAT> NADLoop;
        public List<Loop_TAX_PRICAT> TAXLoop;
        public List<Loop_CUX_PRICAT> CUXLoop;
        public List<Loop_PAT_PRICAT> PATLoop;
        public List<Loop_TDT_PRICAT> TDTLoop;
        public List<Loop_TOD_PRICAT> TODLoop;
        public List<Loop_ALC_PRICAT> ALCLoop;
        public List<Loop_TRU_PRICAT> TRULoop;
        public List<Loop_PGI_PRICAT> PGILoop;
        public UNT UNT;
    }
}
