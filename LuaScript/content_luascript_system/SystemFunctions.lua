--[[
	全体にかかわる処理
]]

-- 追加シーンの読み込み
--  assetbundleName = シーンファイルのアセットバンドル名
--  fileName = シーンファイルのファイル名
function load_scene(assetbundleName, fileName)
	local checkLoaded = system.LoadScene(assetbundleName, fileName)
	while checkLoaded.IsProccessing() do
		coroutine.yield()
	end
	
	-- 読み込んだシーン名のリストを作っておく
	if loadedSceneList == nil then
		loadedSceneList = {}
	end
	
	-- 読み込んだシーン名のリスト
	loadedSceneList[#loadedSceneList + 1] = fileName
end

function load_area_scene(areaId)
	load_scene("content_bg_area_"..areaId, "Area"..areaId)
end

function load_duel_scene(duelId)
	load_scene("content_bg_duel_"..duelId, ""..duelId)
end

function load_field_scene(fieldId)
	load_scene("content_bg_field_"..fieldId, ""..fieldId)
end

function load_scene_preload(assetbundleName, fileName)
	system.PreDownloadRequest(assetbundleName)
end

function load_area_scene_preload(areaId)
	load_scene_preload("content_bg_area_"..areaId)
end

function load_duel_scene_preload(duelId)
	load_scene_preload("content_bg_duel_"..duelId)
end

function load_field_scene_preload(fieldId)
	load_scene_preload("content_bg_field_"..fieldId)
end

function load_sequence_area_scene(areaId)
    local areaId = system.GetSequenceBackGround(areaId)
    load_area_scene(areaId)
end

function load_sequence_area_scene_preload(areaId)
    local areaId = system.GetSequenceBackGround(areaId)
    load_area_scene_preload(areaId)
end

-- シーンを切り替える
--  fileName = シーンファイルのファイル名
function change_scene(fileName)
	system.ChangeScene(fileName)
end

function change_area_scene(areaId)
	change_scene("Area"..areaId)
end

function change_duel_scene(duelId)
	change_scene(""..duelId)
end

function change_field_scene(fieldId)
	change_scene(""..fieldId)
end

function change_weather_cloudy(active)
	if active then
		system.ChangeSceneWeather(7)
	else
		system.ChangeSceneWeather(2)
	end
end

-- エリア用シーンでの配置テーブルの読み込み
--  assetbundleName = 配置テーブルファイルのアセットバンドル名
--  fileName = 配置テーブルファイルのファイル名
function load_area_placement(assetbundleName, fileName)
	local checkLoaded = system.LoadPlacement(assetbundleName, fileName)
	while checkLoaded.IsProccessing() do
		coroutine.yield()
	end
end

function load_area_placement_preload(assetbundleName, fileName)
	system.PreLoadRequest(assetbundleName)
end

-- オブジェクトの読み込み
--  assetbundleName = モデルのプレハブのアセットバンドル名
--  fileName = モデルのプレハブのファイル名
--  posX = 位置X
--  posY = 位置Y
--  posZ = 位置Z
--  angX = 角度X
--  angY = 角度Y
--  angZ = 角度Z
--  animationTag = 本体アニメーションのタグ
--  return = コントローラID
function set_object(assetbundleName, fileName, posX, posY, posZ, angX, angY, angZ, animationTag)
	local object = system.CreateObject("Default")
	object.LoadModel(assetbundleName, fileName, nil, nil)
	while object.IsProccessing() do
		coroutine.yield()
	end
	-- ラベル定義対応
	if type(posX) == "table" then
		object.InitializeTransform(posX[1], posX[2], posX[3], posX[4], posX[5], posX[6], 1.0, 1.0, 1.0)
		object.PlayAnimation(posY, 0.0, 1.0, true)
	else
		object.InitializeTransform(posX, posY, posZ, angX, angY, angZ, 1.0, 1.0, 1.0)
		object.PlayAnimation(animationTag, 0.0, 1.0, true)
	end
	return object
end

function set_object_preload(assetbundleName, fileName, posX, posY, posZ, angX, angY, angZ, animationTag)
	system.PreLoadRequest(assetbundleName)
end

-- オブジェクトの読み込み
--  assetbundleName = モデルのプレハブのアセットバンドル名
--  fileName = モデルのプレハブのファイル名
--  isActive = 開始時のアクティブ状態
--  return = コントローラID
function set_object(assetbundleName, fileName, isActive)
	local object = system.CreateObject("Default")
	object.LoadModel(assetbundleName, fileName, nil, nil)
	while object.IsProccessing() do
		coroutine.yield()
	end
	object.SetActive(isActive)
	return object
end

function set_object_preload(assetbundleName, fileName, isActive)
	system.PreLoadRequest(assetbundleName)
end

-- 空のオブジェクトの生成
--  isActive = 開始時のアクティブ状態
--  return = コントローラID
function set_empty_object(isActive)
	local object = system.CreateObject("Default")
	object.SetActive(isActive)
	return object
end

-- パーティクルエフェクトの読み込み
--  assetbundleName = モデルのプレハブのアセットバンドル名
--  fileName = モデルのプレハブのファイル名
--  isActive = 開始時のアクティブ状態
--  enableSE = エフェクトが持つSEを使うか
--  return = コントローラID
function load_particle(assetbundleName, fileName, isActive, enableSE)
    local effect = system.CreateParticleEffect("Default", isActive, enableSE)
	effect.LoadModel(assetbundleName, fileName, nil, nil)
	while effect.IsProccessing() do
		coroutine.yield()
	end
	return effect
end

function load_particle_preload(assetbundleName, fileName, isActive, enableSE)
	system.PreLoadRequest(assetbundleName)
end

-- ポストプロセスエフェクトの読み込み
--  assetbundleName = モデルのプレハブのアセットバンドル名
--  fileName = モデルのプレハブのファイル名
--  isActive = 開始時のアクティブ状態
--  return = コントローラID
function load_postprocess(assetbundleName, fileName, isActive)
    local posteffect = system.LoadPostEffect(assetbundleName, fileName)
	while posteffect.IsProccessing() do
		coroutine.yield()
	end
	posteffect.SetActive(isActive)
    return posteffect
end

function load_postprocess_preload(assetbundleName, fileName, isActive)
	system.PreLoadRequest(assetbundleName)
end

-- ポストプロセスエフェクトの非同期読み込み
--  assetbundleName = モデルのプレハブのアセットバンドル名
--  fileName = モデルのプレハブのファイル名
--  isActive = 開始時のアクティブ状態
--  return = コントローラID
function load_postprocess_async(assetbundleName, fileName, isActive)
    local posteffect = system.LoadPostEffect(assetbundleName, fileName)
	posteffect.SetActive(isActive)
    return posteffect
end

-- フォグの管理クラスを受け取る
function create_fog_contoroller()
	return system.CreateFogController()
end

-- BGParamtersの管理クラスを受け取る
function create_bgparamters_contoroller()
	return system.CreateBgParametersObject()
end

-- キャラクターの読み込み（3Dモデル無し版）
--  return = コントローラID
function set_chara_unknown()
	local character = system.CreateHuman("Chara")
    character.SetupNo3DModel()
    character.PlayFacial("Normal", 0.0, 1.0, false)
	return character
end

-- キャラクターの読み込み
--  objectAssetbundleName = モデルのプレハブのアセットバンドル名
--  objectFileName = モデルのプレハブのファイル名
--  animationAssetbundleName = 本体アニメーションのパックのアセットバンドル名
--  animationFileName = 本体アニメーションのパックのファイル名
--  facialAssetbundleName = フェイシャルアニメーションのパックのアセットバンドル名
--  facialFileName = フェイシャルアニメーションのパックのファイル名
--  posX = 位置X
--  posY = 位置Y
--  posZ = 位置Z
--  angY = 角度Y
--  animationTag = 本体アニメーションのタグ
--  facialTag = 表情タグ
--  return = コントローラID
function set_chara(objectAssetbundleName, objectFileName, animationAssetbundleName, animationFileName, facialAssetbundleName, facialFileName, posX, posY, posZ, angY, animationTag, facialTag)
	local character = system.CreateHuman("Chara")
	character.LoadModel(objectAssetbundleName, objectFileName, animationAssetbundleName, animationFileName, facialAssetbundleName, facialFileName)
	while character.IsProccessing() do
		coroutine.yield()
	end
	-- ラベル定義対応
	if type(posX) == "table" then
		character.InitializeTransform(posX[1], posX[2], posX[3], 0.0, posX[4], 0.0, 1.0, 1.0, 1.0)
		character.SetAnimationSystemChangeTime(0.0, 0.0)
		character.PlayAnimation(posY, 0.0, 1.0, true)
		character.PlayFacial(posZ, 0.0, 1.0, false)		
	else
		character.InitializeTransform(posX, posY, posZ, 0.0, angY, 0.0, 1.0, 1.0, 1.0)
		character.SetAnimationSystemChangeTime(0.0, 0.0)
		character.PlayAnimation(animationTag, 0.0, 1.0, true)
		character.PlayFacial(facialTag, 0.0, 1.0, false)
	end
	return character
end

function set_chara_preload(objectAssetbundleName, objectFileName, animationAssetbundleName, animationFileName, facialAssetbundleName, facialFileName, posX, posY, posZ, angY, animationTag, facialTag)
	system.PreLoadRequest(objectAssetbundleName)
	system.PreLoadRequest(animationAssetbundleName)
	system.PreLoadRequest(facialAssetbundleName)
end

-- キャラクターの読み込み(アニメーター付き
--  objectAssetbundleName = モデルのプレハブのアセットバンドル名
--  objectFileName = モデルのプレハブのファイル名
--  animationAssetbundleName = 本体アニメーションのパックのアセットバンドル名
--  animationFileName = 本体アニメーションのパックのファイル名
--  facialAssetbundleName = フェイシャルアニメーションのパックのアセットバンドル名
--  facialFileName = フェイシャルアニメーションのパックのファイル名
--  posX = 位置X
--  posY = 位置Y
--  posZ = 位置Z
--  angY = 角度Y
--  animationTag = 本体アニメーションのタグ
--  facialTag = 表情タグ
--  animatorContorollerAssetbundleName = アニメーションコントローラーのアセットバンドル名
--  animatorContorollerName = アニメーションコントローラーの名前
--  defaultTriggerName = アニメーターのデフォルトステートへのトリガー名
--  return = コントローラID
function set_chara_animator(objectAssetbundleName, objectFileName, animationAssetbundleName, animationFileName, facialAssetbundleName, facialFileName, posX, posY, posZ, angY, animationTag, facialTag, animatorControllerAssetbundleName, animatorControllerName, defaultTriggerName)
	local character = system.CreateHuman("Chara")
	character.LoadModel(objectAssetbundleName, objectFileName, animationAssetbundleName, animationFileName, facialAssetbundleName, facialFileName)
	while character.IsProccessing() do
		coroutine.yield()
	end
	if type(posX) == "table" then
		character.LoadAnimator(angY, animationTag)
	else
		character.LoadAnimator(animatorControllerAssetbundleName, animatorControllerName)
	end

	while character.IsProccessing() do
		coroutine.yield()
	end

	if type(posX) == "table" then
		character.SetDefaultTriggerName(facialTag)
	else
		character.SetDefaultTriggerName(defaultTriggerName)
	end

	-- ラベル定義対応
	if type(posX) == "table" then
		character.InitializeTransform(posX[1], posX[2], posX[3], 0.0, posX[4], 0.0, 1.0, 1.0, 1.0)
		character.SetAnimationSystemChangeTime(0.0, 0.0)
		character.PlayAnimation(posY, 0.0, 1.0, true)
		character.PlayFacial(posZ, 0.0, 1.0, false)		
	else
		character.InitializeTransform(posX, posY, posZ, 0.0, angY, 0.0, 1.0, 1.0, 1.0)
		character.SetAnimationSystemChangeTime(0.0, 0.0)
		character.PlayAnimation(animationTag, 0.0, 1.0, true)
		character.PlayFacial(facialTag, 0.0, 1.0, false)
	end
	return character
end

function set_chara_animator_preload(objectAssetbundleName, objectFileName, animationAssetbundleName, animationFileName, facialAssetbundleName, facialFileName, posX, posY, posZ, angY, animationTag, facialTag, animatorControllerAssetbundleName, animatorControllerName, defaultTriggerName)
	system.PreLoadRequest(objectAssetbundleName)
	system.PreLoadRequest(animationAssetbundleName)
	system.PreLoadRequest(facialAssetbundleName)
	system.PreLoadRequest(animatorControllerAssetbundleName)
end

--  頭個別アニメーション用アニメーションパック読み込み
--  object = コントローラID
--  headAnimationPackAssetbundleName = アニメーションのパックのアセットバンドル名
--  headAnimationPackFileName = アニメーションのパックのファイル名
function load_head_animation(object, headAnimationPackAssetbundleName, headAnimationPackFileName)
	local signal = object.LoadHeadAnimation(headAnimationPackAssetbundleName, headAnimationPackFileName)

	while signal.IsProccessing() do
		coroutine.yield()
	end
end

function load_head_animation_preload(object, headAnimationPackAssetbundleName, headAnimationPackFileName)
	system.PreLoadRequest(headAnimationPackAssetbundleName)
end

--  エリアオブジェクト用アニメーションパック読み込み
--  object = コントローラID
--  animationAssetbundleName = アニメーションのパックのアセットバンドル名
--  animationFileName = アニメーションのパックのファイル名
function load_animpack(object, animationAssetbundleName, animationFileName)
	object.LoadAnim(animationAssetbundleName, animationFileName)
	while object.IsProccessing() do
		coroutine.yield()
	end
end

function load_animpack_preload(object, animationAssetbundleName, animationFileName)
	system.PreLoadRequest(animationAssetbundleName)
end

-- キャラクターの取得
--  objectAccessName = 外部からモデルを参照する際の名前
--  animationPath = 本体アニメーションのパックのパス
--  facialPath = フェイシャルアニメーションのパックのパス
--  return = コントローラID
function get_chara(objectAccessName, animationAssetbundleName, animationFileName, facialAssetbundleName, facialFileName)
	local character = system.CreateHuman("Chara")

	character.LinkModel(objectAccessName, animationAssetbundleName, animationFileName, facialAssetbundleName, facialFileName)
	while character.IsProccessing() do
		coroutine.yield()
	end
	character.SetAnimationSystemChangeTime(0.5, 0.25)
	return character
end

function get_chara_preload(objectAccessName, animationAssetbundleName, animationFileName, facialAssetbundleName, facialFileName)

	system.PreLoadRequest(animationAssetbundleName)
	system.PreLoadRequest(facialAssetbundleName)
end

-- オブジェクトの取得
--  objectName = Unity Hierarchy上のGameObject名
--  return = コントローラID
function get_object(objectName)
	local object = system.CreateObject("Default")
	object.LinkObject(objectName)
	return object
end

--  オブジェクトの生成
--  name = 生成したいGameObject名
--  return = コントローラID
function create_object(name)
	local object = system.CreateObject("Default")
	object.SetName(name)
	object.LinkObject(name)
	--LinkObjectすると名前が変わるので付け直す
	object.SetName(name)
	return object
end

--  オブジェクトの座標を設定する
--  object = コントローラID
--  x = x座標
--  y = y座標
--  z = z座標
function set_pos_object(object, x, y, z)
	object.SetPos(x,y,z)
end

-- カメラを登録する
function create_camera()
	local camera = system.CreateCamera()
	camera.SetCamera()

	camera.SetActive(false)
	if CameraList == nil then
		CameraList = {}
	end
	CameraList[#CameraList + 1] = camera
	return camera
end

-- カメラの登録をしなおすときにリセットする
function reset_camera_list()
	CameraList = {}
end

-- カメラを登録する
--  posX = 位置X
--  posY = 位置Y
--  posZ = 位置Z
--  angX = 角度X
--  angY = 角度Y
--  angZ = 角度Z
--  fieldOfView = 画角
--  return = コントローラID
function set_camera(posX, posY, posZ, angX, angY, angZ, fieldOfView)
	local camera = create_camera()

	-- ラベル定義対応
	if type(posX) == "table" then
		camera.InitializeTransform(posX[1], posX[2], posX[3], posX[4], posX[5], posX[6], 1.0, 1.0, 1.0)
		camera.FieldOfView(posX[7])
	else
		camera.InitializeTransform(posX, posY, posZ, angX, angY, angZ, 1.0, 1.0, 1.0)
		camera.FieldOfView(fieldOfView)
	end

	return camera
end

-- 処理待ち
--  control = コントローラID
-- ※todo:スペル修正
function wait_proccess(control)
	while control.IsProccessing() do
		coroutine.yield()
	end
end

-- 時間待ち
--  seconds = 待ち秒数
function wait_time(seconds)
	local control = system.CreateTimer(seconds)
	while control.IsProccessing() do
		coroutine.yield()
	end
end

-- デバッグメッセージ出力
--  message = 文字列
function debug_print(message)
	system.DebugLog(message)
end

-- デバッグモードか判定
function debug()
	return system.CheckDebugMode()
end

-- デバッグモード時のみタップ待ちをする
function debug_wait_tap()
	if debug() then
		local control = system.DebugPause()
		while control.IsProccessing() do
			coroutine.yield()
		end
	end
end

-- デバッグモード時のみ、スクリプトファイル名表示
function show_current_script()
	if debug() then
		local message = system.GetScriptFileName()
		open_narration_window()
		message_direct(message)
		close_narration_window()
	end
end

-- 子コルーチンの作成
--  user_function = コルーチンで動かす関数
--  return = 作成されたスレッド
-- 実行は返されたスレッドを使って、直にcoroutine.resumeを呼ぶ
function create_coroutine(user_function)
	local thread = coroutine.create(user_function)
	system.AddCoroutine(thread)
	return thread
end

-- 連続して再生するデモの予約
--  demoName = 再生予定のデモの名前
function reserve_next_script(demoName)
	system.AddReserveDemo(demoName)
end

-- サウンドファイルの読み込み
--  bank_name = バンク名
function load_sound(bank_name)
	system.LoadSoundFile(bank_name)
end

function preload_sound(bank_name)
	system.PreDownloadRequest(bank_name)
end


-- BGMの再生
--  event_name = イベント名
--  return = 管理ID
function bgm_play(event_name, duration)
	if duration == nil then
		duration = 0.0
	end
	return system.PlayBGM(event_name, duration)
end

-- SEの再生
--  event_name = イベント名
--  return = 管理ID
function se_play(event_name)
	return system.PlaySE(event_name)
end

-- 環境音を再生するか
-- flag = trueだと再生する
function play_env_se(flag)
	if flag == nil then
		flag = true
	end
	system.PlayEnvSe(flag)
end

-- Voiceの再生メッセージタグからボイスを取得する
--  event_name = メッセージタグ
--  return = 管理ID
function voice_play(event_name)
	return system.PlayVoice(event_name)
end

-- SoundSignalを取得する
-- signal = SoundSignalが含まれているLuaSignalMini
-- return = SoundSignal
function get_sound(signal)
	return system.GetSoundSignal(signal)
end

-- BGMの再生停止
--  sound_id = bgm_playで返った管理ID
function bgm_stop(sound_id, duration)
	if duration == nil then
		duration = 0.0
	end
	system.StopBGM(sound_id, duration)
end

-- SEの再生停止
--  sound_id = se_playで返った管理ID
function se_stop(sound_id)
	return system.StopSE(sound_id)
end

-- Voiceの再生停止
--  sound_id = voice_playで返った管理ID
function voice_stop(sound_id)
	system.StopVoice(sound_id)
end

-- int型の変数を取得
--  variableName = adv_variables.xlsmで設定した変数名
function get_int(variableName)
	return system.Param.GetInt(variableName)
end

-- int型の変数を設定
--  variableName = adv_variables.xlsmで設定した変数名
--  variableValue = 設定値
function set_int(variableName, variableValue)
	system.Param.SetInt(variableName, variableValue)
end

-- 現在の施設情報を元に、パラメータを取得する
-- 引数はテスト時のみ有効になるので、正式動作時は省略しても問題ない
--  dummyAttachID = story_facility_attach.xlsmで設定した施設設定ID
--  dummyRewardSetLabelID = story_facility_rewardsetlabel.xlsmで設定した通常時の報酬セットID
--  dummyBonusSetLabelID = story_facility_rewardsetlabel.xlsmで設定したボーナス時の報酬セットID
--  isBonusWeather = ボーナスが天候ボーナスか、falseなら曜日ボーナス
function set_facility(dummyAttachID, dummyRewardSetLabelID, dummyBonusSetLabelID, isBonusWeather)
	if dummyRewardSetLabelID == nil then
		dummyRewardSetLabelID = 0
	end
	if dummyBonusSetLabelID == nil then
		dummyBonusSetLabelID = 0
	end
	if isBonusWeather == nil then
		isBonusWeather = false
	end
	return system.Param.SetFacility(dummyAttachID, dummyRewardSetLabelID, dummyBonusSetLabelID, isBonusWeather)
end

-- 人間パラメータを取得する
--  variableNames = adv_variables.xlsmで設定した変数名（人間パラメータ）の配列
function set_human_parameter(variableNames)
	return system.Param.SetHumanParameter(variableNames)
end


-- ストーリー現在の天候を取得する
-- story_weather.xlsmに書かれている天候の値が返る
function get_weather()
	return system.GetStorySequenceWeather()
end

-- ストーリー現在の時間帯を取得する
-- story_timeslot.xlsmに書かれている時間帯の値が返る
function get_timeslot()
	return system.GetStorySequenceTimeSlot()
end

-- プレイヤーの名前を取得する
function get_playername()
	return system.GetPlayerName()
end

-- プレイヤーのタイプ（キャラメイキングで選んだ値）を取得する
function get_playertype()
	return system.GetPlayerType();
end

-- エリアイベントクエストの情報取得
function get_areaeventquest()
    return system.GetAreaEventQuestObject()
end
function get_subquest()
    return system.GetSubQuestObject()
end
-- メッセージテキストを取得する
-- 主に<%1>を置換して文字列にするため使用
-- messageTag = メッセージタグ
function get_message_text(messageTag)
	return system.GetMessageText(messageTag)
end

-- 現在の言語を取得
function language()
	return system.GetLanguage()
end

-- カレンダー表示切り替え
-- dispflag = falseだと表示オフ
function disp_calendar(dispflag)
	system.DispCalendar(dispflag)
end

-- 通信実行をしてもらう
-- return 通信処理待ち wait_proccess()で戻り値を待ったあと、Resultにアクセスして結果を取り出すこと
function connection()
    return system.Connection()
end

-- タイムラインのシーンを読み込む。
-- assetbundleName = タイムラインシーンファイルのアセットバンドル名
-- fileName = タイムラインシーンファイルのファイル名
function load_timeline(assetbundleName, fileName)
	-- タイムラインのアセットバンドルを読み込む
	local checkLoaded = system.LoadScene(assetbundleName, fileName)
	while checkLoaded.IsProccessing() do
		coroutine.yield()
	end
	
	-- タイムラインシーンのトラックバインド
	system.BindTimelineSceneObject(fileName)
	
	-- タイムラインシーンのオブジェクトを非表示にする
	system.SetActiveSceneRootObject(fileName, false)
	
	-- ADVで読み込んだシーンをアクティブに戻す。主にLinkCameraを戻すよう
	if loadedSceneList != nil then
		if #loadedSceneList == 1 then
			change_scene(loadedSceneList[1])
		end
	end

end

function load_timeline_preload(assetbundleName, fileName)
	system.PreLoadRequest(assetbundleName)
end

-- タイムラインを再生する
-- fileName = タイムラインシーンファイルのファイル名
-- bgflag = 背景リソースを含んでいるタイムラインを再生する場合はtrue
-- fade = タイムラインに入る前のフェード関数
function play_timeline(fileName, bgflag, fade)
	if fade != nil then
		fade()
	end
	
	-- AdvManagerの3DRootを非アクティブにする
	system.Set3DRootActive(false)
	
	-- ADVで読み込んだシーン（主に背景）を非アクティブにする
	if bgflag == true then
		change_scene("")
	end
	
	-- タイムライン再生
	signal = system.PlayTimeline(fileName)
	fadein(0)
	while signal.IsProccessing() do
		coroutine.yield()
	end
	
	-- ADVで読み込んだシーンをアクティブに戻す
	if bgflag == true then
		if loadedSceneList != nil then
			change_scene(loadedSceneList[1])
		end
	end
	
	-- AdvManagerの3DRootをアクティブに戻す
	system.Set3DRootActive(true)
end

function play_timeline_async(fileName, bgflag, fade)
	if fade != nil then
		fade()
	end
	
	-- AdvManagerの3DRootを非アクティブにする
	system.Set3DRootActive(false)
	
	-- ADVで読み込んだシーン（主に背景）を非アクティブにする
	if bgflag == true then
		change_scene("")
	end
	
	-- タイムライン再生
	signal = system.PlayTimeline(fileName)
	fadein(0)

	return signal;
end

function stop_timeline()
	if system.IsPlayingTimeline() then
		system.StopTimeline();
	end
	-- ADVで読み込んだシーンをアクティブに戻す
	if bgflag == true then
		if loadedSceneList != nil then
			change_scene(loadedSceneList[1])
		end
	end
	
	-- AdvManagerの3DRootをアクティブに戻す
	system.Set3DRootActive(true)
end

function pause_timeline()
	system.PauseTimeline();
end

function resume_timeline()
	system.ResumeTimeline();
end

function initialize_MA0010023(charaId)
	load_timeline("content_adv_timeline_timelinemovie_ma_00100_23_scene", "MA_00100_23")

	local signal = system.InitializeMA0010023(charaId)
	while signal.IsProccessing() do
		coroutine.yield()
	end
end

function play_MA0010023()
	-- AdvManagerの3DRootを非アクティブにする
	system.Set3DRootActive(false)

	change_scene("MA_00100_23")

	-- タイムライン再生
	signal = system.PlayTimeline("MA_00100_23")
	fadein(0)
	while signal.IsProccessing() do
		coroutine.yield()
	end

	-- AdvManagerの3DRootをアクティブに戻す
	system.Set3DRootActive(true)
end

function set_light_effect_parameter_by_name(cameraName, bgParameters_hardlight_blend, bgParameters_hardlight_color_code, lightForChrarcters_direction_type_name, lightForChrarcters_intensity, screenGradation_intensity)
	system.SetLightEffectParameter(cameraName, bgParameters_hardlight_blend, bgParameters_hardlight_color_code, lightForChrarcters_direction_type_name, lightForChrarcters_intensity, screenGradation_intensity)
end

function set_vignette_effect_by_name(cameraName, centerX, centerY, colorCode, intensity, smoothness, rounded)
	system.SetVignetteEffect(cameraName, centerX, centerY, colorCode, intensity, smoothness, rounded)
end

function disable_vignette_effect_by_name(cameraName)
	system.DisableVignetteEffect(cameraName)
end

function set_scene_light_effect_parameter(bgParameters_hardlight_blend, bgParameters_hardlight_color_code, lightForChrarcters_direction_type_name, lightForChrarcters_intensity, screenGradation_intensity)
	system.SetActiveSceneLightEffectParameter(bgParameters_hardlight_blend, bgParameters_hardlight_color_code, lightForChrarcters_direction_type_name, lightForChrarcters_intensity, screenGradation_intensity)
end

function set_scene_vignette_effect(centerX, centerY, colorCode, intensity, smoothness, rounded)
	system.SetActiveSceneVignetteEffect(centerX, centerY, colorCode, intensity, smoothness, rounded)
end


function PreStartProc()
	start_ui_proc()
end

function PostStartProc()
	end_ui_proc()
end

function ForceExitProc()
	if SelectBox != nil and SelectBox.GetActive() then
		SelectBox.SetActive(false)
	end
	Play_end(true)
end

function GetHumanList()
	return system.GetAdv2Human()
end

function LoadTutorialPopup()
	return system.LoadTutorialPopup()
end

-- TutorialPopupをtutorialIdで初期化します。
function CreateTutorialPopup(tutorialId, tutorialLayer)
	if tutorialLayer == nil then
		tutorialLayer = false
	end
	return system.CreateTutorialPopup(tutorialId, tutorialLayer)
end

-- TutorialPopupを表示します。
function OpenTutorialPopup()
	return system.OpenTutorialPopup()
end

-- TutorialPopupの読み込み、初期化、表示を行う。
--  tutorialId:number = 初期化用ID
function ShowTutorialPopup(tutorialId)
	wait_proccess(LoadTutorialPopup())
	wait_proccess(CreateTutorialPopup(tutorialId))
	wait_proccess(OpenTutorialPopup())
end

function SetLookonRegex(regex)
	return system.SetLookonRegex(regex)
end

function IsMatchLookonRegex(str)
	return system.IsMatchLookonRegex(str)
end

-- エリアを区切る線の表示切替
function SetActiveFreeMapTransitionAreaUnit(view)
	system.SetActiveFreeMapTransitionAreaUnit(view)
end

-- プレイヤーが選択した現代編主人公のstyleId
function get_player_styleId()
   return system.GetPlayerStyleId()
end
