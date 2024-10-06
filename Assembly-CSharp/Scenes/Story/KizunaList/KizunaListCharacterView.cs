// Decompiled with JetBrains decompiler
// Type: Scenes.Story.KizunaList.KizunaListCharacterView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using TMPro;
using UI.Utilities;
using UnityEngine;

#nullable disable
namespace Scenes.Story.KizunaList
{
  [Token(Token = "0x2002E99")]
  public class KizunaListCharacterView : MonoBehaviour
  {
    [Token(Token = "0x400C7B4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject characterLockMask;
    [Token(Token = "0x400C7B5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ImageAdjustController characterImageAdjustController;
    [Token(Token = "0x400C7B6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject existingInFieldIcon;
    [Token(Token = "0x400C7B7")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject pastMaxRankIconRoot;
    [Token(Token = "0x400C7B8")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI pastMaxRankNumText;
    [Token(Token = "0x400C7B9")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private KizunaListCommuRankGaugeIcon commuRankGaugeIcon;
    [Token(Token = "0x400C7BA")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject commuRankGaugeIconMax;
    [Token(Token = "0x400C7BB")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject commuRankGaugeIconLocked;
    [Token(Token = "0x400C7BC")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject canRankUpIcon;
    [Token(Token = "0x400C7BD")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private CommonButton cursorButton;
    [Token(Token = "0x400C7BE")]
    [FieldOffset(Offset = "0x68")]
    public Action<KizunaQuestInfo.KizunaQuestCharacterInfo> OnClickCursor;
    [Token(Token = "0x400C7BF")]
    [FieldOffset(Offset = "0x70")]
    private KizunaQuestInfo.KizunaQuestCharacterInfo characterInfo;
    [Token(Token = "0x400C7C0")]
    [FieldOffset(Offset = "0x0")]
    private static readonly Color CharacterDisabledColor;

    [Token(Token = "0x6012312")]
    [Address(RVA = "0x4594018", Offset = "0x4594018", VA = "0x4594018")]
    public void Initialize(
      KizunaListCharacterImageLoader characterImageLoader,
      KizunaQuestInfo.KizunaQuestCharacterInfo characterInfo)
    {
    }

    [Token(Token = "0x6012313")]
    [Address(RVA = "0x4594430", Offset = "0x4594430", VA = "0x4594430")]
    public KizunaListCharacterView()
    {
    }

    [Token(Token = "0x6012314")]
    [Address(RVA = "0x4594438", Offset = "0x4594438", VA = "0x4594438")]
    static KizunaListCharacterView()
    {
    }
  }
}
