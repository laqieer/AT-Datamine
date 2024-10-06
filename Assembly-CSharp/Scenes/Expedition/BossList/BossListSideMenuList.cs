// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.BossList.BossListSideMenuList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Expedition.BossList
{
  [Token(Token = "0x2002D2A")]
  public class BossListSideMenuList : MonoBehaviour
  {
    [Token(Token = "0x400C1B3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ScrollRect scrollView;
    [Token(Token = "0x400C1B4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private BossListSideMenu sideMenu;
    [Token(Token = "0x400C1B7")]
    [FieldOffset(Offset = "0x38")]
    private Coroutine snappingProcesser;

    [Token(Token = "0x17003C82")]
    private BossListSideMenu[] SideMenus
    {
      [Token(Token = "0x6011AB0"), Address(RVA = "0x42AD4CC", Offset = "0x42AD4CC", VA = "0x42AD4CC")] get
      {
        return (BossListSideMenu[]) null;
      }
      [Token(Token = "0x6011AB1"), Address(RVA = "0x42AD4D4", Offset = "0x42AD4D4", VA = "0x42AD4D4")] set
      {
      }
    }

    [Token(Token = "0x17003C83")]
    public int SelectedStageId
    {
      [Token(Token = "0x6011AB2"), Address(RVA = "0x42AD4DC", Offset = "0x42AD4DC", VA = "0x42AD4DC")] get
      {
        return new int();
      }
      [Token(Token = "0x6011AB3"), Address(RVA = "0x42AD4E4", Offset = "0x42AD4E4", VA = "0x42AD4E4")] private set
      {
      }
    }

    [Token(Token = "0x6011AB4")]
    [Address(RVA = "0x42AD4EC", Offset = "0x42AD4EC", VA = "0x42AD4EC")]
    public void Initialize(AssetCachedSpawner assetCachedSpawner, Action<int> buttonCallback)
    {
    }

    [Token(Token = "0x6011AB5")]
    [Address(RVA = "0x42AD800", Offset = "0x42AD800", VA = "0x42AD800")]
    public void SelectStage(int stageId)
    {
    }

    [Token(Token = "0x6011AB6")]
    [Address(RVA = "0x42AD850", Offset = "0x42AD850", VA = "0x42AD850")]
    private BossListSideMenu GetItem(int stageId) => (BossListSideMenu) null;

    [Token(Token = "0x6011AB7")]
    [Address(RVA = "0x42AD76C", Offset = "0x42AD76C", VA = "0x42AD76C")]
    private int CountExpeditionStageData() => new int();

    [Token(Token = "0x6011AB8")]
    [Address(RVA = "0x42AD6C8", Offset = "0x42AD6C8", VA = "0x42AD6C8")]
    private void DeleteMenus()
    {
    }

    [Token(Token = "0x6011AB9")]
    [Address(RVA = "0x42AD8A0", Offset = "0x42AD8A0", VA = "0x42AD8A0")]
    private void SnapScrollView(int index, float duration)
    {
    }

    [Token(Token = "0x6011ABA")]
    [Address(RVA = "0x42ADA70", Offset = "0x42ADA70", VA = "0x42ADA70")]
    private void DoSnappingScrollView(Vector2 target, float duration)
    {
    }

    [Token(Token = "0x6011ABB")]
    [Address(RVA = "0x42ADAF8", Offset = "0x42ADAF8", VA = "0x42ADAF8")]
    private void StopSnapping()
    {
    }

    [Token(Token = "0x6011ABC")]
    [Address(RVA = "0x42ADB1C", Offset = "0x42ADB1C", VA = "0x42ADB1C")]
    private IEnumerator ProcessSnappingScrollView(Vector2 target, float duration)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6011ABD")]
    [Address(RVA = "0x42ADBD0", Offset = "0x42ADBD0", VA = "0x42ADBD0")]
    public BossListSideMenuList()
    {
    }
  }
}
