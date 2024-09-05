// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelect.QuestSelect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.QuestSelect
{
  [Token(Token = "0x20033E4")]
  public class QuestSelect : MonoBehaviour
  {
    [Token(Token = "0x400E177")]
    private const string TWEEN_IN_SELECT = "Quest_In";
    [Token(Token = "0x400E178")]
    private const string TWEEN_OUT_SELECT = "Quest_Out";
    [Token(Token = "0x400E179")]
    [FieldOffset(Offset = "0x18")]
    private readonly Dictionary<Scenes.OutGame.QuestSelect.QuestSelect.TweenType, string> tweenMap;
    [Token(Token = "0x400E17A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400E17B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x400E17C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private QuestSelectList selectList;
    [Token(Token = "0x400E17D")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject backButton;

    [Token(Token = "0x170043F7")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x601464C"), Address(RVA = "0x188974C", Offset = "0x188974C", VA = "0x188974C")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x601464D")]
    [Address(RVA = "0x1889754", Offset = "0x1889754", VA = "0x1889754")]
    public void Initialize(
      GameObject listItem,
      IList<QuestInfo> questList,
      Action<int> questDetailAction,
      Action<int> questSelectAction,
      Action<int> lockQuestSelectAction = null,
      int? initQuestId = null)
    {
    }

    [Token(Token = "0x170043F8")]
    public bool IsTweenPlaying
    {
      [Token(Token = "0x601464E"), Address(RVA = "0x1889B0C", Offset = "0x1889B0C", VA = "0x1889B0C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x601464F")]
    [Address(RVA = "0x1889B28", Offset = "0x1889B28", VA = "0x1889B28")]
    public void PlayToEnableAnimation()
    {
    }

    [Token(Token = "0x6014650")]
    [Address(RVA = "0x1889B98", Offset = "0x1889B98", VA = "0x1889B98")]
    public void PlayToDisableAnimation()
    {
    }

    [Token(Token = "0x6014651")]
    [Address(RVA = "0x1889C08", Offset = "0x1889C08", VA = "0x1889C08")]
    public void OnClickToBack()
    {
    }

    [Token(Token = "0x6014652")]
    [Address(RVA = "0x1889C88", Offset = "0x1889C88", VA = "0x1889C88")]
    public void SetAcitveByBackButton(bool active)
    {
    }

    [Token(Token = "0x6014653")]
    [Address(RVA = "0x1889CA8", Offset = "0x1889CA8", VA = "0x1889CA8")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6014654")]
    [Address(RVA = "0x1889E30", Offset = "0x1889E30", VA = "0x1889E30")]
    public QuestSelect()
    {
    }

    [Token(Token = "0x20033E5")]
    public enum TweenType
    {
      [Token(Token = "0x400E17F")] In,
      [Token(Token = "0x400E180")] Out,
    }
  }
}
