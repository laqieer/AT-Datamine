// Decompiled with JetBrains decompiler
// Type: FreeMap.Loader.KeySelectPopupLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Reward;
using Il2CppDummyDll;
using StaqData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FreeMap.Loader
{
  [Token(Token = "0x20018A2")]
  public static class KeySelectPopupLoader
  {
    [Token(Token = "0x4006B06")]
    private const string PopupAssetBundleLabel = "ui_page_arena_popup_prefab";
    [Token(Token = "0x4006B07")]
    private const string PopupAssetName = "Com_Popup_Base_S_TreasureBoxKey";
    [Token(Token = "0x4006B08")]
    private const string ITEM_ICON_NAME = "ui_common_thumb";
    [Token(Token = "0x4006B09")]
    [FieldOffset(Offset = "0x0")]
    private static List<string> labelList;

    [Token(Token = "0x6008BE5")]
    [Address(RVA = "0x4529854", Offset = "0x4529854", VA = "0x4529854")]
    public static IEnumerator LoadAssetBundle(ItemUtility.Parameter uiParam) => (IEnumerator) null;

    [Token(Token = "0x6008BE6")]
    [Address(RVA = "0x45298F0", Offset = "0x45298F0", VA = "0x45298F0")]
    public static KeySelectPopup CreateKeySelectPopup() => (KeySelectPopup) null;

    [Token(Token = "0x6008BE7")]
    [Address(RVA = "0x4529968", Offset = "0x4529968", VA = "0x4529968")]
    public static GameObject GetItemIconPrefab() => (GameObject) null;

    [Token(Token = "0x6008BE8")]
    [Address(RVA = "0x4529A5C", Offset = "0x4529A5C", VA = "0x4529A5C")]
    public static void UnLoadAssetBundle()
    {
    }

    [Token(Token = "0x6008BE9")]
    [Address(RVA = "0x4529C54", Offset = "0x4529C54", VA = "0x4529C54")]
    static KeySelectPopupLoader()
    {
    }
  }
}
