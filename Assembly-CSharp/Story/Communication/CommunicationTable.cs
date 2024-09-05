// Decompiled with JetBrains decompiler
// Type: Story.Communication.CommunicationTable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Story.Communication
{
  [Token(Token = "0x20006B5")]
  public class CommunicationTable
  {
    [Token(Token = "0x400200C")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<int, CommunicationStatus> table;

    [Token(Token = "0x6002602")]
    [Address(RVA = "0x2F3FB9C", Offset = "0x2F3FB9C", VA = "0x2F3FB9C")]
    public CommunicationStatus GetCommunicationStatus(int unitID) => (CommunicationStatus) null;

    [Token(Token = "0x6002603")]
    [Address(RVA = "0x2F3FC48", Offset = "0x2F3FC48", VA = "0x2F3FC48")]
    public CommunicationTable()
    {
    }
  }
}
