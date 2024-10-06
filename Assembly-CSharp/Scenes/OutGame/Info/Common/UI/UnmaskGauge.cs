// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Common.UI.UnmaskGauge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Info.Common.UI
{
  [Token(Token = "0x20035F2")]
  [Serializable]
  public class UnmaskGauge
  {
    [Token(Token = "0x400EA9E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Image unmask;
    [Token(Token = "0x400EA9F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private float width;

    [Token(Token = "0x170046B5")]
    public float Value
    {
      [Token(Token = "0x60153BC"), Address(RVA = "0x4D8CA18", Offset = "0x4D8CA18", VA = "0x4D8CA18")] set
      {
      }
    }

    [Token(Token = "0x60153BD")]
    [Address(RVA = "0x4D8D8B8", Offset = "0x4D8D8B8", VA = "0x4D8D8B8")]
    public UnmaskGauge()
    {
    }
  }
}
