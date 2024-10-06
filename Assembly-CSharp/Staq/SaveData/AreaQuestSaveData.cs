// Decompiled with JetBrains decompiler
// Type: staq.SaveData.AreaQuestSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003CF3")]
  public class AreaQuestSaveData
  {
    [Token(Token = "0x4010C57")]
    [FieldOffset(Offset = "0x10")]
    public int AreaGroupId;
    [Token(Token = "0x4010C58")]
    [FieldOffset(Offset = "0x14")]
    public int AreaId;
    [Token(Token = "0x4010C59")]
    [FieldOffset(Offset = "0x18")]
    public int AreaNodeId;
    [Token(Token = "0x4010C5A")]
    [FieldOffset(Offset = "0x1C")]
    public QuestDifficultyTypeEnum QuestDifficulty;
    [Token(Token = "0x4010C5B")]
    [FieldOffset(Offset = "0x20")]
    public QuestDifficultyTypeEnum QuestDifficultySelectCache;
    [Token(Token = "0x4010C5C")]
    [FieldOffset(Offset = "0x24")]
    public bool AreaNodeScenarioSkipSetting;

    [Token(Token = "0x1700500B")]
    public static string Path
    {
      [Token(Token = "0x60187DF"), Address(RVA = "0x2938998", Offset = "0x2938998", VA = "0x2938998")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60187E0")]
    [Address(RVA = "0x29389E8", Offset = "0x29389E8", VA = "0x29389E8")]
    public string getPath() => (string) null;

    [Token(Token = "0x60187E1")]
    [Address(RVA = "0x2938A30", Offset = "0x2938A30", VA = "0x2938A30")]
    public void Delete()
    {
    }

    [Token(Token = "0x60187E2")]
    [Address(RVA = "0x2938A48", Offset = "0x2938A48", VA = "0x2938A48")]
    public void deleteFile()
    {
    }

    [Token(Token = "0x60187E3")]
    [Address(RVA = "0x2938A74", Offset = "0x2938A74", VA = "0x2938A74")]
    public void load()
    {
    }

    [Token(Token = "0x60187E4")]
    [Address(RVA = "0x2938C48", Offset = "0x2938C48", VA = "0x2938C48")]
    public void save()
    {
    }

    [Token(Token = "0x60187E5")]
    [Address(RVA = "0x2938D50", Offset = "0x2938D50", VA = "0x2938D50")]
    public AreaQuestSaveData()
    {
    }
  }
}
