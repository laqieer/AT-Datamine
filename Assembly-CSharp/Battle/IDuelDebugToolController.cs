// Decompiled with JetBrains decompiler
// Type: Battle.IDuelDebugToolController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle
{
  [Token(Token = "0x2002289")]
  public interface IDuelDebugToolController
  {
    [Token(Token = "0x600D297")]
    DuelManager.DuelProcessType GetDuelProcessType();

    [Token(Token = "0x17002DAE")]
    IDuelDebugToolCharacterSettings AttackerSettings { [Token(Token = "0x600D298")] get; }

    [Token(Token = "0x17002DAF")]
    IDuelDebugToolCharacterSettings AttackerSupporterSettings { [Token(Token = "0x600D299")] get; }

    [Token(Token = "0x17002DB0")]
    IDuelDebugToolCharacterSettings DefenderSettings { [Token(Token = "0x600D29A")] get; }

    [Token(Token = "0x17002DB1")]
    IDuelDebugToolCharacterSettings DefenderSupporterSettings { [Token(Token = "0x600D29B")] get; }

    [Token(Token = "0x17002DB2")]
    IDuelDebugToolEnvironmentSettings EnvironmentSettings { [Token(Token = "0x600D29C")] get; }

    [Token(Token = "0x17002DB3")]
    List<Dictionary<DuelCharacterController.DuelCharacterRole, IDuelDebugToolActionSettings>> TurnList { [Token(Token = "0x600D29D")] get; }
  }
}
