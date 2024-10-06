// Decompiled with JetBrains decompiler
// Type: Story.Tracker.UI.TrackerMainSectionUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using Story.Tracker.Logic;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Story.Tracker.UI
{
  [Token(Token = "0x20005D6")]
  public class TrackerMainSectionUI : MonoBehaviour
  {
    [Token(Token = "0x4001D1C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4001D1D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI title;
    [Token(Token = "0x4001D1E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button detailButton;
    [Token(Token = "0x4001D1F")]
    [FieldOffset(Offset = "0x30")]
    public Func<TrackingData> GetBinded;
    [Token(Token = "0x4001D20")]
    [FieldOffset(Offset = "0x38")]
    public Action<TrackingData> OnDetail;

    [Token(Token = "0x60021CD")]
    [Address(RVA = "0x2D9C958", Offset = "0x2D9C958", VA = "0x2D9C958")]
    public void SetTitle(string text)
    {
    }

    [Token(Token = "0x60021CE")]
    [Address(RVA = "0x2D9C97C", Offset = "0x2D9C97C", VA = "0x2D9C97C")]
    public void OnClickDetail()
    {
    }

    [Token(Token = "0x60021CF")]
    [Address(RVA = "0x2D9C9C8", Offset = "0x2D9C9C8", VA = "0x2D9C9C8")]
    public void Check(bool check)
    {
    }

    [Token(Token = "0x60021D0")]
    [Address(RVA = "0x2D9CA40", Offset = "0x2D9CA40", VA = "0x2D9CA40")]
    public void CheckAnimation(Action callback = null)
    {
    }

    [Token(Token = "0x60021D1")]
    [Address(RVA = "0x2D9CB40", Offset = "0x2D9CB40", VA = "0x2D9CB40")]
    private void OnValidate()
    {
    }

    [Token(Token = "0x60021D2")]
    [Address(RVA = "0x2D9CB90", Offset = "0x2D9CB90", VA = "0x2D9CB90")]
    public void InteractEnable()
    {
    }

    [Token(Token = "0x60021D3")]
    [Address(RVA = "0x2D9CC18", Offset = "0x2D9CC18", VA = "0x2D9CC18")]
    public void InteractDisable()
    {
    }

    [Token(Token = "0x60021D4")]
    [Address(RVA = "0x2D9CCA0", Offset = "0x2D9CCA0", VA = "0x2D9CCA0")]
    public TrackerMainSectionUI()
    {
    }

    [Token(Token = "0x20005D7")]
    private static class GroupIDs
    {
      [Token(Token = "0x4001D21")]
      public const string CheckOn = "Progress_CheckOn";
      [Token(Token = "0x4001D22")]
      public const string CheckOff = "Progress_CheckOff";
      [Token(Token = "0x4001D23")]
      public const string Check = "Progress_Check_Title";
    }
  }
}
