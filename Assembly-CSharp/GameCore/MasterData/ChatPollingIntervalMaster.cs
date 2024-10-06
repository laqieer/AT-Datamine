// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ChatPollingIntervalMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E78")]
  [Serializable]
  public sealed class ChatPollingIntervalMaster : BaseMaster<ChatPollingIntervalData>
  {
    [Token(Token = "0x600583A")]
    [Address(RVA = "0x3E47230", Offset = "0x3E47230", VA = "0x3E47230")]
    public IReadOnlyDictionary<int, ChatPollingIntervalData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ChatPollingIntervalData>) null;
    }

    [Token(Token = "0x600583B")]
    [Address(RVA = "0x3E47238", Offset = "0x3E47238", VA = "0x3E47238", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600583C")]
    [Address(RVA = "0x3E47298", Offset = "0x3E47298", VA = "0x3E47298", Slot = "5")]
    protected override ChatPollingIntervalData LoadEntity(IMasterDataReader reader)
    {
      return (ChatPollingIntervalData) null;
    }

    [Token(Token = "0x600583D")]
    [Address(RVA = "0x3E472F0", Offset = "0x3E472F0", VA = "0x3E472F0")]
    public ChatPollingIntervalMaster()
    {
    }
  }
}
