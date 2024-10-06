
Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_system","CharacterFunctions")
Include("content_luascript_common", "DemoCommonPack")
Include("content_luascript_common", "SoundCommonPack")


-- 全体初期化
function InitializeLoad()
	demo_setup()
    InitializeADV()
    depthOfFieldController = load_depthoffield_effect()
end

function InitializeLoad_Preload()
	system.PreLoadRequest("content_adv_postprocess_depthoffield")
end

-- 全体初期化 能動会話用
function InitializeLoadActive()
	Load_common(false)
    InitializeADV()
end

-- 共通部分
function InitializeADV()
	lastTalkControllerId = nil
	lastTalkFrameType = ""
    lastNameTag = ""
	-- どちら側に表示してたかを記録しておくテーブル
	dirTable = {}

    -- モーション予約テーブル
    reserveMotionTable = {}
    actorTable = {}
    actorTagTable = {}
end

-- 被写界深度のaperture設定
function SetDepthOfFieldAperture(aperture)
    local volumeTypeFullName = "UnityEngine.Rendering.Universal.DepthOfField"
    local fieldName = "aperture";
    set_postprocess_float_paramter(depthOfFieldController, volumeTypeFullName, fieldName, aperture);
end

-- シーンの初期化
-- sceneId 110011などの文字列
function InitializeScene(sceneId)
	load_scene("content_areascene_"..sceneId,"Area"..sceneId)
end

-- キャラ読み込み
-- characterId 101009 = ノワールなどのIDの文字列
-- styleid 000 文字列
-- labelChara Noir 文字列
-- 一応受け渡しているがfacialIdは使ってない
-- defaultmotion デフォルトのアニメーショントリガ名
function InitializeCharacter(characterId, styleId, labelChara, position, facialId, animationControllerId, defaultmotion)
	local styledCharaId = characterId..styleId
	local controllerId = set_chara_animationController("content_chr_"..characterId.."_"..styledCharaId.."_model", styledCharaId.."_Model", "content_motion3d_advarea_common_adv_templatecontroller", animationControllerId, "content_animationpack__common", "FacialPack", position, "Normal")

	character2DFull(controllerId, labelChara, tonumber(styledCharaId))

	if defaultmotion ~= nil then
		controllerId.SetDefaultTriggerName(defaultmotion)
	end
	controllerId.CheckStanding(animationControllerId)

--	add_eye_control(controllerId, -0.05,-0.055,0.0, -1.0,0.04,0.0, -15.0,15.0, -45.0, 45.0, 2.0, 2.0, 1.0, 6.0)
	dirTable[controllerId] = ""
	return controllerId
end

function InitializeCharacter_Preload(characterId, styleId, labelChara, position, facialId, animationControllerId, defaultmotion)
	local styledCharaId = characterId..styleId
	set_chara_animationController_Preload("content_chr_"..characterId.."_"..styledCharaId.."_model", styledCharaId.."_Model", "content_motion3d_advarea_common_adv_templatecontroller", animationControllerId, "content_animationpack__common", "FacialPack", position, "Sri_Std_loop_m", "Normal")
	character2DFull_Preload(nil, labelChara, tonumber(styledCharaId))
end

-- 顔だけの人用キャラ読み込み
-- characterId 101009 = ノワールなどのIDの文字列
-- styleid 000 文字列
-- labelChara Noir 文字列
function InitializeCharacter_2DOnly(characterId, styleId, labelChara)
	local styledCharaId = characterId..styleId
	local controllerId = set_chara_unknown()
	character2DFull(controllerId, labelChara, tonumber(styledCharaId))
	dirTable[controllerId] = ""
	change_face(controllerId, "Normal")
	return controllerId
end

function InitializeCharacter_2DOnly_Preload(characterId, styleId, labelChara)
	local styledCharaId = characterId..styleId
	character2DFull_Preload(nil, labelChara, tonumber(styledCharaId))
end

