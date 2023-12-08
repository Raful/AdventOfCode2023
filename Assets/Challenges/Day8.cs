using UnityEngine;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;

public class Day8 : MonoBehaviour
{
    string _input = "LLRLRRRLLRRRLRRLRRLRLRRRLRRRLRLLRLRRLRRLRLLRRLRRRLRRLRLRLRLRRRLRRLRLLLRRLRRRLLLRLRRRLRRRLLRRLRRRLRLRRRLLLRRLLRRLRRLLLRRRLRRRLRRRLRRLLRLRLRLRRRLRLRLRRLRRLRLRRRLRRLRRRLRRRLLLRLRRLRRLRLLRRLLRRLRRLLRLRRLRRLRLRLLLRLLRRLRRLRRRLLRRLLRRRLRRLRRRLRRRLLRRRLRRRLLRRRLRLRLLRRLRLRLRRRR\r\n\r\nCGM = (SFJ, BVH)\r\nHRM = (PBG, QHK)\r\nBJR = (JJM, BPB)\r\nJTG = (RMK, GCR)\r\nNSG = (QLT, LTH)\r\nTJK = (TBJ, DTN)\r\nHNX = (FCF, MCS)\r\nMNC = (GCP, QBR)\r\nKPH = (JDP, QMR)\r\nSHD = (KGS, JXK)\r\nVDM = (QLR, NVD)\r\nVMT = (KHJ, SXN)\r\nCLX = (XTB, GXS)\r\nLBQ = (LFP, MVC)\r\nXLR = (BGR, XSG)\r\nXVK = (JLG, QGJ)\r\nDGC = (QDM, PLL)\r\nNLS = (DFL, RMX)\r\nNQP = (FNM, JBQ)\r\nJHV = (BRX, LCB)\r\nQDK = (RHC, TDX)\r\nTFC = (HXH, HXH)\r\nPPH = (XKS, JLP)\r\nSFD = (BCN, PDX)\r\nVTN = (PMB, RFZ)\r\nXTN = (JXL, VDM)\r\nGJL = (PFP, KQH)\r\nRDL = (NFR, VMT)\r\nRKN = (NSD, TQV)\r\nSXQ = (RPP, JTX)\r\nKBM = (XLR, FFM)\r\nKBP = (QHL, RTR)\r\nBSJ = (JGX, GGG)\r\nPSD = (GHB, NLC)\r\nSJH = (VNL, GCN)\r\nFNC = (PRP, JQL)\r\nTVQ = (RGT, CFH)\r\nJXT = (SVV, VQK)\r\nRXL = (TTK, BDP)\r\nKHD = (JTG, QLQ)\r\nMKX = (SVV, VQK)\r\nKQH = (CTC, XXX)\r\nNLR = (CJK, HDF)\r\nMKJ = (VJC, VGR)\r\nRFC = (NLC, GHB)\r\nFCJ = (FCD, JFC)\r\nKNP = (KVK, QKB)\r\nHFV = (BSM, HMV)\r\nNSJ = (BBT, NQD)\r\nHCR = (CVT, TXN)\r\nFCG = (DKK, QXJ)\r\nKTB = (HRR, VDV)\r\nLMH = (LMM, LMM)\r\nSVL = (LJG, DVG)\r\nVHG = (LMT, SHD)\r\nNXL = (FDK, VBR)\r\nHVJ = (FTH, GDD)\r\nQDX = (MXS, RMJ)\r\nKTV = (MTG, RMV)\r\nSCJ = (RFC, PSD)\r\nXPG = (FLL, FPG)\r\nBRX = (SHN, DDN)\r\nTDN = (QHP, HTL)\r\nPHL = (XPD, PCF)\r\nQDM = (MBM, CVP)\r\nMFF = (HDR, HHR)\r\nCPV = (FQP, JBL)\r\nVSN = (VXL, NLS)\r\nJVG = (LFP, MVC)\r\nDFL = (CJT, HSK)\r\nQQJ = (SCJ, BGM)\r\nHKP = (QFQ, QDS)\r\nJFN = (FML, KKR)\r\nCTL = (VXC, PNT)\r\nGSC = (MNC, QMK)\r\nFGS = (SHK, SHK)\r\nFDQ = (LMQ, DJK)\r\nLLQ = (TXH, RLG)\r\nMGG = (QKQ, XCQ)\r\nBPP = (LNV, FKM)\r\nKLQ = (TDD, QCC)\r\nMXS = (DMQ, XVK)\r\nBFH = (SHS, TPX)\r\nQMQ = (SLB, PPG)\r\nBBT = (HRP, JDR)\r\nGBR = (CLS, KMG)\r\nMKG = (MNV, XFQ)\r\nVRT = (QJQ, STK)\r\nDHV = (FPC, JCM)\r\nVBR = (CLV, XDN)\r\nFPV = (JBG, CPG)\r\nFDX = (MQF, FSL)\r\nJBG = (HQS, TRD)\r\nKJK = (DKK, QXJ)\r\nMMB = (DMH, VDC)\r\nBVK = (JGC, HXT)\r\nPPC = (STP, MRF)\r\nLMT = (JXK, KGS)\r\nPTF = (XPG, HCH)\r\nCQC = (SCM, NNR)\r\nBHH = (HMN, KSS)\r\nSHN = (CHN, MMR)\r\nLNV = (NTN, TJK)\r\nTJF = (HHJ, NNC)\r\nFSK = (JNQ, XGH)\r\nJKD = (PBG, QHK)\r\nNPS = (CPG, JBG)\r\nBKG = (GSC, SLT)\r\nCNS = (VRK, XLJ)\r\nRGM = (PRL, QFX)\r\nQJH = (QJQ, STK)\r\nPMB = (RRG, SCV)\r\nQJM = (TQV, NSD)\r\nDKK = (RMC, KXH)\r\nHKV = (PDX, BCN)\r\nFBB = (VTG, QBN)\r\nFMV = (HTN, LVX)\r\nRMV = (LPK, HQQ)\r\nKXH = (CBH, KPT)\r\nXLV = (PLL, QDM)\r\nFDT = (VLS, TVH)\r\nRJP = (DBL, GKV)\r\nJXL = (QLR, NVD)\r\nLFM = (BNB, SXT)\r\nMQP = (NFD, XRB)\r\nDJH = (NTT, HPP)\r\nFNR = (HNB, SKV)\r\nSHQ = (SGT, SRS)\r\nQLB = (KVM, GNZ)\r\nXGN = (MGG, PRR)\r\nPCF = (KHD, PFL)\r\nPBS = (VCJ, PPM)\r\nXBG = (FLG, KSG)\r\nBDQ = (MNS, HQL)\r\nXCB = (RJP, CXN)\r\nSXL = (HTF, BBL)\r\nDMH = (JGV, FNS)\r\nRGS = (NSR, BXS)\r\nHHJ = (HBN, LBF)\r\nNKS = (KTM, GDS)\r\nPTV = (JJG, LGQ)\r\nVXC = (TST, QSR)\r\nPFL = (JTG, QLQ)\r\nRQQ = (SMQ, PTF)\r\nNTT = (JTJ, FNF)\r\nLCB = (DDN, SHN)\r\nGQL = (HDR, HHR)\r\nHHF = (CJD, MHD)\r\nFQN = (LRB, FNR)\r\nBKF = (GBX, PBS)\r\nTSQ = (PPC, FJX)\r\nRRF = (CNS, HTK)\r\nDPP = (CGM, LVF)\r\nDNS = (RXN, KHV)\r\nGKH = (TXH, RLG)\r\nTVG = (DVG, LJG)\r\nXBP = (PSS, TTN)\r\nCXN = (GKV, DBL)\r\nFGG = (PTL, BLB)\r\nTBM = (FVL, VVN)\r\nCFQ = (JBP, NXD)\r\nFNB = (LDN, TBN)\r\nVDF = (GLX, FMJ)\r\nPQM = (MPR, PQC)\r\nMCS = (VNV, JNB)\r\nSFJ = (KHF, RVG)\r\nGBH = (CXN, RJP)\r\nDML = (FBB, NDF)\r\nQRB = (BGL, BDQ)\r\nCXB = (NLP, JKJ)\r\nGCP = (BSJ, PKP)\r\nKTM = (CQC, TRB)\r\nBPV = (CDN, RTV)\r\nTVS = (SHK, KVD)\r\nBDP = (PHL, CFC)\r\nHXK = (CGL, XDS)\r\nXSG = (TVG, SVL)\r\nHHR = (FGS, TVS)\r\nRTF = (NDF, FBB)\r\nLHH = (GCV, GCV)\r\nNXD = (JVG, LBQ)\r\nHTF = (QMH, HPV)\r\nTVB = (CBM, CCQ)\r\nFCF = (JNB, VNV)\r\nRFZ = (SCV, RRG)\r\nDJK = (TLN, BPP)\r\nTTK = (CFC, PHL)\r\nCLM = (BNC, TMG)\r\nTDH = (HTK, CNS)\r\nPHM = (RHM, CJM)\r\nSHS = (SPJ, KRK)\r\nSHM = (KVM, KVM)\r\nTTR = (XTB, GXS)\r\nQFX = (FMR, NSJ)\r\nLXR = (GJK, JFR)\r\nVSP = (FCD, JFC)\r\nXSX = (RMJ, MXS)\r\nGHQ = (TXK, DXP)\r\nTXH = (KBC, XMQ)\r\nBVC = (MDH, RBB)\r\nVKH = (MNV, XFQ)\r\nDBL = (XVQ, NHS)\r\nGDD = (BTK, VSN)\r\nFSC = (CFQ, DRK)\r\nJJG = (TQM, JPV)\r\nPBG = (FHB, CMD)\r\nVBN = (PTL, BLB)\r\nBLB = (LMH, QXF)\r\nPPG = (TFC, TGC)\r\nDPC = (KJK, FCG)\r\nPTJ = (TPN, SHQ)\r\nJLS = (CJM, RHM)\r\nRHC = (MFF, GQL)\r\nGXV = (SXL, GFG)\r\nXTH = (JFG, FJJ)\r\nRDX = (STR, XTN)\r\nGBJ = (SHS, TPX)\r\nSHL = (CQK, DPG)\r\nKHV = (RCH, BDZ)\r\nQFN = (MBD, KRJ)\r\nFGT = (TPQ, KBF)\r\nGHK = (MQG, QRB)\r\nSRS = (HPM, MSQ)\r\nMRF = (BVK, FVR)\r\nDMQ = (QGJ, JLG)\r\nPXV = (VXC, PNT)\r\nNSP = (JFR, GJK)\r\nTPB = (VBR, FDK)\r\nDDN = (MMR, CHN)\r\nDMG = (FJX, PPC)\r\nMHR = (SCC, SCC)\r\nRKR = (BKF, HMS)\r\nJFJ = (BHH, RRD)\r\nPSG = (GSG, KTB)\r\nPRP = (GVJ, CDG)\r\nTHL = (TJF, MDQ)\r\nGJK = (VCD, BGK)\r\nGLM = (JFG, FJJ)\r\nJQS = (CFK, JFJ)\r\nJTX = (SMN, TLP)\r\nCDG = (BPV, GQB)\r\nSXN = (FSK, MNF)\r\nFCK = (VDH, CKR)\r\nDSH = (TNR, RTL)\r\nBGM = (RFC, PSD)\r\nFJJ = (HRL, LPD)\r\nFLL = (TBM, JQX)\r\nMHS = (QGV, LSD)\r\nFKM = (TJK, NTN)\r\nJFB = (JHV, XRL)\r\nRPP = (TLP, SMN)\r\nNTN = (TBJ, DTN)\r\nKMG = (KPH, FRJ)\r\nNSM = (VLS, TVH)\r\nKFL = (XCM, PJG)\r\nSXT = (BKT, HJP)\r\nNSD = (TNX, MTD)\r\nVNL = (HMT, DGR)\r\nMSL = (MCS, FCF)\r\nPQC = (DNG, NLQ)\r\nNDS = (VGR, VJC)\r\nPDK = (PHR, GVH)\r\nHMS = (PBS, GBX)\r\nVQS = (QBB, NLR)\r\nNNR = (HNX, MSL)\r\nCCQ = (PSG, RQK)\r\nJCN = (KBF, TPQ)\r\nJLG = (GTJ, DJH)\r\nJFC = (HKK, JSG)\r\nXGK = (BVJ, TVB)\r\nDFG = (LHC, SFH)\r\nGTJ = (NTT, HPP)\r\nCLS = (FRJ, KPH)\r\nQMB = (JLS, PHM)\r\nGSR = (VPL, GGP)\r\nCPQ = (SHL, DNQ)\r\nPFQ = (XKS, JLP)\r\nLBR = (LFM, PCK)\r\nTLS = (HXD, SSL)\r\nQDF = (TBN, LDN)\r\nDHL = (GGQ, RDX)\r\nQJQ = (QMB, LNP)\r\nBVV = (TJL, QQJ)\r\nFNM = (GJL, GJB)\r\nMLA = (VNL, GCN)\r\nTXK = (HKP, DGV)\r\nLDJ = (PQC, MPR)\r\nQPF = (HMK, KJD)\r\nHQL = (MCT, KFL)\r\nFPG = (TBM, JQX)\r\nMNF = (JNQ, XGH)\r\nJQL = (CDG, GVJ)\r\nQMH = (RST, NQP)\r\nGCR = (LBR, HBF)\r\nCBH = (HNS, XXG)\r\nMQF = (JCN, FGT)\r\nQJD = (XGN, NVN)\r\nQDS = (TDG, NKS)\r\nMDH = (TLS, XQN)\r\nJFG = (HRL, LPD)\r\nQKB = (LSF, FQN)\r\nLND = (SLB, PPG)\r\nXKJ = (FHG, BFK)\r\nJKC = (RTL, TNR)\r\nQGJ = (GTJ, DJH)\r\nPCK = (BNB, SXT)\r\nKVK = (LSF, FQN)\r\nNXS = (FDT, NSM)\r\nQMK = (QBR, GCP)\r\nSQK = (LQK, NSG)\r\nTPQ = (XLV, DGC)\r\nMDQ = (HHJ, NNC)\r\nHCH = (FPG, FLL)\r\nBRB = (BJR, RJF)\r\nTDX = (MFF, GQL)\r\nPSS = (CLM, NBP)\r\nKHJ = (MNF, FSK)\r\nRHM = (SHC, QML)\r\nFNF = (FNQ, DHV)\r\nVVN = (PJN, VQB)\r\nTPF = (PRP, JQL)\r\nCDN = (DHL, BKJ)\r\nTPX = (SPJ, KRK)\r\nDNQ = (CQK, DPG)\r\nKJD = (GLM, XTH)\r\nGCL = (LHC, SFH)\r\nJQB = (QPF, KCX)\r\nFPC = (SFD, HKV)\r\nVQK = (XCB, GBH)\r\nFNS = (RRF, TDH)\r\nLLC = (QGV, LSD)\r\nDXR = (NPS, FPV)\r\nBHN = (NSL, PSF)\r\nJGD = (KNG, XKG)\r\nXXG = (JNM, NSK)\r\nBPB = (JXT, MKX)\r\nFTH = (BTK, VSN)\r\nGVH = (DFG, GCL)\r\nBVN = (BHN, TBQ)\r\nTPN = (SGT, SRS)\r\nTST = (CLX, TTR)\r\nJNB = (PQM, LDJ)\r\nLVF = (SFJ, BVH)\r\nVXL = (RMX, DFL)\r\nTJS = (FKB, SXB)\r\nHMV = (TRL, PSC)\r\nSCM = (HNX, MSL)\r\nBRF = (NSP, LXR)\r\nRGT = (QDT, DXR)\r\nVNV = (PQM, LDJ)\r\nNQD = (HRP, JDR)\r\nGDQ = (JCX, RKR)\r\nXQD = (XCH, MJC)\r\nVCD = (SMV, LNS)\r\nNBX = (BQG, SDG)\r\nHKR = (DJK, LMQ)\r\nJNQ = (KGX, PDK)\r\nVMG = (FCK, XPL)\r\nPHR = (GCL, DFG)\r\nKBC = (RKX, CPQ)\r\nHRL = (VDF, JXD)\r\nNVN = (PRR, MGG)\r\nDPV = (GGP, VPL)\r\nLGL = (QHL, RTR)\r\nTRD = (RGM, NRV)\r\nLPD = (VDF, JXD)\r\nQHL = (XDK, XNP)\r\nBXL = (SXL, GFG)\r\nCGL = (CNP, TVR)\r\nGJR = (QPF, KCX)\r\nQBN = (KJC, HCR)\r\nFHG = (SJH, SJH)\r\nBVJ = (CCQ, CBM)\r\nXFQ = (JNV, BKG)\r\nHQS = (RGM, NRV)\r\nCPG = (HQS, TRD)\r\nNHS = (RTF, DML)\r\nSHK = (XQD, XQD)\r\nKXR = (DQX, RSX)\r\nNLQ = (KLQ, JXP)\r\nQKQ = (HVJ, MMT)\r\nDKB = (NPF, XBP)\r\nBTK = (NLS, VXL)\r\nCTC = (CTL, PXV)\r\nVBD = (LMT, SHD)\r\nJBL = (HHF, NNX)\r\nCMV = (DRX, RHV)\r\nLSD = (NJM, CHD)\r\nTPG = (JTX, RPP)\r\nDMN = (GSR, DPV)\r\nJXK = (FGG, VBN)\r\nGGQ = (XTN, STR)\r\nGJF = (CGM, LVF)\r\nGSN = (VJQ, CKG)\r\nVLS = (GFS, GHM)\r\nQBB = (CJK, HDF)\r\nJXD = (GLX, FMJ)\r\nRLG = (KBC, XMQ)\r\nJQX = (VVN, FVL)\r\nLRP = (QBB, NLR)\r\nLGQ = (TQM, JPV)\r\nBNB = (HJP, BKT)\r\nVJC = (QJD, DLN)\r\nFDK = (XDN, CLV)\r\nCFH = (QDT, DXR)\r\nNRV = (QFX, PRL)\r\nCNT = (FCJ, VSP)\r\nKPZ = (GCN, VNL)\r\nKRJ = (DBQ, KBM)\r\nCRJ = (VQL, BFG)\r\nDTN = (GXM, QFN)\r\nHTN = (XGK, CVM)\r\nFJX = (MRF, STP)\r\nPNT = (QSR, TST)\r\nRHV = (KTV, HSX)\r\nCFK = (RRD, BHH)\r\nVDH = (BRF, QXQ)\r\nSFH = (LHH, SBH)\r\nMBT = (HSV, VDG)\r\nRMJ = (XVK, DMQ)\r\nCJD = (TMR, MMB)\r\nVJQ = (FNB, QDF)\r\nDLN = (XGN, NVN)\r\nSDG = (HHG, FSC)\r\nKGS = (FGG, VBN)\r\nSGT = (MSQ, HPM)\r\nJBQ = (GJL, GJB)\r\nGCN = (DGR, HMT)\r\nMNP = (CFK, JFJ)\r\nDMT = (GDQ, QFB)\r\nSTP = (FVR, BVK)\r\nTQR = (FCK, XPL)\r\nHBF = (PCK, LFM)\r\nMBD = (DBQ, KBM)\r\nHNS = (NSK, JNM)\r\nRSX = (NDS, MKJ)\r\nHXD = (MHR, FJM)\r\nKVM = (CMV, KRP)\r\nSLT = (QMK, MNC)\r\nPFP = (XXX, CTC)\r\nTGC = (HXH, DNS)\r\nGDS = (CQC, TRB)\r\nTMG = (CNT, KKQ)\r\nBQA = (VHX, MQS)\r\nGFG = (BBL, HTF)\r\nJCR = (QRB, MQG)\r\nTQM = (KNP, QNN)\r\nGLX = (VKC, NDM)\r\nKSG = (LLQ, GKH)\r\nJVP = (BDP, TTK)\r\nTXN = (JFB, CPF)\r\nGJB = (PFP, KQH)\r\nDVG = (JCR, GHK)\r\nBGC = (FKB, SXB)\r\nVDC = (FNS, JGV)\r\nBKJ = (RDX, GGQ)\r\nNFR = (KHJ, SXN)\r\nXVQ = (RTF, DML)\r\nVRC = (DPV, GSR)\r\nTNR = (GHQ, XRP)\r\nJSS = (LGQ, JJG)\r\nPDX = (DMN, VRC)\r\nPPM = (XHK, DKB)\r\nHDR = (FGS, FGS)\r\nMJA = (CMV, KRP)\r\nCFC = (PCF, XPD)\r\nGXM = (KRJ, MBD)\r\nNLC = (JTN, FVN)\r\nDRX = (HSX, KTV)\r\nCCH = (HCJ, HGM)\r\nTRB = (NNR, SCM)\r\nSSL = (MHR, FJM)\r\nQRC = (MHS, LLC)\r\nRTR = (XDK, XNP)\r\nQLT = (BVC, DSM)\r\nLJG = (JCR, GHK)\r\nHMK = (GLM, XTH)\r\nTVR = (JQB, GJR)\r\nJCX = (BKF, HMS)\r\nTNX = (BFH, GBJ)\r\nSMQ = (XPG, HCH)\r\nLSL = (TDX, RHC)\r\nPFD = (PTV, JSS)\r\nJGV = (TDH, RRF)\r\nNFJ = (XKG, KNG)\r\nCPP = (FMV, TFR)\r\nGNZ = (KRP, CMV)\r\nXCL = (XDR, JFN)\r\nQJN = (DMT, TGX)\r\nDBQ = (FFM, XLR)\r\nRMX = (CJT, HSK)\r\nPLL = (MBM, CVP)\r\nTQV = (TNX, MTD)\r\nFLG = (LLQ, GKH)\r\nGTF = (CPP, QTV)\r\nJLP = (BLM, HPD)\r\nTLN = (FKM, LNV)\r\nLMM = (CDJ, CDJ)\r\nQPD = (PTF, SMQ)\r\nCBM = (RQK, PSG)\r\nJKJ = (NFJ, JGD)\r\nNSL = (XCL, PNC)\r\nRST = (JBQ, FNM)\r\nGBG = (VMT, NFR)\r\nMPR = (DNG, NLQ)\r\nMSQ = (MCR, GTF)\r\nJTN = (QCX, KKM)\r\nCKG = (QDF, FNB)\r\nTRL = (DPC, XSV)\r\nSVV = (XCB, GBH)\r\nNVD = (VRT, QJH)\r\nGHM = (XVJ, GFN)\r\nNFD = (QRC, XJL)\r\nHPD = (QMQ, LND)\r\nQFB = (RKR, JCX)\r\nDRK = (NXD, JBP)\r\nDQX = (MKJ, NDS)\r\nTGX = (GDQ, QFB)\r\nJTJ = (FNQ, DHV)\r\nDSM = (RBB, MDH)\r\nTVH = (GHM, GFS)\r\nRBV = (HMV, BSM)\r\nKBF = (XLV, DGC)\r\nKSS = (DPP, GJF)\r\nCNP = (JQB, GJR)\r\nHGM = (VMG, TQR)\r\nGGP = (GFJ, TVQ)\r\nGVD = (HTL, QHP)\r\nTMR = (VDC, DMH)\r\nFCD = (JSG, HKK)\r\nMNV = (JNV, BKG)\r\nHRJ = (VJQ, CKG)\r\nHXB = (KSG, FLG)\r\nDJX = (MQP, RFN)\r\nCJM = (SHC, QML)\r\nVDV = (LRP, VQS)\r\nLCR = (LQK, NSG)\r\nRTL = (GHQ, XRP)\r\nXDR = (KKR, FML)\r\nJCL = (GVD, TDN)\r\nLVX = (CVM, XGK)\r\nRKX = (SHL, DNQ)\r\nFRJ = (JDP, QMR)\r\nTMZ = (MJC, XCH)\r\nLPK = (LMK, CCH)\r\nJDP = (GSN, HRJ)\r\nKPT = (HNS, XXG)\r\nHDN = (QQJ, TJL)\r\nLTH = (DSM, BVC)\r\nNDF = (QBN, VTG)\r\nDKV = (NSM, FDT)\r\nJGX = (NVL, QTJ)\r\nHBN = (BXL, GXV)\r\nBGR = (SVL, TVG)\r\nLBF = (GXV, BXL)\r\nGBX = (PPM, VCJ)\r\nMXB = (HSV, VDG)\r\nXMQ = (RKX, CPQ)\r\nAAA = (TPN, SHQ)\r\nNDM = (QJM, RKN)\r\nXQN = (HXD, SSL)\r\nQML = (XHF, THL)\r\nMNS = (KFL, MCT)\r\nJNM = (FNC, TPF)\r\nNNX = (CJD, MHD)\r\nVKC = (RKN, QJM)\r\nXRL = (BRX, LCB)\r\nPNC = (JFN, XDR)\r\nGHB = (JTN, FVN)\r\nCJK = (VKH, MKG)\r\nPRR = (XCQ, QKQ)\r\nHXH = (RXN, RXN)\r\nBXD = (KXR, RXS)\r\nVPL = (GFJ, TVQ)\r\nDPF = (MQP, RFN)\r\nSTK = (QMB, LNP)\r\nDGR = (CPV, GSF)\r\nXHF = (MDQ, TJF)\r\nGFJ = (CFH, RGT)\r\nDXP = (DGV, HKP)\r\nQMR = (HRJ, GSN)\r\nVTG = (KJC, HCR)\r\nLRM = (JSS, PTV)\r\nDNG = (KLQ, JXP)\r\nBFK = (SJH, KPZ)\r\nTBJ = (GXM, QFN)\r\nRFN = (XRB, NFD)\r\nMTG = (LPK, HQQ)\r\nVTT = (SHM, QLB)\r\nNJQ = (CDJ, VTN)\r\nHHG = (DRK, CFQ)\r\nSTR = (VDM, JXL)\r\nLTF = (TPL, FDX)\r\nPJN = (MLR, CXB)\r\nXGH = (KGX, PDK)\r\nQLQ = (GCR, RMK)\r\nXTB = (VHG, VBD)\r\nCKR = (BRF, QXQ)\r\nKKQ = (FCJ, VSP)\r\nQCX = (GBR, DMB)\r\nHNB = (PTJ, PTJ)\r\nTDG = (KTM, GDS)\r\nGRC = (TDN, GVD)\r\nXJL = (LLC, MHS)\r\nQSR = (CLX, TTR)\r\nRXS = (DQX, RSX)\r\nHJK = (BQG, SDG)\r\nGVJ = (GQB, BPV)\r\nKGX = (GVH, PHR)\r\nJGC = (BXD, PGT)\r\nCQK = (TSQ, DMG)\r\nRQK = (GSG, KTB)\r\nLFP = (JQS, MNP)\r\nHKK = (RQQ, QPD)\r\nXSV = (KJK, FCG)\r\nTJL = (BGM, SCJ)\r\nVFV = (RDL, GBG)\r\nHDF = (MKG, VKH)\r\nTGA = (RRG, SCV)\r\nVDG = (NBX, HJK)\r\nCLV = (MXB, MBT)\r\nLQK = (QLT, LTH)\r\nJNV = (GSC, SLT)\r\nFQP = (NNX, HHF)\r\nSCC = (SHM, SHM)\r\nLSF = (LRB, LRB)\r\nHPM = (GTF, MCR)\r\nGFS = (GFN, XVJ)\r\nXCQ = (HVJ, MMT)\r\nQTJ = (HDN, BVV)\r\nNNC = (HBN, LBF)\r\nRRG = (GPS, BVN)\r\nSJN = (QDX, XSX)\r\nBQG = (FSC, HHG)\r\nXPL = (VDH, CKR)\r\nQXF = (LMM, NJQ)\r\nLMK = (HCJ, HGM)\r\nDHJ = (TPL, FDX)\r\nVQL = (TJS, BGC)\r\nBGL = (HQL, MNS)\r\nRMK = (LBR, HBF)\r\nFVR = (JGC, HXT)\r\nTFR = (LVX, HTN)\r\nPTL = (LMH, QXF)\r\nDGV = (QFQ, QDS)\r\nKKM = (GBR, DMB)\r\nXVJ = (HXB, XBG)\r\nGQB = (CDN, RTV)\r\nXDN = (MBT, MXB)\r\nQLR = (VRT, QJH)\r\nFFM = (BGR, XSG)\r\nXRB = (XJL, QRC)\r\nGKV = (XVQ, NHS)\r\nVHX = (DKV, NXS)\r\nHPP = (FNF, JTJ)\r\nXRP = (TXK, DXP)\r\nXKG = (GRC, JCL)\r\nFNQ = (JCM, FPC)\r\nBJQ = (VQL, BFG)\r\nHRP = (VFV, HJM)\r\nSMN = (KBP, LGL)\r\nJSG = (RQQ, QPD)\r\nNSK = (FNC, TPF)\r\nVRK = (FDQ, HKR)\r\nMLR = (NLP, JKJ)\r\nFVL = (PJN, VQB)\r\nGXS = (VBD, VHG)\r\nNSR = (CRJ, BJQ)\r\nGCV = (FHG, FHG)\r\nCVM = (BVJ, TVB)\r\nSLB = (TFC, TGC)\r\nKKR = (CSR, BRB)\r\nRBB = (XQN, TLS)\r\nRXN = (RCH, RCH)\r\nGPS = (TBQ, BHN)\r\nHTK = (VRK, XLJ)\r\nHJM = (RDL, GBG)\r\nKJC = (CVT, TXN)\r\nBBL = (QMH, HPV)\r\nSBH = (GCV, XKJ)\r\nHSX = (RMV, MTG)\r\nCDJ = (PMB, PMB)\r\nFKB = (PPH, PFQ)\r\nFSL = (FGT, JCN)\r\nBFG = (BGC, TJS)\r\nHRR = (LRP, VQS)\r\nLRB = (HNB, HNB)\r\nVGR = (QJD, DLN)\r\nFMJ = (NDM, VKC)\r\nKRP = (DRX, RHV)\r\nBTQ = (XDS, CGL)\r\nQHP = (RXL, JVP)\r\nJCM = (HKV, SFD)\r\nSMV = (VHL, QJN)\r\nLNP = (PHM, JLS)\r\nXDK = (SQK, LCR)\r\nPDV = (BXS, NSR)\r\nPJG = (SJN, GPC)\r\nVHL = (DMT, TGX)\r\nZZZ = (SHQ, TPN)\r\nQGV = (NJM, CHD)\r\nGFN = (XBG, HXB)\r\nJJM = (JXT, MKX)\r\nQNN = (KVK, QKB)\r\nQHK = (FHB, CMD)\r\nXNP = (LCR, SQK)\r\nRRD = (HMN, KSS)\r\nHJP = (SXQ, TPG)\r\nQXQ = (LXR, NSP)\r\nVQB = (MLR, CXB)\r\nJDR = (HJM, VFV)\r\nHSV = (HJK, NBX)\r\nPKP = (GGG, JGX)\r\nPGT = (KXR, RXS)\r\nPRL = (NSJ, FMR)\r\nCVP = (PFD, LRM)\r\nTLP = (KBP, LGL)\r\nCSR = (BJR, RJF)\r\nDPG = (DMG, TSQ)\r\nRJF = (JJM, BPB)\r\nLDN = (JKD, HRM)\r\nTBQ = (NSL, PSF)\r\nBCN = (VRC, DMN)\r\nSPJ = (RGS, PDV)\r\nCHN = (HFV, RBV)\r\nKHF = (DJX, DPF)\r\nBDZ = (MQS, VHX)\r\nXLJ = (FDQ, HKR)\r\nFVN = (QCX, KKM)\r\nVCJ = (XHK, DKB)\r\nNLP = (NFJ, JGD)\r\nCPF = (JHV, XRL)\r\nGSG = (HRR, VDV)\r\nPSF = (PNC, XCL)\r\nTPL = (FSL, MQF)\r\nTTN = (NBP, CLM)\r\nXXX = (PXV, CTL)\r\nSXB = (PPH, PFQ)\r\nHMN = (GJF, DPP)\r\nCHD = (LSL, QDK)\r\nHPV = (RST, NQP)\r\nCVT = (CPF, JFB)\r\nQXJ = (RMC, KXH)\r\nJPV = (KNP, QNN)\r\nGGG = (NVL, QTJ)\r\nRVG = (DJX, DPF)\r\nMJC = (JKC, DSH)\r\nXDS = (TVR, CNP)\r\nCMD = (LTF, DHJ)\r\nMQS = (NXS, DKV)\r\nRTV = (BKJ, DHL)\r\nNBP = (BNC, TMG)\r\nFMR = (NQD, BBT)\r\nXHK = (XBP, NPF)\r\nQBR = (PKP, BSJ)\r\nRCH = (VHX, MQS)\r\nBNC = (CNT, KKQ)\r\nHXT = (PGT, BXD)\r\nMTD = (GBJ, BFH)\r\nHTL = (RXL, JVP)\r\nMMR = (HFV, RBV)\r\nFHB = (DHJ, LTF)\r\nQDT = (FPV, NPS)\r\nMMT = (GDD, FTH)\r\nKCX = (KJD, HMK)\r\nXPD = (PFL, KHD)\r\nKNG = (GRC, JCL)\r\nHCJ = (TQR, VMG)\r\nGPC = (XSX, QDX)\r\nFJM = (SCC, VTT)\r\nXCM = (SJN, GPC)\r\nBSM = (TRL, PSC)\r\nHSK = (HXK, BTQ)\r\nMVC = (MNP, JQS)\r\nJXP = (TDD, QCC)\r\nSKV = (PTJ, ZZZ)\r\nQCC = (TPB, NXL)\r\nCJT = (HXK, BTQ)\r\nKRK = (PDV, RGS)\r\nSHC = (XHF, THL)\r\nMQG = (BDQ, BGL)\r\nHMT = (CPV, GSF)\r\nSCV = (BVN, GPS)\r\nQFQ = (NKS, TDG)\r\nBXS = (CRJ, BJQ)\r\nLHC = (LHH, SBH)\r\nQTV = (TFR, FMV)\r\nNVL = (HDN, BVV)\r\nBKT = (TPG, SXQ)\r\nJFR = (VCD, BGK)\r\nGSF = (JBL, FQP)\r\nTDD = (NXL, TPB)\r\nPSC = (DPC, XSV)\r\nMCR = (QTV, CPP)\r\nMHD = (MMB, TMR)\r\nNPF = (PSS, TTN)\r\nTBN = (JKD, HRM)\r\nRMC = (KPT, CBH)\r\nDMB = (CLS, KMG)\r\nBLM = (QMQ, LND)\r\nNJM = (QDK, LSL)\r\nFML = (BRB, CSR)\r\nLNS = (QJN, VHL)\r\nBJA = (XCH, MJC)\r\nJBP = (JVG, LBQ)\r\nKVD = (XQD, TMZ)\r\nLMQ = (BPP, TLN)\r\nBVH = (RVG, KHF)\r\nXCH = (JKC, DSH)\r\nHQQ = (LMK, CCH)\r\nXKS = (HPD, BLM)\r\nBGK = (SMV, LNS)\r\nMBM = (LRM, PFD)\r\nMCT = (XCM, PJG)";

