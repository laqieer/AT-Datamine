// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.CharacterLostListPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x200399E")]
  public class CharacterLostListPopup : MonoBehaviour
  {
    [Token(Token = "0x400FBCA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CanvasGroup topCanvasGroup;
    [Token(Token = "0x400FBCB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x400FBCC")]
    [FieldOffset(Offset = "0x28")]
    private bool isTimelineDirection;
    [Token(Token = "0x400FBCD")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CommonButton comebackButton;
    [Token(Token = "0x400FBCE")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400FBCF")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CHaracterLostReviveThumb srcThumb;
    [Token(Token = "0x400FBD0")]
    [FieldOffset(Offset = "0x48")]
    private List<CHaracterLostReviveThumb> thumbList;
    [Token(Token = "0x400FBD1")]
    [FieldOffset(Offset = "0x50")]
    private List<Character> characterList;
    [Token(Token = "0x400FBD2")]
    private const string ASSET_BUNDLE_LOSTREVIVE = "ui_page_characterlist";
    [Token(Token = "0x400FBD3")]
    private const string ASSET_LOSTREVIVE = "Container_Character_LostRevive";

    [Token(Token = "0x6016A2D")]
    [Address(RVA = "0x3F5F440", Offset = "0x3F5F440", VA = "0x3F5F440")]
    private void Awake()
    {
    }

    [Token(Token = "0x6016A2E")]
    [Address(RVA = "0x3F5F460", Offset = "0x3F5F460", VA = "0x3F5F460")]
    public void Initialize(
      List<Character> charList,
      CharacterLostListPopup.eCharacterLostListType type,
      Action<bool> finish)
    {
    }

    [Token(Token = "0x6016A2F")]
    [Address(RVA = "0x3F5FA9C", Offset = "0x3F5FA9C", VA = "0x3F5FA9C")]
    private IEnumerator playTimeline(UITimelineController.DirectionType inout, Action finishAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016A30")]
    [Address(RVA = "0x3F5F8B8", Offset = "0x3F5F8B8", VA = "0x3F5F8B8")]
    private IEnumerator loadThumbImage() => (IEnumerator) null;

    [Token(Token = "0x6016A31")]
    [Address(RVA = "0x3F5FB6C", Offset = "0x3F5FB6C", VA = "0x3F5FB6C")]
    private IEnumerator SetRevive(Action finish) => (IEnumerator) null;

    [Token(Token = "0x6016A32")]
    [Address(RVA = "0x3F5FC08", Offset = "0x3F5FC08", VA = "0x3F5FC08")]
    public CharacterLostListPopup()
    {
    }

    [Token(Token = "0x200399F")]
    public enum eCharacterLostListType
    {
      [Token(Token = "0x400FBD5")] fromHome,
      [Token(Token = "0x400FBD6")] fromSortiePreparation,
    }
  }
}
