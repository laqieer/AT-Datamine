// Decompiled with JetBrains decompiler
// Type: StaqData.WeaponAdditionalEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200202F")]
  public class WeaponAdditionalEffect
  {
    [Token(Token = "0x1700283F")]
    public int EffectId
    {
      [Token(Token = "0x600C0BB"), Address(RVA = "0x20107C0", Offset = "0x20107C0", VA = "0x20107C0")] get
      {
        return new int();
      }
      [Token(Token = "0x600C0BC"), Address(RVA = "0x20107C8", Offset = "0x20107C8", VA = "0x20107C8")] private set
      {
      }
    }

    [Token(Token = "0x17002840")]
    public float EffectValue
    {
      [Token(Token = "0x600C0BD"), Address(RVA = "0x20107D0", Offset = "0x20107D0", VA = "0x20107D0")] get
      {
        return new float();
      }
      [Token(Token = "0x600C0BE"), Address(RVA = "0x20107D8", Offset = "0x20107D8", VA = "0x20107D8")] private set
      {
      }
    }

    [Token(Token = "0x600C0BF")]
    [Address(RVA = "0x200D548", Offset = "0x200D548", VA = "0x200D548")]
    public WeaponAdditionalEffect(PlayerGearWeaponAdditionalEffectType entity)
    {
    }
  }
}
