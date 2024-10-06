// Decompiled with JetBrains decompiler
// Type: FreeMap.Loader.CommonOneButtonPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace FreeMap.Loader
{
  [Token(Token = "0x20018A4")]
  public static class CommonOneButtonPopup
  {
    [Token(Token = "0x4006B0D")]
    private const string PopupAssetBundleLabel = "ui_common_prefabs";
    [Token(Token = "0x4006B0E")]
    private const string PopupAssetName = "Com_Popup_Base_S_Text";

    [Token(Token = "0x6008BF0")]
    [Address(RVA = "0x452A208", Offset = "0x452A208", VA = "0x452A208")]
    public static IEnumerator LoadAssetBundle() => (IEnumerator) null;

    [Token(Token = "0x6008BF1")]
    [Address(RVA = "0x452A290", Offset = "0x452A290", VA = "0x452A290")]
    public static CommonPopup CreateCommonOneButtonPopup() => (CommonPopup) null;

    [Token(Token = "0x6008BF2")]
    [Address(RVA = "0x452A308", Offset = "0x452A308", VA = "0x452A308")]
    public static void UnLoadAssetBundle()
    {
    }
  }
}
