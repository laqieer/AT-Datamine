// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Equipment.UI.EquipmentTitleUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.Info.Skill.UI;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Info.Equipment.UI
{
  [Token(Token = "0x20035B8")]
  [Serializable]
  public class EquipmentTitleUI
  {
    [Token(Token = "0x400E9C5")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text title;
    [Token(Token = "0x400E9C6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private IconUI icon;

    [Token(Token = "0x6015252")]
    [Address(RVA = "0x4AAC488", Offset = "0x4AAC488", VA = "0x4AAC488")]
    public void SetText(string title)
    {
    }

    [Token(Token = "0x6015253")]
    [Address(RVA = "0x4AAE104", Offset = "0x4AAE104", VA = "0x4AAE104")]
    public void SetRarityIcon(Sprite sprite)
    {
    }

    [Token(Token = "0x6015254")]
    [Address(RVA = "0x4AAE120", Offset = "0x4AAE120", VA = "0x4AAE120")]
    public EquipmentTitleUI()
    {
    }

    [Token(Token = "0x20035B9")]
    [Serializable]
    public class WithCustomSkillInfo
    {
      [Token(Token = "0x400E9C7")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private GameObject root;
      [Token(Token = "0x400E9C8")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      private Text level;
      [Token(Token = "0x400E9C9")]
      [FieldOffset(Offset = "0x20")]
      [SerializeField]
      private SkillIconList skillIconList;

      [Token(Token = "0x6015255")]
      [Address(RVA = "0x4AA4348", Offset = "0x4AA4348", VA = "0x4AA4348")]
      public void SetLevel(int value)
      {
      }

      [Token(Token = "0x6015256")]
      [Address(RVA = "0x4AAE128", Offset = "0x4AAE128", VA = "0x4AAE128")]
      public SkillIconList GetSkillIconList() => (SkillIconList) null;

      [Token(Token = "0x6015257")]
      [Address(RVA = "0x4AAE130", Offset = "0x4AAE130", VA = "0x4AAE130")]
      public WithCustomSkillInfo()
      {
      }
    }
  }
}
