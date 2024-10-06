// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.ResultItem.ResultItemOverProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Battle.ResultItem
{
  [Token(Token = "0x20037E3")]
  public static class ResultItemOverProvider
  {
    [Token(Token = "0x400F435")]
    private const string ASSETBUNDLE_NAME = "ui_page_ingame_battleresult_prefab";
    [Token(Token = "0x400F436")]
    private const string ASSET_NAME = "Container_Battle_Result_Popup_Item_Over";

    [Token(Token = "0x6015FCF")]
    [Address(RVA = "0x232EE90", Offset = "0x232EE90", VA = "0x232EE90")]
    public static IEnumerator RequestAndWait(
      AssetCachedSpawner assetCachedSpawner,
      List<ResultData.ItemData> unreceived,
      Transform parent = null)
    {
      return (IEnumerator) null;
    }
  }
}
