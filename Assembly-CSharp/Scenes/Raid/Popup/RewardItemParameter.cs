// Decompiled with JetBrains decompiler
// Type: Scenes.Raid.Popup.RewardItemParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.Raid.Popup
{
  [Token(Token = "0x20029F2")]
  internal struct RewardItemParameter
  {
    [Token(Token = "0x400B2C7")]
    [FieldOffset(Offset = "0x0")]
    public readonly RewardTypeEnum RewardType;
    [Token(Token = "0x400B2C8")]
    [FieldOffset(Offset = "0x4")]
    public readonly int RewardId;
    [Token(Token = "0x400B2C9")]
    [FieldOffset(Offset = "0x8")]
    public readonly int Amount;

    [Token(Token = "0x6010751")]
    [Address(RVA = "0x4891304", Offset = "0x4891304", VA = "0x4891304")]
    public RewardItemParameter(RewardTypeEnum rewardType, int rewardId, int amount)
    {
    }
  }
}
