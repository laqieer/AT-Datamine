// Decompiled with JetBrains decompiler
// Type: Story.Chart.UI.StoryConditionPopupContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Story.Chart.UI
{
  [Token(Token = "0x2000714")]
  public class StoryConditionPopupContent : Popup.Content
  {
    [Token(Token = "0x40020EB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private StoryConditionUI conditionUI;
    [Token(Token = "0x40020EC")]
    [FieldOffset(Offset = "0x20")]
    private int count;
    [Token(Token = "0x40020ED")]
    [FieldOffset(Offset = "0x28")]
    private List<StoryConditionUI> conditions;

    [Token(Token = "0x60027EC")]
    [Address(RVA = "0x36713A8", Offset = "0x36713A8", VA = "0x36713A8")]
    public StoryConditionUI Duplicate() => (StoryConditionUI) null;

    [Token(Token = "0x60027ED")]
    [Address(RVA = "0x36715B0", Offset = "0x36715B0", VA = "0x36715B0", Slot = "4")]
    public override void OnClose()
    {
    }

    [Token(Token = "0x60027EE")]
    [Address(RVA = "0x36716F0", Offset = "0x36716F0", VA = "0x36716F0")]
    public StoryConditionPopupContent()
    {
    }
  }
}
