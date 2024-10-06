// Decompiled with JetBrains decompiler
// Type: Battle.UI.GiveupPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Utility;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002310")]
  [RequireComponent(typeof (GiveupTween))]
  public sealed class GiveupPanel : MonoBehaviour
  {
    [Token(Token = "0x4009453")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string[] battleNumberTokens;
    [Token(Token = "0x4009454")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [HideInInspector]
    private GiveupTween tweener;
    [Token(Token = "0x4009455")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private RewardItemPanel rewardIconTemplate;
    [Token(Token = "0x4009456")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UnityEngine.UI.Text chapterText;
    [Token(Token = "0x4009457")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private UnityEngine.UI.Text dateText;
    [Token(Token = "0x4009458")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private UnityEngine.UI.Text titleText;
    [Token(Token = "0x4009459")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private UnityEngine.UI.Text battleNumberText;
    [Token(Token = "0x400945A")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private UnityEngine.UI.Text apCostText;
    [Token(Token = "0x400945B")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private UnityEngine.UI.Text effectText;
    [Token(Token = "0x400945C")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private int initialPoolingCount;
    [Token(Token = "0x400945D")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private int maxPoolingCount;
    [Token(Token = "0x400945E")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Transform rewardPanelParent;
    [Token(Token = "0x400945F")]
    [FieldOffset(Offset = "0x70")]
    private Regex[] regexes;
    [Token(Token = "0x4009460")]
    [FieldOffset(Offset = "0x78")]
    private ObjectPool<PoolableRewardItemPanel, RewardItemPanel> panelPool;
    [Token(Token = "0x4009461")]
    [FieldOffset(Offset = "0x80")]
    private HashSet<PoolableRewardItemPanel> usingPanels;

    [Token(Token = "0x600D633")]
    [Address(RVA = "0x1D1B600", Offset = "0x1D1B600", VA = "0x1D1B600")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600D634")]
    [Address(RVA = "0x1D1B9BC", Offset = "0x1D1B9BC", VA = "0x1D1B9BC")]
    public void Show(StoryBattleConfig config)
    {
    }

    [Token(Token = "0x600D635")]
    [Address(RVA = "0x1D1C2FC", Offset = "0x1D1C2FC", VA = "0x1D1C2FC")]
    public void Hide()
    {
    }

    [Token(Token = "0x600D636")]
    [Address(RVA = "0x1D1C0EC", Offset = "0x1D1C0EC", VA = "0x1D1C0EC")]
    private void SetBattleTitle(BattleData data)
    {
    }

    [Token(Token = "0x600D637")]
    [Address(RVA = "0x1D1C540", Offset = "0x1D1C540", VA = "0x1D1C540")]
    public GiveupPanel()
    {
    }
  }
}