    private void Awake()
    {
        Debug.Log("Day 8 part 1: " + ExecutePart1(_input));
        Debug.Log("Day 8 part 2: " + ExecutePart2(_input));
    }

    public static int ExecutePart1(string input)
    {
        string[] splitInputAndMap = input.Split("\r\n\r\n");

        string lrInput = splitInputAndMap[0];

        Dictionary<string, LRDirection> map = ParseDirectionMap(splitInputAndMap[1]);

        string currentNode = "AAA";

        int stepCount = 0;
        while (currentNode != "ZZZ")
        {
            for (int i = 0; i < lrInput.Length && currentNode != "ZZZ"; i++)
            {
                currentNode = map[currentNode].GetDirection(lrInput[i]);

                stepCount++;
            }
        }

        return stepCount;
    }
    public static long ExecutePart2(string input)
    {
        string[] splitInputAndMap = input.Split("\r\n\r\n");

        string lrInput = splitInputAndMap[0];

        Dictionary<string, LRDirection> map = ParseDirectionMap(splitInputAndMap[1]);

        string[] currentNodes = map.Keys.Where(m => m.EndsWith('A')).ToArray();
        List<int> nodeIndicesToSearch = new List<int>();
        List<int> nodeIndicesToRemove = new List<int>();

        int[] stepsToGoal = new int[currentNodes.Length];
        for (int i = 0; i < stepsToGoal.Length; i++)
        {
            stepsToGoal[i] = 0;
            nodeIndicesToSearch.Add(i);
        }

        while (nodeIndicesToSearch.Count > 0)
        {
            for (int i = 0; i < lrInput.Length; i++)
            {
                foreach (int j in nodeIndicesToSearch)
                {
                    currentNodes[j] = map[currentNodes[j]].GetDirection(lrInput[i]);
                    stepsToGoal[j]++;

                    if (currentNodes[j].EndsWith('Z'))
                        nodeIndicesToRemove.Add(j);
                }

                nodeIndicesToSearch.RemoveAll(n => nodeIndicesToRemove.Contains(n));
                nodeIndicesToRemove.Clear();
            }
        }

        return LowestCommonMultiplier(stepsToGoal);
    }

