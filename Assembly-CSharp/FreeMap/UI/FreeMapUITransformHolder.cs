// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.FreeMapUITransformHolder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.Instance.Element;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FreeMap.UI
{
  [Token(Token = "0x2001602")]
  public class FreeMapUITransformHolder
  {
    [Token(Token = "0x1700133A")]
    public FreeMapInstance HolderOwner
    {
      [Token(Token = "0x6007C99"), Address(RVA = "0x21A2F7C", Offset = "0x21A2F7C", VA = "0x21A2F7C")] get
      {
        return (FreeMapInstance) null;
      }
      [Token(Token = "0x6007C9A"), Address(RVA = "0x21A2F84", Offset = "0x21A2F84", VA = "0x21A2F84")] private set
      {
      }
    }

    [Token(Token = "0x1700133B")]
    public Transform UIAnchor
    {
      [Token(Token = "0x6007C9B"), Address(RVA = "0x21A2F8C", Offset = "0x21A2F8C", VA = "0x21A2F8C")] get
      {
        return (Transform) null;
      }
      [Token(Token = "0x6007C9C"), Address(RVA = "0x21A2F94", Offset = "0x21A2F94", VA = "0x21A2F94")] private set
      {
      }
    }

    [Token(Token = "0x1700133C")]
    public List<FreeMapMovePosition> PlayerMovePositionList
    {
      [Token(Token = "0x6007C9D"), Address(RVA = "0x21A2F9C", Offset = "0x21A2F9C", VA = "0x21A2F9C")] get
      {
        return (List<FreeMapMovePosition>) null;
      }
      [Token(Token = "0x6007C9E"), Address(RVA = "0x21A2FA4", Offset = "0x21A2FA4", VA = "0x21A2FA4")] private set
      {
      }
    }

    [Token(Token = "0x1700133D")]
    public FreeMapUITransformHolderLookAt LookAt
    {
      [Token(Token = "0x6007C9F"), Address(RVA = "0x21A2FAC", Offset = "0x21A2FAC", VA = "0x21A2FAC")] get
      {
        return (FreeMapUITransformHolderLookAt) null;
      }
    }

    [Token(Token = "0x1700133E")]
    public int MovePositionCount
    {
      [Token(Token = "0x6007CA0"), Address(RVA = "0x21A2FB4", Offset = "0x21A2FB4", VA = "0x21A2FB4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700133F")]
    public Vector2 PositionXZAxis
    {
      [Token(Token = "0x6007CA1"), Address(RVA = "0x21A3000", Offset = "0x21A3000", VA = "0x21A3000")] get
      {
        return new Vector2();
      }
    }

    [Token(Token = "0x17001340")]
    public int AffiliationClipRangeIndex
    {
      [Token(Token = "0x6007CA2"), Address(RVA = "0x21A3140", Offset = "0x21A3140", VA = "0x21A3140")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6007CA3")]
    [Address(RVA = "0x21A31C0", Offset = "0x21A31C0", VA = "0x21A31C0")]
    public void Initialize(FreeMapInstance holderOwner, Transform iconAnchor)
    {
    }

    [Token(Token = "0x6007CA4")]
    [Address(RVA = "0x21A3310", Offset = "0x21A3310", VA = "0x21A3310")]
    public void AddPlayerMovePosition(FreeMapMovePosition playerMovePosition)
    {
    }

    [Token(Token = "0x6007CA5")]
    [Address(RVA = "0x21A33B8", Offset = "0x21A33B8", VA = "0x21A33B8")]
    public void InsertAnchor(Transform newAnchor)
    {
    }

    [Token(Token = "0x6007CA6")]
    [Address(RVA = "0x21A3438", Offset = "0x21A3438", VA = "0x21A3438")]
    public void InsertPlayerPosition(FreeMapMovePosition newPlayerMovePosition)
    {
    }

    [Token(Token = "0x6007CA7")]
    [Address(RVA = "0x21A3674", Offset = "0x21A3674", VA = "0x21A3674")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6007CA8")]
    [Address(RVA = "0x21A3828", Offset = "0x21A3828", VA = "0x21A3828")]
    public FreeMapUITransformHolder()
    {
    }
  }
}
