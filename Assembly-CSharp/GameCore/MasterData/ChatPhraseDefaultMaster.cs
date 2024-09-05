// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ChatPhraseDefaultMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E76")]
  [Serializable]
  public sealed class ChatPhraseDefaultMaster : BaseMaster<ChatPhraseDefaultData>
  {
    [Token(Token = "0x6005832")]
    [Address(RVA = "0x3E46F14", Offset = "0x3E46F14", VA = "0x3E46F14")]
    public IReadOnlyDictionary<int, ChatPhraseDefaultData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ChatPhraseDefaultData>) null;
    }

    [Token(Token = "0x6005833")]
    [Address(RVA = "0x3E46F1C", Offset = "0x3E46F1C", VA = "0x3E46F1C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005834")]
    [Address(RVA = "0x3E46F7C", Offset = "0x3E46F7C", VA = "0x3E46F7C", Slot = "5")]
    protected override ChatPhraseDefaultData LoadEntity(IMasterDataReader reader)
    {
      return (ChatPhraseDefaultData) null;
    }

    [Token(Token = "0x6005835")]
    [Address(RVA = "0x3E46FD4", Offset = "0x3E46FD4", VA = "0x3E46FD4")]
    public ChatPhraseDefaultMaster()
    {
    }
  }
}
