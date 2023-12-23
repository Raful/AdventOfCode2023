using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Windows;
using static Day20.ModuleBase;

public class Day20 : MonoBehaviour
{
    string _input = "hz{m>3518:A,A}\r\nxjq{s<700:R,x>3290:A,a>2004:R,R}\r\ndn{x<1908:R,a>539:A,s>1576:R,kdn}\r\nql{m<3667:rpl,A}\r\njsd{m>1643:R,R}\r\ndvq{s<1083:R,x>2321:A,A}\r\nqzq{x<3660:A,a>2909:jnb,vhm}\r\npz{s>3001:jlf,zj}\r\ngb{s>236:tpj,mk}\r\nkgl{s<3549:nfm,a>2025:R,x>1769:A,A}\r\njkc{s>1836:A,x>1826:A,vt}\r\nzn{a<471:A,s<757:lmg,th}\r\nvhm{s<3774:A,a<2437:A,A}\r\ngq{x>3007:ngs,xmr}\r\nlz{x>314:R,a>1284:R,A}\r\ngsg{m>1029:R,x>3382:R,R}\r\ncqj{x<2250:A,A}\r\nczh{x<2534:ntq,s>296:nvl,cq}\r\nsjb{m>910:A,s>2975:A,R}\r\ngss{m<3349:R,R}\r\nsf{m<1613:A,x>1749:R,s<2024:R,R}\r\nqd{m<2979:R,s>420:A,s<211:mmr,hc}\r\nnm{m<2530:A,a<690:R,A}\r\ncf{s<2923:A,A}\r\ngqh{m<690:gzc,ft}\r\nkxg{s<868:A,s>881:R,x<2889:R,R}\r\nbqk{s>1277:rqv,a>1262:xrn,xtd}\r\njjf{s<2363:R,a>312:R,R}\r\nqlv{a>1656:rp,sx}\r\nczx{s<374:R,A}\r\ncvm{m<3623:A,a>3090:R,a<2883:R,A}\r\nnp{x<57:R,R}\r\ndf{a>2646:tct,qgd}\r\npq{m>3886:A,s>1300:A,A}\r\ngvj{x<3344:A,m<3208:A,x<3652:R,A}\r\nftk{s>183:czh,m<2812:dxs,mpj}\r\ngdl{a>2242:R,A}\r\ntpj{a>1952:R,x>414:A,a>1633:A,R}\r\nhd{m<746:A,x>3172:A,x<2654:lk,jjf}\r\npqj{m<2823:rlq,m>3109:rj,A}\r\nttj{s<1462:mj,A}\r\nvcl{x>2410:A,s>1991:A,x<2115:R,A}\r\ngsd{m>2665:A,x<2552:R,s<1074:A,A}\r\ndh{s<1213:A,bvg}\r\nxf{s>2328:pc,s<1137:jmc,tlf}\r\njkd{x>1888:cf,x<908:kc,A}\r\nnxd{m>3569:A,x<552:R,A}\r\nkjv{x<2636:zt,x<3183:lkx,m>3114:qrb,pn}\r\nkrp{s>3241:R,m<3498:A,A}\r\nsmm{m<734:A,R}\r\nph{a<3213:A,m>3216:R,A}\r\nnz{x<2386:dtq,s>2080:A,A}\r\nsgj{a<1835:R,A}\r\nqrb{a<955:cxr,m>3690:dc,tn}\r\nnk{x>795:qp,A}\r\nplm{m<1874:jbr,nkj}\r\nlc{x>454:A,x<266:R,A}\r\njj{a>2841:A,a<2118:A,R}\r\npj{m>3173:nxd,x<414:A,hdb}\r\nrh{x<3019:R,A}\r\nnfm{x>1631:R,A}\r\nblh{x<1029:pj,brl}\r\nppt{a<3642:R,m<1223:gsg,A}\r\nhk{a<2029:hpn,s<492:zbb,jt}\r\nnmj{s<207:R,m<3830:A,x<2241:A,R}\r\ndl{a<871:A,m>2275:A,A}\r\ncbs{s<609:vx,s<657:R,A}\r\nvf{m>3366:A,a>560:R,a>296:A,A}\r\nxq{a>1033:R,a<956:A,A}\r\npc{x>3394:A,x<3086:R,a>2727:A,A}\r\nnnk{m>2619:R,a>3006:hpp,jkh}\r\nzt{m>3191:zpb,bsq}\r\nvl{x<3532:A,s>887:A,R}\r\nlmg{m>3564:R,R}\r\nxrf{s>425:kq,m>2828:A,a>324:nm,fsk}\r\ntn{x<3644:zpz,m<3397:A,rch}\r\nhf{a<1446:A,x<2942:A,x<3022:A,R}\r\nbt{s<2790:lbf,a>1654:qpp,s>3238:nql,kjv}\r\ngg{a>2956:gsd,m<2713:dvq,R}\r\nmv{s>651:A,m<1448:A,x<146:A,A}\r\ntp{m>3253:gss,x>1334:A,ms}\r\npg{x<2282:R,a<1349:vg,m>2840:R,hfl}\r\nrch{x>3834:A,s<3078:R,A}\r\ncxr{s>2975:plt,x>3547:R,x<3385:gr,fxd}\r\nbk{m<3130:hkl,m<3476:tp,m>3712:bgc,skz}\r\nxbx{a>3426:rc,s<863:sd,hq}\r\nkd{s>1340:A,A}\r\nbjf{a<593:R,A}\r\nmhm{a>1647:A,a>1415:A,m<2372:A,A}\r\nfx{a<3216:vz,srj}\r\nml{a<2860:R,R}\r\nkzv{s<1301:A,R}\r\njkh{s<947:R,R}\r\npcl{m<3722:rvk,s>1134:pq,a<2815:R,A}\r\nbm{m<776:A,a>3600:R,A}\r\nhrt{s<674:R,x>2588:R,a>2018:R,A}\r\nlqj{x<676:kfp,x>856:lt,br}\r\ndhd{m<2607:R,A}\r\nqcv{x<1535:kl,R}\r\nszq{x>2379:hd,a>306:dn,s<1822:hkd,dns}\r\ntqq{a<522:mb,R}\r\nlkx{a<878:tqq,sbt}\r\nvcc{x>109:R,m<1781:R,m<1933:np,R}\r\ngdz{a>3532:A,A}\r\nvgt{m<1215:vcl,jcg}\r\nbxp{s>1485:A,s<563:R,m>1025:A,A}\r\nbmd{x<2839:rxh,a>2312:nmm,s>1414:krn,bq}\r\nrhg{s<152:A,R}\r\ncz{a<1432:ztv,xfr}\r\nvsd{a>2247:R,a>1946:R,a>1844:A,R}\r\nmqt{x<3172:R,x<3581:R,x>3825:R,R}\r\ntq{x<2593:R,A}\r\nfj{m<3481:rh,tv}\r\ngx{m>2883:R,R}\r\nch{m<517:nk,pd}\r\nmbs{s>1219:A,s<1197:R,x>2230:R,R}\r\nrr{s<927:A,x>1452:A,x<1372:R,R}\r\ncgj{s<3063:R,A}\r\nbbv{s>1112:R,R}\r\ntqz{a>3803:nbb,psq}\r\nncz{m>3717:R,a<634:R,R}\r\njcg{s<2537:R,m<1343:R,A}\r\njt{x<1325:pbb,R}\r\nkzb{m>3653:jqx,m>3482:gf,x>3249:xsk,rjx}\r\nrqv{m<3538:zzl,s<1338:tkq,R}\r\nhsb{a>1037:R,x>870:R,A}\r\njb{x<2075:A,x<2506:lxt,A}\r\nvbk{a<2870:gjb,a>3277:A,dp}\r\njqs{a<1324:A,m>2852:R,a>1529:R,A}\r\nqm{a>3573:A,R}\r\nrzk{x<557:vmp,s<83:tvm,m<3236:mc,ncz}\r\nts{s<3733:fh,tfn}\r\nnsj{a<1336:A,a>1857:A,a>1584:A,R}\r\nvt{a>1102:R,m>2866:R,A}\r\nzkj{x>2500:R,a<467:A,R}\r\nbs{m<724:A,x>3306:fhb,x>3204:A,kdl}\r\nplt{x>3572:R,m<3702:R,s<3130:R,A}\r\njfc{x>924:sf,m<1651:lz,mpg}\r\nknp{m>564:A,m<232:A,s>2339:A,R}\r\nqgd{a<1965:cm,A}\r\ntdm{m>2827:R,m>2718:A,a>3015:R,A}\r\nhgj{s>1445:zq,xrb}\r\nztv{m>1357:qsl,tpx}\r\nfhb{s>1607:R,a<3027:R,A}\r\nkhd{a>3834:R,m>3473:R,R}\r\ntrc{s>512:rrk,m>2509:nd,s>326:sxh,cng}\r\nhr{a>656:A,m>2850:R,x>3389:A,A}\r\nrp{a>2022:R,R}\r\ngjb{a<2267:A,R}\r\nfd{x<1052:vtp,a<949:jrn,hk}\r\nfz{a>980:R,A}\r\nccg{m>2905:R,a>2436:R,R}\r\nqlg{m>1037:R,R}\r\nnhh{x>2581:ql,m>3642:nmj,a>1170:kpf,jdt}\r\njlf{x>3531:R,s>3219:A,A}\r\nnd{s<173:vbb,s>385:npn,bxz}\r\nfhj{m<724:R,a>3762:R,x>3053:R,R}\r\ntx{m>1717:A,m<1555:R,R}\r\nqz{x<3152:R,m<1947:R,tz}\r\nbln{m>1964:A,R}\r\nlh{s<2877:xqk,R}\r\nxhd{x<3255:ps,dz}\r\nkrn{m>1099:gm,gjk}\r\nhpp{a<3169:A,s<938:R,A}\r\nsrj{m<3640:A,A}\r\nfgh{m>1756:R,m>1722:R,s>1813:A,R}\r\ngrd{x<1684:A,x>2484:A,x<2179:R,A}\r\nmpj{a<3142:A,x<2258:tpz,R}\r\njv{x>3146:sq,s>269:R,cb}\r\nvc{a<1112:A,m<1598:jng,m<1694:A,fgh}\r\ntct{a>3518:R,jp}\r\nszk{x>2702:A,s>821:A,x<2020:A,R}\r\ntt{x<3002:A,x<3058:R,s<2845:R,A}\r\nxv{a<1832:A,s<1237:A,s<1251:A,R}\r\nvrq{a<1062:jtr,R}\r\nfbz{m>2837:A,A}\r\nms{m<3212:A,A}\r\ndz{x>3696:dk,m<3179:A,A}\r\nsq{x<3517:A,m<1576:R,m>1616:A,R}\r\nvrv{x>2073:A,m<3335:A,a>3264:R,A}\r\nnx{s>284:R,A}\r\nbq{a<1964:ddh,zmr}\r\nghk{a<441:R,A}\r\nbr{a<2694:smm,x>795:zzv,s<2123:A,R}\r\nkmr{x>1717:A,a>3663:A,s<3538:R,R}\r\nhc{s<318:A,R}\r\nvr{a<399:A,x>2222:A,m>3016:A,A}\r\ncl{m>2530:ct,x<1855:qvv,dh}\r\nvmp{x>236:R,x>131:A,A}\r\nvq{s>526:vb,a>2478:kf,jv}\r\nmdb{a<380:R,m<2455:R,A}\r\ncpb{s<1179:dzj,dj}\r\nssz{s>1128:A,R}\r\nmmr{m<3107:R,R}\r\nddh{x>3498:tm,R}\r\nmk{x>561:A,s>98:R,x>197:R,R}\r\njdn{a>1667:R,xlx}\r\nskh{s<2941:R,a<1171:R,s<3134:A,A}\r\nktr{s>2122:rk,a<757:tsm,vrq}\r\njs{x<1491:A,R}\r\njnr{s<796:R,s>1213:R,A}\r\nxd{x<2458:hv,x<3129:cgj,m>2807:qbb,pz}\r\nhfl{s<300:A,R}\r\nzxt{s<2782:A,s<3589:A,s>3804:R,R}\r\nkf{s<213:kht,s<412:nx,m>1587:A,ksp}\r\njdt{a<424:R,x<2178:R,a<690:A,tvf}\r\ndns{s<2857:xbf,s<3399:llz,a>196:fdf,jsq}\r\ndd{x>1491:R,s<398:A,A}\r\njmc{a<2988:xjq,s>688:A,trj}\r\nhkd{a<163:jnr,R}\r\nzmb{m<3165:pls,gpv}\r\nmb{m<3218:A,m>3585:A,m>3436:A,R}\r\nmsx{x<3666:R,m<3398:R,a<3006:R,A}\r\nvz{s<1252:A,A}\r\nbvc{s<449:R,a>3035:A,R}\r\ngz{x<3316:zcz,qzq}\r\nbb{m<2381:R,x>2178:R,a<1435:R,A}\r\nqch{s>2944:A,m>1485:A,s>2282:R,R}\r\nfdf{a>234:R,a<219:R,m<652:R,R}\r\nbqr{m<1655:A,A}\r\ndjn{x>2008:nt,a<993:jns,x<1955:R,sjr}\r\nxbf{m<712:A,x>1977:R,A}\r\nqpp{s<3361:xd,x>2233:gz,s>3593:ts,sxk}\r\nsrq{s<567:nhh,s<733:kzb,a<1151:nfr,fj}\r\nvgz{x<2442:R,x>3163:A,s<1109:A,A}\r\nspf{m>3098:A,a>1114:R,x<2359:vr,R}\r\nlk{m<1007:R,m<1155:A,A}\r\ncq{x<3030:R,m<3304:A,s>244:R,R}\r\nhpn{m>3374:A,s<535:R,R}\r\npnr{s<564:R,a>1040:A,x>573:knx,vd}\r\ncc{s>1430:mfd,A}\r\nfdb{s>349:R,s>228:A,s>81:A,A}\r\ncm{m<1985:R,x>2862:R,A}\r\nzg{x<2013:R,s>3441:A,R}\r\nth{s<768:A,s<776:R,m>3551:R,R}\r\nbvt{s<883:pxk,A}\r\nps{x<2852:R,a<1334:kj,R}\r\nxmr{x>2490:xs,x<2141:djn,m>2911:spf,pg}\r\ntsm{s<872:A,a<426:bln,x>1500:db,A}\r\nqsl{m<1825:gd,m>1995:tmb,m>1914:ktr,plm}\r\ntvf{s<308:A,m<3477:A,x>2430:A,R}\r\nnbb{a>3887:R,m<2823:A,khd}\r\njsq{m<806:R,a<125:R,R}\r\ngm{s<2956:R,m>1252:dfc,s>3550:R,R}\r\nkv{x>203:R,x<134:A,m<1920:R,R}\r\nbgc{m>3875:R,ssz}\r\nrxh{a<2551:vgt,jb}\r\npsq{s<967:dvk,m<3358:A,R}\r\nrg{x>249:R,x<137:A,A}\r\nrt{a>1268:R,a<1073:A,R}\r\nrcf{m<3157:A,x<3888:R,R}\r\nxtd{a<718:mbs,a>915:ss,a<801:R,A}\r\ntlf{m>331:A,a>2999:R,A}\r\nzl{a<2924:R,a<3347:A,m>592:R,R}\r\nkdl{x<3179:A,a>3060:A,A}\r\nxrn{s>1236:mdq,a<2044:A,gj}\r\ngj{a>2399:R,a<2219:A,s>1215:A,A}\r\nfq{s>518:A,x>3344:A,s>294:A,A}\r\nrb{a>3423:R,a>2952:A,x>915:R,R}\r\nbg{a<433:dd,A}\r\nzzv{x<828:R,s>2255:A,s>1152:R,R}\r\nlp{m<3249:A,s<3008:A,m<3278:A,R}\r\ncvd{a<2723:A,gdz}\r\nzcz{m>3081:A,a>2862:R,a>2373:A,R}\r\nqk{a<1277:R,m<3551:R,R}\r\nhj{m>3271:A,x<1007:A,R}\r\ntr{a<839:A,A}\r\nrld{s<823:R,m<2378:R,A}\r\nfzv{a<1192:mqd,a<1307:kg,nz}\r\ngpv{x>1141:R,jl}\r\nzbb{a>2244:ccg,x>1335:mmf,bh}\r\nss{m<3642:A,A}\r\nzdd{m<2602:xt,tdm}\r\nzqq{m>575:R,A}\r\nzzz{a>3102:vrv,a<2800:cqj,a<2999:A,bvc}\r\nkfp{x>515:ml,A}\r\ndxf{a>315:R,R}\r\nvb{m>1613:jsd,a>2462:szk,hsz}\r\nlpk{s>1135:lht,s>989:gg,nnk}\r\njtr{m<1957:A,a<935:R,A}\r\nls{x>1788:zg,js}\r\nsd{s>376:lxx,ftk}\r\nff{x>3648:R,a<3816:R,R}\r\ndvk{m>3204:A,R}\r\nnc{a<1279:A,x<2499:R,R}\r\ndtq{x<2009:A,R}\r\nrks{m<3222:R,R}\r\nin{m<2131:cz,mtv}\r\njd{s>1478:td,m>1696:df,s<981:vq,vlr}\r\nct{a>879:xv,m>3005:A,nv}\r\nlt{s>1942:zf,R}\r\nzfj{a<1034:zkj,rhg}\r\ndfc{m>1352:R,a>2004:R,x<3229:R,A}\r\nvrx{m<3175:xxm,R}\r\nngs{a<867:lrj,x>3362:nj,qd}\r\nszg{a>2781:A,m<3156:R,a<2714:R,R}\r\nxg{m<2460:R,R}\r\nhh{x>2365:R,A}\r\nkg{m<614:tq,a<1245:R,x>2659:bxp,R}\r\nht{s<3063:R,x<1179:A,R}\r\ngv{x<2021:R,R}\r\nmqd{m<718:A,s<2597:R,qxn}\r\njng{m>1474:A,R}\r\nhzf{m>655:A,A}\r\ntdc{x<221:A,m>2804:R,A}\r\ntpx{x<1414:ch,a<816:szq,fzv}\r\nvxm{s<304:R,x<383:tdc,m<2773:mdb,A}\r\ndxs{x<2545:jcn,s<100:xg,s<153:A,jmj}\r\ngbb{x<2907:mvc,m<543:xf,x>3553:gqh,hjt}\r\nvg{s<356:A,m<2800:A,A}\r\ntkq{m>3809:A,s<1316:R,x>1546:R,R}\r\nzhp{m<1606:A,a>167:A,m<1712:A,R}\r\nzj{a<3026:A,s>2915:A,R}\r\nrkl{m>3409:R,A}\r\nrj{s>1336:A,R}\r\nskz{s<1142:vgz,m>3577:R,m<3533:nc,qk}\r\nbf{m>2781:zz,a>3752:A,a<3606:fdb,R}\r\nzs{a<2108:R,a<2506:R,tx}\r\ndj{s>1374:pzt,m>3269:bqk,s<1274:cl,sdn}\r\ndk{m>2966:R,s<971:R,m<2476:R,A}\r\nkdn{a<435:R,s<659:R,A}\r\ntv{a>1679:vsd,m<3686:R,x<2729:R,A}\r\nnfx{s<3034:A,x>3884:A,A}\r\nknx{x>816:R,x<702:A,R}\r\nrc{x<1712:fnm,tqz}\r\njbr{a<852:A,R}\r\ncgb{a<789:A,s<1835:A,m>3623:rt,A}\r\nxqk{a<1905:R,a>2223:A,a>2093:A,A}\r\nrrk{s>719:rld,a<1094:cbs,qlv}\r\nbvg{m<2397:R,R}\r\nzb{x<3060:R,a<430:qr,csg}\r\nvd{x>278:A,R}\r\nqkc{a<3268:lzc,R}\r\nhsz{m<1538:A,s<813:A,A}\r\nfg{s>3518:R,a<3152:A,A}\r\nzf{a<2679:A,x>922:R,A}\r\nnfr{s<786:zn,s>828:qvz,zb}\r\nlsq{s<2128:R,x<1564:A,R}\r\nvlr{m>1602:kzv,s<1153:mqt,fvn}\r\npzt{a<1316:hgj,x>2214:cc,ttj}\r\nfxd{a>391:R,a>191:R,s<2888:A,A}\r\nnt{s>446:R,x<2086:A,A}\r\nbts{a>638:R,A}\r\nlmt{a<2621:tt,a<3304:cx,fhj}\r\nds{x<646:A,A}\r\nmpg{m<1752:A,A}\r\ntz{s<2648:A,a>3313:A,s<3179:A,A}\r\nbrk{a<277:A,a>456:R,A}\r\ndc{m>3795:R,a>1285:cqc,m<3754:skh,A}\r\nrgq{a>637:A,x>2228:R,R}\r\nlht{a>3119:A,s>1330:A,R}\r\nmvc{a<2677:sg,fl}\r\ncng{x>2909:tc,s<113:kpq,s>224:fz,zfj}\r\nqbb{s<3159:hz,s<3283:krp,msx}\r\nlrj{x>3540:A,m<2947:fq,A}\r\njcn{x>1192:A,m>2569:R,A}\r\nfcd{m<948:A,x<1316:ht,qch}\r\nqvz{m>3696:kxg,a<538:R,tr}\r\nmh{m<3314:grd,s<712:R,x<1541:A,cvm}\r\ngbz{a<622:R,A}\r\nntq{s>250:A,m>3001:R,x<845:A,R}\r\nqr{s<813:R,R}\r\nrl{x>2198:A,x>2022:A,R}\r\ncs{a<815:A,s>2641:A,m<1444:A,R}\r\njqx{a<941:A,a>1538:hrt,A}\r\nvx{m<2417:R,x>3122:R,A}\r\ngt{s>2144:bqr,a>368:A,x<2059:zhp,A}\r\nmdq{x<1604:R,x>2419:R,s<1260:R,A}\r\ngzc{m>604:hzf,zqq}\r\nkpq{x<2542:bb,x>2734:nxl,a>928:R,ghk}\r\ntvm{s>36:R,a<694:R,m<3038:R,R}\r\ncqc{m>3736:R,a>1421:A,A}\r\ncx{x>2986:R,A}\r\nnxl{m>2336:R,a>1436:R,R}\r\nlbf{a>1678:ks,mml}\r\nmx{m<1054:A,a<2830:R,A}\r\nxlx{m>2271:R,a>1109:R,x<3278:R,A}\r\nxs{x<2732:A,m>3031:czx,x<2854:gzj,R}\r\nkm{x<2607:R,a>927:R,gvj}\r\npf{x>1306:rr,mx}\r\nqj{m<2324:brk,R}\r\njp{a>3169:R,s<612:R,a>2848:A,A}\r\nnmm{a<3403:sr,s<2153:sc,ppt}\r\nrpl{s>208:R,R}\r\ngjk{m>958:qlg,sjb}\r\nmc{s<140:R,s>158:A,a>577:R,A}\r\nqvv{s>1224:A,hsb}\r\ncb{m>1607:R,R}\r\nnvl{x<3257:R,a<3099:A,A}\r\nmmf{m<2967:A,A}\r\nkpf{s>198:rl,R}\r\nzmr{x<3388:vqn,R}\r\nrv{s<3061:R,R}\r\nnl{s<1931:pf,fcd}\r\nxrb{x<1432:R,A}\r\nkc{m<2063:R,A}\r\nrvk{s<1178:A,R}\r\nkfx{s>1262:R,x<1201:R,A}\r\nfb{s>2493:A,s>995:rg,m>1647:kv,mv}\r\npls{x<1059:ds,s<3787:R,x<1733:A,fqj}\r\nsr{a>2831:R,s<1861:vl,R}\r\nbxz{s<250:dhd,A}\r\nnhx{m>3054:R,R}\r\nlhq{m>650:R,x>2996:zl,s<1699:R,R}\r\nzz{x>740:A,m>3478:A,s>359:R,R}\r\nzd{s<2863:knp,R}\r\nsl{a>3038:qvb,xj}\r\nbh{x<1198:R,m<2785:A,R}\r\ntpz{m<3568:R,R}\r\nvtp{s>401:pnr,a>1078:gb,s<174:rzk,vxm}\r\nsp{m<1518:cs,s<2529:R,m<1688:A,A}\r\nxx{x>3480:R,x>3304:R,R}\r\ngzj{m<2860:A,a>1265:R,A}\r\nfnm{s>574:hj,bf}\r\nksp{s>456:A,R}\r\npxk{a>3069:R,s>481:A,R}\r\nxxm{x>2290:R,A}\r\ncsg{a>838:R,A}\r\npn{m<2473:sqj,a<1054:lts,qg}\r\nbxt{m<3605:A,s>674:A,R}\r\nkvs{s<3401:km,rks}\r\nvqn{m<1234:R,s<899:A,m<1365:R,R}\r\ndzj{s>1078:bk,x>2290:xhd,blh}\r\nhgz{a<561:A,s<3039:R,x>1054:R,R}\r\njns{s>319:A,m>2997:R,s<151:A,A}\r\nkj{m>3210:A,m>2599:R,A}\r\njnb{x>3800:R,a>3516:A,R}\r\npgg{x>1354:kd,m>2551:gbz,x>763:A,lc}\r\nsdn{a<991:pgg,s<1308:kzl,pqj}\r\nlxt{m<1151:R,x>2255:R,s>2561:A,R}\r\nnql{s<3500:kvs,x<2601:zmb,hp}\r\nnkj{x<1439:R,A}\r\nmfd{x<3094:A,x<3593:R,m<2791:R,R}\r\nnpn{s<446:R,R}\r\nrk{a<925:A,A}\r\nfh{m<3144:R,a>2601:rb,R}\r\nkq{x>1327:R,s<628:R,s<719:R,R}\r\nllz{x<1865:R,x<2062:R,m<533:R,A}\r\nft{s<1983:bbv,a<2323:gqm,a<3139:zxt,bm}\r\nmml{s>2364:vrx,m<3279:jkc,cgb}\r\nrlq{x>2132:R,m>2557:R,a>1746:A,A}\r\nprc{x>1012:nl,x>429:lqj,m>1338:nhr,dt}\r\ngqm{x>3726:A,s<2694:A,m<756:R,R}\r\nlvm{m<3367:A,s>598:A,x<2525:R,R}\r\ndb{m>1949:R,x>2355:R,A}\r\nfvh{m<1036:R,A}\r\nfsj{m>1663:A,x>2977:A,s>2939:R,A}\r\nmtv{s>1535:bt,a>2595:xbx,s>888:cpb,zjb}\r\nzq{x>2291:R,R}\r\nfsk{s>265:R,m<2431:A,s>111:A,A}\r\nlts{x>3595:bjf,hr}\r\ntmb{s>1466:jkd,qcv}\r\nxfr{x<1561:prc,m<833:gbb,m>1471:jd,bmd}\r\nzjb{x<1868:fd,m>3209:srq,m>2729:gq,trc}\r\ngf{m<3555:R,x<2969:bxt,m<3599:A,R}\r\nhgd{x<3424:jqs,x<3784:hcv,rcf}\r\ngr{m>3624:A,a>594:A,a>338:R,A}\r\nhcv{a<1292:A,m>3015:R,R}\r\nnj{m>3046:A,x<3685:fbz,m>2877:R,A}\r\nrjx{s<635:lvm,A}\r\njmj{m<2437:A,a<3023:R,A}\r\nhp{a>779:hgd,dxf}\r\nsqj{s<2972:R,m>2255:R,m<2212:rv,xx}\r\nvbb{s<93:A,a<1485:R,R}\r\nsc{x<3438:R,m<1135:A,a>3704:ff,qm}\r\nbrl{s<979:A,a<1569:R,s>1040:R,A}\r\nhkl{a>1206:A,rgq}\r\nsnt{a<3037:pcl,x>2181:qkc,fx}\r\nhv{m<2950:R,sdv}\r\nmj{a<1926:A,A}\r\ntm{s>687:R,A}\r\nsxh{x>2873:jdn,a>1033:mhm,a<613:qj,dl}\r\nsdv{m<3613:A,R}\r\nqg{s<2990:R,x<3664:gx,s<3085:nfx,R}\r\nvp{s<3458:R,a<3203:R,kmr}\r\nbsq{s<3005:R,A}\r\nqp{s<1699:A,A}\r\njl{s>3798:A,R}\r\nfvn{x>2512:A,s<1276:R,R}\r\nzzl{m>3437:R,x>2355:R,R}\r\nqxn{x<3126:R,m<1095:A,R}\r\npbb{m<3066:A,R}\r\nks{m<3192:cvd,lsq}\r\ntfn{a>3183:nhx,A}\r\ntrj{a<3362:A,m>290:A,x<3632:R,A}\r\nzpz{a<1354:R,s<3021:R,A}\r\nkl{m>2073:A,A}\r\nkht{a>3289:A,x<3178:R,A}\r\nxt{a>3063:A,x<2237:A,a>2887:A,A}\r\nfl{s>2668:fg,A}\r\nxsk{m<3311:nsj,a<1513:R,R}\r\ndt{s<2042:bvt,a>2530:zd,sgj}\r\ngd{a<620:gt,x>2444:vc,a>1108:jfc,sp}\r\nnv{s>1240:R,m>2836:R,a>353:A,R}\r\ntd{a<2465:lh,m<1779:fsj,qz}\r\nhq{m<3025:lpk,m>3391:snt,sl}\r\nkzl{m>2636:A,m<2420:R,R}\r\nhdb{m<2705:A,m<2892:A,s<988:A,R}\r\nlzc{s<1244:R,A}\r\npd{x>814:bts,fvh}\r\nfqj{a>577:R,x>2263:A,x>2013:R,A}\r\nhjt{x>3133:bs,s>2231:lmt,s>1243:lhq,jj}\r\ntc{a<1040:R,a<2061:R,R}\r\nsx{m>2430:R,a>1441:R,R}\r\njrn{m<3177:xrf,bg}\r\nsjr{s>434:R,R}\r\nsbt{a>1333:hf,m<2974:xq,A}\r\nxj{s<1140:szg,a>2875:hh,m>3181:gv,A}\r\nzpb{m>3499:hgz,m<3296:lp,s>2976:vf,rkl}\r\ndp{a>3031:A,a>2953:A,R}\r\nlxx{s>575:mh,m<2984:zdd,zzz}\r\nsxk{x<1180:vbk,a>2579:vp,s<3501:ls,kgl}\r\nqvb{s<1124:R,x<2353:kfx,ph}\r\nsg{x>2195:R,m>320:gdl,a>2241:A,R}\r\nnhr{a>2999:fb,x<176:vcc,zs}\r\n\r\n{x=1853,m=1718,a=852,s=421}\r\n{x=1856,m=768,a=800,s=33}\r\n{x=2847,m=1317,a=3464,s=932}\r\n{x=2618,m=561,a=3141,s=132}\r\n{x=148,m=476,a=2620,s=457}\r\n{x=388,m=1384,a=860,s=100}\r\n{x=1929,m=115,a=349,s=290}\r\n{x=3086,m=2861,a=1622,s=48}\r\n{x=31,m=423,a=315,s=1698}\r\n{x=174,m=907,a=49,s=122}\r\n{x=541,m=15,a=242,s=2732}\r\n{x=1552,m=95,a=350,s=1981}\r\n{x=741,m=981,a=3076,s=2421}\r\n{x=849,m=166,a=1512,s=1803}\r\n{x=13,m=1454,a=146,s=2150}\r\n{x=957,m=67,a=56,s=360}\r\n{x=243,m=368,a=1375,s=878}\r\n{x=890,m=274,a=421,s=83}\r\n{x=474,m=87,a=2601,s=767}\r\n{x=993,m=106,a=3272,s=1520}\r\n{x=102,m=295,a=545,s=2670}\r\n{x=2084,m=1274,a=2583,s=1055}\r\n{x=1440,m=57,a=2201,s=1181}\r\n{x=189,m=4,a=515,s=3434}\r\n{x=164,m=15,a=38,s=368}\r\n{x=643,m=2265,a=1169,s=1196}\r\n{x=133,m=323,a=36,s=737}\r\n{x=1924,m=859,a=590,s=268}\r\n{x=1308,m=668,a=627,s=64}\r\n{x=1277,m=1203,a=2822,s=164}\r\n{x=143,m=1445,a=1323,s=1941}\r\n{x=876,m=577,a=159,s=2538}\r\n{x=877,m=664,a=121,s=238}\r\n{x=578,m=1677,a=99,s=825}\r\n{x=94,m=697,a=629,s=786}\r\n{x=1108,m=1064,a=5,s=597}\r\n{x=416,m=2871,a=946,s=208}\r\n{x=1055,m=20,a=1258,s=1102}\r\n{x=85,m=144,a=1934,s=120}\r\n{x=747,m=2995,a=841,s=809}\r\n{x=205,m=94,a=959,s=1002}\r\n{x=251,m=1836,a=475,s=381}\r\n{x=363,m=765,a=187,s=536}\r\n{x=1823,m=1509,a=361,s=1068}\r\n{x=136,m=765,a=260,s=899}\r\n{x=1752,m=178,a=310,s=227}\r\n{x=318,m=617,a=1396,s=564}\r\n{x=1371,m=196,a=2487,s=2149}\r\n{x=2723,m=926,a=1502,s=1746}\r\n{x=146,m=448,a=181,s=2032}\r\n{x=1501,m=2536,a=1073,s=476}\r\n{x=850,m=900,a=29,s=2148}\r\n{x=984,m=128,a=1750,s=1273}\r\n{x=65,m=740,a=648,s=1147}\r\n{x=660,m=1068,a=1249,s=1061}\r\n{x=289,m=1612,a=710,s=1181}\r\n{x=1872,m=258,a=1788,s=508}\r\n{x=492,m=1178,a=125,s=618}\r\n{x=849,m=1586,a=3172,s=1776}\r\n{x=398,m=1499,a=737,s=645}\r\n{x=115,m=227,a=154,s=622}\r\n{x=415,m=505,a=388,s=338}\r\n{x=104,m=1398,a=921,s=164}\r\n{x=421,m=1201,a=3389,s=456}\r\n{x=661,m=237,a=292,s=283}\r\n{x=143,m=845,a=1391,s=1900}\r\n{x=777,m=141,a=207,s=3834}\r\n{x=780,m=927,a=62,s=430}\r\n{x=2947,m=1361,a=5,s=50}\r\n{x=3493,m=134,a=1163,s=2043}\r\n{x=135,m=456,a=58,s=1093}\r\n{x=1244,m=758,a=450,s=1089}\r\n{x=290,m=2583,a=1692,s=1164}\r\n{x=200,m=713,a=192,s=2113}\r\n{x=1164,m=57,a=3464,s=2020}\r\n{x=1023,m=137,a=1328,s=1460}\r\n{x=612,m=597,a=101,s=427}\r\n{x=2247,m=891,a=1224,s=2817}\r\n{x=870,m=3099,a=1275,s=305}\r\n{x=2099,m=1353,a=1867,s=55}\r\n{x=264,m=153,a=2560,s=1307}\r\n{x=274,m=125,a=167,s=27}\r\n{x=208,m=88,a=1676,s=1450}\r\n{x=5,m=161,a=3312,s=1403}\r\n{x=2294,m=1021,a=4,s=1766}\r\n{x=2683,m=91,a=441,s=2454}\r\n{x=503,m=1775,a=492,s=2809}\r\n{x=517,m=19,a=609,s=1051}\r\n{x=603,m=313,a=211,s=2889}\r\n{x=1663,m=342,a=1651,s=1501}\r\n{x=305,m=1190,a=232,s=1049}\r\n{x=3469,m=86,a=883,s=1897}\r\n{x=654,m=1526,a=741,s=186}\r\n{x=2611,m=959,a=541,s=1131}\r\n{x=3122,m=827,a=1701,s=1953}\r\n{x=594,m=1973,a=475,s=191}\r\n{x=134,m=1169,a=125,s=554}\r\n{x=4,m=401,a=176,s=3228}\r\n{x=2978,m=7,a=309,s=3088}\r\n{x=1187,m=2241,a=221,s=185}\r\n{x=666,m=1214,a=144,s=197}\r\n{x=176,m=30,a=208,s=3302}\r\n{x=1581,m=2530,a=596,s=244}\r\n{x=1264,m=1345,a=16,s=53}\r\n{x=122,m=424,a=2194,s=3612}\r\n{x=859,m=7,a=8,s=2258}\r\n{x=1346,m=211,a=113,s=34}\r\n{x=663,m=1448,a=2323,s=1344}\r\n{x=112,m=141,a=708,s=2131}\r\n{x=312,m=1345,a=1836,s=337}\r\n{x=5,m=1556,a=1244,s=848}\r\n{x=1589,m=233,a=21,s=933}\r\n{x=2173,m=2390,a=180,s=864}\r\n{x=1645,m=1798,a=773,s=297}\r\n{x=3292,m=109,a=1124,s=613}\r\n{x=482,m=1353,a=784,s=3347}\r\n{x=1189,m=3164,a=1874,s=1053}\r\n{x=495,m=431,a=831,s=35}\r\n{x=686,m=915,a=1823,s=809}\r\n{x=766,m=1004,a=1354,s=307}\r\n{x=3352,m=1047,a=471,s=148}\r\n{x=155,m=1449,a=997,s=345}\r\n{x=117,m=93,a=1355,s=14}\r\n{x=1710,m=1171,a=875,s=1402}\r\n{x=1339,m=1068,a=2676,s=354}\r\n{x=1306,m=29,a=1186,s=2010}\r\n{x=179,m=532,a=581,s=1137}\r\n{x=349,m=2778,a=1035,s=1522}\r\n{x=1779,m=831,a=91,s=447}\r\n{x=2267,m=267,a=370,s=177}\r\n{x=684,m=3595,a=349,s=55}\r\n{x=3394,m=422,a=1182,s=1468}\r\n{x=1902,m=359,a=956,s=2143}\r\n{x=3729,m=1383,a=799,s=887}\r\n{x=2182,m=855,a=1277,s=195}\r\n{x=608,m=1985,a=83,s=3923}\r\n{x=2768,m=233,a=1538,s=2232}\r\n{x=59,m=1225,a=270,s=983}\r\n{x=1804,m=2039,a=957,s=705}\r\n{x=460,m=1115,a=1049,s=376}\r\n{x=27,m=144,a=1421,s=2553}\r\n{x=838,m=2998,a=563,s=3050}\r\n{x=142,m=466,a=479,s=1125}\r\n{x=715,m=565,a=32,s=138}\r\n{x=156,m=668,a=507,s=2073}\r\n{x=1926,m=267,a=3414,s=554}\r\n{x=1253,m=1693,a=2019,s=360}\r\n{x=398,m=2354,a=1778,s=643}\r\n{x=954,m=525,a=1508,s=1607}\r\n{x=37,m=31,a=149,s=803}\r\n{x=212,m=383,a=1288,s=145}\r\n{x=39,m=639,a=364,s=1277}\r\n{x=2519,m=1272,a=31,s=2869}\r\n{x=162,m=1170,a=449,s=516}\r\n{x=2101,m=1142,a=2348,s=156}\r\n{x=915,m=2517,a=1793,s=2079}\r\n{x=540,m=856,a=2704,s=3}\r\n{x=414,m=836,a=71,s=1790}\r\n{x=2796,m=1429,a=60,s=928}\r\n{x=52,m=88,a=610,s=517}\r\n{x=1019,m=1532,a=2767,s=632}\r\n{x=1443,m=441,a=228,s=642}\r\n{x=328,m=595,a=947,s=936}\r\n{x=463,m=2650,a=104,s=3234}\r\n{x=789,m=62,a=281,s=257}\r\n{x=293,m=18,a=56,s=62}\r\n{x=9,m=665,a=556,s=426}\r\n{x=1141,m=1351,a=760,s=599}\r\n{x=370,m=839,a=102,s=1985}\r\n{x=2295,m=197,a=2136,s=181}\r\n{x=545,m=1190,a=1118,s=1373}\r\n{x=1488,m=1075,a=265,s=1678}\r\n{x=890,m=3,a=376,s=406}\r\n{x=75,m=318,a=14,s=264}\r\n{x=920,m=63,a=238,s=3394}\r\n{x=1787,m=3530,a=2762,s=5}\r\n{x=316,m=1158,a=1934,s=1069}\r\n{x=573,m=195,a=105,s=564}\r\n{x=1821,m=2141,a=579,s=808}\r\n{x=323,m=2219,a=61,s=208}\r\n{x=140,m=1375,a=46,s=2408}\r\n{x=358,m=529,a=220,s=31}\r\n{x=203,m=789,a=585,s=868}\r\n{x=2118,m=884,a=828,s=362}\r\n{x=388,m=2794,a=2062,s=372}\r\n{x=862,m=2303,a=1032,s=196}\r\n{x=725,m=1153,a=478,s=1423}\r\n{x=1353,m=313,a=2826,s=31}\r\n{x=2985,m=183,a=1256,s=734}\r\n{x=446,m=417,a=1970,s=122}\r\n{x=3598,m=2237,a=38,s=247}\r\n{x=455,m=1138,a=109,s=527}\r\n{x=697,m=1815,a=3009,s=530}\r\n{x=30,m=49,a=497,s=871}\r\n{x=866,m=400,a=1041,s=2446}\r\n{x=304,m=512,a=1530,s=194}\r\n{x=1213,m=2841,a=152,s=553}\r\n{x=477,m=547,a=534,s=2815}\r\n{x=411,m=765,a=70,s=1005}\r\n{x=1767,m=1973,a=872,s=494}";

