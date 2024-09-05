// Decompiled with JetBrains decompiler
// Type: Story.Chart.UI.StoryTerningPointConditionPopupContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Story.Chart.UI
{
  [Token(Token = "0x2000717")]
  public class StoryTerningPointConditionPopupContent : Popup.Content
  {
    [Token(Token = "0x40020F3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private StoryConditionUI conditionUI;
    [Token(Token = "0x40020F4")]
    [FieldOffset(Offset = "0x20")]
    private int count;
    [Token(Token = "0x40020F5")]
    [FieldOffset(Offset = "0x28")]
    private List<StoryConditionUI> conditions;

    [Token(Token = "0x60027F6")]
    [Address(RVA = "0x367188C", Offset = "0x367188C", VA = "0x367188C")]
    public StoryConditionUI Duplicate() => (StoryConditionUI) null;

    [Token(Token = "0x60027F7")]
    [Address(RVA = "0x36719EC", Offset = "0x36719EC", VA = "0x36719EC", Slot = "4")]
    public override void OnClose()
    {
    }

    [Token(Token = "0x60027F8")]
    [Address(RVA = "0x3671B2C", Offset = "0x3671B2C", VA = "0x3671B2C")]
    public StoryTerningPointConditionPopupContent()
    {
    }
  }
}
