--[[
	カメラフレームエフェクトの処理
]]
SystemCameraFrameEffect = load_postprocess_async("content_adv_postprocess_cameraframe", "Ef_C_PP_CameraFrame", true)
PostEffectLoadList[#PostEffectLoadList + 1] = SystemCameraFrameEffect

function on_cameraframe(pattern)
    if SystemCameraFrameEffect != nil then
        if pattern == 1 then
            SystemCameraFrameEffect.OnCameraFrame_VignetteFrame("#000000", true, true, true, true, 0.5, 0.5, 1.8, 1, false, 0)
        elseif pattern == 2 then
            SystemCameraFrameEffect.OnCameraFrame_VignetteFrame("#FFFFFF", true, true, true, true, 0.5, 0.5, 1.8, 1, false, 0)
        elseif pattern == 3 then
            SystemCameraFrameEffect.OnCameraFrame_ColorFrame("#000000", true, true, false, false, 0, 140, 1, 0)
        elseif pattern == 4 then
            SystemCameraFrameEffect.OnCameraFrame_ColorFrame("#FFFFFF", true, true, false, false, 0, 140, 1, 0)
        else
        end
        
    end
end

function off_cameraframe()
    if SystemCameraFrameEffect != nil then
        SystemCameraFrameEffect.OffCameraFrame()
    end
end
