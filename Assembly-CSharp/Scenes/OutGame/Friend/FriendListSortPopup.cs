// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Friend.FriendListSortPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Friend
{
  [Token(Token = "0x2003606")]
  public class FriendListSortPopup : PopupBase
  {
    [Token(Token = "0x400EAE2")]
    public const string AssetBundleName = "2dassets_ui_friend";
    [Token(Token = "0x400EAE3")]
    public const string PrefabName = "Com_Popup_FriendSort";
    [Token(Token = "0x400EAE4")]
    public const string AnimationKeyIn = "FriendSort_In";
    [Token(Token = "0x400EAE5")]
    public const string AnimationKeyOut = "FriendSort_Out";
    [Token(Token = "0x400EAE6")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private FriendListSortPopup.SortToggleInfo[] sortToggles;
    [Token(Token = "0x400EAE7")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Toggle toggleAscending;
    [Token(Token = "0x400EAE8")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Toggle toggleDescending;
    [Token(Token = "0x400EAE9")]
    [FieldOffset(Offset = "0xA0")]
    private FriendListSortInfo friendListSortInfo;
    [Token(Token = "0x400EAEA")]
    [FieldOffset(Offset = "0xA8")]
    public Action<FriendListSortInfo> OnClickDecisionEvent;

    [Token(Token = "0x6015428")]
    [Address(RVA = "0x4D91140", Offset = "0x4D91140", VA = "0x4D91140")]
    public void Setup(FriendListSortInfo friendListSortInfo)
    {
    }

    [Token(Token = "0x6015429")]
    [Address(RVA = "0x4D913A0", Offset = "0x4D913A0", VA = "0x4D913A0")]
    private void OnToggleChanged(FriendListSortTypeEnum friendListSortType, bool enable)
    {
    }

    [Token(Token = "0x601542A")]
    [Address(RVA = "0x4D913C0", Offset = "0x4D913C0", VA = "0x4D913C0")]
    private void OnAscendingToggleChanged(bool enable)
    {
    }

    [Token(Token = "0x601542B")]
    [Address(RVA = "0x4D913E4", Offset = "0x4D913E4", VA = "0x4D913E4")]
    private void OnDescendingToggleChanged(bool enable)
    {
    }

    [Token(Token = "0x601542C")]
    [Address(RVA = "0x4D91404", Offset = "0x4D91404", VA = "0x4D91404")]
    public void OnClickDecision()
    {
    }

    [Token(Token = "0x601542D")]
    [Address(RVA = "0x4D91424", Offset = "0x4D91424", VA = "0x4D91424")]
    public FriendListSortPopup()
    {
    }

    [Token(Token = "0x2003607")]
    [Serializable]
    private class SortToggleInfo
    {
      [Token(Token = "0x400EAEB")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      public FriendListSortTypeEnum friendListSortType;
      [Token(Token = "0x400EAEC")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      public Toggle toggle;

      [Token(Token = "0x601542E")]
      [Address(RVA = "0x4D91494", Offset = "0x4D91494", VA = "0x4D91494")]
      public SortToggleInfo()
      {
      }
    }
  }
}
