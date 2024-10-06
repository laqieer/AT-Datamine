--[[
	エフェクトの処理
]]
PostEffectLoadList = {}

Include("content_luascript_system", "ScreenColorEffectFunctions", {"on_screencolor", "off_screencolor"})
Include("content_luascript_system", "CameraFrameEffectFunctions", {"on_cameraframe", "off_cameraframe"})

-- パーティクルエフェクトの再生速度を変更
--  effect = load_particle()で作ったコントローラID
--  speed = 速度倍率（0.0より上）
function set_particle_speed(effect, speed)
	effect.SetSpeed(speed)
end

-- パーティクルエフェクトの再生
--  effect = load_particle()で作ったコントローラID
function play_particle(effect)
	effect.Play()
end

-- パーティクルエフェクトの停止
--  effect = load_particle()で作ったコントローラID
function stop_particle(effect)
	effect.Stop()
end

-- ポストプロセスの結合荷重を設定
--  effect = load_postprocess()で作ったコントローラID
--  weight = 結合荷重値（0.0～1.0）
function set_postprocess_weight(effect, weight)
    effect.SetWeight(weight)
end

-- ポストプロセスの結合荷重をアニメーション
--  effect = load_postprocess()で作ったコントローラID
--  fromWeight = 結合荷重値の始値（0.0～1.0）
--  toWeight = 結合荷重値の終値（0.0～1.0）
--  duration = 秒数(0.0～)
function change_postprocess_weight(effect, fromWeight, toWeight, duration)
    effect.SetWeight(fromWeight, toWeight, duration)
end

-- ポストプロセスのボリュームのfloatパラメータを変更する
-- effect = load_postprocess()で作ったコントローラID
-- volumeTypeFullName = 変更を行いたいVolumeComponentのクラスのフルネーム
-- fieldName = 変更したいパラメータ名
-- value = 設定するfloat値
function set_postprocess_float_paramter(effect, volumeTypeFullName, fieldName, value)
	effect.SetVolumeParamterFloat(volumeTypeFullName, fieldName, value)
end

-- ポストプロセスのボリュームのintパラメータを変更する
-- effect = load_postprocess()で作ったコントローラID
-- volumeTypeFullName = 変更を行いたいVolumeComponentのクラスのフルネーム
-- fieldName = 変更したいパラメータ名
-- value = 設定するint値
function set_postprocess_int_paramter(effect, volumeTypeFullName, fieldName, value)
	effect.SetVolumeParamterInt(volumeTypeFullName, fieldName, value)
end

-- ポストプロセスのボリュームのboolパラメータを変更する
-- effect = load_postprocess()で作ったコントローラID
-- volumeTypeFullName = 変更を行いたいVolumeComponentのクラスのフルネーム
-- fieldName = 変更したいパラメータ名
-- value = 設定するbool値
function set_postprocess_bool_paramter(effect, volumeTypeFullName, fieldName, value)
	effect.SetVolumeParamterBool(volumeTypeFullName, fieldName, value)
end

-- ポストプロセスのボリュームのenumパラメータを変更する
-- effect = load_postprocess()で作ったコントローラID
-- volumeTypeFullName = 変更を行いたいVolumeComponentのクラスのフルネーム
-- fieldTypeName = 変更したいパラメータのクラスのフルネーム
-- fieldName = 変更したいパラメータ名
-- enumTypeName = 指定するenumの型のフルネーム
-- value = 設定するenumの文字列
function set_postprocess_enum_paramter(effect, volumeTypeFullName, fieldTypeName, fieldName, enumTypeName, value)
	effect.SetVolumeParamterEnum(volumeTypeFullName, fieldTypeName, fieldName, enumTypeName, value)
end

-- ポストプロセスのボリュームのVector2パラメータを変更する
-- effect = load_postprocess()で作ったコントローラID
-- volumeTypeFullName = 変更を行いたいVolumeComponentのクラスのフルネーム
-- fieldName = 変更したいパラメータ名
-- x = 設定するx値
-- y = 設定するy値
function set_postprocess_vector2_paramter(effect, volumeTypeFullName, fieldName, x, y)
	effect.SetVolumeParamterVector2(volumeTypeFullName, fieldName, x, y)
