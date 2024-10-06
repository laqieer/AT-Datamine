// Decompiled with JetBrains decompiler
// Type: Network.Param.FggfcRewardEntityType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A53")]
  [Serializable]
  public class FggfcRewardEntityType
  {
    [Token(Token = "0x400709B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string reward_display_name;
    [Token(Token = "0x400709C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private long reward_quantity;

    [Token(Token = "0x170018D1")]
    public string RewardDisplayName
    {
      [Token(Token = "0x600968B"), Address(RVA = "0x48EF298", Offset = "0x48EF298", VA = "0x48EF298")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600968C"), Address(RVA = "0x48EF2A0", Offset = "0x48EF2A0", VA = "0x48EF2A0")] set
      {
      }
    }

    [Token(Token = "0x170018D2")]
    public long RewardQuantity
    {
      [Token(Token = "0x600968D"), Address(RVA = "0x48EF2A8", Offset = "0x48EF2A8", VA = "0x48EF2A8")] get
      {
        return new long();
      }
      [Token(Token = "0x600968E"), Address(RVA = "0x48EF2B0", Offset = "0x48EF2B0", VA = "0x48EF2B0")] set
      {
      }
    }

    [Token(Token = "0x600968F")]
    [Address(RVA = "0x48EF2B8", Offset = "0x48EF2B8", VA = "0x48EF2B8")]
    public FggfcRewardEntityType()
    {
    }
  }
}
