--[[
	カメラ専用の処理
]]


-- アクティブなカメラを指定する
--  active_camera = アクティブにするコントロールID
function on_camera(active_camera)
	if CameraList != nil then
		for index, camera in pairs(CameraList) do
			camera.SetActive(active_camera == camera)
		end
	end
end

-- 注視点を作成する
-- camera = 対象カメラ
-- posX = 注視点のワールド座標X
-- posY = 注視点のワールド座標Y
-- posZ = 注視点のワールド座標Z
function set_camera_lookat(camera, posX, posY, posZ)
	if type(posX) == "table" then
		camera.SetLookAt(posX[1], posX[2], posX[3])
	else
		camera.SetLookAt(posX, posY, posZ)
	end
end

-- 注視点の破棄
-- camera = 対象カメラ
function reset_camera_lookat(camera)
	camera.ResetLookAt()
end

-- 注視対象の設定
-- camera = 対象カメラ
-- object = 注視対象のオブジェクト
function set_camera_lookat_object(camera, object)
	camera.SetLookAtObject(object)
end

-- 注視対象の破棄
-- camera = 対象カメラ
function reset_camera_lookat_object(camera)
	camera.ResetLookAtObject()
end


-- 画角のアニメーション再生
-- camera = 対象カメラ
-- startFOV = 画角アニメーションの開始値
-- endFOV = 画角アニメーションの終了値
-- duration = かかる秒数
function play_camera_fieldOfView(camera, startFOV, endFOV, duration)
	if type(startFOV) == "table" then
		if #startFOV == 3 then
			local nowFOV = startFOV[1]
			local valuePerSecond = (startFOV[2] - startFOV[1]) / startFOV[3]
			if valuePerSecond > 0.0 then
				while nowFOV <= startFOV[2] do
					camera.FieldOfView(nowFOV)
					coroutine.yield()
					nowFOV = nowFOV + system.GetDeltaTime() * valuePerSecond
				end
			else
				while nowFOV >= startFOV[2] do
					camera.FieldOfView(nowFOV)
					coroutine.yield()
					nowFOV = nowFOV + system.GetDeltaTime() * valuePerSecond
				end
			end
		else
			local nowFOV = startFOV[1]
			local valuePerSecond = (startFOV[2] - startFOV[1]) / endFOV
			if valuePerSecond > 0.0 then
				while nowFOV <= startFOV[2] do
					camera.FieldOfView(nowFOV)
					coroutine.yield()
					nowFOV = nowFOV + system.GetDeltaTime() * valuePerSecond
				end
			else
				while nowFOV >= startFOV[2] do
					camera.FieldOfView(nowFOV)
					coroutine.yield()
					nowFOV = nowFOV + system.GetDeltaTime() * valuePerSecond
				end
			end
		end
	else
		local nowFOV = startFOV
		local valuePerSecond = (endFOV - startFOV) / duration
		if valuePerSecond > 0.0 then
			while nowFOV <= endFOV do
				camera.FieldOfView(nowFOV)
				coroutine.yield()
				nowFOV = nowFOV + system.GetDeltaTime() * valuePerSecond
			end
		else
			while nowFOV >= endFOV do
				camera.FieldOfView(nowFOV)
				coroutine.yield()
				nowFOV = nowFOV + system.GetDeltaTime() * valuePerSecond
			end
		end
	end
end

-- カメラの座標角度画角を設定
-- object = 対象カメラ
-- posrotfov = 座標角度画角の配列
function set_camera_prf(camera, posrotfov)
	camera.SetPos(posrotfov[1], posrotfov[2], posrotfov[3])
	camera.SetRot(posrotfov[4], posrotfov[5], posrotfov[6])
	camera.FieldOfView(posrotfov[7])
end

-- ニアクリップの設定
-- camera = 対象カメラ
-- value = 設定値
function set_camera_nearclip(camera, value)
	camera.NearClip(value)
end


-- ファークリップの設定
-- camera = 対象カメラ
-- value = 設定値
function set_camera_farclip(camera, value)
	camera.FarClip(value)
end