-- 顔すらない人用キャラ読み込み
function InitializeCharacter_TextOnly()
	local controllerId = set_chara_unknown()
	dirTable[controllerId] = ""
	return controllerId
end


-- 3dモデルと2d顔読み込むところだけ
function InitializeCharacter_3D(characterId, styleId, labelChara, facialAssetbundleName, facialFileName, actorTag)
	local styledCharaId = characterId..styleId
	local objectAssetbundleName = "content_chr_"..characterId.."_"..styledCharaId.."_model"
	local objectFileName = styledCharaId.."_Model"

	local controllerId = system.CreateHuman("Chara")
	controllerId.LoadModel(objectAssetbundleName, objectFileName, nil, nil, facialAssetbundleName, facialFileName)
	while controllerId.IsProccessing() do
		coroutine.yield()
	end

	character2DFull(controllerId, labelChara, tonumber(styledCharaId))

	-- 初期ポーズのために0にする
	controllerId.SetAnimationSystemChangeTime(0, 0)
	controllerId.PlayFacial("Normal", 0.0, 1.0, false)

	dirTable[controllerId] = ""
	actorTable[labelChara] = controllerId
	actorTagTable[actorTag] = controllerId
	return controllerId
end

function InitializeCharacter_3D_Preload(characterId, styleId, labelChara, facialAssetbundleName, facialFileName)
	local styledCharaId = characterId..styleId
	local objectAssetbundleName = "content_chr_"..characterId.."_"..styledCharaId.."_model"
	system.PreLoadRequest(objectAssetbundleName)
	system.PreLoadRequest(facialAssetbundleName)
	character2DFull_Preload(nil, labelChara, tonumber(styledCharaId))
end

-- 3dモデルだけ
function InitializeCharacter_3D_not2d(characterId, styleId, labelChara, facialAssetbundleName, facialFileName, actorTag)
	local styledCharaId = characterId..styleId
	local objectAssetbundleName = "content_chr_"..characterId.."_"..styledCharaId.."_model"
	local objectFileName = styledCharaId.."_Model"

	local controllerId = system.CreateHuman("Chara")
	controllerId.LoadModel(objectAssetbundleName, objectFileName, nil, nil, facialAssetbundleName, facialFileName)
	while controllerId.IsProccessing() do
		coroutine.yield()
	end

	controllerId.SetAnimationSystemChangeTime(0.5, 0.25)
	controllerId.PlayFacial("Normal", 0.0, 1.0, false)

	dirTable[controllerId] = ""
	actorTable[labelChara] = controllerId
	actorTagTable[actorTag] = controllerId
	return controllerId
end

function InitializeCharacter_3D_not2d_Preload(characterId, styleId, labelChara, facialAssetbundleName, facialFileName)
	local styledCharaId = characterId..styleId
	local objectAssetbundleName = "content_chr_"..characterId.."_"..styledCharaId.."_model"
	system.PreLoadRequest(objectAssetbundleName)
	system.PreLoadRequest(facialAssetbundleName)
end


-- キャラ初期化 能動会話用
-- objectName 参照用オブジェクトネーム
-- labelChara リソース用文字列
-- styledCharaId スタイルID
-- animationAssetbundleName アニメーションアセットバンドル名
-- animationFileName アニメーションファイル名
-- animationName アニメーション名
function InitializeActiveCharacter(objectName, labelChara, styledCharaId, animationAssetbundleName, animationFileName, animationName)
	local facialAssetbundleName = "content_animationpack__common"
	local facialFileName = "FacialPack"
	local character = system.CreateHuman("Chara")

	if objectName == "Player" then 
		local weather = get_weather()
		if weather == 2 or weather == 3 then 
			if system.IsIndoor() == false then 
				animationName = "Player_Idl_umb_m"
			end
		end
	end

	character.LinkModel(objectName, animationAssetbundleName, animationFileName, facialAssetbundleName, facialFileName)
	while character.IsProccessing() do
		coroutine.yield()
	end

	character2DFull(character, labelChara, tonumber(styledCharaId))

	character.SetAnimationSystemChangeTime(0.5, 0.25)
	character.PlayAnimation(animationName, 0.0, 1.0, true)
	character.PlayFacial("Normal", 0.0, 1.0, false)

	return character
