// Decompiled with JetBrains decompiler
// Type: StaqData.GachaStepUpInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200212E")]
  public class GachaStepUpInfo
  {
    [Token(Token = "0x17002C60")]
    public int GroupId
    {
      [Token(Token = "0x600CB2E"), Address(RVA = "0x1BA87D8", Offset = "0x1BA87D8", VA = "0x1BA87D8")] get
      {
        return new int();
      }
      [Token(Token = "0x600CB2F"), Address(RVA = "0x1BA87E0", Offset = "0x1BA87E0", VA = "0x1BA87E0")] set
      {
      }
    }

    [Token(Token = "0x17002C61")]
    public int CurrentCount
    {
      [Token(Token = "0x600CB30"), Address(RVA = "0x1BA87E8", Offset = "0x1BA87E8", VA = "0x1BA87E8")] get
      {
        return new int();
      }
      [Token(Token = "0x600CB31"), Address(RVA = "0x1BA87F0", Offset = "0x1BA87F0", VA = "0x1BA87F0")] set
      {
      }
    }

    [Token(Token = "0x17002C62")]
    public int TotalCount
    {
      [Token(Token = "0x600CB32"), Address(RVA = "0x1BA87F8", Offset = "0x1BA87F8", VA = "0x1BA87F8")] get
      {
        return new int();
      }
      [Token(Token = "0x600CB33"), Address(RVA = "0x1BA8800", Offset = "0x1BA8800", VA = "0x1BA8800")] set
      {
      }
    }

    [Token(Token = "0x600CB34")]
    [Address(RVA = "0x1BA8808", Offset = "0x1BA8808", VA = "0x1BA8808")]
    public static GachaStepUpInfo CreateFromServerData(G0000GachaStepUpType serverData)
    {
      return (GachaStepUpInfo) null;
    }

    [Token(Token = "0x600CB35")]
    [Address(RVA = "0x1BA4FDC", Offset = "0x1BA4FDC", VA = "0x1BA4FDC")]
    public static List<GachaStepUpInfo> CreateFromServerData(
      IEnumerable<G0000GachaStepUpType> serverData)
    {
      return (List<GachaStepUpInfo>) null;
    }

    [Token(Token = "0x600CB36")]
    [Address(RVA = "0x1BA887C", Offset = "0x1BA887C", VA = "0x1BA887C")]
    public GachaStepUpInfo()
    {
    }
  }
}
