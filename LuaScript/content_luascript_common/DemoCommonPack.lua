--[[
	■スクリプトデモ用共通処理
	・デモ共通で利用する処理をここにまとめて定義
]]

-- ---------------------------------------------------------------------------------------------------------------------

-- include処理

Include("content_luascript_common","DemoCommon_h")	-- 定数系
Include("content_luascript_common","3dCommonPack")	-- ADV小、3D表示
Include("content_luascript_common","2dCommonPack")	-- エリア系、2D表示
Include("content_luascript_common","DotCommonPack")	-- 疑似バトルADV系、ドット表示

-- デモ開始/終了処理関連

function demo_setup()
	--fadeout(0.0, 0.0, 0.0, 1.0, 0.0)	-- 描画準備を隠すための暗転
	--system.LoadSoundFile("staq_E_S")
	--system.LoadSoundFile("se")

	Load_common(true)
end

function demo_setup_nofade()
	--fadeout(0.0, 0.0, 0.0, 1.0, 0.0)	-- 描画準備を隠すための暗転
	--system.LoadSoundFile("staq_E_S")
	--system.LoadSoundFile("se")

	Load_common(false)
end

function demo_start()
	fadein(0)
	Play_start(true)
	wait_time(1.0)	-- 3Dモデルが落ち着くまで少し待つ

		debug_timeweather()	-- デバッグ用
end

function demo_start_nofade()
	fadein(0)
	Play_start(false)
	wait_time(1.0)	-- 3Dモデルが落ち着くまで少し待つ

		debug_timeweather()	-- デバッグ用
end

-- demo_start()のフェードなし、フッターなし呼び出し
function demo_start_nofade_nofooter()
	fadein(0)
	Play_start(false, false)
	wait_time(1.0)	-- 3Dモデルが落ち着くまで少し待つ

		debug_timeweather()	-- デバッグ用
end

function demo_start_nowait()
	fadein(0)
	Play_start(true)

		debug_timeweather()	-- デバッグ用
end

function demo_next()	-- 場面転換用
	Play_end(nil)
	fadeout(0.0, 0.0, 0.0, 1.0, 1.0)
	wait_time(1.0)
end

function demo_end()
	Play_end(true)
	wait_time(1.0)
end

function demo_end_nofade()
	Play_end(false)
	wait_time(1.0)
end

function demo_loadend_area2adv()
	SetActiveFreeMapTransitionAreaUnit(false)
end

function demo_playend_area2adv()
end

-- シーン切り替え準備(フェード)
function scene_change_ready()
	fadeout(0.0, 0.0, 0.0, 1.0, 0.0)
end

-- シーン切り替え終了(フェード)
function scene_change_end()
    fadein_wait(1)
end

-- フッターを開かないカットシーン準備
function nofooter_setup()
	Load_common(false)
end

-- フッターを開かないカットシーン開始
function nofooter_start()
    fadein(0)
	Play_start(false, false) -- フッターを開かないので第2引数にfalse
    debug_timeweather()	-- デバッグ用
end

-- フッターを開かないカットシーン終了
function nofooter_end()
	Play_end(false)
end

function debug_timeweather()

	local timeslot = get_timeslot()
	local weather = get_weather()

	if timeslot == 1 then
		debug_print("■時間帯は「朝」")
	elseif timeslot == 2 then
		debug_print("■時間帯は「昼」")
	elseif timeslot == 3 then
		debug_print("■時間帯は「放課後」")
	elseif timeslot == 4 then
		debug_print("■時間帯は「夜」")
	else
		debug_print("■時間帯は「不明」" .. timeslot)
	end

	if weather == 1 then
		debug_print("■天候は「晴れ」")
	elseif weather == 2 then
		debug_print("■天候は「雨」")
	elseif weather == 3 then
		debug_print("■天候は「雪」")
	elseif weather == 4 then
		debug_print("■天候は「曇り」")
	else
		debug_print("■天候は「不明」" .. weather)
	end

end



function play_facility_effect(level, attach_chr)

	effect_personal_up(attach_chr, "Head", 0.0, 0.10, 0.0, level)

	wait_time(1.0)
end



function kizuna_rankup_hint()
	-- ランクアップ示唆
	local hintText = commu.GetRankupHintText()
	open_narration_window()
		message_direct(hintText) -- ランクアップ示唆
	close_narration_window()
end

function kizuna_rankup_condition()
	-- 進行条件示唆
	local conditionText = commu.GetRankupConditionHintText()
	if string.len(conditionText) > 0 then
		open_narration_window()
			message_direct(conditionText)
		close_narration_window()
	end
end

function kizuna_gaugeup(controller, name)
	local commuRank = name.."_コミュランク"
	local kizuna = name.."_親密度"
	local trustParam = set_communication(commuRank, kizuna)

	hide_ui_textbox()

	trustParam.UpdateNormal() -- ここまでの上昇値をゲージの変化量に変換
	open_trust_gauge(controller, trustParam)
	debug_print("正常終了")
end

function kizuna_gaugeup_encount(controller, name)
	local commuRank = name.."_コミュランク"
	local kizuna = name.."_親密度"
	local trustParam = set_communication(commuRank, kizuna)

	hide_ui_textbox()

	trustParam.Update() -- 選択肢のみのゲージの変化量に変換
	open_trust_gauge(controller, trustParam)
	debug_print("正常終了")
end


-- システムポップアップM
function open_medium_popup(tagTitle, tagMessage)
		local textTitle = ""
		if tagTitle ~= nil then
			textTitle = system.GetMessageText(tagTitle)
		end
		local textMessage = ""
		if tagMessage ~= nil then
			textMessage = system.GetMessageText(tagMessage)
		end
        popup = system.CreateSystemPopup()
        signal = popup.OpenMediumDirect(textTitle, textMessage)
        while signal.IsProccessing() do
                coroutine.yield()
        end
end

-- ---------------------------------------------------------------------------------------------------------------------
-- キャラクター配置用関数　※新リソースID対応版
-- 	【使用方法】
-- 	setup_〇〇〇〇〇〇〇〇({配置座標：x,y,z配列}, "待機ループモーション", スタイル指定番号, 3Dモデル利用フラグ, モーションパックパス名, モーションパック名)
-- 	モーションパックパス名とパック名は省略可能。省略した場合はそのキャラ用の標準モーションパックが適用される。
-- 	【記述例】
-- 	setup_101009_Noir({100, 0, 50}, "Sri_Std_loop_m", 0, true)　座標(100, 0, 50)に「真面目男性：待機ループ」でノワールの「通常：制服」3Dモデルを配置。モーションパックは標準
-- 	setup_101009_Noir({100, 0, 50}, "Sri_Std_loop_m", 0, true, "content_animationpack_201_201noir", "MotionPack_201Noir_DEMO")　デモ専用のモーションパックを適用
-- ---------------------------------------------------------------------------------------------------------------------

