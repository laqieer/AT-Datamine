// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaEventQuest.CumulativeMissionList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.AreaEventQuest
{
  [Token(Token = "0x200392C")]
  internal class CumulativeMissionList : MonoBehaviour
  {
    [Token(Token = "0x400F9E4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ScrollRect scroll;
    [Token(Token = "0x400F9E5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RectTransform cellParent;
    [Token(Token = "0x400F9E6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CumulativeMissionCell cellObj;
    [Token(Token = "0x400F9E7")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI achievementCountText;
    [Token(Token = "0x400F9E8")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI targetCountText;
    [Token(Token = "0x400F9E9")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Slider achievementGauge;
    [Token(Token = "0x400F9EA")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private TextMeshProUGUI titleText;
    [Token(Token = "0x400F9EB")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private TextMeshProUGUI updateInformationText;
    [Token(Token = "0x400F9EC")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CommonButton recieveButton;
    [Token(Token = "0x400F9ED")]
    [FieldOffset(Offset = "0x60")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400F9EE")]
    [FieldOffset(Offset = "0x68")]
    private Action recieveAction;
    [Token(Token = "0x400F9EF")]
    [FieldOffset(Offset = "0x70")]
    private List<CumulativeMissionCell> createCells;
    [Token(Token = "0x400F9F0")]
    [FieldOffset(Offset = "0x78")]
    private SpriteAtlas spriteAtlas;

    [Token(Token = "0x170049F1")]
    private static string AssetBundleFormat
    {
      [Token(Token = "0x6016796"), Address(RVA = "0x42E5930", Offset = "0x42E5930", VA = "0x42E5930")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6016797")]
    [Address(RVA = "0x42E5970", Offset = "0x42E5970", VA = "0x42E5970")]
    public IEnumerator InitializeAsync(
      int eventId,
      int resourceId,
      AssetCachedSpawner assetCachedSpawner,
      Action recieveAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016798")]
    [Address(RVA = "0x42E5A28", Offset = "0x42E5A28", VA = "0x42E5A28")]
    public void UpdateMissionList(
      int tabId,
      List<TotalMissionTabType> response,
      Action<RewardTypeEnum, int> openItemDetailAction)
    {
    }

    [Token(Token = "0x6016799")]
    [Address(RVA = "0x42E5F78", Offset = "0x42E5F78", VA = "0x42E5F78")]
    private bool ExistCanRecieve(List<TotalMissionDetailData> detail, TotalMissionTabType tabType)
    {
      return new bool();
    }

    [Token(Token = "0x601679A")]
    [Address(RVA = "0x42E6150", Offset = "0x42E6150", VA = "0x42E6150")]
    private void OnClickRecieve()
    {
    }

    [Token(Token = "0x601679B")]
    [Address(RVA = "0x42E6174", Offset = "0x42E6174", VA = "0x42E6174")]
    public CumulativeMissionList()
    {
    }
  }
}
