// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Obliviae.ObliviaeQuestStageDetailRewardList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.Story.Obliviae
{
  [Token(Token = "0x2002E6C")]
  public class ObliviaeQuestStageDetailRewardList : MonoBehaviour
  {
    [Token(Token = "0x400C731")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject baseObject;
    [Token(Token = "0x400C732")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform grid;
    [Token(Token = "0x400C733")]
    [FieldOffset(Offset = "0x28")]
    private List<GameObject> rewardListObjects;

    [Token(Token = "0x6012241")]
    [Address(RVA = "0x458C698", Offset = "0x458C698", VA = "0x458C698")]
    public void Setup(
      ObliviaeQuestStageDetailRewardListData rewardListData,
      Action<RewardTypeEnum, int> openDetail)
    {
    }

    [Token(Token = "0x6012242")]
    [Address(RVA = "0x458D564", Offset = "0x458D564", VA = "0x458D564")]
    private void SetupItemIcons(
      ObliviaeQuestStageDetailRewardListData rewardListData,
      Action<RewardTypeEnum, int> openDetail)
    {
    }

    [Token(Token = "0x6012243")]
    [Address(RVA = "0x458D8B8", Offset = "0x458D8B8", VA = "0x458D8B8")]
    public ObliviaeQuestStageDetailRewardList()
    {
    }
  }
}
