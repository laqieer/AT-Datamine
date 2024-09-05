// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.EquipChange.IconUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitEquipmentView.UI.EquipChange
{
  [Token(Token = "0x2000484")]
  [Serializable]
  public class IconUI
  {
    [Token(Token = "0x400184F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Image image;
    [Token(Token = "0x4001850")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI num;

    [Token(Token = "0x6001948")]
    [Address(RVA = "0x24941D4", Offset = "0x24941D4", VA = "0x24941D4")]
    public void Apply(Sprite icon, int num)
    {
    }

    [Token(Token = "0x6001949")]
    [Address(RVA = "0x2494B4C", Offset = "0x2494B4C", VA = "0x2494B4C")]
    public IconUI()
    {
    }
  }
}
