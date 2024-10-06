// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.IntroChapterConstMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200102C")]
  [Serializable]
  public sealed class IntroChapterConstMaster : BaseMaster<IntroChapterConstData>
  {
    [Token(Token = "0x6005E11")]
    [Address(RVA = "0x2799B18", Offset = "0x2799B18", VA = "0x2799B18")]
    public IReadOnlyDictionary<int, IntroChapterConstData> GetEntities()
    {
      return (IReadOnlyDictionary<int, IntroChapterConstData>) null;
    }

    [Token(Token = "0x6005E12")]
    [Address(RVA = "0x2799B20", Offset = "0x2799B20", VA = "0x2799B20", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005E13")]
    [Address(RVA = "0x2799BFC", Offset = "0x2799BFC", VA = "0x2799BFC", Slot = "5")]
    protected override IntroChapterConstData LoadEntity(IMasterDataReader reader)
    {
      return (IntroChapterConstData) null;
    }

    [Token(Token = "0x6005E14")]
    [Address(RVA = "0x2799B88", Offset = "0x2799B88", VA = "0x2799B88")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x17000DDF")]
    public IntroChapterConstData Data
    {
      [Token(Token = "0x6005E15"), Address(RVA = "0x2799C54", Offset = "0x2799C54", VA = "0x2799C54")] get
      {
        return (IntroChapterConstData) null;
      }
      [Token(Token = "0x6005E16"), Address(RVA = "0x2799C5C", Offset = "0x2799C5C", VA = "0x2799C5C")] private set
      {
      }
    }

    [Token(Token = "0x6005E17")]
    [Address(RVA = "0x2799C64", Offset = "0x2799C64", VA = "0x2799C64")]
    public IntroChapterConstMaster()
    {
    }
  }
}
