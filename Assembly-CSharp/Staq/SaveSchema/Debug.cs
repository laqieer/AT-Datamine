// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.Debug
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CA2")]
  public struct Debug : IFlatbufferObject
  {
    [Token(Token = "0x4010C01")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004EF9")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x601827F"), Address(RVA = "0x3B24164", Offset = "0x3B24164", VA = "0x3B24164", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018280")]
    [Address(RVA = "0x3B2416C", Offset = "0x3B2416C", VA = "0x3B2416C")]
    public static Debug GetRootAsDebug(ByteBuffer _bb) => new Debug();

    [Token(Token = "0x6018281")]
    [Address(RVA = "0x3B24178", Offset = "0x3B24178", VA = "0x3B24178")]
    public static Debug GetRootAsDebug(ByteBuffer _bb, Debug obj) => new Debug();

    [Token(Token = "0x6018282")]
    [Address(RVA = "0x3B241D4", Offset = "0x3B241D4", VA = "0x3B241D4")]
    public static bool DebugBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x6018283")]
    [Address(RVA = "0x3B24220", Offset = "0x3B24220", VA = "0x3B24220", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018284")]
    [Address(RVA = "0x3B241BC", Offset = "0x3B241BC", VA = "0x3B241BC")]
    public Debug __assign(int _i, ByteBuffer _bb) => new Debug();

    [Token(Token = "0x17004EFA")]
    public bool UseDlc
    {
      [Token(Token = "0x6018285"), Address(RVA = "0x3B2422C", Offset = "0x3B2422C", VA = "0x3B2422C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004EFB")]
    public bool IgnoreSystemLog
    {
      [Token(Token = "0x6018286"), Address(RVA = "0x3B24274", Offset = "0x3B24274", VA = "0x3B24274")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004EFC")]
    public bool IgnoreNetworkLog
    {
      [Token(Token = "0x6018287"), Address(RVA = "0x3B242BC", Offset = "0x3B242BC", VA = "0x3B242BC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004EFD")]
    public bool PlayerSaveUsers
    {
      [Token(Token = "0x6018288"), Address(RVA = "0x3B24304", Offset = "0x3B24304", VA = "0x3B24304")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004EFE")]
    public bool MeterDisplay
    {
      [Token(Token = "0x6018289"), Address(RVA = "0x3B2434C", Offset = "0x3B2434C", VA = "0x3B2434C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004EFF")]
    public bool ConsoleDisplay
    {
      [Token(Token = "0x601828A"), Address(RVA = "0x3B24394", Offset = "0x3B24394", VA = "0x3B24394")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004F00")]
    public bool ConsoleActive
    {
      [Token(Token = "0x601828B"), Address(RVA = "0x3B243DC", Offset = "0x3B243DC", VA = "0x3B243DC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004F01")]
    public bool DisableError
    {
      [Token(Token = "0x601828C"), Address(RVA = "0x3B24424", Offset = "0x3B24424", VA = "0x3B24424")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004F02")]
    public bool DisableLogLimit
    {
      [Token(Token = "0x601828D"), Address(RVA = "0x3B2446C", Offset = "0x3B2446C", VA = "0x3B2446C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004F03")]
    public int LogLimitNum
    {
      [Token(Token = "0x601828E"), Address(RVA = "0x3B244B4", Offset = "0x3B244B4", VA = "0x3B244B4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004F04")]
    public bool DebugButtonInvisible
    {
      [Token(Token = "0x601828F"), Address(RVA = "0x3B244FC", Offset = "0x3B244FC", VA = "0x3B244FC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004F05")]
    public bool DebugButtonPositionEnabled
    {
      [Token(Token = "0x6018290"), Address(RVA = "0x3B24544", Offset = "0x3B24544", VA = "0x3B24544")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004F06")]
    public float DebugButtonPositionX
    {
      [Token(Token = "0x6018291"), Address(RVA = "0x3B2458C", Offset = "0x3B2458C", VA = "0x3B2458C")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17004F07")]
    public float DebugButtonPositionY
    {
      [Token(Token = "0x6018292"), Address(RVA = "0x3B245D4", Offset = "0x3B245D4", VA = "0x3B245D4")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17004F08")]
    public string ProxyServerName
    {
      [Token(Token = "0x6018293"), Address(RVA = "0x3B2461C", Offset = "0x3B2461C", VA = "0x3B2461C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018294")]
    [Address(RVA = "0x3B24658", Offset = "0x3B24658", VA = "0x3B24658")]
    public ArraySegment<byte>? GetProxyServerNameBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6018295")]
    [Address(RVA = "0x3B24690", Offset = "0x3B24690", VA = "0x3B24690")]
    public byte[] GetProxyServerNameArray() => (byte[]) null;

    [Token(Token = "0x17004F09")]
    public bool CopyErrorLogs
    {
      [Token(Token = "0x6018296"), Address(RVA = "0x3B246DC", Offset = "0x3B246DC", VA = "0x3B246DC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004F0A")]
    public bool ShowFullDuelAnimation
    {
      [Token(Token = "0x6018297"), Address(RVA = "0x3B24724", Offset = "0x3B24724", VA = "0x3B24724")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004F0B")]
    public int DuelPlaySpeed
    {
      [Token(Token = "0x6018298"), Address(RVA = "0x3B2476C", Offset = "0x3B2476C", VA = "0x3B2476C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004F0C")]
    public bool DebugmodeAdv
    {
      [Token(Token = "0x6018299"), Address(RVA = "0x3B247B4", Offset = "0x3B247B4", VA = "0x3B247B4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004F0D")]
    public bool DebugmodeAdvTextcolor
    {
      [Token(Token = "0x601829A"), Address(RVA = "0x3B247FC", Offset = "0x3B247FC", VA = "0x3B247FC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004F0E")]
    public bool ShowInspector
    {
      [Token(Token = "0x601829B"), Address(RVA = "0x3B24844", Offset = "0x3B24844", VA = "0x3B24844")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004F0F")]
    public bool ShowLoadedSoundBank
    {
      [Token(Token = "0x601829C"), Address(RVA = "0x3B2488C", Offset = "0x3B2488C", VA = "0x3B2488C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004F10")]
    public bool ShowGameTime
    {
      [Token(Token = "0x601829D"), Address(RVA = "0x3B248D4", Offset = "0x3B248D4", VA = "0x3B248D4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004F11")]
    public bool IgnorePreHomeEvent
    {
      [Token(Token = "0x601829E"), Address(RVA = "0x3B2491C", Offset = "0x3B2491C", VA = "0x3B2491C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004F12")]
    public bool IgnoreLoginBonus
    {
      [Token(Token = "0x601829F"), Address(RVA = "0x3B24964", Offset = "0x3B24964", VA = "0x3B24964")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004F13")]
    public bool IgnoreIntroChapter
    {
      [Token(Token = "0x60182A0"), Address(RVA = "0x3B249AC", Offset = "0x3B249AC", VA = "0x3B249AC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60182A1")]
    [Address(RVA = "0x3B249F4", Offset = "0x3B249F4", VA = "0x3B249F4")]
    public static Offset<Debug> CreateDebug(
      FlatBufferBuilder builder,
      bool use_dlc = false,
      bool ignore_system_log = false,
      bool ignore_network_log = false,
      bool player_save_users = false,
      bool meter_display = false,
      bool console_display = false,
      bool console_active = false,
      bool disable_error = false,
      bool disable_log_limit = false,
      int log_limit_num = 100,
      bool debug_button_invisible = false,
      bool debug_button_position_enabled = false,
      float debug_button_position_x = 0.0f,
      float debug_button_position_y = 0.0f,
      StringOffset proxy_server_nameOffset = default (StringOffset),
      bool copy_error_logs = false,
      bool show_full_duel_animation = false,
      int duel_play_speed = 1,
      bool debugmode_adv = false,
      bool debugmode_adv_textcolor = false,
      bool show_inspector = false,
      bool show_loaded_sound_bank = false,
      bool show_game_time = false,
      bool ignore_pre_home_event = false,
      bool ignore_login_bonus = false,
      bool ignore_intro_chapter = false)
    {
      return new Offset<Debug>();
    }

    [Token(Token = "0x60182A2")]
    [Address(RVA = "0x3B24FCC", Offset = "0x3B24FCC", VA = "0x3B24FCC")]
    public static void StartDebug(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x60182A3")]
    [Address(RVA = "0x3B24F5C", Offset = "0x3B24F5C", VA = "0x3B24F5C")]
    public static void AddUseDlc(FlatBufferBuilder builder, bool useDlc)
    {
    }

    [Token(Token = "0x60182A4")]
    [Address(RVA = "0x3B24F3C", Offset = "0x3B24F3C", VA = "0x3B24F3C")]
    public static void AddIgnoreSystemLog(FlatBufferBuilder builder, bool ignoreSystemLog)
    {
    }

    [Token(Token = "0x60182A5")]
    [Address(RVA = "0x3B24F1C", Offset = "0x3B24F1C", VA = "0x3B24F1C")]
    public static void AddIgnoreNetworkLog(FlatBufferBuilder builder, bool ignoreNetworkLog)
    {
    }

    [Token(Token = "0x60182A6")]
    [Address(RVA = "0x3B24EFC", Offset = "0x3B24EFC", VA = "0x3B24EFC")]
    public static void AddPlayerSaveUsers(FlatBufferBuilder builder, bool playerSaveUsers)
    {
    }

    [Token(Token = "0x60182A7")]
    [Address(RVA = "0x3B24EDC", Offset = "0x3B24EDC", VA = "0x3B24EDC")]
    public static void AddMeterDisplay(FlatBufferBuilder builder, bool meterDisplay)
    {
    }

    [Token(Token = "0x60182A8")]
    [Address(RVA = "0x3B24EBC", Offset = "0x3B24EBC", VA = "0x3B24EBC")]
    public static void AddConsoleDisplay(FlatBufferBuilder builder, bool consoleDisplay)
    {
    }

    [Token(Token = "0x60182A9")]
    [Address(RVA = "0x3B24E9C", Offset = "0x3B24E9C", VA = "0x3B24E9C")]
    public static void AddConsoleActive(FlatBufferBuilder builder, bool consoleActive)
    {
    }

    [Token(Token = "0x60182AA")]
    [Address(RVA = "0x3B24E7C", Offset = "0x3B24E7C", VA = "0x3B24E7C")]
    public static void AddDisableError(FlatBufferBuilder builder, bool disableError)
    {
    }

    [Token(Token = "0x60182AB")]
    [Address(RVA = "0x3B24E5C", Offset = "0x3B24E5C", VA = "0x3B24E5C")]
    public static void AddDisableLogLimit(FlatBufferBuilder builder, bool disableLogLimit)
    {
    }

    [Token(Token = "0x60182AC")]
    [Address(RVA = "0x3B24CBC", Offset = "0x3B24CBC", VA = "0x3B24CBC")]
    public static void AddLogLimitNum(FlatBufferBuilder builder, int logLimitNum)
    {
    }

    [Token(Token = "0x60182AD")]
    [Address(RVA = "0x3B24E3C", Offset = "0x3B24E3C", VA = "0x3B24E3C")]
    public static void AddDebugButtonInvisible(FlatBufferBuilder builder, bool debugButtonInvisible)
    {
    }

    [Token(Token = "0x60182AE")]
    [Address(RVA = "0x3B24E1C", Offset = "0x3B24E1C", VA = "0x3B24E1C")]
    public static void AddDebugButtonPositionEnabled(
      FlatBufferBuilder builder,
      bool debugButtonPositionEnabled)
    {
    }

    [Token(Token = "0x60182AF")]
    [Address(RVA = "0x3B24CA0", Offset = "0x3B24CA0", VA = "0x3B24CA0")]
    public static void AddDebugButtonPositionX(
      FlatBufferBuilder builder,
      float debugButtonPositionX)
    {
    }

    [Token(Token = "0x60182B0")]
    [Address(RVA = "0x3B24C84", Offset = "0x3B24C84", VA = "0x3B24C84")]
    public static void AddDebugButtonPositionY(
      FlatBufferBuilder builder,
      float debugButtonPositionY)
    {
    }

    [Token(Token = "0x60182B1")]
    [Address(RVA = "0x3B24C64", Offset = "0x3B24C64", VA = "0x3B24C64")]
    public static void AddProxyServerName(
      FlatBufferBuilder builder,
      StringOffset proxyServerNameOffset)
    {
    }

    [Token(Token = "0x60182B2")]
    [Address(RVA = "0x3B24DFC", Offset = "0x3B24DFC", VA = "0x3B24DFC")]
    public static void AddCopyErrorLogs(FlatBufferBuilder builder, bool copyErrorLogs)
    {
    }

    [Token(Token = "0x60182B3")]
    [Address(RVA = "0x3B24DDC", Offset = "0x3B24DDC", VA = "0x3B24DDC")]
    public static void AddShowFullDuelAnimation(
      FlatBufferBuilder builder,
      bool showFullDuelAnimation)
    {
    }

    [Token(Token = "0x60182B4")]
    [Address(RVA = "0x3B24C44", Offset = "0x3B24C44", VA = "0x3B24C44")]
    public static void AddDuelPlaySpeed(FlatBufferBuilder builder, int duelPlaySpeed)
    {
    }

    [Token(Token = "0x60182B5")]
    [Address(RVA = "0x3B24DBC", Offset = "0x3B24DBC", VA = "0x3B24DBC")]
    public static void AddDebugmodeAdv(FlatBufferBuilder builder, bool debugmodeAdv)
    {
    }

    [Token(Token = "0x60182B6")]
    [Address(RVA = "0x3B24D9C", Offset = "0x3B24D9C", VA = "0x3B24D9C")]
    public static void AddDebugmodeAdvTextcolor(
      FlatBufferBuilder builder,
      bool debugmodeAdvTextcolor)
    {
    }

    [Token(Token = "0x60182B7")]
    [Address(RVA = "0x3B24D7C", Offset = "0x3B24D7C", VA = "0x3B24D7C")]
    public static void AddShowInspector(FlatBufferBuilder builder, bool showInspector)
    {
    }

    [Token(Token = "0x60182B8")]
    [Address(RVA = "0x3B24D5C", Offset = "0x3B24D5C", VA = "0x3B24D5C")]
    public static void AddShowLoadedSoundBank(FlatBufferBuilder builder, bool showLoadedSoundBank)
    {
    }

    [Token(Token = "0x60182B9")]
    [Address(RVA = "0x3B24D3C", Offset = "0x3B24D3C", VA = "0x3B24D3C")]
    public static void AddShowGameTime(FlatBufferBuilder builder, bool showGameTime)
    {
    }

    [Token(Token = "0x60182BA")]
    [Address(RVA = "0x3B24D1C", Offset = "0x3B24D1C", VA = "0x3B24D1C")]
    public static void AddIgnorePreHomeEvent(FlatBufferBuilder builder, bool ignorePreHomeEvent)
    {
    }

    [Token(Token = "0x60182BB")]
    [Address(RVA = "0x3B24CFC", Offset = "0x3B24CFC", VA = "0x3B24CFC")]
    public static void AddIgnoreLoginBonus(FlatBufferBuilder builder, bool ignoreLoginBonus)
    {
    }

    [Token(Token = "0x60182BC")]
    [Address(RVA = "0x3B24CDC", Offset = "0x3B24CDC", VA = "0x3B24CDC")]
    public static void AddIgnoreIntroChapter(FlatBufferBuilder builder, bool ignoreIntroChapter)
    {
    }

    [Token(Token = "0x60182BD")]
    [Address(RVA = "0x3B24F7C", Offset = "0x3B24F7C", VA = "0x3B24F7C")]
    public static Offset<Debug> EndDebug(FlatBufferBuilder builder) => new Offset<Debug>();

    [Token(Token = "0x60182BE")]
    [Address(RVA = "0x3B24FE4", Offset = "0x3B24FE4", VA = "0x3B24FE4")]
    public static void FinishDebugBuffer(FlatBufferBuilder builder, Offset<Debug> offset)
    {
    }

    [Token(Token = "0x60182BF")]
    [Address(RVA = "0x3B25040", Offset = "0x3B25040", VA = "0x3B25040")]
    public static void FinishSizePrefixedDebugBuffer(
      FlatBufferBuilder builder,
      Offset<Debug> offset)
    {
    }
  }
}