end


-- キャラ初期化 能動会話用 NPC用
-- objectName 参照用オブジェクトネーム
-- animationAssetbundleName アニメーションアセットバンドル名
-- animationFileName アニメーションファイル名
-- animationName アニメーション名
function InitializeActiveNpc(objectName, animationAssetbundleName, animationFileName, animationName)
    local facialAssetbundleName = "content_animationpack__common"
    local facialFileName = "FacialPack"

    actor = get_chara(objectName, animationAssetbundleName, animationFileName, facialAssetbundleName, facialFileName)
    motion(actor, animationName, 0, 1.0, true)
    return actor
end

-- プレイヤーキャラ用
function InitializePlayerCharacter(actorTag)
	local characterId = system.GetPlayerModelInfo("CharacterId")
	local styleId = system.GetPlayerModelInfo("StyleId")
	local labelChara = system.GetPlayerModelInfo("LabelChara")
	local facialAssetbundleName = system.GetPlayerModelInfo("FacialPath")
	local facialFileName = system.GetPlayerModelInfo("FacialName")

	return InitializeCharacter_3D(characterId, styleId, labelChara, facialAssetbundleName, facialFileName, actorTag)
end

function InitializeActiveCharacter_Preload(objectName, labelChara, styledCharaId, animationAssetbundleName, animationFileName, animationName)
	local facialAssetbundleName = "content_animationpack__common"
	system.PreLoadRequest(animationAssetbundleName)
	system.PreLoadRequest(facialAssetbundleName)
	character2DFull_Preload(nil, labelChara, tonumber(styledCharaId))
end

-- Action　モーション指定
-- controllerId コントローラID
-- motion 指定モーション
function PlayActionDirect(controllerId, motion)
  	controllerId.DecrementSkipDefautTrigger()
    controllerId.SetAnimationTrigger(motion)
end

-- モーション再生予約
-- controllerId コントローラID
-- motion 指定モーション
function PlayAction(controllerId, motion)
    reserveMotionTable[controllerId] = motion
end

-- 予約されたモーションを再生する
function PlayReservedPlayAction()
    -- 予約分は全部再生する
    for controllerId,motion in pairs(reserveMotionTable) do
        if motion ~= nil then
            PlayActionDirect(controllerId,motion)
        end
    end

    -- 全部消す
    for controllerId,motion in pairs(reserveMotionTable) do
        reserveMotionTable[controllerId] = nil
    end
end

-- デフォルトモーションに戻るのをスキップする
function SkipDefaultMotion(actor)
	actor.SetSkipDefautTrigger(2)
end

-- Effect エフェクト再生
-- controllerId コントローラId
-- effectId エフェクトid
function PlayEffect(controllerId, effectId)
end

-- SE SE再生
-- controllerId コントローラId
-- seId SEid
function PlaySE(seId)
	system.PlaySE(seId)
end

-- ウインドウを開く
-- talkerNameTag CHRNAME_NOIRなど文字列　キャラ名表示用のタグ
-- controllerId 話者のコントローラid
-- frametype 枠のタイプ
-- dir 話者の顔位置
function OpenTalkWindow(talkerNameTag, controllerId, frameType, dir)

	local controllIdL
	local controllIdR
	if dir == "L" then
		controllIdL = controllerId
		controllIdR = nil
	end
	if dir == "R" then
		controllIdL = nil
		controllIdR = controllerId
	end
	if dir == "N" then
		controllIdL = nil
		controllIdR = nil
	end

	if frameType == "speech" then
		if controllerId.FaceImageTag ~= "" and dir ~= "N" then
			open_speech_window(talkerNameTag, controllIdL, controllIdR)
		else
			open_speech_window_only3d(talkerNameTag, controllerId)
		end
	end

	if frameType == "mind" then
		open_mind_window(talkerNameTag, controllIdL, controllIdR)
	end

	if frameType == "mind_talk" then
		open_mind_talk_window(talkerNameTag, controllIdL, controllIdR)
	end

	if frameType == "narration" then
		open_narration_window()
	end

	if frameType == "simple" then
		if controllerId.FaceImageTag ~= "" and dir ~= "N" then
			open_simple_window(talkerNameTag)
		else
			open_simple_window_only3d(talkerNameTag, controllerId)
		end
	end

	lastTalkFrameType = frameType
	dirTable[controllerId] = dir
