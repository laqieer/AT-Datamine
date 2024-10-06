// Decompiled with JetBrains decompiler
// Type: StaqData.GachaGroupInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200212A")]
  public class GachaGroupInfo
  {
    [Token(Token = "0x17002C57")]
    public int Id
    {
      [Token(Token = "0x600CB10"), Address(RVA = "0x1BA8558", Offset = "0x1BA8558", VA = "0x1BA8558")] get
      {
        return new int();
      }
      [Token(Token = "0x600CB11"), Address(RVA = "0x1BA8560", Offset = "0x1BA8560", VA = "0x1BA8560")] private set
      {
      }
    }

    [Token(Token = "0x17002C58")]
    public string Name
    {
      [Token(Token = "0x600CB12"), Address(RVA = "0x1BA8568", Offset = "0x1BA8568", VA = "0x1BA8568")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600CB13"), Address(RVA = "0x1BA8570", Offset = "0x1BA8570", VA = "0x1BA8570")] private set
      {
      }
    }

    [Token(Token = "0x600CB14")]
    [Address(RVA = "0x1BA8578", Offset = "0x1BA8578", VA = "0x1BA8578")]
    public static GachaGroupInfo CreateFromServerData(G0000GachaGroupType serverData)
    {
      return (GachaGroupInfo) null;
    }

    [Token(Token = "0x600CB15")]
    [Address(RVA = "0x1BA4DB4", Offset = "0x1BA4DB4", VA = "0x1BA4DB4")]
    public static List<GachaGroupInfo> CreateFromServerData(
      IEnumerable<G0000GachaGroupType> serverData)
    {
      return (List<GachaGroupInfo>) null;
    }

    [Token(Token = "0x600CB16")]
    [Address(RVA = "0x1BA85EC", Offset = "0x1BA85EC", VA = "0x1BA85EC")]
    public GachaGroupInfo()
    {
    }
  }
}