    static Stack<SendData> pulsesToSend = new();

    void Awake()
    {
        Debug.Log("Day 20 part 1: " + Execute(_input));
        pulsesToSend.Clear();
    }

    public static long Execute(string input)
    {
        //input: broadcaster -> a, b, c\r\n%a -> b\r\n%b -> c\r\n%c -> inv\r\n&inv -> a

        ButtonModule button = new ButtonModule();
        BroadcasterModule broadcaster = new BroadcasterModule();
        FlipFlopModule a = new FlipFlopModule("a");
        FlipFlopModule b = new FlipFlopModule("b");
        FlipFlopModule c = new FlipFlopModule("c");
        ConjunctionModule inv = new ConjunctionModule("inv");

        List<ModuleBase> modules = new List<ModuleBase>();
        modules.Add(broadcaster);
        modules.Add(a);
        modules.Add(b);
        modules.Add(c);
        modules.Add(inv);

        button.outputs.Add(broadcaster);

        broadcaster.outputs.Add(a);
        broadcaster.outputs.Add(b);
        broadcaster.outputs.Add(c);

        a.outputs.Add(b);

        b.outputs.Add(c);

        c.outputs.Add(inv);

        inv.inputs.Add(broadcaster);
        inv.inputs.Add(c);

        inv.outputs.Add(a);

        PressButton(button, broadcaster);

        return default;
    }

