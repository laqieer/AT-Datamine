// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.SceneParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Scene;
using Il2CppDummyDll;
using Network.API;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027F5")]
  public class SceneParameter
  {
    [Token(Token = "0x400A9FB")]
    [FieldOffset(Offset = "0x10")]
    public ChangeSceneParameter Parameter;

    [Token(Token = "0x1700361A")]
    public string AppVersion
    {
      [Token(Token = "0x600F9AD"), Address(RVA = "0x44C3324", Offset = "0x44C3324", VA = "0x44C3324")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F9AE"), Address(RVA = "0x44C332C", Offset = "0x44C332C", VA = "0x44C332C")] set
      {
      }
    }

    [Token(Token = "0x1700361B")]
    public string DlcVersion
    {
      [Token(Token = "0x600F9AF"), Address(RVA = "0x44C3334", Offset = "0x44C3334", VA = "0x44C3334")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F9B0"), Address(RVA = "0x44C333C", Offset = "0x44C333C", VA = "0x44C333C")] set
      {
      }
    }

    [Token(Token = "0x1700361C")]
    public string BattleUuid
    {
      [Token(Token = "0x600F9B1"), Address(RVA = "0x44C3344", Offset = "0x44C3344", VA = "0x44C3344")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F9B2"), Address(RVA = "0x44C334C", Offset = "0x44C334C", VA = "0x44C334C")] private set
      {
      }
    }

    [Token(Token = "0x1700361D")]
    public int QuestType
    {
      [Token(Token = "0x600F9B3"), Address(RVA = "0x44C3354", Offset = "0x44C3354", VA = "0x44C3354")] get
      {
        return new int();
      }
      [Token(Token = "0x600F9B4"), Address(RVA = "0x44C335C", Offset = "0x44C335C", VA = "0x44C335C")] private set
      {
      }
    }

    [Token(Token = "0x1700361E")]
    public int QuestId
    {
      [Token(Token = "0x600F9B5"), Address(RVA = "0x44C3364", Offset = "0x44C3364", VA = "0x44C3364")] get
      {
        return new int();
      }
      [Token(Token = "0x600F9B6"), Address(RVA = "0x44C336C", Offset = "0x44C336C", VA = "0x44C336C")] private set
      {
      }
    }

    [Token(Token = "0x1700361F")]
    public int LapCount
    {
      [Token(Token = "0x600F9B7"), Address(RVA = "0x44C3374", Offset = "0x44C3374", VA = "0x44C3374")] get
      {
        return new int();
      }
      [Token(Token = "0x600F9B8"), Address(RVA = "0x44C337C", Offset = "0x44C337C", VA = "0x44C337C")] private set
      {
      }
    }

    [Token(Token = "0x17003620")]
    public int InitDamage
    {
      [Token(Token = "0x600F9B9"), Address(RVA = "0x44C3384", Offset = "0x44C3384", VA = "0x44C3384")] get
      {
        return new int();
      }
      [Token(Token = "0x600F9BA"), Address(RVA = "0x44C338C", Offset = "0x44C338C", VA = "0x44C338C")] private set
      {
      }
    }

    [Token(Token = "0x17003621")]
    public int DeckIndex
    {
      [Token(Token = "0x600F9BB"), Address(RVA = "0x44C3394", Offset = "0x44C3394", VA = "0x44C3394")] get
      {
        return new int();
      }
      [Token(Token = "0x600F9BC"), Address(RVA = "0x44C339C", Offset = "0x44C339C", VA = "0x44C339C")] private set
      {
      }
    }

    [Token(Token = "0x17003622")]
    public int[] SortieDeckSlots
    {
      [Token(Token = "0x600F9BD"), Address(RVA = "0x44C33A4", Offset = "0x44C33A4", VA = "0x44C33A4")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x600F9BE"), Address(RVA = "0x44C33AC", Offset = "0x44C33AC", VA = "0x44C33AC")] private set
      {
      }
    }

    [Token(Token = "0x17003623")]
    public int SubQuestTaskId
    {
      [Token(Token = "0x600F9BF"), Address(RVA = "0x44C33B4", Offset = "0x44C33B4", VA = "0x44C33B4")] get
      {
        return new int();
      }
      [Token(Token = "0x600F9C0"), Address(RVA = "0x44C33BC", Offset = "0x44C33BC", VA = "0x44C33BC")] private set
      {
      }
    }

    [Token(Token = "0x17003624")]
    public Dictionary<int, int> ItemInfos
    {
      [Token(Token = "0x600F9C1"), Address(RVA = "0x44C33C4", Offset = "0x44C33C4", VA = "0x44C33C4")] get
      {
        return (Dictionary<int, int>) null;
      }
      [Token(Token = "0x600F9C2"), Address(RVA = "0x44C33CC", Offset = "0x44C33CC", VA = "0x44C33CC")] private set
      {
      }
    }

    [Token(Token = "0x17003625")]
    public Dictionary<int, int> ChestDropInfos
    {
      [Token(Token = "0x600F9C3"), Address(RVA = "0x44C33D4", Offset = "0x44C33D4", VA = "0x44C33D4")] get
      {
        return (Dictionary<int, int>) null;
      }
      [Token(Token = "0x600F9C4"), Address(RVA = "0x44C33DC", Offset = "0x44C33DC", VA = "0x44C33DC")] private set
      {
      }
    }

    [Token(Token = "0x17003626")]
    public Dictionary<int, int> EnemyDropInfos
    {
      [Token(Token = "0x600F9C5"), Address(RVA = "0x44C33E4", Offset = "0x44C33E4", VA = "0x44C33E4")] get
      {
        return (Dictionary<int, int>) null;
      }
      [Token(Token = "0x600F9C6"), Address(RVA = "0x44C33EC", Offset = "0x44C33EC", VA = "0x44C33EC")] private set
      {
      }
    }

    [Token(Token = "0x17003627")]
    public Dictionary<string, Dictionary<int, StaqData.BasicParameter>> UnitLvUpInfos
    {
      [Token(Token = "0x600F9C7"), Address(RVA = "0x44C33F4", Offset = "0x44C33F4", VA = "0x44C33F4")] get
      {
        return (Dictionary<string, Dictionary<int, StaqData.BasicParameter>>) null;
      }
      [Token(Token = "0x600F9C8"), Address(RVA = "0x44C33FC", Offset = "0x44C33FC", VA = "0x44C33FC")] private set
      {
      }
    }

    [Token(Token = "0x17003628")]
    public int Weather
    {
      [Token(Token = "0x600F9C9"), Address(RVA = "0x44C3404", Offset = "0x44C3404", VA = "0x44C3404")] get
      {
        return new int();
      }
      [Token(Token = "0x600F9CA"), Address(RVA = "0x44C340C", Offset = "0x44C340C", VA = "0x44C340C")] private set
      {
      }
    }

    [Token(Token = "0x17003629")]
    public int TimeSlot
    {
      [Token(Token = "0x600F9CB"), Address(RVA = "0x44C3414", Offset = "0x44C3414", VA = "0x44C3414")] get
      {
        return new int();
      }
      [Token(Token = "0x600F9CC"), Address(RVA = "0x44C341C", Offset = "0x44C341C", VA = "0x44C341C")] private set
      {
      }
    }

    [Token(Token = "0x1700362A")]
    public int Seed
    {
      [Token(Token = "0x600F9CD"), Address(RVA = "0x44C3424", Offset = "0x44C3424", VA = "0x44C3424")] get
      {
        return new int();
      }
      [Token(Token = "0x600F9CE"), Address(RVA = "0x44C342C", Offset = "0x44C342C", VA = "0x44C342C")] private set
      {
      }
    }

    [Token(Token = "0x1700362B")]
    public int RollbackCnt
    {
      [Token(Token = "0x600F9CF"), Address(RVA = "0x44C3434", Offset = "0x44C3434", VA = "0x44C3434")] get
      {
        return new int();
      }
      [Token(Token = "0x600F9D0"), Address(RVA = "0x44C343C", Offset = "0x44C343C", VA = "0x44C343C")] private set
      {
      }
    }

    [Token(Token = "0x1700362C")]
    public int RollbackIdx
    {
      [Token(Token = "0x600F9D1"), Address(RVA = "0x44C3444", Offset = "0x44C3444", VA = "0x44C3444")] get
      {
        return new int();
      }
      [Token(Token = "0x600F9D2"), Address(RVA = "0x44C344C", Offset = "0x44C344C", VA = "0x44C344C")] private set
      {
      }
    }

    [Token(Token = "0x1700362D")]
    private bool IsQuestBattle
    {
      [Token(Token = "0x600F9D3"), Address(RVA = "0x44C3454", Offset = "0x44C3454", VA = "0x44C3454")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700362E")]
    private bool IsArenaBattle
    {
      [Token(Token = "0x600F9D4"), Address(RVA = "0x44C34B4", Offset = "0x44C34B4", VA = "0x44C34B4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600F9D5")]
    [Address(RVA = "0x44C3514", Offset = "0x44C3514", VA = "0x44C3514")]
    public static SceneParameter Create(PvEBattle.QuestBattleSceneParameter sceneParameter)
    {
      return (SceneParameter) null;
    }

    [Token(Token = "0x600F9D6")]
    [Address(RVA = "0x44C3B1C", Offset = "0x44C3B1C", VA = "0x44C3B1C")]
    public static SceneParameter CreateFromSchema(staq.SaveSchema.SceneParameter schema)
    {
      return (SceneParameter) null;
    }

    [Token(Token = "0x600F9D7")]
    [Address(RVA = "0x44C4200", Offset = "0x44C4200", VA = "0x44C4200")]
    public static SceneParameter Create(PvEBattle.ArenaBattleSceneParameter sceneParam)
    {
      return (SceneParameter) null;
    }

    [Token(Token = "0x600F9D8")]
    [Address(RVA = "0x44C42EC", Offset = "0x44C42EC", VA = "0x44C42EC")]
    public static SceneParameter Create(PvEBattle.ArenaPlaceSceneParameter sceneParam)
    {
      return (SceneParameter) null;
    }

    [Token(Token = "0x600F9D9")]
    [Address(RVA = "0x44C43C8", Offset = "0x44C43C8", VA = "0x44C43C8")]
    public void SetRollbackInfoFromServer(APIBattleResumeResponse response)
    {
    }

    [Token(Token = "0x600F9DA")]
    [Address(RVA = "0x44C43E4", Offset = "0x44C43E4", VA = "0x44C43E4")]
    public PvEBattle.QuestBattleSceneParameter Convert()
    {
      return (PvEBattle.QuestBattleSceneParameter) null;
    }

    [Token(Token = "0x600F9DB")]
    [Address(RVA = "0x44C4E4C", Offset = "0x44C4E4C", VA = "0x44C4E4C")]
    public string ToJson() => (string) null;

    [Token(Token = "0x600F9DC")]
    [Address(RVA = "0x44C4F38", Offset = "0x44C4F38", VA = "0x44C4F38")]
    public string ToQuestJson() => (string) null;

    [Token(Token = "0x600F9DD")]
    [Address(RVA = "0x44C5744", Offset = "0x44C5744", VA = "0x44C5744")]
    public string ToArenaJson() => (string) null;

    [Token(Token = "0x600F9DE")]
    [Address(RVA = "0x44C3A1C", Offset = "0x44C3A1C", VA = "0x44C3A1C")]
    public SceneParameter()
    {
    }
  }
}
