// Decompiled with JetBrains decompiler
// Type: Story.Tracker.UI.TrackerSubSectionUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using System.Collections;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Story.Tracker.UI
{
  [Token(Token = "0x20005DA")]
  public class TrackerSubSectionUI : MonoBehaviour
  {
    [Token(Token = "0x4001D29")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4001D2A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITimelineController uiTimelineController;
    [Token(Token = "0x4001D2B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TrackerSubSectionElementUI order;
    [Token(Token = "0x4001D2C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TrackerSubSectionElementUI unorder;
    [Token(Token = "0x4001D2D")]
    [FieldOffset(Offset = "0x38")]
    [Tooltip("アニメーションのズレ")]
    [SerializeField]
    private float delay;
    [Token(Token = "0x4001D2E")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject iconPurpose;
    [Token(Token = "0x4001D2F")]
    [FieldOffset(Offset = "0x48")]
    private TrackerSubSectionElementUI current;

    [Token(Token = "0x170004C0")]
    public float Delay
    {
      [Token(Token = "0x60021DB"), Address(RVA = "0x2D9CDA0", Offset = "0x2D9CDA0", VA = "0x2D9CDA0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x170004C1")]
    public bool IsPlaying
    {
      [Token(Token = "0x60021DC"), Address(RVA = "0x2D9CDA8", Offset = "0x2D9CDA8", VA = "0x2D9CDA8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60021DD")]
    [Address(RVA = "0x2D9CDC4", Offset = "0x2D9CDC4", VA = "0x2D9CDC4")]
    public IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60021DE")]
    [Address(RVA = "0x2D9CE54", Offset = "0x2D9CE54", VA = "0x2D9CE54")]
    public void SetTitle(string text)
    {
    }

    [Token(Token = "0x60021DF")]
    [Address(RVA = "0x2D9CE80", Offset = "0x2D9CE80", VA = "0x2D9CE80")]
    public void SetPurpose(bool sw)
    {
    }

    [Token(Token = "0x60021E0")]
    [Address(RVA = "0x2D9CEA0", Offset = "0x2D9CEA0", VA = "0x2D9CEA0")]
    public void SetProgress(int current, int max)
    {
    }

    [Token(Token = "0x60021E1")]
    [Address(RVA = "0x2D9CEB8", Offset = "0x2D9CEB8", VA = "0x2D9CEB8")]
    public void EnableProgress(bool active)
    {
    }

    [Token(Token = "0x60021E2")]
    [Address(RVA = "0x2D9CED4", Offset = "0x2D9CED4", VA = "0x2D9CED4")]
    public void Order()
    {
    }

    [Token(Token = "0x60021E3")]
    [Address(RVA = "0x2D9CF28", Offset = "0x2D9CF28", VA = "0x2D9CF28")]
    public void NoOrder()
    {
    }

    [Token(Token = "0x60021E4")]
    [Address(RVA = "0x2D9CF8C", Offset = "0x2D9CF8C", VA = "0x2D9CF8C")]
    public void Hide()
    {
    }

    [Token(Token = "0x60021E5")]
    [Address(RVA = "0x2D9CFE0", Offset = "0x2D9CFE0", VA = "0x2D9CFE0")]
    public void Out(Action callback = null)
    {
    }

    [Token(Token = "0x60021E6")]
    [Address(RVA = "0x2D9D0E0", Offset = "0x2D9D0E0", VA = "0x2D9D0E0")]
    public void In()
    {
    }

    [Token(Token = "0x60021E7")]
    [Address(RVA = "0x2D9D138", Offset = "0x2D9D138", VA = "0x2D9D138")]
    public void ChangeAnimation(Action callback = null)
    {
    }

    [Token(Token = "0x60021E8")]
    [Address(RVA = "0x2D9D238", Offset = "0x2D9D238", VA = "0x2D9D238")]
    public void Check(bool check)
    {
    }

    [Token(Token = "0x60021E9")]
    [Address(RVA = "0x2D9D2B0", Offset = "0x2D9D2B0", VA = "0x2D9D2B0")]
    public void CheckAnimation(Action callback = null)
    {
    }

    [Token(Token = "0x60021EA")]
    [Address(RVA = "0x2D9D3B0", Offset = "0x2D9D3B0", VA = "0x2D9D3B0")]
    private void OnValidate()
    {
    }

    [Token(Token = "0x60021EB")]
    [Address(RVA = "0x2D9D42C", Offset = "0x2D9D42C", VA = "0x2D9D42C")]
    public TrackerSubSectionUI()
    {
    }

    [Token(Token = "0x20005DB")]
    private static class GroupIDs
    {
      [Token(Token = "0x4001D30")]
      public const string In = "Progress_In";
      [Token(Token = "0x4001D31")]
      public const string Out = "Progress_Out";
      [Token(Token = "0x4001D32")]
      public const string Change = "Progress_Change";
      [Token(Token = "0x4001D33")]
      public const string Check = "Progress_Check";
      [Token(Token = "0x4001D34")]
      public const string CheckOn = "Progress_CheckOn";
      [Token(Token = "0x4001D35")]
      public const string CheckOff = "Progress_CheckOff";
    }
  }
}
