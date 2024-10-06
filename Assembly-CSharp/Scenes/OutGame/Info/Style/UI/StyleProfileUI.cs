// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Style.UI.StyleProfileUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.Icon;
using Scenes.OutGame.Info.Common.UI;
using System;
using UI;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Info.Style.UI
{
  [Token(Token = "0x2003570")]
  [Serializable]
  public class StyleProfileUI
  {
    [Token(Token = "0x400E865")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private StyleRarityUI rarity;
    [Token(Token = "0x400E866")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GemListUI gemListUI;
    [Token(Token = "0x400E867")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CurrentMaxGaugeUI levelUI;
    [Token(Token = "0x400E868")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextAccessor characterName;
    [Token(Token = "0x400E869")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextAccessor styleName;
    [Token(Token = "0x400E86A")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextAccessor className;
    [Token(Token = "0x400E86B")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextAccessor groups;
    [Token(Token = "0x400E86C")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private TypeIcon elementIcon;
    [Token(Token = "0x400E86D")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private IconUI classIcon;
    [Token(Token = "0x400E86E")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private IconUI typeIcon;
    [Token(Token = "0x400E86F")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private IconUI speciesIcon;
    [Token(Token = "0x400E870")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private IconUI killersIcon;

    [Token(Token = "0x6014F9B")]
    [Address(RVA = "0x4AA0B40", Offset = "0x4AA0B40", VA = "0x4AA0B40")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6014F9C")]
    [Address(RVA = "0x4A9DAAC", Offset = "0x4A9DAAC", VA = "0x4A9DAAC")]
    public void SetRarity(int rarity)
    {
    }

    [Token(Token = "0x6014F9D")]
    [Address(RVA = "0x4A9DADC", Offset = "0x4A9DADC", VA = "0x4A9DADC")]
    public void SetLevel(int current, int max)
    {
    }

    [Token(Token = "0x6014F9E")]
    [Address(RVA = "0x4A9DB84", Offset = "0x4A9DB84", VA = "0x4A9DB84")]
    public void SetLimitBreak(int current, int max)
    {
    }

    [Token(Token = "0x6014F9F")]
    [Address(RVA = "0x4A9DBC4", Offset = "0x4A9DBC4", VA = "0x4A9DBC4")]
    public void SetCharacterName(string name, bool isUniqueName)
    {
    }

    [Token(Token = "0x6014FA0")]
    [Address(RVA = "0x4A9DC9C", Offset = "0x4A9DC9C", VA = "0x4A9DC9C")]
    public void SetStyleName(string name)
    {
    }

    [Token(Token = "0x6014FA1")]
    [Address(RVA = "0x4A9DD54", Offset = "0x4A9DD54", VA = "0x4A9DD54")]
    public void SetClassName(string name)
    {
    }

    [Token(Token = "0x6014FA2")]
    [Address(RVA = "0x4A9DF1C", Offset = "0x4A9DF1C", VA = "0x4A9DF1C")]
    public void SetGroup(string[] texts)
    {
    }

    [Token(Token = "0x6014FA3")]
    [Address(RVA = "0x4AA0D58", Offset = "0x4AA0D58", VA = "0x4AA0D58")]
    public IconUI GetClassIcon() => (IconUI) null;

    [Token(Token = "0x6014FA4")]
    [Address(RVA = "0x4A9E578", Offset = "0x4A9E578", VA = "0x4A9E578")]
    public IconUI CreateTypeIcon() => (IconUI) null;

    [Token(Token = "0x6014FA5")]
    [Address(RVA = "0x4A9E594", Offset = "0x4A9E594", VA = "0x4A9E594")]
    public IconUI CreateSpeciesIcon() => (IconUI) null;

    [Token(Token = "0x6014FA6")]
    [Address(RVA = "0x4AA0D60", Offset = "0x4AA0D60", VA = "0x4AA0D60")]
    public IconUI GetKillersIcon() => (IconUI) null;

    [Token(Token = "0x6014FA7")]
    [Address(RVA = "0x4A9DE0C", Offset = "0x4A9DE0C", VA = "0x4A9DE0C")]
    public void SetElementIcon(ElementTypeEnum element)
    {
    }

    [Token(Token = "0x6014FA8")]
    [Address(RVA = "0x4AA0D68", Offset = "0x4AA0D68", VA = "0x4AA0D68")]
    public StyleProfileUI()
    {
    }
  }
}
