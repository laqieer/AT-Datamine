
IrisOut = system.LoadUIShader("content_effect_adv_ui_cutin_effect_adv_eff_irisout", "ADV_Eff_Irisout", 0)
UiLoadList[#UiLoadList + 1] = IrisOut

-- 円の中心点と大きさの指定
function irisout_set(x,y,size)
	IrisOut.SetActive(true)
	x = IrisOut.GetScreenRatioX(x)
	y = IrisOut.GetScreenRatioY(y)
	size = IrisOut.GetScreenRatioX(size) / 2
	IrisOut.SetParameter("_PosX",x)
	IrisOut.SetParameter("_PosY",y)
	IrisOut.SetParameter("_MaskSize",size)
end

-- 円の大きさと時間の指定してアニメ
function irisout_to(size, duration)
	IrisOut.SetActive(true)
	size = IrisOut.GetScreenRatioX(size) / 2
	local signal = IrisOut.ParameterAnimation("_MaskSize",size,duration)
	return signal
end

-- 円の大きさと時間の指定してアニメと待機
function irisout_to_wait(size, duration)
	local signal = irisout_to(size, duration)
    while signal.IsProccessing() do
	    coroutine.yield()
    end
end

-- キャラと大きさと時間を指定してアニメ
function irisout_set_to(x,y,size,toSize,duration)
	irisout_set(x,y,size)
	return irisout_to(toSize,duration)
end

-- x 座標x
-- y 座標y
-- size   円の半径の開始サイズ
-- toSize 円の半径の終了サイズ
-- duration 時間(秒)
function irisout_set_to_wait(x,y,size,toSize,duration)
	local signal = irisout_set_to(x,y,size,toSize,duration)
    while signal.IsProccessing() do
	    coroutine.yield()
    end
end

function irisout_SetParameter(parameterName, n)
	IrisOut.SetParameter(parameterName, n)
end

function irisout_active(flag)
	IrisOut.SetActive(flag)
end

