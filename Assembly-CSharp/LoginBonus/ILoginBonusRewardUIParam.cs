// Decompiled with JetBrains decompiler
// Type: LoginBonus.ILoginBonusRewardUIParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace LoginBonus
{
  [Token(Token = "0x2000AE7")]
  public interface ILoginBonusRewardUIParam
  {
    [Token(Token = "0x170008F1")]
    RewardTypeEnum rewardType { [Token(Token = "0x6003E1E")] get; }

    [Token(Token = "0x170008F2")]
    int id { [Token(Token = "0x6003E1F")] get; }

    [Token(Token = "0x170008F3")]
    string name { [Token(Token = "0x6003E20")] get; }

    [Token(Token = "0x170008F4")]
    int quantity { [Token(Token = "0x6003E21")] get; }

    [Token(Token = "0x170008F5")]
    int rewardNumber { [Token(Token = "0x6003E22")] get; }

    [Token(Token = "0x170008F6")]
    bool received { [Token(Token = "0x6003E23")] get; }

    [Token(Token = "0x170008F7")]
    bool IsPacked { [Token(Token = "0x6003E24")] get; }

    [Token(Token = "0x170008F8")]
    ItemUtility.Parameter itemParameter { [Token(Token = "0x6003E25")] get; }
  }
}
