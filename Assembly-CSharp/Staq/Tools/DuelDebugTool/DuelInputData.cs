// Decompiled with JetBrains decompiler
// Type: Staq.Tools.DuelDebugTool.DuelInputData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Staq.Tools.DuelDebugTool
{
  [Token(Token = "0x2000983")]
  public class DuelInputData : IDuelDebugToolController
  {
    [Token(Token = "0x6003611")]
    [Address(RVA = "0x3531840", Offset = "0x3531840", VA = "0x3531840", Slot = "4")]
    public DuelManager.DuelProcessType GetDuelProcessType() => new DuelManager.DuelProcessType();

    [Token(Token = "0x1700077E")]
    public IDuelDebugToolCharacterSettings AttackerSettings
    {
      [Token(Token = "0x6003612"), Address(RVA = "0x3531B44", Offset = "0x3531B44", VA = "0x3531B44", Slot = "5")] get
      {
        return (IDuelDebugToolCharacterSettings) null;
      }
    }

    [Token(Token = "0x1700077F")]
    public IDuelDebugToolCharacterSettings AttackerSupporterSettings
    {
      [Token(Token = "0x6003613"), Address(RVA = "0x3531B4C", Offset = "0x3531B4C", VA = "0x3531B4C", Slot = "6")] get
      {
        return (IDuelDebugToolCharacterSettings) null;
      }
    }

    [Token(Token = "0x17000780")]
    public IDuelDebugToolCharacterSettings DefenderSettings
    {
      [Token(Token = "0x6003614"), Address(RVA = "0x3531B54", Offset = "0x3531B54", VA = "0x3531B54", Slot = "7")] get
      {
        return (IDuelDebugToolCharacterSettings) null;
      }
    }

    [Token(Token = "0x17000781")]
    public IDuelDebugToolCharacterSettings DefenderSupporterSettings
    {
      [Token(Token = "0x6003615"), Address(RVA = "0x3531B5C", Offset = "0x3531B5C", VA = "0x3531B5C", Slot = "8")] get
      {
        return (IDuelDebugToolCharacterSettings) null;
      }
    }

    [Token(Token = "0x17000782")]
    public IDuelDebugToolEnvironmentSettings EnvironmentSettings
    {
      [Token(Token = "0x6003616"), Address(RVA = "0x3531B64", Offset = "0x3531B64", VA = "0x3531B64", Slot = "9")] get
      {
        return (IDuelDebugToolEnvironmentSettings) null;
      }
    }

    [Token(Token = "0x17000783")]
    public List<Dictionary<DuelCharacterController.DuelCharacterRole, IDuelDebugToolActionSettings>> TurnList
    {
      [Token(Token = "0x6003617"), Address(RVA = "0x3531B6C", Offset = "0x3531B6C", VA = "0x3531B6C", Slot = "10")] get
      {
        return (List<Dictionary<DuelCharacterController.DuelCharacterRole, IDuelDebugToolActionSettings>>) null;
      }
    }

    [Token(Token = "0x6003618")]
    [Address(RVA = "0x353165C", Offset = "0x353165C", VA = "0x353165C")]
    public DuelInputData(
      IDuelDebugToolCharacterSettings attacker,
      IDuelDebugToolCharacterSettings attackerSupporter,
      IDuelDebugToolCharacterSettings defender,
      IDuelDebugToolCharacterSettings defenderSupporter,
      IDuelDebugToolEnvironmentSettings environmentSettings,
      List<Dictionary<DuelCharacterController.DuelCharacterRole, IDuelDebugToolActionSettings>> turnList)
    {
    }
  }
}
