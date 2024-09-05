// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.GetCustomSkillView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x20036C4")]
  public class GetCustomSkillView : MonoBehaviour
  {
    [Token(Token = "0x400EEAA")]
    [FieldOffset(Offset = "0x18")]
    public float ItemProductionStartWait;
    [Token(Token = "0x400EEAB")]
    [FieldOffset(Offset = "0x1C")]
    public float ItemEffectStartInterval;
    [Token(Token = "0x400EEAC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400EEAD")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x400EEAE")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private PlayableDirector timeLinePlayableDirector;
    [Token(Token = "0x400EEAF")]
    private const string inoutTimeLineAssetbundleName = "ui_page_mnemnographdetail_timeline";
    [Token(Token = "0x400EEB0")]
    private const string inoutTimeLineAssetName = "CustomSkillGet";
    [Token(Token = "0x400EEB1")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Transform cellPearent;
    [Token(Token = "0x400EEB2")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GetCustomSkillViewCell srcGetCustomSkillViewCell;
    [Token(Token = "0x400EEB3")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CanvasGroup bgObj;
    [Token(Token = "0x400EEB4")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CommonButton centerCloseButton;
    [Token(Token = "0x400EEB7")]
    [FieldOffset(Offset = "0x5A")]
    private bool inDirect;
    [Token(Token = "0x400EEB9")]
    [FieldOffset(Offset = "0x60")]
    private List<GameObject> itemList;

    [Token(Token = "0x17004765")]
    public bool IsPlaying
    {
      [Token(Token = "0x60158EF"), Address(RVA = "0x1A62A28", Offset = "0x1A62A28", VA = "0x1A62A28")] get
      {
        return new bool();
      }
      [Token(Token = "0x60158F0"), Address(RVA = "0x1A62A30", Offset = "0x1A62A30", VA = "0x1A62A30")] set
      {
      }
    }

    [Token(Token = "0x17004766")]
    public bool ClickedNextButton
    {
      [Token(Token = "0x60158F1"), Address(RVA = "0x1A62A3C", Offset = "0x1A62A3C", VA = "0x1A62A3C")] get
      {
        return new bool();
      }
      [Token(Token = "0x60158F2"), Address(RVA = "0x1A62A44", Offset = "0x1A62A44", VA = "0x1A62A44")] set
      {
      }
    }

    [Token(Token = "0x17004767")]
    protected bool IsSkipped
    {
      [Token(Token = "0x60158F3"), Address(RVA = "0x1A62A50", Offset = "0x1A62A50", VA = "0x1A62A50")] get
      {
        return new bool();
      }
      [Token(Token = "0x60158F4"), Address(RVA = "0x1A62A58", Offset = "0x1A62A58", VA = "0x1A62A58")] set
      {
      }
    }

    [Token(Token = "0x60158F5")]
    [Address(RVA = "0x1A62A64", Offset = "0x1A62A64", VA = "0x1A62A64")]
    public void Initialize(
      List<GetCustomSkillView.stNewCustomSkillList> newCustomSkillList)
    {
    }

    [Token(Token = "0x60158F6")]
    [Address(RVA = "0x1A632E0", Offset = "0x1A632E0", VA = "0x1A632E0")]
    private void PlayTimeLine(UITimelineController.DirectionType type, Action finish)
    {
    }

    [Token(Token = "0x60158F7")]
    [Address(RVA = "0x1A63484", Offset = "0x1A63484", VA = "0x1A63484")]
    private IEnumerator ExecutePlay() => (IEnumerator) null;

    [Token(Token = "0x60158F8")]
    [Address(RVA = "0x1A6351C", Offset = "0x1A6351C", VA = "0x1A6351C")]
    private IEnumerator scrollCtrl() => (IEnumerator) null;

    [Token(Token = "0x60158F9")]
    [Address(RVA = "0x1A635AC", Offset = "0x1A635AC", VA = "0x1A635AC")]
    public GetCustomSkillView()
    {
    }

    [Token(Token = "0x20036C5")]
    public struct stNewCustomSkillList
    {
      [Token(Token = "0x400EEBA")]
      [FieldOffset(Offset = "0x0")]
      public int mindequipID;
      [Token(Token = "0x400EEBB")]
      [FieldOffset(Offset = "0x4")]
      public int customSkillID;

      [Token(Token = "0x60158FF")]
      [Address(RVA = "0x1A635E8", Offset = "0x1A635E8", VA = "0x1A635E8")]
      public stNewCustomSkillList(int mId, int cID)
      {
      }
    }
  }
}
