// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Skill.UI.SkillCategoryUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Info.Skill.UI
{
  [Token(Token = "0x2003586")]
  [Serializable]
  public class SkillCategoryUI
  {
    [Token(Token = "0x400E8A9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private CustomSkillTypeIcon icon;
    [Token(Token = "0x400E8AA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text title;

    [Token(Token = "0x6015045")]
    [Address(RVA = "0x4AA6A3C", Offset = "0x4AA6A3C", VA = "0x4AA6A3C")]
    public void SetTitle(string title)
    {
    }

    [Token(Token = "0x6015046")]
    [Address(RVA = "0x4AA6A60", Offset = "0x4AA6A60", VA = "0x4AA6A60")]
    public void SetIcon(SkillTypeEnum skillType)
    {
    }

    [Token(Token = "0x6015047")]
    [Address(RVA = "0x4AA6A7C", Offset = "0x4AA6A7C", VA = "0x4AA6A7C")]
    public SkillCategoryUI()
    {
    }
  }
}
