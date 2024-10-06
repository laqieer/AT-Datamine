// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Skill.UI.SkillIconList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Info.Skill.UI
{
  [Token(Token = "0x2003587")]
  [Serializable]
  public class SkillIconList
  {
    [Token(Token = "0x400E8AB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private SkillIconSub skillIconSub;
    [Token(Token = "0x400E8AC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject noneObj;
    [Token(Token = "0x400E8AD")]
    [FieldOffset(Offset = "0x20")]
    private List<SkillIconSub> instances;

    [Token(Token = "0x6015048")]
    [Address(RVA = "0x4AA6A84", Offset = "0x4AA6A84", VA = "0x4AA6A84")]
    public void ResetList()
    {
    }

    [Token(Token = "0x6015049")]
    [Address(RVA = "0x4AA6C68", Offset = "0x4AA6C68", VA = "0x4AA6C68")]
    public void SetNone(bool isActive)
    {
    }

    [Token(Token = "0x601504A")]
    [Address(RVA = "0x4AA43A8", Offset = "0x4AA43A8", VA = "0x4AA43A8")]
    public SkillIconSub CreateInstance() => (SkillIconSub) null;

    [Token(Token = "0x601504B")]
    [Address(RVA = "0x4AA6CFC", Offset = "0x4AA6CFC", VA = "0x4AA6CFC")]
    public SkillIconList()
    {
    }
  }
}
