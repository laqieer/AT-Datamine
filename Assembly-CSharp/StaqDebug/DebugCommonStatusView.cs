// Decompiled with JetBrains decompiler
// Type: StaqDebug.DebugCommonStatusView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Text;
using UnityEngine;

#nullable disable
namespace StaqDebug
{
  [Token(Token = "0x2001F58")]
  public class DebugCommonStatusView : MonoBehaviour
  {
    [Token(Token = "0x4008645")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private float scalingPoint;
    [Token(Token = "0x4008646")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Rect drawRect1;
    [Token(Token = "0x4008647")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Rect drawRect2;
    [Token(Token = "0x4008648")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Color fillColor;
    [Token(Token = "0x4008649")]
    private const int loadingDelayCount = 20;
    [Token(Token = "0x400864A")]
    [FieldOffset(Offset = "0x0")]
    private static float LoadingTime;
    [Token(Token = "0x400864B")]
    [FieldOffset(Offset = "0x4")]
    private static float calcTime;
    [Token(Token = "0x400864C")]
    [FieldOffset(Offset = "0x8")]
    private static float calcDelayTime;
    [Token(Token = "0x400864D")]
    [FieldOffset(Offset = "0xC")]
    private static int callTimerCount;
    [Token(Token = "0x400864E")]
    [FieldOffset(Offset = "0x50")]
    private FpsCalculator fpsCalculator;
    [Token(Token = "0x400864F")]
    [FieldOffset(Offset = "0x58")]
    private StringBuilder debugStatusHeaderText;
    [Token(Token = "0x4008650")]
    [FieldOffset(Offset = "0x60")]
    private Texture texture;
    [Token(Token = "0x4008651")]
    [FieldOffset(Offset = "0x68")]
    private bool isOpenURP;
    [Token(Token = "0x4008652")]
    [FieldOffset(Offset = "0x69")]
    private bool isOpenCamera;
    [Token(Token = "0x4008653")]
    [FieldOffset(Offset = "0x6A")]
    private bool isDispResolution;
    [Token(Token = "0x4008654")]
    [FieldOffset(Offset = "0x6C")]
    private int isPostProcessType;
    [Token(Token = "0x4008655")]
    [FieldOffset(Offset = "0x10")]
    private static float debugTime;

    [Token(Token = "0x600BA14")]
    [Address(RVA = "0x2140B30", Offset = "0x2140B30", VA = "0x2140B30")]
    private void Awake()
    {
    }

    [Token(Token = "0x600BA15")]
    [Address(RVA = "0x2140BD8", Offset = "0x2140BD8", VA = "0x2140BD8")]
    private void Update()
    {
    }

    [Token(Token = "0x600BA16")]
    [Address(RVA = "0x2140C94", Offset = "0x2140C94", VA = "0x2140C94")]
    private void OnGUI()
    {
    }

    [Token(Token = "0x600BA17")]
    [Address(RVA = "0x2141330", Offset = "0x2141330", VA = "0x2141330")]
    public static void StartTimer()
    {
    }

    [Token(Token = "0x600BA18")]
    [Address(RVA = "0x2141394", Offset = "0x2141394", VA = "0x2141394")]
    public static void StopTimer()
    {
    }

    [Token(Token = "0x600BA19")]
    [Address(RVA = "0x2140D00", Offset = "0x2140D00", VA = "0x2140D00")]
    private void DrawStatus()
    {
    }

    [Token(Token = "0x600BA1A")]
    [Address(RVA = "0x21413F4", Offset = "0x21413F4", VA = "0x21413F4")]
    private void DrawURPOption(Rect rect)
    {
    }

    [Token(Token = "0x600BA1B")]
    [Address(RVA = "0x2141C8C", Offset = "0x2141C8C", VA = "0x2141C8C")]
    private void DrawAnti(Rect rect)
    {
    }

    [Token(Token = "0x600BA1C")]
    [Address(RVA = "0x2141EA0", Offset = "0x2141EA0", VA = "0x2141EA0")]
    private void MainShadowResolution(Rect rect)
    {
    }

    [Token(Token = "0x600BA1D")]
    [Address(RVA = "0x2142188", Offset = "0x2142188", VA = "0x2142188")]
    private void AdditionalShadowResolution(Rect rect)
    {
    }

    [Token(Token = "0x600BA1E")]
    [Address(RVA = "0x2142470", Offset = "0x2142470", VA = "0x2142470")]
    private void SoftShadow(Rect rect)
    {
    }

    [Token(Token = "0x600BA1F")]
    [Address(RVA = "0x2142618", Offset = "0x2142618", VA = "0x2142618")]
    private void ColorGrading(Rect rect)
    {
    }

    [Token(Token = "0x600BA20")]
    [Address(RVA = "0x214161C", Offset = "0x214161C", VA = "0x214161C")]
    private void DrawCameraOption(Rect rect)
    {
    }

    [Token(Token = "0x600BA21")]
    [Address(RVA = "0x21427A4", Offset = "0x21427A4", VA = "0x21427A4")]
    private void PostProcessEnable(Rect rect)
    {
    }

    [Token(Token = "0x600BA22")]
    [Address(RVA = "0x2142A48", Offset = "0x2142A48", VA = "0x2142A48")]
    private void HDREnable(Rect rect)
    {
    }

    [Token(Token = "0x600BA23")]
    [Address(RVA = "0x2142BF0", Offset = "0x2142BF0", VA = "0x2142BF0")]
    public static void StartDebugTime()
    {
    }

    [Token(Token = "0x600BA24")]
    [Address(RVA = "0x2142C40", Offset = "0x2142C40", VA = "0x2142C40")]
    public static void DumpDebugTime(string title)
    {
    }

    [Token(Token = "0x600BA25")]
    [Address(RVA = "0x2142D34", Offset = "0x2142D34", VA = "0x2142D34")]
    public DebugCommonStatusView()
    {
    }
  }
}
