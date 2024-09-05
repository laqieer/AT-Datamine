// Decompiled with JetBrains decompiler
// Type: Battle.Data.WatchedBattleAdvData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using Network.Param;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x20026EC")]
  public sealed class WatchedBattleAdvData
  {
    [Token(Token = "0x170032CB")]
    public int BattleAdvId
    {
      [Token(Token = "0x600F0BB"), Address(RVA = "0x41AB824", Offset = "0x41AB824", VA = "0x41AB824")] get
      {
        return new int();
      }
      [Token(Token = "0x600F0BC"), Address(RVA = "0x41AB82C", Offset = "0x41AB82C", VA = "0x41AB82C")] private set
      {
      }
    }

    [Token(Token = "0x170032CC")]
    public List<int> PlayerSelectedIds
    {
      [Token(Token = "0x600F0BD"), Address(RVA = "0x41AB834", Offset = "0x41AB834", VA = "0x41AB834")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x600F0BE"), Address(RVA = "0x41AB83C", Offset = "0x41AB83C", VA = "0x41AB83C")] private set
      {
      }
    }

    [Token(Token = "0x170032CD")]
    public List<int> UnlockedOptions
    {
      [Token(Token = "0x600F0BF"), Address(RVA = "0x41AB844", Offset = "0x41AB844", VA = "0x41AB844")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x600F0C0"), Address(RVA = "0x41AB84C", Offset = "0x41AB84C", VA = "0x41AB84C")] private set
      {
      }
    }

    [Token(Token = "0x170032CE")]
    public List<int> AlreadyReadChoices
    {
      [Token(Token = "0x600F0C1"), Address(RVA = "0x41AB854", Offset = "0x41AB854", VA = "0x41AB854")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x600F0C2"), Address(RVA = "0x41AB85C", Offset = "0x41AB85C", VA = "0x41AB85C")] private set
      {
      }
    }

    [Token(Token = "0x170032CF")]
    public int AdvId
    {
      [Token(Token = "0x600F0C3"), Address(RVA = "0x41AB864", Offset = "0x41AB864", VA = "0x41AB864")] get
      {
        return new int();
      }
      [Token(Token = "0x600F0C4"), Address(RVA = "0x41AB86C", Offset = "0x41AB86C", VA = "0x41AB86C")] private set
      {
      }
    }

    [Token(Token = "0x600F0C5")]
    [Address(RVA = "0x41AB598", Offset = "0x41AB598", VA = "0x41AB598")]
    public WatchedBattleAdvData(int battleAdvId, int advId)
    {
    }

    [Token(Token = "0x600F0C6")]
    [Address(RVA = "0x41AA198", Offset = "0x41AA198", VA = "0x41AA198")]
    public Offset<staq.SaveSchema.WatchedBattleAdvData> Serialize(FlatBufferBuilder fbb)
    {
      return new Offset<staq.SaveSchema.WatchedBattleAdvData>();
    }

    [Token(Token = "0x600F0C7")]
    [Address(RVA = "0x41AB874", Offset = "0x41AB874", VA = "0x41AB874")]
    public AdvRequest CreateAdvRequest() => (AdvRequest) null;
  }
}
