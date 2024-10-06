// Decompiled with JetBrains decompiler
// Type: StaqData.Sort.PersonalEmblemFilterUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.PlayerInfo.PlayerProfile;
using System.Collections.Generic;

#nullable disable
namespace StaqData.Sort
{
  [Token(Token = "0x2002191")]
  public class PersonalEmblemFilterUtility
  {
    [Token(Token = "0x600CD73")]
    [Address(RVA = "0x4B5A128", Offset = "0x4B5A128", VA = "0x4B5A128")]
    public static bool IsAnyFiltered() => new bool();

    [Token(Token = "0x600CD74")]
    [Address(RVA = "0x4B5A1B0", Offset = "0x4B5A1B0", VA = "0x4B5A1B0")]
    public static List<PersonalEmblemListItem.PersonalEmblemInfo> FilterEmblemList(
      List<PersonalEmblemListItem.PersonalEmblemInfo> list,
      PersonalEmblemFilterUtility.PersonalEmblemFilterCondition filterCondition,
      bool[] filter)
    {
      return (List<PersonalEmblemListItem.PersonalEmblemInfo>) null;
    }

    [Token(Token = "0x600CD75")]
    [Address(RVA = "0x4B5A1D0", Offset = "0x4B5A1D0", VA = "0x4B5A1D0")]
    private static List<PersonalEmblemListItem.PersonalEmblemInfo> FilteringCategory(
      List<PersonalEmblemListItem.PersonalEmblemInfo> list,
      bool[] filter)
    {
      return (List<PersonalEmblemListItem.PersonalEmblemInfo>) null;
    }

    [Token(Token = "0x600CD76")]
    [Address(RVA = "0x4B5A714", Offset = "0x4B5A714", VA = "0x4B5A714")]
    private static List<PersonalEmblemListItem.PersonalEmblemInfo> FilteringRarity(
      List<PersonalEmblemListItem.PersonalEmblemInfo> list,
      bool[] filter)
    {
      return (List<PersonalEmblemListItem.PersonalEmblemInfo>) null;
    }

    [Token(Token = "0x600CD77")]
    [Address(RVA = "0x4B5AB30", Offset = "0x4B5AB30", VA = "0x4B5AB30")]
    public PersonalEmblemFilterUtility()
    {
    }

    [Token(Token = "0x2002192")]
    public enum PersonalEmblemFilterCondition
    {
      [Token(Token = "0x4008E73")] Category,
      [Token(Token = "0x4008E74")] Rarity,
    }
  }
}
