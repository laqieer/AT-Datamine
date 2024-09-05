// Decompiled with JetBrains decompiler
// Type: BaseBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000A1")]
public abstract class BaseBehaviour : MonoBehaviour
{
  [Token(Token = "0x400028E")]
  [FieldOffset(Offset = "0x18")]
  private Transform cashedTransform;

  [Token(Token = "0x17000045")]
  public Transform CachedTransform
  {
    [Token(Token = "0x600054C"), Address(RVA = "0x44B1270", Offset = "0x44B1270", VA = "0x44B1270")] get
    {
      return (Transform) null;
    }
  }

  [Token(Token = "0x600054D")]
  [Address(RVA = "0x44B1298", Offset = "0x44B1298", VA = "0x44B1298", Slot = "4")]
  protected virtual void Awake()
  {
  }

  [Token(Token = "0x600054E")]
  [Address(RVA = "0x44B129C", Offset = "0x44B129C", VA = "0x44B129C", Slot = "5")]
  protected virtual void Start()
  {
  }

  [Token(Token = "0x600054F")]
  [Address(RVA = "0x44B12A0", Offset = "0x44B12A0", VA = "0x44B12A0", Slot = "6")]
  protected virtual void OnDestroy()
  {
  }

  [Token(Token = "0x6000550")]
  [Address(RVA = "0x44B12A4", Offset = "0x44B12A4", VA = "0x44B12A4")]
  protected BaseBehaviour()
  {
  }
}
