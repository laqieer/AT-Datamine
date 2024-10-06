// Decompiled with JetBrains decompiler
// Type: Battle.Data.CompositeRangeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x200270C")]
  public sealed class CompositeRangeData : IBasicRangeData
  {
    [Token(Token = "0x400A70A")]
    [FieldOffset(Offset = "0x20")]
    private readonly List<(int x, int y)> defaultPositions;
    [Token(Token = "0x400A70B")]
    [FieldOffset(Offset = "0x28")]
    private readonly List<int> defaultFlags;

    [Token(Token = "0x17003379")]
    public int defaultMinX
    {
      [Token(Token = "0x600F23A"), Address(RVA = "0x41B4944", Offset = "0x41B4944", VA = "0x41B4944", Slot = "9")] get
      {
        return new int();
      }
      [Token(Token = "0x600F23B"), Address(RVA = "0x41B494C", Offset = "0x41B494C", VA = "0x41B494C")] private set
      {
      }
    }

    [Token(Token = "0x1700337A")]
    public int defaultMaxX
    {
      [Token(Token = "0x600F23C"), Address(RVA = "0x41B4954", Offset = "0x41B4954", VA = "0x41B4954", Slot = "10")] get
      {
        return new int();
      }
      [Token(Token = "0x600F23D"), Address(RVA = "0x41B495C", Offset = "0x41B495C", VA = "0x41B495C")] private set
      {
      }
    }

    [Token(Token = "0x1700337B")]
    public int defaultMinY
    {
      [Token(Token = "0x600F23E"), Address(RVA = "0x41B4964", Offset = "0x41B4964", VA = "0x41B4964", Slot = "11")] get
      {
        return new int();
      }
      [Token(Token = "0x600F23F"), Address(RVA = "0x41B496C", Offset = "0x41B496C", VA = "0x41B496C")] private set
      {
      }
    }

    [Token(Token = "0x1700337C")]
    public int defaultMaxY
    {
      [Token(Token = "0x600F240"), Address(RVA = "0x41B4974", Offset = "0x41B4974", VA = "0x41B4974", Slot = "12")] get
      {
        return new int();
      }
      [Token(Token = "0x600F241"), Address(RVA = "0x41B497C", Offset = "0x41B497C", VA = "0x41B497C")] private set
      {
      }
    }

    [Token(Token = "0x1700337D")]
    public IReadOnlyList<(int x, int y)> ActualPositions
    {
      [Token(Token = "0x600F242"), Address(RVA = "0x41B4984", Offset = "0x41B4984", VA = "0x41B4984", Slot = "4")] get
      {
        return (IReadOnlyList<(int, int)>) null;
      }
    }

    [Token(Token = "0x1700337E")]
    public IReadOnlyList<int> ActualFlags
    {
      [Token(Token = "0x600F243"), Address(RVA = "0x41B498C", Offset = "0x41B498C", VA = "0x41B498C", Slot = "5")] get
      {
        return (IReadOnlyList<int>) null;
      }
    }

    [Token(Token = "0x1700337F")]
    public int Count
    {
      [Token(Token = "0x600F244"), Address(RVA = "0x41B4994", Offset = "0x41B4994", VA = "0x41B4994", Slot = "6")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600F245")]
    [Address(RVA = "0x41B49DC", Offset = "0x41B49DC", VA = "0x41B49DC")]
    public CompositeRangeData(IEnumerable<IBasicRangeData> ranges)
    {
    }

    [Token(Token = "0x600F246")]
    [Address(RVA = "0x41B4E84", Offset = "0x41B4E84", VA = "0x41B4E84")]
    private void AddRange(IBasicRangeData rangeData)
    {
    }

    [Token(Token = "0x600F247")]
    [Address(RVA = "0x41B54F8", Offset = "0x41B54F8", VA = "0x41B54F8", Slot = "7")]
    public int GetFlagAt(int x, int y) => new int();

    [Token(Token = "0x600F248")]
    [Address(RVA = "0x41B55CC", Offset = "0x41B55CC", VA = "0x41B55CC", Slot = "8")]
    public bool HasFlagAt(int x, int y) => new bool();
  }
}
