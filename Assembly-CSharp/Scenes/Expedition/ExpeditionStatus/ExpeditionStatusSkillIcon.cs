// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.ExpeditionStatus.ExpeditionStatusSkillIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Expedition.ExpeditionStatus
{
  [Token(Token = "0x2002CFA")]
  public class ExpeditionStatusSkillIcon : MonoBehaviour
  {
    [Token(Token = "0x400C0A9")]
    [FieldOffset(Offset = "0x18")]
    private Scenes.Expedition.ExpeditionStatus.ExpeditionStatus expeditionStatus;
    [Token(Token = "0x400C0AA")]
    [FieldOffset(Offset = "0x20")]
    private SkillDetailData skillDetailData;
    [Token(Token = "0x400C0AB")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image skillImage;
    [Token(Token = "0x400C0AC")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text skillLvText;
    [Token(Token = "0x400C0AD")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image unActiveImage;

    [Token(Token = "0x60119AC")]
    [Address(RVA = "0x46A51A0", Offset = "0x46A51A0", VA = "0x46A51A0")]
    public void Init(SkillDetailData inputSkillDetailData, Scenes.Expedition.ExpeditionStatus.ExpeditionStatus inputExpeditionStatus)
    {
    }

    [Token(Token = "0x60119AD")]
    [Address(RVA = "0x46A5258", Offset = "0x46A5258", VA = "0x46A5258")]
    public void SetUnActive()
    {
    }

    [Token(Token = "0x60119AE")]
    [Address(RVA = "0x46A6D8C", Offset = "0x46A6D8C", VA = "0x46A6D8C")]
    public void OnClickIcon()
    {
    }

    [Token(Token = "0x60119AF")]
    [Address(RVA = "0x46A6DB4", Offset = "0x46A6DB4", VA = "0x46A6DB4")]
    public ExpeditionStatusSkillIcon()
    {
    }
  }
}
