// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Common.UI.CurrentMaxSliderGaugeUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using UI;
using UI.Utilities.SerializeUI;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Info.Common.UI
{
  [Token(Token = "0x20035E8")]
  public class CurrentMaxSliderGaugeUI : CurrentMaxGaugeUI
  {
    [Token(Token = "0x400EA81")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextAccessor current;
    [Token(Token = "0x400EA82")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextAccessor max;
    [Token(Token = "0x400EA83")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Slider gauge;
    [Token(Token = "0x400EA84")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextContainer remainingStock;
    [Token(Token = "0x400EA85")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private ActiveObjectContainers forceActiveObjects;

    [Token(Token = "0x601539C")]
    [Address(RVA = "0x4D8C6E0", Offset = "0x4D8C6E0", VA = "0x4D8C6E0", Slot = "4")]
    public override void Set(int current, int max, int remainingStock)
    {
    }

    [Token(Token = "0x601539D")]
    [Address(RVA = "0x4D8C880", Offset = "0x4D8C880", VA = "0x4D8C880")]
    public void UpdateForceColor(ForceTypeEnum force)
    {
    }

    [Token(Token = "0x601539E")]
    [Address(RVA = "0x4D8C90C", Offset = "0x4D8C90C", VA = "0x4D8C90C")]
    public CurrentMaxSliderGaugeUI()
    {
    }
  }
}
