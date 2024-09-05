// Decompiled with JetBrains decompiler
// Type: Battle.Data.RangeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x2002710")]
  public sealed class RangeData : IBasicRangeData
  {
    [Token(Token = "0x400A712")]
    [FieldOffset(Offset = "0x28")]
    private readonly List<(int x, int y)> defaultPositions;
    [Token(Token = "0x400A713")]
    [FieldOffset(Offset = "0x30")]
    private readonly List<int> defaultFlags;
    [Token(Token = "0x400A714")]
    [FieldOffset(Offset = "0x38")]
    private IReadOnlyList<(int x, int y)> outsideEdges;
    [Token(Token = "0x400A715")]
    [FieldOffset(Offset = "0x40")]
    private IReadOnlyList<(int x, int y)> insideEdges;

    [Token(Token = "0x17003387")]
    public int RangeId
    {
      [Token(Token = "0x600F254"), Address(RVA = "0x41B567C", Offset = "0x41B567C", VA = "0x41B567C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003388")]
    public int defaultMinX
    {
      [Token(Token = "0x600F255"), Address(RVA = "0x41B5684", Offset = "0x41B5684", VA = "0x41B5684", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003389")]
    public int defaultMaxX
    {
      [Token(Token = "0x600F256"), Address(RVA = "0x41B568C", Offset = "0x41B568C", VA = "0x41B568C", Slot = "10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700338A")]
    public int defaultMinY
    {
      [Token(Token = "0x600F257"), Address(RVA = "0x41B5694", Offset = "0x41B5694", VA = "0x41B5694", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700338B")]
    public int defaultMaxY
    {
      [Token(Token = "0x600F258"), Address(RVA = "0x41B569C", Offset = "0x41B569C", VA = "0x41B569C", Slot = "12")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700338C")]
    public IReadOnlyList<(int x, int y)> ActualPositions
    {
      [Token(Token = "0x600F259"), Address(RVA = "0x41B56A4", Offset = "0x41B56A4", VA = "0x41B56A4", Slot = "4")] get
      {
        return (IReadOnlyList<(int, int)>) null;
      }
    }

    [Token(Token = "0x1700338D")]
    public IReadOnlyList<int> ActualFlags
    {
      [Token(Token = "0x600F25A"), Address(RVA = "0x41B56AC", Offset = "0x41B56AC", VA = "0x41B56AC", Slot = "5")] get
      {
        return (IReadOnlyList<int>) null;
      }
    }

    [Token(Token = "0x1700338E")]
    public int Count
    {
      [Token(Token = "0x600F25B"), Address(RVA = "0x41B56B4", Offset = "0x41B56B4", VA = "0x41B56B4", Slot = "6")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700338F")]
    public int MinRange
    {
      [Token(Token = "0x600F25C"), Address(RVA = "0x41B56FC", Offset = "0x41B56FC", VA = "0x41B56FC")] get
      {
        return new int();
      }
      [Token(Token = "0x600F25D"), Address(RVA = "0x41B5704", Offset = "0x41B5704", VA = "0x41B5704")] private set
      {
      }
    }

    [Token(Token = "0x17003390")]
    public int MaxRange
    {
      [Token(Token = "0x600F25E"), Address(RVA = "0x41B570C", Offset = "0x41B570C", VA = "0x41B570C")] get
      {
        return new int();
      }
      [Token(Token = "0x600F25F"), Address(RVA = "0x41B5714", Offset = "0x41B5714", VA = "0x41B5714")] private set
      {
      }
    }

    [Token(Token = "0x600F260")]
    [Address(RVA = "0x41B571C", Offset = "0x41B571C", VA = "0x41B571C")]
    public RangeData(int rangeId, Dictionary<(int x, int y), int> map)
    {
    }

    [Token(Token = "0x600F261")]
    [Address(RVA = "0x41B6674", Offset = "0x41B6674", VA = "0x41B6674")]
    private RangeData(RangeData source)
    {
    }

    [Token(Token = "0x600F262")]
    [Address(RVA = "0x41B66C8", Offset = "0x41B66C8", VA = "0x41B66C8")]
    public RangeData Clone() => (RangeData) null;

    [Token(Token = "0x600F263")]
    [Address(RVA = "0x41B5DF4", Offset = "0x41B5DF4", VA = "0x41B5DF4")]
    private bool IsOutsideEdge(int x, int y) => new bool();

    [Token(Token = "0x600F264")]
    [Address(RVA = "0x41B634C", Offset = "0x41B634C", VA = "0x41B634C")]
    private bool IsInsideEdge(int x, int y) => new bool();

    [Token(Token = "0x600F265")]
    [Address(RVA = "0x41B6728", Offset = "0x41B6728", VA = "0x41B6728", Slot = "7")]
    public int GetFlagAt(int x, int y) => new int();

    [Token(Token = "0x600F266")]
    [Address(RVA = "0x41B67FC", Offset = "0x41B67FC", VA = "0x41B67FC", Slot = "8")]
    public bool HasFlagAt(int x, int y) => new bool();
  }
}
