// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.UseItemScoreMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001172")]
  [Serializable]
  public sealed class UseItemScoreMaster : BaseMaster<UseItemScoreData>
  {
    [Token(Token = "0x6006462")]
    [Address(RVA = "0x4AEF210", Offset = "0x4AEF210", VA = "0x4AEF210")]
    public IReadOnlyDictionary<int, UseItemScoreData> GetEntities()
    {
      return (IReadOnlyDictionary<int, UseItemScoreData>) null;
    }

    [Token(Token = "0x6006463")]
    [Address(RVA = "0x4AEF218", Offset = "0x4AEF218", VA = "0x4AEF218", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006464")]
    [Address(RVA = "0x4AEF278", Offset = "0x4AEF278", VA = "0x4AEF278", Slot = "5")]
    protected override UseItemScoreData LoadEntity(IMasterDataReader reader)
    {
      return (UseItemScoreData) null;
    }

    [Token(Token = "0x6006465")]
    [Address(RVA = "0x4AEF2D0", Offset = "0x4AEF2D0", VA = "0x4AEF2D0")]
    public IReadOnlyCollection<UseItemScoreData> GetListByGroupID(int groupId)
    {
      return (IReadOnlyCollection<UseItemScoreData>) null;
    }

    [Token(Token = "0x6006466")]
    [Address(RVA = "0x4AEF4C4", Offset = "0x4AEF4C4", VA = "0x4AEF4C4")]
    public UseItemScoreMaster()
    {
    }
  }
}