end


-- 開いていたウインドウを閉じる
function CloseTalkWindow()
	if lastTalkFrameType == "speech" then
		close_speech_window()
	end
	if lastTalkFrameType == "mind" then
		close_mind_window()
	end
	if lastTalkFrameType == "mind_talk" then
		close_mind_talk_window()
	end
	if lastTalkFrameType == "narration" then
		close_narration_window()
	end
	if lastTalkFrameType == "simple" then
		close_simple_window()
	end

	lastTalkFrameType = ""
end

-- ウインドウを閉じる必要があるか判定
-- 次のコントローラid
-- 次の枠
function CheckIfNeedClose(controllerId, frameType, dir)
	-- 初回は閉じない
	if lastTalkControllerId == nil then
		if lastTalkFrameType == "" then
			return false
		end
	end

	-- 違う人がしゃべるときは閉じる
	if lastTalkControllerId ~= controllerId then
		return true
	end

	-- 枠が変わるときは閉じる
	if lastTalkFrameType ~= frameType then
		return true
	end

	-- 表示位置が変わるときは閉じる
	if dirTable[controllerId] ~= "" then
		if dirTable[controllerId] ~= dir then
			return true
		end
	end
	return false
end

-- ウインドウを開く必要があるか判定
-- controllerId 話者のコントローラid
-- frameType 枠のタイプ
function CheckIfNeedOpen(controllerId, frameType, dir)
	-- 違う人がしゃべるから開きなおし
	if lastTalkControllerId ~= controllerId then
		return true
	end

	-- フレームが変わるから開きなおし
	if lastTalkFrameType ~= frameType then
		return true
	end

	-- 表示位置が変わるから開きなおし
	if dirTable[controllerId] ~= "" then
		if dirTable[controllerId] ~= dir then
			return true
		end
	end

	return false
end

-- ウインドを開いて会話表示
-- talkerNameTag 話者の名前タグ CHRNAME_NOIRなど文字列
-- frameType 枠タイプ
-- dir 話者の顔位置
-- textId テキストのid
function Talk(controllerId, talkerNameTag, frameType, dir, textId)
	-- 必要があれば前回開いたウインドウを閉じる
	if CheckIfNeedClose(controllerId, frameType, dir) == true then
		CloseTalkWindow()
	end

	if manager ~= nil then
		-- カメラワークのための通知
		manager.CloseupUpExclusiveCamera(controllerId)
	end

	-- 必要があればウインドウを開く
	if CheckIfNeedOpen(controllerId, frameType, dir) == true then
		OpenTalkWindow(talkerNameTag, controllerId, frameType, dir)
    else
        -- ウインドウを開いたまま名前を変更する
        if lastTalkControllerId == controllerId and lastNameTag ~= talkerNameTag then 
            local onSimple = lastTalkFrameType == "simple"
            local validTalker = (talkerNameTag ~= nil)
            set_name_tag(talkerNameTag, onSimple, validTalker)     
	    end
	end

	lastTalkControllerId = controllerId
    lastNameTag = talkerNameTag

    PlayReservedPlayAction()

	-- テスト用
	--message_direct(textId)
	-- 本番用
    message(textId)

	-- しゃべった人のモーションを戻す
	animator_default_motion_if_need(lastTalkControllerId)
end

