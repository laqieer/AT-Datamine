// Decompiled with JetBrains decompiler
// Type: GameCore.Font.MaterialInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using TMPro;
using UnityEngine;

#nullable disable
namespace GameCore.Font
{
  [Token(Token = "0x2001460")]
  [Serializable]
  public class MaterialInfo
  {
    [Token(Token = "0x4005DDC")]
    [FieldOffset(Offset = "0x10")]
    public string label;
    [Token(Token = "0x4005DDD")]
    [FieldOffset(Offset = "0x18")]
    public Material material;
    [Token(Token = "0x4005DDE")]
    [FieldOffset(Offset = "0x20")]
    public TMP_FontAsset defaultFont;

    [Token(Token = "0x60072DA")]
    [Address(RVA = "0x4052F64", Offset = "0x4052F64", VA = "0x4052F64")]
    public MaterialInfo()
    {
    }
  }
}
