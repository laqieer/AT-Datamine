// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.GraphyManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Tayx.Graphy.Advanced;
using Tayx.Graphy.Audio;
using Tayx.Graphy.Fps;
using Tayx.Graphy.Ram;
using Tayx.Graphy.Utils;
using UnityEngine;

#nullable disable
namespace Tayx.Graphy
{
  [Token(Token = "0x2000388")]
  public class GraphyManager : G_Singleton<GraphyManager>
  {
    [Token(Token = "0x400149F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GraphyManager.Mode m_graphyMode;
    [Token(Token = "0x40014A0")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private bool m_enableOnStartup;
    [Token(Token = "0x40014A1")]
    [FieldOffset(Offset = "0x1D")]
    [SerializeField]
    private bool m_keepAlive;
    [Token(Token = "0x40014A2")]
    [FieldOffset(Offset = "0x1E")]
    [SerializeField]
    private bool m_background;
    [Token(Token = "0x40014A3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Color m_backgroundColor;
    [Token(Token = "0x40014A4")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private bool m_enableHotkeys;
    [Token(Token = "0x40014A5")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private KeyCode m_toggleModeKeyCode;
    [Token(Token = "0x40014A6")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private bool m_toggleModeCtrl;
    [Token(Token = "0x40014A7")]
    [FieldOffset(Offset = "0x39")]
    [SerializeField]
    private bool m_toggleModeAlt;
    [Token(Token = "0x40014A8")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private KeyCode m_toggleActiveKeyCode;
    [Token(Token = "0x40014A9")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private bool m_toggleActiveCtrl;
    [Token(Token = "0x40014AA")]
    [FieldOffset(Offset = "0x41")]
    [SerializeField]
    private bool m_toggleActiveAlt;
    [Token(Token = "0x40014AB")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private GraphyManager.ModulePosition m_graphModulePosition;
    [Token(Token = "0x40014AC")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GraphyManager.ModuleState m_fpsModuleState;
    [Token(Token = "0x40014AD")]
    [FieldOffset(Offset = "0x4C")]
    [Range(0.0f, 200f)]
    [Tooltip("Time (in seconds) to reset the minimum and maximum framerates if they don't change in the specified time. Set to 0 if you don't want it to reset.")]
    [SerializeField]
    private int m_timeToResetMinMaxFps;
    [Token(Token = "0x40014AE")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Color m_goodFpsColor;
    [Token(Token = "0x40014AF")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private int m_goodFpsThreshold;
    [Token(Token = "0x40014B0")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private Color m_cautionFpsColor;
    [Token(Token = "0x40014B1")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    private int m_cautionFpsThreshold;
    [Token(Token = "0x40014B2")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Color m_criticalFpsColor;
    [Token(Token = "0x40014B3")]
    [FieldOffset(Offset = "0x88")]
    [Range(10f, 300f)]
    [SerializeField]
    private int m_fpsGraphResolution;
    [Token(Token = "0x40014B4")]
    [FieldOffset(Offset = "0x8C")]
    [SerializeField]
    [Range(1f, 200f)]
    private int m_fpsTextUpdateRate;
    [Token(Token = "0x40014B5")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GraphyManager.ModuleState m_ramModuleState;
    [Token(Token = "0x40014B6")]
    [FieldOffset(Offset = "0x94")]
    [SerializeField]
    private Color m_allocatedRamColor;
    [Token(Token = "0x40014B7")]
    [FieldOffset(Offset = "0xA4")]
    [SerializeField]
    private Color m_reservedRamColor;
    [Token(Token = "0x40014B8")]
    [FieldOffset(Offset = "0xB4")]
    [SerializeField]
    private Color m_monoRamColor;
    [Token(Token = "0x40014B9")]
    [FieldOffset(Offset = "0xC4")]
    [SerializeField]
    [Range(10f, 300f)]
    private int m_ramGraphResolution;
    [Token(Token = "0x40014BA")]
    [FieldOffset(Offset = "0xC8")]
    [Range(1f, 200f)]
    [SerializeField]
    private int m_ramTextUpdateRate;
    [Token(Token = "0x40014BB")]
    [FieldOffset(Offset = "0xCC")]
    [SerializeField]
    private GraphyManager.ModuleState m_audioModuleState;
    [Token(Token = "0x40014BC")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private GraphyManager.LookForAudioListener m_findAudioListenerInCameraIfNull;
    [Token(Token = "0x40014BD")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private AudioListener m_audioListener;
    [Token(Token = "0x40014BE")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private Color m_audioGraphColor;
    [Token(Token = "0x40014BF")]
    [FieldOffset(Offset = "0xF0")]
    [Range(10f, 300f)]
    [SerializeField]
    private int m_audioGraphResolution;
    [Token(Token = "0x40014C0")]
    [FieldOffset(Offset = "0xF4")]
    [Range(1f, 200f)]
    [SerializeField]
    private int m_audioTextUpdateRate;
    [Token(Token = "0x40014C1")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private FFTWindow m_FFTWindow;
    [Token(Token = "0x40014C2")]
    [FieldOffset(Offset = "0xFC")]
    [Tooltip("Must be a power of 2 and between 64-8192")]
    [SerializeField]
    private int m_spectrumSize;
    [Token(Token = "0x40014C3")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private GraphyManager.ModulePosition m_advancedModulePosition;
    [Token(Token = "0x40014C4")]
    [FieldOffset(Offset = "0x104")]
    [SerializeField]
    private GraphyManager.ModuleState m_advancedModuleState;
    [Token(Token = "0x40014C5")]
    [FieldOffset(Offset = "0x108")]
    private bool m_initialized;
    [Token(Token = "0x40014C6")]
    [FieldOffset(Offset = "0x109")]
    private bool m_active;
    [Token(Token = "0x40014C7")]
    [FieldOffset(Offset = "0x10A")]
    private bool m_focused;
    [Token(Token = "0x40014C8")]
    [FieldOffset(Offset = "0x110")]
    private G_FpsManager m_fpsManager;
    [Token(Token = "0x40014C9")]
    [FieldOffset(Offset = "0x118")]
    private G_RamManager m_ramManager;
    [Token(Token = "0x40014CA")]
    [FieldOffset(Offset = "0x120")]
    private G_AudioManager m_audioManager;
    [Token(Token = "0x40014CB")]
    [FieldOffset(Offset = "0x128")]
    private G_AdvancedData m_advancedData;
    [Token(Token = "0x40014CC")]
    [FieldOffset(Offset = "0x130")]
    private G_FpsMonitor m_fpsMonitor;
    [Token(Token = "0x40014CD")]
    [FieldOffset(Offset = "0x138")]
    private G_RamMonitor m_ramMonitor;
    [Token(Token = "0x40014CE")]
    [FieldOffset(Offset = "0x140")]
    private G_AudioMonitor m_audioMonitor;
    [Token(Token = "0x40014CF")]
    [FieldOffset(Offset = "0x148")]
    private GraphyManager.ModulePreset m_modulePresetState;

    [Token(Token = "0x6001417")]
    [Address(RVA = "0x2525230", Offset = "0x2525230", VA = "0x2525230")]
    protected GraphyManager()
    {
    }

    [Token(Token = "0x170001F2")]
    public GraphyManager.Mode GraphyMode
    {
      [Token(Token = "0x6001418"), Address(RVA = "0x2525390", Offset = "0x2525390", VA = "0x2525390")] get
      {
        return new GraphyManager.Mode();
      }
      [Token(Token = "0x6001419"), Address(RVA = "0x2525398", Offset = "0x2525398", VA = "0x2525398")] set
      {
      }
    }

    [Token(Token = "0x170001F3")]
    public bool EnableOnStartup
    {
      [Token(Token = "0x600141A"), Address(RVA = "0x25253E0", Offset = "0x25253E0", VA = "0x25253E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170001F4")]
    public bool KeepAlive
    {
      [Token(Token = "0x600141B"), Address(RVA = "0x25253E8", Offset = "0x25253E8", VA = "0x25253E8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170001F5")]
    public bool Background
    {
      [Token(Token = "0x600141C"), Address(RVA = "0x25253F0", Offset = "0x25253F0", VA = "0x25253F0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600141D"), Address(RVA = "0x25253F8", Offset = "0x25253F8", VA = "0x25253F8")] set
      {
      }
    }

    [Token(Token = "0x170001F6")]
    public Color BackgroundColor
    {
      [Token(Token = "0x600141E"), Address(RVA = "0x2525404", Offset = "0x2525404", VA = "0x2525404")] get
      {
        return new Color();
      }
      [Token(Token = "0x600141F"), Address(RVA = "0x2525410", Offset = "0x2525410", VA = "0x2525410")] set
      {
      }
    }

    [Token(Token = "0x170001F7")]
    public GraphyManager.ModulePosition GraphModulePosition
    {
      [Token(Token = "0x6001420"), Address(RVA = "0x252541C", Offset = "0x252541C", VA = "0x252541C")] get
      {
        return new GraphyManager.ModulePosition();
      }
      [Token(Token = "0x6001421"), Address(RVA = "0x2525424", Offset = "0x2525424", VA = "0x2525424")] set
      {
      }
    }

    [Token(Token = "0x170001F8")]
    public GraphyManager.ModuleState FpsModuleState
    {
      [Token(Token = "0x6001422"), Address(RVA = "0x2525D34", Offset = "0x2525D34", VA = "0x2525D34")] get
      {
        return new GraphyManager.ModuleState();
      }
      [Token(Token = "0x6001423"), Address(RVA = "0x2525D3C", Offset = "0x2525D3C", VA = "0x2525D3C")] set
      {
      }
    }

    [Token(Token = "0x170001F9")]
    public int TimeToResetMinMaxFps
    {
      [Token(Token = "0x6001424"), Address(RVA = "0x2525F10", Offset = "0x2525F10", VA = "0x2525F10")] get
      {
        return new int();
      }
      [Token(Token = "0x6001425"), Address(RVA = "0x2525F18", Offset = "0x2525F18", VA = "0x2525F18")] set
      {
      }
    }

    [Token(Token = "0x170001FA")]
    public Color GoodFPSColor
    {
      [Token(Token = "0x6001426"), Address(RVA = "0x2526108", Offset = "0x2526108", VA = "0x2526108")] get
      {
        return new Color();
      }
      [Token(Token = "0x6001427"), Address(RVA = "0x2526114", Offset = "0x2526114", VA = "0x2526114")] set
      {
      }
    }

    [Token(Token = "0x170001FB")]
    public Color CautionFPSColor
    {
      [Token(Token = "0x6001428"), Address(RVA = "0x2526138", Offset = "0x2526138", VA = "0x2526138")] get
      {
        return new Color();
      }
      [Token(Token = "0x6001429"), Address(RVA = "0x2526144", Offset = "0x2526144", VA = "0x2526144")] set
      {
      }
    }

    [Token(Token = "0x170001FC")]
    public Color CriticalFPSColor
    {
      [Token(Token = "0x600142A"), Address(RVA = "0x2526168", Offset = "0x2526168", VA = "0x2526168")] get
      {
        return new Color();
      }
      [Token(Token = "0x600142B"), Address(RVA = "0x2526174", Offset = "0x2526174", VA = "0x2526174")] set
      {
      }
    }

    [Token(Token = "0x170001FD")]
    public int GoodFPSThreshold
    {
      [Token(Token = "0x600142C"), Address(RVA = "0x2526198", Offset = "0x2526198", VA = "0x2526198")] get
      {
        return new int();
      }
      [Token(Token = "0x600142D"), Address(RVA = "0x25261A0", Offset = "0x25261A0", VA = "0x25261A0")] set
      {
      }
    }

    [Token(Token = "0x170001FE")]
    public int CautionFPSThreshold
    {
      [Token(Token = "0x600142E"), Address(RVA = "0x25261C0", Offset = "0x25261C0", VA = "0x25261C0")] get
      {
        return new int();
      }
      [Token(Token = "0x600142F"), Address(RVA = "0x25261C8", Offset = "0x25261C8", VA = "0x25261C8")] set
      {
      }
    }

    [Token(Token = "0x170001FF")]
    public int FpsGraphResolution
    {
      [Token(Token = "0x6001430"), Address(RVA = "0x25261E8", Offset = "0x25261E8", VA = "0x25261E8")] get
      {
        return new int();
      }
      [Token(Token = "0x6001431"), Address(RVA = "0x25261F0", Offset = "0x25261F0", VA = "0x25261F0")] set
      {
      }
    }

    [Token(Token = "0x17000200")]
    public int FpsTextUpdateRate
    {
      [Token(Token = "0x6001432"), Address(RVA = "0x2526210", Offset = "0x2526210", VA = "0x2526210")] get
      {
        return new int();
      }
      [Token(Token = "0x6001433"), Address(RVA = "0x2526218", Offset = "0x2526218", VA = "0x2526218")] set
      {
      }
    }

    [Token(Token = "0x17000201")]
    public float CurrentFPS
    {
      [Token(Token = "0x6001434"), Address(RVA = "0x2526238", Offset = "0x2526238", VA = "0x2526238")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000202")]
    public float AverageFPS
    {
      [Token(Token = "0x6001435"), Address(RVA = "0x2526254", Offset = "0x2526254", VA = "0x2526254")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000203")]
    public float MinFPS
    {
      [Token(Token = "0x6001436"), Address(RVA = "0x2526270", Offset = "0x2526270", VA = "0x2526270")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000204")]
    public float MaxFPS
    {
      [Token(Token = "0x6001437"), Address(RVA = "0x252628C", Offset = "0x252628C", VA = "0x252628C")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000205")]
    public GraphyManager.ModuleState RamModuleState
    {
      [Token(Token = "0x6001438"), Address(RVA = "0x25262A8", Offset = "0x25262A8", VA = "0x25262A8")] get
      {
        return new GraphyManager.ModuleState();
      }
      [Token(Token = "0x6001439"), Address(RVA = "0x25262B0", Offset = "0x25262B0", VA = "0x25262B0")] set
      {
      }
    }

    [Token(Token = "0x17000206")]
    public Color AllocatedRamColor
    {
      [Token(Token = "0x600143A"), Address(RVA = "0x2526424", Offset = "0x2526424", VA = "0x2526424")] get
      {
        return new Color();
      }
      [Token(Token = "0x600143B"), Address(RVA = "0x2526430", Offset = "0x2526430", VA = "0x2526430")] set
      {
      }
    }

    [Token(Token = "0x17000207")]
    public Color ReservedRamColor
    {
      [Token(Token = "0x600143C"), Address(RVA = "0x2526600", Offset = "0x2526600", VA = "0x2526600")] get
      {
        return new Color();
      }
      [Token(Token = "0x600143D"), Address(RVA = "0x252660C", Offset = "0x252660C", VA = "0x252660C")] set
      {
      }
    }

    [Token(Token = "0x17000208")]
    public Color MonoRamColor
    {
      [Token(Token = "0x600143E"), Address(RVA = "0x2526630", Offset = "0x2526630", VA = "0x2526630")] get
      {
        return new Color();
      }
      [Token(Token = "0x600143F"), Address(RVA = "0x252663C", Offset = "0x252663C", VA = "0x252663C")] set
      {
      }
    }

    [Token(Token = "0x17000209")]
    public int RamGraphResolution
    {
      [Token(Token = "0x6001440"), Address(RVA = "0x2526660", Offset = "0x2526660", VA = "0x2526660")] get
      {
        return new int();
      }
      [Token(Token = "0x6001441"), Address(RVA = "0x2526668", Offset = "0x2526668", VA = "0x2526668")] set
      {
      }
    }

    [Token(Token = "0x1700020A")]
    public int RamTextUpdateRate
    {
      [Token(Token = "0x6001442"), Address(RVA = "0x2526688", Offset = "0x2526688", VA = "0x2526688")] get
      {
        return new int();
      }
      [Token(Token = "0x6001443"), Address(RVA = "0x2526690", Offset = "0x2526690", VA = "0x2526690")] set
      {
      }
    }

    [Token(Token = "0x1700020B")]
    public float AllocatedRam
    {
      [Token(Token = "0x6001444"), Address(RVA = "0x25266B0", Offset = "0x25266B0", VA = "0x25266B0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x1700020C")]
    public float ReservedRam
    {
      [Token(Token = "0x6001445"), Address(RVA = "0x25266CC", Offset = "0x25266CC", VA = "0x25266CC")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x1700020D")]
    public float MonoRam
    {
      [Token(Token = "0x6001446"), Address(RVA = "0x25266E8", Offset = "0x25266E8", VA = "0x25266E8")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x1700020E")]
    public GraphyManager.ModuleState AudioModuleState
    {
      [Token(Token = "0x6001447"), Address(RVA = "0x2526704", Offset = "0x2526704", VA = "0x2526704")] get
      {
        return new GraphyManager.ModuleState();
      }
      [Token(Token = "0x6001448"), Address(RVA = "0x252670C", Offset = "0x252670C", VA = "0x252670C")] set
      {
      }
    }

    [Token(Token = "0x1700020F")]
    public AudioListener AudioListener
    {
      [Token(Token = "0x6001449"), Address(RVA = "0x2526880", Offset = "0x2526880", VA = "0x2526880")] get
      {
        return (AudioListener) null;
      }
      [Token(Token = "0x600144A"), Address(RVA = "0x2526888", Offset = "0x2526888", VA = "0x2526888")] set
      {
      }
    }

    [Token(Token = "0x17000210")]
    public GraphyManager.LookForAudioListener FindAudioListenerInCameraIfNull
    {
      [Token(Token = "0x600144B"), Address(RVA = "0x2526A6C", Offset = "0x2526A6C", VA = "0x2526A6C")] get
      {
        return new GraphyManager.LookForAudioListener();
      }
      [Token(Token = "0x600144C"), Address(RVA = "0x2526A74", Offset = "0x2526A74", VA = "0x2526A74")] set
      {
      }
    }

    [Token(Token = "0x17000211")]
    public Color AudioGraphColor
    {
      [Token(Token = "0x600144D"), Address(RVA = "0x2526A94", Offset = "0x2526A94", VA = "0x2526A94")] get
      {
        return new Color();
      }
      [Token(Token = "0x600144E"), Address(RVA = "0x2526AA0", Offset = "0x2526AA0", VA = "0x2526AA0")] set
      {
      }
    }

    [Token(Token = "0x17000212")]
    public int AudioGraphResolution
    {
      [Token(Token = "0x600144F"), Address(RVA = "0x2526AC4", Offset = "0x2526AC4", VA = "0x2526AC4")] get
      {
        return new int();
      }
      [Token(Token = "0x6001450"), Address(RVA = "0x2526ACC", Offset = "0x2526ACC", VA = "0x2526ACC")] set
      {
      }
    }

    [Token(Token = "0x17000213")]
    public int AudioTextUpdateRate
    {
      [Token(Token = "0x6001451"), Address(RVA = "0x2526AEC", Offset = "0x2526AEC", VA = "0x2526AEC")] get
      {
        return new int();
      }
      [Token(Token = "0x6001452"), Address(RVA = "0x2526AF4", Offset = "0x2526AF4", VA = "0x2526AF4")] set
      {
      }
    }

    [Token(Token = "0x17000214")]
    public FFTWindow FftWindow
    {
      [Token(Token = "0x6001453"), Address(RVA = "0x2526B14", Offset = "0x2526B14", VA = "0x2526B14")] get
      {
        return new FFTWindow();
      }
      [Token(Token = "0x6001454"), Address(RVA = "0x2526B1C", Offset = "0x2526B1C", VA = "0x2526B1C")] set
      {
      }
    }

    [Token(Token = "0x17000215")]
    public int SpectrumSize
    {
      [Token(Token = "0x6001455"), Address(RVA = "0x2526B3C", Offset = "0x2526B3C", VA = "0x2526B3C")] get
      {
        return new int();
      }
      [Token(Token = "0x6001456"), Address(RVA = "0x2526B44", Offset = "0x2526B44", VA = "0x2526B44")] set
      {
      }
    }

    [Token(Token = "0x17000216")]
    public float[] Spectrum
    {
      [Token(Token = "0x6001457"), Address(RVA = "0x2526B64", Offset = "0x2526B64", VA = "0x2526B64")] get
      {
        return (float[]) null;
      }
    }

    [Token(Token = "0x17000217")]
    public float MaxDB
    {
      [Token(Token = "0x6001458"), Address(RVA = "0x2526B80", Offset = "0x2526B80", VA = "0x2526B80")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000218")]
    public GraphyManager.ModuleState AdvancedModuleState
    {
      [Token(Token = "0x6001459"), Address(RVA = "0x2526B9C", Offset = "0x2526B9C", VA = "0x2526B9C")] get
      {
        return new GraphyManager.ModuleState();
      }
      [Token(Token = "0x600145A"), Address(RVA = "0x2526BA4", Offset = "0x2526BA4", VA = "0x2526BA4")] set
      {
      }
    }

    [Token(Token = "0x17000219")]
    public GraphyManager.ModulePosition AdvancedModulePosition
    {
      [Token(Token = "0x600145B"), Address(RVA = "0x2526C40", Offset = "0x2526C40", VA = "0x2526C40")] get
      {
        return new GraphyManager.ModulePosition();
      }
      [Token(Token = "0x600145C"), Address(RVA = "0x2526C48", Offset = "0x2526C48", VA = "0x2526C48")] set
      {
      }
    }

    [Token(Token = "0x600145D")]
    [Address(RVA = "0x25272C8", Offset = "0x25272C8", VA = "0x25272C8")]
    private void Start()
    {
    }

    [Token(Token = "0x600145E")]
    [Address(RVA = "0x25277FC", Offset = "0x25277FC", VA = "0x25277FC")]
    private void Update()
    {
    }

    [Token(Token = "0x600145F")]
    [Address(RVA = "0x252798C", Offset = "0x252798C", VA = "0x252798C")]
    private void OnApplicationFocus(bool isFocused)
    {
    }

    [Token(Token = "0x6001460")]
    [Address(RVA = "0x25279E8", Offset = "0x25279E8", VA = "0x25279E8")]
    public void SetModulePosition(
      GraphyManager.ModuleType moduleType,
      GraphyManager.ModulePosition modulePosition)
    {
    }

    [Token(Token = "0x6001461")]
    [Address(RVA = "0x2527A68", Offset = "0x2527A68", VA = "0x2527A68")]
    public void SetModuleMode(
      GraphyManager.ModuleType moduleType,
      GraphyManager.ModuleState moduleState)
    {
    }

    [Token(Token = "0x6001462")]
    [Address(RVA = "0x2527AFC", Offset = "0x2527AFC", VA = "0x2527AFC")]
    public void ToggleModes()
    {
    }

    [Token(Token = "0x6001463")]
    [Address(RVA = "0x2527BE4", Offset = "0x2527BE4", VA = "0x2527BE4")]
    public void SetPreset(GraphyManager.ModulePreset modulePreset)
    {
    }

    [Token(Token = "0x6001464")]
    [Address(RVA = "0x2527E14", Offset = "0x2527E14", VA = "0x2527E14")]
    public void ToggleActive()
    {
    }

    [Token(Token = "0x6001465")]
    [Address(RVA = "0x2527E24", Offset = "0x2527E24", VA = "0x2527E24")]
    public void Enable()
    {
    }

    [Token(Token = "0x6001466")]
    [Address(RVA = "0x2527E90", Offset = "0x2527E90", VA = "0x2527E90")]
    public void Disable()
    {
    }

    [Token(Token = "0x6001467")]
    [Address(RVA = "0x25272CC", Offset = "0x25272CC", VA = "0x25272CC")]
    private void Init()
    {
    }

    [Token(Token = "0x6001468")]
    [Address(RVA = "0x2527814", Offset = "0x2527814", VA = "0x2527814")]
    private void CheckForHotkeyPresses()
    {
    }

    [Token(Token = "0x6001469")]
    [Address(RVA = "0x2528054", Offset = "0x2528054", VA = "0x2528054")]
    private bool CheckFor1KeyPress(KeyCode key) => new bool();

    [Token(Token = "0x600146A")]
    [Address(RVA = "0x2527FE8", Offset = "0x2527FE8", VA = "0x2527FE8")]
    private bool CheckFor2KeyPress(KeyCode key1, KeyCode key2) => new bool();

    [Token(Token = "0x600146B")]
    [Address(RVA = "0x2527F28", Offset = "0x2527F28", VA = "0x2527F28")]
    private bool CheckFor3KeyPress(KeyCode key1, KeyCode key2, KeyCode key3) => new bool();

    [Token(Token = "0x600146C")]
    [Address(RVA = "0x25253A0", Offset = "0x25253A0", VA = "0x25253A0")]
    private void UpdateAllParameters()
    {
    }

    [Token(Token = "0x600146D")]
    [Address(RVA = "0x25279A8", Offset = "0x25279A8", VA = "0x25279A8")]
    private void RefreshAllParameters()
    {
    }

    [Token(Token = "0x2000389")]
    public enum Mode
    {
      [Token(Token = "0x40014D1")] FULL,
      [Token(Token = "0x40014D2")] LIGHT,
    }

    [Token(Token = "0x200038A")]
    public enum ModuleType
    {
      [Token(Token = "0x40014D4")] FPS,
      [Token(Token = "0x40014D5")] RAM,
      [Token(Token = "0x40014D6")] AUDIO,
      [Token(Token = "0x40014D7")] ADVANCED,
    }

    [Token(Token = "0x200038B")]
    public enum ModuleState
    {
      [Token(Token = "0x40014D9")] FULL,
      [Token(Token = "0x40014DA")] TEXT,
      [Token(Token = "0x40014DB")] BASIC,
      [Token(Token = "0x40014DC")] BACKGROUND,
      [Token(Token = "0x40014DD")] OFF,
    }

    [Token(Token = "0x200038C")]
    public enum ModulePosition
    {
      [Token(Token = "0x40014DF")] TOP_RIGHT,
      [Token(Token = "0x40014E0")] TOP_LEFT,
      [Token(Token = "0x40014E1")] BOTTOM_RIGHT,
      [Token(Token = "0x40014E2")] BOTTOM_LEFT,
      [Token(Token = "0x40014E3")] FREE,
    }

    [Token(Token = "0x200038D")]
    public enum LookForAudioListener
    {
      [Token(Token = "0x40014E5")] ALWAYS,
      [Token(Token = "0x40014E6")] ON_SCENE_LOAD,
      [Token(Token = "0x40014E7")] NEVER,
    }

    [Token(Token = "0x200038E")]
    public enum ModulePreset
    {
      [Token(Token = "0x40014E9")] FPS_BASIC,
      [Token(Token = "0x40014EA")] FPS_TEXT,
      [Token(Token = "0x40014EB")] FPS_FULL,
      [Token(Token = "0x40014EC")] FPS_TEXT_RAM_TEXT,
      [Token(Token = "0x40014ED")] FPS_FULL_RAM_TEXT,
      [Token(Token = "0x40014EE")] FPS_FULL_RAM_FULL,
      [Token(Token = "0x40014EF")] FPS_TEXT_RAM_TEXT_AUDIO_TEXT,
      [Token(Token = "0x40014F0")] FPS_FULL_RAM_TEXT_AUDIO_TEXT,
      [Token(Token = "0x40014F1")] FPS_FULL_RAM_FULL_AUDIO_TEXT,
      [Token(Token = "0x40014F2")] FPS_FULL_RAM_FULL_AUDIO_FULL,
      [Token(Token = "0x40014F3")] FPS_FULL_RAM_FULL_AUDIO_FULL_ADVANCED_FULL,
      [Token(Token = "0x40014F4")] FPS_BASIC_ADVANCED_FULL,
    }
  }
}
