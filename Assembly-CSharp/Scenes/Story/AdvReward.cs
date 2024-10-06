// Decompiled with JetBrains decompiler
// Type: Scenes.Story.AdvReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using GameCore.UIControls;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story
{
  [Token(Token = "0x2002D66")]
  public class AdvReward : MonoBehaviour
  {
    [Token(Token = "0x400C2D1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button button;
    [Token(Token = "0x400C2D2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text textItemName;
    [Token(Token = "0x400C2D3")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text textItemAmount;
    [Token(Token = "0x400C2D4")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ItemIcon itemIcon;
    [Token(Token = "0x400C2D5")]
    [FieldOffset(Offset = "0x38")]
    private UITweenGroup tween;

    [Token(Token = "0x17003C99")]
    public bool IsPlaying
    {
      [Token(Token = "0x6011BDF"), Address(RVA = "0x42BBCA4", Offset = "0x42BBCA4", VA = "0x42BBCA4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003C9A")]
    public bool Clicked
    {
      [Token(Token = "0x6011BE0"), Address(RVA = "0x42BC4D8", Offset = "0x42BC4D8", VA = "0x42BC4D8")] get
      {
        return new bool();
      }
      [Token(Token = "0x6011BE1"), Address(RVA = "0x42BC4E0", Offset = "0x42BC4E0", VA = "0x42BC4E0")] private set
      {
      }
    }

    [Token(Token = "0x6011BE2")]
    [Address(RVA = "0x42BC3D0", Offset = "0x42BC3D0", VA = "0x42BC3D0")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6011BE3")]
    [Address(RVA = "0x42BB9B0", Offset = "0x42BB9B0", VA = "0x42BB9B0")]
    public void Set(string name, int amount, Sprite sprite)
    {
    }

    [Token(Token = "0x6011BE4")]
    [Address(RVA = "0x42BC08C", Offset = "0x42BC08C", VA = "0x42BC08C")]
    public void In()
    {
    }

    [Token(Token = "0x6011BE5")]
    [Address(RVA = "0x42BC0E8", Offset = "0x42BC0E8", VA = "0x42BC0E8")]
    public void Out()
    {
    }

    [Token(Token = "0x6011BE6")]
    [Address(RVA = "0x42BC4EC", Offset = "0x42BC4EC", VA = "0x42BC4EC")]
    private void ClickEvent()
    {
    }

    [Token(Token = "0x6011BE7")]
    [Address(RVA = "0x42BC4F8", Offset = "0x42BC4F8", VA = "0x42BC4F8")]
    public AdvReward()
    {
    }

    [Token(Token = "0x2002D67")]
    private static class TweenAnimationNames
    {
      [Token(Token = "0x400C2D7")]
      public const string In = "Reward_In";
      [Token(Token = "0x400C2D8")]
      public const string Out = "Reward_Out";
    }
  }
}
