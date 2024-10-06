// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Popup.TitleSelect.TitleFrameListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Cysharp.Threading.Tasks;
using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.OutGame.TitleEmblem;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Popup.TitleSelect
{
  [Token(Token = "0x200346B")]
  public class TitleFrameListItem : MonoBehaviour
  {
    [Token(Token = "0x400E3F5")]
    private const string TWEEN_KEY_SET = "Set";
    [Token(Token = "0x400E3F6")]
    private const string TWEEN_KEY_ON = "On";
    [Token(Token = "0x400E3F7")]
    private const string TWEEN_KEY_OFF = "Off";
    [Token(Token = "0x400E3F8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400E3F9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image frameImage;
    [Token(Token = "0x400E3FA")]
    [FieldOffset(Offset = "0x28")]
    private Action onClickAction;

    [Token(Token = "0x17004456")]
    public int TitleId
    {
      [Token(Token = "0x6014915"), Address(RVA = "0x1AA6A9C", Offset = "0x1AA6A9C", VA = "0x1AA6A9C")] get
      {
        return new int();
      }
      [Token(Token = "0x6014916"), Address(RVA = "0x1AA6AA4", Offset = "0x1AA6AA4", VA = "0x1AA6AA4")] private set
      {
      }
    }

    [Token(Token = "0x17004457")]
    public bool IsUnlockedTitle
    {
      [Token(Token = "0x6014917"), Address(RVA = "0x1AA6AAC", Offset = "0x1AA6AAC", VA = "0x1AA6AAC")] get
      {
        return new bool();
      }
      [Token(Token = "0x6014918"), Address(RVA = "0x1AA6AB4", Offset = "0x1AA6AB4", VA = "0x1AA6AB4")] private set
      {
      }
    }

    [Token(Token = "0x6014919")]
    [Address(RVA = "0x1AA675C", Offset = "0x1AA675C", VA = "0x1AA675C")]
    public void Initialize(
      int titleId,
      ITitleLoader titleLoader,
      bool unlocked,
      Action onClickAction,
      CancellationToken cancellationToken)
    {
    }

    [Token(Token = "0x601491A")]
    [Address(RVA = "0x1AA6AC0", Offset = "0x1AA6AC0", VA = "0x1AA6AC0")]
    private UniTaskVoid LoadSpriteAsync(
      int titleId,
      ITitleLoader titleLoader,
      CancellationToken cancellationToken)
    {
      return new UniTaskVoid();
    }

    [Token(Token = "0x601491B")]
    [Address(RVA = "0x1AA6B60", Offset = "0x1AA6B60", VA = "0x1AA6B60")]
    public void OnItemClick()
    {
    }

    [Token(Token = "0x601491C")]
    [Address(RVA = "0x1AA6838", Offset = "0x1AA6838", VA = "0x1AA6838")]
    public void SetSelected(bool selected)
    {
    }

    [Token(Token = "0x601491D")]
    [Address(RVA = "0x1AA6BF4", Offset = "0x1AA6BF4", VA = "0x1AA6BF4")]
    public TitleFrameListItem()
    {
    }
  }
}
