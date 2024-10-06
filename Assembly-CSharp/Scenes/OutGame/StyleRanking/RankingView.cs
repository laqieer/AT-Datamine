// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.StyleRanking.RankingView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.StyleRanking
{
  [Token(Token = "0x2003363")]
  internal class RankingView : MonoBehaviour
  {
    [Token(Token = "0x400DEA5")]
    [FieldOffset(Offset = "0x0")]
    private static int rankingLimit;
    [Token(Token = "0x400DEA6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject first;
    [Token(Token = "0x400DEA7")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject second;
    [Token(Token = "0x400DEA8")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject third;
    [Token(Token = "0x400DEA9")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject upToTenth;
    [Token(Token = "0x400DEAA")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject other;
    [Token(Token = "0x400DEAB")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextMeshProUGUI rankingText;

    [Token(Token = "0x601431B")]
    [Address(RVA = "0x1E16A84", Offset = "0x1E16A84", VA = "0x1E16A84")]
    public void SetRanking(int ranking)
    {
    }

    [Token(Token = "0x601431C")]
    [Address(RVA = "0x1E16C44", Offset = "0x1E16C44", VA = "0x1E16C44")]
    public void SetNotPossession()
    {
    }

    [Token(Token = "0x601431D")]
    [Address(RVA = "0x1E16BA0", Offset = "0x1E16BA0", VA = "0x1E16BA0")]
    private void SetRankingBase(int ranking)
    {
    }

    [Token(Token = "0x601431E")]
    [Address(RVA = "0x1E16CAC", Offset = "0x1E16CAC", VA = "0x1E16CAC")]
    public RankingView()
    {
    }

    [Token(Token = "0x601431F")]
    [Address(RVA = "0x1E16CB4", Offset = "0x1E16CB4", VA = "0x1E16CB4")]
    static RankingView()
    {
    }
  }
}
