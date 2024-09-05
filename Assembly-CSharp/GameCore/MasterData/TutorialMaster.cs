// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.TutorialMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001322")]
  [Serializable]
  public sealed class TutorialMaster : BaseMaster<TutorialData>
  {
    [Token(Token = "0x6006C07")]
    [Address(RVA = "0x48E7CF0", Offset = "0x48E7CF0", VA = "0x48E7CF0")]
    public IReadOnlyDictionary<int, TutorialData> GetEntities()
    {
      return (IReadOnlyDictionary<int, TutorialData>) null;
    }

    [Token(Token = "0x6006C08")]
    [Address(RVA = "0x48E7CF8", Offset = "0x48E7CF8", VA = "0x48E7CF8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006C09")]
    [Address(RVA = "0x48E7D58", Offset = "0x48E7D58", VA = "0x48E7D58", Slot = "5")]
    protected override TutorialData LoadEntity(IMasterDataReader reader) => (TutorialData) null;

    [Token(Token = "0x6006C0A")]
    [Address(RVA = "0x48E7DB0", Offset = "0x48E7DB0", VA = "0x48E7DB0")]
    public TutorialMaster()
    {
    }
  }
}
