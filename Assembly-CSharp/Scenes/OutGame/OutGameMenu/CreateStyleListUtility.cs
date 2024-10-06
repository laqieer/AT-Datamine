// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.CreateStyleListUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003ACC")]
  public class CreateStyleListUtility
  {
    [Token(Token = "0x601721B")]
    [Address(RVA = "0x300973C", Offset = "0x300973C", VA = "0x300973C")]
    public static List<Style> GetStyleList() => (List<Style>) null;

    [Token(Token = "0x601721C")]
    [Address(RVA = "0x3009BE4", Offset = "0x3009BE4", VA = "0x3009BE4")]
    public static List<Style> GetPossessionStyleList() => (List<Style>) null;

    [Token(Token = "0x601721D")]
    [Address(RVA = "0x300A014", Offset = "0x300A014", VA = "0x300A014")]
    public static List<Style> GetNotPossessionStyleList() => (List<Style>) null;

    [Token(Token = "0x601721E")]
    [Address(RVA = "0x300A468", Offset = "0x300A468", VA = "0x300A468")]
    public static List<Style> GetSpecificCharaStyleList(int charaId) => (List<Style>) null;

    [Token(Token = "0x601721F")]
    [Address(RVA = "0x300A924", Offset = "0x300A924", VA = "0x300A924")]
    public static List<Style> GetPossessionSpecificCharaStyleList(int charaId)
    {
      return (List<Style>) null;
    }

    [Token(Token = "0x6017220")]
    [Address(RVA = "0x300AD74", Offset = "0x300AD74", VA = "0x300AD74")]
    public static List<Style> GetNotPossessionSpecificCharaStyleList(int charaId)
    {
      return (List<Style>) null;
    }

    [Token(Token = "0x6017221")]
    [Address(RVA = "0x300B1DC", Offset = "0x300B1DC", VA = "0x300B1DC")]
    public static List<Style> GetTempSpecificCharaStyleList(List<int> charaIds)
    {
      return (List<Style>) null;
    }

    [Token(Token = "0x6017222")]
    [Address(RVA = "0x300B520", Offset = "0x300B520", VA = "0x300B520")]
    public static List<int> GetOrganizationStyleIds() => (List<int>) null;

    [Token(Token = "0x6017223")]
    [Address(RVA = "0x300BB78", Offset = "0x300BB78", VA = "0x300BB78")]
    public CreateStyleListUtility()
    {
    }
  }
}
