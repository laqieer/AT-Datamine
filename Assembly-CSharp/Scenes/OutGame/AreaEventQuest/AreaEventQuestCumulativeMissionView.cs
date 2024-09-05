// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaEventQuest.AreaEventQuestCumulativeMissionView
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
  [Token(Token = "0x200391E")]
  internal class AreaEventQuestCumulativeMissionView : MonoBehaviour
  {
    [Token(Token = "0x400F9AA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x400F9AB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI limitText;
    [Token(Token = "0x400F9AC")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image charaImage;
    [Token(Token = "0x400F9AD")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CumulativeMissionList missionList;
    [Token(Token = "0x400F9AE")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CumulativeMissionTabList tabList;
    [Token(Token = "0x400F9AF")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton backButton;

    [Token(Token = "0x170049D0")]
    public static string AssetBundleFormat
    {
      [Token(Token = "0x6016732"), Address(RVA = "0x42E2C5C", Offset = "0x42E2C5C", VA = "0x42E2C5C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170049D1")]
    public static string AssetName
    {
      [Token(Token = "0x6016733"), Address(RVA = "0x42E2C9C", Offset = "0x42E2C9C", VA = "0x42E2C9C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170049D2")]
    public UITimelineController TimelineController
    {
      [Token(Token = "0x6016734"), Address(RVA = "0x42E2CDC", Offset = "0x42E2CDC", VA = "0x42E2CDC")] get
      {
        return (UITimelineController) null;
      }
    }

    [Token(Token = "0x170049D3")]
    public TextMeshProUGUI LimitText
    {
      [Token(Token = "0x6016735"), Address(RVA = "0x42E2CE4", Offset = "0x42E2CE4", VA = "0x42E2CE4")] get
      {
        return (TextMeshProUGUI) null;
      }
    }

    [Token(Token = "0x170049D4")]
    public Image CharaImage
    {
      [Token(Token = "0x6016736"), Address(RVA = "0x42E2CEC", Offset = "0x42E2CEC", VA = "0x42E2CEC")] get
      {
        return (Image) null;
      }
    }

    [Token(Token = "0x170049D5")]
    public CumulativeMissionList MissionList
    {
      [Token(Token = "0x6016737"), Address(RVA = "0x42E2CF4", Offset = "0x42E2CF4", VA = "0x42E2CF4")] get
      {
        return (CumulativeMissionList) null;
      }
    }

    [Token(Token = "0x170049D6")]
    public CumulativeMissionTabList TabList
    {
      [Token(Token = "0x6016738"), Address(RVA = "0x42E2CFC", Offset = "0x42E2CFC", VA = "0x42E2CFC")] get
      {
        return (CumulativeMissionTabList) null;
      }
    }

    [Token(Token = "0x170049D7")]
    public CommonButton BackButton
    {
      [Token(Token = "0x6016739"), Address(RVA = "0x42E2D04", Offset = "0x42E2D04", VA = "0x42E2D04")] get
      {
        return (CommonButton) null;
      }
    }

    [Token(Token = "0x601673A")]
    [Address(RVA = "0x42E2D0C", Offset = "0x42E2D0C", VA = "0x42E2D0C")]
    public AreaEventQuestCumulativeMissionView()
    {
    }
  }
}
