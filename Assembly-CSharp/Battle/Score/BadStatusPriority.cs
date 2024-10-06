// Decompiled with JetBrains decompiler
// Type: Battle.Score.BadStatusPriority
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using MoonSharp.Interpreter;
using System.Collections.Generic;

#nullable disable
namespace Battle.Score
{
  [Token(Token = "0x200247B")]
  public class BadStatusPriority
  {
    [Token(Token = "0x4009C7A")]
    public const string ReadFromLuaSymbol = "BadStatusPriority";
    [Token(Token = "0x4009C7B")]
    [FieldOffset(Offset = "0x10")]
    public SortedList<BadStatusPriority.Param, int> List;

    [Token(Token = "0x600DFC0")]
    [Address(RVA = "0x201AC98", Offset = "0x201AC98", VA = "0x201AC98")]
    public BadStatusPriority(DynValue value)
    {
    }

    [Token(Token = "0x600DFC1")]
    [Address(RVA = "0x2020FF8", Offset = "0x2020FF8", VA = "0x2020FF8")]
    public int GetPriority(BattleBadStatusTypeEnum badStatus) => new int();

    [Token(Token = "0x200247C")]
    public class ParamComparer : IComparer<BadStatusPriority.Param>
    {
      [Token(Token = "0x600DFC2")]
      [Address(RVA = "0x202111C", Offset = "0x202111C", VA = "0x202111C", Slot = "4")]
      public int Compare(BadStatusPriority.Param a, BadStatusPriority.Param b) => new int();

      [Token(Token = "0x600DFC3")]
      [Address(RVA = "0x2020FC4", Offset = "0x2020FC4", VA = "0x2020FC4")]
      public ParamComparer()
      {
      }
    }

    [Token(Token = "0x200247D")]
    public class Param
    {
      [Token(Token = "0x17003001")]
      public BattleBadStatusTypeEnum BadStatus
      {
        [Token(Token = "0x600DFC4"), Address(RVA = "0x2021154", Offset = "0x2021154", VA = "0x2021154")] get
        {
          return new BattleBadStatusTypeEnum();
        }
        [Token(Token = "0x600DFC5"), Address(RVA = "0x202115C", Offset = "0x202115C", VA = "0x202115C")] private set
        {
        }
      }

      [Token(Token = "0x17003002")]
      public int Priority
      {
        [Token(Token = "0x600DFC6"), Address(RVA = "0x2021164", Offset = "0x2021164", VA = "0x2021164")] get
        {
          return new int();
        }
        [Token(Token = "0x600DFC7"), Address(RVA = "0x202116C", Offset = "0x202116C", VA = "0x202116C")] private set
        {
        }
      }

      [Token(Token = "0x600DFC8")]
      [Address(RVA = "0x2020FCC", Offset = "0x2020FCC", VA = "0x2020FCC")]
      public Param(BattleBadStatusTypeEnum badStatus, int priority)
      {
      }
    }
  }
}
