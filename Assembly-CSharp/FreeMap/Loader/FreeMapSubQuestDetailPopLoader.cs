// Decompiled with JetBrains decompiler
// Type: FreeMap.Loader.FreeMapSubQuestDetailPopLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.Story.SubQuest;
using System.Collections;

#nullable disable
namespace FreeMap.Loader
{
  [Token(Token = "0x20018A0")]
  public static class FreeMapSubQuestDetailPopLoader
  {
    [Token(Token = "0x4006B02")]
    private const string PopupAssetBundleLabel = "2dassets_ui_story_common";
    [Token(Token = "0x4006B03")]
    private const string PopupAssetName = "Adv_Com_Popup_SubQuest";

    [Token(Token = "0x6008BDC")]
    [Address(RVA = "0x45295E0", Offset = "0x45295E0", VA = "0x45295E0")]
    public static IEnumerator LoadAssetBundle() => (IEnumerator) null;

    [Token(Token = "0x6008BDD")]
    [Address(RVA = "0x4529668", Offset = "0x4529668", VA = "0x4529668")]
    public static SubQuestDetailPopup CreateSubQuestDetailPopup() => (SubQuestDetailPopup) null;

    [Token(Token = "0x6008BDE")]
    [Address(RVA = "0x45296FC", Offset = "0x45296FC", VA = "0x45296FC")]
    public static void UnLoadAssetBundle()
    {
    }
  }
}
