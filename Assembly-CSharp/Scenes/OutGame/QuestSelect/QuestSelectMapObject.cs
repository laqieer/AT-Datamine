// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelect.QuestSelectMapObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.QuestSelect
{
  [Token(Token = "0x20033EF")]
  public class QuestSelectMapObject : MonoBehaviour
  {
    [Token(Token = "0x400E1B8")]
    private const string TWEEN_IN = "Chara_On";
    [Token(Token = "0x400E1B9")]
    private const string TWEEN_OUT = "Chara_Off";
    [Token(Token = "0x400E1BA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400E1BB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x400E1BC")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private RawImage charaImage;
    [Token(Token = "0x400E1BD")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text mapText;
    [Token(Token = "0x400E1BE")]
    [FieldOffset(Offset = "0x38")]
    private QuestMapPositionData questMapPosition;
    [Token(Token = "0x400E1BF")]
    [FieldOffset(Offset = "0x40")]
    private StorySubquestFirstPositionData firstPositionData;

    [Token(Token = "0x17004400")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x6014688"), Address(RVA = "0x188C214", Offset = "0x188C214", VA = "0x188C214")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17004401")]
    public Vector2 Position
    {
      [Token(Token = "0x6014689"), Address(RVA = "0x188C21C", Offset = "0x188C21C", VA = "0x188C21C")] get
      {
        return new Vector2();
      }
      [Token(Token = "0x601468A"), Address(RVA = "0x188C224", Offset = "0x188C224", VA = "0x188C224")] private set
      {
      }
    }

    [Token(Token = "0x17004402")]
    public Action<int> OnClickAction
    {
      [Token(Token = "0x601468B"), Address(RVA = "0x188C22C", Offset = "0x188C22C", VA = "0x188C22C")] get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x601468C"), Address(RVA = "0x188C234", Offset = "0x188C234", VA = "0x188C234")] set
      {
      }
    }

    [Token(Token = "0x601468D")]
    [Address(RVA = "0x188AC88", Offset = "0x188AC88", VA = "0x188AC88")]
    public void Initialize(QuestMapPositionData positionData, RenderTexture renderTexture)
    {
    }

    [Token(Token = "0x601468E")]
    [Address(RVA = "0x188A554", Offset = "0x188A554", VA = "0x188A554")]
    public void Initialize(
      StorySubquestFirstPositionData firstPositionData,
      RenderTexture renderTexture)
    {
    }

    [Token(Token = "0x601468F")]
    [Address(RVA = "0x188B53C", Offset = "0x188B53C", VA = "0x188B53C")]
    public void PlayToCharaAnim(bool isOn)
    {
    }

    [Token(Token = "0x6014690")]
    [Address(RVA = "0x188C23C", Offset = "0x188C23C", VA = "0x188C23C")]
    public void OnClickMapIcon()
    {
    }

    [Token(Token = "0x6014691")]
    [Address(RVA = "0x188C274", Offset = "0x188C274", VA = "0x188C274")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6014692")]
    [Address(RVA = "0x188C29C", Offset = "0x188C29C", VA = "0x188C29C")]
    public QuestSelectMapObject()
    {
    }
  }
}
