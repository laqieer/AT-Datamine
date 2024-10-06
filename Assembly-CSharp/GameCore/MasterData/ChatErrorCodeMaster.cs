// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ChatErrorCodeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000ED6")]
  [Serializable]
  public sealed class ChatErrorCodeMaster : BaseMaster<ChatErrorCodeData>
  {
    [Token(Token = "0x6005941")]
    [Address(RVA = "0x3C31198", Offset = "0x3C31198", VA = "0x3C31198")]
    public IReadOnlyDictionary<int, ChatErrorCodeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ChatErrorCodeData>) null;
    }

    [Token(Token = "0x6005942")]
    [Address(RVA = "0x3C311A0", Offset = "0x3C311A0", VA = "0x3C311A0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005943")]
    [Address(RVA = "0x3C31200", Offset = "0x3C31200", VA = "0x3C31200", Slot = "5")]
    protected override ChatErrorCodeData LoadEntity(IMasterDataReader reader)
    {
      return (ChatErrorCodeData) null;
    }

    [Token(Token = "0x6005944")]
    [Address(RVA = "0x3C31258", Offset = "0x3C31258", VA = "0x3C31258")]
    public ChatErrorCodeMaster()
    {
    }
  }
}
