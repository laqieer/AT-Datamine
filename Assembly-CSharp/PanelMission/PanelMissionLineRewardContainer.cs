// Decompiled with JetBrains decompiler
// Type: PanelMission.PanelMissionLineRewardContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace PanelMission
{
  [Token(Token = "0x2000A08")]
  public class PanelMissionLineRewardContainer : MonoBehaviour
  {
    [Token(Token = "0x4002E77")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<PanelMissionLineRewardElement> _elements;
    [Token(Token = "0x4002E78")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject _gauge;

    [Token(Token = "0x6003930")]
    [Address(RVA = "0x310FC2C", Offset = "0x310FC2C", VA = "0x310FC2C")]
    public IEnumerator InitializeAsync(int panelMissionGroupId) => (IEnumerator) null;

    [Token(Token = "0x6003931")]
    [Address(RVA = "0x310E114", Offset = "0x310E114", VA = "0x310E114")]
    public void ActivateLineRewardFlashEffect(int lineNum, bool value)
    {
    }

    [Token(Token = "0x6003932")]
    [Address(RVA = "0x310E290", Offset = "0x310E290", VA = "0x310E290")]
    public void MakeLineRewardReceived(int lineNum)
    {
    }

    [Token(Token = "0x6003933")]
    [Address(RVA = "0x310E3DC", Offset = "0x310E3DC", VA = "0x310E3DC")]
    public void SetGauge(int completeLineCount)
    {
    }

    [Token(Token = "0x6003934")]
    [Address(RVA = "0x3112CB4", Offset = "0x3112CB4", VA = "0x3112CB4")]
    public PanelMissionLineRewardContainer()
    {
    }
  }
}
