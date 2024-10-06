// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.MedalShop.PosessionMedalList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.MedalShop
{
  [Token(Token = "0x2003B30")]
  public class PosessionMedalList : MonoBehaviour
  {
    [Token(Token = "0x4010549")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PosessionMedaiItem baseItem;
    [Token(Token = "0x401054A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RectTransform content;
    [Token(Token = "0x401054B")]
    [FieldOffset(Offset = "0x28")]
    private List<PosessionMedaiItem> createdItems;
    [Token(Token = "0x401054C")]
    [FieldOffset(Offset = "0x30")]
    private Action backButtonAction;
    [Token(Token = "0x4010551")]
    [FieldOffset(Offset = "0x40")]
    private OutGameMenuSubScene subScene;

    [Token(Token = "0x17004BF6")]
    public bool IsConnetingApi
    {
      [Token(Token = "0x60174A2"), Address(RVA = "0x271D3A4", Offset = "0x271D3A4", VA = "0x271D3A4")] get
      {
        return new bool();
      }
      [Token(Token = "0x60174A3"), Address(RVA = "0x271D3AC", Offset = "0x271D3AC", VA = "0x271D3AC")] set
      {
      }
    }

    [Token(Token = "0x17004BF7")]
    public bool IsUpdateLineup
    {
      [Token(Token = "0x60174A4"), Address(RVA = "0x271D3B8", Offset = "0x271D3B8", VA = "0x271D3B8")] get
      {
        return new bool();
      }
      [Token(Token = "0x60174A5"), Address(RVA = "0x271D3C0", Offset = "0x271D3C0", VA = "0x271D3C0")] set
      {
      }
    }

    [Token(Token = "0x17004BF8")]
    public bool IsOpenPopup
    {
      [Token(Token = "0x60174A6"), Address(RVA = "0x271D3CC", Offset = "0x271D3CC", VA = "0x271D3CC")] get
      {
        return new bool();
      }
      [Token(Token = "0x60174A7"), Address(RVA = "0x271D3D4", Offset = "0x271D3D4", VA = "0x271D3D4")] set
      {
      }
    }

    [Token(Token = "0x17004BF9")]
    public bool IsOverlappingCheck
    {
      [Token(Token = "0x60174A8"), Address(RVA = "0x271D3E0", Offset = "0x271D3E0", VA = "0x271D3E0")] get
      {
        return new bool();
      }
      [Token(Token = "0x60174A9"), Address(RVA = "0x271D3E8", Offset = "0x271D3E8", VA = "0x271D3E8")] set
      {
      }
    }

    [Token(Token = "0x60174AA")]
    [Address(RVA = "0x271D3F4", Offset = "0x271D3F4", VA = "0x271D3F4")]
    public void Initialize(
      int medalShopId,
      MedalShopLoader loader,
      AssetCachedSpawner spawner,
      OutGameMenuSubScene subScene,
      Action backButtonAction)
    {
    }

    [Token(Token = "0x60174AB")]
    [Address(RVA = "0x2716DAC", Offset = "0x2716DAC", VA = "0x2716DAC")]
    public void UpdateMedal()
    {
    }

    [Token(Token = "0x60174AC")]
    [Address(RVA = "0x271D954", Offset = "0x271D954", VA = "0x271D954")]
    public void PlayToIn()
    {
    }

    [Token(Token = "0x60174AD")]
    [Address(RVA = "0x271DA9C", Offset = "0x271DA9C", VA = "0x271DA9C")]
    public void PlayToOut(UnityAction finishAction)
    {
    }

    [Token(Token = "0x60174AE")]
    [Address(RVA = "0x2717D5C", Offset = "0x2717D5C", VA = "0x2717D5C")]
    public void OnBackButton()
    {
    }

    [Token(Token = "0x60174AF")]
    [Address(RVA = "0x271D79C", Offset = "0x271D79C", VA = "0x271D79C")]
    private void Destroy()
    {
    }

    [Token(Token = "0x60174B0")]
    [Address(RVA = "0x271DB38", Offset = "0x271DB38", VA = "0x271DB38")]
    public PosessionMedalList()
    {
    }
  }
}
