----------------------------------------------------------------------------------------------------
-- β1版　施設利用・メイン：読書
-- ステージ：酒場
-- 登場キャラ：ノワール
-- 処理フロー：https://confluence.gu3.jp/pages/viewpage.action?pageId=181437973
-- スクリプト作成者：中嶋(悠)
----------------------------------------------------------------------------------------------------

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")

-- アセットなどを読み込む
function Load()
	demo_setup()
	Load_Main_Scene()
end

-- シーケンスの実行
function Play()
	demo_start()

	debug_print("★play start")

	local info = system.GetStoryMainQuestReadBookObject()

	debug_print("★readbook info")
	
	
	-- 導入会話
	AC_01_000003_Inst_start()

	-- 本の所持チェック
	if info.HaveReadableBook == true then

		-- 本を読む/読まない
		open_select_window_direct(Noir, "Normal", "本を読む", "今はやめておく")

		if is_select(1) then
			-- 読む
		else
			-- 読まない
			AC_01_000003_Inst_cancel()
    		system.Cancel()
	    	demo_end()
			return -- 終了
		end

	else
		AC_01_000003_Inst_nobook()
		system.Cancel()	-- 読める本を持っていないので終了
		demo_end()
        return -- 終了
	end

	-- 本一覧を表示
	local menuItems = info.GetUserBooks()
	local item = open_menu_window(menuItems, "読んだ回数")

	-- 選んだ本を保存
	system.SelectMenuItem(item.ID)

	--本効果テキスト
	open_narration_window()
	message(item.Description)
	close_narration_window()

	if item.Read == true then
		-- 読了
		AC_01_000003_Main_finish()
		-- リザルト演出
		open_parameter_up(item.GetHumanParam())
	else
		-- 未読了
		AC_01_000003_Main_unfinish()
	end

	-- 終了
	AC_01_000003_Main_end()

	demo_end()
end

-- 導入
function Load_Inst_Scene()

	Noir = get_chara("Player")
	character2D(Noir, "Noir", "content_unit_101000102", "101000102_UnitFace", "101000102_UnitCutin", "101000102_UnitThumb", "101000102_UnitImage_Full", "101000102_UnitImage_HiRes")
	motion(Noir, "Sri_Std_loop_m", 0.3, 1.0, true)
end

function AC_01_000003_Inst_start()

	change_face(Noir, "Normal")
	open_mind_window("PLAYERNAME_NOIR", Noir, nil)
		message_direct("ここで本が読めそうだな。")
	close_mind_window()

	open_narration_window()
		--message_direct("ここで読書することで、ノワールの<br>人間パラメータがアップします。")
		message_direct("ここで読書をし、読破することで<br>人間パラメータがアップします。")
		message_direct("獲得できる人間パラメータは<br>本の種類によって変わります。")
	close_narration_window()

end

function AC_01_000003_Inst_cancel()

	change_face(Noir, "Normal")
	open_mind_window("PLAYERNAME_NOIR", Noir, nil)
		message_direct("今はいいか。")
	close_mind_window()

end

function AC_01_000003_Inst_nobook()

	change_face(Noir, "Normal")
	open_mind_window("PLAYERNAME_NOIR", Noir, nil)
		message_direct("読むことのできる本を<br>持っていないようだ。")
		message_direct("またにしよう。")
	close_mind_window()

end



-- 本編

function Load_Main_Scene()

	debug_print("★load start")

	load_scene("content_areascene_110011", "Area110011") -- ノワール教室：夕晴

	debug_print("★load_scene")

	--Noir		= set_chara("content_unit_200010101_model", "Model200010101", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack", -3.715695, 0.06, -4.960591, 90, "Sit_study_loop_Chr_002_01", "Normal")
	Noir = set_chara("content_chr_101009_101009002_model", "101009002_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Sri_Std_loop_m", "Normal")
	character2D(Noir, "Noir", "content_chr_101009_101009002_face", "101009002_UnitFace", nil, nil, nil, nil)
	character2D(Noir, "Noir", "content_chr_101009_default_cutin", nil, "101009_UnitCutin", nil, nil, nil)
	character2D(Noir, "Noir", "content_chr_101009_101009002_thumb", nil, nil, "101009002_UnitThumb", nil, nil)
	character2D(Noir, "Noir", "content_chr_101009_101009002_full", nil, nil, nil, "101009002_UnitImage_Full", nil)
	character2D(Noir, "Noir", "content_chr_101009_101009002_hires", nil, nil, nil, nil, "101009002_UnitImage_HiRes")

	debug_print("★character2D")

--[[
	Emo_Angry01_Lop		= set_object("effects_emotion", "Ef_C_Emo_Angry01_Lop", false)
	Emo_Excl01		= set_object("effects_emotion", "Ef_C_Emo_Excl01", false)
	Emo_FelUp01		= set_object("effects_emotion", "Ef_C_Emo_FelUp01", false)
	Emo_FelUp02		= set_object("effects_emotion", "Ef_C_Emo_FelUp02", false)
	Emo_FelUp03		= set_object("effects_emotion", "Ef_C_Emo_FelUp03", false)
	Emo_Heart01		= set_object("effects_emotion", "Ef_C_Emo_Heart01", false)
	Emo_Moya01_Lop		= set_object("effects_emotion", "Ef_C_Emo_Moya01_Lop", false)
	Emo_Que01		= set_object("effects_emotion", "Ef_C_Emo_Que01", false)
	Emo_Sleep01_Lop		= set_object("effects_emotion", "Ef_C_Emo_Sleep01_Lop", false)
	Emo_StUP01		= set_object("effects_emotion", "Ef_C_Emo_StUP01", false)
	Emo_StUP02		= set_object("effects_emotion", "Ef_C_Emo_StUP02", false)
	Emo_StUP03		= set_object("effects_emotion", "Ef_C_Emo_StUP03", false)
	Emo_Sweat01		= set_object("effects_emotion", "Ef_C_Emo_Sweat01", false)
	Emo_Upset01__Lop	= set_object("effects_emotion", "Ef_C_Emo_Upset01__Lop", false)
	Emo_Waiwai01_Lop	= set_object("effects_emotion", "Ef_C_Emo_Waiwai01_Lop", false)
]]

	-- カメラ設定
	--MAIN_CAMERA = set_camera(-1.827, 1.506, -2.397, 9.969, -152.709, 0, 21)
	MAIN_CAMERA = set_camera(-4.8, 1.65, -6.5, 9, 37, 0, 21)

	on_camera(MAIN_CAMERA)
	debug_print("★set_camera")
end

function AC_01_000003_Main_finish()

	change_face(Noir, "Normal")
	open_mind_window("PLAYERNAME_NOIR", Noir, nil)
		message_direct("…これでこの本は読み切ったようだ。<br>興味深い内容ばかりだった。")
		message_direct("次読む本も楽しみだ。")
	close_mind_window()

end

function AC_01_000003_Main_unfinish()

	change_face(Noir, "Normal")
	open_mind_window("PLAYERNAME_NOIR", Noir, nil)
		message_direct("読み切るまでにはもう少し掛かりそうだ。<br>この続きはまた今度読もう。")
	close_mind_window()

end

function AC_01_000003_Main_end()

	change_face(Noir, "Normal")
	open_mind_window("PLAYERNAME_NOIR", Noir, nil)
		message_direct("一旦、このくらいにしておくか。<br>次はいつ読もうかな。")
	close_mind_window()

end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
end
