// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.CharacterList.ScrollCtrl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.CharacterList
{
  [Token(Token = "0x2003733")]
  public class ScrollCtrl : MonoBehaviour
  {
    [Token(Token = "0x400F10A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CommonButton _leftArrow;
    [Token(Token = "0x400F10B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton _rightArrow;
    [Token(Token = "0x400F10C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ScrollRect _scrollRect;
    [Token(Token = "0x400F10D")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private AnimationCurve _jumpMoveCurve;
    [Token(Token = "0x400F10E")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private float _jumpMoveTime;
    [Token(Token = "0x400F10F")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private float _arrowMoveTimeScale;
    [Token(Token = "0x400F111")]
    [FieldOffset(Offset = "0x48")]
    private bool _isInitialized;
    [Token(Token = "0x400F112")]
    [FieldOffset(Offset = "0x4C")]
    private int _contentCount;
    [Token(Token = "0x400F113")]
    [FieldOffset(Offset = "0x50")]
    private int _contentMargin;
    [Token(Token = "0x400F114")]
    [FieldOffset(Offset = "0x58")]
    private Func<float> _contentWidth;
    [Token(Token = "0x400F115")]
    [FieldOffset(Offset = "0x60")]
    private float _jumpMoveTimeCount;
    [Token(Token = "0x400F116")]
    [FieldOffset(Offset = "0x64")]
    private float _jumpMoveLen;
    [Token(Token = "0x400F117")]
    [FieldOffset(Offset = "0x68")]
    private float _jumpMoveSrcVal;
    [Token(Token = "0x400F118")]
    [FieldOffset(Offset = "0x6C")]
    private float _jumpMoveTimeScale;
    [Token(Token = "0x400F119")]
    private const float ContentWidth = 180f;
    [Token(Token = "0x400F11A")]
    [FieldOffset(Offset = "0x70")]
    private float _scrollRectWidth;

    [Token(Token = "0x170047E8")]
    public Action<bool> OperationPossibleEvent
    {
      [Token(Token = "0x6015BE7"), Address(RVA = "0x1B23424", Offset = "0x1B23424", VA = "0x1B23424")] get
      {
        return (Action<bool>) null;
      }
      [Token(Token = "0x6015BE8"), Address(RVA = "0x1B2342C", Offset = "0x1B2342C", VA = "0x1B2342C")] set
      {
      }
    }

    [Token(Token = "0x6015BE9")]
    [Address(RVA = "0x1B23434", Offset = "0x1B23434", VA = "0x1B23434")]
    private void Update()
    {
    }

    [Token(Token = "0x6015BEA")]
    [Address(RVA = "0x1B2372C", Offset = "0x1B2372C", VA = "0x1B2372C")]
    public void Initialize(int conentCount, int contentMargin, Func<float> contentWidth)
    {
    }

    [Token(Token = "0x6015BEB")]
    [Address(RVA = "0x1B23874", Offset = "0x1B23874", VA = "0x1B23874")]
    public void OnClickedArrowLeft()
    {
    }

    [Token(Token = "0x6015BEC")]
    [Address(RVA = "0x1B239A8", Offset = "0x1B239A8", VA = "0x1B239A8")]
    public void OnClickedArrowRight()
    {
    }

    [Token(Token = "0x6015BED")]
    [Address(RVA = "0x1B239B0", Offset = "0x1B239B0", VA = "0x1B239B0")]
    public void MoveTo(Transform to)
    {
    }

    [Token(Token = "0x6015BEE")]
    [Address(RVA = "0x1B2387C", Offset = "0x1B2387C", VA = "0x1B2387C")]
    private void ScrollPerCell(int direction)
    {
    }

    [Token(Token = "0x6015BEF")]
    [Address(RVA = "0x1B23AD0", Offset = "0x1B23AD0", VA = "0x1B23AD0")]
    private void SetJumpMove(float val, float timeScale = 1f)
    {
    }

    [Token(Token = "0x6015BF0")]
    [Address(RVA = "0x1B23B4C", Offset = "0x1B23B4C", VA = "0x1B23B4C")]
    public ScrollCtrl()
    {
    }
  }
}
