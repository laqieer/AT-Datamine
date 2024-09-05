// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaEventQuest.AreaEventQuestTopUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using TMPro;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.AreaEventQuest
{
  [Token(Token = "0x2003929")]
  internal class AreaEventQuestTopUI : MonoBehaviour
  {
    [Token(Token = "0x400F9D0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x400F9D1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text dateText;
    [Token(Token = "0x400F9D2")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CommonButton areaQuestButton;
    [Token(Token = "0x400F9D3")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CommonButton eventMissionButton;
    [Token(Token = "0x400F9D4")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton cumulativeMission;
    [Token(Token = "0x400F9D5")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject cumulativeMissionLock;
    [Token(Token = "0x400F9D6")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonButton exchangeShopButton;
    [Token(Token = "0x400F9D7")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Image medalImage;
    [Token(Token = "0x400F9D8")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private TextMeshProUGUI medalAmountText;
    [Token(Token = "0x400F9D9")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private CommonButton backButton;

    [Token(Token = "0x170049E5")]
    public static string AssetBundleFormat
    {
      [Token(Token = "0x6016781"), Address(RVA = "0x42E4DC4", Offset = "0x42E4DC4", VA = "0x42E4DC4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170049E6")]
    public static string AssetName
    {
      [Token(Token = "0x6016782"), Address(RVA = "0x42E4E04", Offset = "0x42E4E04", VA = "0x42E4E04")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170049E7")]
    public UITimelineController TimelineController
    {
      [Token(Token = "0x6016783"), Address(RVA = "0x42E5148", Offset = "0x42E5148", VA = "0x42E5148")] get
      {
        return (UITimelineController) null;
      }
    }

    [Token(Token = "0x170049E8")]
    public Text DateText
    {
      [Token(Token = "0x6016784"), Address(RVA = "0x42E5150", Offset = "0x42E5150", VA = "0x42E5150")] get
      {
        return (Text) null;
      }
    }

    [Token(Token = "0x170049E9")]
    public Button AreaQuestButton
    {
      [Token(Token = "0x6016785"), Address(RVA = "0x42E5158", Offset = "0x42E5158", VA = "0x42E5158")] get
      {
        return (Button) null;
      }
    }

    [Token(Token = "0x170049EA")]
    public CommonButton EventMissionButton
    {
      [Token(Token = "0x6016786"), Address(RVA = "0x42E5160", Offset = "0x42E5160", VA = "0x42E5160")] get
      {
        return (CommonButton) null;
      }
    }

    [Token(Token = "0x170049EB")]
    public CommonButton CumulativeMissionButton
    {
      [Token(Token = "0x6016787"), Address(RVA = "0x42E5168", Offset = "0x42E5168", VA = "0x42E5168")] get
      {
        return (CommonButton) null;
      }
    }

    [Token(Token = "0x170049EC")]
    public GameObject CumulativeMissionLock
    {
      [Token(Token = "0x6016788"), Address(RVA = "0x42E5170", Offset = "0x42E5170", VA = "0x42E5170")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170049ED")]
    public CommonButton ExchangeShopButton
    {
      [Token(Token = "0x6016789"), Address(RVA = "0x42E5178", Offset = "0x42E5178", VA = "0x42E5178")] get
      {
        return (CommonButton) null;
      }
    }

    [Token(Token = "0x170049EE")]
    public Image MedalImage
    {
      [Token(Token = "0x601678A"), Address(RVA = "0x42E5180", Offset = "0x42E5180", VA = "0x42E5180")] get
      {
        return (Image) null;
      }
    }

    [Token(Token = "0x170049EF")]
    public TextMeshProUGUI MedalAmountText
    {
      [Token(Token = "0x601678B"), Address(RVA = "0x42E5188", Offset = "0x42E5188", VA = "0x42E5188")] get
      {
        return (TextMeshProUGUI) null;
      }
    }

    [Token(Token = "0x170049F0")]
    public CommonButton BackButton
    {
      [Token(Token = "0x601678C"), Address(RVA = "0x42E5190", Offset = "0x42E5190", VA = "0x42E5190")] get
      {
        return (CommonButton) null;
      }
    }

    [Token(Token = "0x601678D")]
    [Address(RVA = "0x42E5198", Offset = "0x42E5198", VA = "0x42E5198")]
    public AreaEventQuestTopUI()
    {
    }
  }
}
