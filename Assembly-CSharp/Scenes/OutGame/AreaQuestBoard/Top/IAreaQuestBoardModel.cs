// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaQuestBoard.Top.IAreaQuestBoardModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Scenes.OutGame.AreaQuestBoard.Top
{
  [Token(Token = "0x20038FA")]
  internal interface IAreaQuestBoardModel
  {
    [Token(Token = "0x170049A5")]
    CacheAreaData CurrentCacheAreaData { [Token(Token = "0x601665A")] get; }

    [Token(Token = "0x170049A6")]
    AreaQuestDifficultyData DifficultyData { [Token(Token = "0x601665B")] get; }

    [Token(Token = "0x170049A7")]
    int SelectedAreaGroupId { [Token(Token = "0x601665C")] get; }

    [Token(Token = "0x170049A8")]
    int SelectedAreaId { [Token(Token = "0x601665D")] get; }

    [Token(Token = "0x170049A9")]
    int SelectedNodeId { [Token(Token = "0x601665E")] get; }

    [Token(Token = "0x170049AA")]
    int SelectedDifficultyId { [Token(Token = "0x601665F")] get; }

    [Token(Token = "0x6016660")]
    bool IsDirectedNode(int nodeId);

    [Token(Token = "0x6016661")]
    void Execute();

    [Token(Token = "0x6016662")]
    void ChangeArea(int nextAreaId);

    [Token(Token = "0x6016663")]
    void UpdateCurrentCacheAreaData(int updatedNodeId = 0, int updatedAreaId = 0);

    [Token(Token = "0x6016664")]
    IEnumerator ConnectAPIAreaQuest();

    [Token(Token = "0x6016665")]
    void SetSelectedDifficultyId(int selectedDifficultyId);
  }
}
