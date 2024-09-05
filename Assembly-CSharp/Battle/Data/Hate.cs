// Decompiled with JetBrains decompiler
// Type: Battle.Data.Hate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x2002727")]
  public sealed class Hate
  {
    [Token(Token = "0x400A76E")]
    private const int MaxValue = 100;
    [Token(Token = "0x400A770")]
    [FieldOffset(Offset = "0x0")]
    private static Hate.InfoComparer comparer;

    [Token(Token = "0x170033DF")]
    public SortedList<Hate.Info, int> List
    {
      [Token(Token = "0x600F378"), Address(RVA = "0x1FA3598", Offset = "0x1FA3598", VA = "0x1FA3598")] get
      {
        return (SortedList<Hate.Info, int>) null;
      }
      [Token(Token = "0x600F379"), Address(RVA = "0x1FA35A0", Offset = "0x1FA35A0", VA = "0x1FA35A0")] private set
      {
      }
    }

    [Token(Token = "0x600F37A")]
    [Address(RVA = "0x1FA35A8", Offset = "0x1FA35A8", VA = "0x1FA35A8")]
    public void Add(int unitId, int value)
    {
    }

    [Token(Token = "0x600F37B")]
    [Address(RVA = "0x1FA37FC", Offset = "0x1FA37FC", VA = "0x1FA37FC")]
    public void ResetValue(int unitId)
    {
    }

    [Token(Token = "0x600F37C")]
    [Address(RVA = "0x1FA399C", Offset = "0x1FA399C", VA = "0x1FA399C")]
    public void ResetAll()
    {
    }

    [Token(Token = "0x600F37D")]
    [Address(RVA = "0x1FA3AA0", Offset = "0x1FA3AA0", VA = "0x1FA3AA0")]
    public bool TryGetHate(int unitId, out Hate.Info info) => new bool();

    [Token(Token = "0x600F37E")]
    [Address(RVA = "0x1FA3C4C", Offset = "0x1FA3C4C", VA = "0x1FA3C4C")]
    public bool TryGetHighestHate(out Hate.Info info) => new bool();

    [Token(Token = "0x600F37F")]
    [Address(RVA = "0x1FA3D48", Offset = "0x1FA3D48", VA = "0x1FA3D48")]
    public Hate()
    {
    }

    [Token(Token = "0x600F380")]
    [Address(RVA = "0x1FA3DF8", Offset = "0x1FA3DF8", VA = "0x1FA3DF8")]
    static Hate()
    {
    }

    [Token(Token = "0x2002728")]
    private class InfoComparer : IComparer<Hate.Info>
    {
      [Token(Token = "0x600F381")]
      [Address(RVA = "0x1FA3E78", Offset = "0x1FA3E78", VA = "0x1FA3E78", Slot = "4")]
      public int Compare(Hate.Info x, Hate.Info y) => new int();

      [Token(Token = "0x600F382")]
      [Address(RVA = "0x1FA3E70", Offset = "0x1FA3E70", VA = "0x1FA3E70")]
      public InfoComparer()
      {
      }
    }

    [Token(Token = "0x2002729")]
    public class Info
    {
      [Token(Token = "0x170033E0")]
      public int UnitId
      {
        [Token(Token = "0x600F383"), Address(RVA = "0x1FA3EB0", Offset = "0x1FA3EB0", VA = "0x1FA3EB0")] get
        {
          return new int();
        }
        [Token(Token = "0x600F384"), Address(RVA = "0x1FA3EB8", Offset = "0x1FA3EB8", VA = "0x1FA3EB8")] private set
        {
        }
      }

      [Token(Token = "0x170033E1")]
      public int Value
      {
        [Token(Token = "0x600F385"), Address(RVA = "0x1FA3EC0", Offset = "0x1FA3EC0", VA = "0x1FA3EC0")] get
        {
          return new int();
        }
        [Token(Token = "0x600F386"), Address(RVA = "0x1FA3EC8", Offset = "0x1FA3EC8", VA = "0x1FA3EC8")] private set
        {
        }
      }

      [Token(Token = "0x600F387")]
      [Address(RVA = "0x1FA37D0", Offset = "0x1FA37D0", VA = "0x1FA37D0")]
      public Info(int unitId, int value)
      {
      }

      [Token(Token = "0x600F388")]
      [Address(RVA = "0x1FA3744", Offset = "0x1FA3744", VA = "0x1FA3744")]
      public void Add(int value)
      {
      }

      [Token(Token = "0x600F389")]
      [Address(RVA = "0x1FA3994", Offset = "0x1FA3994", VA = "0x1FA3994")]
      public void ResetValue()
      {
      }
    }
  }
}
