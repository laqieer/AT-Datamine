Include("content_luascript_system", "LuaCommonPack")

-- アセットなどを読み込む
function Load()
	Load_common(true)
	load_scene("content_areascene_110011", "Area110011") -- 教室

	Camera01 = set_camera(-2.74, 1.531, 1.382, 0.0, 0.0, 0.0, 60)
	set_camera_lookat(Camera01, 0.0, 1.01, -5.15)

	Noir		= set_chara("content_chr_1010001_101000102_model", "Chr_1010001_101000102_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack",  1.050, 0.0, -1.610, 180.0, "Sri_Sit_loop_m", "Normal")

	character2D(Noir,		"Noir",			"content_unit_101000102", "101000102_UnitFace", "101000102_UnitCutin", "101000102_UnitThumb", "101000102_UnitImage_Full", "101000102_UnitImage_HiRes")

	Emo_Excl01_1	= set_object("effects_emotion", "Ef_C_Emo_Excl01", false)
	Emo_Excl01_2	= set_object("effects_emotion", "Ef_C_Emo_Excl01", false)
	Emo_StUp01		= set_object("effects_emotion", "Ef_C_Emo_StUP01", false)
	Emo_StUp02		= set_object("effects_emotion", "Ef_C_Emo_StUP02", false)
	Emo_StUp03		= set_object("effects_emotion", "Ef_C_Emo_StUP03", false)

end

-- 施設導入イベントのテスト
--  dummyAttachID = 
function IntroFacilityTest(dummyAttachID, dummyRewardSetLabelID, dummyBonusSetLabelID, isBonusWeather)
	message_direct("施設導入イベントのテストを開始します")
	local facilityParam = set_facility(dummyAttachID, dummyRewardSetLabelID, dummyBonusSetLabelID, isBonusWeather)

	message_direct("なんらかの人間パラメータが上がります")

	if facilityParam.IsWeatherBonus then
		message_direct("天候ボーナスが発生します")
	elseif facilityParam.IsDayBonus then
		message_direct("曜日ボーナスが発生します")
	end

	message_direct("イベントのテストを終了します")
end

-- 施設イベントのテスト
function FacilityTest(dummyAttachID, dummyRewardSetLabelID, dummyBonusSetLabelID, isBonusWeather)
	message_direct("施設イベントのテストを開始します")
	local facilityParam = set_facility(dummyAttachID, dummyRewardSetLabelID, dummyBonusSetLabelID, isBonusWeather)
	local humanParam = set_human_parameter({ "１章：知識", "１章：度胸", "１章：器用さ", "１章：優しさ", "１章：魅力" })

	-- アイテム選択（選択肢の処理でパラメータは処理している）
	if facilityParam.IsValidItemSelect() then
		message_direct("施設効率化アイテムを使用します")
		local select_index = open_item_window()
		if select_index == 1 then
			effect_at_character(Noir, "Head", Emo_Excl01_1, -0.3, 0.15, 0.0)
			message_direct("施設アイテムRを選びました")
		elseif select_index == 2 then
			effect_at_character(Noir, "Head", Emo_Excl01_1, -0.3, 0.15, 0.0)
			message_direct("施設アイテムSRを選びました")
		elseif select_index == 3 then
			effect_at_character(Noir, "Head", Emo_Excl01_1, -0.3, 0.15, 0.0)
			message_direct("施設アイテムSSRを選びました")
		else
			message_direct("アイテムは使用しません")
		end
	else
		auto_select(4) -- アイテムを所持していない場合は選択肢４番目（アイテム未選択）を自動選択
	end

	-- ボーナス演出
	if facilityParam.IsWeatherBonus then
		effect_at_character(Noir, "Head", Emo_Excl01_2, -0.3, 0.15, 0.0)
		message_direct("天候ボーナスが発生しました")
	elseif facilityParam.IsDayBonus then
		effect_at_character(Noir, "Head", Emo_Excl01_2, -0.3, 0.15, 0.0)
		message_direct("曜日ボーナスが発生しました")
	end

	-- パラメータ取得演出
	facilityParam.Update()	-- ここで報酬をクライアント上に反映する
	humanParam.Update() -- ここまでの人間パラメータの変化を演出用パラメータに変換する
	local totalIncrease = humanParam.GetTotalIncrease()
	if totalIncrease >= 10 then
		effect_at_character(Noir, "Head", Emo_StUp03, -0.3, 0.15, 0.0)
	elseif totalIncrease >= 5 then
		effect_at_character(Noir, "Head", Emo_StUp02, -0.3, 0.15, 0.0)
	else
		effect_at_character(Noir, "Head", Emo_StUp01, -0.3, 0.15, 0.0)
	end
	message_direct("パラメーターが全部で" .. totalIncrease .. "上昇しました")

	-- リザルト演出
	open_parameter_up(humanParam)

	message_direct("イベントのテストを終了します")
end

function HumanParameteTest()
	message_direct("人間パラメータを直接上昇させるテストを開始します")
	local humanParam = set_human_parameter({ "１章：知識", "１章：度胸", "１章：器用さ", "１章：優しさ", "１章：魅力" })
	-- 人間パラメータを選択肢の処理で上昇
	open_select_window(Noir, "Normal")
	-- パラメータ取得演出
	humanParam.Update()
	local totalIncrease = humanParam.GetTotalIncrease()
	if totalIncrease >= 300 then
		effect_at_character(Noir, "Head", Emo_StUp03, -0.3, 0.15, 0.0)
	elseif totalIncrease >= 100 then
		effect_at_character(Noir, "Head", Emo_StUp02, -0.3, 0.15, 0.0)
	else
		effect_at_character(Noir, "Head", Emo_StUp01, -0.3, 0.15, 0.0)
	end

	-- リザルト演出
	open_parameter_up(humanParam)

	message_direct("イベントのテストを終了します")
end

-- シーケンスの実行
function Play()
	on_camera(Camera01)
	fadein(0)
	Play_start(true)

	-- 施設の選択
	open_narration_window()
	message_direct("イベントの種類を選択します")
	open_select_window(Noir, "Normal")
	if is_select(1) then
		message_direct("サンプルの種類を選択します")
		open_select_window(Noir, "Normal")
		if is_select(1) then
			IntroFacilityTest(1, 1, 2, true)
		elseif is_select(2) then
			IntroFacilityTest(2, 3)
		else
			IntroFacilityTest(3, 4, 5, false)
		end
	elseif is_select(2) then
		message_direct("サンプルの種類を選択します")
		open_select_window(Noir, "Normal")
		if is_select(1) then
			FacilityTest(1, 1, 2, true)
		elseif is_select(2) then
			FacilityTest(2, 3)
		else
			FacilityTest(3, 4, 5, false)
		end
	else
		HumanParameteTest()
	end
	close_speech_window()

	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_scene_preload("content_areascene_110011", "Area110011")
	set_chara_preload("content_chr_1010001_101000102_model", "Chr_1010001_101000102_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack",  1.050, 0.0, -1.610, 180.0, "Sri_Sit_loop_m", "Normal")
	set_object_preload("effects_emotion", "Ef_C_Emo_Excl01", false)
	set_object_preload("effects_emotion", "Ef_C_Emo_Excl01", false)
	set_object_preload("effects_emotion", "Ef_C_Emo_StUP01", false)
	set_object_preload("effects_emotion", "Ef_C_Emo_StUP02", false)
	set_object_preload("effects_emotion", "Ef_C_Emo_StUP03", false)
end
