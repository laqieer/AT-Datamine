// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EventQuest.DifficultyButtonList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.EventQuest
{
  [Token(Token = "0x2003657")]
  public class DifficultyButtonList : MonoBehaviour
  {
    [Token(Token = "0x17004713")]
    public Action<QuestDifficultyTypeEnum> OnClickDiffcultyAction
    {
      [Token(Token = "0x6015644"), Address(RVA = "0x18DABD4", Offset = "0x18DABD4", VA = "0x18DABD4")] get
      {
        return (Action<QuestDifficultyTypeEnum>) null;
      }
      [Token(Token = "0x6015645"), Address(RVA = "0x18DABDC", Offset = "0x18DABDC", VA = "0x18DABDC")] set
      {
      }
    }

    [Token(Token = "0x6015646")]
    [Address(RVA = "0x18DABE4", Offset = "0x18DABE4", VA = "0x18DABE4")]
    public void OnClickToDifficulty(int questDifficulty)
    {
    }

    [Token(Token = "0x6015647")]
    [Address(RVA = "0x18DAC00", Offset = "0x18DAC00", VA = "0x18DAC00")]
    public DifficultyButtonList()
    {
    }
  }
}
