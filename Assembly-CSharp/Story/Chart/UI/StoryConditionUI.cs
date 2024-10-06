// Decompiled with JetBrains decompiler
// Type: Story.Chart.UI.StoryConditionUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using UI;
using UnityEngine;

#nullable disable
namespace Story.Chart.UI
{
  [Token(Token = "0x2000716")]
  public class StoryConditionUI : MonoBehaviour
  {
    [Token(Token = "0x40020F0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextAccessor title;
    [Token(Token = "0x40020F1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextAccessor description;
    [Token(Token = "0x40020F2")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private StyleThumb thumb;

    [Token(Token = "0x60027F2")]
    [Address(RVA = "0x3671508", Offset = "0x3671508", VA = "0x3671508")]
    public void SetTitleNumber(int number)
    {
    }

    [Token(Token = "0x60027F3")]
    [Address(RVA = "0x367184C", Offset = "0x367184C", VA = "0x367184C")]
    public void SetText(string text)
    {
    }

    [Token(Token = "0x60027F4")]
    [Address(RVA = "0x3671868", Offset = "0x3671868", VA = "0x3671868")]
    public void SetStyle(Sprite sprite)
    {
    }

    [Token(Token = "0x60027F5")]
    [Address(RVA = "0x3671884", Offset = "0x3671884", VA = "0x3671884")]
    public StoryConditionUI()
    {
    }
  }
}