function Talk_Direct(controllerId, talkerNameTag, frameType, dir, textId)
	-- 必要があれば前回開いたウインドウを閉じる
	if CheckIfNeedClose(controllerId, frameType, dir) == true then
		CloseTalkWindow()
	end
	-- 必要があればウインドウを開く
	if CheckIfNeedOpen(controllerId, frameType, dir) == true then
		OpenTalkWindow(talkerNameTag, controllerId, frameType, dir)
	end
	-- カメラワークのための通知
	manager.CloseupUpExclusiveCamera(controllerId)
	lastTalkControllerId = controllerId

	-- テスト用
	message_direct(textId)

	-- しゃべった人のモーションを戻す
	animator_default_motion_if_need(lastTalkControllerId)
end

-- 会話終了処理
function EndTalk()
	if UITextBox_bgHideStatus ~= nil and UITextBox_bgHideStatus == Anime_Show then
		CloseTalkWindow()
	end
end

-- Play関数開始時の処理 ADV小用
function StartPlay()
	on_camera(RndCamera001)
    demo_start()
end

-- Play関数開始時の処理 能動会話
function StartPlayActive(useFade)
	Play_start(useFade)	-- footerを開く
end

-- Play関数終了時の処理
function EndPlay()
	EndTalk()
	demo_end()
end

-- Play関数終了時の処理 能動会話
function EndPlayActive(useFade)
	EndTalk()
	Play_end(useFade)
end

-- カメラを初期化して、アニメを割り当てる
-- assetBundleName アセットバンドルの名前
-- animName　座標を決めるのにアニメで指定している
-- actor 担当キャラにより、アクティブになるタイミングが決定する
function InitializeCharaCamera(assetBundleName, animName, actor)
	local camera
	camera = create_camera()
	if animName ~= nil then
		camera.SetName(animName)
	end
	load_exclusive_camera(camera, assetBundleName, animName, actor)
	manager.RegisterExclusiveCamera(camera, actor)
	return camera
end

-- キャラカメラのリセット
function ResetCharaCamera()
	reset_camera_list() -- TODO: InitializeTemplateが呼ばれるようになったら消す
	manager.ResetExclusiveCamera()
end

-- ランダム用のカメラを割り当てる　一定時間後にランダムカメラに切り替わる
-- assetBundleName アセットバンドルの名前
-- animName 演出アニメの名前
function InitializeRandomCamera(assetBundleName, animName)
	if animName ~= nil then
		local camera
		camera = create_camera()
		camera.SetName(animName)
		load_camera_anim(camera, assetBundleName, animName)
		manager.RegisterRandomCamera(camera)
		return camera
	end
end

-- ランダムカメラのリセット
function ResetRandomCamera()
	manager.ResetRandomCamera()
end

-- TODO: template関数の頭で呼ぶようにする
function InitializeTemplate()
	reset_camera_list()
	ResetCharaCamera()
	ResetRandomCamera()
end

-- 背景の用意置き場
function InitializeBG(areaId,templateNo)
	-- モブの読み込み
	if manager ~= nil then
		-- 指定があったらそっちを優先
		if MobsNo ~= nil then
			manager.SetMobsNo(MobsNo)
			MobsNo = nil
		end

		local signal = manager.LoadMobs(areaId,templateNo)
        while signal.IsProccessing() do
                coroutine.yield()
        end
	end
end

function InitializeDuelBG(templateNo)
	-- モブの読み込み
	if manager ~= nil then
		-- 指定があったらそっちを優先
		if MobsNo ~= nil then
			manager.SetMobsNo(MobsNo)
			MobsNo = nil
		end

		local signal = manager.LoadMobsDuel(templateNo)
        while signal.IsProccessing() do
                coroutine.yield()
        end
	end
end


-- カメラ制御などを行うクラスを生成する用
function CreateAdvSmallManager()
	local manager
	manager = system.CreateAdvSmallManager()
	if MobsNo ~= nil then
		manager.SetMobsNo(MobsNo)
		MobsNo = nil
	end
	return manager
end

