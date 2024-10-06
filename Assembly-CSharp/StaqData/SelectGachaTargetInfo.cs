// Decompiled with JetBrains decompiler
// Type: StaqData.SelectGachaTargetInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002144")]
  public class SelectGachaTargetInfo
  {
    [Token(Token = "0x17002C95")]
    public int TargetId
    {
      [Token(Token = "0x600CBDF"), Address(RVA = "0x1BAA648", Offset = "0x1BAA648", VA = "0x1BAA648")] get
      {
        return new int();
      }
      [Token(Token = "0x600CBE0"), Address(RVA = "0x1BAA650", Offset = "0x1BAA650", VA = "0x1BAA650")] private set
      {
      }
    }

    [Token(Token = "0x17002C96")]
    public List<SelectGachaTargetDetailInfo> TargetOptions
    {
      [Token(Token = "0x600CBE1"), Address(RVA = "0x1BAA658", Offset = "0x1BAA658", VA = "0x1BAA658")] get
      {
        return (List<SelectGachaTargetDetailInfo>) null;
      }
      [Token(Token = "0x600CBE2"), Address(RVA = "0x1BAA660", Offset = "0x1BAA660", VA = "0x1BAA660")] private set
      {
      }
    }

    [Token(Token = "0x17002C97")]
    public int SelectedTargetOptionId
    {
      [Token(Token = "0x600CBE3"), Address(RVA = "0x1BAA668", Offset = "0x1BAA668", VA = "0x1BAA668")] get
      {
        return new int();
      }
      [Token(Token = "0x600CBE4"), Address(RVA = "0x1BAA670", Offset = "0x1BAA670", VA = "0x1BAA670")] private set
      {
      }
    }

    [Token(Token = "0x17002C98")]
    public int TargetCount
    {
      [Token(Token = "0x600CBE5"), Address(RVA = "0x1BAA678", Offset = "0x1BAA678", VA = "0x1BAA678")] get
      {
        return new int();
      }
      [Token(Token = "0x600CBE6"), Address(RVA = "0x1BAA680", Offset = "0x1BAA680", VA = "0x1BAA680")] private set
      {
      }
    }

    [Token(Token = "0x17002C99")]
    public int CurrentTargetCount
    {
      [Token(Token = "0x600CBE7"), Address(RVA = "0x1BAA688", Offset = "0x1BAA688", VA = "0x1BAA688")] get
      {
        return new int();
      }
      [Token(Token = "0x600CBE8"), Address(RVA = "0x1BAA690", Offset = "0x1BAA690", VA = "0x1BAA690")] private set
      {
      }
    }

    [Token(Token = "0x17002C9A")]
    public int CurrentTargetCountForDisplay
    {
      [Token(Token = "0x600CBE9"), Address(RVA = "0x1BAA698", Offset = "0x1BAA698", VA = "0x1BAA698")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002C9B")]
    public SelectGachaTargetDetailInfo SelectedGachaTargetDetailInfo
    {
      [Token(Token = "0x600CBEA"), Address(RVA = "0x1BAA6A4", Offset = "0x1BAA6A4", VA = "0x1BAA6A4")] get
      {
        return (SelectGachaTargetDetailInfo) null;
      }
      [Token(Token = "0x600CBEB"), Address(RVA = "0x1BAA6AC", Offset = "0x1BAA6AC", VA = "0x1BAA6AC")] private set
      {
      }
    }

    [Token(Token = "0x600CBEC")]
    [Address(RVA = "0x1BAA6B4", Offset = "0x1BAA6B4", VA = "0x1BAA6B4")]
    public static SelectGachaTargetInfo CreateFromServerData(G0001GachaTargetType serverData)
    {
      return (SelectGachaTargetInfo) null;
    }

    [Token(Token = "0x600CBED")]
    [Address(RVA = "0x1BA55D8", Offset = "0x1BA55D8", VA = "0x1BA55D8")]
    public static List<SelectGachaTargetInfo> CreateFromServerData(
      IEnumerable<G0001GachaTargetType> serverData)
    {
      return (List<SelectGachaTargetInfo>) null;
    }

    [Token(Token = "0x600CBEE")]
    [Address(RVA = "0x1BAA7FC", Offset = "0x1BAA7FC", VA = "0x1BAA7FC")]
    public SelectGachaTargetInfo()
    {
    }
  }
}
