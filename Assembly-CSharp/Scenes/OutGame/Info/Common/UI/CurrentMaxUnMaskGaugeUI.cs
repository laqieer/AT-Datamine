// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Common.UI.CurrentMaxUnMaskGaugeUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UI;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Info.Common.UI
{
  [Token(Token = "0x20035E9")]
  public class CurrentMaxUnMaskGaugeUI : CurrentMaxGaugeUI
  {
    [Token(Token = "0x400EA86")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextAccessor current;
    [Token(Token = "0x400EA87")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextAccessor max;
    [Token(Token = "0x400EA88")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UnmaskGauge gauge;

    [Token(Token = "0x601539F")]
    [Address(RVA = "0x4D8C914", Offset = "0x4D8C914", VA = "0x4D8C914", Slot = "4")]
    public override void Set(int current, int max, int remainingStock = 0)
    {
    }

    [Token(Token = "0x60153A0")]
    [Address(RVA = "0x4D8CA64", Offset = "0x4D8CA64", VA = "0x4D8CA64")]
    public CurrentMaxUnMaskGaugeUI()
    {
    }
  }
}