    public static long LowestCommonMultiplier(int[] values)
    {
        long currentLCM = values[0];

        for (int i = 1; i < values.Length; i++)
        {
            long otherLCM = values[i];
            long currentLCMIncrement = currentLCM;

            while (currentLCM != otherLCM)
            {
                if (currentLCM < otherLCM)
                {
                    currentLCM += currentLCMIncrement;
                }
                else
                {
                    otherLCM = currentLCM + (currentLCM % values[i]);
                }
            }
        }

        return currentLCM;
    }

    static Dictionary<string, LRDirection> ParseDirectionMap(string mapString)
    {
        //Example input: AAA = (BBB, BBB)\r\nBBB = (AAA, ZZZ)\r\nZZZ = (ZZZ, ZZZ)

        Dictionary<string, LRDirection> map = new Dictionary<string, LRDirection>();

        string[] lines = mapString.Split("\r\n");

        foreach (string line in lines)
        {
            //Example line: AAA = (BBB, BBB)

            string[] splitEquals = line.Split(" = ");

            map.Add(splitEquals[0], new LRDirection(splitEquals[1]));
        }
        
        return map;
    }

    public class LRDirection
    {
        public string Left { get; private set; }
        public string Right { get; private set; }

        public LRDirection(string input)
        {
            //Example input: (SFJ, BVH)
            Left = input.Substring(1, 3);
            Right = input.Substring(6, 3);
        }

        public string GetDirection(char directionInput)
        {
            return directionInput == 'L' ? Left : Right;
        }
    }
}
