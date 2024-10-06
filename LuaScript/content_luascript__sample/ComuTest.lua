Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")

-- アセットなどを読み込む
function Load()
	Load_common(true)
	load_scene("content_areascene_110011", "Area110011") -- 教室

	Camera01 = set_camera(-2.74, 1.531, 1.382, 0.0, 0.0, 0.0, 60)
	set_camera_lookat(Camera01, 0.0, 1.01, -5.15)
	
	setup_Lancelot({0.000, 0.0, -5.440, 0.0})
	
	setup_Noir({1.050, 0.0, -1.610, 180.0})
	motion(Noir, "Sri_Sit_loop_m", 0.0, 1.0, true)
	
	setup_Guinevere({-1.430, 0.0,  0.050, 180.0})
	motion(Guinevere, "Nbl_Sit_loop_f", 0.0, 1.0, true)
	
	MobGirl01	= set_chara("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack",  2.466, 0.0, -1.920, 180.0, "Mob_Sit_loop_f", "Normal")
	MobGirl02	= set_chara("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack", -1.430, 0.0, -1.930, 180.0, "Mob_Sit_loop_f", "Normal")
	MobGirl03	= set_chara("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack", -2.850, 0.0, -1.890, 180.0, "Mob_Sit_loop_f", "Normal")

	-- 目のコントロールを作る
	local function CommonEyeControl(character)
		add_eye_control(character, -0.05,-0.055,0.0, -1.0,0.04,0.0, -15.0,15.0, -45.0, 45.0, 2.0, 2.0, 1.0, 6.0)
		set_eye_hilight(character, 1.0, 100.0)
	end
	
	CommonEyeControl(MobGirl01)
	CommonEyeControl(MobGirl02)
	CommonEyeControl(MobGirl03)
	
	set_eye_scale(MobGirl01, 1.0, 1.0)
	set_eye_scale(MobGirl02, 0.5, 1.0)
	set_eye_scale(MobGirl03, 1.0, 0.5)
	
	-- 瞳の大きさや目の角度もしくは注視対象を設定する
	set_eye_lookat(MobGirl01, Lancelot, "J_Head")
	set_eye_angle(MobGirl02, 10.0, 20.0)
	set_eye_lookat(MobGirl03, Lancelot, "J_Head")
	
	Emo_FelUp01		= set_object("effects_emotion", "Ef_C_Emo_FelUp01", false)
	Emo_FelUp02		= set_object("effects_emotion", "Ef_C_Emo_FelUp02", false)
	Emo_FelUp03		= set_object("effects_emotion", "Ef_C_Emo_FelUp03", false)

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

	-- 通常コミュのコミュ効率化アイテム選択あるか？
	if trustParam.IsValidItemSelect() then
		
		-- コミュ効率化アイテム選択
		normal_commu_item_menu(trustParam)
		trustParam.UpdateNormalItem() -- コミュ効率化アイテム更新の適用
		if trustParam.UseItemReactionType == 1 then
			-- 好みでない
			debug_print("好みでない")
			open_trust_gauge(TargetCharacter, trustParam)
		elseif trustParam.UseItemReactionType == 2 then
			-- 好み
			debug_print("好み")
			open_trust_gauge(TargetCharacter, trustParam)
		else
			-- 選択しなかった
			debug_print("選択しなかった")
		end
	end
	
	trustParam.UpdateNormal() -- 通常コミュの更新の適用

	-- 通常会話
	message_direct("通常の親密度アップ演出を実行します")

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
	trustParam.UpdateRankup()
	-- ランクアップ演出
	message_direct("ランクアップ演出を実行します")
	open_trust_rank_up(TargetCharacter, trustParam)

	-- 会話による選択肢
	message_direct("初期親密度を決める会話をします")
	open_select_window(Noir, "Normal")
	
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
	
	debug_print("lauguage=" .. language())
	
	-- コミュの対象を決める
	open_narration_window()
	message_direct("コミュの対象を選択します")
	open_select_window(Noir, "Normal")
	if is_select(1) then
		-- ギネヴィアがターゲットでイベント内容を決める
		message_direct("イベントの種類を選択します")
		open_select_window(Noir, "Normal")
		if is_select(1) then
			-- 獲得イベント
			set_int("コミュランク：ギネヴィア", 1)	-- ダミー
			set_int("親密度：ギネヴィア", 0)	-- ダミー
			GetComuTest(Guinevere, "コミュランク：ギネヴィア", "親密度：ギネヴィア")
		elseif is_select(2) then
			-- 導入イベント
			set_int("コミュランク：ギネヴィア", 3)	-- ダミー
			set_int("親密度：ギネヴィア", 22)	-- ダミー
			IntroComuTest(Guinevere, "コミュランク：ギネヴィア", "親密度：ギネヴィア")
		elseif is_select(3) then
			-- 通常イベント
			set_int("コミュランク：ギネヴィア", 3)	-- ダミー
			set_int("親密度：ギネヴィア", 22)	-- ダミー
			NormalComuTest(Guinevere, "コミュランク：ギネヴィア", "親密度：ギネヴィア")
		else
			-- ランクアップイベント
			set_int("コミュランク：ギネヴィア", 3)	-- ダミー
			set_int("親密度：ギネヴィア", 30)	-- ダミー
			RankupComuTest(Guinevere, "コミュランク：ギネヴィア", "親密度：ギネヴィア")
		end
	else
		-- ランスロットがターゲットでイベント内容を決める
		message_direct("イベントの種類を選択します")
		open_select_window(Noir, "Normal")
		if is_select(1) then
			-- 獲得イベント
			set_int("コミュランク：ランスロット", 1)	-- ダミー
			set_int("親密度：ランスロット", 0)	-- ダミー
			GetComuTest(Lancelot, "コミュランク：ランスロット", "親密度：ランスロット")
		elseif is_select(2) then
			-- 導入イベント
			set_int("コミュランク：ランスロット", 3)	-- ダミー
			set_int("親密度：ランスロット", 22)	-- ダミー
			IntroComuTest(Lancelot, "コミュランク：ランスロット", "親密度：ランスロット")
		elseif is_select(3) then
			-- 通常イベント
			set_int("コミュランク：ランスロット", 3)	-- ダミー
			set_int("親密度：ランスロット", 22)	-- ダミー
			NormalComuTest(Lancelot, "コミュランク：ランスロット", "親密度：ランスロット")
		else
			-- ランクアップイベント
			set_int("コミュランク：ランスロット", 3)	-- ダミー
			set_int("親密度：ランスロット", 30)	-- ダミー
			RankupComuTest(Lancelot, "コミュランク：ランスロット", "親密度：ランスロット")
		end
	end
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
	setup_Noir_preload({1.050, 0.0, -1.610, 180.0})
	setup_Guinevere_preload({-1.430, 0.0,  0.050, 180.0})
	set_chara_preload("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack",  2.466, 0.0, -1.920, 180.0, "Mob_Sit_loop_f", "Normal")
	set_chara_preload("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack", -1.430, 0.0, -1.930, 180.0, "Mob_Sit_loop_f", "Normal")
	set_chara_preload("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack", -2.850, 0.0, -1.890, 180.0, "Mob_Sit_loop_f", "Normal")
	local function CommonEyeControl_preload(character)
	end
	CommonEyeControl_preload(MobGirl01)
	CommonEyeControl_preload(MobGirl02)
	CommonEyeControl_preload(MobGirl03)
	set_object_preload("effects_emotion", "Ef_C_Emo_FelUp01", false)
	set_object_preload("effects_emotion", "Ef_C_Emo_FelUp02", false)
	set_object_preload("effects_emotion", "Ef_C_Emo_FelUp03", false)
end
