// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Common.UI.EquipmentEnduranceUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UI;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Info.Common.UI
{
  [Token(Token = "0x20035EB")]
  public class EquipmentEnduranceUI : MonoBehaviour
  {
    [Token(Token = "0x400EA8B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextAccessor current;
    [Token(Token = "0x400EA8C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextAccessor max;
    [Token(Token = "0x400EA8D")]
    [FieldOffset(Offset = "0x28")]
    [Header("%以下で危険域表示")]
    [SerializeField]
    private int dangerouseThresholdPercent;
    [Token(Token = "0x400EA8E")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Color daungerouseColor;

    [Token(Token = "0x60153A9")]
    [Address(RVA = "0x4D8CB84", Offset = "0x4D8CB84", VA = "0x4D8CB84")]
    public void Set(int current, int max)
    {
    }

    [Token(Token = "0x60153AA")]
    [Address(RVA = "0x4D8CCB0", Offset = "0x4D8CCB0", VA = "0x4D8CCB0")]
    public EquipmentEnduranceUI()
    {
    }
  }
}
