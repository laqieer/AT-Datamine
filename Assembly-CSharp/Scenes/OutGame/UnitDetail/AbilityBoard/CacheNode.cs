// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.AbilityBoard.CacheNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.UnitDetail.AbilityBoard
{
  [Token(Token = "0x2003311")]
  public class CacheNode
  {
    [Token(Token = "0x400DCA3")]
    [FieldOffset(Offset = "0x10")]
    private CacheNode prevNode;
    [Token(Token = "0x400DCA4")]
    [FieldOffset(Offset = "0x18")]
    private List<CacheNode> nextNodes;
    [Token(Token = "0x400DCA5")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<int, int> needItemDatas;
    [Token(Token = "0x400DCA6")]
    [FieldOffset(Offset = "0x28")]
    private List<ItemData> itemDatas;
    [Token(Token = "0x400DCA7")]
    [FieldOffset(Offset = "0x30")]
    private int nodeId;
    [Token(Token = "0x400DCA8")]
    [FieldOffset(Offset = "0x34")]
    private bool isCompleted;
    [Token(Token = "0x400DCA9")]
    [FieldOffset(Offset = "0x35")]
    private bool isChosen;
    [Token(Token = "0x400DCAA")]
    [FieldOffset(Offset = "0x36")]
    private bool canRelease;

    [Token(Token = "0x1700434A")]
    public int NodeId
    {
      [Token(Token = "0x6014114"), Address(RVA = "0x20BC4BC", Offset = "0x20BC4BC", VA = "0x20BC4BC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700434B")]
    public CacheNode PrevNode
    {
      [Token(Token = "0x6014115"), Address(RVA = "0x20BC4C4", Offset = "0x20BC4C4", VA = "0x20BC4C4")] get
      {
        return (CacheNode) null;
      }
    }

    [Token(Token = "0x1700434C")]
    public List<CacheNode> NextNodes
    {
      [Token(Token = "0x6014116"), Address(RVA = "0x20BC4CC", Offset = "0x20BC4CC", VA = "0x20BC4CC")] get
      {
        return (List<CacheNode>) null;
      }
    }

    [Token(Token = "0x1700434D")]
    public List<ItemData> ItemDatas
    {
      [Token(Token = "0x6014117"), Address(RVA = "0x20BC4D4", Offset = "0x20BC4D4", VA = "0x20BC4D4")] get
      {
        return (List<ItemData>) null;
      }
    }

    [Token(Token = "0x1700434E")]
    public Dictionary<int, int> NeedItemDatas
    {
      [Token(Token = "0x6014118"), Address(RVA = "0x20BC4DC", Offset = "0x20BC4DC", VA = "0x20BC4DC")] get
      {
        return (Dictionary<int, int>) null;
      }
    }

    [Token(Token = "0x1700434F")]
    public bool IsCompleted
    {
      [Token(Token = "0x6014119"), Address(RVA = "0x20BC4E4", Offset = "0x20BC4E4", VA = "0x20BC4E4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004350")]
    public bool IsChosen
    {
      [Token(Token = "0x601411A"), Address(RVA = "0x20BC4EC", Offset = "0x20BC4EC", VA = "0x20BC4EC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004351")]
    public bool CanRelease
    {
      [Token(Token = "0x601411B"), Address(RVA = "0x20BC4F4", Offset = "0x20BC4F4", VA = "0x20BC4F4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004352")]
    public bool IsEnd
    {
      [Token(Token = "0x601411C"), Address(RVA = "0x20BC4FC", Offset = "0x20BC4FC", VA = "0x20BC4FC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004353")]
    public bool IsCustom
    {
      [Token(Token = "0x601411D"), Address(RVA = "0x20BC54C", Offset = "0x20BC54C", VA = "0x20BC54C")] get
      {
        return new bool();
      }
      [Token(Token = "0x601411E"), Address(RVA = "0x20BC554", Offset = "0x20BC554", VA = "0x20BC554")] private set
      {
      }
    }

    [Token(Token = "0x601411F")]
    [Address(RVA = "0x20BC560", Offset = "0x20BC560", VA = "0x20BC560")]
    public CacheNode(int nodeId, bool isCompleted, List<ItemData> itemDatas)
    {
    }

    [Token(Token = "0x6014120")]
    [Address(RVA = "0x20BC6B0", Offset = "0x20BC6B0", VA = "0x20BC6B0")]
    public CacheNode Add(CacheNode prevNode) => (CacheNode) null;

    [Token(Token = "0x6014121")]
    [Address(RVA = "0x20BC788", Offset = "0x20BC788", VA = "0x20BC788")]
    public void SetChosen(bool isChosen)
    {
    }

    [Token(Token = "0x6014122")]
    [Address(RVA = "0x20BC794", Offset = "0x20BC794", VA = "0x20BC794")]
    public void SetCanRelease(bool canRelease)
    {
    }

    [Token(Token = "0x6014123")]
    [Address(RVA = "0x20BC768", Offset = "0x20BC768", VA = "0x20BC768")]
    private void SetData()
    {
    }

    [Token(Token = "0x6014124")]
    [Address(RVA = "0x20BC7A0", Offset = "0x20BC7A0", VA = "0x20BC7A0")]
    private void SetDataFirst()
    {
    }

    [Token(Token = "0x6014125")]
    [Address(RVA = "0x20BC938", Offset = "0x20BC938", VA = "0x20BC938")]
    private void SetDataOtherFirst()
    {
    }

    [Token(Token = "0x6014126")]
    [Address(RVA = "0x20BC990", Offset = "0x20BC990", VA = "0x20BC990")]
    private void SetPrevItemNeededToReleaseThisNode()
    {
    }

    [Token(Token = "0x6014127")]
    [Address(RVA = "0x20BCB30", Offset = "0x20BCB30", VA = "0x20BCB30")]
    private void AddNeedItemAmountToReleaseThisNode()
    {
    }
  }
}
