// Decompiled with JetBrains decompiler
// Type: Battle.Process.PvEPhaseFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x200265D")]
  public class PvEPhaseFactory : IBattlePhaseFactory
  {
    [Token(Token = "0x600ED88")]
    [Address(RVA = "0x449D060", Offset = "0x449D060", VA = "0x449D060", Slot = "4")]
    public BattlePhaseBase Create(PhaseCode code, BattlePlayerData player)
    {
      return (BattlePhaseBase) null;
    }

    [Token(Token = "0x600ED89")]
    [Address(RVA = "0x448CA10", Offset = "0x448CA10", VA = "0x448CA10")]
    public PvEPhaseFactory()
    {
    }
  }
}
