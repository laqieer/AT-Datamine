// Decompiled with JetBrains decompiler
// Type: Battle.UI.LoadedConditionDetailPanelProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x200238C")]
  public class LoadedConditionDetailPanelProvider
  {
    [Token(Token = "0x400974C")]
    public const string ASSETBUNDLE_LABEL = "2dassets_ui_ingameui";
    [Token(Token = "0x400974D")]
    public const string ASSET_NAME = "Com_Popup_StatusDetails";

    [Token(Token = "0x600D903")]
    [Address(RVA = "0x1B9349C", Offset = "0x1B9349C", VA = "0x1B9349C")]
    public BattleConditionDetailPanel Instantiate(Transform parent)
    {
      return (BattleConditionDetailPanel) null;
    }

    [Token(Token = "0x600D904")]
    [Address(RVA = "0x1B93494", Offset = "0x1B93494", VA = "0x1B93494")]
    public LoadedConditionDetailPanelProvider()
    {
    }
  }
}
