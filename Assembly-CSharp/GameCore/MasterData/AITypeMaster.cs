// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AITypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DD1")]
  [Serializable]
  public sealed class AITypeMaster : BaseMaster<AITypeData>
  {
    [Token(Token = "0x400420F")]
    [FieldOffset(Offset = "0x18")]
    private int AttackAITypeId;
    [Token(Token = "0x4004210")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<int, AITypeData> userAIDic;
    [Token(Token = "0x4004211")]
    [FieldOffset(Offset = "0x28")]
    private Dictionary<int, AITypeData> partyAIDic;

    [Token(Token = "0x600545A")]
    [Address(RVA = "0x3AA47E8", Offset = "0x3AA47E8", VA = "0x3AA47E8")]
    public IReadOnlyDictionary<int, AITypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AITypeData>) null;
    }

    [Token(Token = "0x600545B")]
    [Address(RVA = "0x3AA47F0", Offset = "0x3AA47F0", VA = "0x3AA47F0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600545C")]
    [Address(RVA = "0x3AA4850", Offset = "0x3AA4850", VA = "0x3AA4850", Slot = "5")]
    protected override AITypeData LoadEntity(IMasterDataReader reader) => (AITypeData) null;

    [Token(Token = "0x600545D")]
    [Address(RVA = "0x3AA48C0", Offset = "0x3AA48C0", VA = "0x3AA48C0")]
    private void OnLoadEntity(AITypeData entity)
    {
    }

    [Token(Token = "0x600545E")]
    [Address(RVA = "0x3AA48FC", Offset = "0x3AA48FC", VA = "0x3AA48FC")]
    private void SetAIDictionary(
      AITypeData entity,
      bool settingFlag,
      Dictionary<int, AITypeData> dic)
    {
    }

    [Token(Token = "0x600545F")]
    [Address(RVA = "0x3AA49A0", Offset = "0x3AA49A0", VA = "0x3AA49A0")]
    public AITypeData GetUserAI(int aiTypeId) => (AITypeData) null;

    [Token(Token = "0x6005460")]
    [Address(RVA = "0x3AA4A18", Offset = "0x3AA4A18", VA = "0x3AA4A18")]
    public IReadOnlyCollection<AITypeData> GetUserAIs() => (IReadOnlyCollection<AITypeData>) null;

    [Token(Token = "0x6005461")]
    [Address(RVA = "0x3AA4A68", Offset = "0x3AA4A68", VA = "0x3AA4A68")]
    public AITypeData GetPartyAI(int aiTypeId) => (AITypeData) null;

    [Token(Token = "0x6005462")]
    [Address(RVA = "0x3AA4AE0", Offset = "0x3AA4AE0", VA = "0x3AA4AE0")]
    public List<AITypeData> GetPartyAIList() => (List<AITypeData>) null;

    [Token(Token = "0x6005463")]
    [Address(RVA = "0x3AA4CEC", Offset = "0x3AA4CEC", VA = "0x3AA4CEC")]
    public AITypeData GetAttackerAI() => (AITypeData) null;

    [Token(Token = "0x6005464")]
    [Address(RVA = "0x3AA4D38", Offset = "0x3AA4D38", VA = "0x3AA4D38")]
    public AITypeMaster()
    {
    }
  }
}
