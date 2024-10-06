// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ChatStampMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E7F")]
  [Serializable]
  public sealed class ChatStampMaster : BaseMaster<ChatStampData>
  {
    [Token(Token = "0x6005855")]
    [Address(RVA = "0x3E481DC", Offset = "0x3E481DC", VA = "0x3E481DC")]
    public IReadOnlyDictionary<int, ChatStampData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ChatStampData>) null;
    }

    [Token(Token = "0x6005856")]
    [Address(RVA = "0x3E481E4", Offset = "0x3E481E4", VA = "0x3E481E4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005857")]
    [Address(RVA = "0x3E48244", Offset = "0x3E48244", VA = "0x3E48244", Slot = "5")]
    protected override ChatStampData LoadEntity(IMasterDataReader reader) => (ChatStampData) null;

    [Token(Token = "0x6005858")]
    [Address(RVA = "0x3E4829C", Offset = "0x3E4829C", VA = "0x3E4829C")]
    public ChatStampMaster()
    {
    }
  }
}
