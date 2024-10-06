// Decompiled with JetBrains decompiler
// Type: LoginBonus.LoginBonusRewardHolder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace LoginBonus
{
  [Token(Token = "0x2000AE1")]
  public class LoginBonusRewardHolder
  {
    [Token(Token = "0x40031F6")]
    [FieldOffset(Offset = "0x18")]
    private List<ILoginBonusRewardUIParam> rewards;

    [Token(Token = "0x170008EE")]
    public int loginBonusId
    {
      [Token(Token = "0x6003DF5"), Address(RVA = "0x2C12674", Offset = "0x2C12674", VA = "0x2C12674")] get
      {
        return new int();
      }
      [Token(Token = "0x6003DF6"), Address(RVA = "0x2C1267C", Offset = "0x2C1267C", VA = "0x2C1267C")] private set
      {
      }
    }

    [Token(Token = "0x170008EF")]
    public int currentRewardNumber
    {
      [Token(Token = "0x6003DF7"), Address(RVA = "0x2C12684", Offset = "0x2C12684", VA = "0x2C12684")] get
      {
        return new int();
      }
      [Token(Token = "0x6003DF8"), Address(RVA = "0x2C1268C", Offset = "0x2C1268C", VA = "0x2C1268C")] private set
      {
      }
    }

    [Token(Token = "0x170008F0")]
    public IReadOnlyList<ILoginBonusRewardUIParam> Rewards
    {
      [Token(Token = "0x6003DF9"), Address(RVA = "0x2C12694", Offset = "0x2C12694", VA = "0x2C12694")] get
      {
        return (IReadOnlyList<ILoginBonusRewardUIParam>) null;
      }
    }

    [Token(Token = "0x6003DFA")]
    [Address(RVA = "0x2C06A74", Offset = "0x2C06A74", VA = "0x2C06A74")]
    public void Initialize(int loginBonusId, int currentRewardNumber)
    {
    }

    [Token(Token = "0x6003DFB")]
    [Address(RVA = "0x2C126A4", Offset = "0x2C126A4", VA = "0x2C126A4")]
    public List<string> GetAssetBundleNames() => (List<string>) null;

    [Token(Token = "0x6003DFC")]
    [Address(RVA = "0x2C12FD0", Offset = "0x2C12FD0", VA = "0x2C12FD0")]
    public LoginBonusRewardHolder ResetCurrentRewardNumber() => (LoginBonusRewardHolder) null;

    [Token(Token = "0x6003DFD")]
    [Address(RVA = "0x2C13040", Offset = "0x2C13040", VA = "0x2C13040")]
    private ItemUtility.Parameter ToItemParameter(LoginBonusRewardData rewardData)
    {
      return new ItemUtility.Parameter();
    }

    [Token(Token = "0x6003DFE")]
    [Address(RVA = "0x2C13128", Offset = "0x2C13128", VA = "0x2C13128")]
    private ItemUtility.Parameter ToItemParameter(LoginBonusRewardDetailData rewardDetailData)
    {
      return new ItemUtility.Parameter();
    }

    [Token(Token = "0x6003DFF")]
    [Address(RVA = "0x2C13170", Offset = "0x2C13170", VA = "0x2C13170")]
    private ILoginBonusRewardUIParam CreateReward(
      IGrouping<LoginBonusRewardData, LoginBonusRewardDetailData> rewards,
      bool received)
    {
      return (ILoginBonusRewardUIParam) null;
    }

    [Token(Token = "0x6003E00")]
    [Address(RVA = "0x2C10AB0", Offset = "0x2C10AB0", VA = "0x2C10AB0")]
    public ILoginBonusRewardUIParam GetTodayReward() => (ILoginBonusRewardUIParam) null;

    [Token(Token = "0x6003E01")]
    [Address(RVA = "0x2C10B54", Offset = "0x2C10B54", VA = "0x2C10B54")]
    public ILoginBonusRewardUIParam GetTommorowReward() => (ILoginBonusRewardUIParam) null;

    [Token(Token = "0x6003E02")]
    [Address(RVA = "0x2C135C4", Offset = "0x2C135C4", VA = "0x2C135C4")]
    public IEnumerable<ILoginBonusRewardUIParam> GetTodayRewards()
    {
      return (IEnumerable<ILoginBonusRewardUIParam>) null;
    }

    [Token(Token = "0x6003E03")]
    [Address(RVA = "0x2C13730", Offset = "0x2C13730", VA = "0x2C13730")]
    public IEnumerable<ILoginBonusRewardUIParam> GetTommorowRewards()
    {
      return (IEnumerable<ILoginBonusRewardUIParam>) null;
    }

    [Token(Token = "0x6003E04")]
    [Address(RVA = "0x2C1389C", Offset = "0x2C1389C", VA = "0x2C1389C")]
    public bool IsTodayReward(ILoginBonusRewardUIParam reward) => new bool();

    [Token(Token = "0x6003E05")]
    [Address(RVA = "0x2C13950", Offset = "0x2C13950", VA = "0x2C13950")]
    public bool IsTommorowReward(ILoginBonusRewardUIParam reward) => new bool();

    [Token(Token = "0x6003E06")]
    [Address(RVA = "0x2C08CE0", Offset = "0x2C08CE0", VA = "0x2C08CE0")]
    public bool IsLastReward() => new bool();

    [Token(Token = "0x6003E07")]
    [Address(RVA = "0x2C06A6C", Offset = "0x2C06A6C", VA = "0x2C06A6C")]
    public LoginBonusRewardHolder()
    {
    }
  }
}
