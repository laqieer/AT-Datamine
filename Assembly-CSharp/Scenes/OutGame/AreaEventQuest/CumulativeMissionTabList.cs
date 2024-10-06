// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaEventQuest.CumulativeMissionTabList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

#nullable disable
namespace Scenes.OutGame.AreaEventQuest
{
  [Token(Token = "0x2003930")]
  internal class CumulativeMissionTabList : MonoBehaviour
  {
    [Token(Token = "0x400FA02")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform tabParent;
    [Token(Token = "0x400FA03")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CumulativeMissionTab tabObj;
    [Token(Token = "0x400FA04")]
    [FieldOffset(Offset = "0x28")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400FA05")]
    [FieldOffset(Offset = "0x30")]
    private SpriteAtlas spriteAtlas;
    [Token(Token = "0x400FA06")]
    [FieldOffset(Offset = "0x38")]
    private List<CumulativeMissionTab> createTabs;

    [Token(Token = "0x170049F4")]
    private static string AssetBundleFormat
    {
      [Token(Token = "0x60167AC"), Address(RVA = "0x42E6CA8", Offset = "0x42E6CA8", VA = "0x42E6CA8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60167AD")]
    [Address(RVA = "0x42E6CE8", Offset = "0x42E6CE8", VA = "0x42E6CE8")]
    public IEnumerator InitializeAsync(
      List<TotalMissionTabType> response,
      int currentTabId,
      int resourceId,
      AssetCachedSpawner assetCachedSpawner,
      Action<int> onClickAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60167AE")]
    [Address(RVA = "0x42E6DB4", Offset = "0x42E6DB4", VA = "0x42E6DB4")]
    public void UpdateTabs(List<TotalMissionTabType> tabTypes, int currentTabId)
    {
    }

    [Token(Token = "0x60167AF")]
    [Address(RVA = "0x42E6EB8", Offset = "0x42E6EB8", VA = "0x42E6EB8")]
    public CumulativeMissionTabList()
    {
    }
  }
}
