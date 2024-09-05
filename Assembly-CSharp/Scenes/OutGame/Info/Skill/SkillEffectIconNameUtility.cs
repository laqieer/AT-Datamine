// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Skill.SkillEffectIconNameUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using System;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.Info.Skill
{
  [Token(Token = "0x2003573")]
  public static class SkillEffectIconNameUtility
  {
    [Token(Token = "0x400E874")]
    public const string ASSETBUNDLE_NAME = "";
    [Token(Token = "0x400E875")]
    [FieldOffset(Offset = "0x0")]
    private static Func<EffectDetailData, string> defaultIDFunc;
    [Token(Token = "0x400E876")]
    [FieldOffset(Offset = "0x8")]
    private static Dictionary<BattleEffectTypeEnum, Func<EffectDetailData, string>> toAssetIDs;

    [Token(Token = "0x6014FAE")]
    [Address(RVA = "0x4AA0D80", Offset = "0x4AA0D80", VA = "0x4AA0D80")]
    public static string[] Get(int skillID, int level) => (string[]) null;

    [Token(Token = "0x6014FAF")]
    [Address(RVA = "0x4AA1190", Offset = "0x4AA1190", VA = "0x4AA1190")]
    public static SkillEffectIconNameUtility.SkillEffectIconData[] GetIconData(
      int skillID,
      int level)
    {
      return (SkillEffectIconNameUtility.SkillEffectIconData[]) null;
    }

    [Token(Token = "0x6014FB0")]
    [Address(RVA = "0x4AA15D0", Offset = "0x4AA15D0", VA = "0x4AA15D0")]
    static SkillEffectIconNameUtility()
    {
    }

    [Token(Token = "0x2003574")]
    public struct SkillEffectIconData
    {
      [Token(Token = "0x400E877")]
      [FieldOffset(Offset = "0x0")]
      public string IconName;
      [Token(Token = "0x400E878")]
      [FieldOffset(Offset = "0x8")]
      public bool IsBadStatus;

      [Token(Token = "0x17004592")]
      public SkillIconSub.BgColor BgColor
      {
        [Token(Token = "0x6014FB1"), Address(RVA = "0x4AA16E8", Offset = "0x4AA16E8", VA = "0x4AA16E8")] get
        {
          return new SkillIconSub.BgColor();
        }
      }
    }
  }
}
