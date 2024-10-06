--[[
	スクリーンカラーエフェクトの処理
]]
SystemScreenColorEffect = load_postprocess_async("content_adv_postprocess_coloradjustments", "Ef_C_PP_ColorAdjustments", true)
PostEffectLoadList[#PostEffectLoadList + 1] = SystemScreenColorEffect

function on_screencolor(colorFilter, hueShift, saturation)
    if SystemScreenColorEffect != nil then
        SystemScreenColorEffect.OnScreenColor(colorFilter, hueShift, saturation)
    end
end

function off_screencolor()
    if SystemScreenColorEffect != nil then
        SystemScreenColorEffect.OffScreenColor()
    end
end

