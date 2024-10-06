Include("content_luascript_common","ADVSmallPack")
Include("content_luascript__sample", "Characters_h")

-- アセットなどを読み込む
function Load()
	manager = CreateAdvSmallManager()
	
    demo_setup_nofade()
    
    commu = get_commu() -- 実行中コミュ
    commuChara = commu.GetCharacter()

    local characterId = commuChara.CharacterID .. ""
    local styleId = commuChara.StyleID .. ""
    
    local character = characters[characterId]
    local position = {2.229,0.000,1.360,257.000} -- スクリプトで指定
    InitializeCharacter(characterId, styleId, character.labelChara, position, character.facialId, character.animationController)
    
	Talker = get_chara("Dinatan")
	Player = get_chara("Player")
end

-- シーケンスの実行
function Play()

    demo_start_nofade()

    show_current_script()
    
    open_narration_window()
        message_direct("β3コミュテスト/ディナタン")
        message_direct("サンプルスクリプト<color=\"red\"> CommuNormal </color>です。")
    close_narration_window()
    
	CO_101012_00_start()	-- 導入会話
	
	-- ランクアップ示唆
    local hintText = commu.GetRankupHintText()
    
    open_narration_window()
        message_direct(hintText) -- ランクアップ示唆
        
        message_direct("コミュしますか？")
    close_narration_window()
    
    -- 確認
	open_select_window_direct(Player, "Normal", "はい", "いいえ")

	if is_select(1) then
		CO_101012_00_execute() -- ロケーション選択
		CO_101012_00_location()
	elseif is_select(2) then
		-- いいえ
		CO_101012_00_stop()	-- 断る
		system.Cancel()
	else
		-- 例外処理
		system.Cancel()
	end

    demo_end_nofade()
end


function get_commu()
    return system.GetCommu()
end


function CO_101012_00_start()

	open_speech_window("CHRNAME_DINATAN", Talker, nil)
	message_direct("兄さんどうしたの？")
	close_speech_window()
end
function CO_101012_00_location()

	open_speech_window("CHRNAME_DINATAN", Talker, nil)
	message_direct("うん、兄さんについてくよ")
	close_speech_window()
end

function CO_101012_00_stop()

	open_speech_window("PLAYERNAME_NOIR", Player, nil)
	message_direct("コミュ中断します")
	close_speech_window()

end

function CO_101012_00_execute()
    
    local locations = commu.GetLocations()
    
    local location = open_communication_place_window(locations, "---")  -- 仮UIとしてmenu流用
    
    system.SelectMenuItem(location.ID)
    
end

function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
    local characterId = commuChara.CharacterID .. ""
    local styleId = commuChara.StyleID .. ""
    local character = characters[characterId]
    local position = {2.229,0.000,1.360,257.000} -- スクリプトで指定
    InitializeCharacter_Preload(characterId, styleId, character.labelChara, position, character.facialId, character.animationController)
	get_chara_preload("Dinatan")
	get_chara_preload("Player")
end
