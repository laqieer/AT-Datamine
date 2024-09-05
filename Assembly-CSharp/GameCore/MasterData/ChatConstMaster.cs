// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ChatConstMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E74")]
  [Serializable]
  public sealed class ChatConstMaster : BaseMaster<ChatConstData>
  {
    [Token(Token = "0x600582A")]
    [Address(RVA = "0x3E4687C", Offset = "0x3E4687C", VA = "0x3E4687C")]
    public IReadOnlyDictionary<int, ChatConstData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ChatConstData>) null;
    }

    [Token(Token = "0x600582B")]
    [Address(RVA = "0x3E46884", Offset = "0x3E46884", VA = "0x3E46884", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600582C")]
    [Address(RVA = "0x3E468E4", Offset = "0x3E468E4", VA = "0x3E468E4", Slot = "5")]
    protected override ChatConstData LoadEntity(IMasterDataReader reader) => (ChatConstData) null;

    [Token(Token = "0x600582D")]
    [Address(RVA = "0x3E4693C", Offset = "0x3E4693C", VA = "0x3E4693C")]
    public ChatConstMaster()
    {
    }
  }
}
