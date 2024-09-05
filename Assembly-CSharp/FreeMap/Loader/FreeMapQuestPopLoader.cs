// Decompiled with JetBrains decompiler
// Type: FreeMap.Loader.FreeMapQuestPopLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.Story.SubQuest;
using System.Collections;

#nullable disable
namespace FreeMap.Loader
{
  [Token(Token = "0x200188C")]
  public static class FreeMapQuestPopLoader
  {
    [Token(Token = "0x4006AC7")]
    private const string PopupAssetBundleLabel = "2dassets_ui_story_common";
    [Token(Token = "0x4006AC8")]
    private const string PopupAssetName = "Adv_Com_Popup_SubQuest";

    [Token(Token = "0x6008B69")]
    [Address(RVA = "0x452738C", Offset = "0x452738C", VA = "0x452738C")]
    public static IEnumerator LoadAssetBundle() => (IEnumerator) null;

    [Token(Token = "0x6008B6A")]
    [Address(RVA = "0x4527414", Offset = "0x4527414", VA = "0x4527414")]
    public static SubQuestDetailPopup CreateQuestPopup() => (SubQuestDetailPopup) null;

    [Token(Token = "0x6008B6B")]
    [Address(RVA = "0x4527524", Offset = "0x4527524", VA = "0x4527524")]
    public static void UnLoadAssetBundle()
    {
    }
  }
}
