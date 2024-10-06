// Decompiled with JetBrains decompiler
// Type: StaqData.ConditionItemInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData.Quest;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020B0")]
  public class ConditionItemInfo
  {
    [Token(Token = "0x17002A4C")]
    public System.Collections.Generic.List<ItemInfo> List
    {
      [Token(Token = "0x600C5DE"), Address(RVA = "0x1A0835C", Offset = "0x1A0835C", VA = "0x1A0835C")] get
      {
        return (System.Collections.Generic.List<ItemInfo>) null;
      }
    }

    [Token(Token = "0x600C5DF")]
    [Address(RVA = "0x1A08364", Offset = "0x1A08364", VA = "0x1A08364")]
    public ConditionItemInfo(
      IEnumerable<StorySubquestRewardPaymentData> payments)
    {
    }

    [Token(Token = "0x600C5E0")]
    [Address(RVA = "0x1A08774", Offset = "0x1A08774", VA = "0x1A08774")]
    public bool IsCompelte() => new bool();
  }
}
