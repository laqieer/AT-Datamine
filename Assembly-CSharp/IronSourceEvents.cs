// Decompiled with JetBrains decompiler
// Type: IronSourceEvents
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000024")]
public class IronSourceEvents : MonoBehaviour
{
  [Token(Token = "0x40000C8")]
  private const string ERROR_CODE = "error_code";
  [Token(Token = "0x40000C9")]
  private const string ERROR_DESCRIPTION = "error_description";
  [Token(Token = "0x40000CA")]
  private const string INSTANCE_ID_KEY = "instanceId";
  [Token(Token = "0x40000CB")]
  private const string PLACEMENT_KEY = "placement";
  [Token(Token = "0x40000CD")]
  [FieldOffset(Offset = "0x18")]
  private IUnityInitialization initializationAndroid;
  [Token(Token = "0x40000CE")]
  [FieldOffset(Offset = "0x20")]
  private IUnityRewardedVideo rewardedVideoAndroid;
  [Token(Token = "0x40000CF")]
  [FieldOffset(Offset = "0x28")]
  private IUnityRewardedVideoManual rewardedVideoAndroidManual;
  [Token(Token = "0x40000D0")]
  [FieldOffset(Offset = "0x30")]
  private IUnityInterstitial interstitialAndroid;
  [Token(Token = "0x40000D1")]
  [FieldOffset(Offset = "0x38")]
  private IUnityOfferwall offerwallAndroid;
  [Token(Token = "0x40000D2")]
  [FieldOffset(Offset = "0x40")]
  private IUnityBanner bannerAndroid;
  [Token(Token = "0x40000D3")]
  [FieldOffset(Offset = "0x48")]
  private IUnitySegment segmentAndroid;
  [Token(Token = "0x40000D4")]
  [FieldOffset(Offset = "0x50")]
  private IUnityImpressionData impressionDataAndroid;

  [Token(Token = "0x14000013")]
  public static event Action onSdkInitializationCompletedEvent
  {
    [Token(Token = "0x600012A"), Address(RVA = "0x2049AC8", Offset = "0x2049AC8", VA = "0x2049AC8")] add
    {
    }
    [Token(Token = "0x600012B"), Address(RVA = "0x2049B80", Offset = "0x2049B80", VA = "0x2049B80")] remove
    {
    }
  }

