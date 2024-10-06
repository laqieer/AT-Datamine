// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ITroopsMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013EB")]
  public interface ITroopsMaster
  {
    [Token(Token = "0x6006FC6")]
    IReadOnlyList<ITroopsData> GetTroops(int placementId);
  }
}
