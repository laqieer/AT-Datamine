// Decompiled with JetBrains decompiler
// Type: Scenes.Story.KizunaList.ScrollControl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.KizunaList
{
  [Token(Token = "0x2002EA4")]
  public class ScrollControl : MonoBehaviour
  {
    [Token(Token = "0x400C7EA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CommonButton leftArrow;
    [Token(Token = "0x400C7EB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton rightArrow;
    [Token(Token = "0x400C7EC")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ScrollRect scrollRect;
    [Token(Token = "0x400C7ED")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private AnimationCurve jumpMoveCurve;
    [Token(Token = "0x400C7EE")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private float jumpMoveTime;
    [Token(Token = "0x400C7EF")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private float arrowMoveTimeScale;
    [Token(Token = "0x400C7F0")]
    [FieldOffset(Offset = "0x40")]
    private bool isInitialized;
    [Token(Token = "0x400C7F1")]
    [FieldOffset(Offset = "0x44")]
    private int contentCount;
    [Token(Token = "0x400C7F2")]
    [FieldOffset(Offset = "0x48")]
    private int contentMargin;
    [Token(Token = "0x400C7F3")]
    [FieldOffset(Offset = "0x4C")]
    private float contentWidth;
    [Token(Token = "0x400C7F4")]
    [FieldOffset(Offset = "0x50")]
    private float jumpMoveTimeCount;
    [Token(Token = "0x400C7F5")]
    [FieldOffset(Offset = "0x54")]
    private float jumpMoveLen;
    [Token(Token = "0x400C7F6")]
    [FieldOffset(Offset = "0x58")]
    private float jumpMoveSrcVal;
    [Token(Token = "0x400C7F7")]
    [FieldOffset(Offset = "0x5C")]
    private float jumpMoveTimeScale;

    [Token(Token = "0x6012355")]
    [Address(RVA = "0x45946AC", Offset = "0x45946AC", VA = "0x45946AC")]
    public void Initialize(int contentCount, int contentMargin, float contentWidth)
    {
    }

    [Token(Token = "0x6012356")]
    [Address(RVA = "0x45957D8", Offset = "0x45957D8", VA = "0x45957D8")]
    private void Update()
    {
    }

    [Token(Token = "0x6012357")]
    [Address(RVA = "0x4595BB0", Offset = "0x4595BB0", VA = "0x4595BB0")]
    public void OnClickedArrowLeft()
    {
    }

    [Token(Token = "0x6012358")]
    [Address(RVA = "0x4595D04", Offset = "0x4595D04", VA = "0x4595D04")]
    public void OnClickedArrowRight()
    {
    }

    [Token(Token = "0x6012359")]
    [Address(RVA = "0x4595BB8", Offset = "0x4595BB8", VA = "0x4595BB8")]
    private void ScrollPerCell(int direction)
    {
    }

    [Token(Token = "0x601235A")]
    [Address(RVA = "0x4595D0C", Offset = "0x4595D0C", VA = "0x4595D0C")]
    private void SetJumpMove(float val, float timeScale = 1f)
    {
    }

    [Token(Token = "0x601235B")]
    [Address(RVA = "0x4595D64", Offset = "0x4595D64", VA = "0x4595D64")]
    public ScrollControl()
    {
    }
  }
}
