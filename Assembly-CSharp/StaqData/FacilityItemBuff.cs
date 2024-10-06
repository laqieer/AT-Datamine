// Decompiled with JetBrains decompiler
// Type: StaqData.FacilityItemBuff
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020B9")]
  public class FacilityItemBuff
  {
    [Token(Token = "0x17002A6A")]
    public int FacilityID
    {
      [Token(Token = "0x600C62A"), Address(RVA = "0x1CD59B4", Offset = "0x1CD59B4", VA = "0x1CD59B4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002A6B")]
    public int ItemID
    {
      [Token(Token = "0x600C62B"), Address(RVA = "0x1CD59BC", Offset = "0x1CD59BC", VA = "0x1CD59BC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002A6C")]
    public int Amount
    {
      [Token(Token = "0x600C62C"), Address(RVA = "0x1CD59C4", Offset = "0x1CD59C4", VA = "0x1CD59C4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002A6D")]
    public IEnumerable<StoryFacilityItemBuffEffectParamData> Bonus
    {
      [Token(Token = "0x600C62D"), Address(RVA = "0x1CD59CC", Offset = "0x1CD59CC", VA = "0x1CD59CC")] get
      {
        return (IEnumerable<StoryFacilityItemBuffEffectParamData>) null;
      }
    }

    [Token(Token = "0x17002A6E")]
    public int Cost
    {
      [Token(Token = "0x600C62E"), Address(RVA = "0x1CD59D4", Offset = "0x1CD59D4", VA = "0x1CD59D4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600C62F")]
    [Address(RVA = "0x1CD5844", Offset = "0x1CD5844", VA = "0x1CD5844")]
    public FacilityItemBuff(
      int facilityID,
      int itemID,
      int amount,
      IEnumerable<StoryFacilityItemBuffEffectParamData> bonus,
      int cost)
    {
    }
  }
}
