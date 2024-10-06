// Decompiled with JetBrains decompiler
// Type: UI.ItemDetail.ItemUsageUtil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace UI.ItemDetail
{
  [Token(Token = "0x20008E6")]
  public static class ItemUsageUtil
  {
    [Token(Token = "0x600326F")]
    [Address(RVA = "0x3C1849C", Offset = "0x3C1849C", VA = "0x3C1849C")]
    public static string[] GetUsageNames(int itemId, ItemTypeEnum itemType) => (string[]) null;

    [Token(Token = "0x20008E7")]
    private enum Usage
    {
      [Token(Token = "0x40029B6")] None,
      [Token(Token = "0x40029B7")] LvUp,
      [Token(Token = "0x40029B8")] AbillityBoard,
      [Token(Token = "0x40029B9")] OptionChoose,
      [Token(Token = "0x40029BA")] SkillLvUp,
      [Token(Token = "0x40029BB")] LpRecovery,
      [Token(Token = "0x40029BC")] LimitBreak,
      [Token(Token = "0x40029BD")] SpecialReincarnation,
    }
  }
}