    static void PressButton(ButtonModule button, BroadcasterModule broadcaster)
    {

        button.Trigger();

        while (pulsesToSend.Count > 0)
        {
            SendData sendData = pulsesToSend.Pop();
            foreach (ModuleBase module in sendData.outputs)
            {
                Debug.Log("Sending pulse to " + module.label);
                module.ReceivePulse(sendData.isHighPulse);
            }
        }
    }

    ModuleBase GetModuleType(string inputLine)
    {
        //%nx -> fn, rn

        if (inputLine[0] == '%')
            return new FlipFlopModule(inputLine.Substring(1, inputLine.IndexOf(' ') - 1));

        if (inputLine[0] == '&')
            return new ConjunctionModule(inputLine.Substring(1, inputLine.IndexOf(' ') - 1));

        if (inputLine.StartsWith("broadcaster"))
            return new BroadcasterModule();

        throw new Exception("Module type not detected from input " + inputLine);
    }
    
    public abstract class ModuleBase
    {
        public class SendData
        {
            public List<ModuleBase> outputs;
            public bool isHighPulse;

            public SendData(List<ModuleBase> outputs, bool isHighPulse)
            {
                this.outputs = outputs;
                this.isHighPulse = isHighPulse;
            }
        }

        public ModuleBase(string label)
        {
            this.label = label;
        }

