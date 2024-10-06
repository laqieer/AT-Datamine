// Decompiled with JetBrains decompiler
// Type: Battle.UI.LoadedUnitPanelProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002388")]
  public class LoadedUnitPanelProvider
  {
    [Token(Token = "0x4009744")]
    public const string ASSETBUNDLE_LABEL = "ui_page_abridged";
    [Token(Token = "0x4009745")]
    public const string ASSET_NAME = "Container_Popup_Unit_Abridged_Battle";

    [Token(Token = "0x600D8FB")]
    [Address(RVA = "0x1B91014", Offset = "0x1B91014", VA = "0x1B91014")]
    public UnitPanel Instantiate(Transform parent, bool isNeedLp) => (UnitPanel) null;

    [Token(Token = "0x600D8FC")]
    [Address(RVA = "0x1B9100C", Offset = "0x1B9100C", VA = "0x1B9100C")]
    public LoadedUnitPanelProvider()
    {
    }
  }
}
