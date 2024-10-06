Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")

Include("content_luascript_common", "CO_LOCATION_h")

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)

	local commu = system.GetCommu() -- 実行中コミュ
	local commuChara = commu.GetCharacter()
	local characterId = commuChara.CharacterID
	local strStyleId = tostring(commuChara.StyleID)
	local charaId = string.sub(strStyleId,1,6)
	local styleId = string.sub(strStyleId,7,9)

	Actor001 = InitializeCharacter("101009","002","101009002",CharaPos005,"101009002","Com_m_SitController","to Sit01_Loop")
	Actor002 = InitializeCharacter(charaId, styleId, characters_sit[characterId].labelChara, CharaPos006, characters_sit[characterId].facialId, characters_sit[characterId].animationController,"to Sit01_Loop")

	InitializeCharaCamera(CameraAssetBundleName,CameraPos005,Actor001)
	InitializeCharaCamera(CameraAssetBundleName,CameraPos006,Actor002)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()

	-- 不要な食器の削除
	setup_template_moveobj_110122_01(3,false)
	setup_template_moveobj_110122_01(4,false)
	setup_template_moveobj_110122_01(7,false)
	setup_template_moveobj_110122_01(8,false)

end

function Play()
	StartPlay()

	local commu = system.GetCommu() -- 実行中コミュ
	local commuChara = commu.GetCharacter()
	local location = commu.GetLocation() -- 選択済みのロケーション

	-- 汎用演出
	open_narration_window()
		--message_replace_direct("<%1>と<%2>で楽しんだ", commuChara.CharaName, location.TextValue)
		message_replace("CO_LOCATION_000001", commuChara.CharaName, location.TextValue)
	close_narration_window()

	kizuna_gaugeup(Actor002,commuChara.CharaName)

	EndPlay()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110122)
	local commu = system.GetCommu() -- 実行中コミュ
	local commuChara = commu.GetCharacter()
	local characterId = commuChara.CharacterID
	local strStyleId = tostring(commuChara.StyleID)
	local charaId = string.sub(strStyleId,1,6)
	local styleId = string.sub(strStyleId,7,9)
	InitializeCharacter_Preload("101009","002","101009002",CharaPos005,"101009002","Com_m_SitController","to Sit01_Loop")
	InitializeCharacter_Preload(charaId, styleId, characters_sit[characterId].labelChara, CharaPos006, characters_sit[characterId].facialId, characters_sit[characterId].animationController,"to Sit01_Loop")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
end
