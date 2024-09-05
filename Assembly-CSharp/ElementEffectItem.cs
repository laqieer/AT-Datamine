// Decompiled with JetBrains decompiler
// Type: ElementEffectItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000127")]
[Serializable]
public class ElementEffectItem
{
  [Token(Token = "0x400062D")]
  [FieldOffset(Offset = "0x10")]
  public ElementEffectItem.ElementType elementType;
  [Token(Token = "0x400062E")]
  [FieldOffset(Offset = "0x18")]
  public GameObject elementEffectPrefab;

  [Token(Token = "0x6000815")]
  [Address(RVA = "0x485D9E8", Offset = "0x485D9E8", VA = "0x485D9E8")]
  public ElementEffectItem()
  {
  }

  [Token(Token = "0x2000128")]
  public enum ElementType
  {
    [Token(Token = "0x4000630")] None,
    [Token(Token = "0x4000631")] Fire,
    [Token(Token = "0x4000632")] Wind,
    [Token(Token = "0x4000633")] Ice,
    [Token(Token = "0x4000634")] Thunder,
    [Token(Token = "0x4000635")] Holy,
    [Token(Token = "0x4000636")] Ruin,
  }
}
