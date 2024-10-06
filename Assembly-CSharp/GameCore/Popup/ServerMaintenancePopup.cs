// Decompiled with JetBrains decompiler
// Type: GameCore.Popup.ServerMaintenancePopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace GameCore.Popup
{
  [Token(Token = "0x2000D0C")]
  public class ServerMaintenancePopup : PopupBase
  {
    [Token(Token = "0x4003A36")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text messageText;
    [Token(Token = "0x4003A37")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text cautionText;
    [Token(Token = "0x4003A38")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private GameObject scheduleRoot;
    [Token(Token = "0x4003A39")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private TMP_Text scheduleText;
    [Token(Token = "0x4003A3A")]
    [FieldOffset(Offset = "0xA8")]
    private Action twitterButtonClicked;
    [Token(Token = "0x4003A3B")]
    [FieldOffset(Offset = "0xB0")]
    private string URL;

    [Token(Token = "0x17000AF6")]
    private string DownloadURL
    {
      [Token(Token = "0x6004AFC"), Address(RVA = "0x3142D00", Offset = "0x3142D00", VA = "0x3142D00")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000AF7")]
    private string DefaultMessage
    {
      [Token(Token = "0x6004AFD"), Address(RVA = "0x3142D4C", Offset = "0x3142D4C", VA = "0x3142D4C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000AF8")]
    private string DefaultCaution
    {
      [Token(Token = "0x6004AFE"), Address(RVA = "0x3142DCC", Offset = "0x3142DCC", VA = "0x3142DCC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6004AFF")]
    [Address(RVA = "0x3142E4C", Offset = "0x3142E4C", VA = "0x3142E4C")]
    public static PopupHandle CreateAndOpen(Action twitterButtonClicked) => (PopupHandle) null;

    [Token(Token = "0x6004B00")]
    [Address(RVA = "0x31430C4", Offset = "0x31430C4", VA = "0x31430C4")]
    private void Awake()
    {
    }

    [Token(Token = "0x6004B01")]
    [Address(RVA = "0x3143158", Offset = "0x3143158", VA = "0x3143158")]
    private void OnClickTwitter()
    {
    }

    [Token(Token = "0x6004B02")]
    [Address(RVA = "0x31430A4", Offset = "0x31430A4", VA = "0x31430A4")]
    private void Initialize(Action twitterButtonClicked, Action onFinished)
    {
    }

    [Token(Token = "0x6004B03")]
    [Address(RVA = "0x314318C", Offset = "0x314318C", VA = "0x314318C")]
    private IEnumerator InitializeAsync(Action twitterButtonClicked, Action onFinished)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6004B04")]
    [Address(RVA = "0x3143208", Offset = "0x3143208", VA = "0x3143208")]
    private IEnumerator RequestMaintenaceData(
      Action<ServerMaintenancePopup.MaintenanceData> onFinished)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6004B05")]
    [Address(RVA = "0x314327C", Offset = "0x314327C", VA = "0x314327C")]
    private void SetMessage(string message)
    {
    }

    [Token(Token = "0x6004B06")]
    [Address(RVA = "0x31432E0", Offset = "0x31432E0", VA = "0x31432E0")]
    private void SetCaution(string caution)
    {
    }

    [Token(Token = "0x6004B07")]
    [Address(RVA = "0x3143344", Offset = "0x3143344", VA = "0x3143344")]
    private void SetSchedule(DateTime? beginAt, DateTime? endAt)
    {
    }

    [Token(Token = "0x6004B08")]
    [Address(RVA = "0x314348C", Offset = "0x314348C", VA = "0x314348C")]
    public ServerMaintenancePopup()
    {
    }

    [Token(Token = "0x2000D0D")]
    [Serializable]
    public class MaintenanceDataJson
    {
      [Token(Token = "0x4003A3C")]
      [FieldOffset(Offset = "0x10")]
      public string message;
      [Token(Token = "0x4003A3D")]
      [FieldOffset(Offset = "0x18")]
      public string caution;
      [Token(Token = "0x4003A3E")]
      [FieldOffset(Offset = "0x20")]
      public string maintenance_start_at;
      [Token(Token = "0x4003A3F")]
      [FieldOffset(Offset = "0x28")]
      public string maintenance_end_at;

      [Token(Token = "0x6004B09")]
      [Address(RVA = "0x32E2A64", Offset = "0x32E2A64", VA = "0x32E2A64")]
      public MaintenanceDataJson()
      {
      }
    }

    [Token(Token = "0x2000D0E")]
    public class MaintenanceData
    {
      [Token(Token = "0x17000AF9")]
      public string Message
      {
        [Token(Token = "0x6004B0A"), Address(RVA = "0x32E2A6C", Offset = "0x32E2A6C", VA = "0x32E2A6C")] get
        {
          return (string) null;
        }
        [Token(Token = "0x6004B0B"), Address(RVA = "0x32E2A74", Offset = "0x32E2A74", VA = "0x32E2A74")] private set
        {
        }
      }

      [Token(Token = "0x17000AFA")]
      public string Caution
      {
        [Token(Token = "0x6004B0C"), Address(RVA = "0x32E2A7C", Offset = "0x32E2A7C", VA = "0x32E2A7C")] get
        {
          return (string) null;
        }
        [Token(Token = "0x6004B0D"), Address(RVA = "0x32E2A84", Offset = "0x32E2A84", VA = "0x32E2A84")] private set
        {
        }
      }

      [Token(Token = "0x17000AFB")]
      public DateTime? BeginAt
      {
        [Token(Token = "0x6004B0E"), Address(RVA = "0x32E2A8C", Offset = "0x32E2A8C", VA = "0x32E2A8C")] get
        {
          return new DateTime?();
        }
        [Token(Token = "0x6004B0F"), Address(RVA = "0x32E2A98", Offset = "0x32E2A98", VA = "0x32E2A98")] private set
        {
        }
      }

      [Token(Token = "0x17000AFC")]
      public DateTime? EndAt
      {
        [Token(Token = "0x6004B10"), Address(RVA = "0x32E2AA0", Offset = "0x32E2AA0", VA = "0x32E2AA0")] get
        {
          return new DateTime?();
        }
        [Token(Token = "0x6004B11"), Address(RVA = "0x32E2AAC", Offset = "0x32E2AAC", VA = "0x32E2AAC")] private set
        {
        }
      }

      [Token(Token = "0x6004B12")]
      [Address(RVA = "0x32E2AB4", Offset = "0x32E2AB4", VA = "0x32E2AB4")]
      public static ServerMaintenancePopup.MaintenanceData CreateDefault()
      {
        return (ServerMaintenancePopup.MaintenanceData) null;
      }

      [Token(Token = "0x6004B13")]
      [Address(RVA = "0x32E2B18", Offset = "0x32E2B18", VA = "0x32E2B18")]
      public static ServerMaintenancePopup.MaintenanceData CreateByServerData(
        ServerMaintenancePopup.MaintenanceDataJson json)
      {
        return (ServerMaintenancePopup.MaintenanceData) null;
      }

      [Token(Token = "0x6004B14")]
      [Address(RVA = "0x32E2B10", Offset = "0x32E2B10", VA = "0x32E2B10")]
      public MaintenanceData()
      {
      }
    }
  }
}
