// Decompiled with JetBrains decompiler
// Type: UI.MultipleItemDetail.MultipleItemDetailParamater
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace UI.MultipleItemDetail
{
  [Token(Token = "0x20008BA")]
  public struct MultipleItemDetailParamater
  {
    [Token(Token = "0x40028EE")]
    [FieldOffset(Offset = "0x0")]
    public RewardTypeEnum rewardType;
    [Token(Token = "0x40028EF")]
    [FieldOffset(Offset = "0x4")]
    public int rewardId;
    [Token(Token = "0x40028F0")]
    [FieldOffset(Offset = "0x8")]
    public ItemUtility.Parameter itemParameter;
    [Token(Token = "0x40028F1")]
    [FieldOffset(Offset = "0x68")]
    public int possessionItemQuantity;
    [Token(Token = "0x40028F2")]
    [FieldOffset(Offset = "0x6C")]
    public int sellingPrice;
  }
}
