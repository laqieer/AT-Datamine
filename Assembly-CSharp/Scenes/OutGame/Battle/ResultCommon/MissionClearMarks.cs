// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.ResultCommon.MissionClearMarks
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Battle.ResultCommon
{
  [Token(Token = "0x20037E8")]
  public class MissionClearMarks : MonoBehaviour
  {
    [Token(Token = "0x400F44B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject _topNode;
    [Token(Token = "0x400F44C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject[] _missionClearMark;
    [Token(Token = "0x400F44D")]
    [FieldOffset(Offset = "0x28")]
    [Header("Tweenアニメ")]
    [SerializeField]
    private UITweenGroup _tweenGroup;
    [Token(Token = "0x400F44E")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private string[] _missionClearInNames;
    [Token(Token = "0x400F44F")]
    [FieldOffset(Offset = "0x38")]
    private bool[] _missionClear;

    [Token(Token = "0x6015FE5")]
    [Address(RVA = "0x232FF38", Offset = "0x232FF38", VA = "0x232FF38")]
    public void Initialize(bool[] missionClear)
    {
    }

    [Token(Token = "0x6015FE6")]
    [Address(RVA = "0x232EFEC", Offset = "0x232EFEC", VA = "0x232EFEC")]
    public void PlayCheck()
    {
    }

    [Token(Token = "0x6015FE7")]
    [Address(RVA = "0x232FF40", Offset = "0x232FF40", VA = "0x232FF40")]
    public MissionClearMarks()
    {
    }
  }
}
