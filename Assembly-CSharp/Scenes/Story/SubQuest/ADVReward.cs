// Decompiled with JetBrains decompiler
// Type: Scenes.Story.SubQuest.ADVReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using GameCore.UIControls;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.SubQuest
{
  [Token(Token = "0x2002D85")]
  public class ADVReward : MonoBehaviour
  {
    [Token(Token = "0x400C379")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button button;
    [Token(Token = "0x400C37A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text textItemName;
    [Token(Token = "0x400C37B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text textItemAmount;
    [Token(Token = "0x400C37C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ItemIcon itemIcon;
    [Token(Token = "0x400C37D")]
    [FieldOffset(Offset = "0x38")]
    private Func<string> itemFormat;
    [Token(Token = "0x400C37E")]
    [FieldOffset(Offset = "0x40")]
    private UITweenGroup tween;

    [Token(Token = "0x17003CC5")]
    public bool IsPlaying
    {
      [Token(Token = "0x6011CB4"), Address(RVA = "0x3F9D5AC", Offset = "0x3F9D5AC", VA = "0x3F9D5AC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003CC6")]
    public bool Clicked
    {
      [Token(Token = "0x6011CB5"), Address(RVA = "0x3F9D5C8", Offset = "0x3F9D5C8", VA = "0x3F9D5C8")] get
      {
        return new bool();
      }
      [Token(Token = "0x6011CB6"), Address(RVA = "0x3F9D5D0", Offset = "0x3F9D5D0", VA = "0x3F9D5D0")] private set
      {
      }
    }

    [Token(Token = "0x6011CB7")]
    [Address(RVA = "0x3F9D5DC", Offset = "0x3F9D5DC", VA = "0x3F9D5DC")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6011CB8")]
    [Address(RVA = "0x3F9D694", Offset = "0x3F9D694", VA = "0x3F9D694")]
    public void Set(string name, int amount, Sprite sprite)
    {
    }

    [Token(Token = "0x6011CB9")]
    [Address(RVA = "0x3F9D7A8", Offset = "0x3F9D7A8", VA = "0x3F9D7A8")]
    public void In()
    {
    }

    [Token(Token = "0x6011CBA")]
    [Address(RVA = "0x3F9D804", Offset = "0x3F9D804", VA = "0x3F9D804")]
    public void Out()
    {
    }

    [Token(Token = "0x6011CBB")]
    [Address(RVA = "0x3F9D85C", Offset = "0x3F9D85C", VA = "0x3F9D85C")]
    private void ClickEvent()
    {
    }

    [Token(Token = "0x6011CBC")]
    [Address(RVA = "0x3F9D868", Offset = "0x3F9D868", VA = "0x3F9D868")]
    public ADVReward()
    {
    }

    [Token(Token = "0x2002D86")]
    private static class TweenAnimationNames
    {
      [Token(Token = "0x400C380")]
      public const string In = "Reward_In";
      [Token(Token = "0x400C381")]
      public const string Out = "Reward_Out";
    }
  }
}
