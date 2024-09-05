// Decompiled with JetBrains decompiler
// Type: Story.KizunaQuest.KizunaQuestContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Story.KizunaQuest
{
  [Token(Token = "0x2000680")]
  public class KizunaQuestContainer : MonoBehaviour
  {
    [Token(Token = "0x4001F39")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject unitImage;
    [Token(Token = "0x4001F3A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text unitName;
    [Token(Token = "0x4001F3B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private KizunaQuestRewardInfo rewardInfo;
    [Token(Token = "0x4001F3C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private KizunaQuestRankupInfo rankupInfo;
    [Token(Token = "0x4001F3F")]
    [FieldOffset(Offset = "0x48")]
    private GameObject unitFacePrefab;
    [Token(Token = "0x4001F40")]
    [FieldOffset(Offset = "0x50")]
    private AssetCachedSpawner spawneSelf;
    [Token(Token = "0x4001F41")]
    [FieldOffset(Offset = "0x58")]
    private AssetSpawnOperation<GameObject> charafaceHandle;

    [Token(Token = "0x17000572")]
    public Action OnClickRankUpAction
    {
      [Token(Token = "0x6002525"), Address(RVA = "0x2F35F78", Offset = "0x2F35F78", VA = "0x2F35F78")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6002526"), Address(RVA = "0x2F35F80", Offset = "0x2F35F80", VA = "0x2F35F80")] set
      {
      }
    }

    [Token(Token = "0x17000573")]
    public Action OnClickKizunaQuestInfoAction
    {
      [Token(Token = "0x6002527"), Address(RVA = "0x2F35F88", Offset = "0x2F35F88", VA = "0x2F35F88")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6002528"), Address(RVA = "0x2F35F90", Offset = "0x2F35F90", VA = "0x2F35F90")] set
      {
      }
    }

    [Token(Token = "0x6002529")]
    [Address(RVA = "0x2F35F98", Offset = "0x2F35F98", VA = "0x2F35F98")]
    public void Initialize(
      IKizunaQuestPopupParam uiParam,
      GameObject rankUpInfoPrefab,
      GameObject iconPrefab)
    {
    }

    [Token(Token = "0x600252A")]
    [Address(RVA = "0x2F36248", Offset = "0x2F36248", VA = "0x2F36248")]
    private void SpwanCharacterUnitFace(int defaultStyleId)
    {
    }

    [Token(Token = "0x600252B")]
    [Address(RVA = "0x2F36C50", Offset = "0x2F36C50", VA = "0x2F36C50")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x600252C")]
    [Address(RVA = "0x2F36D24", Offset = "0x2F36D24", VA = "0x2F36D24")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600252D")]
    [Address(RVA = "0x2F36DB0", Offset = "0x2F36DB0", VA = "0x2F36DB0")]
    public void OnClickToRankUp()
    {
    }

    [Token(Token = "0x600252E")]
    [Address(RVA = "0x2F36DCC", Offset = "0x2F36DCC", VA = "0x2F36DCC")]
    public void OnClickToKizunaQuestInfo()
    {
    }

    [Token(Token = "0x600252F")]
    [Address(RVA = "0x2F36DE8", Offset = "0x2F36DE8", VA = "0x2F36DE8")]
    public KizunaQuestContainer()
    {
    }
  }
}
