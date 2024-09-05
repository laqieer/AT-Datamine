// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.Audio.G_AudioMonitor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

#nullable disable
namespace Tayx.Graphy.Audio
{
  [Token(Token = "0x20003A1")]
  public class G_AudioMonitor : MonoBehaviour
  {
    [Token(Token = "0x400157B")]
    private const float m_refValue = 1f;
    [Token(Token = "0x400157C")]
    [FieldOffset(Offset = "0x18")]
    private GraphyManager m_graphyManager;
    [Token(Token = "0x400157D")]
    [FieldOffset(Offset = "0x20")]
    private AudioListener m_audioListener;
    [Token(Token = "0x400157E")]
    [FieldOffset(Offset = "0x28")]
    private GraphyManager.LookForAudioListener m_findAudioListenerInCameraIfNull;
    [Token(Token = "0x400157F")]
    [FieldOffset(Offset = "0x2C")]
    private FFTWindow m_FFTWindow;
    [Token(Token = "0x4001580")]
    [FieldOffset(Offset = "0x30")]
    private int m_spectrumSize;
    [Token(Token = "0x4001581")]
    [FieldOffset(Offset = "0x38")]
    private float[] m_spectrum;
    [Token(Token = "0x4001582")]
    [FieldOffset(Offset = "0x40")]
    private float[] m_spectrumHighestValues;
    [Token(Token = "0x4001583")]
    [FieldOffset(Offset = "0x48")]
    private float m_maxDB;

    [Token(Token = "0x17000228")]
    public float[] Spectrum
    {
      [Token(Token = "0x60014E2"), Address(RVA = "0x252D340", Offset = "0x252D340", VA = "0x252D340")] get
      {
        return (float[]) null;
      }
    }

    [Token(Token = "0x17000229")]
    public float[] SpectrumHighestValues
    {
      [Token(Token = "0x60014E3"), Address(RVA = "0x252D348", Offset = "0x252D348", VA = "0x252D348")] get
      {
        return (float[]) null;
      }
    }

    [Token(Token = "0x1700022A")]
    public float MaxDB
    {
      [Token(Token = "0x60014E4"), Address(RVA = "0x252D350", Offset = "0x252D350", VA = "0x252D350")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x1700022B")]
    public bool SpectrumDataAvailable
    {
      [Token(Token = "0x60014E5"), Address(RVA = "0x252C388", Offset = "0x252C388", VA = "0x252C388")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60014E6")]
    [Address(RVA = "0x252D358", Offset = "0x252D358", VA = "0x252D358")]
    private void Awake()
    {
    }

    [Token(Token = "0x60014E7")]
    [Address(RVA = "0x252D444", Offset = "0x252D444", VA = "0x252D444")]
    private void Update()
    {
    }

    [Token(Token = "0x60014E8")]
    [Address(RVA = "0x252D6D4", Offset = "0x252D6D4", VA = "0x252D6D4")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60014E9")]
    [Address(RVA = "0x252D190", Offset = "0x252D190", VA = "0x252D190")]
    public void UpdateParameters()
    {
    }

    [Token(Token = "0x60014EA")]
    [Address(RVA = "0x252CA54", Offset = "0x252CA54", VA = "0x252CA54")]
    public float lin2dB(float linear) => new float();

    [Token(Token = "0x60014EB")]
    [Address(RVA = "0x252CA84", Offset = "0x252CA84", VA = "0x252CA84")]
    public float dBNormalized(float db) => new float();

    [Token(Token = "0x60014EC")]
    [Address(RVA = "0x252D630", Offset = "0x252D630", VA = "0x252D630")]
    private AudioListener FindAudioListener() => (AudioListener) null;

    [Token(Token = "0x60014ED")]
    [Address(RVA = "0x252D778", Offset = "0x252D778", VA = "0x252D778")]
    private void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode)
    {
    }

    [Token(Token = "0x60014EE")]
    [Address(RVA = "0x252D35C", Offset = "0x252D35C", VA = "0x252D35C")]
    private void Init()
    {
    }

    [Token(Token = "0x60014EF")]
    [Address(RVA = "0x252D79C", Offset = "0x252D79C", VA = "0x252D79C")]
    public G_AudioMonitor()
    {
    }
  }
}
