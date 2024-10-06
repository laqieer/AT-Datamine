// Decompiled with JetBrains decompiler
// Type: IllustLayoutInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002DE")]
public class IllustLayoutInfo : ScriptableObject
{
  [Token(Token = "0x40010AA")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  public IllustLayoutInfo.Layout[] layouts;

  [Token(Token = "0x60011FA")]
  [Address(RVA = "0x27DA40C", Offset = "0x27DA40C", VA = "0x27DA40C")]
  public IllustLayoutInfo.Layout Find(string tag) => (IllustLayoutInfo.Layout) null;

  [Token(Token = "0x60011FB")]
  [Address(RVA = "0x27DAF9C", Offset = "0x27DAF9C", VA = "0x27DAF9C")]
  public IllustLayoutInfo()
  {
  }

  [Token(Token = "0x20002DF")]
  [Serializable]
  public class Layout
  {
    [Token(Token = "0x40010AB")]
    [FieldOffset(Offset = "0x10")]
    public string tag;
    [Token(Token = "0x40010AC")]
    [FieldOffset(Offset = "0x18")]
    public Rect rect;

    [Token(Token = "0x60011FC")]
    [Address(RVA = "0x27DAFA4", Offset = "0x27DAFA4", VA = "0x27DAFA4")]
    public Layout()
    {
    }
  }
}
