// Decompiled with JetBrains decompiler
// Type: ADV2.Adv2Trust
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003E38")]
  public class Adv2Trust : Adv2UI
  {
    [Token(Token = "0x4011144")]
    [FieldOffset(Offset = "0x68")]
    private Transform parent;

    [Token(Token = "0x17005177")]
    public Adv2Trust.TrustTypeEnum TrustType
    {
      [Token(Token = "0x601910B"), Address(RVA = "0x296E000", Offset = "0x296E000", VA = "0x296E000")] get
      {
        return new Adv2Trust.TrustTypeEnum();
      }
      [Token(Token = "0x601910C"), Address(RVA = "0x296E008", Offset = "0x296E008", VA = "0x296E008")] private set
      {
      }
    }

    [Token(Token = "0x601910D")]
    [Address(RVA = "0x296E010", Offset = "0x296E010", VA = "0x296E010")]
    public static Adv2Trust Create(
      GameObject addComponent,
      Transform parent,
      Adv2Trust.TrustTypeEnum type)
    {
      return (Adv2Trust) null;
    }

    [Token(Token = "0x601910E")]
    [Address(RVA = "0x296E0A4", Offset = "0x296E0A4", VA = "0x296E0A4")]
    private void Init(GameObject prefab)
    {
    }

    [Token(Token = "0x601910F")]
    [Address(RVA = "0x296E298", Offset = "0x296E298", VA = "0x296E298")]
    public void SetBindObject(GameObject prefab)
    {
    }

    [Token(Token = "0x6019110")]
    [Address(RVA = "0x296E29C", Offset = "0x296E29C", VA = "0x296E29C")]
    public Adv2Trust()
    {
    }

    [Token(Token = "0x2003E39")]
    public enum TrustTypeEnum
    {
      [Token(Token = "0x4011147")] Release,
      [Token(Token = "0x4011148")] RankUp,
    }
  }
}
