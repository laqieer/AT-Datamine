// Decompiled with JetBrains decompiler
// Type: GameCore.UIControls.UISafeAreaInsets
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.UIControls
{
  [Token(Token = "0x2000C1C")]
  [ExecuteInEditMode]
  public class UISafeAreaInsets : MonoBehaviour
  {
    [Token(Token = "0x40036F1")]
    private const float TopOrRight = 1f;
    [Token(Token = "0x40036F2")]
    private const float BottomOrLeft = 0.0f;
    [Token(Token = "0x40036F3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private bool fixedWidth;
    [Token(Token = "0x40036F4")]
    [FieldOffset(Offset = "0x19")]
    [SerializeField]
    private bool fixedHeight;
    [Token(Token = "0x40036F5")]
    [FieldOffset(Offset = "0x1A")]
    [SerializeField]
    private bool adjustedWidthScale;
    [Token(Token = "0x40036F6")]
    [FieldOffset(Offset = "0x1B")]
    [SerializeField]
    private bool adjustedMinScale;
    [Token(Token = "0x40036F7")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private bool adjustedHeightScale;
    [Token(Token = "0x40036F8")]
    [FieldOffset(Offset = "0x20")]
    private SafeAreaExtensions safeAreaEx;
    [Token(Token = "0x40036F9")]
    [FieldOffset(Offset = "0x28")]
    private RectTransform panel;
    [Token(Token = "0x40036FA")]
    [FieldOffset(Offset = "0x30")]
    private Rect lastSafeArea;
    [Token(Token = "0x40036FB")]
    [FieldOffset(Offset = "0x40")]
    private Dictionary<string, UISafeAreaAdjustmentInfo> beforeUISafeAreaAdjustmentInfo;

    [Token(Token = "0x17000A08")]
    private SafeAreaExtensions SafeAreaEx
    {
      [Token(Token = "0x600454E"), Address(RVA = "0x350E910", Offset = "0x350E910", VA = "0x350E910")] get
      {
        return (SafeAreaExtensions) null;
      }
    }

    [Token(Token = "0x600454F")]
    [Address(RVA = "0x350E9A4", Offset = "0x350E9A4", VA = "0x350E9A4")]
    public IEnumerator WaitInitialize(Action finishAction) => (IEnumerator) null;

    [Token(Token = "0x6004550")]
    [Address(RVA = "0x350EA40", Offset = "0x350EA40", VA = "0x350EA40")]
    private void Start()
    {
    }

    [Token(Token = "0x6004551")]
    [Address(RVA = "0x350EB40", Offset = "0x350EB40", VA = "0x350EB40")]
    private Rect GetSafeArea() => new Rect();

    [Token(Token = "0x6004552")]
    [Address(RVA = "0x350EAA8", Offset = "0x350EAA8", VA = "0x350EAA8")]
    public void UpdateSafeArea(bool isForce = false)
    {
    }

    [Token(Token = "0x6004553")]
    [Address(RVA = "0x350F48C", Offset = "0x350F48C", VA = "0x350F48C")]
    public void CorrectRectTransformToSafeArea(RectTransform rectTransForm, bool isForce = false)
    {
    }

    [Token(Token = "0x6004554")]
    [Address(RVA = "0x350F198", Offset = "0x350F198", VA = "0x350F198")]
    private void FixAnchor(Rect area)
    {
    }

    [Token(Token = "0x6004555")]
    [Address(RVA = "0x350F390", Offset = "0x350F390", VA = "0x350F390")]
    private void AdjustScale(Rect area)
    {
    }

    [Token(Token = "0x6004556")]
    [Address(RVA = "0x350F524", Offset = "0x350F524", VA = "0x350F524")]
    private void AdjustScaleWidthOrHeight(float scale, bool isWidth)
    {
    }

    [Token(Token = "0x6004557")]
    [Address(RVA = "0x350FCDC", Offset = "0x350FCDC", VA = "0x350FCDC")]
    public void SaveBeforeAdjustmentInfo(string instanceID, RectTransform rt)
    {
    }

    [Token(Token = "0x6004558")]
    [Address(RVA = "0x350ECC0", Offset = "0x350ECC0", VA = "0x350ECC0")]
    private void RestoreScale()
    {
    }

    [Token(Token = "0x6004559")]
    [Address(RVA = "0x350FDF8", Offset = "0x350FDF8", VA = "0x350FDF8")]
    public UISafeAreaInsets()
    {
    }
  }
}
