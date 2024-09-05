// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.PreHomeEventAdvContentMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010E2")]
  [Serializable]
  public sealed class PreHomeEventAdvContentMaster : BaseMaster<PreHomeEventAdvContentData>
  {
    [Token(Token = "0x6006173")]
    [Address(RVA = "0x28E0B50", Offset = "0x28E0B50", VA = "0x28E0B50")]
    public IReadOnlyDictionary<int, PreHomeEventAdvContentData> GetEntities()
    {
      return (IReadOnlyDictionary<int, PreHomeEventAdvContentData>) null;
    }

    [Token(Token = "0x6006174")]
    [Address(RVA = "0x28E0B58", Offset = "0x28E0B58", VA = "0x28E0B58", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006175")]
    [Address(RVA = "0x28E0BB8", Offset = "0x28E0BB8", VA = "0x28E0BB8", Slot = "5")]
    protected override PreHomeEventAdvContentData LoadEntity(IMasterDataReader reader)
    {
      return (PreHomeEventAdvContentData) null;
    }

    [Token(Token = "0x6006176")]
    [Address(RVA = "0x28E0C10", Offset = "0x28E0C10", VA = "0x28E0C10")]
    public PreHomeEventAdvContentMaster()
    {
    }
  }
}
