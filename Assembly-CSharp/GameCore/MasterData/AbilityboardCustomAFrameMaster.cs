// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityboardCustomAFrameMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200133A")]
  [Serializable]
  public sealed class AbilityboardCustomAFrameMaster : BaseMaster<AbilityboardCustomAFrameData>
  {
    [Token(Token = "0x4005AA2")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<AbilityboardCustomAFrameData>> descriptionTable;

    [Token(Token = "0x6006C76")]
    [Address(RVA = "0x46F3B30", Offset = "0x46F3B30", VA = "0x46F3B30")]
    public IReadOnlyDictionary<int, AbilityboardCustomAFrameData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AbilityboardCustomAFrameData>) null;
    }

    [Token(Token = "0x6006C77")]
    [Address(RVA = "0x46F3B38", Offset = "0x46F3B38", VA = "0x46F3B38", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006C78")]
    [Address(RVA = "0x46F3DFC", Offset = "0x46F3DFC", VA = "0x46F3DFC", Slot = "5")]
    protected override AbilityboardCustomAFrameData LoadEntity(IMasterDataReader reader)
    {
      return (AbilityboardCustomAFrameData) null;
    }

    [Token(Token = "0x6006C79")]
    [Address(RVA = "0x46F3E6C", Offset = "0x46F3E6C", VA = "0x46F3E6C")]
    private void OnLoadEntity(AbilityboardCustomAFrameData entity)
    {
    }

    [Token(Token = "0x6006C7A")]
    [Address(RVA = "0x46F3BA0", Offset = "0x46F3BA0", VA = "0x46F3BA0")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x6006C7B")]
    [Address(RVA = "0x46F3E70", Offset = "0x46F3E70", VA = "0x46F3E70")]
    private void GroupingByGroupId(AbilityboardCustomAFrameData entity)
    {
    }

    [Token(Token = "0x6006C7C")]
    [Address(RVA = "0x46F402C", Offset = "0x46F402C", VA = "0x46F402C")]
    public AbilityboardCustomAFrameData GetListByGroupIdAndFrameType(int groupId, int frameType)
    {
      return (AbilityboardCustomAFrameData) null;
    }

    [Token(Token = "0x6006C7D")]
    [Address(RVA = "0x46F41D0", Offset = "0x46F41D0", VA = "0x46F41D0")]
    public AbilityboardCustomAFrameMaster()
    {
    }
  }
}
