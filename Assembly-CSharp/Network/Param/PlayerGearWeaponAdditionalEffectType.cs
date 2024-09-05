// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerGearWeaponAdditionalEffectType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001ABF")]
  [Serializable]
  public class PlayerGearWeaponAdditionalEffectType
  {
    [Token(Token = "0x40072A1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private float effect_value;
    [Token(Token = "0x40072A2")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int effect_id;

    [Token(Token = "0x17001AF7")]
    public float EffectValue
    {
      [Token(Token = "0x6009B24"), Address(RVA = "0x48F1930", Offset = "0x48F1930", VA = "0x48F1930")] get
      {
        return new float();
      }
      [Token(Token = "0x6009B25"), Address(RVA = "0x48F1938", Offset = "0x48F1938", VA = "0x48F1938")] set
      {
      }
    }

    [Token(Token = "0x17001AF8")]
    public int EffectId
    {
      [Token(Token = "0x6009B26"), Address(RVA = "0x48F1940", Offset = "0x48F1940", VA = "0x48F1940")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B27"), Address(RVA = "0x48F1948", Offset = "0x48F1948", VA = "0x48F1948")] set
      {
      }
    }

    [Token(Token = "0x6009B28")]
    [Address(RVA = "0x48F1950", Offset = "0x48F1950", VA = "0x48F1950")]
    public PlayerGearWeaponAdditionalEffectType()
    {
    }
  }
}
