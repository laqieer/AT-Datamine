// Decompiled with JetBrains decompiler
// Type: staq.SystemUI.SystemMeter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace staq.SystemUI
{
  [Token(Token = "0x2003D5A")]
  public class SystemMeter : 
    MonoBehaviour,
    IPointerDownHandler,
    IEventSystemHandler,
    IPointerUpHandler,
    IPointerClickHandler
  {
    [Token(Token = "0x4010D99")]
    [FieldOffset(Offset = "0x18")]
    public RawImage fpsImage;
    [Token(Token = "0x4010D9A")]
    [FieldOffset(Offset = "0x20")]
    public RawImage memoryUsageImage;
    [Token(Token = "0x4010D9B")]
    [FieldOffset(Offset = "0x28")]
    public Text currentFPSText;
    [Token(Token = "0x4010D9C")]
    [FieldOffset(Offset = "0x30")]
    public Text averageFPSText;
    [Token(Token = "0x4010D9D")]
    [FieldOffset(Offset = "0x38")]
    public Text reservedMemoryText;
    [Token(Token = "0x4010D9E")]
    [FieldOffset(Offset = "0x40")]
    public Text usedMemoryText;
    [Token(Token = "0x4010D9F")]
    [FieldOffset(Offset = "0x48")]
    public RectTransform rectTransform;
    [Token(Token = "0x4010DA0")]
    [FieldOffset(Offset = "0x50")]
    public float maxDisplayingFPS;
    [Token(Token = "0x4010DA1")]
    [FieldOffset(Offset = "0x54")]
    public float maxDisplayingMemory;
    [Token(Token = "0x4010DA2")]
    [FieldOffset(Offset = "0x58")]
    public Color backgroundColor;
    [Token(Token = "0x4010DA3")]
    [FieldOffset(Offset = "0x68")]
    public Color currentFPSColor;
    [Token(Token = "0x4010DA4")]
    [FieldOffset(Offset = "0x78")]
    public Color averageFPSColor;
    [Token(Token = "0x4010DA5")]
    [FieldOffset(Offset = "0x88")]
    public Color currentUsedMemoryColor;
    [Token(Token = "0x4010DA6")]
    [FieldOffset(Offset = "0x98")]
    public Color currentReservedMemoryColor;
    [Token(Token = "0x4010DA7")]
    [FieldOffset(Offset = "0xA8")]
    public float[] pageDensities;
    [Token(Token = "0x4010DA8")]
    [FieldOffset(Offset = "0xB0")]
    public float updateInterval;
    [Token(Token = "0x4010DA9")]
    [FieldOffset(Offset = "0xB8")]
    private Texture2D fpsTexture;
    [Token(Token = "0x4010DAA")]
    [FieldOffset(Offset = "0xC0")]
    private Texture2D memoryUsageTexture;
    [Token(Token = "0x4010DAB")]
    [FieldOffset(Offset = "0xC8")]
    private int currentFPSColumn;
    [Token(Token = "0x4010DAC")]
    [FieldOffset(Offset = "0xCC")]
    private int currentMemoryUsageColumn;
    [Token(Token = "0x4010DAD")]
    [FieldOffset(Offset = "0xD0")]
    private float averageFPS;
    [Token(Token = "0x4010DAE")]
    [FieldOffset(Offset = "0xD4")]
    private float averageFPSCount;
    [Token(Token = "0x4010DAF")]
    [FieldOffset(Offset = "0xD8")]
    private float lastUpdateTime;
    [Token(Token = "0x4010DB0")]
    [FieldOffset(Offset = "0xDC")]
    private int fpsPageDensityIndex;
    [Token(Token = "0x4010DB1")]
    [FieldOffset(Offset = "0xE0")]
    private int memoryUsagePageDensityIndex;
    [Token(Token = "0x4010DB2")]
    [FieldOffset(Offset = "0xE4")]
    private SystemMeter.Status currentStatus;
    [Token(Token = "0x4010DB3")]
    [FieldOffset(Offset = "0xE8")]
    private PointerEventData eventData;
    [Token(Token = "0x4010DB4")]
    [FieldOffset(Offset = "0xF0")]
    private Vector3 originalLocalPosition;

    [Token(Token = "0x6018B06")]
    [Address(RVA = "0x264197C", Offset = "0x264197C", VA = "0x264197C")]
    public void Start()
    {
    }

    [Token(Token = "0x6018B07")]
    [Address(RVA = "0x2641CA0", Offset = "0x2641CA0", VA = "0x2641CA0")]
    public void Update()
    {
    }

    [Token(Token = "0x6018B08")]
    [Address(RVA = "0x2641980", Offset = "0x2641980", VA = "0x2641980")]
    private void Initialize()
    {
    }

    [Token(Token = "0x6018B09")]
    [Address(RVA = "0x2642324", Offset = "0x2642324", VA = "0x2642324")]
    private Texture2D GetTexture(int width, int height, Color backgroundColor) => (Texture2D) null;

    [Token(Token = "0x6018B0A")]
    [Address(RVA = "0x2641CFC", Offset = "0x2641CFC", VA = "0x2641CFC")]
    private void UpdateFPS()
    {
    }

    [Token(Token = "0x6018B0B")]
    [Address(RVA = "0x2641FB8", Offset = "0x2641FB8", VA = "0x2641FB8")]
    private void UpdateMemoryUsage()
    {
    }

    [Token(Token = "0x6018B0C")]
    [Address(RVA = "0x2642418", Offset = "0x2642418", VA = "0x2642418")]
    private void ToggleStatus()
    {
    }

    [Token(Token = "0x6018B0D")]
    [Address(RVA = "0x264252C", Offset = "0x264252C", VA = "0x264252C", Slot = "4")]
    public void OnPointerDown(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6018B0E")]
    [Address(RVA = "0x264255C", Offset = "0x264255C", VA = "0x264255C", Slot = "5")]
    public void OnPointerUp(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6018B0F")]
    [Address(RVA = "0x2642270", Offset = "0x2642270", VA = "0x2642270")]
    private void OnTouchMove()
    {
    }

    [Token(Token = "0x6018B10")]
    [Address(RVA = "0x2642564", Offset = "0x2642564", VA = "0x2642564", Slot = "6")]
    public void OnPointerClick(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6018B11")]
    [Address(RVA = "0x2642610", Offset = "0x2642610", VA = "0x2642610")]
    public SystemMeter()
    {
    }

    [Token(Token = "0x2003D5B")]
    public enum Status
    {
      [Token(Token = "0x4010DB6")] Image,
      [Token(Token = "0x4010DB7")] Text,
    }
  }
}