-- Timeline用のカメラ
-- camera = 対象カメラ
-- posrotfov = カメラ座標角度画角のテーブル
-- duration = かかる秒数
function timeline_camera(camera, posrotfov, duration)
	slidemove(camera, posrotfov[1], posrotfov[2], posrotfov[3], duration)
	turn(camera, posrotfov[4], posrotfov[5], posrotfov[6], duration)
	nowFOV = camera.GetFieldOfView()
	local op = create_coroutine(play_camera_fieldOfView)
	coroutine.resume(op, camera, nowFOV, posrotfov[7], duration)
end

-- 現在のアクティブなカメラを取得する
function get_active_camera()
	local camera = nil
	if CameraList != nil then
		for i=1, #CameraList do
			if CameraList[i].IsActive() == true then
				camera = CameraList[i]
				break
			end
		end
	end
	return camera
end

-- ADV小用カメラのアニメーション読み込み
-- camera = 対象カメラ
-- path = アセットバンドルのパス
-- animName = *.animファイル名
function load_camera_anim(camera, path, animName)
	camera.LoadCameraAnim(path,animName)
	while camera.IsProccessing() do
		coroutine.yield()
	end
end

-- ADV小用カメラ　キャラ専用
-- camera = 対象カメラ
-- path = アセットバンドルのパス
-- animName = *.animファイル名
-- actor = 対象モデル
function load_exclusive_camera(camera, assetBundleName, animName, actor)
	camera.LoadExclusiveCamera(assetBundleName, animName, actor)
	while camera.IsProccessing() do
		coroutine.yield()
	end
end

-- クロスディゾルブ実行
-- toCamera = 遷移先カメラ
-- duration = フェード秒
-- useCapture = キャプチャした画像を使用するか？falseの場合は都度レンダリングされます。
function crossdissolve(toCamera, duration, useCapture)
	local fromCamera = get_active_camera()
	if useCapture and fromCamera != nil and fromCamera != toCamera then
		crossdissolve_source_create(fromCamera)
	end
	on_camera(toCamera)
	-- アクティブなカメラがないもしくは遷移先と同じ場合は実行しない
	if fromCamera != nil and fromCamera != toCamera then
		toCamera.StartCrossDissolve(fromCamera, duration, 1)
	end
end

-- クロスディゾルブ用のキャプチャ画像を生成する
-- caputureCamera = キャプチャを生成するカメラ
function crossdissolve_source_create(caputureCamera)
	on_camera(caputureCamera)
	-- キャプチャを使用する場合は1フレームレンダリング用の待ちをいれる。
	caputureCamera.CreateCrossDissolveRenderTexture(1)
	coroutine.yield()
	-- レンダリング用のカメラをdisableにすることでそれ以上更新させないようにする
	caputureCamera.DisableCrossDissolveRenderCamera()
end

-- クロスディゾルブ用のキャプチャ画像を破棄する
-- caputureCamera = キャプチャを破棄するカメラ
function crossdissolve_source_destory(caputureCamera)
	-- キャプチャに使用したキャプチャ関連を破棄する。
	caputureCamera.DestoryCrossDissolveRenderTexture()
end

-- カメラクエイクの開始
-- camera = 対象カメラ
-- amplitude = 揺れ強度
-- duration = 揺れ時間
function shake_camera(camera, amplitude, duration)
	camera.StartShake(amplitude, duration)
end

-- カメラクエイクの停止
-- camera = 対象カメラ
function stop_shake_camera(camera)
	camera.StopShake()
end

function set_light_effect_parameter(camera, bgParameters_hardlight_blend, bgParameters_hardlight_color_code, lightForChrarcters_direction_type_name, lightForChrarcters_intensity, screenGradation_intensity)
	if camera ~= nil then
		camera.SetLightEffectParameter(camera, bgParameters_hardlight_blend, bgParameters_hardlight_color_code, lightForChrarcters_direction_type_name, lightForChrarcters_intensity, screenGradation_intensity)
	end
end

function set_vignette_effect(camera, centerX, centerY, colorCode, intensity, smoothness, rounded)
	if camera ~= nil then
		camera.SetVignetteEffect(camera, centerX, centerY, colorCode, intensity, smoothness, rounded)
	end
end

function disable_vignette_effect(camera)
	if camera ~= nil then
		camera.DisableVignetteEffect()
	end
end

function load_camera_anim_preload(camera, path, animName)
	system.PreLoadRequest(path)
end
