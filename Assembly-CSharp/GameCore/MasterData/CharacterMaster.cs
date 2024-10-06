// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.CharacterMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001369")]
  [Serializable]
  public sealed class CharacterMaster : BaseMaster<CharacterData>
  {
    [Token(Token = "0x4005B15")]
    public const string TEXT_AB = "text_masterdata_unit";

    [Token(Token = "0x6006D4C")]
    [Address(RVA = "0x46FBA3C", Offset = "0x46FBA3C", VA = "0x46FBA3C")]
    public IReadOnlyDictionary<int, CharacterData> GetEntities()
    {
      return (IReadOnlyDictionary<int, CharacterData>) null;
    }

    [Token(Token = "0x6006D4D")]
    [Address(RVA = "0x46FBA44", Offset = "0x46FBA44", VA = "0x46FBA44", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006D4E")]
    [Address(RVA = "0x46FBAA4", Offset = "0x46FBAA4", VA = "0x46FBAA4", Slot = "5")]
    protected override CharacterData LoadEntity(IMasterDataReader reader) => (CharacterData) null;

    [Token(Token = "0x6006D4F")]
    [Address(RVA = "0x46FBAFC", Offset = "0x46FBAFC", VA = "0x46FBAFC")]
    public IReadOnlyCollection<CharacterData> GetList()
    {
      return (IReadOnlyCollection<CharacterData>) null;
    }

    [Token(Token = "0x6006D50")]
    [Address(RVA = "0x46FBB4C", Offset = "0x46FBB4C", VA = "0x46FBB4C")]
    public CharacterMaster()
    {
    }
  }
}
