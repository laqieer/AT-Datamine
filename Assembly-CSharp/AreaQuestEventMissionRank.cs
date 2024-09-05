// Decompiled with JetBrains decompiler
// Type: AreaQuestEventMissionRank
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x200029C")]
public class AreaQuestEventMissionRank : MonoBehaviour
{
  [Token(Token = "0x4000F5A")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private Image imageRank;
  [Token(Token = "0x4000F5B")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private PlayableDirector playableStay;
  [Token(Token = "0x4000F5C")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  private PlayableDirector playableOut;
  [Token(Token = "0x4000F5D")]
  [FieldOffset(Offset = "0x30")]
  [SerializeField]
  private PlayableDirector playableIn;
  [Token(Token = "0x4000F60")]
  [FieldOffset(Offset = "0x40")]
  private AssetCachedSpawner spawner;
  [Token(Token = "0x4000F61")]
  [FieldOffset(Offset = "0x48")]
  private bool isPlayDirector;

  [Token(Token = "0x1700017E")]
  private int ResourceId
  {
    [Token(Token = "0x600102F"), Address(RVA = "0x1BE5CB4", Offset = "0x1BE5CB4", VA = "0x1BE5CB4")] get
    {
      return new int();
    }
    [Token(Token = "0x6001030"), Address(RVA = "0x1BE5CBC", Offset = "0x1BE5CBC", VA = "0x1BE5CBC")] set
    {
    }
  }

  [Token(Token = "0x1700017F")]
  private int Rank
  {
    [Token(Token = "0x6001031"), Address(RVA = "0x1BE5CC4", Offset = "0x1BE5CC4", VA = "0x1BE5CC4")] get
    {
      return new int();
    }
    [Token(Token = "0x6001032"), Address(RVA = "0x1BE5CCC", Offset = "0x1BE5CCC", VA = "0x1BE5CCC")] set
    {
    }
  }

  [Token(Token = "0x6001033")]
  [Address(RVA = "0x1BE5CD4", Offset = "0x1BE5CD4", VA = "0x1BE5CD4")]
  public void Initialize(int eventPageId, AssetCachedSpawner spawner)
  {
  }

  [Token(Token = "0x6001034")]
  [Address(RVA = "0x1BE5DC4", Offset = "0x1BE5DC4", VA = "0x1BE5DC4")]
  private IEnumerator CreateRankIcon(int rank) => (IEnumerator) null;

  [Token(Token = "0x6001035")]
  [Address(RVA = "0x1BE5E64", Offset = "0x1BE5E64", VA = "0x1BE5E64")]
  public void SetRankIcon(int rank)
  {
  }

  [Token(Token = "0x6001036")]
  [Address(RVA = "0x1BE5E98", Offset = "0x1BE5E98", VA = "0x1BE5E98")]
  public void UpdateRankIcon(int rank, Action OnComplate)
  {
  }

  [Token(Token = "0x6001037")]
  [Address(RVA = "0x1BE5EB8", Offset = "0x1BE5EB8", VA = "0x1BE5EB8")]
  public IEnumerator ChangeRankIcon(int nextRank, Action OnComplate) => (IEnumerator) null;

  [Token(Token = "0x6001038")]
  [Address(RVA = "0x1BE5F60", Offset = "0x1BE5F60", VA = "0x1BE5F60")]
  private void StopedPlayableDirector(PlayableDirector director)
  {
  }

  [Token(Token = "0x6001039")]
  [Address(RVA = "0x1BE5F68", Offset = "0x1BE5F68", VA = "0x1BE5F68")]
  public AreaQuestEventMissionRank()
  {
  }
}