        public const bool HIGH = true;
        public const bool LOW = false;

        public string label;

        public List<ModuleBase> outputs = new();

        public bool lastPulseHigh = false;

        public abstract void ReceivePulse(bool isHigh);

        protected void AddSendRequest(bool isHigh)
        {
            pulsesToSend.Push(new SendData(outputs, isHigh));
        }
    }

    public class ButtonModule : ModuleBase
    {
        public ButtonModule() : base("button") { }

        public override void ReceivePulse(bool isHigh)
        {
            throw new Exception("Button should never receive a pulse.");
        }

        public void Trigger()
        {
            AddSendRequest(LOW);
        }
    }

    public class BroadcasterModule : ModuleBase
    {
        public BroadcasterModule() : base("broadcaster") { }

        public override void ReceivePulse(bool isHigh)
        {
            Debug.Log("Broadcaster received pulse");
            AddSendRequest(isHigh);
        }
    }

    public class FlipFlopModule : ModuleBase
    {
        public FlipFlopModule(string label) : base(label) { }

        bool isOn = false;

        public override void ReceivePulse(bool isHigh)
        {
            if (isHigh)
                return;

            isOn = !isOn;

            AddSendRequest(isOn);
        }
    }

    public class ConjunctionModule : ModuleBase
    {
        public ConjunctionModule(string label) : base(label) { }

        public List<ModuleBase> inputs = new();

        public override void ReceivePulse(bool isHigh)
        {
            bool sendHigh = inputs.All(input => input.lastPulseHigh); //TODO: Handle lastPulseHigh differently

            AddSendRequest(sendHigh);
        }
    }
}