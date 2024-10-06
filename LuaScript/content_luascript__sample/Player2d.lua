-- MA_01104_110
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")

function Load()
	Load_common(true)

	init_psbattleadv("201150000", "201150000")
	change_time_and_weather(BattleTime_Sunset , BattleWeather_Shiny)

	pbadv_setup_101009_Noir(0,true, 20, 23,0) --ノワール
	pbadv_setup_101012_Dinatan(0,true, 22, 14,0)  --ディナタン
	pbadv_setup_101001_Tyrfing(1,true, 20, 29,0)  --ティルフィング（キラーズ）

	testpattern()

	local layer = 0

	-- 現代編主人公の設定
	pbadv_setup_player(19,24,layer)

	setup_complete_unit()

	dot_change_anim(dotDinatan, 1)

	change_camera_distance(8.0, 0.0)
	
	change_camera_angle(25.0, 0.0)
	
	move_camera(20, 24, 0.0)

	load_sound("BGM_Battle_Running")
	
	
end

function Play()
	Play_start(true)
	fadein(0)


	-- @ノワール	おまえッッ！！！！	
	change_face(Noir, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir, nil)
	message_direct("主人公テスト")
	close_speech_window()

	local testmessage

	playerStyleId = get_player_styleId()

	if playerStyleId == 101003001 then
		testmessage = "男性1の人は地味茶男"
	elseif playerStyleId == 101004001 then
		testmessage = "女性1の人は地味茶女"
	elseif playerStyleId == 101005001 then
		testmessage = "男性2の人は派手茶男"
	elseif playerStyleId == 101006001 then
		testmessage = "女性2の人は派手茶女"
	elseif playerStyleId == 101007001 then
		testmessage = "男性3の人は水色男"
	elseif playerStyleId == 101008001 then
		testmessage = "女性3の人は水色女"
	end


	change_face(playerFace, "Surprise")
	open_speech_window("PLAYERNAME_GENDAI", playerFace, nil)
	PlayPartVoiceDirect("Player","0015")
	message_direct(testmessage)
	close_speech_window()

	dot_move_unit_seq(playerDot, 21, 24)
	wait_seq()

	dot_move_unit_seq(playerDot, 19, 24)
	wait_seq()

	dot_unit_dir(playerDot,3)


	change_face(Tyrfing1, "Anger")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message_direct("おわりです")
	close_speech_window()


	Play_end(true)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(0,true, 20, 23,0)
	pbadv_setup_101012_Dinatan_preload(0,true, 22, 14,0)
	pbadv_setup_101001_Tyrfing_preload(1,true, 20, 29,0)
	preload_sound("BGM_Battle_Running")
end

function Talktest(controllerId, talkerNameTag, frameType, dir, textId)
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
	message_direct(textId)
	-- 本番用
    --message(textId)

	-- しゃべった人のモーションを戻す
	animator_default_motion_if_need(lastTalkControllerId)
end

function testpattern()
	local layer = 0
	playerStyleId = 101003001
	pl1Face = setup_player_2d(playerStyleId)
	pl1Dot = setup_player_dot(playerStyleId,15,21,layer)

	playerStyleId = 101004001
	pl2Face = setup_player_2d(playerStyleId)
	pl2Dot = setup_player_dot(playerStyleId,17,21,layer)

	playerStyleId = 101005001
	pl3Face = setup_player_2d(playerStyleId)
	pl3Dot = setup_player_dot(playerStyleId,19,21,layer)

	playerStyleId = 101006001
	pl4Face = setup_player_2d(playerStyleId)
	pl4Dot = setup_player_dot(playerStyleId,21,21,layer)

	playerStyleId = 101007001
	pl5Face = setup_player_2d(playerStyleId)
	pl5Dot = setup_player_dot(playerStyleId,23,21,layer)

	playerStyleId = 101008001
	pl6Face = setup_player_2d(playerStyleId)
	pl6Dot = setup_player_dot(playerStyleId,25,21,layer)
end