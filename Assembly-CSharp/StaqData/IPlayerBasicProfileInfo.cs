// Decompiled with JetBrains decompiler
// Type: StaqData.IPlayerBasicProfileInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200204B")]
  public interface IPlayerBasicProfileInfo : IPlayerTitleInfo
  {
    [Token(Token = "0x170028CF")]
    string Name { [Token(Token = "0x600C202")] get; }

    [Token(Token = "0x170028D0")]
    string Id { [Token(Token = "0x600C203")] get; }

    [Token(Token = "0x170028D1")]
    int Experience { [Token(Token = "0x600C204")] get; }

    [Token(Token = "0x170028D2")]
    int SymbolUnitMasterId { [Token(Token = "0x600C205")] get; }

    [Token(Token = "0x170028D3")]
    DateTime LastSignedInAt { [Token(Token = "0x600C206")] get; }
  }
}