  [Token(Token = "0x14000014")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceRewardedVideoEvents listener instead.", false)]
  public static event Action<IronSourceError> onRewardedVideoAdShowFailedEvent
  {
    [Token(Token = "0x600012C"), Address(RVA = "0x2049C38", Offset = "0x2049C38", VA = "0x2049C38")] add
    {
    }
    [Token(Token = "0x600012D"), Address(RVA = "0x2049D08", Offset = "0x2049D08", VA = "0x2049D08")] remove
    {
    }
  }

  [Token(Token = "0x14000015")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceRewardedVideoEvents listener instead.", false)]
  public static event Action onRewardedVideoAdOpenedEvent
  {
    [Token(Token = "0x600012E"), Address(RVA = "0x2049DD8", Offset = "0x2049DD8", VA = "0x2049DD8")] add
    {
    }
    [Token(Token = "0x600012F"), Address(RVA = "0x2049E94", Offset = "0x2049E94", VA = "0x2049E94")] remove
    {
    }
  }

  [Token(Token = "0x14000016")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceRewardedVideoEvents listener instead.", false)]
  public static event Action onRewardedVideoAdClosedEvent
  {
    [Token(Token = "0x6000130"), Address(RVA = "0x2049F50", Offset = "0x2049F50", VA = "0x2049F50")] add
    {
    }
    [Token(Token = "0x6000131"), Address(RVA = "0x204A00C", Offset = "0x204A00C", VA = "0x204A00C")] remove
    {
    }
  }

  [Token(Token = "0x14000017")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceRewardedVideoEvents listener instead.", false)]
  public static event Action onRewardedVideoAdStartedEvent
  {
    [Token(Token = "0x6000132"), Address(RVA = "0x204A0C8", Offset = "0x204A0C8", VA = "0x204A0C8")] add
    {
    }
    [Token(Token = "0x6000133"), Address(RVA = "0x204A184", Offset = "0x204A184", VA = "0x204A184")] remove
    {
    }
  }

  [Token(Token = "0x14000018")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceRewardedVideoEvents listener instead.", false)]
  public static event Action onRewardedVideoAdEndedEvent
  {
    [Token(Token = "0x6000134"), Address(RVA = "0x204A240", Offset = "0x204A240", VA = "0x204A240")] add
    {
    }
    [Token(Token = "0x6000135"), Address(RVA = "0x204A2FC", Offset = "0x204A2FC", VA = "0x204A2FC")] remove
    {
    }
  }

  [Token(Token = "0x14000019")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceRewardedVideoEvents listener instead.", false)]
  public static event Action<IronSourcePlacement> onRewardedVideoAdRewardedEvent
  {
    [Token(Token = "0x6000136"), Address(RVA = "0x204A3B8", Offset = "0x204A3B8", VA = "0x204A3B8")] add
    {
    }
    [Token(Token = "0x6000137"), Address(RVA = "0x204A488", Offset = "0x204A488", VA = "0x204A488")] remove
    {
    }
  }

  [Token(Token = "0x1400001A")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceRewardedVideoEvents listener instead.", false)]
  public static event Action<IronSourcePlacement> onRewardedVideoAdClickedEvent
  {
    [Token(Token = "0x6000138"), Address(RVA = "0x204A558", Offset = "0x204A558", VA = "0x204A558")] add
    {
    }
    [Token(Token = "0x6000139"), Address(RVA = "0x204A628", Offset = "0x204A628", VA = "0x204A628")] remove
    {
    }
  }

  [Token(Token = "0x1400001B")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceRewardedVideoEvents listener instead.", false)]
  public static event Action<bool> onRewardedVideoAvailabilityChangedEvent
  {
    [Token(Token = "0x600013A"), Address(RVA = "0x204A6F8", Offset = "0x204A6F8", VA = "0x204A6F8")] add
    {
    }
    [Token(Token = "0x600013B"), Address(RVA = "0x204A7C8", Offset = "0x204A7C8", VA = "0x204A7C8")] remove
    {
    }
  }

  [Token(Token = "0x1400001C")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceRewardedVideoEvents listener instead.", false)]
  public static event Action<IronSourceError> onRewardedVideoAdLoadFailedEvent
  {
    [Token(Token = "0x600013C"), Address(RVA = "0x204A898", Offset = "0x204A898", VA = "0x204A898")] add
    {
    }
    [Token(Token = "0x600013D"), Address(RVA = "0x204A968", Offset = "0x204A968", VA = "0x204A968")] remove
    {
    }
  }

  [Token(Token = "0x1400001D")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceRewardedVideoEvents listener instead.", false)]
  public static event Action onRewardedVideoAdReadyEvent
  {
    [Token(Token = "0x600013E"), Address(RVA = "0x204AA38", Offset = "0x204AA38", VA = "0x204AA38")] add
    {
    }
    [Token(Token = "0x600013F"), Address(RVA = "0x204AAF4", Offset = "0x204AAF4", VA = "0x204AAF4")] remove
    {
    }
  }

  [Token(Token = "0x1400001E")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
  public static event Action<string> onRewardedVideoAdOpenedDemandOnlyEvent
  {
    [Token(Token = "0x6000140"), Address(RVA = "0x204ABB0", Offset = "0x204ABB0", VA = "0x204ABB0")] add
    {
    }
    [Token(Token = "0x6000141"), Address(RVA = "0x204AC80", Offset = "0x204AC80", VA = "0x204AC80")] remove
    {
    }
  }

  [Token(Token = "0x1400001F")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
  public static event Action<string> onRewardedVideoAdClosedDemandOnlyEvent
  {
    [Token(Token = "0x6000142"), Address(RVA = "0x204AD50", Offset = "0x204AD50", VA = "0x204AD50")] add
    {
    }
    [Token(Token = "0x6000143"), Address(RVA = "0x204AE20", Offset = "0x204AE20", VA = "0x204AE20")] remove
    {
    }
  }

  [Token(Token = "0x14000020")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
  public static event Action<string> onRewardedVideoAdLoadedDemandOnlyEvent
  {
    [Token(Token = "0x6000144"), Address(RVA = "0x204AEF0", Offset = "0x204AEF0", VA = "0x204AEF0")] add
    {
    }
    [Token(Token = "0x6000145"), Address(RVA = "0x204AFC0", Offset = "0x204AFC0", VA = "0x204AFC0")] remove
    {
    }
  }

  [Token(Token = "0x14000021")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
  public static event Action<string> onRewardedVideoAdRewardedDemandOnlyEvent
  {
    [Token(Token = "0x6000146"), Address(RVA = "0x204B090", Offset = "0x204B090", VA = "0x204B090")] add
    {
    }
    [Token(Token = "0x6000147"), Address(RVA = "0x204B160", Offset = "0x204B160", VA = "0x204B160")] remove
    {
    }
  }

  [Token(Token = "0x14000022")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
  public static event Action<string, IronSourceError> onRewardedVideoAdShowFailedDemandOnlyEvent
  {
    [Token(Token = "0x6000148"), Address(RVA = "0x204B230", Offset = "0x204B230", VA = "0x204B230")] add
    {
    }
    [Token(Token = "0x6000149"), Address(RVA = "0x204B300", Offset = "0x204B300", VA = "0x204B300")] remove
    {
    }
  }

  [Token(Token = "0x14000023")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
  public static event Action<string> onRewardedVideoAdClickedDemandOnlyEvent
  {
    [Token(Token = "0x600014A"), Address(RVA = "0x204B3D0", Offset = "0x204B3D0", VA = "0x204B3D0")] add
    {
    }
    [Token(Token = "0x600014B"), Address(RVA = "0x204B4A0", Offset = "0x204B4A0", VA = "0x204B4A0")] remove
    {
    }
  }

  [Token(Token = "0x14000024")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
  public static event Action<string, IronSourceError> onRewardedVideoAdLoadFailedDemandOnlyEvent
  {
    [Token(Token = "0x600014C"), Address(RVA = "0x204B570", Offset = "0x204B570", VA = "0x204B570")] add
    {
    }
    [Token(Token = "0x600014D"), Address(RVA = "0x204B640", Offset = "0x204B640", VA = "0x204B640")] remove
    {
    }
  }

  [Token(Token = "0x14000025")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceInterstitialEvents listener instead.", false)]
  public static event Action onInterstitialAdReadyEvent
  {
    [Token(Token = "0x600014E"), Address(RVA = "0x204B710", Offset = "0x204B710", VA = "0x204B710")] add
    {
    }
    [Token(Token = "0x600014F"), Address(RVA = "0x204B7CC", Offset = "0x204B7CC", VA = "0x204B7CC")] remove
    {
    }
  }

  [Token(Token = "0x14000026")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceInterstitialEvents listener instead.", false)]
  public static event Action<IronSourceError> onInterstitialAdLoadFailedEvent
  {
    [Token(Token = "0x6000150"), Address(RVA = "0x204B888", Offset = "0x204B888", VA = "0x204B888")] add
    {
    }
    [Token(Token = "0x6000151"), Address(RVA = "0x204B958", Offset = "0x204B958", VA = "0x204B958")] remove
    {
    }
  }

  [Token(Token = "0x14000027")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceInterstitialEvents listener instead.", false)]
  public static event Action onInterstitialAdOpenedEvent
  {
    [Token(Token = "0x6000152"), Address(RVA = "0x204BA28", Offset = "0x204BA28", VA = "0x204BA28")] add
    {
    }
    [Token(Token = "0x6000153"), Address(RVA = "0x204BAE4", Offset = "0x204BAE4", VA = "0x204BAE4")] remove
    {
    }
  }

  [Token(Token = "0x14000028")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceInterstitialEvents listener instead.", false)]
  public static event Action onInterstitialAdClosedEvent
  {
    [Token(Token = "0x6000154"), Address(RVA = "0x204BBA0", Offset = "0x204BBA0", VA = "0x204BBA0")] add
    {
    }
    [Token(Token = "0x6000155"), Address(RVA = "0x204BC5C", Offset = "0x204BC5C", VA = "0x204BC5C")] remove
    {
    }
  }

  [Token(Token = "0x14000029")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceInterstitialEvents listener instead.", false)]
  public static event Action onInterstitialAdShowSucceededEvent
  {
    [Token(Token = "0x6000156"), Address(RVA = "0x204BD18", Offset = "0x204BD18", VA = "0x204BD18")] add
    {
    }
    [Token(Token = "0x6000157"), Address(RVA = "0x204BDD4", Offset = "0x204BDD4", VA = "0x204BDD4")] remove
    {
    }
  }

  [Token(Token = "0x1400002A")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceInterstitialEvents listener instead.", false)]
  public static event Action<IronSourceError> onInterstitialAdShowFailedEvent
  {
    [Token(Token = "0x6000158"), Address(RVA = "0x204BE90", Offset = "0x204BE90", VA = "0x204BE90")] add
    {
    }
    [Token(Token = "0x6000159"), Address(RVA = "0x204BF60", Offset = "0x204BF60", VA = "0x204BF60")] remove
    {
    }
  }

  [Token(Token = "0x1400002B")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceInterstitialEvents listener instead.", false)]
  public static event Action onInterstitialAdClickedEvent
  {
    [Token(Token = "0x600015A"), Address(RVA = "0x204C030", Offset = "0x204C030", VA = "0x204C030")] add
    {
    }
    [Token(Token = "0x600015B"), Address(RVA = "0x204C0EC", Offset = "0x204C0EC", VA = "0x204C0EC")] remove
    {
    }
  }

  [Token(Token = "0x1400002C")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
  public static event Action<string> onInterstitialAdReadyDemandOnlyEvent
  {
    [Token(Token = "0x600015C"), Address(RVA = "0x204C1A8", Offset = "0x204C1A8", VA = "0x204C1A8")] add
    {
    }
    [Token(Token = "0x600015D"), Address(RVA = "0x204C278", Offset = "0x204C278", VA = "0x204C278")] remove
    {
    }
  }

  [Token(Token = "0x1400002D")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
  public static event Action<string> onInterstitialAdOpenedDemandOnlyEvent
  {
    [Token(Token = "0x600015E"), Address(RVA = "0x204C348", Offset = "0x204C348", VA = "0x204C348")] add
    {
    }
    [Token(Token = "0x600015F"), Address(RVA = "0x204C418", Offset = "0x204C418", VA = "0x204C418")] remove
    {
    }
  }

  [Token(Token = "0x1400002E")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
  public static event Action<string> onInterstitialAdClosedDemandOnlyEvent
  {
    [Token(Token = "0x6000160"), Address(RVA = "0x204C4E8", Offset = "0x204C4E8", VA = "0x204C4E8")] add
    {
    }
    [Token(Token = "0x6000161"), Address(RVA = "0x204C5B8", Offset = "0x204C5B8", VA = "0x204C5B8")] remove
    {
    }
  }

  [Token(Token = "0x1400002F")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
  public static event Action<string, IronSourceError> onInterstitialAdLoadFailedDemandOnlyEvent
  {
    [Token(Token = "0x6000162"), Address(RVA = "0x204C688", Offset = "0x204C688", VA = "0x204C688")] add
    {
    }
    [Token(Token = "0x6000163"), Address(RVA = "0x204C758", Offset = "0x204C758", VA = "0x204C758")] remove
    {
    }
  }

  [Token(Token = "0x14000030")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
  public static event Action<string> onInterstitialAdClickedDemandOnlyEvent
  {
    [Token(Token = "0x6000164"), Address(RVA = "0x204C828", Offset = "0x204C828", VA = "0x204C828")] add
    {
    }
    [Token(Token = "0x6000165"), Address(RVA = "0x204C8F8", Offset = "0x204C8F8", VA = "0x204C8F8")] remove
    {
    }
  }

  [Token(Token = "0x14000031")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
  public static event Action<string, IronSourceError> onInterstitialAdShowFailedDemandOnlyEvent
  {
    [Token(Token = "0x6000166"), Address(RVA = "0x204C9C8", Offset = "0x204C9C8", VA = "0x204C9C8")] add
    {
    }
    [Token(Token = "0x6000167"), Address(RVA = "0x204CA98", Offset = "0x204CA98", VA = "0x204CA98")] remove
    {
    }
  }

  [Token(Token = "0x14000032")]
  [Obsolete("This API call is for the ironSource Offerwall, which will soon be deprecated. Please migrate to the Tapjoy Offerwall using the 'Offerwall migration checklist'.", false)]
  public static event Action<bool> onOfferwallAvailableEvent
  {
    [Token(Token = "0x6000168"), Address(RVA = "0x204CB68", Offset = "0x204CB68", VA = "0x204CB68")] add
    {
    }
    [Token(Token = "0x6000169"), Address(RVA = "0x204CC38", Offset = "0x204CC38", VA = "0x204CC38")] remove
    {
    }
  }

  [Token(Token = "0x14000033")]
  [Obsolete("This API call is for the ironSource Offerwall, which will soon be deprecated. Please migrate to the Tapjoy Offerwall using the 'Offerwall migration checklist'.", false)]
  public static event Action onOfferwallOpenedEvent
  {
    [Token(Token = "0x600016A"), Address(RVA = "0x204CD08", Offset = "0x204CD08", VA = "0x204CD08")] add
    {
    }
    [Token(Token = "0x600016B"), Address(RVA = "0x204CDC4", Offset = "0x204CDC4", VA = "0x204CDC4")] remove
    {
    }
  }

  [Token(Token = "0x14000034")]
  [Obsolete("This API call is for the ironSource Offerwall, which will soon be deprecated. Please migrate to the Tapjoy Offerwall using the 'Offerwall migration checklist'.", false)]
  public static event Action<Dictionary<string, object>> onOfferwallAdCreditedEvent
  {
    [Token(Token = "0x600016C"), Address(RVA = "0x204CE80", Offset = "0x204CE80", VA = "0x204CE80")] add
    {
    }
    [Token(Token = "0x600016D"), Address(RVA = "0x204CF50", Offset = "0x204CF50", VA = "0x204CF50")] remove
    {
    }
  }

  [Token(Token = "0x14000035")]
  [Obsolete("This API call is for the ironSource Offerwall, which will soon be deprecated. Please migrate to the Tapjoy Offerwall using the 'Offerwall migration checklist'.", false)]
  public static event Action<IronSourceError> onGetOfferwallCreditsFailedEvent
  {
    [Token(Token = "0x600016E"), Address(RVA = "0x204D020", Offset = "0x204D020", VA = "0x204D020")] add
    {
    }
    [Token(Token = "0x600016F"), Address(RVA = "0x204D0F0", Offset = "0x204D0F0", VA = "0x204D0F0")] remove
    {
    }
  }

  [Token(Token = "0x14000036")]
  [Obsolete("This API call is for the ironSource Offerwall, which will soon be deprecated. Please migrate to the Tapjoy Offerwall using the 'Offerwall migration checklist'.", false)]
  public static event Action onOfferwallClosedEvent
  {
    [Token(Token = "0x6000170"), Address(RVA = "0x204D1C0", Offset = "0x204D1C0", VA = "0x204D1C0")] add
    {
    }
    [Token(Token = "0x6000171"), Address(RVA = "0x204D27C", Offset = "0x204D27C", VA = "0x204D27C")] remove
    {
    }
  }

  [Token(Token = "0x14000037")]
  [Obsolete("This API call is for the ironSource Offerwall, which will soon be deprecated. Please migrate to the Tapjoy Offerwall using the 'Offerwall migration checklist'.", false)]
  public static event Action<IronSourceError> onOfferwallShowFailedEvent
  {
    [Token(Token = "0x6000172"), Address(RVA = "0x204D338", Offset = "0x204D338", VA = "0x204D338")] add
    {
    }
    [Token(Token = "0x6000173"), Address(RVA = "0x204D408", Offset = "0x204D408", VA = "0x204D408")] remove
    {
    }
  }

  [Token(Token = "0x14000038")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceBannerEvents listener instead.", false)]
  public static event Action onBannerAdLoadedEvent
  {
    [Token(Token = "0x6000174"), Address(RVA = "0x204D4D8", Offset = "0x204D4D8", VA = "0x204D4D8")] add
    {
    }
    [Token(Token = "0x6000175"), Address(RVA = "0x204D594", Offset = "0x204D594", VA = "0x204D594")] remove
    {
    }
  }

  [Token(Token = "0x14000039")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceBannerEvents listener instead.", false)]
  public static event Action onBannerAdLeftApplicationEvent
  {
    [Token(Token = "0x6000176"), Address(RVA = "0x204D650", Offset = "0x204D650", VA = "0x204D650")] add
    {
    }
    [Token(Token = "0x6000177"), Address(RVA = "0x204D70C", Offset = "0x204D70C", VA = "0x204D70C")] remove
    {
    }
  }

  [Token(Token = "0x1400003A")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceBannerEvents listener instead.", false)]
  public static event Action onBannerAdScreenDismissedEvent
  {
    [Token(Token = "0x6000178"), Address(RVA = "0x204D7C8", Offset = "0x204D7C8", VA = "0x204D7C8")] add
    {
    }
    [Token(Token = "0x6000179"), Address(RVA = "0x204D884", Offset = "0x204D884", VA = "0x204D884")] remove
    {
    }
  }

  [Token(Token = "0x1400003B")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceBannerEvents listener instead.", false)]
  public static event Action onBannerAdScreenPresentedEvent
  {
    [Token(Token = "0x600017A"), Address(RVA = "0x204D940", Offset = "0x204D940", VA = "0x204D940")] add
    {
    }
    [Token(Token = "0x600017B"), Address(RVA = "0x204D9FC", Offset = "0x204D9FC", VA = "0x204D9FC")] remove
    {
    }
  }

  [Token(Token = "0x1400003C")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceBannerEvents listener instead.", false)]
  public static event Action onBannerAdClickedEvent
  {
    [Token(Token = "0x600017C"), Address(RVA = "0x204DAB8", Offset = "0x204DAB8", VA = "0x204DAB8")] add
    {
    }
    [Token(Token = "0x600017D"), Address(RVA = "0x204DB74", Offset = "0x204DB74", VA = "0x204DB74")] remove
    {
    }
  }

  [Token(Token = "0x1400003D")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceBannerEvents listener instead.", false)]
  public static event Action<IronSourceError> onBannerAdLoadFailedEvent
  {
    [Token(Token = "0x600017E"), Address(RVA = "0x204DC30", Offset = "0x204DC30", VA = "0x204DC30")] add
    {
    }
    [Token(Token = "0x600017F"), Address(RVA = "0x204DD00", Offset = "0x204DD00", VA = "0x204DD00")] remove
    {
    }
  }

  [Token(Token = "0x1400003E")]
  public static event Action<string> onSegmentReceivedEvent
  {
    [Token(Token = "0x6000180"), Address(RVA = "0x204DDD0", Offset = "0x204DDD0", VA = "0x204DDD0")] add
    {
    }
    [Token(Token = "0x6000181"), Address(RVA = "0x204DEA0", Offset = "0x204DEA0", VA = "0x204DEA0")] remove
    {
    }
  }

  [Token(Token = "0x1400003F")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0. Please use OnImpressionDataReady instead.")]
  public static event Action<IronSourceImpressionData> onImpressionSuccessEvent
  {
    [Token(Token = "0x6000182"), Address(RVA = "0x204DF70", Offset = "0x204DF70", VA = "0x204DF70")] add
    {
    }
    [Token(Token = "0x6000183"), Address(RVA = "0x204E040", Offset = "0x204E040", VA = "0x204E040")] remove
    {
    }
  }

  [Token(Token = "0x14000040")]
  public static event Action<IronSourceImpressionData> onImpressionDataReadyEvent
  {
    [Token(Token = "0x6000184"), Address(RVA = "0x204E110", Offset = "0x204E110", VA = "0x204E110")] add
    {
    }
    [Token(Token = "0x6000185"), Address(RVA = "0x204E1E0", Offset = "0x204E1E0", VA = "0x204E1E0")] remove
    {
    }
  }

  [Token(Token = "0x6000186")]
  [Address(RVA = "0x204E2B0", Offset = "0x204E2B0", VA = "0x204E2B0")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000187")]
  [Address(RVA = "0x204E99C", Offset = "0x204E99C", VA = "0x204E99C")]
  private void registerInitializationEvents()
  {
  }

  [Token(Token = "0x6000188")]
  [Address(RVA = "0x20518EC", Offset = "0x20518EC", VA = "0x20518EC")]
  private void registerBannerEvents()
  {
  }

  [Token(Token = "0x6000189")]
  [Address(RVA = "0x2050678", Offset = "0x2050678", VA = "0x2050678")]
  private void registerInterstitialEvents()
  {
  }

  [Token(Token = "0x600018A")]
  [Address(RVA = "0x2050D28", Offset = "0x2050D28", VA = "0x2050D28")]
  private void registerInterstitialDemandOnlyEvents()
  {
  }

  [Token(Token = "0x600018B")]
  [Address(RVA = "0x20512F4", Offset = "0x20512F4", VA = "0x20512F4")]
  private void registerOfferwallEvents()
  {
  }

  [Token(Token = "0x600018C")]
  [Address(RVA = "0x20525EC", Offset = "0x20525EC", VA = "0x20525EC")]
  private void registerSegmentEvents()
  {
  }

  [Token(Token = "0x600018D")]
  [Address(RVA = "0x20523B8", Offset = "0x20523B8", VA = "0x20523B8")]
  private void registerImpressionDataEvents()
  {
  }

  [Token(Token = "0x600018E")]
  [Address(RVA = "0x204F4E0", Offset = "0x204F4E0", VA = "0x204F4E0")]
  public void registerRewardedVideoDemandOnlyEvents()
  {
  }

  [Token(Token = "0x600018F")]
  [Address(RVA = "0x204EAE8", Offset = "0x204EAE8", VA = "0x204EAE8")]
  private void registerRewardedVideoEvents()
  {
  }

  [Token(Token = "0x6000190")]
  [Address(RVA = "0x204F2A0", Offset = "0x204F2A0", VA = "0x204F2A0")]
  public void registerRewardedVideoManualEvents()
  {
  }

  [Token(Token = "0x14000041")]
  private static event Action<string, IronSourceError> _onConsentViewDidFailToLoadWithErrorEvent
  {
    [Token(Token = "0x6000191"), Address(RVA = "0x2052738", Offset = "0x2052738", VA = "0x2052738")] add
    {
    }
    [Token(Token = "0x6000192"), Address(RVA = "0x2052808", Offset = "0x2052808", VA = "0x2052808")] remove
    {
    }
  }

  [Token(Token = "0x14000042")]
  public static event Action<string, IronSourceError> onConsentViewDidFailToLoadWithErrorEvent
  {
    [Token(Token = "0x6000193"), Address(RVA = "0x20528D8", Offset = "0x20528D8", VA = "0x20528D8")] add
    {
    }
    [Token(Token = "0x6000194"), Address(RVA = "0x2052968", Offset = "0x2052968", VA = "0x2052968")] remove
    {
    }
  }

  [Token(Token = "0x6000195")]
  [Address(RVA = "0x20529F8", Offset = "0x20529F8", VA = "0x20529F8")]
  public void onConsentViewDidFailToLoadWithError(string args)
  {
  }

  [Token(Token = "0x14000043")]
  private static event Action<string, IronSourceError> _onConsentViewDidFailToShowWithErrorEvent
  {
    [Token(Token = "0x6000196"), Address(RVA = "0x2052DC8", Offset = "0x2052DC8", VA = "0x2052DC8")] add
    {
    }
    [Token(Token = "0x6000197"), Address(RVA = "0x2052E98", Offset = "0x2052E98", VA = "0x2052E98")] remove
    {
    }
  }

  [Token(Token = "0x14000044")]
  public static event Action<string, IronSourceError> onConsentViewDidFailToShowWithErrorEvent
  {
    [Token(Token = "0x6000198"), Address(RVA = "0x2052F68", Offset = "0x2052F68", VA = "0x2052F68")] add
    {
    }
    [Token(Token = "0x6000199"), Address(RVA = "0x2052FF8", Offset = "0x2052FF8", VA = "0x2052FF8")] remove
    {
    }
  }

  [Token(Token = "0x600019A")]
  [Address(RVA = "0x2053088", Offset = "0x2053088", VA = "0x2053088")]
  public void onConsentViewDidFailToShowWithError(string args)
  {
  }

  [Token(Token = "0x14000045")]
  private static event Action<string> _onConsentViewDidAcceptEvent
  {
    [Token(Token = "0x600019B"), Address(RVA = "0x20531C0", Offset = "0x20531C0", VA = "0x20531C0")] add
    {
    }
    [Token(Token = "0x600019C"), Address(RVA = "0x2053290", Offset = "0x2053290", VA = "0x2053290")] remove
    {
    }
  }

  [Token(Token = "0x14000046")]
  public static event Action<string> onConsentViewDidAcceptEvent
  {
    [Token(Token = "0x600019D"), Address(RVA = "0x2053360", Offset = "0x2053360", VA = "0x2053360")] add
    {
    }
    [Token(Token = "0x600019E"), Address(RVA = "0x20533F0", Offset = "0x20533F0", VA = "0x20533F0")] remove
    {
    }
  }

  [Token(Token = "0x600019F")]
  [Address(RVA = "0x2053480", Offset = "0x2053480", VA = "0x2053480")]
  public void onConsentViewDidAccept(string consentViewType)
  {
  }

  [Token(Token = "0x14000047")]
  private static event Action<string> _onConsentViewDidDismissEvent
  {
    [Token(Token = "0x60001A0"), Address(RVA = "0x20534EC", Offset = "0x20534EC", VA = "0x20534EC")] add
    {
    }
    [Token(Token = "0x60001A1"), Address(RVA = "0x20535BC", Offset = "0x20535BC", VA = "0x20535BC")] remove
    {
    }
  }

  [Token(Token = "0x14000048")]
  public static event Action<string> onConsentViewDidDismissEvent
  {
    [Token(Token = "0x60001A2"), Address(RVA = "0x205368C", Offset = "0x205368C", VA = "0x205368C")] add
    {
    }
    [Token(Token = "0x60001A3"), Address(RVA = "0x205371C", Offset = "0x205371C", VA = "0x205371C")] remove
    {
    }
  }

  [Token(Token = "0x60001A4")]
  [Address(RVA = "0x20537AC", Offset = "0x20537AC", VA = "0x20537AC")]
  public void onConsentViewDidDismiss(string consentViewType)
  {
  }

  [Token(Token = "0x14000049")]
  private static event Action<string> _onConsentViewDidLoadSuccessEvent
  {
    [Token(Token = "0x60001A5"), Address(RVA = "0x2053818", Offset = "0x2053818", VA = "0x2053818")] add
    {
    }
    [Token(Token = "0x60001A6"), Address(RVA = "0x20538E8", Offset = "0x20538E8", VA = "0x20538E8")] remove
    {
    }
  }

  [Token(Token = "0x1400004A")]
  public static event Action<string> onConsentViewDidLoadSuccessEvent
  {
    [Token(Token = "0x60001A7"), Address(RVA = "0x20539B8", Offset = "0x20539B8", VA = "0x20539B8")] add
    {
    }
    [Token(Token = "0x60001A8"), Address(RVA = "0x2053A48", Offset = "0x2053A48", VA = "0x2053A48")] remove
    {
    }
  }

  [Token(Token = "0x60001A9")]
  [Address(RVA = "0x2053AD8", Offset = "0x2053AD8", VA = "0x2053AD8")]
  public void onConsentViewDidLoadSuccess(string consentViewType)
  {
  }

  [Token(Token = "0x1400004B")]
  private static event Action<string> _onConsentViewDidShowSuccessEvent
  {
    [Token(Token = "0x60001AA"), Address(RVA = "0x2053B44", Offset = "0x2053B44", VA = "0x2053B44")] add
    {
    }
    [Token(Token = "0x60001AB"), Address(RVA = "0x2053C14", Offset = "0x2053C14", VA = "0x2053C14")] remove
    {
    }
  }

  [Token(Token = "0x1400004C")]
  public static event Action<string> onConsentViewDidShowSuccessEvent
  {
    [Token(Token = "0x60001AC"), Address(RVA = "0x2053CE4", Offset = "0x2053CE4", VA = "0x2053CE4")] add
    {
    }
    [Token(Token = "0x60001AD"), Address(RVA = "0x2053D74", Offset = "0x2053D74", VA = "0x2053D74")] remove
    {
    }
  }

  [Token(Token = "0x60001AE")]
  [Address(RVA = "0x2053E04", Offset = "0x2053E04", VA = "0x2053E04")]
  public void onConsentViewDidShowSuccess(string consentViewType)
  {
  }

  [Token(Token = "0x60001AF")]
  [Address(RVA = "0x2052B30", Offset = "0x2052B30", VA = "0x2052B30")]
  private IronSourceError getErrorFromErrorObject(object descriptionObject)
  {
    return (IronSourceError) null;
  }

  [Token(Token = "0x60001B0")]
  [Address(RVA = "0x2053E70", Offset = "0x2053E70", VA = "0x2053E70")]
  private IronSourcePlacement getPlacementFromObject(object placementObject)
  {
    return (IronSourcePlacement) null;
  }

  [Token(Token = "0x60001B1")]
  [Address(RVA = "0x20540C0", Offset = "0x20540C0", VA = "0x20540C0")]
  private static void InvokeEvent(Action<IronSourceImpressionData> evt, string args)
  {
  }

  [Token(Token = "0x60001B2")]
  [Address(RVA = "0x2054834", Offset = "0x2054834", VA = "0x2054834")]
  public IronSourceEvents()
  {
  }
}
