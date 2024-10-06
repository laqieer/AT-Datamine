// Decompiled with JetBrains decompiler
// Type: StaqData.GachaDetailInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Gacha;
using Gacha.API;
using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002125")]
  public class GachaDetailInfo
  {
    [Token(Token = "0x4008CB3")]
    [FieldOffset(Offset = "0x78")]
    private IGachaModuleInfo gachaModuleInfo;
    [Token(Token = "0x4008CB4")]
    [FieldOffset(Offset = "0x80")]
    private ScheduleInfo scheduleInfo;
    [Token(Token = "0x4008CB5")]
    [FieldOffset(Offset = "0x88")]
    private GachaListItemInfo gachaListItemInfo;

    [Token(Token = "0x17002C1A")]
    public string GachaName
    {
      [Token(Token = "0x600CA9F"), Address(RVA = "0x1BA6618", Offset = "0x1BA6618", VA = "0x1BA6618")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002C1B")]
    public int Id
    {
      [Token(Token = "0x600CAA0"), Address(RVA = "0x1BA6FF4", Offset = "0x1BA6FF4", VA = "0x1BA6FF4")] get
      {
        return new int();
      }
      [Token(Token = "0x600CAA1"), Address(RVA = "0x1BA6FFC", Offset = "0x1BA6FFC", VA = "0x1BA6FFC")] private set
      {
      }
    }

    [Token(Token = "0x17002C1C")]
    public string Name
    {
      [Token(Token = "0x600CAA2"), Address(RVA = "0x1BA7004", Offset = "0x1BA7004", VA = "0x1BA7004")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600CAA3"), Address(RVA = "0x1BA700C", Offset = "0x1BA700C", VA = "0x1BA700C")] private set
      {
      }
    }

    [Token(Token = "0x17002C1D")]
    public string GroupName
    {
      [Token(Token = "0x600CAA4"), Address(RVA = "0x1BA7014", Offset = "0x1BA7014", VA = "0x1BA7014")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002C1E")]
    public int GroupId
    {
      [Token(Token = "0x600CAA5"), Address(RVA = "0x1BA702C", Offset = "0x1BA702C", VA = "0x1BA702C")] get
      {
        return new int();
      }
      [Token(Token = "0x600CAA6"), Address(RVA = "0x1BA7034", Offset = "0x1BA7034", VA = "0x1BA7034")] private set
      {
      }
    }

    [Token(Token = "0x17002C1F")]
    public int RollCount
    {
      [Token(Token = "0x600CAA7"), Address(RVA = "0x1BA703C", Offset = "0x1BA703C", VA = "0x1BA703C")] get
      {
        return new int();
      }
      [Token(Token = "0x600CAA8"), Address(RVA = "0x1BA7044", Offset = "0x1BA7044", VA = "0x1BA7044")] private set
      {
      }
    }

    [Token(Token = "0x17002C20")]
    public DateTime StartAt
    {
      [Token(Token = "0x600CAA9"), Address(RVA = "0x1BA656C", Offset = "0x1BA656C", VA = "0x1BA656C")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17002C21")]
    public DateTime EndAt
    {
      [Token(Token = "0x600CAAA"), Address(RVA = "0x1BA65A8", Offset = "0x1BA65A8", VA = "0x1BA65A8")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17002C22")]
    public int Limit
    {
      [Token(Token = "0x600CAAB"), Address(RVA = "0x1BA704C", Offset = "0x1BA704C", VA = "0x1BA704C")] get
      {
        return new int();
      }
      [Token(Token = "0x600CAAC"), Address(RVA = "0x1BA7054", Offset = "0x1BA7054", VA = "0x1BA7054")] private set
      {
      }
    }

    [Token(Token = "0x17002C23")]
    public int DailyLimit
    {
      [Token(Token = "0x600CAAD"), Address(RVA = "0x1BA705C", Offset = "0x1BA705C", VA = "0x1BA705C")] get
      {
        return new int();
      }
      [Token(Token = "0x600CAAE"), Address(RVA = "0x1BA7064", Offset = "0x1BA7064", VA = "0x1BA7064")] private set
      {
      }
    }

    [Token(Token = "0x17002C24")]
    public int Count
    {
      [Token(Token = "0x600CAAF"), Address(RVA = "0x1BA706C", Offset = "0x1BA706C", VA = "0x1BA706C")] get
      {
        return new int();
      }
      [Token(Token = "0x600CAB0"), Address(RVA = "0x1BA7074", Offset = "0x1BA7074", VA = "0x1BA7074")] private set
      {
      }
    }

    [Token(Token = "0x17002C25")]
    public int DailyCount
    {
      [Token(Token = "0x600CAB1"), Address(RVA = "0x1BA707C", Offset = "0x1BA707C", VA = "0x1BA707C")] get
      {
        return new int();
      }
      [Token(Token = "0x600CAB2"), Address(RVA = "0x1BA7084", Offset = "0x1BA7084", VA = "0x1BA7084")] private set
      {
      }
    }

    [Token(Token = "0x17002C26")]
    public int RemainAdvertisementCount
    {
      [Token(Token = "0x600CAB3"), Address(RVA = "0x1BA708C", Offset = "0x1BA708C", VA = "0x1BA708C")] get
      {
        return new int();
      }
      [Token(Token = "0x600CAB4"), Address(RVA = "0x1BA7094", Offset = "0x1BA7094", VA = "0x1BA7094")] private set
      {
      }
    }

    [Token(Token = "0x17002C27")]
    public PaymentTypeEnum PaymentType
    {
      [Token(Token = "0x600CAB5"), Address(RVA = "0x1BA709C", Offset = "0x1BA709C", VA = "0x1BA709C")] get
      {
        return new PaymentTypeEnum();
      }
      [Token(Token = "0x600CAB6"), Address(RVA = "0x1BA70A4", Offset = "0x1BA70A4", VA = "0x1BA70A4")] private set
      {
      }
    }

    [Token(Token = "0x17002C28")]
    public int PaymentId
    {
      [Token(Token = "0x600CAB7"), Address(RVA = "0x1BA70AC", Offset = "0x1BA70AC", VA = "0x1BA70AC")] get
      {
        return new int();
      }
      [Token(Token = "0x600CAB8"), Address(RVA = "0x1BA70B4", Offset = "0x1BA70B4", VA = "0x1BA70B4")] private set
      {
      }
    }

    [Token(Token = "0x17002C29")]
    public int PaymentAmount
    {
      [Token(Token = "0x600CAB9"), Address(RVA = "0x1BA70BC", Offset = "0x1BA70BC", VA = "0x1BA70BC")] get
      {
        return new int();
      }
      [Token(Token = "0x600CABA"), Address(RVA = "0x1BA70C4", Offset = "0x1BA70C4", VA = "0x1BA70C4")] private set
      {
      }
    }

    [Token(Token = "0x17002C2A")]
    public bool IsBadgeEnable
    {
      [Token(Token = "0x600CABB"), Address(RVA = "0x1BA70CC", Offset = "0x1BA70CC", VA = "0x1BA70CC")] get
      {
        return new bool();
      }
      [Token(Token = "0x600CABC"), Address(RVA = "0x1BA70D4", Offset = "0x1BA70D4", VA = "0x1BA70D4")] private set
      {
      }
    }

    [Token(Token = "0x17002C2B")]
    public int StepupId
    {
      [Token(Token = "0x600CABD"), Address(RVA = "0x1BA70E0", Offset = "0x1BA70E0", VA = "0x1BA70E0")] get
      {
        return new int();
      }
      [Token(Token = "0x600CABE"), Address(RVA = "0x1BA70E8", Offset = "0x1BA70E8", VA = "0x1BA70E8")] private set
      {
      }
    }

    [Token(Token = "0x17002C2C")]
    public int MaxExecuteCount
    {
      [Token(Token = "0x600CABF"), Address(RVA = "0x1BA70F0", Offset = "0x1BA70F0", VA = "0x1BA70F0")] get
      {
        return new int();
      }
      [Token(Token = "0x600CAC0"), Address(RVA = "0x1BA70F8", Offset = "0x1BA70F8", VA = "0x1BA70F8")] private set
      {
      }
    }

    [Token(Token = "0x17002C2D")]
    public List<GachaBonusRewardInfo> Bonuses
    {
      [Token(Token = "0x600CAC1"), Address(RVA = "0x1BA7100", Offset = "0x1BA7100", VA = "0x1BA7100")] get
      {
        return (List<GachaBonusRewardInfo>) null;
      }
      [Token(Token = "0x600CAC2"), Address(RVA = "0x1BA7108", Offset = "0x1BA7108", VA = "0x1BA7108")] private set
      {
      }
    }

    [Token(Token = "0x17002C2E")]
    public GachaGroupInfo GroupInfo
    {
      [Token(Token = "0x600CAC3"), Address(RVA = "0x1BA7110", Offset = "0x1BA7110", VA = "0x1BA7110")] get
      {
        return (GachaGroupInfo) null;
      }
      [Token(Token = "0x600CAC4"), Address(RVA = "0x1BA7118", Offset = "0x1BA7118", VA = "0x1BA7118")] private set
      {
      }
    }

    [Token(Token = "0x17002C2F")]
    public List<GachaPickupInfo> Pickups
    {
      [Token(Token = "0x600CAC5"), Address(RVA = "0x1BA7120", Offset = "0x1BA7120", VA = "0x1BA7120")] get
      {
        return (List<GachaPickupInfo>) null;
      }
      [Token(Token = "0x600CAC6"), Address(RVA = "0x1BA7128", Offset = "0x1BA7128", VA = "0x1BA7128")] private set
      {
      }
    }

    [Token(Token = "0x17002C30")]
    public GachaStepUpInfo StepupInfo
    {
      [Token(Token = "0x600CAC7"), Address(RVA = "0x1BA7130", Offset = "0x1BA7130", VA = "0x1BA7130")] get
      {
        return (GachaStepUpInfo) null;
      }
      [Token(Token = "0x600CAC8"), Address(RVA = "0x1BA7138", Offset = "0x1BA7138", VA = "0x1BA7138")] private set
      {
      }
    }

    [Token(Token = "0x17002C31")]
    public bool HasLimit
    {
      [Token(Token = "0x600CAC9"), Address(RVA = "0x1BA7140", Offset = "0x1BA7140", VA = "0x1BA7140")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002C32")]
    public bool HasDailyLimit
    {
      [Token(Token = "0x600CACA"), Address(RVA = "0x1BA7150", Offset = "0x1BA7150", VA = "0x1BA7150")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002C33")]
    public bool IsLimit
    {
      [Token(Token = "0x600CACB"), Address(RVA = "0x1BA648C", Offset = "0x1BA648C", VA = "0x1BA648C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002C34")]
    public bool IsDailyLimit
    {
      [Token(Token = "0x600CACC"), Address(RVA = "0x1BA64AC", Offset = "0x1BA64AC", VA = "0x1BA64AC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002C35")]
    public int RemainingCount
    {
      [Token(Token = "0x600CACD"), Address(RVA = "0x1BA7160", Offset = "0x1BA7160", VA = "0x1BA7160")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002C36")]
    public int RemainingDailyCount
    {
      [Token(Token = "0x600CACE"), Address(RVA = "0x1BA7228", Offset = "0x1BA7228", VA = "0x1BA7228")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002C37")]
    public bool IsAdvertisementLimit
    {
      [Token(Token = "0x600CACF"), Address(RVA = "0x1BA72F0", Offset = "0x1BA72F0", VA = "0x1BA72F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002C38")]
    public bool HasBonus
    {
      [Token(Token = "0x600CAD0"), Address(RVA = "0x1BA7314", Offset = "0x1BA7314", VA = "0x1BA7314")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002C39")]
    public bool HasPickup
    {
      [Token(Token = "0x600CAD1"), Address(RVA = "0x1BA7364", Offset = "0x1BA7364", VA = "0x1BA7364")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002C3A")]
    public bool IsStepGacha
    {
      [Token(Token = "0x600CAD2"), Address(RVA = "0x1BA7374", Offset = "0x1BA7374", VA = "0x1BA7374")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002C3B")]
    public bool IsAdsGacha
    {
      [Token(Token = "0x600CAD3"), Address(RVA = "0x1BA64CC", Offset = "0x1BA64CC", VA = "0x1BA64CC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002C3C")]
    public string ApiSchemaVersion
    {
      [Token(Token = "0x600CAD4"), Address(RVA = "0x1BA7384", Offset = "0x1BA7384", VA = "0x1BA7384")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002C3D")]
    public GachaTypeEnum GachaType
    {
      [Token(Token = "0x600CAD5"), Address(RVA = "0x1BA7428", Offset = "0x1BA7428", VA = "0x1BA7428")] get
      {
        return new GachaTypeEnum();
      }
    }

    [Token(Token = "0x17002C3E")]
    public int GachaId
    {
      [Token(Token = "0x600CAD6"), Address(RVA = "0x1BA74CC", Offset = "0x1BA74CC", VA = "0x1BA74CC")] get
      {
        return new int();
      }
      [Token(Token = "0x600CAD7"), Address(RVA = "0x1BA74D4", Offset = "0x1BA74D4", VA = "0x1BA74D4")] private set
      {
      }
    }

    [Token(Token = "0x17002C3F")]
    public string Title
    {
      [Token(Token = "0x600CAD8"), Address(RVA = "0x1BA74DC", Offset = "0x1BA74DC", VA = "0x1BA74DC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002C40")]
    public int SelectGachaTargetID
    {
      [Token(Token = "0x600CAD9"), Address(RVA = "0x1BA74F4", Offset = "0x1BA74F4", VA = "0x1BA74F4")] get
      {
        return new int();
      }
      [Token(Token = "0x600CADA"), Address(RVA = "0x1BA74FC", Offset = "0x1BA74FC", VA = "0x1BA74FC")] private set
      {
      }
    }

    [Token(Token = "0x17002C41")]
    public SelectGachaTargetInfo SelectGachaTargetInfo
    {
      [Token(Token = "0x600CADB"), Address(RVA = "0x1BA7504", Offset = "0x1BA7504", VA = "0x1BA7504")] get
      {
        return (SelectGachaTargetInfo) null;
      }
      [Token(Token = "0x600CADC"), Address(RVA = "0x1BA750C", Offset = "0x1BA750C", VA = "0x1BA750C")] private set
      {
      }
    }

    [Token(Token = "0x17002C42")]
    public bool IsSelectGacha
    {
      [Token(Token = "0x600CADD"), Address(RVA = "0x1BA7514", Offset = "0x1BA7514", VA = "0x1BA7514")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600CADE")]
    [Address(RVA = "0x1BA7524", Offset = "0x1BA7524", VA = "0x1BA7524")]
    public static GachaDetailInfo CreateFromServerData(
      IGachaModuleInfo gachaModuleInfo,
      G0000GachaType serverData)
    {
      return (GachaDetailInfo) null;
    }

    [Token(Token = "0x600CADF")]
    [Address(RVA = "0x1BA50F0", Offset = "0x1BA50F0", VA = "0x1BA50F0")]
    public static List<GachaDetailInfo> CreateFromServerData(
      IGachaModuleInfo moduleInfo,
      IEnumerable<G0000GachaType> serverData)
    {
      return (List<GachaDetailInfo>) null;
    }

    [Token(Token = "0x600CAE0")]
    [Address(RVA = "0x1BA77EC", Offset = "0x1BA77EC", VA = "0x1BA77EC")]
    public static GachaDetailInfo CreateFromServerData(
      IGachaModuleInfo gachaModuleInfo,
      G0001GachaType serverData)
    {
      return (GachaDetailInfo) null;
    }

    [Token(Token = "0x600CAE1")]
    [Address(RVA = "0x1BA54E8", Offset = "0x1BA54E8", VA = "0x1BA54E8")]
    public static List<GachaDetailInfo> CreateFromServerData(
      IGachaModuleInfo moduleInfo,
      IEnumerable<G0001GachaType> serverData)
    {
      return (List<GachaDetailInfo>) null;
    }

    [Token(Token = "0x600CAE2")]
    [Address(RVA = "0x1BA7A20", Offset = "0x1BA7A20", VA = "0x1BA7A20")]
    public GachaPaymentModel GetGachaPaymentModel() => (GachaPaymentModel) null;

    [Token(Token = "0x600CAE3")]
    [Address(RVA = "0x1BA7AEC", Offset = "0x1BA7AEC", VA = "0x1BA7AEC")]
    public GachaPaymentModel GetGachaPaymentModel(int executeCount) => (GachaPaymentModel) null;

    [Token(Token = "0x600CAE4")]
    [Address(RVA = "0x1BA66D8", Offset = "0x1BA66D8", VA = "0x1BA66D8")]
    public void OnInitialize(IGachaInfoMaster gachaInfoMaster, GachaDetailGroupInfo detailGroupInfo)
    {
    }

    [Token(Token = "0x600CAE5")]
    [Address(RVA = "0x1BA7740", Offset = "0x1BA7740", VA = "0x1BA7740")]
    public GachaDetailInfo()
    {
    }
  }
}
