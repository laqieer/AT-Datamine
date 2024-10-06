// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.SkillIconSub
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x20039C9")]
  public class SkillIconSub : MonoBehaviour
  {
    [Token(Token = "0x400FCA4")]
    public const string TweenGroupId_Color_Normal = "Color_Normal";
    [Token(Token = "0x400FCA5")]
    public const string TweenGroupId_Color_StatusEffect = "Color_StatusEffect";
    [Token(Token = "0x400FCA6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject root;
    [Token(Token = "0x400FCA7")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject Img_Bg_Diamond;
    [Token(Token = "0x400FCA8")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject Img_Bg_Square;
    [Token(Token = "0x400FCA9")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image Img_Icon;
    [Token(Token = "0x400FCAA")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private UITweenGroup tweenGroup;

    [Token(Token = "0x17004AA3")]
    public Image IconImage
    {
      [Token(Token = "0x6016B16"), Address(RVA = "0x3F67BAC", Offset = "0x3F67BAC", VA = "0x3F67BAC")] get
      {
        return (Image) null;
      }
      [Token(Token = "0x6016B17"), Address(RVA = "0x3F67BB4", Offset = "0x3F67BB4", VA = "0x3F67BB4")] set
      {
      }
    }

    [Token(Token = "0x17004AA4")]
    public GameObject Root
    {
      [Token(Token = "0x6016B18"), Address(RVA = "0x3F67BBC", Offset = "0x3F67BBC", VA = "0x3F67BBC")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x6016B19")]
    [Address(RVA = "0x3F67660", Offset = "0x3F67660", VA = "0x3F67660")]
    public void SetSprite(Sprite sprite, SkillIconSub.Bg bg, SkillIconSub.BgColor bgColor)
    {
    }

    [Token(Token = "0x6016B1A")]
    [Address(RVA = "0x3F67C3C", Offset = "0x3F67C3C", VA = "0x3F67C3C")]
    private void SetBg(SkillIconSub.Bg bg)
    {
    }

    [Token(Token = "0x6016B1B")]
    [Address(RVA = "0x3F67CC4", Offset = "0x3F67CC4", VA = "0x3F67CC4")]
    private void SetBgColor(SkillIconSub.BgColor bgColor)
    {
    }

    [Token(Token = "0x6016B1C")]
    [Address(RVA = "0x3F67D80", Offset = "0x3F67D80", VA = "0x3F67D80")]
    public SkillIconSub()
    {
    }

    [Token(Token = "0x20039CA")]
    public enum Bg
    {
      [Token(Token = "0x400FCAC")] NONE,
      [Token(Token = "0x400FCAD")] DIAMOND,
      [Token(Token = "0x400FCAE")] SQUARE,
    }

    [Token(Token = "0x20039CB")]
    public enum BgColor
    {
      [Token(Token = "0x400FCB0")] NORMAL,
      [Token(Token = "0x400FCB1")] STATUS_EFFECT,
    }
  }
}
