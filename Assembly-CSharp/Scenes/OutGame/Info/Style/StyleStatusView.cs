// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Style.StyleStatusView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.Info.Equipment.UI;
using Scenes.OutGame.Info.Style.UI;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Info.Style
{
  [Token(Token = "0x200355E")]
  public class StyleStatusView
  {
    [Token(Token = "0x400E818")]
    [FieldOffset(Offset = "0x20")]
    private List<IconUI> typeIconInstances;
    [Token(Token = "0x400E819")]
    [FieldOffset(Offset = "0x28")]
    private List<IconUI> speciesIconInstances;

    [Token(Token = "0x17004589")]
    public StyleProfileUI StyleProfileUI
    {
      [Token(Token = "0x6014F2C"), Address(RVA = "0x4A9DA8C", Offset = "0x4A9DA8C", VA = "0x4A9DA8C")] private get
      {
        return (StyleProfileUI) null;
      }
      [Token(Token = "0x6014F2D"), Address(RVA = "0x4A9DA94", Offset = "0x4A9DA94", VA = "0x4A9DA94")] set
      {
      }
    }

    [Token(Token = "0x1700458A")]
    public EquipmentFlavorUI FlavorUI
    {
      [Token(Token = "0x6014F2E"), Address(RVA = "0x4A9DA9C", Offset = "0x4A9DA9C", VA = "0x4A9DA9C")] private get
      {
        return (EquipmentFlavorUI) null;
      }
      [Token(Token = "0x6014F2F"), Address(RVA = "0x4A9DAA4", Offset = "0x4A9DAA4", VA = "0x4A9DAA4")] set
      {
      }
    }

    [Token(Token = "0x6014F30")]
    [Address(RVA = "0x4A9CF00", Offset = "0x4A9CF00", VA = "0x4A9CF00")]
    public void SetReset()
    {
    }

    [Token(Token = "0x6014F31")]
    [Address(RVA = "0x4A9D2B4", Offset = "0x4A9D2B4", VA = "0x4A9D2B4")]
    public void SetRarityStarCount(int rarity)
    {
    }

    [Token(Token = "0x6014F32")]
    [Address(RVA = "0x4A9DAC4", Offset = "0x4A9DAC4", VA = "0x4A9DAC4")]
    public void SetLevel(int level, int max)
    {
    }

    [Token(Token = "0x6014F33")]
    [Address(RVA = "0x4A9D2D4", Offset = "0x4A9D2D4", VA = "0x4A9D2D4")]
    public void SetLimitBreak(int current, int max)
    {
    }

    [Token(Token = "0x6014F34")]
    [Address(RVA = "0x4A9D2EC", Offset = "0x4A9D2EC", VA = "0x4A9D2EC")]
    public void SetCharacterName(string name, bool isUniqueName)
    {
    }

    [Token(Token = "0x6014F35")]
    [Address(RVA = "0x4A9D308", Offset = "0x4A9D308", VA = "0x4A9D308")]
    public void SetStyleName(string name)
    {
    }

    [Token(Token = "0x6014F36")]
    [Address(RVA = "0x4A9D320", Offset = "0x4A9D320", VA = "0x4A9D320")]
    public void SetClassName(string name)
    {
    }

    [Token(Token = "0x6014F37")]
    [Address(RVA = "0x4A9D0BC", Offset = "0x4A9D0BC", VA = "0x4A9D0BC")]
    public void SetElementIcon(ElementTypeEnum element)
    {
    }

    [Token(Token = "0x6014F38")]
    [Address(RVA = "0x4A9DF04", Offset = "0x4A9DF04", VA = "0x4A9DF04")]
    public void SetGroup(string[] groups)
    {
    }

    [Token(Token = "0x6014F39")]
    [Address(RVA = "0x4A9D098", Offset = "0x4A9D098", VA = "0x4A9D098")]
    public void SetClassIcon(Sprite sprite)
    {
    }

    [Token(Token = "0x6014F3A")]
    [Address(RVA = "0x4A9D0D4", Offset = "0x4A9D0D4", VA = "0x4A9D0D4")]
    public IconUI AddTypeIcon(Sprite sprite) => (IconUI) null;

    [Token(Token = "0x6014F3B")]
    [Address(RVA = "0x4A9D130", Offset = "0x4A9D130", VA = "0x4A9D130")]
    public IconUI AddTypeIconEmpty() => (IconUI) null;

    [Token(Token = "0x6014F3C")]
    [Address(RVA = "0x4A9D180", Offset = "0x4A9D180", VA = "0x4A9D180")]
    public IconUI AddSpeciesTypeIcon(Sprite sprite) => (IconUI) null;

    [Token(Token = "0x6014F3D")]
    [Address(RVA = "0x4A9D1B8", Offset = "0x4A9D1B8", VA = "0x4A9D1B8")]
    public IconUI AddSpeciesTypeIconEmpty() => (IconUI) null;

    [Token(Token = "0x6014F3E")]
    [Address(RVA = "0x4A9D208", Offset = "0x4A9D208", VA = "0x4A9D208")]
    public void SetKillersIcon(Sprite sprite)
    {
    }

    [Token(Token = "0x6014F3F")]
    [Address(RVA = "0x4A9D264", Offset = "0x4A9D264", VA = "0x4A9D264")]
    public void SetKillersEmpty()
    {
    }

    [Token(Token = "0x6014F40")]
    [Address(RVA = "0x4A9D338", Offset = "0x4A9D338", VA = "0x4A9D338")]
    public void SetFlavor(string text)
    {
    }

    [Token(Token = "0x6014F41")]
    [Address(RVA = "0x4A9E0C4", Offset = "0x4A9E0C4", VA = "0x4A9E0C4")]
    private IconUI GetTypeIcon() => (IconUI) null;

    [Token(Token = "0x6014F42")]
    [Address(RVA = "0x4A9E30C", Offset = "0x4A9E30C", VA = "0x4A9E30C")]
    private IconUI GetSpeciesIcon() => (IconUI) null;

    [Token(Token = "0x6014F43")]
    [Address(RVA = "0x4A9E5B0", Offset = "0x4A9E5B0", VA = "0x4A9E5B0")]
    public StyleStatusView()
    {
    }
  }
}