-- 3Dモデル_ティルフィング
function setup_101001_Tyrfing(pos, pose, style, use3d, mcpath, mcpack)
	-- style 1:キラーズ
	-- style それ以外:通常

	if mcpath == nil then
		mcpath = "content_animationpack_101_101tyrf"
		mcpack = "MotionPack_101Tyrf"
	end

	if style == 1 then
		-- キラーズ
		if use3d == true then
			Tyrfing = set_chara("content_chr_101001_101001002_model", "101001002_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Tyrfing = set_chara_unknown()
		end

		character2DFull(Tyrfing, "Tyrfing", 101001002)
	else
		-- 通常：制服
		if use3d == true then
			Tyrfing = set_chara("content_chr_101001_101001001_model", "101001001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Tyrfing = set_chara_unknown()
		end

		character2DFull(Tyrfing, "Tyrfing", 101001001)
	end
end


-- 3Dモデル_ノワール
function setup_101009_Noir(pos, pose, style, use3d, mcpath, mcpack)
	-- style 1:雨具
	-- style 2:金コート版
	-- style 3:東方諸国連合軍
	-- style 4:幼少期　※3Dモデル無し
	-- style それ以外:通常

	if mcpath == nil then
		mcpath = "content_animationpack_101_101noir"
		mcpack = "MotionPack_101Noir"
	end

	if style == 2 then
		-- 金コード版
		if use3d == true then
			Noir = set_chara("content_chr_101009_101009001_model", "101009001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Noir = set_chara_unknown()
		end

		character2DFull(Noir, "Noir", 101009001)


	elseif style == 3 then
		-- 東方諸国連合軍
		if use3d == true then
			Noir = set_chara("content_chr_101009_101009003_model", "101009003_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Noir = set_chara_unknown()
		end

		character2DFull(Noir, "Noir", 101009003)


	elseif style == 4 then
		-- 幼少期　※3Dモデル無し
		Noir = set_chara_unknown()
		character2DFull(Noir, "Noir", 101009005)

	else
		-- 通常：制服
		if use3d == true then
			Noir = set_chara("content_chr_101009_101009002_model", "101009002_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Noir = set_chara_unknown()
		end

		character2DFull(Noir, "Noir", 101009002)
	end
end


-- 3Dモデル_ランスロット
function setup_101010_Lancelot(pos, pose, style, use3d, mcpath, mcpack)
	-- style 1:キラーズ
	-- style 2:幼少期　※3Dモデル無し
	-- style それ以外:通常

	if mcpath == nil then
		mcpath = "content_animationpack_101_101lanc"
		mcpack = "MotionPack_101Lanc"
	end

	if style == 1 then
		-- キラーズ
		if use3d == true then
			Lancelot = set_chara("content_chr_101010_101010002_model", "101010002_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Lancelot = set_chara_unknown()
		end

		character2DFull(Lancelot, "Lancelot", 101010002)

	elseif style == 2 then
		-- 幼少期　※3Dモデル無し
		Lancelot = set_chara_unknown()
		character2DFull(Lancelot, "Lancelot", 101010003)

	else
		-- 通常：制服
		if use3d == true then
			Lancelot = set_chara("content_chr_101010_101010001_model", "101010001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Lancelot = set_chara_unknown()
		end

		character2DFull(Lancelot, "Lancelot", 101010001)
	end
end


-- 3Dモデル_ギネヴィア
function setup_101011_Guinevere(pos, pose, style, use3d, mcpath, mcpack)
	-- style 1:キラーズ
	-- style 2:ドレス
	-- style それ以外:通常

	if mcpath == nil then
		mcpath = "content_animationpack_101_101guin"
		mcpack = "MotionPack_101Guin"
	end

	if style == 1 then
		-- キラーズ
		if use3d == true then
			Guinevere = set_chara("content_chr_101011_101011002_model", "101011002_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Guinevere = set_chara_unknown()
		end

		character2DFull(Guinevere, "Guinevere", 101011002)
		
	elseif style == 2 then
		-- ドレス
		if use3d == true then
			Guinevere = set_chara("content_chr_101011_101011003_model", "101011003_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Guinevere = set_chara_unknown()
		end

		character2DFull(Guinevere, "Guinevere", 101011003)
		
	else
		-- 通常：制服
		if use3d == true then
			Guinevere = set_chara("content_chr_101011_101011001_model", "101011001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Guinevere = set_chara_unknown()
		end

		character2DFull(Guinevere, "Guinevere", 101011001)
	end
end

--3D_ディナタン
function setup_101012_Dinatan(pos, pose, style, use3d, mcpath, mcpack)
	-- style 1:キラーズ
	-- style 2:傭兵
	-- style 3:幼少期　※3Dモデル無し
	-- style それ以外:通常

	if mcpath == nil then
		mcpath = "content_animationpack_101_101dina"
		mcpack = "MotionPack_101Dina"
	end

	if style == 1 then
		-- キラーズ
		if use3d == true then
			Dinatan = set_chara("content_chr_101012_101012002_model", "101012002_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Dinatan = set_chara_unknown()
		end

		character2DFull(Dinatan, "Dinatan", 101012002)


	elseif style == 2 then
		-- 傭兵
		if use3d == true then
			Dinatan = set_chara("content_chr_101012_101012003_model", "101012003_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Dinatan = set_chara_unknown()
		end

		character2DFull(Dinatan, "Dinatan", 101012003)


	elseif style == 3 then
		-- 幼少期　※3Dモデル無し
		Dinatan = set_chara_unknown()
		character2DFull(Dinatan, "Dinatan", 101012004)

	else
		-- 通常：制服
		if use3d == true then
			Dinatan = set_chara("content_chr_101012_101012001_model", "101012001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Dinatan = set_chara_unknown()
		end

		character2DFull(Dinatan, "Dinatan", 101012001)
	end
end

--3D_ガウェイン
function setup_101013_Gawain(pos, pose, style, use3d, mcpath, mcpack)
	-- style それ以外:通常

	if mcpath == nil then
		mcpath = "content_animationpack_101_101gawa"
		mcpack = "MotionPack_101Gawa"
	end

	if style == 1 then
		-- まだ未定
	else
		-- 通常：制服
		if use3d == true then
			Gawain = set_chara("content_chr_101013_101013001_model", "101013001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Gawain = set_chara_unknown()
		end

		character2DFull(Gawain, "Gawain", 101013001)
	end
end

--3D_ギネマウア
function setup_101016_Gwenhwymawr(pos, pose, style, use3d, mcpath, mcpack)
	-- style 1:キラーズ
	-- style それ以外:通常

	if mcpath == nil then
		mcpath = "content_animationpack_101_101gwen"
		mcpack = "MotionPack_101Gwen"
	end

	if style == 1 then
		-- キラーズ
		if use3d == true then
			Gwenhwymawr = set_chara("content_chr_101016_101016002_model", "101016002_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Gwenhwymawr = set_chara_unknown()
		end

		character2DFull(Gwenhwymawr, "Gwenhwymawr", 101016002)
	else
		-- 通常：制服
		if use3d == true then
			Gwenhwymawr = set_chara("content_chr_101016_101016001_model", "101016001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Gwenhwymawr = set_chara_unknown()
		end

		character2DFull(Gwenhwymawr, "Gwenhwymawr", 101016001)
	end
end


--3D_マルディサント
function setup_101017_Maladisant(pos, pose, style, use3d, mcpath, mcpack)
	-- style 1:キラーズ
	-- style 2:療養服
	-- style それ以外:通常

	if mcpath == nil then
--		mcpath = "content_animationpack__common"
--		mcpack = "MotionPackBeta2"
		mcpath = "content_animationpack_101_101mala"
		mcpack = "MotionPack_101Mala"
	end

	if style == 1 then
		-- キラーズ
		if use3d == true then
			Maladisant = set_chara("content_chr_101017_101017002_model", "101017002_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Gwenhwymawr = set_chara_unknown()
		end

		character2DFull(Maladisant, "Maladisant", 101017002)
	else
		-- 通常：制服
		if use3d == true then
			Maladisant = set_chara("content_chr_101017_101017001_model", "101017001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Maladisant = set_chara_unknown()
		end

		character2DFull(Maladisant, "Maladisant", 101017001)
	end
end


-- 3D_エレイン
function setup_101030_Elaine(pos, pose, style, use3d, mcpath, mcpack)
	-- style 1:スカー
	-- style 2:ドレス
	-- style それ以外:通常

	if mcpath == nil then
		mcpath = "content_animationpack_101_101elai"
		mcpack = "MotionPack_101Elai"
	end

	if style == 1 then
		-- スカー
		if use3d == true then
			Elaine = set_chara("content_chr_101030_101030002_model", "101030002_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Elaine = set_chara_unknown()
		end

		character2DFull(Elaine, "Elaine", 101030002)

	elseif style == 2 then
		-- ドレス
		if use3d == true then
			Elaine = set_chara("content_chr_101030_101030003_model", "101030003_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Elaine = set_chara_unknown()
		end

		character2DFull(Elaine, "Elaine", 101030003)
		
	else
		-- 通常：制服
		if use3d == true then
			Elaine = set_chara("content_chr_101030_101030001_model", "101030001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Elaine = set_chara_unknown()
		end

		character2DFull(Elaine, "Elaine", 101030001)
	end
end


-- 3D_ガラハッド
function setup_101028_Galahad(pos, pose, style, use3d, mcpath, mcpack)
	-- style 1:銀卓の騎士
	-- style 2:銀卓の騎士（兜あり）
	-- style 3:暴走状態	
	-- style それ以外:制服

	if mcpath == nil then
		mcpath = "content_animationpack_101_101gala"
		mcpack = "MotionPack_101Gala"
	end

	if style == 1 then
		-- 銀卓の騎士
		if use3d == true then
			Galahad = set_chara("content_chr_101028_101028002_model", "101028002_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Galahad = set_chara_unknown()
		end

		character2DFull(Galahad, "Galahad", 101028002)

	elseif style == 2 then
		-- 銀卓の騎士（兜あり）
		-- 未定

	elseif style == 3 then
		-- 暴走状態
		-- 未定

	else
		-- 通常：制服
		if use3d == true then
			Galahad = set_chara("content_chr_101028_101028001_model", "101028001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Galahad = set_chara_unknown()
		end

		character2DFull(Galahad, "Galahad", 101028001)
	end
end


--3D_ラグネル
function setup_101018_Ragnar(pos, pose, style, use3d, mcpath, mcpack)
	-- style 1:キラーズ
	-- style それ以外:通常

	if mcpath == nil then
		mcpath = "content_animationpack_101_101ragn"
		mcpack = "MotionPack_101Ragn"
	end

	if style == 1 then
		-- キラーズ
		if use3d == true then
			Ragnar = set_chara("content_chr_101018_101018002_model", "101018002_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Ragnar = set_chara_unknown()
		end

		character2DFull(Ragnar, "Ragnar", 101018002)
	else
		-- 通常：制服
		if use3d == true then
			Ragnar = set_chara("content_chr_101018_101018001_model", "101018001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Ragnar = set_chara_unknown()
		end

		character2DFull(Ragnar, "Ragnar", 101018001)
	end
end

-- ---------------------------------------------------------------------------------------------------------------------
--3D_パーシヴァル
function setup_101026_Percival(pos, pose, style, use3d, mcpath, mcpack)
	-- style それ以外:通常

	if mcpath == nil then
		mcpath = "content_animationpack_101_101perc"
		mcpack = "MotionPack_101Perc"
	end

	if style == 1 then
		-- まだ未定
	else
		-- 通常：制服
		if use3d == true then
			Percival = set_chara("content_chr_101026_101026001_model", "101026001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Percival = set_chara_unknown()
		end

		character2DFull(Percival, "Percival", 101026001)
	end
end



--3D_トリスタン
function setup_101014_Tristan(pos, pose, style, use3d, mcpath, mcpack)
	-- style それ以外:通常

	if mcpath == nil then
		mcpath = "content_animationpack_101_101tris"
		mcpack = "MotionPack_101Tris"
	end

	if style == 1 then
		-- まだ未定
	else
		-- 通常
		if use3d == true then
			Tristan = set_chara("content_chr_101014_101014001_model", "101014001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Tristan = set_chara_unknown()
		end

		character2DMinimum(Tristan, "Tristan", 101014001)
	end
end

--3D_アーサー
function setup_101015_Arthur(pos, pose, style, use3d, mcpath, mcpack)
	-- style 1:バルバロイ態
	-- style それ以外:通常

	if mcpath == nil then
		mcpath = "content_animationpack_101_101arth"
		mcpack = "MotionPack_101Arth"
	end

	if style == 1 then
		-- バルバロイ態
		-- まだ未定
	else
		-- 通常
		if use3d == true then
			Arthur = set_chara("content_chr_101015_101015001_model", "101015001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Arthur = set_chara_unknown()
		end

		character2DMinimum(Arthur, "Arthur", 101015001)
	end
end

--3D_イゾルデ
function setup_101019_Isolde(pos, pose, style, use3d, mcpath, mcpack)
	-- style それ以外:通常

	if mcpath == nil then
		mcpath = "content_animationpack_101_101isol"
		mcpack = "MotionPack_101Isol"
	end

	if style == 1 then
		-- まだ未定
	else
		-- 通常
		if use3d == true then
			Isolde = set_chara("content_chr_101019_101019001_model", "101019001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Isolde = set_chara_unknown()
		end

		character2DMinimum(Isolde, "Isolde", 101019001)
	end
end

--3D_ヴォールス
function setup_101024_Bors(pos, pose, style, use3d, mcpath, mcpack)
	-- style それ以外:通常

	if mcpath == nil then
		mcpath = "content_animationpack_101_101bors"
		mcpack = "MotionPack_101Bors"
	end

	if style == 1 then
		-- まだ未定
	else
		-- 通常
		if use3d == true then
			Bors = set_chara("content_chr_101024_101024001_model", "101024001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Bors = set_chara_unknown()
		end

		character2DMinimum(Bors, "Bors", 101024001)
	end
end


--3D_ガレス
function setup_101032_Gareth(pos, pose, style, use3d, mcpath, mcpack)
	-- style それ以外:通常

	if mcpath == nil then
		mcpath = "content_animationpack_101_101gare"
		mcpack = "MotionPack_101Gare"
	end

	if style == 1 then
		-- まだ未定
	else
		-- 通常
		if use3d == true then
			Gareth = set_chara("content_chr_101032_101032001_model", "101032001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Gareth = set_chara_unknown()
		end

		character2DMinimum(Gareth, "Gareth", 101032001)
	end
end

--3D_リオネス
function setup_101033_Lyonesse(pos, pose, style, use3d, mcpath, mcpack)
	-- style それ以外:通常

	if mcpath == nil then
		mcpath = "content_animationpack_101_101lyon"
		mcpack = "MotionPack_101Lyon"
	end

	if style == 1 then
		-- まだ未定
	else
		-- 通常
		if use3d == true then
			Lyonesse = set_chara("content_chr_101033_101033001_model", "101033001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Lyonesse = set_chara_unknown()
		end

		character2DMinimum(Lyonesse, "Lyonesse", 101033001)
	end
end


--3D_ケイ
function setup_101040_Kay(pos, pose, style, use3d, mcpath, mcpack)
	-- style それ以外:通常

	if mcpath == nil then
		mcpath = "content_animationpack_101_101kay"
		mcpack = "MotionPack_101Kay"
	end

	if style == 1 then
		-- まだ未定
	else
		-- 通常
		if use3d == true then
			Kay = set_chara("content_chr_101040_101040001_model", "101040001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Kay = set_chara_unknown()
		end

		character2DMinimum(Kay, "Kay", 101040001)
	end
end


--3D_モルガン
function setup_101041_Morgan(pos, pose, style, use3d, mcpath, mcpack)
	-- style 1:バルバロイ態
	-- style それ以外:通常（車椅子）

	if mcpath == nil then
--		mcpath = "content_animationpack__common"
--		mcpack = "MotionPackBeta2"
		mcpath = "content_animationpack_101_101morg"
		mcpack = "MotionPack_101Morg"
	end

	if style == 1 then
		-- バルバロイ態
		-- まだ未定
	else
		-- 通常（車椅子）
		if use3d == true then
			Morgan = set_chara("content_chr_101041_101041001_model", "101041001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Morgan = set_chara_unknown()
		end

		character2DMinimum(Morgan, "Morgan", 101041001)
	end
end



--3D_ブルーノ
function setup_101021_Bruno(pos, pose, style, use3d, mcpath, mcpack)
	-- style 1:傭兵
	-- style 2:キラーズ体（仮面なし）
	-- style それ以外:キラーズ体（仮面あり）

	if mcpath == nil then
		mcpath = "content_animationpack_101_101arth"
		mcpack = "MotionPack_101Arth" --@todo【仮】でアーサー（堂々）のパックを設定
	end

	if style == 1 then
		-- まだ未定
	else
		-- 通常
		if use3d == true then
			Bruno = set_chara("content_chr_101021_101021001_model", "101021001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Bruno = set_chara_unknown()
		end

		character2DMinimum(Bruno, "Bruno", 101021001)
	end
end


--3D_ラロゥ
function setup_101061_Larou(pos, pose, style, use3d, mcpath, mcpack)
	-- style それ以外:通常

	if mcpath == nil then
		mcpath = "content_animationpack_101_101laro"
		mcpack = "MotionPack_101Laro"
	end

	if style == 1 then
		-- まだ未定
	else
		-- 通常
		if use3d == true then
			Larou = set_chara("content_chr_101061_101061001_model", "101061001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Larou = set_chara_unknown()
		end

		character2DMinimum(Larou, "Larou", 101061001)
	end
end


--3D_マルイル
function setup_101062_Maril(pos, pose, style, use3d, mcpath, mcpack)
	-- style それ以外:通常

	if mcpath == nil then
		mcpath = "content_animationpack_101_101mari"
		mcpack = "MotionPack_101Mari"
	end

	if style == 1 then
		-- まだ未定
	else
		-- 通常
		if use3d == true then
			Maril = set_chara("content_chr_101062_101062001_model", "101062001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Maril = set_chara_unknown()
		end

		character2DMinimum(Maril, "Maril", 101062001)
	end
end


--3D_クリスティーナ
function setup_101063_Christina(pos, pose, style, use3d, mcpath, mcpack)
	-- style それ以外:通常

	if mcpath == nil then
		mcpath = "content_animationpack_101_101chri"
		mcpack = "MotionPack_101Chri"
	end

	if style == 1 then
		-- まだ未定
	else
		-- 通常
		if use3d == true then
			Christina = set_chara("content_chr_101063_101063001_model", "101063001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Christina = set_chara_unknown()
		end

		character2DMinimum(Christina, "Christina", 101063001)
	end
end


--3D_リアム
function setup_101064_Liam(pos, pose, style, use3d, mcpath, mcpack)
	-- style それ以外:通常

	if mcpath == nil then
		mcpath = "content_animationpack_101_101liam"
		mcpack = "MotionPack_101Liam"
	end

	if style == 1 then
		-- まだ未定
	else
		-- 通常
		if use3d == true then
			Liam = set_chara("content_chr_101064_101064001_model", "101064001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Liam = set_chara_unknown()
		end

		character2DMinimum(Liam, "Liam", 101064001)
	end
end


--3D_モーロノーエ
function setup_101042_Moronoe(pos, pose, style, use3d, mcpath, mcpack)
	-- style それ以外:通常

	if mcpath == nil then
		mcpath = "content_animationpack__common"
		mcpack = "MotionPackBeta2"
	end

	if style == 1 then
		-- まだ未定
	else
		-- 通常
		if use3d == true then
			Moronoe = set_chara("content_chr_101042_101042001_model", "101042001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Moronoe = set_chara_unknown()
		end

		character2DMinimum(Moronoe, "Moronoe", 101042001)
	end
end


--3D_ニニアン
function setup_101067_Ninian(pos, pose, style, use3d, mcpath, mcpack)
	-- style それ以外:通常
	
	if mcpath == nil then
		mcpath = "content_animationpack_101_101dina" --@todo ディナタンで代用
		mcpack = "MotionPack_101Dina"
	end

	if style == 1 then
		-- まだ未定
	else
		-- 通常
		if use3d == true then
			Ninian = set_chara("content_chr_101067_101067001_model", "101067001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
			Ninian = set_chara_unknown()
		end

		character2DMinimum(Ninian, "Ninian", 101067001)
	end
end


-- ---------------------------------------------------------------------------------------------------------------------
function setup_MOB01_StudentB(pos, pose, style, mcpath, mcpack)
	-- style 1:キャメロット騎士学術院（男）２
	-- style 2:キャメロット騎士学術院（男）３
	-- style それ以外:キャメロット騎士学術院（男）

	local label

	if mcpath == nil then
		mcpath = "content_animationpack_100_100mobm"
		mcpack = "MotionPack_100MobM"
	end

	if style == 1 then
		-- キャメロット騎士学術院（男）２
		label = set_chara("content_chr_401007_401007001_model", "401007001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	elseif style == 2 then
		-- キャメロット騎士学術院（男）３
		label = set_chara("content_chr_401009_401009001_model", "401009001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	else
		-- キャメロット騎士学術院（男）
		label = set_chara("content_chr_401005_401005001_model", "401005001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	end

	return(label)
end

function setup_MOB01_StudentG(pos, pose, style, mcpath, mcpack)
	-- style 1:キャメロット騎士学術院（女）２
	-- style 2:キャメロット騎士学術院（女）３
	-- style それ以外:キャメロット騎士学術院（女）

	local label

	if mcpath == nil then
		mcpath = "content_animationpack_100_100mobf"
		mcpack = "MotionPack_100MobF"
	end

	if style == 1 then
		-- キャメロット騎士学術院（女）２
		label = set_chara("content_chr_401008_401008001_model", "401008001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	elseif style == 2 then
		-- キャメロット騎士学術院（女）３
		label = set_chara("content_chr_401010_401010001_model", "401010001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	else
		-- キャメロット騎士学術院（女）
		label = set_chara("content_chr_401006_401006001_model", "401006001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	end

	return(label)
end

function setup_MOB01_Soldier(pos, pose, style, mcpath, mcpack)
	-- style 1:キャメロット軍兵士_上位
	-- style 2:東方諸国連合軍兵_下位
	-- style 3:東方諸国連合軍兵_下位（バルバロイ寄生.ver）
	-- style 4:東方諸国連合軍兵_上位
	-- style 5:ローマ兵士_下位
	-- style 6:ローマ兵士_上位
	-- style それ以外:キャメロット軍兵士_下位

	local label

	if mcpath == nil then
		mcpath = "content_animationpack_100_100mobm"
		mcpack = "MotionPack_100MobM"
	end

	if style == 1 then
		-- キャメロット軍兵士_上位
		label = set_chara("content_chr_401035_401035001_model", "401035001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	elseif style == 2 then
		-- 東方諸国連合軍兵_下位
		label = set_chara("content_chr_401038_401038001_model", "401038001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	elseif style == 3 then
		-- 東方諸国連合軍兵_下位（バルバロイ寄生.ver）
		label = set_chara("content_chr_401038_401038002_model", "401038002_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	elseif style == 4 then
		-- 東方諸国連合軍兵_上位
		label = set_chara("content_chr_401037_401037001_model", "401037001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	elseif style == 5 then
		-- ローマ兵士_下位
		label = set_chara("content_chr_401040_401040001_model", "401040001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	elseif style == 6 then
		-- ローマ兵士_上位
		label = set_chara("content_chr_401039_401039001_model", "401039001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	else
		-- キャメロット軍兵士_下位
		label = set_chara("content_chr_401036_401036001_model", "401036001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	end

	return(label)
end

function setup_MOB01_CitizenM(pos, pose, style, mcpath, mcpack)
	-- style 1:市民（男）２
	-- style 2:市民（中年男）
	-- style 3:市民（中年男）２
	-- style それ以外:市民（男）

	local label

	if mcpath == nil then
		mcpath = "content_animationpack_100_100mobm"
		mcpack = "MotionPack_100MobM"
	end

	if style == 1 then
		-- 市民（男）２
		label = set_chara("content_chr_401013_401013001_model", "401013001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	elseif style == 2 then
		-- 市民（中年男）
		label = set_chara("content_chr_401019_401019001_model", "401019001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	elseif style == 3 then
		-- 市民（中年男）２
		label = set_chara("content_chr_401021_401021001_model", "401021001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	else
		-- 市民（男）
		label = set_chara("content_chr_401011_401011001_model", "401011001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	end

	return(label)
end

function setup_MOB01_CitizenF(pos, pose, style, mcpath, mcpack)
	-- style 1:市民（女）２
	-- style 2:市民（中年女）
	-- style 3:市民（中年女）２
	-- style それ以外:市民（女）

	local label

	if mcpath == nil then
		mcpath = "content_animationpack_100_100mobf"
		mcpack = "MotionPack_100MobF"
	end

	if style == 1 then
		-- 市民（女）２
		label = set_chara("content_chr_401014_401014001_model", "401014001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	elseif style == 2 then
		-- 市民（中年女）
		label = set_chara("content_chr_401020_401020001_model", "401020001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	elseif style == 3 then
		-- 市民（中年女）２
		label = set_chara("content_chr_401022_401022001_model", "401022001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	else
		-- 市民（女）
		label = set_chara("content_chr_401012_401012001_model", "401012001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	end

	return(label)
end

function setup_MOB01_ChildM(pos, pose, style, mcpath, mcpack)
	-- style 1:子供（男）２
	-- style それ以外:子供（男）

	local label

	if mcpath == nil then
		mcpath = "content_animationpack_100_100chefc"
		mcpack = "MotionPack_100CheFC"
	end

	if style == 1 then
		-- 子供（男）２
		label = set_chara("content_chr_401017_401017001_model", "401017001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	else
		-- 子供（男）
		label = set_chara("content_chr_401015_401015001_model", "401015001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	end

	return(label)
end

function setup_MOB01_ChildF(pos, pose, style, mcpath, mcpack)
	-- style 1:子供（女）２
	-- style それ以外:子供（女）

	local label

	if mcpath == nil then
		mcpath = "content_animationpack_100_100chefc"
		mcpack = "MotionPack_100CheFC"
	end

	if style == 1 then
		-- 子供（女）２
		label = set_chara("content_chr_401018_401018001_model", "401018001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	else
		-- 子供（女）
		label = set_chara("content_chr_401016_401016001_model", "401016001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	end

	return(label)
end



-- 背景モデルの時間帯・天候変化の対応

function setup_Area110041()
--[[ 110041 屋上
	昼晴：110041
	昼雨：115042
	昼雪：115043

	夕晴：115044
	夕雨：115045
	夕雪：115046
]]
	local env = get_environment()
	debug_print("■envは " .. env)

	
	if env == 11 then
		load_area_scene(110041)
	elseif env == 12 then
		load_area_scene(115042)
	elseif env == 13 then
		load_area_scene(115043)
	elseif env == 21 then
		load_area_scene(110041)
	elseif env == 22 then
		load_area_scene(115042)
	elseif env == 23 then
		load_area_scene(115043)
	elseif env == 31 then
		load_area_scene(115044)
	elseif env == 32 then
		load_area_scene(115045)
	elseif env == 33 then
		load_area_scene(115046)
	else
		-- どれにも当てはまらない
		load_area_scene(110041)
	end
end

function setup_Area112021()
--[[ 112021 マーケット
	昼：112021
	夕：116024
	夜：116027
]]
	local env = get_timeslot()
	debug_print("■envは " .. env)

	if env == 1 then
		load_area_scene(112021) -- マーケット　昼
	elseif env == 2 then
		load_area_scene(112021) -- マーケット　昼
	elseif env == 3 then
		load_area_scene(116024) -- マーケット　夕
	elseif env == 41 then
		load_area_scene(116027) -- マーケット　夜
	else
		-- どれにも当てはまらない
		load_area_scene(112021) -- マーケット　昼
	end
end

function get_environment()
--[[
	返り値
	11	朝　晴
	12	朝　雨
	13	朝　雪
	14	朝　曇り

	21	昼　晴
	22	昼　雨
	23	昼　雪
	24	昼　曇り

	31	夕　晴
	32	夕　雨
	33	夕　雪
	34	夕　曇り

	41	夜　晴
	42	夜　雨
	43	夜　雪
	44	夜　曇り
]]
	return( get_timeslot()*10 + get_weather() )
end

function setup_101001_Tyrfing_preload(pos, pose, style, use3d, mcpath, mcpack)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if mcpath == nil then
		mcpath = "content_animationpack_101_101tyrf"
		mcpack = "MotionPack_101Tyrf"
	end
	if style == 1 then
		if use3d == true then
			set_chara_preload("content_chr_101001_101001002_model", "101001002_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DFull_Preload(Tyrfing, "Tyrfing", 101001002)
	else
		if use3d == true then
			set_chara_preload("content_chr_101001_101001001_model", "101001001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DFull_Preload(Tyrfing, "Tyrfing", 101001001)
	end
end

function setup_101009_Noir_preload(pos, pose, style, use3d, mcpath, mcpack)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if mcpath == nil then
		mcpath = "content_animationpack_101_101noir"
		mcpack = "MotionPack_101Noir"
	end
	if style == 2 then
		if use3d == true then
			set_chara_preload("content_chr_101009_101009001_model", "101009001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DFull_Preload(Noir, "Noir", 101009001)
	elseif style == 3 then
		if use3d == true then
			set_chara_preload("content_chr_101009_101009003_model", "101009003_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DFull_Preload(Noir, "Noir", 101009003)
	elseif style == 4 then
		character2DFull_Preload(Noir, "Noir", 101009005)
	else
		if use3d == true then
			set_chara_preload("content_chr_101009_101009002_model", "101009002_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DFull_Preload(Noir, "Noir", 101009002)
	end
end

function setup_101010_Lancelot_preload(pos, pose, style, use3d, mcpath, mcpack)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if mcpath == nil then
		mcpath = "content_animationpack_101_101lanc"
		mcpack = "MotionPack_101Lanc"
	end
	if style == 1 then
		if use3d == true then
			set_chara_preload("content_chr_101010_101010002_model", "101010002_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DFull_Preload(Lancelot, "Lancelot", 101010002)
	elseif style == 2 then
		character2DFull_Preload(Lancelot, "Lancelot", 101010003)
	else
		if use3d == true then
			set_chara_preload("content_chr_101010_101010001_model", "101010001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DFull_Preload(Lancelot, "Lancelot", 101010001)
	end
end

function setup_101011_Guinevere_preload(pos, pose, style, use3d, mcpath, mcpack)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if mcpath == nil then
		mcpath = "content_animationpack_101_101guin"
		mcpack = "MotionPack_101Guin"
	end
	if style == 1 then
		if use3d == true then
			set_chara_preload("content_chr_101011_101011002_model", "101011002_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DFull_Preload(Guinevere, "Guinevere", 101011002)
	elseif style == 2 then
		if use3d == true then
			set_chara_preload("content_chr_101011_101011003_model", "101011003_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DFull_Preload(Guinevere, "Guinevere", 101011003)
	else
		if use3d == true then
			set_chara_preload("content_chr_101011_101011001_model", "101011001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DFull_Preload(Guinevere, "Guinevere", 101011001)
	end
end

function setup_101012_Dinatan_preload(pos, pose, style, use3d, mcpath, mcpack)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if mcpath == nil then
		mcpath = "content_animationpack_101_101dina"
		mcpack = "MotionPack_101Dina"
	end
	if style == 1 then
		if use3d == true then
			set_chara_preload("content_chr_101012_101012002_model", "101012002_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DFull_Preload(Dinatan, "Dinatan", 101012002)
	elseif style == 2 then
		if use3d == true then
			set_chara_preload("content_chr_101012_101012003_model", "101012003_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DFull_Preload(Dinatan, "Dinatan", 101012003)
	elseif style == 3 then
		character2DFull_Preload(Dinatan, "Dinatan", 101012004)
	else
		if use3d == true then
			set_chara_preload("content_chr_101012_101012001_model", "101012001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DFull_Preload(Dinatan, "Dinatan", 101012001)
	end
end

function setup_101013_Gawain_preload(pos, pose, style, use3d, mcpath, mcpack)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if mcpath == nil then
		mcpath = "content_animationpack_101_101gawa"
		mcpack = "MotionPack_101Gawa"
	end
	if style == 1 then
	else
		if use3d == true then
			set_chara_preload("content_chr_101013_101013001_model", "101013001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DFull_Preload(Gawain, "Gawain", 101013001)
	end
end

function setup_101016_Gwenhwymawr_preload(pos, pose, style, use3d, mcpath, mcpack)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if mcpath == nil then
		mcpath = "content_animationpack_101_101gwen"
		mcpack = "MotionPack_101Gwen"
	end
	if style == 1 then
		if use3d == true then
			set_chara_preload("content_chr_101016_101016002_model", "101016002_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DFull_Preload(Gwenhwymawr, "Gwenhwymawr", 101016002)
	else
		if use3d == true then
			set_chara_preload("content_chr_101016_101016001_model", "101016001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DFull_Preload(Gwenhwymawr, "Gwenhwymawr", 101016001)
	end
end

function setup_101017_Maladisant_preload(pos, pose, style, use3d, mcpath, mcpack)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if mcpath == nil then
		mcpath = "content_animationpack_101_101mala"
		mcpack = "MotionPack_101Mala"
	end
	if style == 1 then
		if use3d == true then
			set_chara_preload("content_chr_101017_101017002_model", "101017002_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DFull_Preload(Maladisant, "Maladisant", 101017002)
	else
		if use3d == true then
			set_chara_preload("content_chr_101017_101017001_model", "101017001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DFull_Preload(Maladisant, "Maladisant", 101017001)
	end
end

function setup_101030_Elaine_preload(pos, pose, style, use3d, mcpath, mcpack)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if mcpath == nil then
		mcpath = "content_animationpack_101_101elai"
		mcpack = "MotionPack_101Elai"
	end
	if style == 1 then
		if use3d == true then
			set_chara_preload("content_chr_101030_101030002_model", "101030002_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DFull_Preload(Elaine, "Elaine", 101030002)
	elseif style == 2 then
		if use3d == true then
			set_chara_preload("content_chr_101030_101030003_model", "101030003_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DFull_Preload(Elaine, "Elaine", 101030003)
	else
		if use3d == true then
			set_chara_preload("content_chr_101030_101030001_model", "101030001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DFull_Preload(Elaine, "Elaine", 101030001)
	end
end

function setup_101028_Galahad_preload(pos, pose, style, use3d, mcpath, mcpack)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if mcpath == nil then
		mcpath = "content_animationpack_101_101gala"
		mcpack = "MotionPack_101Gala"
	end
	if style == 1 then
		if use3d == true then
			set_chara_preload("content_chr_101028_101028002_model", "101028002_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DFull_Preload(Galahad, "Galahad", 101028002)
	elseif style == 2 then
	elseif style == 3 then
	else
		if use3d == true then
			set_chara_preload("content_chr_101028_101028001_model", "101028001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DFull_Preload(Galahad, "Galahad", 101028001)
	end
end

function setup_101018_Ragnar_preload(pos, pose, style, use3d, mcpath, mcpack)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if mcpath == nil then
		mcpath = "content_animationpack_101_101ragn"
		mcpack = "MotionPack_101Ragn"
	end
	if style == 1 then
		if use3d == true then
			set_chara_preload("content_chr_101018_101018002_model", "101018002_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DFull_Preload(Ragnar, "Ragnar", 101018002)
	else
		if use3d == true then
			set_chara_preload("content_chr_101018_101018001_model", "101018001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DFull_Preload(Ragnar, "Ragnar", 101018001)
	end
end

function setup_101026_Percival_preload(pos, pose, style, use3d, mcpath, mcpack)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if mcpath == nil then
		mcpath = "content_animationpack_101_101perc"
		mcpack = "MotionPack_101Perc"
	end
	if style == 1 then
	else
		if use3d == true then
			set_chara_preload("content_chr_101026_101026001_model", "101026001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DFull_Preload(Percival, "Percival", 101026001)
	end
end

function setup_101014_Tristan_preload(pos, pose, style, use3d, mcpath, mcpack)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if mcpath == nil then
		mcpath = "content_animationpack_101_101tris"
		mcpack = "MotionPack_101Tris"
	end
	if style == 1 then
	else
		if use3d == true then
			set_chara_preload("content_chr_101014_101014001_model", "101014001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DMinimum_Preload(Tristan, "Tristan", 101014001)
	end
end

function setup_101015_Arthur_preload(pos, pose, style, use3d, mcpath, mcpack)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if mcpath == nil then
		mcpath = "content_animationpack_101_101arth"
		mcpack = "MotionPack_101Arth"
	end
	if style == 1 then
	else
		if use3d == true then
			set_chara_preload("content_chr_101015_101015001_model", "101015001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DMinimum_Preload(Arthur, "Arthur", 101015001)
	end
end

function setup_101019_Isolde_preload(pos, pose, style, use3d, mcpath, mcpack)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if mcpath == nil then
		mcpath = "content_animationpack_101_101isol"
		mcpack = "MotionPack_101Isol"
	end
	if style == 1 then
	else
		if use3d == true then
			set_chara_preload("content_chr_101019_101019001_model", "101019001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DMinimum_Preload(Isolde, "Isolde", 101019001)
	end
end

function setup_101024_Bors_preload(pos, pose, style, use3d, mcpath, mcpack)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if mcpath == nil then
		mcpath = "content_animationpack_101_101bors"
		mcpack = "MotionPack_101Bors"
	end
	if style == 1 then
	else
		if use3d == true then
			set_chara_preload("content_chr_101024_101024001_model", "101024001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DMinimum_Preload(Bors, "Bors", 101024001)
	end
end

function setup_101032_Gareth_preload(pos, pose, style, use3d, mcpath, mcpack)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if mcpath == nil then
		mcpath = "content_animationpack_101_101gare"
		mcpack = "MotionPack_101Gare"
	end
	if style == 1 then
	else
		if use3d == true then
			set_chara_preload("content_chr_101032_101032001_model", "101032001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DMinimum_Preload(Gareth, "Gareth", 101032001)
	end
end

function setup_101033_Lyonesse_preload(pos, pose, style, use3d, mcpath, mcpack)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if mcpath == nil then
		mcpath = "content_animationpack_101_101lyon"
		mcpack = "MotionPack_101Lyon"
	end
	if style == 1 then
	else
		if use3d == true then
			set_chara_preload("content_chr_101033_101033001_model", "101033001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DMinimum_Preload(Lyonesse, "Lyonesse", 101033001)
	end
end

function setup_101040_Kay_preload(pos, pose, style, use3d, mcpath, mcpack)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if mcpath == nil then
		mcpath = "content_animationpack_101_101kay"
		mcpack = "MotionPack_101Kay"
	end
	if style == 1 then
	else
		if use3d == true then
			set_chara_preload("content_chr_101040_101040001_model", "101040001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DMinimum_Preload(Kay, "Kay", 101040001)
	end
end

function setup_101041_Morgan_preload(pos, pose, style, use3d, mcpath, mcpack)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if mcpath == nil then
		mcpath = "content_animationpack_101_101morg"
		mcpack = "MotionPack_101Morg"
	end
	if style == 1 then
	else
		if use3d == true then
			set_chara_preload("content_chr_101041_101041001_model", "101041001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DMinimum_Preload(Morgan, "Morgan", 101041001)
	end
end

function setup_101021_Bruno_preload(pos, pose, style, use3d, mcpath, mcpack)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if mcpath == nil then
		mcpath = "content_animationpack_101_101arth"
		mcpack = "MotionPack_101Arth" --@todo【仮】でアーサー（堂々）のパックを設定
	end
	if style == 1 then
	else
		if use3d == true then
			set_chara_preload("content_chr_101021_101021001_model", "101021001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DMinimum_Preload(Bruno, "Bruno", 101021001)
	end
end

function setup_101061_Larou_preload(pos, pose, style, use3d, mcpath, mcpack)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if mcpath == nil then
		mcpath = "content_animationpack_101_101laro"
		mcpack = "MotionPack_101Laro"
	end
	if style == 1 then
	else
		if use3d == true then
			set_chara_preload("content_chr_101061_101061001_model", "101061001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DMinimum_Preload(Larou, "Larou", 101061001)
	end
end

function setup_101062_Maril_preload(pos, pose, style, use3d, mcpath, mcpack)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if mcpath == nil then
		mcpath = "content_animationpack_101_101mari"
		mcpack = "MotionPack_101Mari"
	end
	if style == 1 then
	else
		if use3d == true then
			set_chara_preload("content_chr_101062_101062001_model", "101062001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DMinimum_Preload(Maril, "Maril", 101062001)
	end
end

function setup_101063_Christina_preload(pos, pose, style, use3d, mcpath, mcpack)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if mcpath == nil then
		mcpath = "content_animationpack_101_101chri"
		mcpack = "MotionPack_101Chri"
	end
	if style == 1 then
	else
		if use3d == true then
			set_chara_preload("content_chr_101063_101063001_model", "101063001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DMinimum_Preload(Christina, "Christina", 101063001)
	end
end

function setup_101064_Liam_preload(pos, pose, style, use3d, mcpath, mcpack)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if mcpath == nil then
		mcpath = "content_animationpack_101_101liam"
		mcpack = "MotionPack_101Liam"
	end
	if style == 1 then
	else
		if use3d == true then
			set_chara_preload("content_chr_101064_101064001_model", "101064001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DMinimum_Preload(Liam, "Liam", 101064001)
	end
end

function setup_101042_Moronoe_preload(pos, pose, style, use3d, mcpath, mcpack)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if mcpath == nil then
		mcpath = "content_animationpack__common"
		mcpack = "MotionPackBeta2"
	end
	if style == 1 then
	else
		if use3d == true then
			set_chara_preload("content_chr_101042_101042001_model", "101042001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DMinimum_Preload(Moronoe, "Moronoe", 101042001)
	end
end

function setup_101067_Ninian_preload(pos, pose, style, use3d, mcpath, mcpack)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if mcpath == nil then
		mcpath = "content_animationpack_101_101dina" --@todo ディナタンで代用
		mcpack = "MotionPack_101Dina"
	end
	if style == 1 then
	else
		if use3d == true then
			set_chara_preload("content_chr_101067_101067001_model", "101067001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
		else
		end
		character2DMinimum_Preload(Ninian, "Ninian", 101067001)
	end
end

function setup_MOB01_StudentB_preload(pos, pose, style, mcpath, mcpack)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	local label
	if mcpath == nil then
		mcpath = "content_animationpack_100_100mobm"
		mcpack = "MotionPack_100MobM"
	end
	if style == 1 then
		set_chara_preload("content_chr_401007_401007001_model", "401007001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	elseif style == 2 then
		set_chara_preload("content_chr_401009_401009001_model", "401009001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	else
		set_chara_preload("content_chr_401005_401005001_model", "401005001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	end
end

function setup_MOB01_StudentG_preload(pos, pose, style, mcpath, mcpack)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	local label
	if mcpath == nil then
		mcpath = "content_animationpack_100_100mobf"
		mcpack = "MotionPack_100MobF"
	end
	if style == 1 then
		set_chara_preload("content_chr_401008_401008001_model", "401008001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	elseif style == 2 then
		set_chara_preload("content_chr_401010_401010001_model", "401010001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	else
		set_chara_preload("content_chr_401006_401006001_model", "401006001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	end
end

function setup_MOB01_Soldier_preload(pos, pose, style, mcpath, mcpack)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	local label
	if mcpath == nil then
		mcpath = "content_animationpack_100_100mobm"
		mcpack = "MotionPack_100MobM"
	end
	if style == 1 then
		set_chara_preload("content_chr_401035_401035001_model", "401035001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	elseif style == 2 then
		set_chara_preload("content_chr_401038_401038001_model", "401038001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	elseif style == 3 then
		set_chara_preload("content_chr_401038_401038002_model", "401038002_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	elseif style == 4 then
		set_chara_preload("content_chr_401037_401037001_model", "401037001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	elseif style == 5 then
		set_chara_preload("content_chr_401040_401040001_model", "401040001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	elseif style == 6 then
		set_chara_preload("content_chr_401039_401039001_model", "401039001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	else
		set_chara_preload("content_chr_401036_401036001_model", "401036001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	end
end

function setup_MOB01_CitizenM_preload(pos, pose, style, mcpath, mcpack)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	local label
	if mcpath == nil then
		mcpath = "content_animationpack_100_100mobm"
		mcpack = "MotionPack_100MobM"
	end
	if style == 1 then
		set_chara_preload("content_chr_401013_401013001_model", "401013001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	elseif style == 2 then
		set_chara_preload("content_chr_401019_401019001_model", "401019001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	elseif style == 3 then
		set_chara_preload("content_chr_401021_401021001_model", "401021001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	else
		set_chara_preload("content_chr_401011_401011001_model", "401011001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	end
end

function setup_MOB01_CitizenF_preload(pos, pose, style, mcpath, mcpack)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	local label
	if mcpath == nil then
		mcpath = "content_animationpack_100_100mobf"
		mcpack = "MotionPack_100MobF"
	end
	if style == 1 then
		set_chara_preload("content_chr_401014_401014001_model", "401014001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	elseif style == 2 then
		set_chara_preload("content_chr_401020_401020001_model", "401020001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	elseif style == 3 then
		set_chara_preload("content_chr_401022_401022001_model", "401022001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	else
		set_chara_preload("content_chr_401012_401012001_model", "401012001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	end
end

function setup_MOB01_ChildM_preload(pos, pose, style, mcpath, mcpack)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	local label
	if mcpath == nil then
		mcpath = "content_animationpack_100_100chefc"
		mcpack = "MotionPack_100CheFC"
	end
	if style == 1 then
		set_chara_preload("content_chr_401017_401017001_model", "401017001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	else
		set_chara_preload("content_chr_401015_401015001_model", "401015001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	end
end

function setup_MOB01_ChildF_preload(pos, pose, style, mcpath, mcpack)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	local label
	if mcpath == nil then
		mcpath = "content_animationpack_100_100chefc"
		mcpack = "MotionPack_100CheFC"
	end
	if style == 1 then
		set_chara_preload("content_chr_401018_401018001_model", "401018001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	else
		set_chara_preload("content_chr_401016_401016001_model", "401016001_Model", mcpath, mcpack, "content_animationpack__common", "FacialPack", pos, pose, "Normal")
	end
end

function setup_Area110041_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if env == 11 then
		load_area_scene_preload(110041)
	elseif env == 12 then
		load_area_scene_preload(115042)
	elseif env == 13 then
		load_area_scene_preload(115043)
	elseif env == 21 then
		load_area_scene_preload(110041)
	elseif env == 22 then
		load_area_scene_preload(115042)
	elseif env == 23 then
		load_area_scene_preload(115043)
	elseif env == 31 then
		load_area_scene_preload(115044)
	elseif env == 32 then
		load_area_scene_preload(115045)
	elseif env == 33 then
		load_area_scene_preload(115046)
	else
		load_area_scene_preload(110041)
	end
end

function setup_Area112021_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if env == 1 then
		load_area_scene_preload(112021)
	elseif env == 2 then
		load_area_scene_preload(112021)
	elseif env == 3 then
		load_area_scene_preload(116024)
	elseif env == 41 then
		load_area_scene_preload(116027)
	else
		load_area_scene_preload(112021)
	end
end

