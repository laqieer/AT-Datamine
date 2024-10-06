Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")


-- アセットなどを読み込む
function Load()
	Load_common(true)
	load_scene("content_areascene_110011", "Area110011") -- 教室

	Camera01 = set_camera(-2.74, 1.531, 1.382, 0.0, 0.0, 0.0, 60)
	set_camera_lookat(Camera01, 0.0, 1.01, -5.15)

	setup_Lancelot({0.000, 0.0, -5.440, 0.0})

	Emo_FelUp01		= set_object("effects_emotion", "Ef_C_Emo_FelUp01", false)
	Emo_FelUp02		= set_object("effects_emotion", "Ef_C_Emo_FelUp02", false)
	Emo_FelUp03		= set_object("effects_emotion", "Ef_C_Emo_FelUp03", false)
end

-- アイテムの好みによってエフェクトを変える
--  TargetCharacter = set_charaの返り値
--  effectType = story_communication_item_buff.xlsmの反応タイプをIDで（story_communication_reaction_type.xlsmを参照）
function UseItemEffect(TargetCharacter, effectType)
	if effectType == 0 then
		effect_at_character(TargetCharacter, "Head", Emo_FelUp01, -0.3, 0.15, 0.0)
	elseif effectType == 1 then
		effect_at_character(TargetCharacter, "Head", Emo_FelUp02, -0.3, 0.15, 0.0)
	else
		effect_at_character(TargetCharacter, "Head", Emo_FelUp03, -0.3, 0.15, 0.0)
	end
end

-- コミュ獲得イベントのテスト
--  TargetCharacter = set_charaの返り値
--  ComuRankName = adv_variables.xlsmの種類「コミュランク」の変数名
--  ComuPointName = adv_variables.xlsmの種類「親密度」の変数名
function GetComuTest(TargetCharacter, ComuRankName, ComuPointName)
	message_direct("コミュ獲得イベントのテストを開始します")
	local trustParam = set_communication_acquired(ComuRankName, ComuPointName)

	-- 獲得演出
	open_trust_release(TargetCharacter, trustParam)
end

-- コミュ導入イベントのテスト
--  TargetCharacter = set_charaの返り値
--  ComuRankName = adv_variables.xlsmの種類「コミュランク」の変数名
--  ComuPointName = adv_variables.xlsmの種類「親密度」の変数名
function IntroComuTest(TargetCharacter, ComuRankName, ComuPointName)
	message_direct("導入のコミュイベントのテストを開始します")
	local trustParam = set_communication_intro(ComuRankName, ComuPointName)
end

-- 通常コミュイベントのテスト
--  TargetCharacter = set_charaの返り値
--  ComuRankName = adv_variables.xlsmの種類「コミュランク」の変数名
--  ComuPointName = adv_variables.xlsmの種類「親密度」の変数名
function NormalComuTest(TargetCharacter, ComuRankName, ComuPointName)
	message_direct("通常のコミュイベントのテストを開始します")
	local trustParam = set_communication(ComuRankName, ComuPointName)

	-- アイテム選択
	if trustParam.IsValidItemSelect() then
		message_direct("コミュ効率化アイテムを使用します")
		local select_index = open_item_window()
		trustParam.UpdateNormal()
		if select_index == 1 then
			message_direct("コミュアイテムRを選びました")
			UseItemEffect(TargetCharacter, trustParam.UseItemReactionType)
			message_direct("コミュアイテムRを使用しました")
		elseif select_index == 2 then
			message_direct("コミュアイテムSRを選びました")
			UseItemEffect(TargetCharacter, trustParam.UseItemReactionType)
			message_direct("コミュアイテムSRを使用しました")
		elseif select_index == 3 then
			message_direct("コミュアイテムSSRを選びました")
			UseItemEffect(TargetCharacter, trustParam.UseItemReactionType)
			message_direct("コミュアイテムSSRを使用しました")
		else
			message_direct("アイテムは使用しません")
		end
	else
		auto_select(4) -- アイテムを所持していない場合は選択肢４番目（アイテム未選択）を自動選択
	end

	-- 通常会話
	message_direct("通常の親密度アップ演出を実行します")
	UseItemEffect(TargetCharacter, 0)

	-- 親密度ゲージ演出
	message_direct("最終的な親密度の変化を表示します")
	open_trust_gauge(TargetCharacter, trustParam)

	message_direct("イベントのテストを終了します")
end

-- ランクアップコミュイベントのテスト
--  TargetCharacter = set_charaの返り値
--  ComuRankName = adv_variables.xlsmの種類「コミュランク」の変数名
--  ComuPointName = adv_variables.xlsmの種類「親密度」の変数名
function RankupComuTest(TargetCharacter, ComuRankName, ComuPointName)
	message_direct("ランクアップコミュイベントのテストを開始します")
	local trustParam = set_communication_rankup(ComuRankName, ComuPointName)

	-- ランクアップ演出
	message_direct("ランクアップ演出を実行します")
	open_trust_rank_up(TargetCharacter, trustParam)

	-- 会話による選択肢
	message_direct("初期親密度を決める会話をします")
	open_select_window(Noir, "Normal")
	trustParam.UpdateRankup()
	if is_select(1) then
		message_direct("選択項目１を選びました")
	elseif is_select(2) then
		message_direct("選択項目２を選びました")
	elseif is_select(3) then
		message_direct("選択項目３を選びました")
	else
		message_direct("選択項目４を選びました")
	end
	if trustParam.AddPoint >= 15 then
		effect_at_character(TargetCharacter, "Head", Emo_FelUp03, -0.3, 0.15, 0.0)
	elseif trustParam.AddPoint >= 10 then
		effect_at_character(TargetCharacter, "Head", Emo_FelUp02, -0.3, 0.15, 0.0)
	else
		effect_at_character(TargetCharacter, "Head", Emo_FelUp01, -0.3, 0.15, 0.0)
	end

	-- 親密度ゲージ演出
	message_direct("最終的な親密度の変化を表示します")
	open_trust_gauge(TargetCharacter, trustParam)

	message_direct("イベントのテストを終了します")
end

-- シーケンスの実行
function Play()
	on_camera(Camera01)
	fadein(0)
	Play_start(true)

	open_narration_window()
	message_direct("確定処理のテスト")

--	close_speech_window()

--	NormalComuTest(Lancelot, "コミュランク：ランスロット", "親密度：ランスロット")
	set_int("親密度：ランスロット", 0)	-- ダミー
	set_int("コミュランク：ランスロット", 3)	-- ダミー
	local trustParam = set_communication("コミュランク：ランスロット", "親密度：ランスロット")
--	open_trust_gauge(Lancelot, trustParam)
	open_trust_release(Lancelot, trustParam)
	
	open_narration_window()
	message_direct("終了します")
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
	setup_Lancelot_preload({0.000, 0.0, -5.440, 0.0})
	set_object_preload("effects_emotion", "Ef_C_Emo_FelUp01", false)
	set_object_preload("effects_emotion", "Ef_C_Emo_FelUp02", false)
	set_object_preload("effects_emotion", "Ef_C_Emo_FelUp03", false)
end