end

-- ポストプロセスのボリュームのVector3パラメータを変更する
-- effect = load_postprocess()で作ったコントローラID
-- volumeTypeFullName = 変更を行いたいVolumeComponentのクラスのフルネーム
-- fieldName = 変更したいパラメータ名
-- x = 設定するx値
-- y = 設定するy値
-- z = 設定するz値
function set_postprocess_vector3_paramter(effect, volumeTypeFullName, fieldName, x, y, z)
	effect.SetVolumeParamterVector3(volumeTypeFullName, fieldName, x, y, z)
end

-- ポストプロセスのボリュームのVector4パラメータを変更する
-- effect = load_postprocess()で作ったコントローラID
-- volumeTypeFullName = 変更を行いたいVolumeComponentのクラスのフルネーム
-- fieldName = 変更したいパラメータ名
-- x = 設定するx値
-- y = 設定するy値
-- z = 設定するz値
-- w = 設定するw値
function set_postprocess_vector4_paramter(effect, volumeTypeFullName, fieldName, x, y, z, w)
	effect.SetVolumeParamterVector4(volumeTypeFullName, fieldName, x, y, z, w)
end

-- ポストプロセスのボリュームのColorパラメータを変更する
-- effect = load_postprocess()で作ったコントローラID
-- volumeTypeFullName = 変更を行いたいVolumeComponentのクラスのフルネーム
-- fieldName = 変更したいパラメータ名
-- value = 設定するカラーのコード(#FFFFFF形式)
function set_postprocess_color_paramter(effect, volumeTypeFullName, fieldName, value)
	effect.SetVolumeParamterColor(volumeTypeFullName, fieldName, value)
end

-- フォグ設定関連
-- フォグコントローラーID
FogContoroller = nil

-- フォグの有効化
function fog_active()
	if FogContoroller == nil then
		FogContoroller = create_fog_contoroller()
	end
	FogContoroller.Enable();
end

-- フォグの無効化
function fog_deactive()
	if FogContoroller == nil then
		FogContoroller = create_fog_contoroller()
	end
	FogContoroller.Disable();
end

-- フォグをシーンの初期設定値にリセット
function fog_reset()
	 if FogContoroller != nil then
		FogContoroller.Reset();
	 end
end

-- フォグのパラメータ設定
-- colorCode = フォグカラー
-- startDist = リニアフォグの開始距離
-- endDist = リニアフォグの終了距離
-- density = フォグの密度
function fog_set_parameter(colorCode, startDist, endDist, density)
	 linear_fog_set_parameter(colorCode, startDist, endDist);
	 exponential_fog_set_parameter(colorCode, density);
end

-- リニアフォグのパラメータ設定
-- colorCode = フォグカラー
-- startDist = リニアフォグの開始距離
-- endDist = リニアフォグの終了距離
function linear_fog_set_parameter(colorCode, startDist, endDist)
	 if FogContoroller == nil then
		FogContoroller = create_fog_contoroller()
	 end
	 FogContoroller.SetLinearFogParameter(colorCode, startDist, endDist);
end

-- 指数・乗指数フォグのパラメータ設定
-- colorCode = フォグカラー
-- density = フォグの密度
function exponential_fog_set_parameter(colorCode, density)
	 if FogContoroller == nil then
		FogContoroller = create_fog_contoroller()
	 end
	 FogContoroller.SetExponentialFogParameter(colorCode, density);
end

-- BGParamters設定関連
-- フォグコントローラーID
BgParameterContoroller = nil

-- BGParamtersの設定
function set_bgparameters(enable, blend, colorCode)
	if BgParameterContoroller == nil then
		BgParameterContoroller = create_bgparamters_contoroller()
	end
    BgParameterContoroller.SetBgParameter(enable, blend, colorCode)
end

function wait_load_post_effect_list()
	for index, asset in pairs(PostEffectLoadList) do
		while asset.IsProccessing() do
			coroutine.yield()
		end
	end
end

-- 被写界深度プレハブ読み込み
function load_depthoffield_effect()
	local effect = nil
    effect = load_postprocess("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", true)
    return effect
end