-- モデルとコントローラを読み込む
-- 顔は指定してるけど、キャラIDにもとづいて　読み込まれるのでここでは使用してない
-- objectAssetbundleName モデルのアセットバンドル名
-- objectFileName　モデルファイル名
-- animationAssetbundleName　アニメーションコントローラーのアセットバンドル名
-- animationFileName　アニメーションコントローラーのファイル名
function set_chara_animationController(objectAssetbundleName, objectFileName, animationAssetbundleName, animationFileName, facialAssetbundleName, facialFileName, position, facialTag)
	local character = system.CreateHuman("Chara")
	character.LoadModel(objectAssetbundleName, objectFileName, nil, nil, facialAssetbundleName, facialFileName)
	while character.IsProccessing() do
		coroutine.yield()
	end
	character.LoadAnimator(animationAssetbundleName, animationFileName)
	while character.IsProccessing() do
		coroutine.yield()
	end

	character.InitializeTransform(position[1], position[2], position[3], 0.0, position[4], 0.0, 1.0, 1.0, 1.0)
	character.SetAnimationSystemChangeTime(0.0, 0.0)
	character.PlayFacial(facialTag, 0.0, 1.0, false)

	return character
end

function set_chara_animationController_Preload(objectAssetbundleName, objectFileName, animationAssetbundleName, animationFileName, facialAssetbundleName, facialFileName, posX, posY, posZ, angY, animationTag, facialTag)
	system.PreLoadRequest(objectAssetbundleName)
	system.PreLoadRequest(facialAssetbundleName)
	system.PreLoadRequest(animationAssetbundleName)
end

-- コントローラーを読み込んで差し替える
-- actor 対象オブジェクト
-- path パス
-- animationControllerName コントローラー名
-- defaultmotion デフォルトモーション
function set_animationcontroller_path(actor, path, animationControllerName, defaultmotion)
	-- 同じコントローラーを読み込まないように
	if actor.CheckControllerName(animationControllerName) == false then
		actor.LoadAnimator(path, animationControllerName)
		while actor.IsProccessing() do
			coroutine.yield()
		end
		actor.SetDefaultTriggerName(defaultmotion)
		actor.CheckStanding(animationControllerName)
		PlayActionDirect(actor,defaultmotion)
	end
end

-- コントローラーを読み込んで差し替える
-- actor 対象オブジェクト
-- animationControllerName コントローラー名
-- defaultmotion デフォルトモーション
function set_animationcontroller(actor, animationControllerName, defaultmotion)
	set_animationcontroller_path(actor, "content_motion3d_advarea_common_adv_templatecontroller", animationControllerName, defaultmotion)
end

-- 途中でモブを消したいときはfalse
function SwitchMob(active)
	if manager ~= nil then
		manager.SwitchMob(active)
	end
end

-- カメラの身長差オフセットをしない
function DontCameraOffset(actor)
	manager.DontCameraOffset(actor)
end

-- 現代編でプレイヤーが選択したキャラのスタイルID
function GetPlayerStyleId()
	return system.GetPlayerStyleId()
end

-- 非表示モデルを表示に
function Appear(actor)
	actor.SetActive(true)
end

-- 表示モデルを非表示に
function Hide(actor)
	actor.SetActive(false)
end

-- カメラの自動変更をしない
function DontChangeRandomCamera(flag)
	if flag == false then
		RestartRandomCamera()
	else
		manager.DontChangeRandomCamera(flag)
	end
end

-- ランダムカメラ再開要求
function RestartRandomCamera()
	manager.RestartRandomCamera()
end

-- ランダムカメラが駆動中の時にtrueが返る
function IsRndCameraActive()　
	return manager.IsRndCameraActive()
end

-- 同じカメラを連続して使うときに位置がズレるの防ぐ
function SkipOffsetCamera(camera)
	camera.SetSkipOffset()
end

-- 位置と専用カメラを登録しなおす
-- 誰かいた場所に別の人を立たせる用
function SetPositionAndCamera(actor,position,camera)
	actor.InitializeTransform(position[1], position[2], position[3], 0.0, position[4], 0.0, 1.0, 1.0, 1.0)
	manager.RegisterExclusiveCamera(camera, actor)
