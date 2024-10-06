// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.SkillIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Battle
{
  [Token(Token = "0x2003785")]
  public sealed class SkillIcon : MonoBehaviour
  {
    [Token(Token = "0x400F27F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameCore.UIControls.SkillIcon icon;
    [Token(Token = "0x400F280")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Slider expSlider;

    [Token(Token = "0x17004865")]
    public GameCore.UIControls.SkillIcon Icon
    {
      [Token(Token = "0x6015DDF"), Address(RVA = "0x231EBF0", Offset = "0x231EBF0", VA = "0x231EBF0")] get
      {
        return (GameCore.UIControls.SkillIcon) null;
      }
    }

    [Token(Token = "0x6015DE0")]
    [Address(RVA = "0x231EBF8", Offset = "0x231EBF8", VA = "0x231EBF8")]
    public void SetExpSlider(float value)
    {
    }

    [Token(Token = "0x6015DE1")]
    [Address(RVA = "0x231EC1C", Offset = "0x231EC1C", VA = "0x231EC1C")]
    public SkillIcon()
    {
    }
  }
}
