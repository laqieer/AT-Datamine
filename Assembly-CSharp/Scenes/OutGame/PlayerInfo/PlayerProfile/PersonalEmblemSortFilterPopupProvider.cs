// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.PlayerInfo.PlayerProfile.PersonalEmblemSortFilterPopupProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.PlayerInfo.PlayerProfile
{
  [Token(Token = "0x20034AE")]
  public class PersonalEmblemSortFilterPopupProvider
  {
    [Token(Token = "0x400E53F")]
    private const string ASSETBUNDLE_NAME = "ui_page_sortfilter_prefab";

    [Token(Token = "0x6014AA8")]
    [Address(RVA = "0x1D63904", Offset = "0x1D63904", VA = "0x1D63904")]
    public static AssetSpawnOperation<GameObject> RequestPopup(
      AssetCachedSpawner spawner,
      List<PersonalEmblemListItem.PersonalEmblemInfo> possessionList,
      List<PersonalEmblemListItem.PersonalEmblemInfo> notPossessionList,
      int setEmblemID,
      Action<List<PersonalEmblemListItem.PersonalEmblemInfo>> sortAction)
    {
      return (AssetSpawnOperation<GameObject>) null;
    }

    [Token(Token = "0x6014AA9")]
    [Address(RVA = "0x1D68150", Offset = "0x1D68150", VA = "0x1D68150")]
    public PersonalEmblemSortFilterPopupProvider()
    {
    }
  }
}
