// Decompiled with JetBrains decompiler
// Type: Battle.Expedition.Process.UnitCreator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Expedition.Data;
using Battle.Process;
using Battle.Stage;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.Expedition.Process
{
  [Token(Token = "0x2002606")]
  public class UnitCreator : UnitCreatorBase
  {
    [Token(Token = "0x400A33C")]
    [FieldOffset(Offset = "0x18")]
    private BoardData boardData;
    [Token(Token = "0x400A33D")]
    [FieldOffset(Offset = "0x20")]
    private ExpeditionBattleData battleData;

    [Token(Token = "0x1700320B")]
    protected IDirector MainDirector
    {
      [Token(Token = "0x600EAB8"), Address(RVA = "0x4B967F8", Offset = "0x4B967F8", VA = "0x4B967F8")] get
      {
        return (IDirector) null;
      }
      [Token(Token = "0x600EAB9"), Address(RVA = "0x4B96800", Offset = "0x4B96800", VA = "0x4B96800")] set
      {
      }
    }

    [Token(Token = "0x1700320C")]
    protected BattleStage BattleStage
    {
      [Token(Token = "0x600EABA"), Address(RVA = "0x4B96808", Offset = "0x4B96808", VA = "0x4B96808")] get
      {
        return (BattleStage) null;
      }
      [Token(Token = "0x600EABB"), Address(RVA = "0x4B96810", Offset = "0x4B96810", VA = "0x4B96810")] set
      {
      }
    }

    [Token(Token = "0x600EABC")]
    [Address(RVA = "0x4B96818", Offset = "0x4B96818", VA = "0x4B96818")]
    private UnitCreator()
    {
    }

    [Token(Token = "0x600EABD")]
    [Address(RVA = "0x4B8CA30", Offset = "0x4B8CA30", VA = "0x4B8CA30")]
    public UnitCreator(BattleCore battleCore)
    {
    }

    [Token(Token = "0x600EABE")]
    [Address(RVA = "0x4B8AD48", Offset = "0x4B8AD48", VA = "0x4B8AD48")]
    public List<UnitParameterData> CreateAllies(bool isBossBattle)
    {
      return (List<UnitParameterData>) null;
    }

    [Token(Token = "0x600EABF")]
    [Address(RVA = "0x4B8B098", Offset = "0x4B8B098", VA = "0x4B8B098")]
    public List<UnitParameterData> CreateEnemies(bool isBossBattle)
    {
      return (List<UnitParameterData>) null;
    }

    [Token(Token = "0x600EAC0")]
    [Address(RVA = "0x4B9686C", Offset = "0x4B9686C", VA = "0x4B9686C")]
    private UnitParameterData CreateEnemy(
      ExpeditionBattleData.CreateEnemyData enemy,
      int manageNo,
      Vector2Int coord,
      bool isBossBattle = false)
    {
      return (UnitParameterData) null;
    }

    [Token(Token = "0x600EAC1")]
    [Address(RVA = "0x4B95368", Offset = "0x4B95368", VA = "0x4B95368")]
    public List<UnitParameterData> PopEnemy() => (List<UnitParameterData>) null;
  }
}
