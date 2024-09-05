// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Skill.UI.SkillInfoTitleUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Info.Skill.UI
{
  [Token(Token = "0x2003589")]
  public class SkillInfoTitleUI : MonoBehaviour
  {
    [Token(Token = "0x400E8B3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CustomSkillIcon skillIcon;
    [Token(Token = "0x400E8B4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text title;
    [Token(Token = "0x400E8B5")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text level;
    [Token(Token = "0x400E8B6")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private SkillIconList iconList;

    [Token(Token = "0x6015053")]
    [Address(RVA = "0x4AA6DE0", Offset = "0x4AA6DE0", VA = "0x4AA6DE0")]
    public void SetSkillIcon(Sprite sprite)
    {
    }

    [Token(Token = "0x6015054")]
    [Address(RVA = "0x4AA6E78", Offset = "0x4AA6E78", VA = "0x4AA6E78")]
    public void SetTitle(string title)
    {
    }

    [Token(Token = "0x6015055")]
    [Address(RVA = "0x4AA6F18", Offset = "0x4AA6F18", VA = "0x4AA6F18")]
    public void SetLevel(int level)
    {
    }

    [Token(Token = "0x6015056")]
    [Address(RVA = "0x4AA6FBC", Offset = "0x4AA6FBC", VA = "0x4AA6FBC")]
    public void SetLevelNothing()
    {
    }

    [Token(Token = "0x6015057")]
    [Address(RVA = "0x4AA7060", Offset = "0x4AA7060", VA = "0x4AA7060")]
    public void SetRarityBaseImage(Sprite baseImage)
    {
    }

    [Token(Token = "0x6015058")]
    [Address(RVA = "0x4AA70F8", Offset = "0x4AA70F8", VA = "0x4AA70F8")]
    public void ResetSubIcon()
    {
    }

    [Token(Token = "0x6015059")]
    [Address(RVA = "0x4AA7108", Offset = "0x4AA7108", VA = "0x4AA7108")]
    public void SetSubIconNone(bool isActive)
    {
    }

    [Token(Token = "0x601505A")]
    [Address(RVA = "0x4AA711C", Offset = "0x4AA711C", VA = "0x4AA711C")]
    public void AddSubIcon(Sprite icon, SkillIconSub.BgColor bgColor)
    {
    }

    [Token(Token = "0x601505B")]
    [Address(RVA = "0x4AA7168", Offset = "0x4AA7168", VA = "0x4AA7168")]
    public SkillInfoTitleUI()
    {
    }
  }
}
