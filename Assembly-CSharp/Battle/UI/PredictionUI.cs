// Decompiled with JetBrains decompiler
// Type: Battle.UI.PredictionUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UI.Utilities.SerializeUI;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023FC")]
  [Serializable]
  public class PredictionUI
  {
    [Token(Token = "0x600DC84")]
    [Address(RVA = "0x1E1E32C", Offset = "0x1E1E32C", VA = "0x1E1E32C")]
    public PredictionUI()
    {
    }

    [Token(Token = "0x20023FD")]
    [Serializable]
    public class HpGaugeContainer
    {
      [Token(Token = "0x40099B4")]
      [FieldOffset(Offset = "0x10")]
      public Slider BeforeGauge;
      [Token(Token = "0x40099B5")]
      [FieldOffset(Offset = "0x18")]
      public Slider AfterGauge;
      [Token(Token = "0x40099B6")]
      [FieldOffset(Offset = "0x20")]
      public TextContainer HpStock;
      [Token(Token = "0x40099B7")]
      [FieldOffset(Offset = "0x28")]
      public Image HpGaugeImage;
      [Token(Token = "0x40099B8")]
      [FieldOffset(Offset = "0x30")]
      public Image HpStockImage;

      [Token(Token = "0x600DC85")]
      [Address(RVA = "0x1E1E334", Offset = "0x1E1E334", VA = "0x1E1E334")]
      public HpGaugeContainer()
      {
      }
    }
  }
}