end

-- テンプレデータをモデルに適用する
-- labelモデル読み込んだ時のラベル
-- rot 向き
-- position 位置
-- controllerPath アニメーションコントローラーのパス
-- controllerName アニメーションコントローラーの名前
-- defaultmotion デフォルトモーション名
-- cameraassetbundlename カメラアニメーションのパス
-- cameraAnimName　カメラアニメーションの名前
function SetTemplate(actorTag, rot, position, controllerPath, controllerName, defaultMotion, cameraAssetBundleName, cameraAnimName)
	-- 読み込み済のモデルを取得
	local actor = actorTagTable[actorTag]

	-- モデルがない人は必要がない
	if controllerName == "" then 
		return nil 
	end

	-- 位置設定
	set_pos(actor,position)

	-- 向き設定
	if rot == nil then
		rot = position[4]
	end

	set_rot(actor, {0,rot,0})

	-- アニメーションコントローラー設定
	set_animationcontroller_path(actor, controllerPath, controllerName, defaultMotion)

	-- カメラがないケース
	if cameraAssetBundleName == nil or cameraAnimName == nil then 
		return nil
	end

	-- カメラ設定
	return 	InitializeCharaCamera(cameraAssetBundleName, cameraAnimName, actor)
end

-- プレイヤーキャラ用
function SetPlayerTemplate(actorTag, rot, position, cameraAssetBundleName, cameraAnimName)
	local controllerPath  = system.GetPlayerModelInfo("AnimationControllerPath")
	local controllerName  = system.GetPlayerModelInfo("AnimationControllerName")
	local defaultMotion = system.GetPlayerModelInfo("DefaultMotion")

	return SetTemplate(actorTag, rot, position, controllerPath, controllerName, defaultMotion, cameraAssetBundleName, cameraAnimName)
end

-- 入場　量産フォームから EntryWalk(キャラ名,番号)で使用
-- actor キャラ
-- exCamera キャラ専用カメラ
-- eeTable カメラ、位置情報が入っているテーブル テンプレに含まれている
-- assetBundleName カメラのアニメが含まれているアセットバンドル
-- assetName カメラのアニメの名前
function EntryWalk(actor, exCamera, eeTable, assetBundleName, assetName)
    local eeCamera = eeTable[1]
    local startPos = eeTable[2] 
    local goalPos = eeTable[3]  
    local CameraTime1 = eeTable[4]
    local CameraTime2 = eeTable[5]
    local MoveTime = eeTable[6]
    local TurnTime = eeTable[7]
	
	local active = is_active(actor)
	
	on_active(actor)
	set_pos(actor,startPos)
	turn_lookat_position(actor,goalPos[1],goalPos[2],goalPos[3],0) --向きを行先に合わせる
	
	-- 俯瞰
	on_camera(RndCamera090)
	
	if active == false then
	    wait_time(0.03)	--ポーズが決まるのを待つ
	end
	
	exCamera.InitializeOffset()
	eeCamera.CopyOffset(exCamera)
	load_exclusive_camera(eeCamera ,assetBundleName, assetName, actor)

    --キャラを移動させる
    PlayActionDirect(actor,"to Wlk")
    slidemove(actor, goalPos[1],goalPos[2],goalPos[3] ,MoveTime)


    wait_time(CameraTime1)

    on_camera(eeCamera)

	while eeCamera.IsPositionAnimationPlayng() do
		coroutine.yield()
	end

	exCamera.SetSkipOffset()

    if manager ~= nil then
        DontChangeRandomCamera(false)
        manager.CloseupUpExclusiveCamera(actor) -- キャラカメラに変更
    end

    PlayActionDirect(actor,"to Std_Loop")       --　モーションを基本立ちに設定して
    turn_chara(actor, goalPos[4],TurnTime)          --　回転させる
    wait_time(TurnTime)
end
