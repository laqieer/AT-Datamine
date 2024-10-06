// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Skill.UI.SkillListUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Info.Skill.UI
{
  [Token(Token = "0x200358F")]
  public class SkillListUI : MonoBehaviour
  {
    [Token(Token = "0x400E8D9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SkillListCategoryUI categoryUI;
    [Token(Token = "0x400E8DA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private DetailSkillListThumb elementUI;
    [Token(Token = "0x400E8DB")]
    [FieldOffset(Offset = "0x28")]
    private List<SkillListCategoryUI> categories;
    [Token(Token = "0x400E8DC")]
    [FieldOffset(Offset = "0x30")]
    private List<DetailSkillListThumb> elements;

    [Token(Token = "0x6015087")]
    [Address(RVA = "0x4A9D40C", Offset = "0x4A9D40C", VA = "0x4A9D40C")]
    public void Reset()
    {
    }

    [Token(Token = "0x6015088")]
    [Address(RVA = "0x4AA83B8", Offset = "0x4AA83B8", VA = "0x4AA83B8")]
    public SkillListCategoryUI GetCategoryInstance() => (SkillListCategoryUI) null;

    [Token(Token = "0x6015089")]
    [Address(RVA = "0x4AA857C", Offset = "0x4AA857C", VA = "0x4AA857C")]
    public SkillListCategoryUI CreateCategoryInstance() => (SkillListCategoryUI) null;

    [Token(Token = "0x601508A")]
    [Address(RVA = "0x4A9D888", Offset = "0x4A9D888", VA = "0x4A9D888")]
    public DetailSkillListThumb GetElementInstance() => (DetailSkillListThumb) null;

    [Token(Token = "0x601508B")]
    [Address(RVA = "0x4AA86AC", Offset = "0x4AA86AC", VA = "0x4AA86AC")]
    public DetailSkillListThumb CreateElementInstance() => (DetailSkillListThumb) null;

    [Token(Token = "0x601508C")]
    [Address(RVA = "0x4AA87DC", Offset = "0x4AA87DC", VA = "0x4AA87DC")]
    public SkillListUI()
    {
    }
  }
}
