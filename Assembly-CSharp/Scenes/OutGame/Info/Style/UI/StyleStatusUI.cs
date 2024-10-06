// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Style.UI.StyleStatusUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Info.Equipment.UI;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Info.Style.UI
{
  [Token(Token = "0x2003572")]
  public class StyleStatusUI : MonoBehaviour
  {
    [Token(Token = "0x400E872")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private EquipmentFlavorUI flavorUI;
    [Token(Token = "0x400E873")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private StyleProfileUI styleProfileUI;

    [Token(Token = "0x6014FAB")]
    [Address(RVA = "0x4A9FE48", Offset = "0x4A9FE48", VA = "0x4A9FE48")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6014FAC")]
    [Address(RVA = "0x4AA01EC", Offset = "0x4AA01EC", VA = "0x4AA01EC")]
    public StyleStatusView CreateView() => (StyleStatusView) null;

    [Token(Token = "0x6014FAD")]
    [Address(RVA = "0x4AA0D78", Offset = "0x4AA0D78", VA = "0x4AA0D78")]
    public StyleStatusUI()
    {
    }
  }
}
